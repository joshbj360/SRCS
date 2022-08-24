Imports SRCSv3._1

Public Class User
    Implements IUser

    Private staff_id_renamed, u_name_renamed, _password,
    usertype_renamed, user_sbjects_renamed, section_,
    u_fullname_renamed, sessionid_renamed, guid_ As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal user As DataRow)
        guid_ = String.Format("{0}", user("guid"))
        staff_id_renamed = String.Format("{0}", user("staff_id"))  'String.Format("{0}", score("std_fullName"))
        u_name_renamed = String.Format("{0}", user("username"))
        _password = String.Format("{0}", user("password"))
        usertype_renamed = String.Format("{0}", user("usertype"))

        ' std_class_renamed = String.Format("{0}", user("std_class"))
        '   user_sbjects_renamed = String.Format("{0}", user("subjects"))
        u_fullname_renamed = String.Format("{0}", user("fullName"))
        sessionid_renamed = String.Format("{0}", user("sessionID"))
        ' term_renamed = String.Format("{0}", user("term"))
        section_ = String.Format("{0}", user("section"))

    End Sub

    Public Property fullName As String Implements IUser.fullName
        Get
            Return u_fullname_renamed
        End Get
        Set(value As String)
            u_fullname_renamed = value
        End Set
    End Property

    Public Property guid As String Implements IUser.guid
        Get
            Return guid_
        End Get
        Set(value As String)
            guid_ = value
        End Set
    End Property

    Public Property password As String Implements IUser.password
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property section As String Implements IUser.section
        Get
            Return section_
        End Get
        Set(value As String)
            section_ = value
        End Set
    End Property

    Public Property sessionID As String Implements IUser.sessionID
        Get
            Return sessionid_renamed
        End Get
        Set(value As String)
            sessionid_renamed = value
        End Set
    End Property

    Public Property staffID As String Implements IUser.staffID
        Get
            Return staff_id_renamed
        End Get
        Set(value As String)
            staff_id_renamed = value
        End Set
    End Property

    Public Property userName As String Implements IUser.userName
        Get
            Return u_name_renamed
        End Get
        Set(value As String)
            u_name_renamed = value
        End Set
    End Property

    Public Property userType As String Implements IUser.userType
        Get
            Return usertype_renamed
        End Get
        Set(value As String)
            usertype_renamed = value
        End Set
    End Property
End Class
