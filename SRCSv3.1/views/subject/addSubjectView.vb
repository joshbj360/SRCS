Public Class addSubjectView
    '' Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' initEditors(currentSession.academicSession, currentSession.term, cmbSection.Text)
    End Sub
    Public Sub New(currentSession As SessionSettings)
        ' This call is required by the designer.
        InitializeComponent()
        initEditors(currentSession)
        ''currentSession = setsController.CurrentSession(year, term)
    End Sub
    Private Sub initEditors(currentSession As SessionSettings)
        ' Add any initialization after the InitializeComponent() call.
        cmbYear.Text = currentSession.academicSession
        cmbTerm.Text = currentSession.term

        defaultSubjectsRepCmb.Items.AddRange(userController_.getAllUsersNamesBySessionID(currentSession.sessionID))
        ' GridControl1.DataSource = classController.getListOfAllClassesBySessionIDSection(currentSession.sessionID, cmbSection.Text)
    End Sub
    Public Overrides Sub refreshData()
        MyBase.refreshData()
        If cmbYear.Text <> Nothing And cmbTerm.Text <> Nothing Then
            'DefaultSubjectTableTableAdapter.FillBySection(DbDataSet.defaultSubjectTable, cmbSection.Text)
            subjectRepCmb.Items.AddRange(userController_.getAllUsersNamesBySessionID(GlobalCurrentSession.sessionID))
            ' GridControl1.DataSource = classController.getListOfAllClassesBySessionIDSection(currentSession.sessionID, cmbSection.Text)
            If currentClass() IsNot Nothing Then
                loadFocusedClass()
            End If
        End If
    End Sub
    Private Function currentClass() As StdClass
        Return TryCast(TileView1.GetFocusedRow, StdClass)
    End Function
    Private Sub loadFocusedClass()
        Try
            'If cmbSection.Text IsNot Nothing Then
            '    SubjectTableTableAdapter.FillBySection(DbDataSet.subjectTable, cmbSection.Text)
            'End If

            For Each subject In subjectController_.getSubjectsBySessionIDClassID(GlobalCurrentSession.sessionID, currentClass.classID)
                GridView2.SelectRow(GridView2.LocateByDisplayText(0, colsubjectName1, subject.subjectName))
            Next
        Catch ex As Exception
            If TileView1.RowCount < 1 Then
                MessageBox.Show("No Class registered in this section! Right click to add class.")
            End If
        End Try
    End Sub
    Private Sub TileView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles TileView1.FocusedRowChanged
        loadFocusedClass()
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs)
        refreshData()
    End Sub
    Private Sub saveDefaultSubject(gv As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim rowHandle As Integer = 0
        While gv.IsValidRowHandle(rowHandle)
            Dim std As New DefaultSubject(gv.GetDataRow(rowHandle))
            ' std.section = cmbSection.Text
            subjectController_.addDefaultSubject(std)
            rowHandle = rowHandle + 1
        End While
    End Sub

    'default subjects
    Private Sub defaualtSubjectUIPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)

        If e.Button.Properties.Caption = "Select" Then
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        End If
        If e.Button.Properties.Caption = "Delete" Then
            If GridView1.GetSelectedRows.Count >= 1 Then
                If MessageBox.Show("Sure to delete selected subject(s)? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    GridView1.DeleteSelectedRows()
                    saveDefaultSubject(GridView1)
                End If
            End If
        End If
    End Sub
    Private Sub saveSubjects(sessionID As String, classID As String, gv As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim subjects As New List(Of Subject)
        For Each rowHandle In gv.GetSelectedRows
            Dim subject As New Subject
            subject.sessionID = sessionID
            subject.classID = classID
            subject.subjectName = gv.GetRowCellDisplayText(rowHandle, "subjectName")
            subject.subjectTeacherName = gv.GetRowCellDisplayText(rowHandle, "subjectTeacherName")
            subject.subjectID = gv.GetRowCellDisplayText(rowHandle, "subjectID")
            '      subject.section = cmbSection.Text

            subjectController_.addSubject(subject)
        Next

        For Each student In stdController.getStudentsSessionIDClassID(sessionID, classID)
            For Each subject In subjectController_.getSubjectsBySessionIDClassID(sessionID, classID)
                Dim score As New Score
                score.stdID = student.stdID
                score.sessionID = sessionID
                score.classID = classID
                score.subjectID = subject.subjectID

                scoreController_.addScore(score)
            Next
        Next
    End Sub
    Private Sub subjectUIPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles subjectUIPanel.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            saveSubjects(GlobalCurrentSession.sessionID, currentClass.classID, GridView2)
            refreshData()
        End If
        If e.Button.Properties.Caption = "Delete" Then
            If MessageBox.Show("Sure to delete selected subjects?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GridView2.DeleteSelectedRows()
                saveSubjects(GlobalCurrentSession.sessionID, currentClass.classID, GridView2)
                refreshData()
            End If

        End If
    End Sub

    Private Sub AddClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClassToolStripMenuItem.Click
        Dim indexForm As New indexForm(Me, New addClassView(GlobalCurrentSession))
        indexForm.Show(Me.FindForm)
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Dim indexForm As New indexForm(Me, New addUserView(GlobalCurrentSession))
        indexForm.Show(Me.FindForm)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        saveDefaultSubject(GridView1)
        refreshData()
    End Sub

    Private Sub subjectGridControl_Click(sender As Object, e As EventArgs) Handles subjectGridControl.Click

    End Sub
End Class
