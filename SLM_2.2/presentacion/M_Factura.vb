Public Class M_Factura
    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        M_BuscarCliente.ShowDialog()
    End Sub

    Private Sub btncrearCliente_Click(sender As Object, e As EventArgs) Handles btncrearCliente.Click
        M_CrearCliente.ShowDialog()
    End Sub
End Class