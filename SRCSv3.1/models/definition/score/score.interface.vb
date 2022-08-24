
Public Interface IScore
    Property sessionID As String
    Property stdID As String
    Property subjectID As String
    Property studentFullName As String
    Property classID As String
    Property firstAss As Integer
    Property secondAss As Integer
    Property firstCA As Integer
    Property secondCA As Integer
    Property exam As Integer
    Property totalScore As Integer
    Property gradeRemarks As String
    Property subjectPosition As String
    Property classPosition As String

End Interface

Interface IThirdTermController
    Sub ThirdTermRankClassPosition(sessionID As String, classID As String)
    ''third term cumulative

    ReadOnly Property AllThirdTermScores As List(Of Score)
    Function GetThirdTermScoresBySCSubjectID(sessionID As String, classID As String, subjectID As String) As List(Of Score)
    Sub AddThirdTermScore(firstTermTotalScore As Integer, secondTermTotalScore As Integer, thirdTermScore As Score)
    Sub UpdateThirdTermScore(firstTermTotalScore As Integer, secondTermTotalScore As Integer, thirdTermScore As Score)
    Function ThirdTermScoreExist(score As Score) As Boolean
    Sub ThirdTermRankSubjectPosition(sessionID As String, classID As String, subjectID As String)
End Interface
Interface IScoreControllers

    'getters
    Function getRankedScores(sessionID As String, classID As String) As List(Of Score)
    Sub rankClassPosition(sessionID As String, classID As String)


    Sub rankSubjectPositon(sessionID As String, classID As String, subjectID As String)
    Function getAllScores() As List(Of Score)
    ReadOnly Property GetScoresByClassID(classID As String) As List(Of Score)
    Function getScoresBySessionID(sessionID As String) As List(Of Score)
    Function getScoresBySessionIDClassID(sessionID As String, classID As String) As List(Of Score)
    Function getScoresBySessionIDClassIDSubjectID(sessionID As String, classID As String, subjectID As String) As List(Of Score)
    Function getStudentSubjectTotalScore(stdID As String, subjectID As String, classID As String, SessionID As String) As Integer
    'check if score details exist. (i.e name, class, subject, section year, term)
    Function ScoreExist(score As Score) As Boolean



    'setters
    'delete scores from db by 'year and term and class or subject'
    Sub deleteScoreFromSubject(sessionID As String, classID As String, subjectID As String, stdID As String)
    Sub deleteScoreFromAllSubjects(sessionID As String, classID As String, studentID As String)
    Sub addScore(ByVal score As Score, Optional editValues As Boolean = False)
    Sub addScores(ByVal scores As List(Of Score))
    'move scores to new term
    Sub promoteScores(students As List(Of student_), subjects As List(Of Subject))

    Sub promoteClassScores(OldclassID As String, NewClassID As String, NewSessionID As String)
    'move score to new term
    Sub promoteScore(student As student_, subjects As List(Of Subject))
    Sub updateSubjectID(score As Score)
    Sub updateStudentFullName(score As Score)
    Sub updateScoreValues(score As Score)



End Interface
