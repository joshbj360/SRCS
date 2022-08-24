Public Class setupDashboard
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PanelControl1.Controls.Add(New SessionSetupView With {.Dock = DockStyle.Fill})
        WindowsUIButtonPanel1.Buttons(1).Properties.Caption = "Continue to User Setup"

        subTitleLbl.Text = String.Format(
            "SRCS - {0} - {1} - {2}",
            setsController.getSchoolSettings.schName,
            GlobalCurrentSession.academicSession,
            GlobalCurrentSession.term
        )
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Caption = "Continue to User Setup" Then
            PanelControl1.Controls.Clear()
            PanelControl1.Controls.Add(New addUserView(GlobalCurrentSession) With {.Dock = DockStyle.Fill})

            WindowsUIButtonPanel1.Buttons(1).Properties.Caption = "Continue to Class Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Caption = "Back to Session Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = True
            Exit Sub
        End If
        If e.Button.Properties.Caption = "Back to Session Setup" Then
            PanelControl1.Controls.Clear()
            PanelControl1.Controls.Add(New SessionSetupView With {.Dock = DockStyle.Fill})

            WindowsUIButtonPanel1.Buttons(1).Properties.Caption = "Continue to User Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = False
            Exit Sub
        End If
        If e.Button.Properties.Caption = "Continue to Class Setup" Then
            PanelControl1.Controls.Clear()
            ''    MsgBox(GlobalCurrentSession.sessionID)
            PanelControl1.Controls.Add(New ClassSetupView(GlobalCurrentSession) With {.Dock = DockStyle.Fill})

            WindowsUIButtonPanel1.Buttons(1).Properties.Caption = "Continue to Subject Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Caption = "Back to User Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = True
            Exit Sub
        End If
        If e.Button.Properties.Caption = "Back to User Setup" Then
            PanelControl1.Controls.Clear()
            PanelControl1.Controls.Add(New addUserView(GlobalCurrentSession) With {.Dock = DockStyle.Fill})

            WindowsUIButtonPanel1.Buttons(1).Properties.Caption = "Continue to Class Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Caption = "Back to Session Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = True
            Exit Sub
        End If
        If e.Button.Properties.Caption = "Continue to Subject Setup" Then
            PanelControl1.Controls.Clear()
            ''    MsgBox(GlobalCurrentSession.sessionID)
            PanelControl1.Controls.Add(New addSubjectWizard(GlobalCurrentSession) With {.Dock = DockStyle.Fill})

            WindowsUIButtonPanel1.Buttons(0).Properties.Caption = "Back to Class Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Visible = True
            WindowsUIButtonPanel1.Buttons(1).Properties.Visible = False

            Exit Sub
        End If
        If e.Button.Properties.Caption = "Back to Class Setup" Then
            PanelControl1.Controls.Clear()
            PanelControl1.Controls.Add(New addUserView(GlobalCurrentSession) With {.Dock = DockStyle.Fill})

            WindowsUIButtonPanel1.Buttons(1).Properties.Caption = "Continue to Subject Setup"
            WindowsUIButtonPanel1.Buttons(0).Properties.Caption = "Back to User Setup"
            WindowsUIButtonPanel1.Buttons(1).Properties.Visible = True

            Exit Sub
        End If

    End Sub
End Class
