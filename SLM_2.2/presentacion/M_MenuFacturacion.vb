Public Class M_MenuFacturacion
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        M_Factura.limpiar()
        M_BuscarFactura.ShowDialog()
    End Sub
    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        M_BuscarCotizacion.ShowDialog()
    End Sub
    Private Sub btnSede_Click(sender As Object, e As EventArgs) Handles btnSede.Click
        M_Sede.ShowDialog()
    End Sub
    Private Sub btnTerminoPago_Click(sender As Object, e As EventArgs) Handles btnTerminoPago.Click
        M_TerminosPago.ShowDialog()
    End Sub
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        M_Cliente.ShowDialog()
    End Sub
    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        M_Sucursal.ShowDialog()
    End Sub
End Class