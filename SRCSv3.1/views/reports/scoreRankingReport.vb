Imports DevExpress.XtraReports.UI
Public Class scoreRankingReport
    Private schoolSettings As SchoolSettings = setsController.getSchoolSettings

    Public Sub New(session As SessionSettings, Stdclass As StdClass)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = schoolSettings.schName
        XrSchAddress.Text = schoolSettings.schAddress
        XrYear.Text = session.academicSession
        XrTerm.Text = session.term
        XrClass.Text = Stdclass.stdClass
        XrFromTeacher.Text = Stdclass.formTeacherName
        ScoresReportQueryTableAdapter1.FillScoresBySessionIDClassID(DbDataSet1.scoresReportQuery, session.sessionID, Stdclass.classID)
    End Sub


    Private counter As Integer = 0
    Private Sub XrTableCell16_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell16.BeforePrint
        'While counter < Me.DisplayableRowCount 
        counter += 1
        CType(sender, XRTableCell).Text = String.Format("{0}", counter)
        ' End While
    End Sub
End Class