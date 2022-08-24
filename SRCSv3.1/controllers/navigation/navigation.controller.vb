Imports SRCSv3._1
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports System.Collections

Public Class NavigationController

    Implements INavigationController

    Private classController As StdClassController = New StdClassController
    Private subjectController As SubjectController = New SubjectController

#Region " events"
#End Region

    Public Function sessionFromNavSelection() As SessionSettings Implements INavigationController.sessionFromNavSelection
        Throw New NotImplementedException()
    End Function

    Public Function subjectFromNavSelection(navigation As Navigation) As Subject Implements INavigationController.subjectFromNavSelection
        Return subjectController.getSubjects(
        navigation.academicSession,
        navigation.term
        ).FirstOrDefault(Function(x) x.subjectName = navigation.subjectName)
    End Function

    Public Function classFromNavSelection(navigation As Navigation) As StdClass Implements INavigationController.classFromNavSelection
        Return classController.getListOfAllClasses(
        navigation.academicSession,
        navigation.term
        ).FirstOrDefault(Function(x) x.stdClass = navigation.studentClass)
    End Function


    Public Function subjectsFromNavSelection(nav As Navigation) As List(Of Subject) Implements INavigationController.subjectsFromNavSelection
        Dim subjects As IEnumerable = (
        From subjs In subjectController.getSubjects(nav.academicSession, nav.term)
        Where subjs.stdClass = nav.studentClass
        Select subjs).Distinct
        Return subjects.Cast(Of Subject).ToList
    End Function

    Public Function createTileItem(itemName As String) As TileBarItem Implements INavigationController.createTileItem
        Dim tile As New TileBarItem
        Dim tileItemElement As New TileItemElement
        tileItemElement.Text = itemName ' "Form Teacher: " + _class.FormTeacher
        tile.Name = itemName
        tileItemElement.TextAlignment = TileItemContentAlignment.MiddleCenter
        tileItemElement.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        tileItemElement.Appearance.Normal.Font = New Font("Segoe UI Light", 11, FontStyle.Bold)
        tile.Elements.Add(tileItemElement)
        tile.TextAlignment = TileItemContentAlignment.MiddleCenter
        Return tile
    End Function
End Class
