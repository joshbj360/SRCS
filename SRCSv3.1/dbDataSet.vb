

Partial Public Class dbDataSet
    Partial Public Class thirdTermScoreTableDataTable
        Private Sub thirdTermScoreTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.t2Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class reportSettingsDataTable
        Private Sub reportSettingsDataTable_reportSettingsRowChanging(sender As Object, e As reportSettingsRowChangeEvent) Handles Me.reportSettingsRowChanging

        End Sub

    End Class

    Partial Public Class subjectTableDataTable
        Private Sub subjectTableDataTable_subjectTableRowChanging(sender As Object, e As subjectTableRowChangeEvent) Handles Me.subjectTableRowChanging

        End Sub

    End Class
End Class

Namespace dbDataSetTableAdapters

    Partial Public Class thirdTermScoreTableTableAdapter
    End Class
End Namespace
