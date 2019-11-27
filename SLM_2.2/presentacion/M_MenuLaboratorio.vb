Public Class M_MenuLaboratorio
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs)
        M_Factura.limpiar()
        M_BuscarFactura.ShowDialog()
    End Sub
    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs)
        M_BuscarCotizacion.ShowDialog()
    End Sub
    Private Sub btnmedico_Click(sender As Object, e As EventArgs) Handles btnmedico.Click
        M_Medico.ShowDialog()
    End Sub
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        M_Cliente.ShowDialog()
    End Sub
    Private Sub btnSede_Click(sender As Object, e As EventArgs)
        M_Sede.ShowDialog()
    End Sub
    Private Sub btnTerminoPago_Click(sender As Object, e As EventArgs)
        M_TerminosPago.ShowDialog()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub M_MenuLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class