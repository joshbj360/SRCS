Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text
Public Class addScoresView
    Private reportSettings As ReportSettings = setsController.getReportSettings
    Private InitialTerm As String
    Private InitialYear As String

    '' Private subjectName As String
    Public Sub New(currentSession As SessionSettings)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'ScoreTableTableAdapter.Fill(DbDataSet.scoreTable)
        initEditors(currentSession)

    End Sub
    Private ScoreSession_ As SessionSettings
    Private Property ScoreSession As SessionSettings
        Get
            Return ScoreSession_
        End Get
        Set(value As SessionSettings)
            ScoreSession_ = value
        End Set
    End Property

    Private OnfirstStart As Boolean = True
    Private Sub initEditors(currentSession As SessionSettings)
        ScoreSession = currentSession
        cmbSchYear.Text = currentSession.academicSession
        cmbTerm.Text = currentSession.term
        If currentSession.term = "Third Term" Then
            chkEditLayoutItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            CheckEdit1.Checked = True
        End If
        loadUserClasstoClassTextBox(currentSession, ActiveUser)

        FARepositoryItemSpinEdit1.MaxValue = reportSettings.assScore
        SARepositoryItemSpinEdit2.MaxValue = reportSettings.assScore
        FTRepositoryItemSpinEdit3.MaxValue = reportSettings.testScore
        STRepositoryItemSpinEdit4.MaxValue = reportSettings.testScore
        ERepositoryItemSpinEdit5.MaxValue = reportSettings.examScore
        OnfirstStart = False
        InitialYear = cmbSchYear.Text
        InitialTerm = cmbTerm.Text
    End Sub

    ''' <summary>
    ''' Check for the userType and load the respective classes, that the user teaches.
    ''' All classes is loaded for the admin userType.
    ''' </summary>
    ''' <param name="sessionID"></param>
    ''' <param name="user"></param>
    Private Sub loadUserClasstoClassTextBox(currentSession As SessionSettings, user As User)
        WaitDlg(sWaitDlgStatus.Show, "Loading Classes...", "Please Wait")
        Try
            Dim classes_ As New List(Of String)
            Dim subjects_ As New List(Of Subject)

            Select Case user.userType
                Case sUserType.subjectTeacher
                    cmbStdClass.Properties.Items.Clear()

                    subjects_ = (subjectController_.getSubjects(currentSession.sessionID).Where(Function(x) x.subjectTeacherName = user.fullName)).Distinct.ToList

                    For Each subject In subjects_
                        cmbStdClass.Properties.Items.Add(classController.GetClassByClassID(subject.classID).stdClass)
                    Next

                Case sUserType.Admin
                    classes_ = classController.GetListOfAllClassNames(currentSession.sessionID)
                    cmbStdClass.Properties.Items.Clear()

                    cmbStdClass.Properties.Items.AddRange(classes_)
                    cmbStdClass.SelectedIndex = 0
                    Dim subjects As New List(Of Subject)
                    subjects = subjectController_.getSubjectsBySessionIDClassID(currentSession.sessionID, CurrentClass(currentSession.sessionID, cmbStdClass.Text).classID)
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            XtraMessageBox.Show("Classes failed to load. " + vbCrLf + ex.Message)
            WaitDlg(sWaitDlgStatus.Hide)
        End Try
        WaitDlg(sWaitDlgStatus.Hide)
    End Sub

#Region "Functions"
    Private ReadOnly Property GetOldTermTotalScore(OldSessionID As String, stdID As String) As Integer
        Get
            If CurrentClass(OldSessionID, cmbStdClass.Text) IsNot Nothing Then

                If CurrentSubject(OldSessionID, CurrentClass(OldSessionID, cmbStdClass.Text).classID, subjectName) IsNot Nothing Then
                    Return scoreController_.getStudentSubjectTotalScore(
                        stdID,
                        CurrentSubject(
                            OldSessionID,
                            CurrentClass(OldSessionID, cmbStdClass.Text).classID,
                            subjectName
                        ).subjectID,
                        CurrentClass(OldSessionID, cmbStdClass.Text).classID,
                        OldSessionID)
                Else
                    Return 0
                    statusController.message = "No Subject exist for the specified class."
                    Exit Property
                End If
            Else
                Return 0
                statusController.message = "No record exist for " + cmbStdClass.Text + " for " + OldSessionID
                Exit Property
            End If
        End Get
    End Property


    'Loop throught the rows and save it to the database
    Private Sub SaveThirdTermScore(Session As SessionSettings, thirdTermScore As Score)
        If Session.sessionID.Contains("ThirdTerm") And Session.term = "Third Term" Then

            Dim FirstTermSessionID = Session.academicSession + "/FirstTerm"
            Dim secondTermSessionID = Session.academicSession + "/SecondTerm"

            thirdTermScoreController_.addThirdTermScore(
                    GetOldTermTotalScore(FirstTermSessionID, thirdTermScore.stdID),
                    GetOldTermTotalScore(secondTermSessionID, thirdTermScore.stdID),
                    thirdTermScore
                )

        Else
            statusController.message = "Unable to save score for third term. This is not Third term"
        End If

    End Sub
    Private Sub saveScore(sessionID As String, classID As String, subjectID As String, gv As GridView)
        WaitDlg(sWaitDlgStatus.Show, "Saving scores...", "Please wait")
        Dim ifSuccessCount As Integer = 0
        ' Dim i As Integer = 0
        gv.OptionsSelection.MultiSelect = True
        gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        gv.SelectAll()

        For Each rowHandle As Integer In gv.GetSelectedRows
            '    MsgBox(i)
            'If gv.IsValidRowHandle(i) Then
            scoreController_.addScore(Score(sessionID, classID, subjectID, rowHandle, gv), True)
            If CheckEdit1.Checked Then
                SaveThirdTermScore(ScoreSession, Score(sessionID, classID, subjectID, rowHandle, gv))

                statusController.message = vbCrLf + "Saved Student Third Term Scores"
            End If

            ifSuccessCount += 1
            '  End If
        Next
        'While gv.IsValidRowHandle(i)

        'End While
        If CheckEdit1.Checked Then
            thirdTermScoreController_.ThirdTermRankSubjectPosition(sessionID, classID, subjectID)
            thirdTermScoreController_.ThirdTermRankClassPosition(sessionID, classID)
        End If
        scoreController_.rankSubjectPositon(sessionID, classID, subjectID)
        scoreController_.rankClassPosition(sessionID, classID)

        statusController.message += "Saved Student Scores."

        WaitDlg(sWaitDlgStatus.Hide)
        MessageBox.Show(String.Format("{0} Student score(s) saved.", ifSuccessCount))
    End Sub
    Private Function Score(sessionID As String, classID As String, subjectID As String, rowHandle As Integer, gv As GridView) As Score
        Return New Score With {
                .stdID = gv.GetRowCellDisplayText(rowHandle, colstd_id),
                .studentFullName = gv.GetRowCellDisplayText(rowHandle, colstd_fullName),
                .subjectID = subjectID,
                .classID = classID,
                .sessionID = sessionID,
                .exam = CInt(gv.GetRowCellDisplayText(rowHandle, "exam")),
                .firstAss = CInt(gv.GetRowCellDisplayText(rowHandle, "firstAss")),
                .firstCA = CInt(gv.GetRowCellDisplayText(rowHandle, "firstCA")),
                .gradeRemarks = gv.GetRowCellDisplayText(rowHandle, "colgrade"),
                .secondAss = CInt(gv.GetRowCellDisplayText(rowHandle, "secondAss")),
                .secondCA = CInt(gv.GetRowCellDisplayText(rowHandle, "secondCA")),
                .totalScore = CInt(gv.GetRowCellDisplayText(rowHandle, "coltot"))
                }

    End Function
#End Region
#Region "PanelButtons"
    Private Sub addEditScoreButtonPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles addEditScoreButtonPanel.ButtonClick
        Dim ClassID = CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).classID
        If e.Button.Properties.Caption = "Save" Then

            saveScore(
                    ScoreSession.sessionID,
                    ClassID,
                    CurrentSubject(ScoreSession.sessionID, ClassID, subjectName).subjectID,
                    GridView1
                )
            ShowAlertForm(Me.FindForm, "Saving Scores...", statusController.message)
        End If
        If e.Button.Properties.Caption = "Add" Then
            Dim addStdFrm As New addStudentForm(ScoreSession)
            addStdFrm.sbOK.Tag = "add"
            Dim indexform As New indexForm(Me, addStdFrm)
            indexform.Show(Me.FindForm)
        End If
        If e.Button.Properties.Caption = "Delete" Then
            deleteScore(
                ScoreSession.sessionID,
                CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).classID,
                CurrentSubject(ScoreSession.sessionID, ClassID, subjectName).subjectID
                )

        End If

    End Sub

    Private Sub deleteScore(sessionID As String, classID As String, subjectID As String)
        Dim sb As New StringBuilder
        If MessageBox.Show("Delete selected row(s)?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each rowHandle As Integer In GridView1.GetSelectedRows
                scoreController_.deleteScoreFromSubject(
                       sessionID,
                       classID,
                       subjectID,
                       GridView1.GetRowCellDisplayText(rowHandle, colstd_id)
                )
            Next
            GridView1.DeleteSelectedRows()
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

    Private Sub addEditScoreButtonPanel_ButtonUnchecked(sender As Object, e As ButtonEventArgs) Handles addEditScoreButtonPanel.ButtonUnchecked
        If e.Button.Properties.Caption = "Select" Then
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
            GridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False
        End If
    End Sub

#End Region


    Private Sub cmbSchYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchYear.SelectedIndexChanged

        If cmbSchYear.Text <> Nothing And cmbTerm.Text <> Nothing And (Not OnfirstStart) Then
            If XtraMessageBox.Show(
                "Are you sure you want to change the academic year?",
                messageController.caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) = DialogResult.Yes Then
                InitialYear = cmbSchYear.Text
                InitialTerm = cmbTerm.Text
                ScoreSession = setsController.CurrentSession(cmbSchYear.Text, cmbTerm.Text)
            Else
                cmbSchYear.Text = InitialYear
                cmbTerm.Text = InitialTerm
            End If

        End If
    End Sub

    Private Sub cmbTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTerm.SelectedIndexChanged
        If cmbSchYear.Text IsNot Nothing And cmbTerm.Text IsNot Nothing And (Not OnfirstStart) Then
            If XtraMessageBox.Show(
                "Are you sure you want to change the Term?",
                messageController.caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) = DialogResult.Yes Then
                InitialYear = cmbSchYear.Text
                InitialTerm = cmbTerm.Text
                ScoreSession = setsController.CurrentSession(cmbSchYear.Text, cmbTerm.Text)
            Else
                cmbSchYear.Text = InitialYear
                cmbTerm.Text = InitialTerm
            End If
        End If
    End Sub
    Private ReadOnly Property CurrentClass(SessionID As String, className As String) As StdClass
        Get

            If cmbStdClass.Text <> String.Empty Then
                Return classController.GetClassBySessionIDClassNAme(SessionID, className)
                'MsgBox("Class field cannot be empty")
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private Function CurrentSubject(sessionID As String, classID As String, subjectName As String) As Subject
        If sessionID <> Nothing And classID <> Nothing And subjectName <> Nothing Then
            Return subjectController_.getSubjectBySessionIDClassIDSubjectName(sessionID, classID, subjectName)
        Else
            Return Nothing
        End If
    End Function

    Private subjectName_ As String
    Private Property subjectName As String
        Get
            Return subjectName_
        End Get
        Set(value As String)
            subjectName_ = value
        End Set
    End Property

    Private Sub cmbStdClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStdClass.SelectedIndexChanged
        WaitDlg(sWaitDlgStatus.Show, "Loading Subjects...", "Please Wait")

        If cmbStdClass.Text <> Nothing And cmbSchYear.Text <> Nothing And cmbTerm.Text <> Nothing Then
            loadSubjectsToTileBarUserType(
            ScoreSession.sessionID,
            CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).stdClass
            )
        End If
        WaitDlg(sWaitDlgStatus.Hide)
    End Sub
    Private Sub loadSubjectsToTileBarUserType(sessionID As String, className As String)
        Try
            '    MsgBox(currentClass.classID)
            Select Case ActiveUser.userType
                Case sUserType.subjectTeacher
                    loadSubjectsToTileBar(
                        sessionID,
                        className,
                        subjectController_.getSubjectsBySessionIDClassIDUserID(
                           sessionID,
                           CurrentClass(sessionID, className).classID,
                           ActiveUser.fullName
                        ).Select(Function(x) x.subjectName).Distinct.ToList)

                    'If cmbStdClass.Text <> Nothing And CurrentClass(sessionID, className) IsNot Nothing Then
                    '    loadScoresToGrid(sessionID, CurrentClass(sessionID, className).classID, FirstSubjectName)
                    'End If<
                Case sUserType.Admin
                    loadSubjectsToTileBar(sessionID, className, subjectController_.getSubjectsBySessionIDClassID(
                    sessionID,
                    CurrentClass(sessionID, cmbStdClass.Text).classID
                    ).Select(Function(x) x.subjectName).Distinct.ToList)

            End Select

        Catch ex As Exception
            WaitDlg(sWaitDlgStatus.Hide)
        End Try


    End Sub
    Private Sub loadScoresToGrid(sessionID As String, classID As String, subjectName As String)
        WaitDlg(sWaitDlgStatus.Show, "Loading Scores...", "Please Wait")
        ScoreTableTableAdapter.FillBySessionIDClassIDSubjectID(
            DbDataSet.scoreTable,
            sessionID,
            classID,
            subjectController_.getSubjectBySessionIDClassIDSubjectName(
                    sessionID,
                    classID,
                    subjectName
                ).subjectID
            )
        txtSubjectPreview.Text = subjectName
        WaitDlg(sWaitDlgStatus.Hide)
    End Sub
    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileControl1.ItemClick
        subjectName = e.Item.Name
        loadScoresToGrid(
                ScoreSession.sessionID,
                CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).classID,
                subjectName
            )
        '
    End Sub
    Public Sub loadSubjectsToTileBar(sessionID As String, ClassName As String, subjectNames As List(Of String))

        If cmbSchYear.Text <> Nothing And cmbTerm.Text <> Nothing And cmbStdClass.Text <> Nothing Then
            NameCBGridView1Repository.Items.Clear()
            NameCBGridView1Repository.Items.AddRange(
                stdController.getStudentsSessionIDClassID(sessionID, CurrentClass(sessionID, ClassName).classID).Select(Function(x) x.fullName).Distinct.ToList
            )

            TileGroup2.Items.Clear()
            'For Each subject In subjectController_.getSubjectsBySessionIDClassID(currentSession.sessionID, currentClass.classID)
            For Each subjectName_ In subjectNames
                TileGroup2.Items.Add(createTileItem(subjectName_))
            Next
        Else
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
            If cmbStdClass.Text = Nothing Then
                MessageBox.Show("Select Class")
                cmbStdClass.Focus()
                Exit Sub
            End If
        End If

    End Sub

    Dim subjectsDictionary As New Dictionary(Of Integer, String)

    Private Sub NameCBGridView1Repository_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameCBGridView1Repository.SelectedIndexChanged
        Try
            Dim cmb As DevExpress.XtraEditors.ComboBoxEdit = CType(sender, DevExpress.XtraEditors.ComboBoxEdit)
            Dim editValue As Object = cmb.EditValue
            GridView1.SetRowCellValue(
                GridView1.FocusedRowHandle,
                colstd_id,
                stdController.getStudentsSessionIDClassID(
                        ScoreSession.sessionID,
                        CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).classID).FirstOrDefault(
                                Function(x) ((x.surname + " " + x.otherNames) = editValue.ToString
                          )
                    ).stdID
                )
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbStdClass_BeforePopup(sender As Object, e As EventArgs) Handles cmbStdClass.BeforePopup
        loadUserClasstoClassTextBox(ScoreSession, ActiveUser)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        WaitDlg(sWaitDlgStatus.Show, "Loading Subjects...", "Please Wait")

        If cmbStdClass.Text <> Nothing Then
            loadSubjectsToTileBarUserType(
            ScoreSession.sessionID,
            CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).stdClass
            )
        End If
        WaitDlg(sWaitDlgStatus.Hide)
    End Sub

    Private Sub addScoresView_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, GridView1.KeyDown, TileControl1.KeyDown
        Dim ClassID = CurrentClass(ScoreSession.sessionID, cmbStdClass.Text).classID
        If e.Control = True AndAlso e.KeyCode = Keys.S Then
            saveScore(
                  ScoreSession.sessionID,
                  ClassID,
                  CurrentSubject(ScoreSession.sessionID, ClassID, subjectName).subjectID,
                  GridView1
              )
            ShowAlertForm(Me.FindForm, "Saving Scores...", statusController.message)
        End If
    End Sub





    'Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
    '    Dim rowHandle As Integer = e.ListSourceRowIndex
    '    If e.IsGetData Then
    '        If e.Column Is GridColumn1 Then
    '            If Not subjectsDictionary.ContainsKey(rowHandle) Then
    '                subjectsDictionary.Add(rowHandle, stdController.getStudent(GridView1.GetRowCellDisplayText(rowHandle, "stdID")).fullName)
    '            End If
    '            e.Value = subjectsDictionary(rowHandle)
    '        End If
    '    End If
    '    If e.IsSetData Then
    '        subjectsDictionary(rowHandle) = Convert.ToString(e.Value)
    '    End If
    'End Sub

End Class
