Imports DevExpress.XtraBars.Navigation
Public Interface IChangeStatus
    Property status As Boolean
    Property message As String
    Property sender As Object

End Interface
Public Interface INavigation
    Property academicSession As String
    Property term As String
    Property studentClass As String
    Property subjectName As String

End Interface
Public Interface INavigationController
    Function createTileItem(itemName As String) As TileBarItem
    Function subjectsFromNavSelection(nav As Navigation) As List(Of Subject)
    Function subjectFromNavSelection(navigation As Navigation) As Subject
    Function classFromNavSelection(navigation As Navigation) As StdClass
    Function sessionFromNavSelection() As SessionSettings
End Interface