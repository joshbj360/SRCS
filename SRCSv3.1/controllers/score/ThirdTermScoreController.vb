Imports SRCSv3._1

Public Class ThirdTermScoreController
    Implements IThirdTermController

    Private listOfAvgScores_ As New List(Of Double)
    Public ReadOnly Property AllThirdTermScores As List(Of Score) Implements IThirdTermController.AllThirdTermScores
        Get
            Dim scoreList As List(Of Score) = New List(Of Score)
            Dim dataset As dbDataSet = New dbDataSet()
            Dim scoreTable As dbDataSet.thirdTermScoreTableDataTable = dataset.thirdTermScoreTable
            Dim dataAdapter As dbDataSetTableAdapters.thirdTermScoreTableTableAdapter = New dbDataSetTableAdapters.thirdTermScoreTableTableAdapter

            dataAdapter.Fill(scoreTable)
            scoreList.Clear()

            For Each row As dbDataSet.thirdTermScoreTableRow In scoreTable.Rows
                scoreList.Add(New Score(row, String.Empty))
            Next

            Return scoreList
        End Get
    End Property

    Public Sub addThirdTermScore(firstTermTotalScore As Integer, secondTermTotalScore As Integer, thirdTermScore As Score) Implements IThirdTermController.addThirdTermScore
        Dim da As New dbDataSetTableAdapters.thirdTermScoreTableTableAdapter
        If Not ThirdTermScoreExist(thirdTermScore) Then
            '' MsgBox(False.ToString)
            da.Insert(
                thirdTermScore.subjectID,
                subjectController_.getSubjectBySubjectID(thirdTermScore.sessionID, thirdTermScore.subjectID).subjectName,
                thirdTermScore.classID,
                classController.GetClassByClassID(thirdTermScore.classID).stdClass,
                secondTermTotalScore,
                thirdTermScore.firstAss,
                thirdTermScore.secondAss,
                thirdTermScore.firstCA,
                thirdTermScore.secondCA,
                thirdTermScore.exam,
                thirdTermScore.totalScore,
                thirdTermScore.gradeRemarks,
                thirdTermScore.sessionID,
                thirdTermScore.stdID,
                firstTermTotalScore,
                thirdTermScore.subjectPosition,
                thirdTermScore.classPosition
                )
        Else
            '' MsgBox(True.ToString)
            updateThirdTermScore(firstTermTotalScore, secondTermTotalScore, thirdTermScore)
        End If
    End Sub

    Public Sub updateThirdTermScore(firstTermTotalScore As Integer, secondTermTotalScore As Integer, thirdTermScore As Score) Implements IThirdTermController.updateThirdTermScore
        If thirdTermScore Is Nothing Then
            Return
        End If

        Dim da As New dbDataSetTableAdapters.thirdTermScoreTableTableAdapter
        da.Update(
         subjectController_.getSubjectBySubjectID(thirdTermScore.sessionID, thirdTermScore.subjectID).subjectName,
          classController.GetClassByClassID(thirdTermScore.classID).stdClass,
           secondTermTotalScore,
            thirdTermScore.firstAss,
            thirdTermScore.secondAss,
            thirdTermScore.firstCA,
            thirdTermScore.secondCA,
            thirdTermScore.exam,
            thirdTermScore.totalScore,
            thirdTermScore.gradeRemarks,
            firstTermTotalScore,
            thirdTermScore.subjectPosition,
            thirdTermScore.classPosition,
            thirdTermScore.subjectID,
            thirdTermScore.classID,
            thirdTermScore.sessionID,
            thirdTermScore.stdID
         )
    End Sub

    Public Function ThirdTermScoreExist(score As Score) As Boolean Implements IThirdTermController.ThirdTermScoreExist
        Return AllThirdTermScores.Exists(
            Function(x) x.stdID = score.stdID _
            And x.sessionID = score.sessionID _
            And x.classID = score.classID _
            And x.subjectID = score.subjectID
        )
    End Function

    Public Function GetThirdTermScoresBySCSubjectID(sessionID As String, classID As String, subjectID As String) As List(Of Score) Implements IThirdTermController.GetThirdTermScoresBySCSubjectID
        Return AllThirdTermScores.Where(Function(x) x.sessionID = sessionID And x.classID = classID And x.subjectID = subjectID).ToList
    End Function

#Region "Class Ranking"

    Public Sub ThirdTermRankClassPosition(sessionID As String, classID As String) Implements IThirdTermController.ThirdTermRankClassPosition
        Dim dict_ As New Dictionary(Of String, Integer)
        Dim da As New dbDataSetTableAdapters.thirdTermScoreTableTableAdapter

        ' sort the list of avg scores.
        Dim sortedList = From entry In listOfAvgScores_ Order By entry Descending Select entry

        For Each std In getThirdTermTotalAvg(sessionID, classID)
            dict_.Add(std.Key, (sortedList.ToList.IndexOf(std.Value) + 1))
        Next

        For Each score In dict_
            da.uClassPositionBySCStd(wordedPosition(score.Value.ToString), sessionID, classID, score.Key)
        Next
        ''e530-thinkpad
    End Sub

    Public Function getThirdTermTotalAvg(sessionID As String, classID As String) As Dictionary(Of String, Double)
        Dim dict As New Dictionary(Of String, Double)

        Dim avgScores = AllThirdTermScores.Where(Function(x) x.sessionID = sessionID And x.classID = classID).AsQueryable().GroupBy(
            Function(x) x.stdID,
            Function(ID, scores) New With {
                .key = ID,
                .average = scores.Average(Function(x) x.totalScore)
            }
        )
        listOfAvgScores_.Clear()

        For Each std In avgScores
            dict.Add(std.key, std.average)
            listOfAvgScores_.Add(std.average)
            ''sb.Append(String.Format("{0} {1}", std.key, std.average) + vbCrLf)
        Next
        Return dict
    End Function


#End Region
#Region "Subject Ranking"

    Dim grandTotalScores As List(Of Integer) = New List(Of Integer)
    Public Sub ThirdTermRankSubjectPosition(sessionID As String, classID As String, subjectID As String) Implements IThirdTermController.ThirdTermRankSubjectPosition
        Dim dict1 As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim da As New dbDataSetTableAdapters.thirdTermScoreTableTableAdapter
        grandTotalScores.Clear()

        For Each std In GetThirdTermScoresBySCSubjectID(sessionID, classID, subjectID)
            dict1.Add(std.stdID, CInt(std.totalScore))
            grandTotalScores.Add(CInt(std.totalScore))
        Next

        Dim sortedList = From score In grandTotalScores Order By score Descending Select score

        Dim dict As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

        For Each score In dict1
            dict.Add(score.Key, sortedList.ToList.IndexOf(score.Value) + 1)
        Next

        For Each score In dict
            da.uSubjectPositionBySCSubjectIDStdID(wordedPosition(score.Value.ToString), sessionID, classID, subjectID, score.Key)
        Next
    End Sub

#End Region
End Class
