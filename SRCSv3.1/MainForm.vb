Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Partial Public Class MainForm
    Inherits XtraForm

    Private schoolSettings As SchoolSettings = New SchoolSettings()
    Public Sub New()
        InitializeComponent()
        AddHandler Me.windowsUIView1.QueryStartupContentContainer, AddressOf windowsUIView1_QueryStartupContentContainer
        AddHandler Me.windowsUIView1.QueryControl, AddressOf windowsUIView1_QueryControl
        windowsUIView1.SplashScreenProperties.Caption = "GloryLand Int'l Academy" + vbCrLf _
            + "Result Compilation Software"
        windowsUIView1.SplashScreenProperties.LoadingDescription = "Loading default settings..."

    End Sub

    Private Function adminPageGroup() As PageGroup
        Dim apg As New PageGroup
        apg.Caption = "SRCS " + schoolSettings.schName
        apg.HeaderButtonBackgroundImages = True
        apg.Items.AddRange(
            New Document() {
                      listAssignClassViewDocument,
                      addSubjectWizardDocument,
                      addScoresViewDocument,
                      reportDashboardViewDocument,
                      settingsViewDocument
                      }
            )
        Return apg
    End Function
    Private Function SubjectTeacherPageGroup() As PageGroup
        Dim spg As New PageGroup()
        spg.Properties.AllowHtmlDrawHeaders = DevExpress.Utils.DefaultBoolean.True
        spg.Caption = "Grade Engine"
        spg.Items.AddRange(New Document() {
                          addScoresViewDocument
                          })
        Return spg
    End Function
    Sub windowsUIView1_QueryStartupContentContainer(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.WindowsUI.QueryContentContainerEventArgs)
        Select Case ActiveUser.userType
            Case sUserType.subjectTeacher
                windowsUIView1.ContentContainers.Add(SubjectTeacherPageGroup)
                e.ContentContainer = SubjectTeacherPageGroup()

            Case Else
                windowsUIView1.ContentContainers.Add(adminPageGroup)
                e.ContentContainer = adminPageGroup()
        End Select
    End Sub

    ' Assigning a required content for each auto generated Document

    ' Private settingsView As New settingsView
    ' Private addSubjectWizard As New addSubjectWizard
    ' Private addScoresView As New addScoresView
    'Private listAssignClassView As New listAssignClassView
    ' Private reportDashboardView As New reportDashboardView
    Sub windowsUIView1_QueryControl(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)

        If e.Document Is settingsViewDocument Then
            e.Control = New settingsView
        End If

        'If e.Document Is mainDashboardDocument Then
        '    e.Control = New SRCSv3._1.MainDashboard()
        'End If
        If e.Document Is addSubjectWizardDocument Then
            e.Control = New addSubjectWizard(GlobalCurrentSession)
        End If

        'If e.Document Is addClassViewDocument Then
        '    e.Control = New SRCSv3._1.addClassView()
        'End If

        If e.Document Is addScoresViewDocument Then
            e.Control = New addScoresView(GlobalCurrentSession)
        End If
        If e.Document Is listAssignClassViewDocument Then
            e.Control = New listAssignClassView
        End If
        If e.Document Is reportDashboardViewDocument Then
            e.Control = New reportDashboardView(GlobalCurrentSession)
        End If
        If e.Control Is Nothing Then
            e.Control = New System.Windows.Forms.Control()
        End If
    End Sub
End Class
