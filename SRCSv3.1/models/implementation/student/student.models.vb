
Public Class student_
    Implements IStudent, IStudentFullNameAndClass
    Private ID_ As Integer
    Private _classOfAdmission, _dob, _otherNames, _stdID, _surname, _grNo, _passportPath _
        , fullname_, stdclassID_, sessionID_, _section, _status, gender_ As String
    Private _passport As Image
    Public Sub New()

    End Sub
    Public Sub New(datarow As DataRow)
        ID_ = CInt(datarow("ID"))
        fullname_ = String.Format("{0} {1}", datarow("surname"), datarow("otherNames"))
        stdclassID_ = String.Format("{0}", datarow("classID"))
        sessionID_ = String.Format("{0}", datarow("sessionID"))
        _section = String.Format("{0}", datarow("section"))
        _status = String.Format("{0}", datarow("status"))
        _grNo = String.Format("{0}", datarow("grNO"))
        gender_ = String.Format("{0}", datarow("gender"))
        _classOfAdmission = String.Format("{0}", datarow("classOfAdmission"))
        _dob = String.Format("{0}", datarow("DOB"))
        _otherNames = String.Format("{0}", datarow("otherNames"))
        _stdID = String.Format("{0}", datarow("stdID"))
        _surname = String.Format("{0}", datarow("surname"))
        _passportPath = String.Format("{0}", datarow("passportPath"))

        If _passportPath <> Nothing Then
            Try
                _passport = Image.FromFile(Application.StartupPath + _passportPath)
            Catch ex As Exception

            End Try

        Else
            _passport = My.Resources.Unknown_user
        End If
    End Sub
    Public ReadOnly Property ID As Integer Implements IStudent.ID
        Get
            Return ID_
        End Get
    End Property

    Public Property fullName As String Implements IStudentFullNameAndClass.fullName
        Get
            Return fullname_
        End Get
        Set(value As String)
            fullname_ = value
        End Set
    End Property

    Public Property section As String Implements IStudentFullNameAndClass.section
        Get
            Return _section
        End Get
        Set(value As String)
            _section = value
        End Set
    End Property

    Public Property status As String Implements IStudentFullNameAndClass.status
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property stdClassID As String Implements IStudentFullNameAndClass.stdClass
        Get
            Return stdclassID_
        End Get
        Set(value As String)
            stdclassID_ = value
        End Set
    End Property

    Public Property gender As String Implements IStudent.gender
        Get
            Return gender_
        End Get
        Set(value As String)
            gender_ = value
        End Set
    End Property
    Public Property classOfAdmission As String Implements IStudent.classOfAdmission
        Get
            Return _classOfAdmission
        End Get
        Set(value As String)
            _classOfAdmission = value
        End Set
    End Property

    Public Property DOB As String Implements IStudent.DOB
        Get
            Return _dob
        End Get
        Set(value As String)
            _dob = value
        End Set
    End Property

    Public Property grNo As String Implements IStudent.grNo
        Get
            Return _grNo
        End Get
        Set(value As String)
            _grNo = value
        End Set
    End Property

    Public Property otherNames As String Implements IStudent.otherNames
        Get
            Return _otherNames
        End Get
        Set(value As String)
            _otherNames = value
        End Set
    End Property


    Public Property stdID As String Implements IStudent.stdID
        Get
            Return _stdID
        End Get
        Set(value As String)
            _stdID = value
        End Set
    End Property

    Public Property surname As String Implements IStudent.surname
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Property Passport As Image Implements IStudent.Passport
        Get
            Return _passport
        End Get
        Set(value As Image)
            _passport = value
        End Set
    End Property

    Public Property passportPath As String Implements IStudent.passportPath
        Get
            Return _passportPath
        End Get
        Set(value As String)
            _passportPath = value
        End Set
    End Property

    Public Property sessionID As String Implements IStudentFullNameAndClass.sessionID
        Get
            Return sessionID_
        End Get
        Set(value As String)
            sessionID_ = value
        End Set
    End Property
End Class
