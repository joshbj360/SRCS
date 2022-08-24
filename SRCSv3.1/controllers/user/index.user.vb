Module indexUser
    Public userController_ As UserController = New UserController

    Private _user As User
    Public Property ActiveUser As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

End Module
