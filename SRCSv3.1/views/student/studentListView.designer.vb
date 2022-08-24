<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentListView
    Inherits BaseSRCSModule

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentListView))
        Dim WindowsUIButtonImageOptions6 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions7 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions8 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.addEditScoreButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.cmbSchYear = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbTerm = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbClass = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.StudentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New SRCSv3._1.dbDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colschYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterm1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgrNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstdID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsurname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colotherNames = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltermOfAdmission = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colyearOfAdmission = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colguardianName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcurrentClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colclassOfAdmission = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpreviousSchAttended = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstudentPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstudentEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnationality = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldisability = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReligion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstateOfOrigin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colentranceExamScore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassportPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.colstaff_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgradeRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotalscore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexamscore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colacadyr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsecondass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsecondca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StudentTableTableAdapter = New SRCSv3._1.dbDataSetTableAdapters.studentTableTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cmbSchYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.addEditScoreButtonPanel)
        Me.LayoutControl1.Controls.Add(Me.cmbSchYear)
        Me.LayoutControl1.Controls.Add(Me.cmbTerm)
        Me.LayoutControl1.Controls.Add(Me.cmbClass)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(360, 292, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(755, 531)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'addEditScoreButtonPanel
        '
        WindowsUIButtonImageOptions5.Image = CType(resources.GetObject("WindowsUIButtonImageOptions5.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions6.Image = CType(resources.GetObject("WindowsUIButtonImageOptions6.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions7.Image = CType(resources.GetObject("WindowsUIButtonImageOptions7.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions8.Image = CType(resources.GetObject("WindowsUIButtonImageOptions8.Image"), System.Drawing.Image)
        Me.addEditScoreButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Edit Highlighted student", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Add", True, WindowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Add Student (Ctri + N)", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Delete highligted student", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Select", True, WindowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "Select multiple students", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.addEditScoreButtonPanel.Location = New System.Drawing.Point(516, 64)
        Me.addEditScoreButtonPanel.Name = "addEditScoreButtonPanel"
        Me.addEditScoreButtonPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.addEditScoreButtonPanel.Size = New System.Drawing.Size(33, 445)
        Me.addEditScoreButtonPanel.TabIndex = 8
        Me.addEditScoreButtonPanel.UseButtonBackgroundImages = False
        '
        'cmbSchYear
        '
        Me.cmbSchYear.Location = New System.Drawing.Point(103, 14)
        Me.cmbSchYear.Name = "cmbSchYear"
        Me.cmbSchYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSchYear.Size = New System.Drawing.Size(150, 32)
        Me.cmbSchYear.StyleController = Me.LayoutControl1
        Me.cmbSchYear.TabIndex = 7
        '
        'cmbTerm
        '
        Me.cmbTerm.Location = New System.Drawing.Point(348, 14)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTerm.Size = New System.Drawing.Size(150, 32)
        Me.cmbTerm.StyleController = Me.LayoutControl1
        Me.cmbTerm.TabIndex = 6
        '
        'cmbClass
        '
        Me.cmbClass.Location = New System.Drawing.Point(593, 14)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbClass.Size = New System.Drawing.Size(150, 32)
        Me.cmbClass.StyleController = Me.LayoutControl1
        Me.cmbClass.TabIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.StudentTableBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.ImageIndex = 10
        Me.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.GridControl1.Location = New System.Drawing.Point(198, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2})
        Me.GridControl1.Size = New System.Drawing.Size(314, 445)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StudentTableBindingSource
        '
        Me.StudentTableBindingSource.DataMember = "studentTable"
        Me.StudentTableBindingSource.DataSource = Me.DbDataSet
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colschYear, Me.colterm1, Me.colgrNO, Me.colstdID, Me.colsurname, Me.colotherNames, Me.colDOB, Me.colgender, Me.coladdress, Me.coltermOfAdmission, Me.colyearOfAdmission, Me.colguardianName, Me.colcurrentClass, Me.colsection, Me.colclassOfAdmission, Me.colpreviousSchAttended, Me.colstudentPhone, Me.colstudentEmail, Me.colnationality, Me.coldisability, Me.colnote, Me.colReligion, Me.colstatus, Me.colstateOfOrigin, Me.colLga, Me.colentranceExamScore, Me.colpassportPath})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "New subject..."
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colschYear
        '
        Me.colschYear.FieldName = "schYear"
        Me.colschYear.Name = "colschYear"
        '
        'colterm1
        '
        Me.colterm1.FieldName = "term"
        Me.colterm1.Name = "colterm1"
        '
        'colgrNO
        '
        Me.colgrNO.FieldName = "grNO"
        Me.colgrNO.Name = "colgrNO"
        '
        'colstdID
        '
        Me.colstdID.FieldName = "stdID"
        Me.colstdID.Name = "colstdID"
        '
        'colsurname
        '
        Me.colsurname.Caption = "Surname"
        Me.colsurname.FieldName = "surname"
        Me.colsurname.Name = "colsurname"
        Me.colsurname.Visible = True
        Me.colsurname.VisibleIndex = 0
        Me.colsurname.Width = 93
        '
        'colotherNames
        '
        Me.colotherNames.Caption = "Other Names"
        Me.colotherNames.FieldName = "otherNames"
        Me.colotherNames.Name = "colotherNames"
        Me.colotherNames.Visible = True
        Me.colotherNames.VisibleIndex = 1
        Me.colotherNames.Width = 203
        '
        'colDOB
        '
        Me.colDOB.FieldName = "DOB"
        Me.colDOB.Name = "colDOB"
        '
        'colgender
        '
        Me.colgender.FieldName = "gender"
        Me.colgender.Name = "colgender"
        '
        'coladdress
        '
        Me.coladdress.FieldName = "address"
        Me.coladdress.Name = "coladdress"
        '
        'coltermOfAdmission
        '
        Me.coltermOfAdmission.FieldName = "termOfAdmission"
        Me.coltermOfAdmission.Name = "coltermOfAdmission"
        '
        'colyearOfAdmission
        '
        Me.colyearOfAdmission.FieldName = "yearOfAdmission"
        Me.colyearOfAdmission.Name = "colyearOfAdmission"
        '
        'colguardianName
        '
        Me.colguardianName.FieldName = "guardianName"
        Me.colguardianName.Name = "colguardianName"
        '
        'colcurrentClass
        '
        Me.colcurrentClass.FieldName = "currentClass"
        Me.colcurrentClass.Name = "colcurrentClass"
        '
        'colsection
        '
        Me.colsection.FieldName = "section"
        Me.colsection.Name = "colsection"
        '
        'colclassOfAdmission
        '
        Me.colclassOfAdmission.FieldName = "classOfAdmission"
        Me.colclassOfAdmission.Name = "colclassOfAdmission"
        '
        'colpreviousSchAttended
        '
        Me.colpreviousSchAttended.FieldName = "previousSchAttended"
        Me.colpreviousSchAttended.Name = "colpreviousSchAttended"
        '
        'colstudentPhone
        '
        Me.colstudentPhone.FieldName = "studentPhone"
        Me.colstudentPhone.Name = "colstudentPhone"
        '
        'colstudentEmail
        '
        Me.colstudentEmail.FieldName = "studentEmail"
        Me.colstudentEmail.Name = "colstudentEmail"
        '
        'colnationality
        '
        Me.colnationality.FieldName = "nationality"
        Me.colnationality.Name = "colnationality"
        '
        'coldisability
        '
        Me.coldisability.FieldName = "disability"
        Me.coldisability.Name = "coldisability"
        '
        'colnote
        '
        Me.colnote.FieldName = "note"
        Me.colnote.Name = "colnote"
        '
        'colReligion
        '
        Me.colReligion.FieldName = "Religion"
        Me.colReligion.Name = "colReligion"
        '
        'colstatus
        '
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        '
        'colstateOfOrigin
        '
        Me.colstateOfOrigin.FieldName = "stateOfOrigin"
        Me.colstateOfOrigin.Name = "colstateOfOrigin"
        '
        'colLga
        '
        Me.colLga.FieldName = "Lga"
        Me.colLga.Name = "colLga"
        '
        'colentranceExamScore
        '
        Me.colentranceExamScore.FieldName = "entranceExamScore"
        Me.colentranceExamScore.Name = "colentranceExamScore"
        '
        'colpassportPath
        '
        Me.colpassportPath.FieldName = "passportPath"
        Me.colpassportPath.Name = "colpassportPath"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Root1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.SimpleSeparator2, Me.SimpleSeparator3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(755, 531)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'Root1
        '
        Me.Root1.CustomizationFormText = "Root"
        Me.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root1.GroupBordersVisible = False
        Me.Root1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.SimpleSeparator1, Me.EmptySpaceItem2, Me.LayoutControlItem5})
        Me.Root1.Location = New System.Drawing.Point(0, 40)
        Me.Root1.Name = "Root1"
        Me.Root1.Size = New System.Drawing.Size(735, 471)
        Me.Root1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root1.Text = "Root"
        Me.Root1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(176, 2)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(318, 449)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(531, 2)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(184, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(184, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(184, 449)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(715, 2)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 2)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(176, 0)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(176, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(176, 449)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.addEditScoreButtonPanel
        Me.LayoutControlItem5.Location = New System.Drawing.Point(494, 2)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(37, 449)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbClass
        Me.LayoutControlItem2.Location = New System.Drawing.Point(490, 2)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(245, 36)
        Me.LayoutControlItem2.Text = "Student Class:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbTerm
        Me.LayoutControlItem3.Location = New System.Drawing.Point(245, 2)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(245, 36)
        Me.LayoutControlItem3.Text = "Term"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbSchYear
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 2)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(245, 36)
        Me.LayoutControlItem4.Text = "Academic Session:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(88, 13)
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 38)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(735, 2)
        '
        'SimpleSeparator3
        '
        Me.SimpleSeparator3.AllowHotTrack = False
        Me.SimpleSeparator3.Location = New System.Drawing.Point(0, 0)
        Me.SimpleSeparator3.Name = "SimpleSeparator3"
        Me.SimpleSeparator3.Size = New System.Drawing.Size(735, 2)
        '
        'colstaff_id
        '
        Me.colstaff_id.FieldName = "staff_id"
        Me.colstaff_id.Name = "colstaff_id"
        '
        'colposition
        '
        Me.colposition.FieldName = "position"
        Me.colposition.Name = "colposition"
        '
        'colgradeRemarks
        '
        Me.colgradeRemarks.FieldName = "gradeRemarks"
        Me.colgradeRemarks.Name = "colgradeRemarks"
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        '
        'coltotalscore
        '
        Me.coltotalscore.FieldName = "totalscore"
        Me.coltotalscore.Name = "coltotalscore"
        '
        'colexamscore
        '
        Me.colexamscore.FieldName = "examscore"
        Me.colexamscore.Name = "colexamscore"
        '
        'colterm
        '
        Me.colterm.FieldName = "term"
        Me.colterm.Name = "colterm"
        '
        'colacadyr
        '
        Me.colacadyr.FieldName = "acadyr"
        Me.colacadyr.Name = "colacadyr"
        '
        'colfirstass
        '
        Me.colfirstass.FieldName = "firstass"
        Me.colfirstass.Name = "colfirstass"
        '
        'colsecondass
        '
        Me.colsecondass.FieldName = "secondass"
        Me.colsecondass.Name = "colsecondass"
        '
        'colsecondca
        '
        Me.colsecondca.FieldName = "secondca"
        Me.colsecondca.Name = "colsecondca"
        '
        'StudentTableTableAdapter
        '
        Me.StudentTableTableAdapter.ClearBeforeFill = True
        '
        'studentListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.TouchScaleFactor = 1.5!
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.Name = "studentListView"
        Me.Size = New System.Drawing.Size(755, 531)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cmbSchYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudentmarksBindingSource As BindingSource
    'Friend WithEvents Result_db1DataSet As result_db1DataSet
    'Friend WithEvents Student_marksTableAdapter As result_db1DataSetTableAdapters.student_marksTableAdapter
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Root1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents colstaff_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgradeRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotalscore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexamscore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colacadyr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsecondass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsecondca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbSchYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbTerm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbClass As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StudentTableBindingSource As BindingSource
    Friend WithEvents DbDataSet As dbDataSet
    Friend WithEvents StudentTableTableAdapter As dbDataSetTableAdapters.studentTableTableAdapter
    Friend WithEvents addEditScoreButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colschYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterm1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgrNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstdID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colotherNames As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltermOfAdmission As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colyearOfAdmission As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colguardianName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcurrentClass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colclassOfAdmission As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpreviousSchAttended As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstudentPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstudentEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnationality As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldisability As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReligion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstateOfOrigin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colentranceExamScore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpassportPath As DevExpress.XtraGrid.Columns.GridColumn
End Class
