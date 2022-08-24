Imports DevExpress.XtraEditors

Public Class ListUsersView
    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UserTableTableAdapter.Fill(DbDataSet.userTable)
    End Sub

    Private Sub deleteUser(currentSession As SessionSettings)
        If CurrentUser IsNot Nothing Then
            If XtraMessageBox.Show("Do you want To delete the user " + CurrentUser.fullName + "?", setsController.getSchoolSettings.schName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                WaitDlg(sWaitDlgStatus.Show, "Deleting User Details")
                Try
                    userController_.deleteUser(currentSession.sessionID, CurrentUser)
                    UserTableTableAdapter.FillBySessionID(DbDataSet.userTable, currentSession.sessionID)
                Catch ex As Exception

                End Try
                WaitDlg(sWaitDlgStatus.Hide)
                ShowAlertForm(Me.FindForm, "Delete Users ", alertmessage:=CurrentUser.fullName + " details deleted.")
            End If
        Else
            XtraMessageBox.Show("No user to delete.")
        End If

    End Sub
    Private ReadOnly Property CurrentUser As User
        Get
            Return userController_.getUser(
                GridView2.GetRowCellDisplayText(GridView2.FocusedRowHandle, "guid")
                )
        End Get
    End Property

    Private Sub WindowsUIButtonPanel11_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel11.ButtonClick
        If e.Button.Properties.Caption = "Delete" Then
            deleteUser(GlobalCurrentSession)
        End If
        If e.Button.Properties.Caption = "Add" Then
            Dim setupDashboard As New setupDashboard()
            setupDashboard.PanelControl1.Controls.Add(New addUserView(GlobalCurrentSession))
        End If
        If e.Button.Properties.Caption = "Edit" Then
            Dim setupDashboard As New setupDashboard
            Dim editUserView As New addUserView(GlobalCurrentSession)
            editUserView.addEditScoreButtonPanel.Buttons(0).Properties.Caption = "Update"

            editUserView.editUser(CurrentUser)
            setupDashboard.PanelControl1.Controls.Add(editUserView)
            ''addEditScoreButtonPanel.Buttons(0).Properties.Caption = "Update"
        End If
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        UserLogTableTableAdapter.FillByUserName(DbDataSet.userLogTable, CurrentUser.userName)
    End Sub
End Class
