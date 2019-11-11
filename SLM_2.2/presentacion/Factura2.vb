Public Class Factura2
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarMedico_Click(sender As Object, e As EventArgs) Handles btnbuscarMedico.Click
        BuscarMedico.ShowDialog()
    End Sub
End Class