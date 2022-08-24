Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Public Class emptyCatSheetReport
    Public Sub New(sessionID As String, classID As String, schoolSettings As SchoolSettings)
        ' Me.sessionIDParameter.Value = year
        ' This call is required by the designer.
        InitializeComponent()
        '' MsgBox(sessionID)
        ' Add any initialization after the InitializeComponent() call.
        sessionIDParams.Value = sessionID
        classIDParams.Value = classID
        XrNameOfSchool.Text = schoolSettings.schName
        XrSchAddress.Text = schoolSettings.schAddress
        ''MsgBox(sessionIDParams.Value)



        'lblAss1.Text = "Ass 1 " + "(" + sch.DefaultAssScore.ToString + ")"
        'lblAss2.Text = "Ass 2 " + "(" + sch.DefaultAssScore.ToString + ")"
        'lbl1stCa.Text = "Test 1 " + "(" + sch.DefaultTestScore.ToString + ")"
        'lbl2ndCa.Text = "Test 2 " + "(" + sch.DefaultTestScore.ToString + ")"
        'lblExam.Text = "Exam " + "(" + sch.DefaultExamScore.ToString + ")"
    End Sub

    Private counter As Integer = 0
    Private Sub XrTableCell16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell16.BeforePrint


    End Sub

    Private Sub GroupFooter1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint

    End Sub

    Private Sub XrTableCell15_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles XrTableCell16.PrintOnPage

    End Sub
End Class