Public Class Factura
    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        BuscarCliente.ShowDialog()
    End Sub

    Private Sub btncrearCliente_Click(sender As Object, e As EventArgs) Handles btncrearCliente.Click
        CrearCliente.ShowDialog()
    End Sub
End Class