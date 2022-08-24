<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListUsersView
    Inherits BaseSRCSModule

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListUsersView))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl11 = New DevExpress.XtraGrid.GridControl()
        Me.UserLogTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New SRCSv3._1.dbDataSet()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colu_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colu_name1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusertype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.WindowsUIButtonPanel11 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem13 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.UserTableTableAdapter = New SRCSv3._1.dbDataSetTableAdapters.userTableTableAdapter()
        Me.UserLogTableTableAdapter = New SRCSv3._1.dbDataSetTableAdapters.userLogTableTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLogTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl11)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl11)
        Me.LayoutControl1.Controls.Add(Me.WindowsUIButtonPanel11)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-8, -8, 1382, 784)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(832, 424)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl11
        '
        Me.GridControl11.DataSource = Me.UserLogTableBindingSource
        Me.GridControl11.Location = New System.Drawing.Point(421, 225)
        Me.GridControl11.MainView = Me.GridView11
        Me.GridControl11.Name = "GridControl11"
        Me.GridControl11.Size = New System.Drawing.Size(360, 529)
        Me.GridControl11.TabIndex = 11
        Me.GridControl11.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView11})
        '
        'UserLogTableBindingSource
        '
        Me.UserLogTableBindingSource.DataMember = "userLogTable"
        Me.UserLogTableBindingSource.DataSource = Me.DbDataSet
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView11
        '
        Me.GridView11.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView11.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView11.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView11.Appearance.Row.Options.UseFont = True
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colu_name, Me.coldte, Me.coltme, Me.colID})
        Me.GridView11.GridControl = Me.GridControl11
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsBehavior.ReadOnly = True
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colu_name
        '
        Me.colu_name.Caption = "User"
        Me.colu_name.FieldName = "u_name"
        Me.colu_name.Name = "colu_name"
        Me.colu_name.Visible = True
        Me.colu_name.VisibleIndex = 0
        '
        'coldte
        '
        Me.coldte.Caption = "Date of Login"
        Me.coldte.FieldName = "dte"
        Me.coldte.Name = "coldte"
        Me.coldte.Visible = True
        Me.coldte.VisibleIndex = 1
        '
        'coltme
        '
        Me.coltme.Caption = "Time of Login"
        Me.coltme.FieldName = "tme"
        Me.coltme.Name = "coltme"
        Me.coltme.Visible = True
        Me.coltme.VisibleIndex = 2
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.UserTableBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(34, 229)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(349, 525)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "userTable"
        Me.UserTableBindingSource.DataSource = Me.DbDataSet
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colu_name1, Me.colFullname, Me.colusertype, Me.GridColumn11})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.EnableDetailToolTip = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colu_name1
        '
        Me.colu_name1.Caption = "Username:"
        Me.colu_name1.FieldName = "username"
        Me.colu_name1.Name = "colu_name1"
        Me.colu_name1.Visible = True
        Me.colu_name1.VisibleIndex = 1
        '
        'colFullname
        '
        Me.colFullname.Caption = "Full name:"
        Me.colFullname.FieldName = "fullName"
        Me.colFullname.Name = "colFullname"
        Me.colFullname.Visible = True
        Me.colFullname.VisibleIndex = 0
        '
        'colusertype
        '
        Me.colusertype.Caption = "User type:"
        Me.colusertype.FieldName = "usertype"
        Me.colusertype.Name = "colusertype"
        Me.colusertype.Visible = True
        Me.colusertype.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "GridColumn1"
        Me.GridColumn11.FieldName = "guid"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl11.ImageOptions.Image = CType(resources.GetObject("LabelControl11.ImageOptions.Image"), System.Drawing.Image)
        Me.LabelControl11.Location = New System.Drawing.Point(34, 189)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(170, 36)
        Me.LabelControl11.StyleController = Me.LayoutControl1
        Me.LabelControl11.TabIndex = 13
        Me.LabelControl11.Text = "List of all Users:"
        '
        'WindowsUIButtonPanel11
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.Image = CType(resources.GetObject("WindowsUIButtonImageOptions2.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions3.Image = CType(resources.GetObject("WindowsUIButtonImageOptions3.Image"), System.Drawing.Image)
        Me.WindowsUIButtonPanel11.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Add", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Edit", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Delete", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel11.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.WindowsUIButtonPanel11.Location = New System.Drawing.Point(24, 104)
        Me.WindowsUIButtonPanel11.Name = "WindowsUIButtonPanel11"
        Me.WindowsUIButtonPanel11.Size = New System.Drawing.Size(767, 47)
        Me.WindowsUIButtonPanel11.TabIndex = 18
        Me.WindowsUIButtonPanel11.UseButtonBackgroundImages = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Root1, Me.LayoutControlGroup3, Me.SimpleLabelItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(815, 788)
        Me.Root.TextVisible = False
        '
        'Root1
        '
        Me.Root1.CustomizationFormText = "Root"
        Me.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root1.GroupBordersVisible = False
        Me.Root1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem13, Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        Me.Root1.Location = New System.Drawing.Point(0, 155)
        Me.Root1.Name = "Root1"
        Me.Root1.OptionsItemText.TextToControlDistance = 3
        Me.Root1.Size = New System.Drawing.Size(795, 613)
        Me.Root1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root1.Text = "Root"
        Me.Root1.TextVisible = False
        '
        'EmptySpaceItem13
        '
        Me.EmptySpaceItem13.AllowHotTrack = False
        Me.EmptySpaceItem13.CustomizationFormText = "EmptySpaceItem13"
        Me.EmptySpaceItem13.Location = New System.Drawing.Point(377, 0)
        Me.EmptySpaceItem13.MaxSize = New System.Drawing.Size(10, 593)
        Me.EmptySpaceItem13.MinSize = New System.Drawing.Size(10, 593)
        Me.EmptySpaceItem13.Name = "EmptySpaceItem13"
        Me.EmptySpaceItem13.Size = New System.Drawing.Size(10, 593)
        Me.EmptySpaceItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem13.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem10, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(377, 593)
        Me.LayoutControlGroup1.Text = "List all Users"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.LabelControl11
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(174, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.GridControl2
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(353, 529)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(174, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(179, 40)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SimpleLabelItem1, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(387, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(388, 593)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.CustomizationFormText = "User Log"
        Me.SimpleLabelItem1.ImageOptions.Image = CType(resources.GetObject("SimpleLabelItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(364, 36)
        Me.SimpleLabelItem1.Text = "User Log history:"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(198, 32)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridControl11
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(364, 533)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(795, 75)
        Me.LayoutControlGroup3.TextVisible = False
        Me.LayoutControlGroup3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.WindowsUIButtonPanel11
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(771, 51)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'SimpleLabelItem2
        '
        Me.SimpleLabelItem2.AllowHotTrack = False
        Me.SimpleLabelItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.SimpleLabelItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gray
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem2.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopCenter
        Me.SimpleLabelItem2.ImageOptions.Image = CType(resources.GetObject("SimpleLabelItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(795, 80)
        Me.SimpleLabelItem2.Text = "User Manager"
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(198, 76)
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'UserLogTableTableAdapter
        '
        Me.UserLogTableTableAdapter.ClearBeforeFill = True
        '
        'ListUsersView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ListUsersView"
        Me.Size = New System.Drawing.Size(832, 424)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLogTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl11 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colu_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colu_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusertype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WindowsUIButtonPanel11 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents Root1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem13 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents UserTableBindingSource As BindingSource
    Friend WithEvents UserTableTableAdapter As dbDataSetTableAdapters.userTableTableAdapter
    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents UserLogTableBindingSource As BindingSource
    Friend WithEvents UserLogTableTableAdapter As dbDataSetTableAdapters.userLogTableTableAdapter
End Class
