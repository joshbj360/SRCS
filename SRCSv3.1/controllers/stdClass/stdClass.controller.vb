Imports System.Collections

Public Class StdClassController
    Implements IStdClassController

    Public Function GetListOfAllClassNames(sessionID As String) As List(Of String) Implements IStdClassController.GetListOfAllClassNames
        Dim classNames As IEnumerable = (
         From classes In GetListOfAllClassesBySessionID(sessionID)
         Select classes.stdClass
         ).OrderBy(Function(x) x).Distinct
        Return classNames.Cast(Of String).ToList()
    End Function


    Public Function GetListOfAllClassesBySessionID(sessionID As String) As List(Of StdClass) Implements IStdClassController.GetListOfAllClassesBySessionID
        Dim _classes As List(Of StdClass) = New List(Of StdClass)
        Dim da As dbDataSetTableAdapters.stdClassTableTableAdapter = New dbDataSetTableAdapters.stdClassTableTableAdapter

        For Each row As dbDataSet.stdClassTableRow In da.GetDataBySessionID(sessionID).Rows
            _classes.Add(New StdClass(row))
        Next
        Return _classes
    End Function

    Public Function IfClassExist(
                                Optional stdClass As StdClass = Nothing,
                                Optional sessionID As String = "",
                                Optional classId As String = "",
                                Optional className As String = "") As Boolean Implements IStdClassController.IfClassExist

        Return GetAllClasses().Exists(
        Function(x) (x.sessionID = stdClass.sessionID Or x.sessionID = sessionID) And
                    (x.classID = stdClass.classID Or x.stdClass = className)
        )
    End Function

    Public Sub assignFormTeacher(clasz As StdClass) Implements IStdClassController.assignFormTeacher
        Dim da As New dbDataSetTableAdapters.stdClassTableTableAdapter
        da.Update(
            clasz.stdClass,
            clasz.section,
            clasz.formTeacherName,
            clasz.sessionID,
            clasz.classID
            )
    End Sub

    Public Sub AddClass(class_ As StdClass) Implements IStdClassController.AddClass
        Try
            Dim da As New dbDataSetTableAdapters.stdClassTableTableAdapter
            If Not IfClassExist(class_) Then

                da.Insert(
                    class_.classID,
                    class_.sessionID,
                    class_.stdClass,
                    class_.section,
                    class_.formTeacherName
                    )

                statusController.status = True
                statusController.message = "Class added."
            Else
                statusController.status = False
                statusController.message = "Class already added."
            End If
        Catch ex As Exception
            statusController.message = "Could not add new class." + vbCrLf + ex.Message
        End Try


    End Sub

    Public Sub editClass(class_ As StdClass) Implements IStdClassController.editClass
        Try
            Dim da As New dbDataSetTableAdapters.stdClassTableTableAdapter
            da.Update(
            class_.stdClass,
            class_.section,
            class_.formTeacherName,
            class_.sessionID,
            class_.classID
            )

            statusController.message = "Class details successfully updated!"
            statusController.status = True
            MessageBox.Show(statusController.message)
        Catch ex As Exception
            statusController.status = False
            statusController.message = "Class details update failed! " + vbCrLf + ex.Message
        End Try


    End Sub

    Public Function generateClassID(sessionID As String, className As String) As String Implements IStdClassController.generateClassID
        Dim _id As String = String.Empty
        Try
            '_id = getDataFromMarksTable("std_id", "std_FullName", nameOfStd)
            _id = GetListOfAllClassesBySessionID(sessionID).FirstOrDefault(Function(x) x.stdClass.Contains(className)).classID

            If _id.Length = 32 Then
                Return _id
            End If
            ' MsgBox(_id.Substring(32)) '+ "   " + clasz)
        Catch ex As Exception
            '    ' MsgBox(ex.Message)
        End Try
        _id = Guid.NewGuid.ToString("N") '+ (clasz.Replace(" ", ""))
        Return _id
    End Function

    Public Sub deleteClass(class_ As StdClass) Implements IStdClassController.deleteClass
        Dim da As New dbDataSetTableAdapters.stdClassTableTableAdapter
        da.Delete(class_.classID, class_.sessionID)
        MessageBox.Show("Deleted.")
    End Sub


    ''' <summary>
    ''' Query all student by oldClassID
    ''' Promote them to newClassID and NewSessionID
    ''' </summary>
    ''' <param name="OldclassID"></param>
    ''' <param name="NewClassID"></param>
    ''' <param name="NewSessionID"></param>
    Public Sub PromoteClass(OldclassID As String, NewClassID As String, NewSessionID As String) Implements IStdClassController.PromoteClass
        For Each student In stdController.GetAllStudentsByClassID(OldclassID)
            student.stdClassID = NewClassID
            student.sessionID = NewSessionID
            stdController.promoteStudent(student)
        Next
    End Sub

    Public Function GetListOfAllClassesBySessionIDSection(sessionID As String, section As String) As List(Of StdClass) Implements IStdClassController.GetListOfAllClassesBySessionIDSection
        Return GetListOfAllClassesBySessionID(sessionID).Where(Function(x) x.section = section).ToList()
    End Function

    Public Function GetClassByClassID(classID As String) As StdClass Implements IStdClassController.GetClassByClassID
        Return GetAllClasses.FirstOrDefault(Function(x) x.classID = classID)
        '' MsgBox(classID + "  " + getAllClasses.FirstOrDefault(Function(x) x.classID = classID).stdClass)
    End Function

    Public ReadOnly Property GetClassBySessionIDClassNAme(sessonID As String, className As String) As StdClass Implements IStdClassController.GetClassBySessionIDClassNAme
        Get
            Return GetListOfAllClassesBySessionID(sessonID).FirstOrDefault(Function(x) x.stdClass = className)
        End Get

    End Property

    Public Function GetListOfAllClassNamesBySessionIDSection(sessionID As String, section As String) As List(Of String) Implements IStdClassController.GetListOfAllClassNamesBySessionIDSection
        Dim classNames As IEnumerable = (
         From classes In GetListOfAllClassesBySessionIDSection(sessionID, section)
         Select classes.stdClass
         ).OrderBy(Function(x) x).Distinct
        Return classNames.Cast(Of String).ToList()
    End Function

    Public Function GetAllClasses() As List(Of StdClass) Implements IStdClassController.GetAllClasses
        Dim _classes As List(Of StdClass) = New List(Of StdClass)
        Dim da As dbDataSetTableAdapters.stdClassTableTableAdapter = New dbDataSetTableAdapters.stdClassTableTableAdapter
        For Each row As dbDataSet.stdClassTableRow In da.GetData.Rows
            _classes.Add(New StdClass(row))
        Next
        Return _classes
    End Function

    Public Function getAllClassesName(section As String) As List(Of String) Implements IStdClassController.GetClassesName
        Dim classNames As IEnumerable = (
         From classes In GetAllClasses()
         Where classes.section = section
         Select classes.stdClass
         ).OrderBy(Function(x) x).Distinct
        Return classNames.Cast(Of String).ToList()

    End Function
End Class
