Public Interface IStudentFullNameAndClass
    Property sessionID As String
    Property fullName As String
    Property stdClass As String
    Property section As String
    Property status As String
    Property stdID As String
End Interface
Public Interface IStudent
    Inherits IStudentFullNameAndClass
    ReadOnly Property ID As Integer
    Property grNo As String
    Property surname As String
    Property otherNames As String
    Property gender As String
    Property DOB As String
    Property classOfAdmission As String
    Property passportPath As String
    Property Passport As Image
End Interface

Public Interface IStudentController
    Sub addStudent(student As student_)
    Sub addStudents(students As List(Of student_))
    Sub updateStudent(student As student_)
    Function getStudent(stdID As String) As student_
    Function ifStudentExist(sessionID As String, stdID As String, surname As String, othernames As String) As Boolean
    Function getAllStudents() As List(Of student_)
    ReadOnly Property GetAllStudentsByClassID(classID As String) As List(Of student_)
    Function getStudentsSessionID(sessionID As String) As List(Of student_)
    Function getStudentsSessionIDClassID(SessionID As String, classID As String) As List(Of student_)

    Sub deleteStudent(studentID As String)
    'moveStudent to a new term
    Sub promoteStudent(student As student_)
    'promote student to a new class
    Sub promoteStudentAndScores(student As student_, subjects As List(Of Subject))
    'get a student performance in term, year, all-through
    'delete a student

End Interface

