
Imports System.Data.OleDb
Imports System.Text
Imports DevExpress
Imports DevExpress.XtraEditors

Partial Public Class addSubjectWizard
    '' Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)

    Private dlg As DevExpress.Utils.WaitDialogForm = Nothing
    Dim i As Integer = 1
    Public user As String

#Region "ALL DATA"
    Public Sub New(currentSession As SessionSettings)
        InitializeComponent()
        initEditors(currentSession)
    End Sub
    Private Sub initEditors(currentSession As SessionSettings)
        r_yrcb.Text = currentSession.academicSession
        r_semcb.Text = currentSession.term

        TileView1.FocusedRowHandle = 0
        NavigationFrame1.SelectedPage = nav1_setyr
        subjectTeacherREP.Items.AddRange(userController_.getAllUsers.Select(Function(x) x.fullName).Distinct.ToList)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles r_a_nextbtn.Click
        getListOfAllClassesBySessionIDSection(GlobalCurrentSession)
    End Sub

    Private Sub getListOfAllClassesBySessionIDSection(currentSession As SessionSettings)
        If r_sectionCB.Text <> Nothing Then
            classGridControl.DataSource = classController.GetListOfAllClassesBySessionIDSection(currentSession.sessionID, r_sectionCB.Text)
            LabelControl3.Text = "Subjects for " + r_sectionCB.Text + " section"
            NavigationFrame1.SelectNextPage()
        Else
            MessageBox.Show("Select the section you want to work on.")
        End If
    End Sub
    Private Sub loadSubjectsForSelectedClass(currentSession As SessionSettings, section As String, class_ As StdClass)
        Try
            If section IsNot Nothing Then
                'SubjectTableTableAdapter.FillBySection(DbDataSet.subjectTable, section)
                subjectGridControl.DataSource = subjectController_.getDefaultSubjectsByClass(section, class_.stdClass)
                For Each subject In subjectController_.getSubjectsBySessionIDClassID(currentSession.sessionID, class_.classID)
                    Dim row As Integer = subjectsView.LocateByDisplayText(0, colSubject, subject.subjectName)
                    subjectsView.SelectRow(row)
                    subjectsView.SetRowCellValue(row, "subjectTeacherName", subject.subjectTeacherName)
                Next
            End If
            If subjectsView.RowCount < 1 Then
                If MessageBox.Show("No default subject registered for this class." + vbCrLf _
                                   + "Do you want to add default subjects?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    showDefaultSubjectControls()
                End If
            End If

        Catch ex As Exception
            If TileView1.RowCount < 1 Then
                MessageBox.Show("No Class registered in this section! Right click to add class.")
                subjectGridControl.DataSource = Nothing
            End If
        End Try
    End Sub

    Dim teacherDict As New Dictionary(Of Integer, String)
    Private Sub subjectsView_CustomUnboundColumnData(sender As Object, e As XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles subjectsView.CustomUnboundColumnData
        Dim rowHandle As Integer = e.ListSourceRowIndex
        If e.IsGetData Then
            If Not teacherDict.ContainsKey(rowHandle) Then
                teacherDict.Add(rowHandle, "Not assigned.")
            End If
            e.Value = teacherDict(rowHandle)
        End If
        If e.IsSetData Then
            teacherDict(rowHandle) = Convert.ToString(e.Value)
        End If
    End Sub

    Private Sub TileView1_FocusedRowChanged(sender As Object, e As XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles TileView1.FocusedRowChanged
        loadSubjectsForSelectedClass(GlobalCurrentSession, r_sectionCB.Text, currentClass)
    End Sub

    Private Function currentClass() As StdClass
        Return TryCast(TileView1.GetFocusedRow, StdClass)
    End Function
    Private Sub saveSubjects(currentSession As SessionSettings, section As String, classs As StdClass, gv As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim sb As New StringBuilder
        Try
            WaitDlg(sWaitDlgStatus.Show, "Saving Subjects...")
            Dim subjects As New List(Of Subject)
            subjectController_.deleteSubjects(currentSession.sessionID, classs.classID)
            sb.Append(String.Format("Class {0}:", classs.stdClass) + vbCrLf)
            Dim counter As Integer = 0
            For Each rowHandle In gv.GetSelectedRows
                Dim subject As New Subject
                subject.sessionID = currentSession.sessionID
                subject.classID = classs.classID
                subject.stdClass = classs.stdClass
                subject.subjectName = gv.GetRowCellDisplayText(rowHandle, "subjectName")
                subject.subjectTeacherName = gv.GetRowCellDisplayText(rowHandle, "subjectTeacherName")
                subject.subjectID = gv.GetRowCellDisplayText(rowHandle, "subjectID")
                subject.section = section

                subjectController_.addSubject(subject)
                For Each student In stdController.getStudentsSessionIDClassID(currentSession.sessionID, classs.classID)
                    Dim score As New Score
                    score.stdID = student.stdID
                    score.sessionID = currentSession.sessionID
                    score.classID = classs.classID
                    score.subjectID = subject.subjectID
                    score.studentFullName = student.fullName

                    scoreController_.addScore(score)
                    ' sb.Append(Chr(9) & String.Format("  {0} score(s) created.", counter) + vbCrLf)
                Next
                'counter += 1
            Next
            WaitDlg(sWaitDlgStatus.Hide)
            If statusController.status Then
                XtraMessageBox.Show(statusController.message + vbCrLf + sb.ToString, messageController.caption)
            Else
                MessageBox.Show(statusController.message, messageController.caption)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        saveSubjects(GlobalCurrentSession, r_sectionCB.Text, currentClass, subjectsView)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles t_bckbtn.Click
        NavigationFrame1.SelectPrevPage()
    End Sub
    Private Sub SimpleButton1_Click_2(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        NavigationFrame1.SelectPrevPage()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        subjectTeacherREP.Items.AddRange(userController_.getAllUsersNamesBySessionID(GlobalCurrentSession.sessionID))
        ' gridControl1.DataSource = getSelectedSubjectsFromCLB(r_classCB.Text, subjectsCheckedListBox)
        NavigationFrame1.SelectNextPage()
    End Sub
    Private Sub showDefaultSubjectControls()
        If currentClass() IsNot Nothing Then
            Dim addDefaultSubject As New addDefaultSubjectView
            addDefaultSubject.ComboBoxEdit1.Text = r_sectionCB.Text
            Dim indexForm As New indexForm(Me, addDefaultSubject)
            indexForm.Show(Me.FindForm)
        Else
            MessageBox.Show("Select a class.")
        End If

    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        showDefaultSubjectControls()
    End Sub

    Private Sub TileView1_ItemClick(sender As Object, e As XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView1.ItemClick
        loadSubjectsForSelectedClass(GlobalCurrentSession, r_sectionCB.Text, currentClass)
    End Sub

    Private Sub r_yrcb_EditValueChanged(sender As Object, e As EventArgs) Handles r_yrcb.EditValueChanged

    End Sub

#End Region
End Class

