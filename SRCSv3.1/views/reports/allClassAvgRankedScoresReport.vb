Imports DevExpress.XtraReports.UI
Public Class allClassAvgRankedScoresReport
    Public Sub New(schoolSettings As SchoolSettings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        XrNameOfSchool.Text = schoolSettings.schName
        XrSchAddress.Text = schoolSettings.schAddress

    End Sub


    Private counter As Integer = 0
    Private Sub XrTableCell16_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
        'While counter < Me.DisplayableRowCount 
        counter += 1
        CType(sender, XRTableCell).Text = String.Format("{0}", counter)
        ' End While
    End Sub
End Class