<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addClassView
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cancelBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.saveBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbSchYear = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbTerm = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbSection = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbFormTeacher = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtClass = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DbDataSet = New SRCSv3._1.dbDataSet()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cmbSchYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFormTeacher.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cancelBtn)
        Me.LayoutControl1.Controls.Add(Me.saveBtn)
        Me.LayoutControl1.Controls.Add(Me.cmbSchYear)
        Me.LayoutControl1.Controls.Add(Me.cmbTerm)
        Me.LayoutControl1.Controls.Add(Me.cmbSection)
        Me.LayoutControl1.Controls.Add(Me.cmbFormTeacher)
        Me.LayoutControl1.Controls.Add(Me.txtClass)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(591, 202)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(497, 122)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 11
        Me.SimpleButton2.Text = "Add User"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(419, 158)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(160, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "Save and &New"
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(12, 158)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(202, 32)
        Me.cancelBtn.StyleController = Me.LayoutControl1
        Me.cancelBtn.TabIndex = 9
        Me.cancelBtn.Text = "&Cancel"
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(218, 158)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(197, 32)
        Me.saveBtn.StyleController = Me.LayoutControl1
        Me.saveBtn.TabIndex = 8
        Me.saveBtn.Text = "&Save"
        '
        'cmbSchYear
        '
        Me.cmbSchYear.Location = New System.Drawing.Point(112, 13)
        Me.cmbSchYear.Name = "cmbSchYear"
        Me.cmbSchYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSchYear.Size = New System.Drawing.Size(182, 32)
        Me.cmbSchYear.StyleController = Me.LayoutControl1
        Me.cmbSchYear.TabIndex = 7
        '
        'cmbTerm
        '
        Me.cmbTerm.Location = New System.Drawing.Point(398, 13)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTerm.Size = New System.Drawing.Size(181, 32)
        Me.cmbTerm.StyleController = Me.LayoutControl1
        Me.cmbTerm.TabIndex = 6
        '
        'cmbSection
        '
        Me.cmbSection.Location = New System.Drawing.Point(112, 86)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSection.Properties.Items.AddRange(New Object() {"Crech", "Nursery", "Primary", "Junior Secondary", "Senior Secondary Science", "Senior Secondary Arts", "Senior Secondary Mixed"})
        Me.cmbSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbSection.Size = New System.Drawing.Size(467, 32)
        Me.cmbSection.StyleController = Me.LayoutControl1
        Me.cmbSection.TabIndex = 5
        '
        'cmbFormTeacher
        '
        Me.cmbFormTeacher.Location = New System.Drawing.Point(112, 122)
        Me.cmbFormTeacher.Name = "cmbFormTeacher"
        Me.cmbFormTeacher.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFormTeacher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbFormTeacher.Size = New System.Drawing.Size(381, 32)
        Me.cmbFormTeacher.StyleController = Me.LayoutControl1
        Me.cmbFormTeacher.TabIndex = 6
        '
        'txtClass
        '
        Me.txtClass.Location = New System.Drawing.Point(112, 50)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtClass.Size = New System.Drawing.Size(467, 32)
        Me.txtClass.StyleController = Me.LayoutControl1
        Me.txtClass.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.layoutControlItem1, Me.layoutControlItem3, Me.SimpleSeparator1, Me.SimpleSeparator2, Me.layoutControlItem2, Me.LayoutControlItem13, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(591, 202)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmbSchYear
        Me.LayoutControlItem14.CustomizationFormText = "Academic Session:"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 1)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(286, 36)
        Me.LayoutControlItem14.Text = "Academic Session:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(88, 13)
        '
        'layoutControlItem1
        '
        Me.layoutControlItem1.Control = Me.txtClass
        Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
        Me.layoutControlItem1.Location = New System.Drawing.Point(0, 38)
        Me.layoutControlItem1.Name = "layoutControlItem1"
        Me.layoutControlItem1.Size = New System.Drawing.Size(571, 36)
        Me.layoutControlItem1.Text = "Class Name:"
        Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutControlItem1.TextSize = New System.Drawing.Size(88, 13)
        '
        'layoutControlItem3
        '
        Me.layoutControlItem3.Control = Me.cmbFormTeacher
        Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
        Me.layoutControlItem3.Location = New System.Drawing.Point(0, 110)
        Me.layoutControlItem3.Name = "layoutControlItem3"
        Me.layoutControlItem3.Size = New System.Drawing.Size(485, 36)
        Me.layoutControlItem3.Text = "Form Teacher:"
        Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 37)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(571, 1)
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 0)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(571, 1)
        '
        'layoutControlItem2
        '
        Me.layoutControlItem2.Control = Me.cmbSection
        Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
        Me.layoutControlItem2.Location = New System.Drawing.Point(0, 74)
        Me.layoutControlItem2.Name = "layoutControlItem2"
        Me.layoutControlItem2.Size = New System.Drawing.Size(571, 36)
        Me.layoutControlItem2.Text = "Section:"
        Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmbTerm
        Me.LayoutControlItem13.CustomizationFormText = "Term"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(286, 1)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(285, 36)
        Me.LayoutControlItem13.Text = "Term"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.saveBtn
        Me.LayoutControlItem4.Location = New System.Drawing.Point(206, 146)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(201, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cancelBtn
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 146)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(206, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(407, 146)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(164, 36)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(485, 110)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(86, 36)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'addClassView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.TouchScaleFactor = 1.5!
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.Name = "addClassView"
        Me.Size = New System.Drawing.Size(591, 202)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cmbSchYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFormTeacher.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmbSchYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbTerm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbSection As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbFormTeacher As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cancelBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtClass As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DbDataSet As dbDataSet
End Class
