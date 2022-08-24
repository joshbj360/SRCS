Public Class ProgramSelfOnTest
    Public Function CheckNumberOfClasses(sessionID As String) As Integer
        Return classController.GetListOfAllClassNames(sessionID).Count
    End Function

    Public Function CheckForSubjects(classes As List(Of String)) As List(Of Dictionary(Of String, Integer))
        Dim classesList_ As New List(Of Dictionary(Of String, Integer))

        Return classesList_
    End Function
End Class