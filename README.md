# WinForms Data Grid - How To Create a Sortable Column for TileView

When you drag-and-drop cards of a TileView connected to a SQL source, a record index collision may occur: moving a card marks the data source record as "to be removed", and a new record (with an updated data source index) is created instead. However, the previous record is not removed, and as a result, the data row is duplicated.

To overcome this issue, create a data source column that will store card positions within their groups, and update these values whenever a user drags a card.

```cs
// Sort by the "IndexInGroup" column
colIndexInGroup.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
tileView1.BeforeItemDrop += TileView1_BeforeItemDrop;

void TileView1_BeforeItemDrop(object sender, BeforeItemDropEventArgs e) {
    e.Handled = true;
    // Leave data source indexes as is
    e.NewListSourceRowIndex = e.ListSourceRowIndex;

    var view = sender as TileView;
    var column = view.Columns["IndexInGroup"];

    /* Assign new IndexInGroup column values for all cards
    that are already in the target group */
    if(e.NewGroupRowHandle != GridControl.InvalidRowHandle) {
        int childRowCount = view.GetChildRowCount(e.NewGroupRowHandle);
        for(int n = 0; n < childRowCount; n++) {
            int rowHandle = view.GetChildRowHandle(e.NewGroupRowHandle, n);
            // Skip the TargetIndexInGroup - this index must belong to the dragged card
            int index = n >= e.TargetIndexInGroup ? n + 1 : n;
            view.SetRowCellValue(rowHandle, column, index);
        }
    }

    // Assign the TargetIndexInGroup value to the "IndexInGroup" cell of the dragged card
    view.SetRowCellValue(e.RowHandle, column, e.TargetIndexInGroup);
    // Assign the new "colGroupId" column value to the dragged card
    view.SetRowCellValue(e.RowHandle, view.ColumnSet.GroupColumn, e.NewGroupColumnValue);
}
```

## Files to Look At

- [Form1.cs](./CS/Reorder/Form1.cs) (VB: [Form1.vb](./VB/Reorder/Form1.vb))

## Documentation

- [Tile View](https://docs.devexpress.com/WindowsForms/114728/controls-and-libraries/data-grid/views/tile-view)
- [OptionsDrag property](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Tile.TileView.OptionsDragDrop)