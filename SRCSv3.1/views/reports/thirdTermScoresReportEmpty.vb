Imports System.Drawing.Printing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Parameters
Public Class thirdTermScoresReportEmpty
    Private reportSettings As ReportSettings = setsController.getReportSettings
    ''Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Private schoolSettings As SchoolSettings = setsController.getSchoolSettings
    Public Sub New(currentSession As SessionSettings, classID As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sessionIDParams.Value = currentSession.sessionID
        classIDParams.Value = classID
        XrNameOfSchool.Text = schoolSettings.schName
        '   xrsch_website.Text = get_Website
        XrLabel8.Text = currentSession.academicSession
        XrLabel10.Text = currentSession.term
        xrSch_phone.Text = schoolSettings.schContact
        xrSch_email.Text = schoolSettings.SchEmail
        fb_label.Text = schoolSettings.facebook
        tw_label.Text = schoolSettings.twitter
        ''    yt_label.Text = schoolSettings.linkedIn
        XrSchAddress.Text = schoolSettings.schAddress
        XrLabel2.Text = stdController.getStudentsSessionIDClassID(currentSession.sessionID, classID).Distinct.Count.ToString
        XrLabel14.Text = currentSession.noOfDaysSchOpen.ToString
        XrLabel17.Visible = reportSettings.showPosition
        XrLabel18.Visible = reportSettings.showPosition
        Try
            XrLabel19.Text = setsController.getSessionSettingsBySessionID(currentSession.sessionID).nextTermBegins.ToLongDateString
        Catch ex As Exception

        End Try
        xrsch_website.Text = schoolSettings.website
        'schWebsite.Text = get_Website
        'schEmail.Text = get_sch_email
        'vendorLogo.Image = get_sch_logo
    End Sub

    Public Sub New(ByVal s As Score, currentSession As SessionSettings, classID As String, schoolSettings As SchoolSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        XrLabel8.Text = currentSession.academicSession
        XrLabel10.Text = currentSession.term
        sessionIDParams.Value = currentSession.sessionID
        classIDParams.Value = classID
        XrNameOfSchool.Text = schoolSettings.schName
        '   xrsch_website.Text = get_Website
        xrSch_phone.Text = schoolSettings.schContact
        xrSch_email.Text = schoolSettings.SchEmail
        fb_label.Text = schoolSettings.facebook
        tw_label.Text = schoolSettings.twitter
        ''  yt_label.Text = schoolSettings.linkedIn
        XrSchAddress.Text = schoolSettings.schAddress
        XrLabel2.Text = stdController.getStudentsSessionIDClassID(currentSession.sessionID, classID).Distinct.Count.ToString
        XrLabel14.Text = currentSession.noOfDaysSchOpen.ToString
        XrLabel17.Visible = reportSettings.showPosition
        XrLabel18.Visible = reportSettings.showPosition
        Try
            XrLabel19.Text = setsController.getSessionSettingsBySessionID(currentSession.sessionID).nextTermBegins.ToLongDateString
        Catch ex As Exception

        End Try
        xrsch_website.Text = schoolSettings.website
        'schWebsite.Text = get_Website
        'schEmail.Text = get_sch_email
        'vendorLogo.Image = get_sch_logo

        '  ParamsStdId.Value = "0d1b846db15241e3891310e861358aa4JSS1B" ' s.StudentID


        Dim Para1 As New Parameter()
        Para1.Name = "IdsOfStudents"

        Para1.Type = GetType(System.String)
        Para1.MultiValue = False
        Para1.Description = "Click Submit to Query:"

        Dim lookupSettings As New DynamicListLookUpSettings()
        lookupSettings.DataSource = Me.DataSource
        lookupSettings.DataMember = "Query"
        lookupSettings.DisplayMember = "stdID"
        lookupSettings.ValueMember = "stdID"

        Para1.LookUpSettings = lookupSettings
        Para1.Visible = True
        '  Para1.selectAllValues = True
        Me.FilterString = "stdID in (?IdsOfStudents)"

        Para1.Value = s.stdID
        Parameters.Add(Para1)

    End Sub

    Private Sub InitFormatRule(Optional useRule As DevExpress.Utils.DefaultBoolean = False)
        FAssFormattingRule1.Formatting.Visible = useRule
        SAssFormattingRule2.Formatting.Visible = useRule
        FTestFormattingRule3.Formatting.Visible = useRule
        STestFormattingRule1.Formatting.Visible = useRule
        ExamFormattingRule1.Formatting.Visible = useRule
        TotalFormattingRule4.Formatting.Visible = useRule
        GradeFormattingRule5.Formatting.Visible = useRule

        FAssFormattingRule1.Condition = "[firstAss]<" + (reportSettings.assScore * (reportSettings.redMarkPercentage / 100)).ToString
        SAssFormattingRule2.Condition = "[secondAss]<" + (reportSettings.assScore * (reportSettings.redMarkPercentage / 100)).ToString
        FTestFormattingRule3.Condition = "[firstCA]<" + (reportSettings.testScore * (reportSettings.redMarkPercentage / 100)).ToString
        STestFormattingRule1.Condition = "[secondCA]<" + (reportSettings.testScore * (reportSettings.redMarkPercentage / 100)).ToString
        ExamFormattingRule1.Condition = "[exam] < " + (reportSettings.examScore * (reportSettings.redMarkPercentage / 100)).ToString
        TotalFormattingRule4.Condition = "[totalScore] < " + (reportSettings.testScore * (reportSettings.redMarkPercentage / 100)).ToString

    End Sub

    Private Sub report_sheet_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        InitFormatRule(reportSettings.useRedMark)
    End Sub
End Class