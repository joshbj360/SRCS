Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class addUserView
    '' Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors()
    End Sub


    Private Sub initEditors()
        Try
            addEditScoreButtonPanel.Buttons(0).Properties.Caption = "Save"
            ' cmbClass.Properties.Items.AddRange(classController.getListOfAllClassNames(cmbSchYear.Text, cmbTerm.Text))
            txtfullname.Properties.Items.AddRange(userController_.getAllUsers.Select(Function(x) x.fullName).Distinct.ToList)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub clearEditors()
        txtfullname.Text = Nothing
        txtusername.Text = Nothing
        txtPassword.Text = Nothing
        txtPassword1.Text = Nothing
        rgDesgination.SelectedIndex = 1
    End Sub
    Private Function calcStaffID() As String
        Return "STF" + "/" + Today.Year.ToString + "/" + userController_.getAllUsers.Count.ToString
    End Function
    Private Function User_(currentSession As SessionSettings) As User
        Dim _user As New User
        _user.guid = userController_.ValidateOrGenerateGuid(txtusername.Text, txtfullname.Text)
        _user.fullName = txtfullname.Text
        _user.password = txtPassword.Text
        _user.sessionID = currentSession.sessionID
        _user.section = ""
        _user.staffID = calcStaffID()
        ' _user.term = cmbTerm.Text
        _user.userName = txtusername.Text
        _user.userType = rgDesgination.EditValue.ToString
        Return _user
    End Function

    Private Sub SaveUser(currentSession As SessionSettings)
        'If cmbSchYear.Text = Nothing Then
        '    MessageBox.Show("Select Academic Session")
        '    cmbSchYear.Focus()
        '    Exit Sub
        'End If
        'If cmbTerm.Text = Nothing Then
        '    MessageBox.Show("Select Term")
        '    cmbTerm.Focus()
        '    Exit Sub
        'End If

        If txtPassword.Text <> txtPassword1.Text Then
            XtraMessageBox.Show("Password Do no match", setsController.getSchoolSettings.schName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If
        If txtusername.Text = Nothing Then
            XtraMessageBox.Show("Username Is empty", setsController.getSchoolSettings.schName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
            Exit Sub
        End If
        If txtfullname.Text = Nothing Then
            XtraMessageBox.Show("Enter full name", setsController.getSchoolSettings.schName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtfullname.Focus()
            Exit Sub
        End If
        'Try
        WaitDlg(sWaitDlgStatus.Show, "Saving User...")
        userController_.addUser(User_(currentSession))
        clearEditors()
        WaitDlg(sWaitDlgStatus.Hide)
        ShowAlertForm(Me.FindForm, "New User", alertmessage:=User_(currentSession).fullName + " details saved.")
        '        ShouldRefresh = True
        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub editUser(user As User)
        If user IsNot Nothing Then
            txtfullname.Text = user.fullName
            txtusername.Text = user.userName
            txtPassword.Text = user.password
            rgDesgination.EditValue = user.userType

            Dim newUser As New User With {
            .fullName = txtfullname.Text,
            .userName = txtusername.Text,
            .guid = user.guid,
            .staffID = user.staffID,
            .password = txtPassword.Text,
            .userType = rgDesgination.EditValue.ToString,
            .sessionID = GlobalCurrentSession.sessionID
            }
            userController_.editUser(newUser)
        End If
    End Sub

    Private Sub addEditScoreButtonPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles addEditScoreButtonPanel.ButtonClick
        If e.Button.Properties.Caption = "Save" Then
            SaveUser(GlobalCurrentSession)
        End If
        If e.Button.Properties.Caption = "Update" Then

        End If
        If e.Button.Properties.Caption = "Save & New" Then
            'NavigationFrame1.SelectedPage = NavigationPage1
            SaveUser(GlobalCurrentSession)
            clearEditors()
        End If
        If e.Button.Properties.Caption = "All Users" Then
            Dim setupDashboard As New indexForm(Me, New ListUsersView(GlobalCurrentSession)) With {.WindowState = FormWindowState.Maximized}
            setupDashboard.ShowDialog(Me.FindForm)
        End If
    End Sub

End Class
