Imports System.Collections
Imports SRCSv3._1

Public Class StudentController
    Implements IStudentController

    Public Sub addStudent(student As student_) Implements IStudentController.addStudent
        Dim da As New dbDataSetTableAdapters.studentTableTableAdapter
        da.Insert(
                  "", 'grno
                  student.stdID, 'studentID
                  student.surname, 'surname
                  student.otherNames, 'othernames
                  student.DOB, 'dob
                  "", ' gender
                  "", 'address
                  "", 'term of admission
                  "", 'year of admission
                  "", 'gurdian name
                  student.section, 'section
                  student.classOfAdmission, 'class of admission
                  "", 'previous school attended
                  "", 'studnet phone
                  "", 'student email
                  "", 'nationality
                  "", 'disablity
                  "", 'note
                  "", 'religion
                  student.status,'status
                  "", 'state of origin
                  "", 'lga
                  1, 'entrance score
                  student.passportPath,'passportpath
                  student.sessionID, 'sessionID' 
                  student.stdClassID 'classID
                  )


    End Sub

    Public Sub addStudents(students As List(Of student_)) Implements IStudentController.addStudents
        For Each std In students
            addStudent(std)
        Next
    End Sub

    Public Sub deleteStudent(studentID As String) Implements IStudentController.deleteStudent
        Dim da As New dbDataSetTableAdapters.studentTableTableAdapter
        '   MsgBox(studentID)
        da.DeleteQueryStudentID(studentID)
    End Sub

    Public Sub promoteStudent(student As student_) Implements IStudentController.promoteStudent
        If Not stdController.ifStudentExist(
            student.sessionID,
            student.stdID,
            student.surname,
            student.otherNames) Then

            ''update because a student can only be in a class once.
            ''But can have multiple score records for different classes and section.
            ''once we call the unique student ID, it should give all the scores for the student.
            Me.updateStudent(student)
        End If
    End Sub

    Public Sub promoteStudentAndScores(student As student_, subjects As List(Of Subject)) Implements IStudentController.promoteStudentAndScores
        promoteStudent(student)
        scoreController_.promoteScore(
        student,
        subjects
        )
    End Sub

    Public Sub updateStudent(student As student_) Implements IStudentController.updateStudent
        Dim da As dbDataSetTableAdapters.studentTableTableAdapter = New dbDataSetTableAdapters.studentTableTableAdapter
        da.Update(
                  "", 'grno
                  student.surname, 'surname
                  student.otherNames, 'othernames
                  student.DOB, 'dob
                  "",'gender
                  "", 'address
                  "", 'term of admission
                  "", 'year of admission
                  "", 'guadian name
                  student.section, 'section
                  student.classOfAdmission, 'class of admission
                  "", 'previous school attended
                  "", 'student phone
                  "", 'studnet email
                  "", 'nationality
                  "", 'disability
                  "", 'note
                  "", 'religion
                  student.status,
                  "", 'state od origin
                  "", 'lga
                  1, 'entrannce score
                  student.passportPath, 'passport path
                  student.sessionID, 'sessionID
                  student.stdClassID, 'classID
                  student.stdID 'where stdID = ?
                )
    End Sub

    Public Function getAllStudents() As List(Of student_) Implements IStudentController.getAllStudents
        Dim studentList As List(Of student_) = New List(Of student_)
        Dim dataset As dbDataSet = New dbDataSet()
        Dim studentTable As dbDataSet.studentTableDataTable = dataset.studentTable
        Dim dataAdapter As dbDataSetTableAdapters.studentTableTableAdapter = New dbDataSetTableAdapters.studentTableTableAdapter

        dataAdapter.Fill(studentTable)
        studentList.Clear()

        For Each row As dbDataSet.studentTableRow In studentTable.Rows
            studentList.Add(New student_(row))
        Next

        Return studentList.OrderBy(Function(x) x.ID).ToList
    End Function

    Public ReadOnly Property GetAllStudentsByClassID(classID As String) As List(Of student_) Implements IStudentController.GetAllStudentsByClassID
        Get
            Return getAllStudents.Where(Function(x) String.Compare(x.stdClassID, classID, StringComparison.Ordinal) = 0).ToList
        End Get
    End Property

    Public Function getStudent(studentID As String) As student_ Implements IStudentController.getStudent
        Return getAllStudents.FirstOrDefault(
        Function(x) x.stdID = studentID
        )
    End Function


    Public Function getStudentsSessionIDClassID(SessionID As String, classID As String) As List(Of student_) Implements IStudentController.getStudentsSessionIDClassID
        Dim students_ As IEnumerable = (
        From students In getAllStudents()
        Where students.sessionID = SessionID And students.stdClassID = classID)
        Return students_.Cast(Of student_).ToList
    End Function

    Public Function ifStudentExist(sessionID As String, stdID As String, surname As String, othernames As String) As Boolean Implements IStudentController.ifStudentExist
        Return getStudentsSessionID(sessionID).Exists(Function(x) x.stdID = stdID Or (x.surname.Contains(surname) And x.otherNames.Contains(othernames)))
    End Function

    Public Function getStudentsSessionID(sessionID As String) As List(Of student_) Implements IStudentController.getStudentsSessionID
        Dim students As IEnumerable = (
        From students_ In getAllStudents()
        Where students_.sessionID = sessionID)
        Return students.Cast(Of student_).ToList
    End Function
End Class
