Public Class YTCSNavView
 
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        YTCSNavViewProperty = Me
    End Sub


    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileControl1.ItemClick
        nav.subjectName = e.Item.Name
        addScoreViewProperty.ScoreTableTableAdapter.FillByYearTermStdClassSubject(
        addScoreViewProperty.DbDataSet.scoreTable,
        nav.academicSession,
        nav.term,
        nav.studentClass,
        e.Item.Name
        )
        '   MsgBox("hi there")
    End Sub
End Class
