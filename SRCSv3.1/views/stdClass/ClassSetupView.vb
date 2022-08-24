Imports DevExpress.XtraEditors

Public Class ClassSetupView

    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadClassesToGrid(currentSession)
    End Sub
    Private Sub loadClassesToGrid(CurrentSession As SessionSettings)
        ''  MsgBox(CurrentSession.sessionID + "     " + GlobalCurrentSession.sessionID)
        StdClassTableTableAdapter.Fill(DbDataSet.stdClassTable)
        StdClassTableTableAdapter.FillBySessionID(DbDataSet.stdClassTable, CurrentSession.sessionID)
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Caption = "New Class" Then
            Dim indexForm As New indexForm(Me, New addClassView(GlobalCurrentSession) With {.Dock = DockStyle.Fill})
            indexForm.Text = "Add new class"
            indexForm.ShowDialog(Me.FindForm)
        End If

        If e.Button.Properties.Caption = "Edit Class" Then
            If CurrentClass() IsNot Nothing Then
                Dim indexForm As New indexForm(Me, New addClassView(CurrentClass) With {.Dock = DockStyle.Fill})
                indexForm.Text = "Edit " + CurrentClass.stdClass + " details"
                indexForm.ShowDialog(Me.FindForm)
            End If
            XtraMessageBox.Show("Invalid class selection", messageController.caption, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
        End If

        If e.Button.Properties.Caption = "Promote Class" Then
            If GlobalCurrentSession IsNot Nothing And CurrentClass() IsNot Nothing Then
                Dim indexForm As New indexForm(Me, New promoteStudentView(GlobalCurrentSession, CurrentClass) With {.Dock = DockStyle.Fill})
                indexForm.WindowState = FormWindowState.Maximized
                indexForm.Text = "Promote Class"
                indexForm.ShowDialog(Me.FindForm)
            End If
            If XtraMessageBox.Show(text:="No class selected. Do you want to continue?", caption:=messageController.caption, buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim indexForm As New indexForm(Me, New promoteStudentView With {.Dock = DockStyle.Fill})
                indexForm.WindowState = FormWindowState.Maximized
                indexForm.Text = "Promote Class"
                indexForm.ShowDialog(Me.FindForm)
            End If
        End If

        If e.Button.Properties.Caption = "Delete Class" Then
            If CurrentClass() IsNot Nothing Then
                If MessageBox.Show(
                               "Sure To delete " + CurrentClass.stdClass + " ?",
                               "SRCS - Current Session: " + GlobalCurrentSession.sessionID,';''''''''''//;'][;
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    classController.deleteClass(CurrentClass)
                    refreshData()
                End If
            End If
            XtraMessageBox.Show("No class to delete", messageController.caption, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
        End If
    End Sub
    Public Overrides Sub refreshData()
        MyBase.refreshData()
        Try
            loadClassesToGrid(GlobalCurrentSession)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "SRCS - Current Session: " + GlobalCurrentSession.sessionID)
        End Try

    End Sub

    Private Function CurrentClass() As StdClass
        If GridView1.RowCount < 1 Then
            Return Nothing
        Else
            Dim newStdClass = New StdClass()
            newStdClass.classID = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, colclassID)
            newStdClass.formTeacherName = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, colformTeacherName)
            newStdClass.section = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, colsection)
            newStdClass.sessionID = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, colsessionID)
            newStdClass.stdClass = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, colstdClass)
            Return newStdClass
        End If
    End Function

End Class
