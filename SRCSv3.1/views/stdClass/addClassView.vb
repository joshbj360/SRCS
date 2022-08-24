Public Class addClassView
    ''Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Private toEditClassID As String
    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors(currentSession)
    End Sub
    Public Sub New(stdclass As StdClass)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtClass.Text = stdclass.stdClass
        cmbFormTeacher.Text = stdclass.formTeacherName
        cmbSection.Text = stdclass.section
        cmbSchYear.Text = setsController.getSessionSettingsBySessionID(stdclass.sessionID).academicSession
        cmbTerm.Text = setsController.getSessionSettingsBySessionID(stdclass.sessionID).term
        txtClass.Properties.Items.AddRange(classController.GetAllClasses.Select(Function(x) x.stdClass).Distinct.ToList)

        cmbFormTeacher.Properties.Items.AddRange(userController_.getAllUsersNamesBySessionID(stdclass.sessionID))
        saveBtn.Tag = "Update"
        toEditClassID = stdclass.classID
    End Sub
    Private Sub initEditors(currentSession As SessionSettings)
        cmbSchYear.Text = currentSession.academicSession
        cmbTerm.Text = currentSession.term
        cmbFormTeacher.Properties.Items.AddRange(userController_.getAllUsers.Select(Function(x) x.fullName).Distinct.ToList)
        txtClass.Text = Nothing
        txtClass.Properties.Items.AddRange(classController.GetAllClasses.Select(Function(x) x.stdClass).Distinct.ToList)
        cmbFormTeacher.Text = ""
        cmbSection.Text = ""
        saveBtn.Tag = "Add"
    End Sub
    Public Overrides Sub refreshData()
        MyBase.refreshData()
        cmbFormTeacher.Properties.Items.AddRange(userController_.getAllUsersNamesBySessionID(GlobalCurrentSession.sessionID))
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Function _class(currentSession As SessionSettings) As StdClass
        Dim class_ As New StdClass
        class_.classID = classController.generateClassID(currentSession.sessionID, txtClass.Text)
        class_.formTeacherName = cmbFormTeacher.Text
        class_.sessionID = currentSession.sessionID
        class_.stdClass = txtClass.Text
        class_.section = cmbSection.Text
        class_.stdClass = txtClass.Text.ToUpper.Trim
        Return class_
    End Function
    Private Sub saveClass(currentSession As SessionSettings)
        If cmbSchYear.Text = Nothing Then
            MessageBox.Show("Select Academic Session")
            cmbSchYear.Focus()
            Exit Sub
        End If
        If cmbTerm.Text = Nothing Then
            MessageBox.Show("Select Term")
            cmbTerm.Focus()
            Exit Sub
        End If
        If txtClass.Text = Nothing Then
            MessageBox.Show("Enter Class Name")
            txtClass.Focus()
            Exit Sub
        End If
        If cmbSection.Text = Nothing Then
            MessageBox.Show("Select School Section")
            cmbSection.Focus()
            Exit Sub
        End If
        If cmbFormTeacher.Text = Nothing Then
            If MessageBox.Show("No Form Teacher selected. Do you want to continue?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                _class(currentSession).formTeacherName = "NotImplemented"
            Else
                Exit Sub
            End If
        End If
        classController.AddClass(_class(currentSession))
        If statusController.status And (Not statusController.status) Then
            MessageBox.Show(statusController.message)
            refreshData()
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If saveBtn.Tag Is "Add" Then
            saveClass(GlobalCurrentSession)
        End If
        If saveBtn.Tag Is "Update" Then
            _class(GlobalCurrentSession).classID = toEditClassID
            classController.editClass(_class(GlobalCurrentSession))
        End If

    End Sub

    'Private Sub cmbSchYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchYear.SelectedIndexChanged
    '    If cmbSchYear.Text <> Nothing And cmbTerm.Text <> Nothing Then
    '        currentSession = setsController.CurrentSession(cmbSchYear.Text, cmbTerm.Text)
    '    End If
    'End Sub

    'Private Sub cmbTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTerm.SelectedIndexChanged
    '    If cmbSchYear.Text <> Nothing And cmbTerm.Text <> Nothing Then
    '        currentSession = setsController.CurrentSession(cmbSchYear.Text, cmbTerm.Text)
    '    End If
    'End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        saveClass(GlobalCurrentSession)
        initEditors(GlobalCurrentSession)
        saveBtn.Tag = "Add"
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim anu As New addUserView(GlobalCurrentSession)
        anu.addEditScoreButtonPanel.Buttons(3).Properties.Enabled = False
        anu.NavigationFrame1.SelectedPage = anu.NavigationPage1

        Dim form As New indexForm(Me, anu)
        form.StartPosition = FormStartPosition.CenterScreen
        form.WindowState = FormWindowState.Maximized
        form.Show(Me.FindForm)
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.FindForm.Close()
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
