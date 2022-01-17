Partial Class _Set
    Partial Public Class PingerDataTable
        Private Sub PingerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IPColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class PortDataTable
        Private Sub PortDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LportColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class ProxyDataTable

        Private Sub ProxyDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ProxyaddColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class OptionsDataTable
        Private Sub OptionsDataTable_OptionsRowChanging(sender As Object, e As OptionsRowChangeEvent) Handles Me.OptionsRowChanging

        End Sub

        Private Sub OptionsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PingColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
