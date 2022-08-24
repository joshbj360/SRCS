Imports DevExpress

Partial Public Class addStudentForm
    Inherits BaseSRCSModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addStudentForm))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbClassOfAdmission = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtmname = New DevExpress.XtraEditors.TextEdit()
        Me.txtGfullname = New DevExpress.XtraEditors.TextEdit()
        Me.txtlastsch = New DevExpress.XtraEditors.TextEdit()
        Me.txtstdid = New DevExpress.XtraEditors.TextEdit()
        Me.txtgrno = New DevExpress.XtraEditors.TextEdit()
        Me.memNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPhno = New DevExpress.XtraEditors.TextEdit()
        Me.memAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.txtoname = New DevExpress.XtraEditors.TextEdit()
        Me.sbOK = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsname = New DevExpress.XtraEditors.TextEdit()
        Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
        Me.cmbclass = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbnationality = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtemail = New DevExpress.XtraEditors.HyperLinkEdit()
        Me.cmbdob = New DevExpress.XtraEditors.DateEdit()
        Me.cmbgender = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.rdgPhyChal = New DevExpress.XtraEditors.RadioGroup()
        Me.cmbSection = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.stdIDLayoutItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciGender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtageCONTROLitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcgInfo = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciState = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lcgAddress = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciLine = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciEmail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPhone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtMnameControlItem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNotes = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciBirthDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciCity = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcMain.SuspendLayout()
        CType(Me.cmbClassOfAdmission.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGfullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlastsch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstdid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtoname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbclass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbnationality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdob.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgPhyChal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stdIDLayoutItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtageCONTROLitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMnameControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcMain
        '
        Me.lcMain.AllowCustomization = False
        Me.lcMain.Controls.Add(Me.cmbClassOfAdmission)
        Me.lcMain.Controls.Add(Me.SimpleButton2)
        Me.lcMain.Controls.Add(Me.txtmname)
        Me.lcMain.Controls.Add(Me.txtGfullname)
        Me.lcMain.Controls.Add(Me.txtlastsch)
        Me.lcMain.Controls.Add(Me.txtstdid)
        Me.lcMain.Controls.Add(Me.txtgrno)
        Me.lcMain.Controls.Add(Me.memNotes)
        Me.lcMain.Controls.Add(Me.sbCancel)
        Me.lcMain.Controls.Add(Me.txtPhno)
        Me.lcMain.Controls.Add(Me.memAddress)
        Me.lcMain.Controls.Add(Me.txtoname)
        Me.lcMain.Controls.Add(Me.sbOK)
        Me.lcMain.Controls.Add(Me.txtsname)
        Me.lcMain.Controls.Add(Me.pePhoto)
        Me.lcMain.Controls.Add(Me.cmbclass)
        Me.lcMain.Controls.Add(Me.cmbnationality)
        Me.lcMain.Controls.Add(Me.txtemail)
        Me.lcMain.Controls.Add(Me.cmbdob)
        Me.lcMain.Controls.Add(Me.cmbgender)
        Me.lcMain.Controls.Add(Me.rdgPhyChal)
        Me.lcMain.Controls.Add(Me.cmbSection)
        Me.lcMain.Controls.Add(Me.RadioGroup1)
        resources.ApplyResources(Me.lcMain, "lcMain")
        Me.lcMain.Name = "lcMain"
        Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(379, 287, 450, 596)
        Me.lcMain.Root = Me.layoutControlGroup1
        '
        'cmbClassOfAdmission
        '
        resources.ApplyResources(Me.cmbClassOfAdmission, "cmbClassOfAdmission")
        Me.cmbClassOfAdmission.Name = "cmbClassOfAdmission"
        Me.cmbClassOfAdmission.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbClassOfAdmission.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbClassOfAdmission.StyleController = Me.lcMain
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.SimpleButton2, "SimpleButton2")
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.StyleController = Me.lcMain
        '
        'txtmname
        '
        resources.ApplyResources(Me.txtmname, "txtmname")
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Properties.Appearance.Options.UseFont = True
        Me.txtmname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmname.StyleController = Me.lcMain
        '
        'txtGfullname
        '
        resources.ApplyResources(Me.txtGfullname, "txtGfullname")
        Me.txtGfullname.Name = "txtGfullname"
        Me.txtGfullname.Properties.Appearance.Font = CType(resources.GetObject("txtGfullname.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtGfullname.Properties.Appearance.Options.UseFont = True
        Me.txtGfullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGfullname.StyleController = Me.lcMain
        '
        'txtlastsch
        '
        resources.ApplyResources(Me.txtlastsch, "txtlastsch")
        Me.txtlastsch.Name = "txtlastsch"
        Me.txtlastsch.Properties.Appearance.Font = CType(resources.GetObject("txtlastsch.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtlastsch.Properties.Appearance.Options.UseFont = True
        Me.txtlastsch.StyleController = Me.lcMain
        '
        'txtstdid
        '
        resources.ApplyResources(Me.txtstdid, "txtstdid")
        Me.txtstdid.Name = "txtstdid"
        Me.txtstdid.Properties.Appearance.Font = CType(resources.GetObject("txtstdid.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtstdid.Properties.Appearance.Options.UseFont = True
        Me.txtstdid.StyleController = Me.lcMain
        '
        'txtgrno
        '
        resources.ApplyResources(Me.txtgrno, "txtgrno")
        Me.txtgrno.Name = "txtgrno"
        Me.txtgrno.Properties.Appearance.Font = CType(resources.GetObject("txtgrno.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtgrno.Properties.Appearance.Options.UseFont = True
        Me.txtgrno.StyleController = Me.lcMain
        '
        'memNotes
        '
        resources.ApplyResources(Me.memNotes, "memNotes")
        Me.memNotes.Name = "memNotes"
        Me.memNotes.Properties.Appearance.Font = CType(resources.GetObject("memNotes.Properties.Appearance.Font"), System.Drawing.Font)
        Me.memNotes.Properties.Appearance.Options.UseFont = True
        Me.memNotes.StyleController = Me.lcMain
        '
        'sbCancel
        '
        Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sbCancel.ImageOptions.Image = CType(resources.GetObject("sbCancel.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.sbCancel, "sbCancel")
        Me.sbCancel.Name = "sbCancel"
        Me.sbCancel.StyleController = Me.lcMain
        '
        'txtPhno
        '
        resources.ApplyResources(Me.txtPhno, "txtPhno")
        Me.txtPhno.Name = "txtPhno"
        Me.txtPhno.Properties.Appearance.Font = CType(resources.GetObject("txtPhno.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtPhno.Properties.Appearance.Options.UseFont = True
        Me.txtPhno.Properties.Mask.EditMask = resources.GetString("txtPhno.Properties.Mask.EditMask")
        Me.txtPhno.Properties.Mask.MaskType = CType(resources.GetObject("txtPhno.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtPhno.StyleController = Me.lcMain
        '
        'memAddress
        '
        resources.ApplyResources(Me.memAddress, "memAddress")
        Me.memAddress.Name = "memAddress"
        Me.memAddress.Properties.Appearance.Font = CType(resources.GetObject("memAddress.Properties.Appearance.Font"), System.Drawing.Font)
        Me.memAddress.Properties.Appearance.Options.UseFont = True
        Me.memAddress.StyleController = Me.lcMain
        '
        'txtoname
        '
        resources.ApplyResources(Me.txtoname, "txtoname")
        Me.txtoname.Name = "txtoname"
        Me.txtoname.Properties.Appearance.Font = CType(resources.GetObject("txtoname.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtoname.Properties.Appearance.Options.UseFont = True
        Me.txtoname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtoname.StyleController = Me.lcMain
        '
        'sbOK
        '
        Me.sbOK.AutoWidthInLayoutControl = True
        Me.sbOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.sbOK.ImageOptions.Image = CType(resources.GetObject("sbOK.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.sbOK, "sbOK")
        Me.sbOK.Name = "sbOK"
        Me.sbOK.StyleController = Me.lcMain
        Me.sbOK.Tag = "add"
        '
        'txtsname
        '
        resources.ApplyResources(Me.txtsname, "txtsname")
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Properties.Appearance.Font = CType(resources.GetObject("txtsname.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtsname.Properties.Appearance.Options.UseFont = True
        Me.txtsname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsname.StyleController = Me.lcMain
        ConditionValidationRule1.ErrorText = "This value is required"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dxValidationProvider1.SetValidationRule(Me.txtsname, ConditionValidationRule1)
        '
        'pePhoto
        '
        Me.pePhoto.Cursor = System.Windows.Forms.Cursors.Default
        Me.pePhoto.EditValue = Global.SRCSv3._1.My.Resources.Resources.Unknown_user
        resources.ApplyResources(Me.pePhoto, "pePhoto")
        Me.pePhoto.Name = "pePhoto"
        Me.pePhoto.Properties.AllowFocused = False
        Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pePhoto.StyleController = Me.lcMain
        '
        'cmbclass
        '
        resources.ApplyResources(Me.cmbclass, "cmbclass")
        Me.cmbclass.Name = "cmbclass"
        Me.cmbclass.Properties.Appearance.Font = CType(resources.GetObject("cmbclass.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cmbclass.Properties.Appearance.Options.UseFont = True
        Me.cmbclass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbclass.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbclass.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbclass.Properties.DropDownRows = 11
        Me.cmbclass.StyleController = Me.lcMain
        '
        'cmbnationality
        '
        resources.ApplyResources(Me.cmbnationality, "cmbnationality")
        Me.cmbnationality.Name = "cmbnationality"
        Me.cmbnationality.Properties.Appearance.Font = CType(resources.GetObject("cmbnationality.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cmbnationality.Properties.Appearance.Options.UseFont = True
        Me.cmbnationality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbnationality.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbnationality.Properties.DropDownRows = 11
        Me.cmbnationality.StyleController = Me.lcMain
        '
        'txtemail
        '
        resources.ApplyResources(Me.txtemail, "txtemail")
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Properties.Appearance.Font = CType(resources.GetObject("txtemail.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtemail.Properties.Appearance.Options.UseFont = True
        Me.txtemail.Properties.SingleClick = False
        Me.txtemail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtemail.StyleController = Me.lcMain
        '
        'cmbdob
        '
        resources.ApplyResources(Me.cmbdob, "cmbdob")
        Me.cmbdob.Name = "cmbdob"
        Me.cmbdob.Properties.Appearance.Font = CType(resources.GetObject("cmbdob.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cmbdob.Properties.Appearance.Options.UseFont = True
        Me.cmbdob.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbdob.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbdob.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cmbdob.Properties.MaxValue = New Date(9999, 12, 31, 0, 0, 0, 0)
        Me.cmbdob.StyleController = Me.lcMain
        '
        'cmbgender
        '
        resources.ApplyResources(Me.cmbgender, "cmbgender")
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Properties.Appearance.Font = CType(resources.GetObject("cmbgender.Properties.Appearance.Font"), System.Drawing.Font)
        Me.cmbgender.Properties.Appearance.Options.UseFont = True
        Me.cmbgender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbgender.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbgender.StyleController = Me.lcMain
        '
        'rdgPhyChal
        '
        resources.ApplyResources(Me.rdgPhyChal, "rdgPhyChal")
        Me.rdgPhyChal.Name = "rdgPhyChal"
        Me.rdgPhyChal.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.rdgPhyChal.Properties.Appearance.Font = CType(resources.GetObject("rdgPhyChal.Properties.Appearance.Font"), System.Drawing.Font)
        Me.rdgPhyChal.Properties.Appearance.Options.UseFont = True
        Me.rdgPhyChal.Properties.ColumnIndent = 10
        Me.rdgPhyChal.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(resources.GetString("rdgPhyChal.Properties.Items"), resources.GetString("rdgPhyChal.Properties.Items1")), New DevExpress.XtraEditors.Controls.RadioGroupItem(resources.GetString("rdgPhyChal.Properties.Items2"), resources.GetString("rdgPhyChal.Properties.Items3"))})
        Me.rdgPhyChal.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.rdgPhyChal.StyleController = Me.lcMain
        '
        'cmbSection
        '
        resources.ApplyResources(Me.cmbSection, "cmbSection")
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Properties.Appearance.Options.UseFont = True
        Me.cmbSection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSection.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSection.Properties.Items.AddRange(New Object() {resources.GetString("cmbSection.Properties.Items"), resources.GetString("cmbSection.Properties.Items1"), resources.GetString("cmbSection.Properties.Items2"), resources.GetString("cmbSection.Properties.Items3"), resources.GetString("cmbSection.Properties.Items4"), resources.GetString("cmbSection.Properties.Items5"), resources.GetString("cmbSection.Properties.Items6")})
        Me.cmbSection.StyleController = Me.lcMain
        '
        'RadioGroup1
        '
        resources.ApplyResources(Me.RadioGroup1, "RadioGroup1")
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.AutoHeight = CType(resources.GetObject("RadioGroup1.Properties.AutoHeight"), Boolean)
        Me.RadioGroup1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RadioGroup1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RadioGroup1.Properties.Items.AddRange(New Object() {resources.GetString("RadioGroup1.Properties.Items"), resources.GetString("RadioGroup1.Properties.Items1"), resources.GetString("RadioGroup1.Properties.Items2"), resources.GetString("RadioGroup1.Properties.Items3"), resources.GetString("RadioGroup1.Properties.Items4"), resources.GetString("RadioGroup1.Properties.Items5")})
        Me.RadioGroup1.StyleController = Me.lcMain
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.AppearanceItemCaption.Font = CType(resources.GetObject("layoutControlGroup1.AppearanceItemCaption.Font"), System.Drawing.Font)
        Me.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = True
        resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciFirstName, Me.lciPhoto, Me.emptySpaceItem3, Me.emptySpaceItem2, Me.splitterItem1, Me.lciLastName, Me.LayoutControlItem3, Me.stdIDLayoutItem, Me.lciGender, Me.txtageCONTROLitem, Me.lcgInfo, Me.EmptySpaceItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.EmptySpaceItem8, Me.lcgAddress, Me.LayoutControlItem7, Me.lciNotes, Me.lciBirthDate, Me.lciCity, Me.LayoutControlItem9, Me.SimpleSeparator1, Me.layoutControlItem2, Me.layoutControlItem1, Me.LayoutControlItem10})
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(912, 669)
        Me.layoutControlGroup1.TextVisible = False
        '
        'lciFirstName
        '
        Me.lciFirstName.AppearanceItemCaption.ForeColor = CType(resources.GetObject("lciFirstName.AppearanceItemCaption.ForeColor"), System.Drawing.Color)
        Me.lciFirstName.AppearanceItemCaption.Options.UseForeColor = True
        Me.lciFirstName.Control = Me.txtsname
        resources.ApplyResources(Me.lciFirstName, "lciFirstName")
        Me.lciFirstName.Location = New System.Drawing.Point(211, 38)
        Me.lciFirstName.Name = "lciFirstName"
        Me.lciFirstName.Size = New System.Drawing.Size(227, 38)
        Me.lciFirstName.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciPhoto
        '
        Me.lciPhoto.Control = Me.pePhoto
        resources.ApplyResources(Me.lciPhoto, "lciPhoto")
        Me.lciPhoto.Location = New System.Drawing.Point(30, 0)
        Me.lciPhoto.Name = "lciPhoto"
        Me.lciPhoto.Size = New System.Drawing.Size(157, 190)
        Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
        Me.lciPhoto.TextVisible = False
        '
        'emptySpaceItem3
        '
        Me.emptySpaceItem3.AllowHotTrack = False
        resources.ApplyResources(Me.emptySpaceItem3, "emptySpaceItem3")
        Me.emptySpaceItem3.Location = New System.Drawing.Point(30, 605)
        Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 6)
        Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 6)
        Me.emptySpaceItem3.Name = "emptySpaceItem3"
        Me.emptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.emptySpaceItem3.Size = New System.Drawing.Size(690, 6)
        Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'emptySpaceItem2
        '
        Me.emptySpaceItem2.AllowHotTrack = False
        resources.ApplyResources(Me.emptySpaceItem2, "emptySpaceItem2")
        Me.emptySpaceItem2.Location = New System.Drawing.Point(30, 611)
        Me.emptySpaceItem2.Name = "emptySpaceItem2"
        Me.emptySpaceItem2.Size = New System.Drawing.Size(690, 38)
        Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'splitterItem1
        '
        Me.splitterItem1.AllowHotTrack = True
        resources.ApplyResources(Me.splitterItem1, "splitterItem1")
        Me.splitterItem1.Location = New System.Drawing.Point(187, 0)
        Me.splitterItem1.Name = "splitterItem1"
        Me.splitterItem1.Size = New System.Drawing.Size(24, 190)
        '
        'lciLastName
        '
        Me.lciLastName.AppearanceItemCaption.ForeColor = CType(resources.GetObject("lciLastName.AppearanceItemCaption.ForeColor"), System.Drawing.Color)
        Me.lciLastName.AppearanceItemCaption.Options.UseForeColor = True
        Me.lciLastName.Control = Me.txtoname
        resources.ApplyResources(Me.lciLastName, "lciLastName")
        Me.lciLastName.Location = New System.Drawing.Point(438, 38)
        Me.lciLastName.Name = "lciLastName"
        Me.lciLastName.Size = New System.Drawing.Size(282, 38)
        Me.lciLastName.TextSize = New System.Drawing.Size(126, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtgrno
        Me.LayoutControlItem3.Location = New System.Drawing.Point(211, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(183, 38)
        resources.ApplyResources(Me.LayoutControlItem3, "LayoutControlItem3")
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(126, 16)
        '
        'stdIDLayoutItem
        '
        Me.stdIDLayoutItem.Control = Me.txtstdid
        Me.stdIDLayoutItem.Location = New System.Drawing.Point(394, 0)
        Me.stdIDLayoutItem.Name = "stdIDLayoutItem"
        Me.stdIDLayoutItem.Size = New System.Drawing.Size(326, 38)
        resources.ApplyResources(Me.stdIDLayoutItem, "stdIDLayoutItem")
        Me.stdIDLayoutItem.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciGender
        '
        Me.lciGender.Control = Me.cmbgender
        resources.ApplyResources(Me.lciGender, "lciGender")
        Me.lciGender.Location = New System.Drawing.Point(211, 76)
        Me.lciGender.Name = "lciGender"
        Me.lciGender.Size = New System.Drawing.Size(227, 38)
        Me.lciGender.TextSize = New System.Drawing.Size(126, 16)
        '
        'txtageCONTROLitem
        '
        Me.txtageCONTROLitem.AppearanceItemCaption.ForeColor = CType(resources.GetObject("txtageCONTROLitem.AppearanceItemCaption.ForeColor"), System.Drawing.Color)
        Me.txtageCONTROLitem.AppearanceItemCaption.Options.UseForeColor = True
        Me.txtageCONTROLitem.Control = Me.cmbSection
        Me.txtageCONTROLitem.Location = New System.Drawing.Point(438, 116)
        Me.txtageCONTROLitem.Name = "txtageCONTROLitem"
        Me.txtageCONTROLitem.Size = New System.Drawing.Size(282, 38)
        resources.ApplyResources(Me.txtageCONTROLitem, "txtageCONTROLitem")
        Me.txtageCONTROLitem.TextSize = New System.Drawing.Size(126, 16)
        '
        'lcgInfo
        '
        resources.ApplyResources(Me.lcgInfo, "lcgInfo")
        Me.lcgInfo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
        Me.lcgInfo.ExpandButtonVisible = True
        Me.lcgInfo.Expanded = False
        Me.lcgInfo.ExpandOnDoubleClick = True
        Me.lcgInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciState, Me.LayoutControlItem5, Me.LayoutControlItem8})
        Me.lcgInfo.Location = New System.Drawing.Point(30, 467)
        Me.lcgInfo.Name = "lcgInfo"
        Me.lcgInfo.Size = New System.Drawing.Size(690, 33)
        '
        'lciState
        '
        Me.lciState.Control = Me.cmbnationality
        resources.ApplyResources(Me.lciState, "lciState")
        Me.lciState.Location = New System.Drawing.Point(0, 0)
        Me.lciState.Name = "lciState"
        Me.lciState.Size = New System.Drawing.Size(840, 38)
        Me.lciState.TextSize = New System.Drawing.Size(126, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtlastsch
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 38)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(840, 38)
        resources.ApplyResources(Me.LayoutControlItem5, "LayoutControlItem5")
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(126, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.rdgPhyChal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(840, 44)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(840, 44)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(840, 44)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        resources.ApplyResources(Me.LayoutControlItem8, "LayoutControlItem8")
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(126, 16)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 649)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(730, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(12, 649)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(10, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(10, 649)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(20, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(10, 649)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(720, 0)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(10, 649)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'lcgAddress
        '
        resources.ApplyResources(Me.lcgAddress, "lcgAddress")
        Me.lcgAddress.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciLine, Me.lciEmail, Me.lciPhone, Me.LayoutControlItem6, Me.txtMnameControlItem})
        Me.lcgAddress.Location = New System.Drawing.Point(30, 190)
        Me.lcgAddress.Name = "lcgAddress"
        Me.lcgAddress.Size = New System.Drawing.Size(690, 277)
        '
        'lciLine
        '
        Me.lciLine.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lciLine.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lciLine.Control = Me.memAddress
        resources.ApplyResources(Me.lciLine, "lciLine")
        Me.lciLine.Location = New System.Drawing.Point(0, 150)
        Me.lciLine.Name = "lciLine"
        Me.lciLine.Size = New System.Drawing.Size(666, 85)
        Me.lciLine.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciEmail
        '
        Me.lciEmail.Control = Me.txtemail
        resources.ApplyResources(Me.lciEmail, "lciEmail")
        Me.lciEmail.Location = New System.Drawing.Point(0, 112)
        Me.lciEmail.Name = "lciEmail"
        Me.lciEmail.Size = New System.Drawing.Size(666, 38)
        Me.lciEmail.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciPhone
        '
        Me.lciPhone.Control = Me.txtPhno
        resources.ApplyResources(Me.lciPhone, "lciPhone")
        Me.lciPhone.Location = New System.Drawing.Point(0, 74)
        Me.lciPhone.Name = "lciPhone"
        Me.lciPhone.Size = New System.Drawing.Size(666, 38)
        Me.lciPhone.TextSize = New System.Drawing.Size(126, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtGfullname
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(666, 38)
        resources.ApplyResources(Me.LayoutControlItem6, "LayoutControlItem6")
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(126, 16)
        '
        'txtMnameControlItem
        '
        Me.txtMnameControlItem.Control = Me.txtmname
        Me.txtMnameControlItem.Location = New System.Drawing.Point(0, 38)
        Me.txtMnameControlItem.Name = "txtMnameControlItem"
        Me.txtMnameControlItem.Size = New System.Drawing.Size(666, 36)
        resources.ApplyResources(Me.txtMnameControlItem, "txtMnameControlItem")
        Me.txtMnameControlItem.TextSize = New System.Drawing.Size(126, 16)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.RadioGroup1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(438, 154)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(282, 36)
        resources.ApplyResources(Me.LayoutControlItem7, "LayoutControlItem7")
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciNotes
        '
        Me.lciNotes.Control = Me.memNotes
        resources.ApplyResources(Me.lciNotes, "lciNotes")
        Me.lciNotes.Location = New System.Drawing.Point(30, 500)
        Me.lciNotes.Name = "lciNotes"
        Me.lciNotes.Size = New System.Drawing.Size(690, 105)
        Me.lciNotes.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciNotes.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciBirthDate
        '
        Me.lciBirthDate.Control = Me.cmbdob
        resources.ApplyResources(Me.lciBirthDate, "lciBirthDate")
        Me.lciBirthDate.Location = New System.Drawing.Point(438, 76)
        Me.lciBirthDate.Name = "lciBirthDate"
        Me.lciBirthDate.Size = New System.Drawing.Size(282, 38)
        Me.lciBirthDate.TextSize = New System.Drawing.Size(126, 16)
        '
        'lciCity
        '
        Me.lciCity.AppearanceItemCaption.ForeColor = CType(resources.GetObject("lciCity.AppearanceItemCaption.ForeColor"), System.Drawing.Color)
        Me.lciCity.AppearanceItemCaption.Options.UseForeColor = True
        Me.lciCity.Control = Me.cmbclass
        resources.ApplyResources(Me.lciCity, "lciCity")
        Me.lciCity.Location = New System.Drawing.Point(211, 116)
        Me.lciCity.Name = "lciCity"
        Me.lciCity.Size = New System.Drawing.Size(227, 38)
        Me.lciCity.TextSize = New System.Drawing.Size(126, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmbClassOfAdmission
        Me.LayoutControlItem9.Location = New System.Drawing.Point(211, 154)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(227, 36)
        resources.ApplyResources(Me.LayoutControlItem9, "LayoutControlItem9")
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(126, 16)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(211, 114)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(509, 2)
        '
        'layoutControlItem2
        '
        Me.layoutControlItem2.Control = Me.sbCancel
        resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
        Me.layoutControlItem2.Location = New System.Drawing.Point(742, 76)
        Me.layoutControlItem2.Name = "layoutControlItem2"
        Me.layoutControlItem2.Size = New System.Drawing.Size(150, 573)
        Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutControlItem2.TextVisible = False
        '
        'layoutControlItem1
        '
        Me.layoutControlItem1.Control = Me.sbOK
        resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
        Me.layoutControlItem1.Location = New System.Drawing.Point(742, 0)
        Me.layoutControlItem1.Name = "layoutControlItem1"
        Me.layoutControlItem1.Size = New System.Drawing.Size(150, 38)
        Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutControlItem1.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton2
        Me.LayoutControlItem10.Location = New System.Drawing.Point(742, 38)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(150, 38)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'dxValidationProvider1
        '
        Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'addStudentForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lcMain)
        Me.LookAndFeel.TouchScaleFactor = 1.5!
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "addStudentForm"
        CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcMain.ResumeLayout(False)
        CType(Me.cmbClassOfAdmission.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGfullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlastsch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstdid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgrno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtoname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbclass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbnationality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdob.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgPhyChal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stdIDLayoutItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtageCONTROLitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMnameControlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private lcMain As DevExpress.XtraLayout.LayoutControl
    Private txtoname As DevExpress.XtraEditors.TextEdit
    Private txtsname As DevExpress.XtraEditors.TextEdit
    Private pePhoto As DevExpress.XtraEditors.PictureEdit
    Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private lciPhoto As DevExpress.XtraLayout.LayoutControlItem
    Private lciFirstName As DevExpress.XtraLayout.LayoutControlItem
    Private lciLastName As DevExpress.XtraLayout.LayoutControlItem
    Private txtPhno As DevExpress.XtraEditors.TextEdit
    Private memAddress As DevExpress.XtraEditors.MemoEdit
    Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
    Private cmbnationality As DevExpress.XtraEditors.ComboBoxEdit
    Private txtemail As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents cmbdob As DevExpress.XtraEditors.DateEdit
    Private cmbgender As DevExpress.XtraEditors.ImageComboBoxEdit
    Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents sbCancel As DevExpress.XtraEditors.SimpleButton
    Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private memNotes As XtraEditors.MemoEdit
    Private lciNotes As XtraLayout.LayoutControlItem
    Private lcgAddress As XtraLayout.LayoutControlGroup
    Private lciLine As XtraLayout.LayoutControlItem
    Private lciCity As XtraLayout.LayoutControlItem
    Private lciState As XtraLayout.LayoutControlItem
    Private lcgInfo As XtraLayout.LayoutControlGroup
    Private lciEmail As XtraLayout.LayoutControlItem
    Private lciPhone As XtraLayout.LayoutControlItem
    Private lciBirthDate As XtraLayout.LayoutControlItem
    Private lciGender As XtraLayout.LayoutControlItem
    Friend WithEvents txtGfullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtlastsch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtstdid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtgrno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents stdIDLayoutItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtmname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMnameControlItem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtageCONTROLitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rdgPhyChal As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents sbOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem10 As XtraLayout.LayoutControlItem
    Friend WithEvents cmbSection As XtraEditors.ComboBoxEdit
    Friend WithEvents cmbClassOfAdmission As XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem9 As XtraLayout.LayoutControlItem
    Friend WithEvents cmbclass As XtraEditors.ComboBoxEdit
    Friend WithEvents RadioGroup1 As XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleSeparator1 As XtraLayout.SimpleSeparator
End Class

