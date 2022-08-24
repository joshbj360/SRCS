Imports SRCSv3._1
Public Class ChangeStatus
    Implements IChangeStatus
    Private message_ As String
    Private status_ As Boolean
    Private sender_ As Object
    Public Sub New()
        message_ = "NotImplemented"
        status_ = False
    End Sub
    Public Property message As String Implements IChangeStatus.message
        Get
            Return message_
        End Get
        Set(value As String)
            message_ = value
        End Set
    End Property

    Public Property sender As Object Implements IChangeStatus.sender
        Get
            Return sender_
        End Get
        Set(value As Object)
            sender_ = value
        End Set
    End Property

    Public Property status As Boolean Implements IChangeStatus.status
        Get
            Return status_
        End Get
        Set(value As Boolean)
            status_ = value
        End Set
    End Property
End Class

Public Class Navigation
    Implements INavigation
    Private academicSession_, term_, studentClass_, subjectsName_ As String

    Public Sub New()
        academicSession_ = defaultSessionSettings.academicSession
        term_ = defaultSessionSettings.term
    End Sub
    Public Property academicSession As String Implements INavigation.academicSession
        Get
            Return academicSession_
        End Get
        Set(value As String)
            academicSession_ = value
        End Set
    End Property

    Public Property studentClass As String Implements INavigation.studentClass
        Get
            Return studentClass_
        End Get
        Set(value As String)
            studentClass_ = value
        End Set
    End Property

    Public Property subjectName As String Implements INavigation.subjectName
        Get
            Return subjectsName_
        End Get
        Set(value As String)
            subjectsName_ = value
        End Set
    End Property

    Public Property term As String Implements INavigation.term
        Get
            Return term_
        End Get
        Set(value As String)
            term_ = value
        End Set
    End Property

    'Public Function subjectFromNavSelection() As Subject Implements INavigation.subjectFromNavSelection
    '    Return SubjectController.getSubjects(Me.academicSession, Me.term).FirstOrDefault(Function(x) x.subjectName = Me.subjectName)
    'End Function
End Class
