#Region "UserType"
Structure sUserType
    Const Admin = "Admin"
    Const subjectTeacher = "subjectTeacher"
    Const formTeacher = "formTeacher"
End Structure
#End Region

Public Interface IUser
    Property guid As String
    Property staffID As String
    Property fullName As String
    Property userName As String
    Property userType As String
    Property section As String
    Property password As String
    Property sessionID As String
End Interface

Public Interface IUserController
    'add user
    Sub addUser(user As User)
    'edit user
    Sub editUser(user As User)
    'Check if user exist
    Function ifUserExist(guid As String) As Boolean
    'valaidate or generate UserGUID
    Function ValidateOrGenerateGuid(Optional username As String = "", Optional fullname As String = "") As String
    'delete user 
    Sub deleteUser(sessionID As String, user As User)
    'assign a user to a class
    Sub assignUserToClass(user As User, stdClass As StdClass, session As SessionSettings)
    'assign a user to a subject
    Sub assignUserToSubject(user As User, subject As Subject, session As SessionSettings)
    'get user form-class | year
    Function getUserFormClass(stdClass As StdClass, session As SessionSettings) As User
    'get all subjects taught by a user | term session, all
    Function getAllSubjectsTaughtByUser(session As SessionSettings) As List(Of Subject)

    'get single user
    Function getUser(guid As String) As User
    Function getAllUsers() As List(Of User)
    Function getAllUsersNamesBySessionID(sessionID As String) As List(Of String)
    Function getUserByUserName(username As String) As User
    Function getUserByFullName(fullname As String) As User
End Interface
