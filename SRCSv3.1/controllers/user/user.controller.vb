Imports System.Collections
Imports DevExpress.XtraEditors
Imports SRCSv3._1

Public Class UserController
    Implements IUserController

    Public Sub addUser(user As User) Implements IUserController.addUser
        If Not ifUserExist(user.guid) Then
            Dim da As New dbDataSetTableAdapters.userTableTableAdapter
            da.Insert(
                        user.staffID,
                        user.fullName,
                        user.userName,
                        user.password,
                        user.userType,
                        user.section,
                        "",
                        user.guid,
                        user.sessionID
                        )
        Else
            editUser(user)
        End If

    End Sub

    Public Sub assignUserToClass(user As User, stdClass As StdClass, session As SessionSettings) Implements IUserController.assignUserToClass
        If user.userType = sUserType.formTeacher Then
            If classController.IfClassExist(stdClass) Then
                classController.editClass(stdClass)
            Else
                XtraMessageBox.Show("Error assigning Form Teacher.")
            End If
        End If
    End Sub

    Public Sub assignUserToSubject(user As User, subject As Subject, session As SessionSettings) Implements IUserController.assignUserToSubject
        Throw New NotImplementedException()
    End Sub

    Public Sub deleteUser(sessionID As String, user As User) Implements IUserController.deleteUser
        Dim da As dbDataSetTableAdapters.userTableTableAdapter = New dbDataSetTableAdapters.userTableTableAdapter
        da.DeleteQuerySessionIDUserID(sessionID, user.guid)
    End Sub

    Public Sub editUser(user As User) Implements IUserController.editUser
        Dim da As New dbDataSetTableAdapters.userTableTableAdapter
        ' MsgBox(user.guid)
        da.Update(
        user.staffID,
        user.fullName,
        user.userName,
        user.password,
        user.userType,
        user.section,
        "",
        user.sessionID,
        user.guid
)
    End Sub

    Public Function getAllSubjectsTaughtByUser(session As SessionSettings) As List(Of Subject) Implements IUserController.getAllSubjectsTaughtByUser
        Throw New NotImplementedException()
    End Function

    Public Function getAllUsers() As List(Of User) Implements IUserController.getAllUsers
        Dim users_ As New List(Of User)
        Dim da As New dbDataSetTableAdapters.userTableTableAdapter

        For Each row As dbDataSet.userTableRow In da.GetData
            users_.Add(New User(row))
        Next
        Return users_
    End Function

    Public Function getAllUsersNamesBySessionID(sessionID As String) As List(Of String) Implements IUserController.getAllUsersNamesBySessionID
        Dim userNames As IEnumerable = (
        From users In getAllUsers()
        Where users.sessionID = sessionID
        Select users.fullName
        ).OrderBy(Function(x) x).Distinct
        Return userNames.Cast(Of String).ToList
    End Function

    Public Function getUser(guid As String) As User Implements IUserController.getUser
        Return getAllUsers.FirstOrDefault(
        Function(x) x.guid = guid
        )
    End Function

    Public Function getUserByFullName(fullname As String) As User Implements IUserController.getUserByFullName
        Return getAllUsers.FirstOrDefault(
            Function(x) x.fullName = fullname)
    End Function

    Public Function getUserByUserName(username As String) As User Implements IUserController.getUserByUserName
        Return getAllUsers.FirstOrDefault(
            Function(x) x.userName = username)
    End Function

    Public Function getUserFormClass(stdClass As StdClass, session As SessionSettings) As User Implements IUserController.getUserFormClass
        Throw New NotImplementedException()
    End Function

    Public Function ifUserExist(guid As String) As Boolean Implements IUserController.ifUserExist
        Return getAllUsers.Exists(Function(x) x.guid = guid)
    End Function

    Public Function ValidateOrGenerateGuid(Optional username As String = "", Optional fullname As String = "") As String Implements IUserController.ValidateOrGenerateGuid
        Dim _id As String = ""
        Try
            '_id = getDataFromMarksTable("std_id", "std_FullName", nameOfStd)
            _id = getAllUsers.FirstOrDefault(Function(x) x.fullName.Contains(fullname) And x.userName.Contains(username)).guid

            If _id.Length = 32 Then
                Return _id
            End If
            MsgBox(_id.Substring(32)) '+ "   " + clasz)
        Catch ex As Exception
            '    ' MsgBox(ex.Message)
        End Try
        _id = Guid.NewGuid.ToString("N") '+ (clasz.Replace(" ", ""))
        Return _id
    End Function
End Class
