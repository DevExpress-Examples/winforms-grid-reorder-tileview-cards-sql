Namespace Reorder
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim tableColumnDefinition1 As New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition1 As New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement1 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colIndexInGroup = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colGroupId = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.toolbarFormControl1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
            Me.toolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.skinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
            Me.skinPaletteDropDownButtonItem1 = New DevExpress.XtraBars.SkinPaletteDropDownButtonItem()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tileView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.toolbarFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.toolbarFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colText
            ' 
            Me.colText.Caption = "Text"
            Me.colText.FieldName = "Text"
            Me.colText.MinWidth = 45
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 0
            Me.colText.Width = 168
            ' 
            ' colIndexInGroup
            ' 
            Me.colIndexInGroup.Caption = "IndexInGroup"
            Me.colIndexInGroup.FieldName = "IndexInGroup"
            Me.colIndexInGroup.MinWidth = 45
            Me.colIndexInGroup.Name = "colIndexInGroup"
            Me.colIndexInGroup.Visible = True
            Me.colIndexInGroup.VisibleIndex = 2
            Me.colIndexInGroup.Width = 168
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
            Me.gridControl1.Location = New System.Drawing.Point(0, 46)
            Me.gridControl1.MainView = Me.tileView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(1302, 555)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.tileView1})
            ' 
            ' tileView1
            ' 
            Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colText, Me.colGroupId, Me.colIndexInGroup})
            Me.tileView1.ColumnSet.GroupColumn = Me.colGroupId
            Me.tileView1.DetailHeight = 766
            Me.tileView1.GridControl = Me.gridControl1
            Me.tileView1.Name = "tileView1"
            Me.tileView1.OptionsDragDrop.AllowDrag = True
            Me.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban
            Me.tileView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGroupId, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.tileView1.TileColumns.Add(tableColumnDefinition1)
            Me.tileView1.TileRows.Add(tableRowDefinition1)
            Me.tileView1.TileRows.Add(tableRowDefinition2)
            Me.tileView1.TileRows.Add(tableRowDefinition3)
            tileViewItemElement1.Appearance.Normal.FontSizeDelta = 3
            tileViewItemElement1.Appearance.Normal.Options.UseFont = True
            tileViewItemElement1.Column = Me.colText
            tileViewItemElement1.Text = "colText"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
            tileViewItemElement2.AnchorElementIndex = 2
            tileViewItemElement2.Column = Me.colIndexInGroup
            tileViewItemElement2.RowIndex = 2
            tileViewItemElement2.Text = "colIndexInGroup"
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
            tileViewItemElement3.RowIndex = 2
            tileViewItemElement3.Text = "Index in group:"
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            Me.tileView1.TileTemplate.Add(tileViewItemElement1)
            Me.tileView1.TileTemplate.Add(tileViewItemElement2)
            Me.tileView1.TileTemplate.Add(tileViewItemElement3)
            ' 
            ' colGroupId
            ' 
            Me.colGroupId.Caption = "GroupId"
            Me.colGroupId.FieldName = "GroupId"
            Me.colGroupId.MinWidth = 45
            Me.colGroupId.Name = "colGroupId"
            Me.colGroupId.Visible = True
            Me.colGroupId.VisibleIndex = 1
            Me.colGroupId.Width = 168
            ' 
            ' toolbarFormControl1
            ' 
            Me.toolbarFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.toolbarFormControl1.Manager = Me.toolbarFormManager1
            Me.toolbarFormControl1.Name = "toolbarFormControl1"
            Me.toolbarFormControl1.Size = New System.Drawing.Size(1302, 46)
            Me.toolbarFormControl1.TabIndex = 1
            Me.toolbarFormControl1.TabStop = False
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.skinDropDownButtonItem1)
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.skinPaletteDropDownButtonItem1)
            Me.toolbarFormControl1.ToolbarForm = Me
            ' 
            ' toolbarFormManager1
            ' 
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlTop)
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlRight)
            Me.toolbarFormManager1.Form = Me
            Me.toolbarFormManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.skinDropDownButtonItem1, Me.skinPaletteDropDownButtonItem1})
            Me.toolbarFormManager1.MaxItemId = 2
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 46)
            Me.barDockControlTop.Manager = Me.toolbarFormManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(1302, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
            Me.barDockControlBottom.Manager = Me.toolbarFormManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(1302, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
            Me.barDockControlLeft.Manager = Me.toolbarFormManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 555)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1302, 46)
            Me.barDockControlRight.Manager = Me.toolbarFormManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 555)
            ' 
            ' skinDropDownButtonItem1
            ' 
            Me.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.skinDropDownButtonItem1.Id = 0
            Me.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1"
            ' 
            ' skinPaletteDropDownButtonItem1
            ' 
            Me.skinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.skinPaletteDropDownButtonItem1.Id = 1
            Me.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 19F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1302, 601)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Controls.Add(Me.toolbarFormControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Form1"
            Me.Text = "How to Implement a Sortable Column"
            Me.ToolbarFormControl = Me.toolbarFormControl1
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tileView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.toolbarFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.toolbarFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView
        Private colText As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colGroupId As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colIndexInGroup As DevExpress.XtraGrid.Columns.TileViewColumn
        Private toolbarFormControl1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl
        Private toolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private skinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
        Private skinPaletteDropDownButtonItem1 As DevExpress.XtraBars.SkinPaletteDropDownButtonItem
    End Class
End Namespace

