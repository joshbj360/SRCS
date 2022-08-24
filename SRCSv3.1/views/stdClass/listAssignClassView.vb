Imports System.Data.OleDb
Imports System.Text
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Class listAssignClassView
    '' Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Private schoolSettings As SchoolSettings = setsController.getSchoolSettings
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors(GlobalCurrentSession.academicSession, GlobalCurrentSession.term)
    End Sub

    Public Sub initEditors(ByVal year As String, term As String)
        Try
            cmbAcadyr.Text = year
            cmbTerm.Text = term

            classGridControl.DataSource = classController.GetListOfAllClassesBySessionID(GlobalCurrentSession.sessionID)
            TileView2.FocusedRowHandle = 1
        Catch ex As Exception

        End Try

    End Sub
#Region "Student"
    Private Sub studentUIPanel_ButtonChecked(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles studentUIPanel.ButtonChecked
        If e.Button.Properties.Caption = "Select" Then
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True
            GridView1.SelectRow(GridView1.FocusedRowHandle)
        End If
    End Sub

    Private Sub studentUIPanel_ButtonUnchecked(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles studentUIPanel.ButtonUnchecked
        If e.Button.Properties.Caption = "Select" Then
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
            GridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False
        End If
    End Sub
    Private Sub WindowsUIButtonPanel2_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles studentUIPanel.ButtonClick
        ' Try
        If e.Button.Properties.Caption = "Add" Then
            Dim addStdFrm As New addStudentForm(currentClass)
            addStdFrm.cmbSection.Text = currentClass.section
            addStdFrm.cmbclass.Text = currentClass.stdClass
            addStdFrm.sbOK.Tag = "add"

            Dim indexform As New indexForm(Me, addStdFrm)
            indexform.Show(Me.FindForm)
        End If
        If e.Button.Properties.Caption = "Edit" Then
            If currentStudent() IsNot Nothing Then
                Dim addStdFrm As New addStudentForm(currentStudent)
                addStdFrm.sbOK.Tag = "update"
                Dim indexform As New indexForm(Me, addStdFrm)
                indexform.Text = ("Update " + currentStudent.fullName + " Bio data").ToUpper
                indexform.Show(Me.FindForm)
            Else
                MessageBox.Show("No student selected", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
        If e.Button.Properties.Caption = "Delete" Then
            If Not GridView1.RowCount < 1 And Not GridView1.SelectedRowsCount < 1 Then

                If XtraMessageBox.Show(String.Format("Do you want to delete {0} record(s) and academic records?", GridView1.SelectedRowsCount),
                                       caption:=messageController.caption,
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question
                                       ) = DialogResult.Yes Then

                    For Each studentRowIndex In GridView1.GetSelectedRows
                        Dim student = TryCast(GridView1.GetRow(studentRowIndex), student_)
                        deleteStudentAndScores(GlobalCurrentSession.sessionID, currentClass.classID, student)
                    Next
                End If
            Else
                XtraMessageBox.Show("No student to delete.", caption:=messageController.caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        'Catch ex As Exception

        'End Try

    End Sub
    Private Sub deleteStudentAndScores(SessionID As String, classID As String, student As student_)
        stdController.deleteStudent(student.stdID)
        scoreController_.deleteScoreFromAllSubjects(SessionID, classID, student.stdID)
        GridView1.DeleteSelectedRows()
    End Sub
    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        If e.Clicks = 2 Then
            If currentStudent() IsNot Nothing Then
                Dim addStdFrm As New addStudentForm(currentStudent)
                addStdFrm.sbOK.Tag = "update"
                Dim indexform As New indexForm(Me, addStdFrm)
                indexform.Text = ("Update " + currentStudent.fullName + " Bio data").ToUpper
                indexform.Show(Me.FindForm)
            Else
                MessageBox.Show("No student selected", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub
    Private Function currentStudent() As student_
        Return TryCast(GridView1.GetFocusedRow, student_)
    End Function
#End Region
#Region "Classes"
    Private Sub classUIPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles classUIPanel1.ButtonClick
        If e.Button.Properties.Caption = "Add" Then
            Dim inForm As New indexForm(Me, New addClassView(GlobalCurrentSession))
            inForm.Show(Me.FindForm)

        End If
        If e.Button.Properties.Caption = "Edit" Then
            Dim inForm As New indexForm(Me, New addClassView(currentClass))
            inForm.Show(Me.FindForm)
        End If
        If e.Button.Properties.Caption = "Delete" Then
            If MessageBox.Show(
                               "Sure To delete " + currentClass.stdClass + " ?",
                               "SRCS - Current Session: " + GlobalCurrentSession.sessionID,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                classController.deleteClass(currentClass)
                refreshData()
            End If
        End If
    End Sub
    Private Sub promoteClass(currentSession As SessionSettings)
        If classController.GetListOfAllClassesBySessionID(currentSession.sessionID).Count < 1 Then
            Dim promoteControl1 As New promoteStudentView()
            Dim inForm1 As New indexForm(Me, promoteControl1)
            inForm1.WindowState = FormWindowState.Maximized
            inForm1.Show(Me.FindForm)
        Else
            Dim promotecontrol As New promoteStudentView()

            promotecontrol.cmbYear1.Text = cmbAcadyr.Text
            promotecontrol.cmbTerm1.Text = cmbTerm.Text
            promotecontrol.cmbClass1.Text = currentClass.stdClass

            Dim inForm As New indexForm(Me, promotecontrol)
            inForm.WindowState = FormWindowState.Maximized
            inForm.Show(Me.FindForm)
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        promoteClass(GlobalCurrentSession)
    End Sub

    Private Function currentClass() As StdClass
        Return TryCast(TileView2.GetFocusedRow, StdClass)
    End Function
    Private Sub TileView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles TileView2.FocusedRowChanged
        loadSelectedClassDetails(GlobalCurrentSession.sessionID, currentClass.classID)
    End Sub

    Private Sub loadSelectedClassDetails(sessionID As String, classID As String)
        studentGridControl.DataSource = stdController.getStudentsSessionIDClassID(sessionID, classID)
        classRankListControl.DataSource = scoreController_.getRankedScores(sessionID, classID).Distinct
        ScoresReportQueryTableAdapter.FillSessionIDClassID(DbDataSet.scoresReportQuery, sessionID, classID)
        ' MsgBox(ScoresReportQueryTableAdapter.ScalarQueryBySessionIDGroupID("2021/2022/FirstTerm", "6ef43425691c42929df011aaf5103a81"))
    End Sub

    Private Sub TileView2_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView2.ItemClick
        loadSelectedClassDetails(GlobalCurrentSession.sessionID, currentClass.classID)
    End Sub

#End Region
    Public Overrides Sub refreshData()
        MyBase.refreshData()
        Try
            classGridControl.DataSource = classController.GetListOfAllClassesBySessionID(GlobalCurrentSession.sessionID)
            studentGridControl.DataSource = stdController.getStudentsSessionIDClassID(
                           GlobalCurrentSession.sessionID,
                           currentClass.classID
                       )
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "SRCS - Current Session: " + GlobalCurrentSession.sessionID)
        End Try

    End Sub

    ' Print class score ranking
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If currentClass() IsNot Nothing Then
            Dim b As New scoreRankingReport(GlobalCurrentSession, currentClass)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub

    'print empty CAT sheet for the current class
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If currentClass() IsNot Nothing Then
            Dim b As New emptyCatSheetReport(GlobalCurrentSession.sessionID, currentClass.classID, schoolSettings)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub

    'rint all the results.
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If currentClass() IsNot Nothing Then
            Dim b As New scoresReport(GlobalCurrentSession, currentClass.classID)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub

    'print masterlist for current class
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If currentClass() IsNot Nothing Then
            Dim b As New masterScoreReport()
            'Dim b As New XtraReport1
            '' b.SessionIDParams.Value = currentSession.sessionID
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub

    Private Sub classRankListControl_DoubleClick(sender As Object, e As EventArgs) Handles classRankListControl.DoubleClick
        Dim s As Score = TryCast(classRankListControl.SelectedItem, Score)
        Dim sb As New StringBuilder
        sb.Append(s.studentFullName)
        sb.Append(s.stdID)
        sb.Append(s.sessionID)
        sb.Append(s.classID)
        'MsgBox(sb.ToString)
        If currentClass() IsNot Nothing Then
            Dim b As New scoresReport(s, GlobalCurrentSession, currentClass.classID)
            b.studentIDParams.Value = s.stdID
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If currentClass() IsNot Nothing Then
            Dim b As New thirdTermScoresReport(GlobalCurrentSession, currentClass.classID)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If currentClass() IsNot Nothing Then
            Dim b As New thirdTermScoresReportEmpty(GlobalCurrentSession, currentClass.classID)
            CType(New ReportPrintTool(b), ReportPrintTool).ShowRibbonPreview()
        End If
    End Sub
End Class
