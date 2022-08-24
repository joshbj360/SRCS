Imports System.Globalization
Public Class YTCNavView

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initEditors()

        ' yt.Parent = Me
    End Sub

    Private Sub initEditors()
        cmbSchYear.Text = defaultSessionSettings.academicSession
        cmbTerm.Text = defaultSessionSettings.term
        cmbStdClass.Properties.Items.AddRange(classController.getListOfAllClassNames(cmbSchYear.Text, cmbTerm.Text))
    End Sub
    Private Sub cmbSchYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchYear.SelectedIndexChanged
        nav.academicSession = cmbSchYear.Text

    End Sub

    Private Sub cmbTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTerm.SelectedIndexChanged
        nav.term = cmbTerm.Text

    End Sub

    Private Sub cmbStdClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStdClass.SelectedIndexChanged
        nav.studentClass = cmbStdClass.Text
    End Sub
    Public Event loadItems(sender As Object, e As EventArgs)
    Public Sub loadItemsToTileBar()

        If cmbSchYear.Text <> Nothing And cmbTerm.Text <> Nothing And cmbStdClass.Text <> Nothing Then
            'lblClassDetails.Text = "Section: " + navController.classFromNavSelection(nav).section _
            '                   + "  Class Name: " + navController.classFromNavSelection(nav).stdClass _
            '                   + "  Form Teacher: " + navController.classFromNavSelection(nav).formTeacherName

            YTCSNavViewProperty.TileGroup2.Items.Clear()
            For Each item In navController.subjectsFromNavSelection(nav)
                YTCSNavViewProperty.TileGroup2.Items.Add(navController.createTileItem(item.subjectName))
            Next
        Else
            If cmbSchYear.Text = Nothing Then
                MessageBox.Show("Select Academic Session")
                cmbSchYear.Focus()
                Exit Sub
            End If
            If cmbTerm.Text = Nothing Then
                MessageBox.Show("Select Term")
                cmbTerm.Focus()
                Exit Sub
            End If
            If cmbStdClass.Text = Nothing Then
                MessageBox.Show("Select Class")
                cmbStdClass.Focus()
                Exit Sub
            End If
        End If

    End Sub

    Public Sub load_items(sender As Object, e As EventArgs) Handles Me.loadItems
        loadItemsToTileBar()
    End Sub

End Class
