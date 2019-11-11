Public Class M_ClasificacionContacto
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_BuscarTipoClasificacion.ShowDialog()
    End Sub
End Class