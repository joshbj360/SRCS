Imports System.Collections
Imports SRCSv3._1

Public Class SubjectController
    Implements ISubjectControllers

#Region "Default Subject Functions"
    Public Sub addDefaultSubject(defaultSubject As DefaultSubject) Implements ISubjectControllers.addDefaultSubject
        Try
            Dim da As New dbDataSetTableAdapters.defaultSubjectTableTableAdapter
            da.Insert(
                defaultSubject.subjectName,
                defaultSubject.section,
                defaultSubject.stdClass,
                generateSubjectID
                )
            statusController.message = "Subject(s) details successfully added!"
            statusController.status = True

        Catch ex As Exception
            statusController.status = False
            statusController.message = "Subject details update failed! " + vbCrLf + ex.Message
        End Try
    End Sub
    Public Sub addDefaultSubjects(defaultSubjects As List(Of DefaultSubject)) Implements ISubjectControllers.addDefaultSubjects
        For Each subject In defaultSubjects
            addDefaultSubject(subject)
        Next
    End Sub

    Public Sub deleteDefaultSubject(subject As DefaultSubject) Implements ISubjectControllers.deleteDefaultSubject
        Dim da As New dbDataSetTableAdapters.defaultSubjectTableTableAdapter
        da.Delete(subject.section, subject.subjectName, subject.section, subject.subjectID)
    End Sub

    Public Function getDefaultSubjects(section As String) As List(Of DefaultSubject) Implements ISubjectControllers.getDefaultSubjects
        Dim da As New dbDataSetTableAdapters.defaultSubjectTableTableAdapter
        Dim subjects_ As List(Of DefaultSubject) = New List(Of DefaultSubject)
        For Each row As dbDataSet.defaultSubjectTableRow In da.GetDataBySection(section).Rows
            subjects_.Add(New DefaultSubject(row))
        Next
        Return subjects_
    End Function

    Public Function ifDefaultSubjectExist(subject As DefaultSubject) As Boolean Implements ISubjectControllers.ifDefaultSubjectExist
        Return getDefaultSubjectsByClass(subject.section, subject.stdClass).Exists(
            Function(x) x.subjectID = subject.subjectID
         )
    End Function


    Public Function getDefaultSubjectsByClass(section As String, className As String) As List(Of DefaultSubject) Implements ISubjectControllers.getDefaultSubjectsByClass
        Dim da As New dbDataSetTableAdapters.defaultSubjectTableTableAdapter
        Dim subjects_ As List(Of DefaultSubject) = New List(Of DefaultSubject)
        For Each row As dbDataSet.defaultSubjectTableRow In da.GetDataBySectionClass(section, className).Rows
            subjects_.Add(New DefaultSubject(row))
        Next
        Return subjects_
    End Function

    Public Function getDefaultSubjectsNames(section As String) As List(Of String) Implements ISubjectControllers.getDefaultSubjectsNames
        Dim subjectNames As IEnumerable = (
        From names In getDefaultSubjects(section)
        Where names.section = section
        Select names.subjectName).OrderBy(Function(s) s).Distinct
        Return subjectNames.Cast(Of String).ToList
    End Function

    Public Sub updateDefaultSubject(defaultSubject As DefaultSubject) Implements ISubjectControllers.updateDefaultSubject
        Dim da As New dbDataSetTableAdapters.defaultSubjectTableTableAdapter
        da.Update(
             defaultSubject.subjectName,
             defaultSubject.section,
             defaultSubject.subjectID,
             defaultSubject.stdClass
     )
        statusController.message = "Subject(s) details successfully updated!"
        statusController.status = True
    End Sub
#End Region

#Region "Subject Functions"
    Public Sub addSubject(subject As Subject) Implements ISubjectControllers.addSubject
        Try
            If Not ifSubjectExist(subject) Then
                Dim da As New dbDataSetTableAdapters.subjectTableTableAdapter
                da.Insert(
                       subject.subjectName,
                       subject.subjectTeacherName,
                       subject.subjectID,
                       subject.sessionID,
                       subject.classID,
                       subject.section
                       )

                statusController.message = "Subject(s) details successfully added!"
                statusController.status = True
                ' MessageBox.Show(statusController.message)
            Else
                Dim da As New dbDataSetTableAdapters.subjectTableTableAdapter
                da.Update(
                       subject.subjectName,
                       subject.subjectTeacherName,
                       subject.subjectID,
                       subject.sessionID,
                       subject.classID,
                       subject.section
                       )

                statusController.message = "Subject(s) details successfully added!"
                statusController.status = True
                ' MessageBox.Show(statusController.message)
            End If

        Catch ex As Exception
            statusController.status = False
            statusController.message = "Subject details update failed! " + vbCrLf + ex.Message
        End Try
    End Sub
    Public Function generateSubjectID() As String Implements ISubjectControllers.generateSubjectID
        Dim _id As String = Guid.NewGuid.ToString("N")
        Return _id
    End Function



    Public Sub deleteSubjects(sessionID As String, classID As String) Implements ISubjectControllers.deleteSubjects
        Dim da As New dbDataSetTableAdapters.subjectTableTableAdapter
        da.Delete(sessionID, classID)
    End Sub

    Public Sub updateSubject(subject As Subject) Implements ISubjectControllers.updateSubject
        Throw New NotImplementedException()
    End Sub



    Public Function getSubjects(sessionID As String) As List(Of Subject) Implements ISubjectControllers.getSubjects
        Dim subjectList As List(Of Subject) = New List(Of Subject)
        Dim dataAdapter As dbDataSetTableAdapters.subjectTableTableAdapter = New dbDataSetTableAdapters.subjectTableTableAdapter

        subjectList.Clear()
        For Each row As dbDataSet.subjectTableRow In dataAdapter.GetDataBySessionID(sessionID).Rows
            subjectList.Add(New Subject(row))
        Next

        Return subjectList
    End Function

    Public Function getSubjectsBySessionIDClassID(sessionID As String, classID As String) As List(Of Subject) Implements ISubjectControllers.getSubjectsBySessionIDClassID
        Dim subjectList As List(Of Subject) = New List(Of Subject)
        Dim dataAdapter As dbDataSetTableAdapters.subjectTableTableAdapter = New dbDataSetTableAdapters.subjectTableTableAdapter

        subjectList.Clear()
        For Each row As dbDataSet.subjectTableRow In dataAdapter.GetDataBySessionIDClassID(sessionID, classID).Rows
            subjectList.Add(New Subject(row))
        Next
        ''MsgBox(subjectList.Count)
        Return subjectList
    End Function


    Public Function ifSubjectExist(subject As Subject) As Boolean Implements ISubjectControllers.ifSubjectExist
        ' MsgBox(subject.subjectName)
        Return getSubjectsBySessionIDClassID(subject.sessionID, subject.classID).Exists(
        Function(x) x.subjectID = subject.subjectID And x.sessionID = subject.sessionID
        )
    End Function

    Public Function subjectFromID(subjectID As String) As Subject Implements ISubjectControllers.subjectFromID
        Dim da As New dbDataSetTableAdapters.subjectTableTableAdapter
        Return New Subject(da.GetDataSubjectID(subjectID).FirstOrDefault)
    End Function

    Public Function getSubjectsBySection(section As String) As List(Of Subject) Implements ISubjectControllers.getSubjectsBySection
        Dim da As New dbDataSetTableAdapters.subjectTableTableAdapter
        Dim subjects_ As List(Of Subject) = New List(Of Subject)
        For Each row As dbDataSet.subjectTableRow In da.GetDataBySection(section).Rows
            subjects_.Add(New Subject(row))
        Next
        Return subjects_
    End Function

    Public Function getSubjectsBySessionIDClassIDUserID(sessionID As String, classID As String, UserFullName As String) As List(Of Subject) Implements ISubjectControllers.getSubjectsBySessionIDClassIDUserID
        Dim subjectList As List(Of Subject) = New List(Of Subject)
        Dim dataAdapter As dbDataSetTableAdapters.subjectTableTableAdapter = New dbDataSetTableAdapters.subjectTableTableAdapter

        subjectList.Clear()
        For Each row As dbDataSet.subjectTableRow In dataAdapter.GetDataBySessionIDClassID(sessionID, classID).Rows
            subjectList.Add(New Subject(row))
        Next

        Return subjectList.Where(Function(x) x.subjectTeacherName = UserFullName).Distinct.ToList
    End Function

    Public Function getSubjectBySessionIDClassIDSubjectName(sessionID As String, classID As String, subjectName As String) As Subject Implements ISubjectControllers.getSubjectBySessionIDClassIDSubjectName
        Return getSubjectsBySessionIDClassID(sessionID, classID).FirstOrDefault(Function(x) x.subjectName = subjectName)

    End Function
    Public Function getSubjectBySubjectID(SessionID As String, subjectID As String) As Subject Implements ISubjectControllers.getSubjectBySubjectID
        Return getSubjects(SessionID).FirstOrDefault(Function(x) x.subjectID = subjectID)

    End Function

#End Region
End Class
