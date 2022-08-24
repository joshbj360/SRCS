Imports DevExpress.XtraReports.UI

Public Class reportDashboardView
    '' Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Private schoolSettings As SchoolSettings = setsController.getSchoolSettings
    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        StdClassTableTableAdapter.FillBySessionID(DbDataSet.stdClassTable, currentSession.sessionID)
        ComboBoxEdit1.Properties.Items.AddRange(setsController.getAllSessions.Select(Function(x) x.sessionID).Cast(Of String).Distinct.ToList)
    End Sub
    Private Function currentClass() As StdClass
        Return New StdClass(TileView1.GetFocusedDataRow)
    End Function
    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        If ComboBoxEdit1.Text <> Nothing Then
            StdClassTableTableAdapter.FillBySessionID(DbDataSet.stdClassTable, ComboBoxEdit1.Text)
        Else
            MessageBox.Show("No SessionID Selected")
        End If

    End Sub
    Public Overrides Sub refreshData()
        MyBase.refreshData()
        '' StdClassTableTableAdapter.FillBySessionID(DbDataSet.stdClassTable, currentSession.sessionID)
        ComboBoxEdit1.Properties.Items.AddRange(setsController.getAllSessions.Select(Function(x) x.sessionID).Cast(Of String).Distinct.ToList)
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles catReportTile.ItemClick

    End Sub
    Private Sub printCATSheet(currentSession As SessionSettings)
        If currentClass() IsNot Nothing Then
            Dim b As New emptyCatSheetReport(currentSession.sessionID, currentClass.classID, schoolSettings)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        Else
            MessageBox.Show("No class selected!")
        End If
        '  MessageBox.Show(currentClass.stdClass)
    End Sub
    Private Sub stdReportTile_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles stdReportTile.ItemClick

    End Sub
    Private Sub PrintScoreReport(currentSession As SessionSettings)
        If currentClass() IsNot Nothing Then
            Dim b As New scoresReport(currentSession, currentClass.classID)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        Else
            MessageBox.Show("No class selected!")
        End If
    End Sub
    Private Sub masterListReportTile_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles masterListReportTile.ItemClick

    End Sub
    Private Sub PringMasterList(CurrentSession As SessionSettings)
        If currentClass() IsNot Nothing Then
            Dim b As New masterScoreReport(CurrentSession.sessionID, currentClass.classID) ', schoolSettings)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        Else
            MessageBox.Show("No class selected!")
        End If
    End Sub
    Private Sub avgRankedReportTile_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles avgRankedReportTile.ItemClick

    End Sub
    Private Sub PrintAVGRankedReport(currentSession As SessionSettings)
        If currentClass() IsNot Nothing Then
            Dim b As New scoreRankingReport(currentSession, currentClass) ', schoolSettings)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        Else
            MessageBox.Show("No class selected!")
        End If
    End Sub
    Private Sub topThreeReportTile_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles topThreeReportTile.ItemClick

    End Sub
    Private Sub PrintTopThreeReport(currentSession As SessionSettings)
        If currentClass() IsNot Nothing Then
            Dim b As New allClassAvgRankedScoresReport(schoolSettings)
            b.sessionIdParams.Value = currentSession.sessionID
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        Else
            MessageBox.Show("No class selected!")
        End If
    End Sub
End Class
