Public Interface IChangeStatus
    Property status As Boolean
    Property message As String
    Property sender As Object

End Interface
Public Interface IMessageDetails
    Property message As String
    Property caption As String
    Property buttonType As MessageBoxButtons
End Interface