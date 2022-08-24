Imports SRCSv3._1

Public Class StdClass
    Implements IStdClass

    Private formTeacher_, sessionID_, section_, stdClass_, classID_ As String
    Public Sub New()

    End Sub

    Public Sub New(stdClass As DataRow)
        classID_ = String.Format("{0}", stdClass("classID"))
        formTeacher_ = String.Format("{0}", stdClass("formTeacherName"))
        sessionID_ = String.Format("{0}", stdClass("sessionID"))
        section_ = String.Format("{0}", stdClass("section"))
        stdClass_ = String.Format("{0}", stdClass("stdClass"))
    End Sub

    Public Property formTeacherName As String Implements IStdClass.formTeacherName
        Get
            Return formTeacher_
        End Get
        Set(value As String)
            formTeacher_ = value
        End Set
    End Property


    Public Property section As String Implements IStdClass.section
        Get
            Return section_
        End Get
        Set(value As String)
            section_ = value
        End Set
    End Property

    Public Property stdClass As String Implements IStdClass.stdClass
        Get
            Return stdClass_
        End Get
        Set(value As String)
            stdClass_ = value
        End Set
    End Property

    Public Property classID As String Implements IStdClass.classID
        Get
            Return classID_
        End Get
        Set(value As String)
            classID_ = value
        End Set
    End Property

    Public Property sessionID As String Implements IStdClass.sessionID
        Get
            Return sessionID_
        End Get
        Set(value As String)
            sessionID_ = value
        End Set
    End Property
End Class
