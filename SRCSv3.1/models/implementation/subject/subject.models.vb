Imports SRCSv3._1
Public Class DefaultSubject
    Implements IDefaultSubject

    Private stdClass_, subjectName_, subjectID_ As String
    Private section_ As String
    Public Sub New()
    End Sub
    Public Sub New(subject As DataRow)
        subjectName_ = String.Format("{0}", subject("subjectName"))
        section_ = String.Format("{0}", subject("section"))
        stdClass_ = String.Format("{0}", subject("stdClass"))
        subjectID_ = String.Format("{0}", subject("subjectID"))
    End Sub
    Public Property subjectID As String Implements IDefaultSubject.subjectID
        Get
            Return subjectID_
        End Get
        Set(value As String)
            subjectID_ = value
        End Set
    End Property
    Public Property section As String Implements IDefaultSubject.section
        Get
            Return section_
        End Get
        Set(value As String)
            section_ = value
        End Set
    End Property

    Public Property subjectName As String Implements IDefaultSubject.subjectName
        Get
            Return subjectName_
        End Get
        Set(value As String)
            subjectName_ = value
        End Set
    End Property

    Public Property stdClass As String Implements IDefaultSubject.stdClass
        Get
            Return stdClass_
        End Get
        Set(value As String)
            stdClass_ = value
        End Set
    End Property


End Class
Public Class Subject
    Implements ISubject

    Private subjectName_, subjectTeacher_, sessionID_, classID_, subjectID_, section_, stdClass_ As String
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(subject As DataRow)

        subjectTeacher_ = String.Format("{0}", subject("subjectTeacherName"))
        sessionID_ = String.Format("{0}", subject("sessionID"))
        classID_ = String.Format("{0}", subject("classID"))
        subjectID_ = String.Format("{0}", subject("subjectID"))
        subjectName_ = String.Format("{0}", subject("subjectName"))
        section_ = String.Format("{0}", subject("section"))
        stdClass_ = String.Format("{0}", subject("stdClass"))

    End Sub

    Public Property classID As String Implements ISubject.classID
        Get
            Return classID_
        End Get
        Set(value As String)
            classID_ = value
        End Set
    End Property

    Public Property sessionID As String Implements ISubject.sessionID
        Get
            Return sessionID_
        End Get
        Set(value As String)
            sessionID_ = value
        End Set
    End Property

    Public Property subjectTeacherName As String Implements ISubject.subjectTeacherName
        Get
            Return subjectTeacher_
        End Get
        Set(value As String)
            subjectTeacher_ = value
        End Set
    End Property

    Public Property section As String Implements ISubject.section
        Get
            Return section_
        End Get
        Set(value As String)
            section_ = value
        End Set
    End Property

    Public Property subjectName As String Implements IDefaultSubject.subjectName
        Get
            Return subjectName_
        End Get
        Set(value As String)
            subjectName_ = value
        End Set
    End Property

    Public Property stdClass As String Implements IDefaultSubject.stdClass
        Get
            Return stdClass_
        End Get
        Set(value As String)
            stdClass_ = value
        End Set
    End Property

    Public Property subjectID As String Implements IDefaultSubject.subjectID
        Get
            Return subjectID_
        End Get
        Set(value As String)
            subjectID_ = value
        End Set
    End Property
End Class
