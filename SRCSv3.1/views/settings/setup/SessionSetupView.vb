Imports DevExpress.XtraEditors

Public Class SessionSetupView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitEditors()
    End Sub
    Private Sub InitEditors()
        Try
            txtOldAcadyr.Text = DefaultCurrentSession.academicSession
            txtOldTerm.Text = DefaultCurrentSession.term
            no_days_txt.Text = DefaultCurrentSession.noOfDaysSchOpen.ToString
            next_term_begins.EditValue = DefaultCurrentSession.nextTermBegins


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function validateEditors() As Boolean
        Dim NoErrors As Boolean = True
        If sch_year_tb.Text = Nothing Then
            XtraMessageBox.Show("Enter a new academic Session.", caption:=messageController.caption)
            sch_year_tb.Focus()
            NoErrors = False
        End If
        If sch_term_tb.Text = Nothing Then
            NoErrors = False
        End If

        Return NoErrors
    End Function
    Private Sub addSession(year As String, term As String, nextTermBegins As Date, noOfDaysSchOpen As Integer)
        Try
            If year <> Nothing And term <> Nothing Then
                Dim NewSessionID As String = String.Format("{0}/{1}", year, term.Replace(" ", ""))

                setsController.addDefaultYearTerm(year, term, nextTermBegins, noOfDaysSchOpen)
                setsController.updateSchoolSettingsSessionIDByID(NewSessionID)


                Dim session As New SessionSettings
                session.sessionID = NewSessionID
                session.academicSession = year
                session.term = term
                session.nextTermBegins = CDate(next_term_begins.DateTime.ToShortDateString)
                'session.nextTermEnds = CDate(next_term_ends.dateTime.ToLongDateString)
                session.noOfDaysSchOpen = CInt(no_days_txt.EditValue)
                setsController.addSession(session)

                GlobalCurrentSession = session
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        WaitDlg(sWaitDlgStatus.Show)
        If validateEditors() Then
            addSession(
            sch_year_tb.Text,
            sch_term_tb.Text,
            CDate(next_term_begins.EditValue),
            CInt(no_days_txt.EditValue)
            )
            refreshEditors()
            statusController.message = "Default Session Set."
        Else
            statusController.message = "Unable to set default Session." + vbCrLf + "Check the inputs and try again."
        End If

        WaitDlg(sWaitDlgStatus.Hide)
        ShowAlertForm(Me.FindForm, "Session Settings", alertmessage:=statusController.message)

    End Sub
    Private Sub refreshEditors()
        Try
            'we can use GlobalCurrentSession variable because changes has been saved.
            txtOldAcadyr.Text = GlobalCurrentSession.academicSession
            txtOldTerm.Text = GlobalCurrentSession.term
            TryCast(Me.FindForm, setupDashboard).subTitleLbl.Text = String.Format(
                "SRCS - {0} - {1} - {2}",
                setsController.getSchoolSettings.schName,
                GlobalCurrentSession.academicSession,
                GlobalCurrentSession.term
            )

            statusController.message = String.Format(
                "Academic year changed from {0} to {1} " + vbCrLf + "Term changed from {2} to {3}",
                txtOldAcadyr.Text,
                sch_year_tb.Text + vbCrLf,
                txtOldTerm.Text,
                sch_term_tb.Text
            )
            sch_term_tb.Text = Nothing
            sch_year_tb.Text = Nothing
            no_days_txt.Text = Nothing
            statusController.status = True
        Catch ex As Exception

        End Try

    End Sub
End Class
