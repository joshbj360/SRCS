Imports DevExpress.XtraEditors

Partial Public Class promoteStudentView
    Public Sub New()
        InitializeComponent()
        cmbClass2.Properties.Items.AddRange(
                      classController.GetAllClasses.Select(
                      Function(x) x.stdClass).Distinct.ToList)
        cmbClass1.Properties.Items.AddRange(
                      classController.GetAllClasses.Select(
                      Function(x) x.stdClass).Distinct.ToList)
    End Sub
    Public Sub New(CurrentSession As SessionSettings, currentClass As StdClass) ''Students As List(Of student_))

        ' This call is required by the designer.
        InitializeComponent()
        cmbYear1.Text = CurrentSession.academicSession
        cmbTerm1.Text = CurrentSession.term
        cmbClass1.Text = currentClass.stdClass

        loadStudents(cmbYear1.Text, cmbTerm1.Text, cmbClass1.Text)
    End Sub

#Region "Check Count of (subject, session and Subjects)"
    Private Function StudentsExist(sessionId As String, classID As String) As Boolean
        ''  MsgBox(sessionId + " " + classID + "    " + stdController.getStudentsSessionIDClassID(sessionId, classID).Count.ToString)
        Return stdController.getStudentsSessionIDClassID(sessionId, classID).Count > 0
    End Function

    Private Function SessionExist(year As String, term As String) As Boolean
        Return setsController.getAllSessions.Exists(Function(s) s.academicSession = year And s.term = term)
    End Function

    Private Function SubjectsExist(SessionId As String, ClassID As String) As Boolean
        Return subjectController_.getSubjectsBySessionIDClassID(SessionId, ClassID).Count > 0
    End Function

    Private Function ClassExist(sessionID As String, className As String) As Boolean
        Return classController.GetAllClasses.Exists(Function(s) s.sessionID = sessionID And s.stdClass = className)
    End Function
#End Region

    Private Sub loadStudents(year As String, term As String, className As String) ''students As List(Of student_))
        WaitDlg(sWaitDlgStatus.Show, "Loading Students...")

        Try
            If SessionExist(year, term) Then
                Dim sessionID = setsController.getAllSessions.FirstOrDefault(Function(x) x.academicSession = year And x.term = term).sessionID

                If ClassExist(sessionID, className) Then
                    Dim classID = classController.GetClassBySessionIDClassNAme(sessionID, className).classID

                    If Not StudentsExist(sessionID, classID) Then
                        XtraMessageBox.Show("No student in this class for this session.", caption:=messageController.caption)
                        WaitDlg(sWaitDlgStatus.Hide)
                        Exit Sub
                    Else
                        Dim students As List(Of student_) = stdController.getStudentsSessionIDClassID(sessionID, classID)
                        statusController.message = String.Format("{0} student(s) ready to be promoted.", students.Count)

                        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
                        GridView1.OptionsSelection.MultiSelect = True

                        GridControl1.DataSource = students
                        GridView1.SelectAll()
                    End If
                Else
                    XtraMessageBox.Show("Class details for this academic session does not exist", caption:=messageController.caption)
                    WaitDlg(sWaitDlgStatus.Hide)
                    statusController.message = "No record of the selected Class."
                    Exit Sub
                End If
            Else
                XtraMessageBox.Show("Academic Session does not exist", caption:=messageController.caption)
                WaitDlg(sWaitDlgStatus.Hide)
                statusController.message = "No record of the selected academic Session."
                Exit Sub
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Unable to load students for the selected class.", caption:=messageController.caption)
        End Try
        WaitDlg(sWaitDlgStatus.Hide)
        ShowAlertForm(Me.FindForm, "Promote Students", alertmessage:=statusController.message)
        'cmbClass1.Properties.Items.Clear()
        cmbClass2.Properties.Items.Clear()
        'cmbClass1.Properties.Items.AddRange(classController.getAllClasses.Select(Function(x) x.stdClass).Distinct.ToList)
        cmbClass2.Properties.Items.AddRange(classController.GetAllClasses.Select(Function(x) x.stdClass).Distinct.ToList)
    End Sub

    Private Sub moveStuBtn_Click(sender As Object, e As EventArgs) Handles moveStuBtn.Click
        If (GridView1.RowCount < 1) Or (GridView1.SelectedRowsCount < 1) Then
            MessageBox.Show("No Student(s) selected for promotion.", caption:=messageController.caption, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim s_students As New List(Of student_)
        For Each row In GridView1.GetSelectedRows
            s_students.Add(TryCast(GridView1.GetRow(row), student_))
        Next
        'msgBox(s_students.Count)

        GridControl2.DataSource = s_students
        GridControl2.RefreshDataSource()
        GridView1.DeleteSelectedRows()
    End Sub

    Private Function validateComboBoxes(cmbYear As ComboBoxEdit, cmbTerm As ComboBoxEdit, cmbClass As ComboBoxEdit) As Boolean
        Dim validator As Boolean = True

        If cmbYear.Text = "" Or cmbTerm.Text = "" Or cmbClass.Text = "" Then
            MessageBox.Show("Enter a valid Academic Year, Term and class.")
            validator = False
        End If

        Return validator
    End Function

    Private Sub CreateNewClass(newSessionID As String)

        classController.AddClass(New StdClass With {
                            .classID = classController.generateClassID(newSessionID, cmbClass2.Text),
                                        .sessionID = newSessionID,
                                        .stdClass = cmbClass2.Text,
                                        .section = classController.GetAllClasses.FirstOrDefault(Function(s) s.stdClass = cmbClass2.Text).section,
                                        .formTeacherName = ""
                                    })
    End Sub
    Private Sub CreateNewSession()
        setsController.addSession(
                       New SessionSettings With {
                                       .academicSession = cmbYear2.Text,
                                       .term = cmbTerm2.Text,
                                       .sessionID = cmbYear2.Text + "/" + cmbTerm2.Text.Replace(" ", "")
                       })
    End Sub

    Private Sub SubjectEventSub(
                               FormerSessionID As String,
                               FormerClassID As String,
                               NewSessionID As String,
                               NewClass As StdClass,
                               Students As List(Of student_)
                               )
        MsgBox(SubjectsExist(FormerSessionID, FormerClassID))
        If SubjectsExist(FormerSessionID, FormerClassID) Then

            Dim subjects As List(Of Subject) = subjectController_.getSubjectsBySessionIDClassID(FormerSessionID, FormerClassID)

            If XtraMessageBox.Show("Do you want to copy " + subjects.Count.ToString + " subjects associated with this class?" + vbCrLf _
                                    + "This will promote the students and copy their subjects.",
                                    caption:=messageController.caption,
                                    buttons:=MessageBoxButtons.YesNo,
                                    icon:=MessageBoxIcon.Question
                                    ) = DialogResult.Yes Then
                WaitDlg(sWaitDlgStatus.Show)
                For Each student In Students
                    student.sessionID = NewSessionID
                    student.stdClassID = NewClass.classID
                    student.section = NewClass.section

                    stdController.promoteStudentAndScores(student, subjects)
                Next
                For Each subject In subjects
                    Dim newSubject As New Subject With {
                      .classID = NewClass.classID,
                      .section = subject.section,
                      .sessionID = NewSessionID,
                      .subjectID = subject.subjectID,
                      .subjectName = subject.subjectName,
                      .subjectTeacherName = subject.subjectTeacherName
                    }
                    subjectController_.addSubject(newSubject)
                Next
                statusController.message = String.Format("{0} students promoted and {1} subjects added each.", Students.Count, subjects.Count)
                WaitDlg(sWaitDlgStatus.Hide)
            Else
                promoteOnlyStudents(NewSessionID, NewClass, Students)
            End If
        Else
            promoteOnlyStudents(NewSessionID, NewClass, Students)
        End If
    End Sub
    Private Sub promoteOnlyStudents(NewSessionID As String, Newclass As StdClass, students As List(Of student_))
        For Each student In students
            student.sessionID = NewSessionID
            student.stdClassID = Newclass.classID
            student.section = Newclass.section

            stdController.promoteStudent(student)
        Next
        statusController.message = String.Format("{0} students promoted. No subject was added. You will need to add subjects later.", students.Count)
    End Sub
    Private Sub ClassEventSub(
         FormerSessionID As String,
                               FormerClassID As String,
                               NewSessionID As String)

        If ClassExist(NewSessionID, cmbClass2.Text) Then
            Dim NewClass As StdClass = classController.GetClassBySessionIDClassNAme(NewSessionID, cmbClass2.Text)
            Dim students As List(Of student_) = TryCast(GridControl2.DataSource, List(Of student_))
            SubjectEventSub(FormerSessionID, FormerClassID, NewSessionID, NewClass, students)

        Else
            ''create new class
            CreateNewClass(NewSessionID)
            ''continue as normal.
            Dim NewClass As StdClass = classController.GetClassBySessionIDClassNAme(NewSessionID, cmbClass2.Text)
            Dim students As List(Of student_) = TryCast(GridControl2.DataSource, List(Of student_))
            SubjectEventSub(FormerSessionID, FormerClassID, NewSessionID, NewClass, students)
        End If
    End Sub
    Private Sub SaveMovedStudents(FormerSessionID As String, FormerClassID As String)
        If validateComboBoxes(cmbYear2, cmbTerm2, cmbClass2) Then

            If SessionExist(cmbYear2.Text, cmbTerm2.Text) Then
                Dim NewSessionID As String = String.Format("{0}/{1}", cmbYear2.Text, cmbTerm2.Text.Replace(" ", ""))
                ClassEventSub(FormerSessionID, FormerClassID, NewSessionID)

            Else
                If XtraMessageBox.Show("Selected Session does no exist. Do you want to create it?", caption:=messageController.message, buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Question) = DialogResult.Yes Then
                    ''create new session
                    CreateNewSession()
                    ShowAlertForm(Me.FindForm, "New Session", "New session added")
                    ''continue as normal.
                    Dim NewSessionID As String = String.Format("{0}/{1}", cmbYear2.Text, cmbTerm2.Text.Replace(" ", ""))
                    ClassEventSub(FormerSessionID, FormerClassID, NewSessionID)

                Else
                    Exit Sub
                End If
            End If
            XtraMessageBox.Show(statusController.message, messageController.caption)
        End If
    End Sub
    Private Sub saveMovedBtn_Click(sender As Object, e As EventArgs) Handles saveMovedBtn.Click
        Dim FormerSessionID As String = String.Format("{0}/{1}", cmbYear1.Text, cmbTerm1.Text.Replace(" ", ""))

        Dim FormerClassID As String = classController.GetClassBySessionIDClassNAme(FormerSessionID, cmbClass1.Text).classID
        '' MsgBox(FormerSessionID + " " + FormerClassID)
        If GridView2.RowCount<1 Then
            XtraMessageBox.Show("No student has been moved for promotion.", messageController.caption)
            Exit Sub
        End If
            SaveMovedStudents(FormerSessionID, FormerClassID)
    End Sub

    Public Overrides Sub refreshData()
        MyBase.refreshData()
    End Sub
    Private Function FormerSessionID_val() As String
        Dim FormerSessionID_ = String.Format("{0}/{1}", cmbYear1.Text, cmbTerm1.Text.Replace(" ", ""))
        If setsController.getAllSessions.Exists(Function(x) x.sessionID = FormerSessionID_) Then
            Return FormerSessionID_
        Else
            Return Nothing
        End If

        Return FormerSessionID_
    End Function
    Private Function FormerClassID_val(formerSessionID_ As String) As String
        If classController.GetAllClasses.Exists(Function(x) x.sessionID = formerSessionID_ And x.stdClass = cmbClass1.Text) Then
            Return classController.GetClassBySessionIDClassNAme(FormerSessionID_val, cmbClass1.Text).classID
        Else
            Return Nothing
        End If
    End Function
    'Private Sub LoadStudentsOnValidation()
    '    ''  Try
    '    If FormerSessionID_val() IsNot Nothing Then
    '        ''MsgBox(FormerSessionID_val() + " 2 " + FormerClassID_val())
    '        If FormerClassID_val(FormerSessionID_val) IsNot Nothing Then
    '            '' MsgBox(FormerSessionID_val() + " 3 " + FormerClassID_val())
    '            loadStudents(FormerSessionID_val, FormerClassID_val(FormerClassID_val(FormerSessionID_val)))
    '        Else
    '            cmbClass1.Properties.Items.Clear()
    '            cmbClass1.Properties.Items.AddRange(
    '                classController.getAllClasses.Where(
    '                    Function(s) s.sessionID = FormerSessionID_val()).Select(
    '                    Function(x) x.stdClass).Distinct.ToList)

    '        End If
    '    Else
    '        '' XtraMessageBox.Show("Record of session does not exist")
    '        Exit Sub
    '    End If
    '    'Catch ex As Exception
    '    '    MessageBox.Show("No student found for this class")
    '    'End Try
    'End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.FindForm.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If cmbYear1.Text IsNot Nothing And cmbTerm1.Text IsNot Nothing And cmbClass1.Text IsNot Nothing Then
            loadStudents(cmbYear1.Text, cmbTerm1.Text, cmbClass1.Text)
        End If
    End Sub
End Class
