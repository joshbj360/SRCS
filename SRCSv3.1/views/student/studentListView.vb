Imports DevExpress.XtraGrid.Views.Grid

Public Class studentListView
    ''Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)

    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors(currentSession)
    End Sub

    Private Sub initEditors(currentSession As SessionSettings)
        cmbSchYear.Text = currentSession.academicSession ' nav.academicSession
        cmbTerm.Text = currentSession.term
        cmbClass.Properties.Items.AddRange(classController.GetListOfAllClassNames(currentSession.sessionID))
    End Sub

    Private Sub cmbSchYer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClass.SelectedIndexChanged
        '        nav.studentClass = cmbClass.Text

        FillStudentsBySessionId(GlobalCurrentSession)
    End Sub
    Private Sub FillStudentsBySessionId(CurrentSession As SessionSettings)
        StudentTableTableAdapter.FillBySessionIDClassID(
       DbDataSet.studentTable,
       CurrentSession.sessionID,
       classController.GetClassBySessionIDClassNAme(CurrentSession.sessionID, cmbClass.Text).classID
       )
    End Sub
    Private Sub addEditScoreButtonPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles addEditScoreButtonPanel.ButtonClick
        If cmbSchYear.Text <> Nothing AndAlso cmbTerm.Text <> Nothing And cmbClass.Text <> Nothing Then
            If e.Button.Properties.Caption = "Add" Then

                '' Dim addFrm As addStudentForm = New addStudentForm(GlobalCurrentSession)
                Dim addStdFrm As New addStudentForm(GlobalCurrentSession)
                addStdFrm.sbOK.Tag = "add"
                Dim indexform As New indexForm(Me, addStdFrm)
                indexform.Show(Me.FindForm)
            End If

            If e.Button.Properties.Caption = "Edit" Then
                Dim addStdFrm As New addStudentForm(currentStudent)
                addStdFrm.sbOK.Tag = "update"
                Dim indexform As New indexForm(Me, addStdFrm)
                indexform.Show(Me.FindForm)
            End If
        Else
            MessageBox.Show("Academic Session, Term and Class must be selected.")
            Exit Sub
        End If
    End Sub
    Private Sub addEditScoreButtonPanel_ButtonChecked(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles addEditScoreButtonPanel.ButtonChecked
        If e.Button.Properties.Caption = "Select" Then
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect
            GridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True
            GridView1.SelectRow(GridView1.FocusedRowHandle)
        End If
    End Sub

    Private Sub addEditScoreButtonPanel_ButtonUnchecked(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles addEditScoreButtonPanel.ButtonUnchecked
        If e.Button.Properties.Caption = "Select" Then
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
            GridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False
        End If
    End Sub
    Private Sub PupilsView1_RowCellClick(ByVal sender As Object, ByVal e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Button = MouseButtons.Left AndAlso e.RowHandle >= 0 AndAlso e.Clicks = 2 Then
            Dim addStdFrm As New addStudentForm(currentStudent)
            addStdFrm.sbOK.Tag = "edit"
            Dim indexform As New indexForm(Me, addStdFrm)
            indexform.Show(Me.FindForm)
        End If
    End Sub

    Private Sub PupilsView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyData = Keys.Enter AndAlso GridView1.FocusedRowHandle >= 0 Then
            Dim addStdFrm As New addStudentForm(currentStudent)
            addStdFrm.sbOK.Tag = "edit"
            Dim indexform As New indexForm(Me, addStdFrm)
            indexform.Show(Me.FindForm)
        End If
    End Sub
    Private Function currentStudent() As student_
        Return (New student_(GridView1.GetDataRow(GridView1.FocusedRowHandle)))
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub cmbSchYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchYear.SelectedIndexChanged
        ' nav.academicSession = cmbSchYear.Text
    End Sub

    Private Sub cmbTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTerm.SelectedIndexChanged
        ' nav.term = cmbTerm.Text
    End Sub

End Class
