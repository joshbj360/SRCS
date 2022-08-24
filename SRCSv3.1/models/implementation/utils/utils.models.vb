Imports SRCSv3._1

Public Class ChangeStatus
    Implements IChangeStatus
    Private message_ As String
    Private status_ As Boolean
    Private sender_ As Object

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
    Private hasChanged_ As Boolean

End Class

Public Class MessageDetails
    Implements IMessageDetails
    Private message_, caption_ As String
    Public Sub New()
        Try
            caption_ = String.Format("{0}, ({1})", setsController.getSchoolSettings.schName, GlobalCurrentSession.sessionID)
        Catch ex As Exception

        End Try
    End Sub
    Public Property message As String Implements IMessageDetails.message
        Get
            Return message_
        End Get
        Set(value As String)
            message_ = value
        End Set
    End Property

    Public Property caption As String Implements IMessageDetails.caption
        Get
            Return caption_
        End Get
        Set(value As String)
            caption_ = value
        End Set
    End Property

    Public Property buttonType As MessageBoxButtons Implements IMessageDetails.buttonType
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As MessageBoxButtons)
            Throw New NotImplementedException()
        End Set
    End Property
End Class