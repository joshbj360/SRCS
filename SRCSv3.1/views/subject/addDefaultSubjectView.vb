Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers

Public Class addDefaultSubjectView
    Private classesName As New List(Of String)
    ''Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitEditors(GlobalCurrentSession, ComboBoxEdit1.Text)
    End Sub
    Private Sub InitEditors(currentSession As SessionSettings, section As String)
        If ComboBoxEdit1.Text <> Nothing Then
            GridControl1.DataSource = dataSubjects(section)

            defaultSubjectsRepCmb.Items.Clear()
            defaultSubjectsRepCmb.Items.AddRange(subjectController_.getSubjects(currentSession.sessionID).Select(Function(x) x.subjectName).Distinct.ToList)

            classesName.Clear()
            classesName = classController.getAllClassesName(section)
        End If
    End Sub
    Private Function dataSubjects(section As String) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("counter", GetType(Integer))
        dt.Columns.Add("subjectName", GetType(String))
        dt.Columns.Add("section", GetType(String))
        dt.Columns.Add("stdClass", GetType(String))
        dt.Columns.Add("subjectID", GetType(String))

        Dim i As Integer = 0
        For Each subject In subjectController_.getDefaultSubjects(section).GroupBy(Function(x) x.subjectName).Select(Function(x) x.First).ToList
            dt.Rows.Add(i + 1, subject.subjectName, section, subject.stdClass, subject.subjectID)
            i += 1
        Next
        Return dt
    End Function
    Sub InitSkinGalary()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub

    Private Function rgbiSkins() As RibbonGalleryBarItem
        Throw New NotImplementedException()
    End Function

    Public Overrides Sub refreshData()
        MyBase.refreshData()
        InitEditors(GlobalCurrentSession, ComboBoxEdit1.Text)
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        saveDefaultSubject(ComboBoxEdit1.Text, GridView1)
        refreshData()
    End Sub

    Private Sub saveDefaultSubject(section As String, gv As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim sb As New StringBuilder
        If classesName.Count < 1 Then
            If MessageBox.Show("No Class exist in this section." + vbCrLf +
                               "Do you want to add class?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim indexForm As New indexForm(Me, New addClassView(GlobalCurrentSession))
                indexForm.Show(Me.FindForm)
            End If
        End If

        For Each className In classController.getAllClassesName(section).Distinct
            '  MsgBox(className)
            Dim rowHandle As Integer = 0
            While gv.IsValidRowHandle(rowHandle)
                '  MsgBox(rowHandle)
                Dim dSub As New DefaultSubject
                dSub.subjectName = Convert.ToString(gv.GetRowCellValue(rowHandle, "subjectName"))
                dSub.section = section
                dSub.stdClass = className
                dSub.subjectID = Convert.ToString(gv.GetRowCellValue(rowHandle, "subjectID"))

                If Not subjectController_.ifDefaultSubjectExist(dSub) Then
                    subjectController_.addDefaultSubject(dSub)
                Else
                    subjectController_.updateDefaultSubject(dSub)
                End If
                rowHandle = rowHandle + 1
                'sb.Append(Chr(9) & String.Format("{0}", std.subjectName) & " added. " + vbCrLf)
            End While
        Next
        'sb.Append(String.Format("{0} Subjects added for {1} class(es)", rowHandle, counter))
        If statusController.status Then
            MessageBox.Show(statusController.message + vbCrLf + sb.ToString)
        Else
            MessageBox.Show(statusController.message)
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.FindForm.Close()
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        If ComboBoxEdit1.Text <> Nothing Then
            GridControl1.DataSource = dataSubjects(ComboBoxEdit1.Text)
        End If
    End Sub
    Dim subjectsDictionary As New Dictionary(Of Integer, String)
    'Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
    '    Dim rowHandle As Integer = e.ListSourceRowIndex

    '    If e.IsGetData Then
    '        If e.Column.FieldName = "subjectName" Then
    '            If Not subjectsDictionary.ContainsKey(rowHandle) Then
    '                subjectsDictionary.Add(rowHandle, "New Subject Name")
    '            End If
    '            e.Value = subjectsDictionary(rowHandle)
    '            GridView1.SetRowCellValue(rowHandle + 1, "subjectName", "New Sub")

    '        End If
    '        If e.Column.FieldName = "counter" Then
    '            e.Value = GridView1.GetRowHandle(rowHandle) + 1

    '        End If

    '    End If
    '    If e.IsSetData Then
    '        subjectsDictionary(rowHandle) = Convert.ToString(e.Value)
    '    End If
    'End Sub
End Class
