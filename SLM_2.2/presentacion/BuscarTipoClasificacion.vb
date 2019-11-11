Public Class BuscarTipoClasificacion
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        CrearTipoClasificacion.ShowDialog()
    End Sub
End Class