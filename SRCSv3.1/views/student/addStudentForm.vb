
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class addStudentForm
    Dim cmd As OleDbCommand
    Dim x As String
    '' Private currentSession As SessionSettings = setsController.CurrentSession(defaultYearTerm.academicSession, defaultYearTerm.term)
    Private currentClass As StdClass
    Public Sub New(currentSession As SessionSettings)
        InitializeComponent()

        grNo()
        InitEditors(currentSession)
        sbOK.Tag = "add"
    End Sub
    Public Sub New(classz As StdClass)
        InitializeComponent()
        grNo()
        InitEditors(GlobalCurrentSession)
        sbOK.Tag = "add"
        currentClass = classz
    End Sub
    Public Sub New(ByVal std As student_)
        InitializeComponent()
        grNo()
        InitEditors(GlobalCurrentSession)
        currentClass = classController.GetClassByClassID(std.stdClassID)
        '  InitMenuManager(menuManager)
        pePhoto.Image = std.Passport
        txtgrno.Text = std.grNo
        txtstdid.Text = std.stdID
        txtsname.Text = std.surname
        txtoname.Text = std.otherNames

        cmbdob.Text = std.DOB
        cmbgender.SelectItemByDescription(std.gender)
        'memAddress.Text = STD.Address
        'year of addmission

        'txtGfullname.Text = STD.F_name
        'txtmname.Text = STD.M_name
        cmbclass.Text = currentClass.stdClass
        'txtlastsch.Text = STD.PreviousSch
        'txtPhno.Text = STD.Phone
        'txtemail.Text = STD.Email
        'rdgPhyChal.EditValue = STD.Disability
        'cmbnationality.Text = STD.Nationality
        'memNotes.Text = STD.Note
        Text = std.fullName
        InitValidationProvider()
        sbOK.Tag = "update"
    End Sub

    Private Sub InitValidationProvider()
        'dxValidationProvider1.SetValidationRule(txtgrno, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(txtstdid, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(cmbdob, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(cmbgender, ValidationRulesHelper.RuleIsNotBlank)
        dxValidationProvider1.SetValidationRule(cmbclass, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(cmbnationality, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(txtlastsch, ValidationRulesHelper.RuleIsNotBlank)
        dxValidationProvider1.SetValidationRule(txtsname, ValidationRulesHelper.RuleIsNotBlank)
        dxValidationProvider1.SetValidationRule(txtoname, ValidationRulesHelper.RuleIsNotBlank)
        dxValidationProvider1.SetValidationRule(cmbSection, ValidationRulesHelper.RuleIsNotBlank)
        '  dxValidationProvider1.SetValidationRule(txtPhno, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(txtGfullname, ValidationRulesHelper.RuleIsNotBlank)
        'dxValidationProvider1.SetValidationRule(pePhoto, ValidationRulesHelper.RuleIsNotBlank)
    End Sub


    Private Sub InitEditors(currentSession As SessionSettings)
        InitPersonComboBox(cmbgender.Properties)
        cmbclass.Properties.Items.AddRange(classController.GetListOfAllClassNames(currentSession.sessionID).Distinct.ToList)
        ' cmbclass.Text = nav.studentClass
        rdgPhyChal.SelectedIndex = 0
        txtsname.Focus()
    End Sub
#Region "Add Sudent"
    Private y As Integer
    Public Sub grNo()
        Try

            If stdController.getAllStudents.Count < 1 Then
                y = "001"
            Else
                y = (stdController.getAllStudents.LastOrDefault.ID + 1)
            End If
            ' Guid.NewGuid.ToString.Substring(0, 4).ToUpper
            x = stdController.getAllStudents.Count.ToString
            x += 1
            txtgrno.Text = "0" + x
            ' txtstdid.Text = admController.IDInitial + Now.ToString("yyyy") + "/" + txtgrno.Text
            txtstdid.Text = String.Format("{0}/{1}/{2}/{3}", admController.IDInitial, y, Now.ToString("yyyy"), txtgrno.Text)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub sbCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCancel.Click
        dxValidationProvider1.RemoveControlError(cmbclass)
        dxValidationProvider1.RemoveControlError(txtsname)
        dxValidationProvider1.RemoveControlError(txtoname)
        dxValidationProvider1.RemoveControlError(cmbSection)
        Me.FindForm.Close()
    End Sub

    Private bytes As Byte()
    Private Sub saveStudent(currentSession As SessionSettings)
        InitValidationProvider()
        If dxValidationProvider1.Validate Then
            Dim class_ As StdClass = classController.GetClassBySessionIDClassNAme(currentSession.sessionID, cmbclass.Text)
            If class_ Is Nothing Then
                XtraMessageBox.Show("Class not found!")
                Exit Sub
            End If
            addUpdate(currentSession, class_.classID)
        Else
            XtraMessageBox.Show("Marked Fields are required")
            Exit Sub
        End If

    End Sub
    Private Sub sbOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbOK.Click
        saveStudent(GlobalCurrentSession)
    End Sub
    Private Function student_(SessionID As String, classID As String) As student_
        Dim std_ As student_ = New student_
        std_.fullName = String.Format("{0} {1}", txtsname.Text, txtoname.Text)
        std_.classOfAdmission = cmbClassOfAdmission.Text
        std_.DOB = cmbdob.Text
        std_.otherNames = txtoname.Text.Trim
        std_.sessionID = SessionID
        std_.section = cmbSection.Text
        std_.status = RadioGroup1.EditValue.ToString
        std_.stdClassID = classID
        std_.stdID = txtstdid.Text
        std_.surname = txtsname.Text.Trim
        std_.gender = cmbgender.Text

        Try
            Dim newSize As System.Drawing.Size
            newSize.Height = 420
            newSize.Width = 350
            Dim ms As New IO.MemoryStream

            If pePhoto IsNot Nothing Then
                Dim passport_name As String = "\db\student_passport\" + txtoname.Text + "_" + txtsname.Text + ".jpg"
                std_.passportPath = passport_name
                Dim img As Bitmap = New Bitmap(pePhoto.Image, newSize)
                img.Save(Application.StartupPath + passport_name, Imaging.ImageFormat.Jpeg)
                ' pePhoto.Image.Save(ms, Imaging.ImageFormat.Bmp)
                ' bytes = ms.GetBuffer
                '   STD.Photo = pePhoto.Image
                '  pri_std.Assign(STD)
            End If

        Catch ex As Exception
            '    MsgBox(ex.Message)
        End Try

        Return std_
    End Function
    Private Function score_(sessionID As String, classID As String, subjectID As String) As Score
        Dim _score As Score = New Score
        _score.stdID = txtstdid.Text
        _score.classID = classID
        _score.sessionID = sessionID
        _score.subjectID = subjectID
        _score.studentFullName = String.Format("{0} {1}", txtsname.Text, txtoname.Text)
        Return _score
    End Function

    Private Sub addUpdate(CurrentSession As SessionSettings, classID As String)
        If sbOK.Tag Is "add" Then

            If stdController.ifStudentExist(CurrentSession.sessionID, txtstdid.Text, txtsname.Text, txtoname.Text) Then
                XtraMessageBox.Show("Student already saved")
                clearFields()
                grNo()
                Exit Sub

                'And also check if the student in all existing seleted subjects for the class.
                'If not, then add.
            Else
                stdController.addStudent(
                    student_(
                   CurrentSession.sessionID,
                    classID
                    )
                )
                For Each subject In subjectController_.getSubjectsBySessionIDClassID(CurrentSession.sessionID, classID)
                    scoreController_.addScore(score_(
                                             CurrentSession.sessionID,
                                             classID,
                                             subject.subjectID
                    )
                )
                Next
                XtraMessageBox.Show("Addmission Done Successfully")
                '  resetall()
                txtgrno.Text = ""
            End If
        ElseIf sbOK.Tag Is "update" Then
            'Try '
            stdController.updateStudent(student_(CurrentSession.sessionID, classID))
            Dim score As New Score With {
                .sessionID = CurrentSession.sessionID,
                .classID = classID,
                .studentFullName = String.Format("{0} {1}", txtsname.Text, txtoname.Text),
                .stdID = txtstdid.Text
            }

            scoreController_.updateStudentFullName(score)
            XtraMessageBox.Show("Records Updated Successfully")
            'Catch ex As Exception
            '    XtraMessageBox.Show(ex.Message)
            'End Try
        End If
    End Sub

    Private Sub clearFields()
        grno()
        txtsname.Text = Nothing
        txtsname.Focus()
        txtoname.Text = Nothing
        cmbSection.Text = Nothing
        cmbdob.Text = Nothing
        cmbgender.Text = Nothing
        memAddress.Text = Nothing
        pePhoto.Image = My.Resources.Unknown_user
        txtGfullname.Text = Nothing
        txtmname.Text = Nothing
        cmbclass.Text = Nothing
        txtlastsch.Text = Nothing
        txtPhno.Text = Nothing
        txtemail.Text = Nothing
        cmbnationality.Text = Nothing
        rdgPhyChal.EditValue = Nothing
        memNotes.Text = Nothing
        'cmbSooTb.Text = Nothing
        'cmbLgaTb.Text = Nothing
        'chkAdmStatus.Text = Nothing
        txtgrno.Enabled = False
        txtstdid.Enabled = False
        InitEditors(GlobalCurrentSession)
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        saveStudent(GlobalCurrentSession)
        clearFields()
        grNo()
        cmbclass.Text = currentClass.stdClass
        cmbSection.Text = currentClass.section
    End Sub

#End Region
End Class

