
Partial Public Class MainForm
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
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement12 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement13 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement14 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
        Me.Tile8 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.listAssignClassViewDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.addSubjectWizardDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.addScoresViewDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.reportDashboardViewDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.settingsViewDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.addSubjectWizardTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.Tile7 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.SubjectSummaryTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.Tile2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.reportDashboardViewTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listAssignClassViewDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addSubjectWizardDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addScoresViewDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportDashboardViewDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingsViewDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addSubjectWizardTile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectSummaryTile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportDashboardViewTile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'documentManager1
        '
        Me.documentManager1.ContainerControl = Me
        Me.documentManager1.View = Me.windowsUIView1
        Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.windowsUIView1})
        '
        'windowsUIView1
        '
        Me.windowsUIView1.Appearance.BackColor = System.Drawing.SystemColors.Desktop
        Me.windowsUIView1.Appearance.Options.UseBackColor = True
        Me.windowsUIView1.AppearanceActionsBar.BackColor = System.Drawing.SystemColors.Desktop
        Me.windowsUIView1.AppearanceActionsBar.ForeColor = System.Drawing.Color.Silver
        Me.windowsUIView1.AppearanceActionsBar.Options.UseBackColor = True
        Me.windowsUIView1.AppearanceActionsBar.Options.UseForeColor = True
        Me.windowsUIView1.AppearanceActionsBarButton.BackColor = System.Drawing.Color.Silver
        Me.windowsUIView1.AppearanceActionsBarButton.BorderColor = System.Drawing.Color.Silver
        Me.windowsUIView1.AppearanceActionsBarButton.ForeColor = System.Drawing.Color.Silver
        Me.windowsUIView1.AppearanceActionsBarButton.Options.UseBackColor = True
        Me.windowsUIView1.AppearanceActionsBarButton.Options.UseBorderColor = True
        Me.windowsUIView1.AppearanceActionsBarButton.Options.UseForeColor = True
        Me.windowsUIView1.AppearanceCaption.ForeColor = System.Drawing.Color.Silver
        Me.windowsUIView1.AppearanceCaption.Options.UseForeColor = True
        Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.settingsViewDocument, Me.addSubjectWizardDocument, Me.addScoresViewDocument, Me.listAssignClassViewDocument, Me.reportDashboardViewDocument})
        Me.windowsUIView1.SplashScreenProperties.Caption = ""
        Me.windowsUIView1.TileContainerProperties.AllowDrag = False
        Me.windowsUIView1.TileContainerProperties.AllowDragTilesBetweenGroups = False
        Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.SubjectSummaryTile, Me.Tile2, Me.addSubjectWizardTile, Me.Tile7, Me.Tile8, Me.reportDashboardViewTile})
        '
        'Tile8
        '
        Me.Tile8.Appearances.Normal.BackColor = System.Drawing.Color.Silver
        Me.Tile8.Appearances.Normal.BorderColor = System.Drawing.Color.Silver
        Me.Tile8.Appearances.Normal.ForeColor = System.Drawing.Color.Black
        Me.Tile8.Appearances.Normal.Options.UseBackColor = True
        Me.Tile8.Appearances.Normal.Options.UseBorderColor = True
        Me.Tile8.Appearances.Normal.Options.UseForeColor = True
        Me.Tile8.Document = Me.listAssignClassViewDocument
        TileItemElement9.Image = Global.SRCSv3._1.My.Resources.Resources.Shape_1101
        TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement9.ImageLocation = New System.Drawing.Point(10, -10)
        TileItemElement9.Text = ""
        TileItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement10.Appearance.Normal.Options.UseFont = True
        TileItemElement10.Text = "Classes"
        TileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement10.TextLocation = New System.Drawing.Point(0, 7)
        Me.Tile8.Elements.Add(TileItemElement9)
        Me.Tile8.Elements.Add(TileItemElement10)
        Me.Tile8.Name = "Tile8"
        '
        'listAssignClassViewDocument
        '
        Me.listAssignClassViewDocument.ActionCaption = "Class"
        Me.listAssignClassViewDocument.ActionImageOptions.Image = Global.SRCSv3._1.My.Resources.Resources.network
        Me.listAssignClassViewDocument.Caption = "Classes"
        Me.listAssignClassViewDocument.ControlName = "listAssignClassView"
        Me.listAssignClassViewDocument.ControlTypeName = "SRCSv3._1.listAssignClassView"
        Me.listAssignClassViewDocument.Header = "Class dashboard"
        Me.listAssignClassViewDocument.ImageOptions.Image = Global.SRCSv3._1.My.Resources.Resources._005_class1
        '
        'addSubjectWizardDocument
        '
        Me.addSubjectWizardDocument.Caption = "Subjects"
        Me.addSubjectWizardDocument.ControlName = "addSubjectWizard"
        Me.addSubjectWizardDocument.ControlTypeName = "SRCSv3._1.addSubjectWizard"
        Me.addSubjectWizardDocument.ImageOptions.Image = Global.SRCSv3._1.My.Resources.Resources._008_text_books
        '
        'addScoresViewDocument
        '
        Me.addScoresViewDocument.Caption = "Scores"
        Me.addScoresViewDocument.ControlName = "addScoresView"
        Me.addScoresViewDocument.ControlTypeName = "SRCSv3._1.addScoresView"
        Me.addScoresViewDocument.ImageOptions.Image = Global.SRCSv3._1.My.Resources.Resources._001_grade
        '
        'reportDashboardViewDocument
        '
        Me.reportDashboardViewDocument.Caption = "Report Dashboard"
        Me.reportDashboardViewDocument.ControlName = "reportDashboardView"
        Me.reportDashboardViewDocument.ControlTypeName = "SRCSv3._1.reportDashboardView"
        Me.reportDashboardViewDocument.ImageOptions.Image = Global.SRCSv3._1.My.Resources.Resources._003_exam_results
        '
        'settingsViewDocument
        '
        Me.settingsViewDocument.Caption = "Settings"
        Me.settingsViewDocument.ControlName = "settingsView"
        Me.settingsViewDocument.ControlTypeName = "SRCSv3._1.settingsView"
        Me.settingsViewDocument.ImageOptions.Image = CType(resources.GetObject("settingsViewDocument.ImageOptions.Image"), System.Drawing.Image)
        '
        'addSubjectWizardTile
        '
        Me.addSubjectWizardTile.Appearances.Normal.BackColor = System.Drawing.Color.Silver
        Me.addSubjectWizardTile.Appearances.Normal.BorderColor = System.Drawing.Color.Silver
        Me.addSubjectWizardTile.Appearances.Normal.ForeColor = System.Drawing.Color.Black
        Me.addSubjectWizardTile.Appearances.Normal.Options.UseBackColor = True
        Me.addSubjectWizardTile.Appearances.Normal.Options.UseBorderColor = True
        Me.addSubjectWizardTile.Appearances.Normal.Options.UseForeColor = True
        Me.addSubjectWizardTile.Document = Me.addSubjectWizardDocument
        TileItemElement5.Image = Global.SRCSv3._1.My.Resources.Resources.Shape_78
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement5.ImageLocation = New System.Drawing.Point(0, -10)
        TileItemElement5.Text = ""
        TileItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement6.Appearance.Normal.Options.UseFont = True
        TileItemElement6.Text = "Subjects"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.addSubjectWizardTile.Elements.Add(TileItemElement5)
        Me.addSubjectWizardTile.Elements.Add(TileItemElement6)
        Me.addSubjectWizardTile.Name = "addSubjectWizardTile"
        '
        'Tile7
        '
        Me.Tile7.Appearances.Normal.BackColor = System.Drawing.Color.Silver
        Me.Tile7.Appearances.Normal.BorderColor = System.Drawing.Color.Silver
        Me.Tile7.Appearances.Normal.ForeColor = System.Drawing.Color.Black
        Me.Tile7.Appearances.Normal.Options.UseBackColor = True
        Me.Tile7.Appearances.Normal.Options.UseBorderColor = True
        Me.Tile7.Appearances.Normal.Options.UseForeColor = True
        Me.Tile7.Document = Me.addScoresViewDocument
        TileItemElement7.Image = Global.SRCSv3._1.My.Resources.Resources._002_grade_1
        TileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement7.ImageLocation = New System.Drawing.Point(0, -10)
        TileItemElement7.Text = ""
        TileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement8.Appearance.Normal.Options.UseFont = True
        TileItemElement8.Text = "Scores"
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement8.TextLocation = New System.Drawing.Point(0, 7)
        Me.Tile7.Elements.Add(TileItemElement7)
        Me.Tile7.Elements.Add(TileItemElement8)
        Me.Tile7.Name = "Tile7"
        '
        'SubjectSummaryTile
        '
        Me.SubjectSummaryTile.Appearances.Normal.BackColor = System.Drawing.Color.Silver
        Me.SubjectSummaryTile.Appearances.Normal.BorderColor = System.Drawing.Color.Silver
        Me.SubjectSummaryTile.Appearances.Normal.Options.UseBackColor = True
        Me.SubjectSummaryTile.Appearances.Normal.Options.UseBorderColor = True
        TileItemElement1.Image = Global.SRCSv3._1.My.Resources.Resources.email
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement1.Text = ""
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Black
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Appearance.Normal.Options.UseForeColor = True
        TileItemElement2.StretchVertical = True
        TileItemElement2.Text = "Send Results"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement2.TextLocation = New System.Drawing.Point(14, 0)
        Me.SubjectSummaryTile.Elements.Add(TileItemElement1)
        Me.SubjectSummaryTile.Elements.Add(TileItemElement2)
        Me.SubjectSummaryTile.Group = "2"
        Me.SubjectSummaryTile.Name = "SubjectSummaryTile"
        Me.SubjectSummaryTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        '
        'Tile2
        '
        Me.Tile2.Appearances.Normal.BackColor = System.Drawing.Color.Silver
        Me.Tile2.Appearances.Normal.BorderColor = System.Drawing.Color.Silver
        Me.Tile2.Appearances.Normal.ForeColor = System.Drawing.Color.Black
        Me.Tile2.Appearances.Normal.Options.UseBackColor = True
        Me.Tile2.Appearances.Normal.Options.UseBorderColor = True
        Me.Tile2.Appearances.Normal.Options.UseForeColor = True
        Me.Tile2.Document = Me.settingsViewDocument
        TileItemElement3.Image = Global.SRCSv3._1.My.Resources.Resources.Shape_154
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement3.Text = ""
        TileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement4.Appearance.Normal.Options.UseFont = True
        TileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None
        TileItemElement4.Text = "School Setup"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemElement4.TextLocation = New System.Drawing.Point(0, 7)
        Me.Tile2.Elements.Add(TileItemElement3)
        Me.Tile2.Elements.Add(TileItemElement4)
        Me.Tile2.Group = "2"
        Me.Tile2.Name = "Tile2"
        Me.Tile2.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        '
        'reportDashboardViewTile
        '
        Me.reportDashboardViewTile.Appearances.Normal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.reportDashboardViewTile.Appearances.Normal.BorderColor = System.Drawing.Color.Silver
        Me.reportDashboardViewTile.Appearances.Normal.ForeColor = System.Drawing.Color.Black
        Me.reportDashboardViewTile.Appearances.Normal.Options.UseBackColor = True
        Me.reportDashboardViewTile.Appearances.Normal.Options.UseBorderColor = True
        Me.reportDashboardViewTile.Appearances.Normal.Options.UseForeColor = True
        Me.reportDashboardViewTile.Document = Me.reportDashboardViewDocument
        TileItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement11.Appearance.Normal.Options.UseFont = True
        TileItemElement11.Image = Global.SRCSv3._1.My.Resources.Resources.Shape_109
        TileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement11.ImageLocation = New System.Drawing.Point(-40, 30)
        TileItemElement11.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement11.Text = "CAT reports"
        TileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileItemElement12.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        TileItemElement12.Appearance.Normal.Options.UseFont = True
        TileItemElement12.Image = Global.SRCSv3._1.My.Resources.Resources.Shape_70
        TileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement12.ImageLocation = New System.Drawing.Point(-34, 90)
        TileItemElement12.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement12.Text = "Score reports"
        TileItemElement13.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        TileItemElement13.Appearance.Normal.Options.UseFont = True
        TileItemElement13.Image = Global.SRCSv3._1.My.Resources.Resources._004_certificate
        TileItemElement13.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement13.ImageLocation = New System.Drawing.Point(-45, 150)
        TileItemElement13.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement13.Text = "Master list"
        TileItemElement14.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        TileItemElement14.Appearance.Normal.Options.UseFont = True
        TileItemElement14.Image = Global.SRCSv3._1.My.Resources.Resources.Shape_92
        TileItemElement14.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement14.ImageLocation = New System.Drawing.Point(-5, 210)
        TileItemElement14.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement14.Text = "Class ranking report"
        Me.reportDashboardViewTile.Elements.Add(TileItemElement11)
        Me.reportDashboardViewTile.Elements.Add(TileItemElement12)
        Me.reportDashboardViewTile.Elements.Add(TileItemElement13)
        Me.reportDashboardViewTile.Elements.Add(TileItemElement14)
        Me.reportDashboardViewTile.Group = "2"
        Me.reportDashboardViewTile.Name = "reportDashboardViewTile"
        Me.reportDashboardViewTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Large
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 589)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listAssignClassViewDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addSubjectWizardDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addScoresViewDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportDashboardViewDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingsViewDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addSubjectWizardTile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectSummaryTile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportDashboardViewTile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Private WithEvents windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
    Private WithEvents mainTileContainer As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
    Friend WithEvents addEditScoresTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents addEditScoresDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents XtraUserControl1Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents xtraUserControl1Document As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents mainControlTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents mainControlDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents addUserViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents settingsViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents studentListViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents YTCNavViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents yTCNavViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents YTCSNavViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents yTCSNavViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents addClassViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents addClassViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents addScoresViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents addScoresViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents listAssignClassViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents TabbedGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup
    Friend WithEvents TabbedGroup2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup
    Friend WithEvents TabbedGroup3 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup
    Friend WithEvents mainDashboardDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents MainDashboardTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents promoteStudentViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents addSubjectViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents PageGroup1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup
    Friend WithEvents addSubjectWizardDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents Tile2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents Tile4 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents addSubjectWizardTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents Tile6 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents Tile7 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents SubjectSummaryTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents classSummaryTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents listAssignClassViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents Tile8 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents reportDashboardViewDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents reportDashboardViewTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
End Class
