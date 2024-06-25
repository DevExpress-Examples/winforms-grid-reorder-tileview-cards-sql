<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/518130311/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1105093)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WinForms Data Grid - How to avoid data conflicts when users drag cards of a TileView connected to a SQL source

When you drag-and-drop cards of a TileView connected to a SQL data source, a record index collision may occur. Moving a card marks the data source record as "to be removed", and a new record (with an updated data source index) is created instead. The previous record is not removed. As a result, the data row is duplicated.

This example shows how to avoid this issue. Create a column in the data source to store the position of cards within their groups. Update the position of a card every time the user drags the card.

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

```vb
' Sort by the "IndexInGroup" column
colIndexInGroup.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

AddHandler tileView1.BeforeItemDrop, AddressOf TileView1_BeforeItemDrop

Private Sub TileView1_BeforeItemDrop(ByVal sender As Object, ByVal e As BeforeItemDropEventArgs)
    e.Handled = True
    ' Leave data source indexes as is
    e.NewListSourceRowIndex = e.ListSourceRowIndex

    Dim view = TryCast(sender, TileView)
    Dim column = view.Columns("IndexInGroup")

      Assign new IndexInGroup column values for all cards
     that are already in the target group 
    If e.NewGroupRowHandle <> GridControl.InvalidRowHandle Then
        Dim childRowCount As Integer = view.GetChildRowCount(e.NewGroupRowHandle)
        For n As Integer = 0 To childRowCount - 1
            Dim rowHandle As Integer = view.GetChildRowHandle(e.NewGroupRowHandle, n)
            ' Skip the TargetIndexInGroup - this index must belong to the dragged card
            Dim index As Integer = If(n >= e.TargetIndexInGroup, n + 1, n)
            view.SetRowCellValue(rowHandle, column, index)
        Next n
    End If

    ' Assign the TargetIndexInGroup value to the "IndexInGroup" cell of the dragged card
    view.SetRowCellValue(e.RowHandle, column, e.TargetIndexInGroup)
    ' Assign the new "colGroupId" column value to the dragged card
    view.SetRowCellValue(e.RowHandle, view.ColumnSet.GroupColumn, e.NewGroupColumnValue)
End Sub
```


## Files to Review

- [Form1.cs](./CS/Reorder/Form1.cs) (VB: [Form1.vb](./VB/Reorder/Form1.vb))


## Documentation

- [Tile View](https://docs.devexpress.com/WindowsForms/114728/controls-and-libraries/data-grid/views/tile-view)
- [OptionsDrag property](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Tile.TileView.OptionsDragDrop)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-reorder-tileview-cards-sql&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-reorder-tileview-cards-sql&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
