Imports DevExpress.XtraEditors
Imports System.Text

Public Class ScoreController
    Implements IScoreControllers

#Region "Getters"
    Function getAllScores() As List(Of Score) Implements IScoreControllers.getAllScores
        Dim scoreList As List(Of Score) = New List(Of Score)
        Dim dataset As dbDataSet = New dbDataSet()
        Dim scoreTable As dbDataSet.scoreTableDataTable = dataset.scoreTable
        Dim dataAdapter As dbDataSetTableAdapters.scoreTableTableAdapter = New dbDataSetTableAdapters.scoreTableTableAdapter

        dataAdapter.Fill(scoreTable)
        scoreList.Clear()

        For Each row As dbDataSet.scoreTableRow In scoreTable.Rows
            scoreList.Add(New Score(row))
        Next

        Return scoreList
    End Function

    Public ReadOnly Property GetScoresByClassID(classID As String) As List(Of Score) Implements IScoreControllers.GetScoresByClassID
        Get
            Return getAllScores.Where(Function(x) String.Compare(x.classID, classID, StringComparison.Ordinal) = 0).ToList
        End Get
    End Property
    Public Function getScoresBySessionID(sessionID As String) As List(Of Score) Implements IScoreControllers.getScoresBySessionID
        Dim scoreList As List(Of Score) = New List(Of Score)
        Dim dataAdapter As dbDataSetTableAdapters.scoreTableTableAdapter = New dbDataSetTableAdapters.scoreTableTableAdapter

        scoreList.Clear()
        For Each row As dbDataSet.scoreTableRow In dataAdapter.GetDataBySessionID(sessionID).Rows
            scoreList.Add(New Score(row))
        Next

        Return scoreList
    End Function

    Public Function getScoresBySessionIDClassID(sessionID As String, classID As String) As List(Of Score) Implements IScoreControllers.getScoresBySessionIDClassID
        Dim scoreList As New List(Of Score)
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter

        For Each row As dbDataSet.scoreTableRow In da.GetDataBysessionIDClassID(sessionID, classID).Rows
            scoreList.Add(New Score(row))
        Next

        Return scoreList.Distinct.ToList
    End Function

    Public Function getScoresBySessionIDClassIDSubjectID(sessionID As String, classID As String, subjectID As String) As List(Of Score) Implements IScoreControllers.getScoresBySessionIDClassIDSubjectID
        Dim scoreList As List(Of Score) = New List(Of Score)
        Dim dataAdapter As dbDataSetTableAdapters.scoreTableTableAdapter = New dbDataSetTableAdapters.scoreTableTableAdapter

        scoreList.Clear()
        For Each row As dbDataSet.scoreTableRow In dataAdapter.GetDataBySessionIDClassIDSubjectID(sessionID, classID, subjectID).Rows
            scoreList.Add(New Score(row))
        Next

        Return scoreList
    End Function

    Public Function getRankedScores(sessionID As String, classID As String) As List(Of Score) Implements IScoreControllers.getRankedScores
        Dim da As New dbDataSetTableAdapters.scoresReportQueryTableAdapter
        Dim scores As New List(Of Score)
        For Each row As dbDataSet.scoresReportQueryRow In da.GetScoresBySessionIDClassID(sessionID, classID).Rows
            Dim score As New Score With
            {
            .stdID = $"{row("stdID")}",
            .studentFullName = $"{row("surname")} {row("otherNames")}",
            .totalScore = row("totalScore"),
            .classPosition = $"{row("classPosition")}"
            }
            scores.Add(score)
        Next

        Return scores
    End Function


    Public Function getStudentSubjectTotalScore(stdID As String, subjectID As String, classID As String, SessionID As String) As Integer Implements IScoreControllers.getStudentSubjectTotalScore
        Try
            Return scoreController_.getScoresBySessionIDClassIDSubjectID(
                       SessionID,
                       classID,
                       subjectID
                       ).FirstOrDefault(Function(x) String.Compare(x.stdID, stdID, StringComparison.Ordinal) = 0).totalScore
        Catch ex As Exception
            statusController.message += "Score not found for " + stdID
            Return 0
        End Try

    End Function
#End Region

#Region "Setters"
    Public Sub addScore(score As Score, Optional editScoreValues As Boolean = False) Implements IScoreControllers.addScore
        Dim da As dbDataSetTableAdapters.scoreTableTableAdapter = New dbDataSetTableAdapters.scoreTableTableAdapter
        If Not ScoreExist(score) Then
            da.Insert(
            score.stdID,
            score.firstAss,
            score.secondAss,
            score.firstCA,
            score.secondCA,
            score.exam,
            score.totalScore,
            score.gradeRemarks,
            score.subjectPosition,
            score.classPosition,
            score.subjectID,
            score.classID,
            score.sessionID,
            score.studentFullName
    )
            ' Else
            ' update scoreDetails()
            ' look for a more reasonable way to update score-details without editing the score-values
        ElseIf editScoreValues Then
            updateScoreValues(score)
        End If
    End Sub

    Public Sub addScores(scores As List(Of Score)) Implements IScoreControllers.addScores
        For Each score In scores
            addScore(score)
        Next
    End Sub

    Public Sub deleteScoreFromSubject(sessionID As String, classID As String, subjectID As String, stdID As String) Implements IScoreControllers.deleteScoreFromSubject
        Dim da As dbDataSetTableAdapters.scoreTableTableAdapter = New dbDataSetTableAdapters.scoreTableTableAdapter
        da.DeleteBysessionIDClassIDSubjectIDStdID(sessionID, classID, subjectID, stdID)
    End Sub

    ''' <summary>
    ''' If there is no Score in the OldClassID then Exit Sub.
    ''' Query all scores by OldClassID. 
    ''' Add score to the NewSessionID (which checks if it exits, if not creates a new Score). 
    ''' </summary>
    ''' <param name="OldclassID"></param>
    ''' <param name="NewClassID"></param>
    ''' <param name="NewSessionID"></param>
    Public Sub promoteClassScores(OldclassID As String, NewClassID As String, NewSessionID As String) Implements IScoreControllers.promoteClassScores
        If Not GetScoresByClassID(OldclassID).Count < 1 Then
            For Each score In GetScoresByClassID(OldclassID)
                Dim newScore As New Score With {
                    .classID = NewClassID,
                    .sessionID = NewSessionID,
                    .subjectID = score.subjectID,
                    .stdID = score.stdID,
                    .studentFullName = score.studentFullName
                }
                addScore(newScore)
            Next
        Else
            XtraMessageBox.Show("No Score was found for " + classController.GetClassByClassID(OldclassID).sessionID)
            Exit Sub
        End If

    End Sub


    Public Sub promoteScores(
                            students As List(Of student_),
                            subjects As List(Of Subject)
                            ) Implements IScoreControllers.promoteScores
        For Each student In students
            promoteScore(
            student,
            subjects
            )
        Next
    End Sub

    Public Sub promoteScore(student As student_, subjects As List(Of Subject)) Implements IScoreControllers.promoteScore
        If Not subjects.Count < 1 Then
            For Each subject In subjects
                Dim score As New Score With {
                    .stdID = student.stdID,
                    .studentFullName = student.fullName,
                    .sessionID = student.sessionID,
                    .classID = student.stdClassID,
                    .subjectID = subject.subjectID
                }
                'MsgBox(subject.subjectID)

                addScore(score)
                '' subjectController_.addSubject(newSubject)
            Next
        Else
            XtraMessageBox.Show("No subject for the specified SessionID.")
            Exit Sub
        End If
    End Sub

    Public Function ScoreExist(score As Score) As Boolean Implements IScoreControllers.ScoreExist
        Return getAllScores.Exists(
            Function(x) x.stdID = score.stdID _
            And x.sessionID = score.sessionID _
            And x.classID = score.classID _
            And x.subjectID = score.subjectID
        )
    End Function


    Public Sub updateSubjectID(score As Score) Implements IScoreControllers.updateSubjectID
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter
        da.uSubjectIDBySCStid(
        score.subjectID,
        score.stdID,
        score.sessionID,
        score.classID
        )
    End Sub


    Public Sub updateScoreValues(score As Score) Implements IScoreControllers.updateScoreValues
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter
        da.Update(
        score.firstAss,
        score.secondAss,
        score.firstCA,
        score.secondCA,
        score.exam,
        score.totalScore,
        score.gradeRemarks,
        score.subjectPosition,
        score.classPosition,
        score.sessionID,
        score.classID,
        score.subjectID,
        score.stdID)
    End Sub

    Public Sub updateStudentFullName(score As Score) Implements IScoreControllers.updateStudentFullName
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter
        da.uStudentFullNameBySCSubjectIDStdID(
        score.studentFullName,
        score.sessionID,
        score.classID,
        score.stdID
        )
    End Sub

#End Region

#Region "Class Rank"
    Private listOfAvgScores_ As New List(Of Double)
    Private sb As New StringBuilder
    Public Function getTotalAvg(sessionID As String, classID As String) As Dictionary(Of String, Double)
        Dim dict As New Dictionary(Of String, Double)

        Dim avgScores = getScoresBySessionIDClassID(sessionID, classID).AsQueryable().GroupBy(
            Function(x) x.stdID, Function(ID, scores) New With {
                .key = ID,
                .average = scores.Average(Function(x) x.totalScore)
            }
        )
        listOfAvgScores_.Clear()

        For Each std In avgScores
            dict.Add(std.key, std.average)
            listOfAvgScores_.Add(std.average)
            sb.Append(String.Format("{0} {1}", std.key, std.average) + vbCrLf)
        Next
        Return dict
    End Function

    Public Sub rankClassPosition(sessionID As String, classID As String) Implements IScoreControllers.rankClassPosition
        Dim dict_ As New Dictionary(Of String, Integer)
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter
        ' sort the list of avg scores.
        Dim sortedList = From entry In listOfAvgScores_ Order By entry Descending Select entry

        For Each std In getTotalAvg(sessionID, classID)
            dict_.Add(std.Key, (sortedList.ToList.IndexOf(std.Value) + 1))
        Next

        For Each score In dict_
            da.uClassPositionBySCStd(wordedPosition(score.Value.ToString), sessionID, classID, score.Key)
        Next

    End Sub

#End Region

#Region "Subject Rank"
    Private totalScores As List(Of Integer) = New List(Of Integer)



    Public Sub rankSubjectPositon(sessionID As String, classID As String, subjectID As String) Implements IScoreControllers.rankSubjectPositon
        Dim dict1 As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter
        totalScores.Clear()

        For Each std In getScoresBySessionIDClassIDSubjectID(sessionID, classID, subjectID)
            dict1.Add(std.stdID, CInt(std.totalScore))
            totalScores.Add(CInt(std.totalScore))
        Next

        Dim sortedList = From score In totalScores Order By score Descending Select score

        Dim dict As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        For Each score In dict1
            dict.Add(score.Key, sortedList.ToList.IndexOf(score.Value) + 1)
        Next

        For Each score In dict
            da.uSubjectPositionBySCSubjectID(wordedPosition(score.Value.ToString), sessionID, classID, subjectID, score.Key)
        Next
    End Sub

    Public Sub deleteScoreFromAllSubjects(sessionID As String, classID As String, studentID As String) Implements IScoreControllers.deleteScoreFromAllSubjects
        Dim da As New dbDataSetTableAdapters.scoreTableTableAdapter
        da.DeleteBySessionIDClassIDStdID(sessionID, classID, studentID)
    End Sub

#End Region
End Class
