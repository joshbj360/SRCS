
Imports SRCSv3._1

Public Class Score
    Implements IScore

    Private firstAss_, secondAss_, firstCA_, secondCA_, exam_, totalScore_, firstTermTotalScore_, secondTermTotalScore_, grandTotal_ As Integer
    Private subjectID_, classID_, sessionID_, fullName_, stdID_, gradeRemarks_, classPosition_, subjectPostion_, className_ As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal score As DataRow)
        stdID_ = String.Format("{0}", score("stdID"))
        subjectID_ = String.Format("{0}", score("subjectID"))
        sessionID_ = String.Format("{0}", score("sessionID"))
        fullName_ = String.Format("{0}", score("studentFullName"))
        classID_ = String.Format("{0}", score("classID"))
        firstAss_ = CInt(score("firstAss"))
        secondAss_ = CInt(score("secondAss"))
        firstCA_ = CInt(score("firstCA"))
        secondCA_ = CInt(score("secondCA"))
        exam_ = CInt(score("exam"))
        totalScore_ = CInt(score("totalScore"))
        gradeRemarks_ = String.Format("{0}", score("gradeRemarks"))
        subjectPostion_ = String.Format("{0}", score("subjectPosition"))
        classPosition_ = String.Format("{0}", score("classPosition"))
    End Sub
#Disable Warning IDE0060 ' Remove unused parameter
    Public Sub New(ByVal score As DataRow, Optional n As String = "")
#Enable Warning IDE0060 ' Remove unused parameter
        stdID_ = String.Format("{0}", score("stdID"))
        subjectID_ = String.Format("{0}", score("subjectID"))
        sessionID_ = String.Format("{0}", score("sessionID"))
        '' fullName_ = String.Format("{0}", score("studentFullName"))
        classID_ = String.Format("{0}", score("classID"))
        className_ = String.Format("{0}", score("className"))
        firstTermTotalScore_ = CInt(score("firstTermTotalScore"))
        secondTermTotalScore_ = CInt(score("secondTermTotalScore"))
        firstAss_ = CInt(score("a1"))
        secondAss_ = CInt(score("a2"))
        firstCA_ = CInt(score("t1"))
        secondCA_ = CInt(score("t2"))
        exam_ = CInt(score("exm"))
        totalScore_ = CInt(score("total"))
        grandTotal_ = CInt(score("grandTotal"))
        gradeRemarks_ = String.Format("{0}", score("grade"))
        subjectPostion_ = String.Format("{0}", score("subjectPosition"))
        classPosition_ = String.Format("{0}", score("classPosition"))
    End Sub
    Public Property classPosition As String Implements IScore.classPosition
        Get
            Return classPosition_
        End Get
        Set(value As String)
            classPosition_ = value
        End Set

    End Property

    Public Property exam As Integer Implements IScore.exam
        Get
            Return exam_
        End Get
        Set(value As Integer)
            exam_ = value
        End Set
    End Property
    Public Property firstAss As Integer Implements IScore.firstAss
        Get
            Return firstAss_
        End Get
        Set(value As Integer)
            firstAss_ = value
        End Set
    End Property

    Public Property firstCA As Integer Implements IScore.firstCA
        Get
            Return firstCA_
        End Get
        Set(value As Integer)
            firstCA_ = value
        End Set
    End Property
    Public Property gradeRemarks As String Implements IScore.gradeRemarks
        Get
            Return gradeRemarks_
        End Get
        Set(value As String)
            gradeRemarks_ = value
        End Set
    End Property

    Public Property totalScore As Integer Implements IScore.totalScore
        Get
            Return totalScore_
        End Get
        Set(value As Integer)
            totalScore_ = value
        End Set
    End Property
    Public Property secondAss As Integer Implements IScore.secondAss
        Get
            Return secondAss_
        End Get
        Set(value As Integer)
            secondAss_ = value
        End Set
    End Property

    Public Property secondCA As Integer Implements IScore.secondCA
        Get
            Return secondCA_
        End Get
        Set(value As Integer)
            secondCA_ = value
        End Set
    End Property

    Public Property subjectPosition As String Implements IScore.subjectPosition
        Get
            Return subjectPostion_
        End Get
        Set(value As String)
            subjectPostion_ = value
        End Set
    End Property

    Public Property sessionID As String Implements IScore.sessionID
        Get
            Return sessionID_
        End Get
        Set(value As String)
            sessionID_ = value
        End Set
    End Property

    Public Property stdID As String Implements IScore.stdID
        Get
            Return stdID_
        End Get
        Set(value As String)
            stdID_ = value
        End Set
    End Property

    Public Property subjectID As String Implements IScore.subjectID
        Get
            Return subjectID_
        End Get
        Set(value As String)
            subjectID_ = value
        End Set
    End Property

    Public Property classID As String Implements IScore.classID
        Get
            Return classID_
        End Get
        Set(value As String)
            classID_ = value
        End Set
    End Property

    Public Property studentFullName As String Implements IScore.studentFullName
        Get
            Return fullName_
        End Get
        Set(value As String)
            fullName_ = value
        End Set
    End Property
End Class
