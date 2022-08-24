Imports DevExpress.XtraReports.UI

Public Class MainDashboard
    'Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim b As New masterScoreReport()
        'Dim b As New XtraReport1
        '    b.sessionIDParams.Value = currentSession.sessionID
        CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()

    End Sub
End Class
