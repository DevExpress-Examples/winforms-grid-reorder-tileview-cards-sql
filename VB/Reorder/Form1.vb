Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Tile
Imports System.Windows.Forms

Namespace Reorder
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.ToolbarForm.ToolbarForm

        Public Sub New()
            InitializeComponent()

            tileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {.Caption = "Group 0", .GroupValue = 0})
            tileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {.Caption = "Group 1", .GroupValue = 1})
            tileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {.Caption = "Group 2", .GroupValue = 2})
            tileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {.Caption = "Group 3", .GroupValue = 3})

            ' Sort by the "IndexInGroup" column
            colIndexInGroup.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            gridControl1.DataSource = DataHelper.GetData()

            AddHandler tileView1.BeforeItemDrop, AddressOf TileView1_BeforeItemDrop
        End Sub

        Private Sub TileView1_BeforeItemDrop(ByVal sender As Object, ByVal e As BeforeItemDropEventArgs)
            e.Handled = True
            ' Leave data source indexes as is
            e.NewListSourceRowIndex = e.ListSourceRowIndex

            Dim view = TryCast(sender, TileView)
            Dim column = view.Columns("IndexInGroup")

'             Assign new IndexInGroup column values for all cards
'            that are already in the target group 
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
    End Class
End Namespace
