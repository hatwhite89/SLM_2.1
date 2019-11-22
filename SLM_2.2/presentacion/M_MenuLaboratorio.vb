Public Class M_MenuLaboratorio
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        M_BuscarFactura.ShowDialog()
    End Sub
    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        M_BuscarCotizacion.ShowDialog()
    End Sub

    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click


    End Sub
End Class