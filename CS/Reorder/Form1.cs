using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Tile;
using System.Windows.Forms;

namespace Reorder {
    public partial class Form1 : DevExpress.XtraBars.ToolbarForm.ToolbarForm {
        public Form1() {
            InitializeComponent();

            tileView1.OptionsKanban.Groups.Add(new KanbanGroup() { Caption = "Group 0", GroupValue = 0 });
            tileView1.OptionsKanban.Groups.Add(new KanbanGroup() { Caption = "Group 1", GroupValue = 1 });
            tileView1.OptionsKanban.Groups.Add(new KanbanGroup() { Caption = "Group 2", GroupValue = 2 });
            tileView1.OptionsKanban.Groups.Add(new KanbanGroup() { Caption = "Group 3", GroupValue = 3 });

            // Sort by the "IndexInGroup" column
            colIndexInGroup.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridControl1.DataSource = DataHelper.GetData();

            tileView1.BeforeItemDrop += TileView1_BeforeItemDrop;
        }

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
    }
}
