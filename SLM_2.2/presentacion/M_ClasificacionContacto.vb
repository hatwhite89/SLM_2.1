Public Class M_ClasificacionContacto
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_BuscarTipoClasificacion.ShowDialog()
    End Sub

    Private Sub M_ClasificacionContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellContentClick

    End Sub
End Class