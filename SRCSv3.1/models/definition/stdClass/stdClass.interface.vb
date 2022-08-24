Public Structure sSectionType
    Const Creche As String = "Creche"
    Const Nursery As String = "Nursery"
    Const Primary As String = "Primary"
    Const Junior_Secondary As String = "Junior Secondary"
    Const Senior_Secondary_Science As String = "Senior Secondary Science"
    Const Senior_Secondary_Arts As String = "Senior Secondary Arts"
End Structure

Public Interface IStdClass
    Property classID As String
    Property stdClass As String
    Property section As String
    Property formTeacherName As String
    Property sessionID As String
End Interface

Public Interface IStdClassController
    'validate and generate classID
    Function GenerateClassID(sessionID As String, className As String) As String
    'promote a class
    Sub PromoteClass(OldclassID As String, NewClassID As String, NewSessionID As String)
    'add a class
    Sub AddClass(stdClas As StdClass)
    'edit class
    Sub EditClass(class_ As StdClass)
    'delete a class
    Sub DeleteClass(class_ As StdClass)
    'assign a form teacher
    Sub AssignFormTeacher(clasz As StdClass)
    'get form teacher in a class
    'get all female studens
    'get all male students
    'get best 3 performing students
    'get least performance
    'get average performance
    'get subjects that student fail most.
    'get number of students

    'check if class exits
    Function IfClassExist(Optional stdClass As StdClass = Nothing, Optional sessionID As String = "", Optional classId As String = "", Optional className As String = "") As Boolean
    Function GetClassByClassID(classID As String) As StdClass
    ReadOnly Property GetClassBySessionIDClassNAme(sessonID As String, className As String) As StdClass
    Function GetAllClasses() As List(Of StdClass)
    Function GetClassesName(section As String) As List(Of String)
    Function GetListOfAllClassNames(sessionID As String) As List(Of String)
    Function GetListOfAllClassNamesBySessionIDSection(sessionID As String, section As String) As List(Of String)
    Function GetListOfAllClassesBySessionID(sessionID As String) As List(Of StdClass)
    Function GetListOfAllClassesBySessionIDSection(sessionID As String, section As String) As List(Of StdClass)
End Interface
