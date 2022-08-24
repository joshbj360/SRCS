Public Interface IDefaultSubject
    Property subjectName As String
    Property section As String
    Property stdClass As String
    Property subjectID As String
End Interface
Public Interface ISubject
    Inherits IDefaultSubject
    Property subjectTeacherName As String
    Property sessionID As String
    Property classID As String
End Interface
Public Interface ISubjectControllers
#Region "Default Subject"
    Function generateSubjectID() As String
    Function subjectFromID(subjectID As String) As Subject
    Function ifDefaultSubjectExist(subject As DefaultSubject) As Boolean
    Sub addDefaultSubject(defaultSubject As DefaultSubject)
    Sub updateDefaultSubject(defaultSubject As DefaultSubject)
    Sub addDefaultSubjects(defaultSubjects As List(Of DefaultSubject))
    Sub deleteDefaultSubject(subject As DefaultSubject)
    Function getDefaultSubjects(section As String) As List(Of DefaultSubject)
    Function getDefaultSubjectsNames(section As String) As List(Of String)
    Function getDefaultSubjectsByClass(section As String, className As String) As List(Of DefaultSubject)
#End Region
    Sub addSubject(subject As Subject)
    Sub updateSubject(subject As Subject)
    Sub deleteSubjects(sessionID As String, classID As String)
    Function ifSubjectExist(subject As Subject) As Boolean
    Function getSubjectBySubjectID(SessionID As String, subjectID As String) As Subject
    Function getSubjectBySessionIDClassIDSubjectName(sessionID As String, classID As String, subjectName As String) As Subject
    Function getSubjects(ByVal sessionID As String) As List(Of Subject)
    Function getSubjectsBySection(ByVal section As String) As List(Of Subject)
    Function getSubjectsBySessionIDClassID(sessionID As String, classID As String) As List(Of Subject)
    Function getSubjectsBySessionIDClassIDUserID(sessionID As String, classID As String, UserFullname As String) As List(Of Subject)
End Interface
