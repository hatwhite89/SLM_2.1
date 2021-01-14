Public Class M_MenuFacturacion
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        'M_Factura.limpiar()
        M_BuscarFactura.Show()
    End Sub
    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        M_BuscarCotizacion.Show()
    End Sub
    Private Sub btnTerminoPago_Click(sender As Object, e As EventArgs) Handles btnTerminoPago.Click
        M_TerminosPago.Show()
    End Sub
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        M_Cliente.Show()
    End Sub
    Private Sub btnRecibos_Click(sender As Object, e As EventArgs) Handles btnRecibos.Click
        M_BuscarRecibo.Show()
    End Sub
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        E_DetalleExamenes.Show()
    End Sub
    Private Sub btnGrupoExamen_Click(sender As Object, e As EventArgs) Handles btnGrupoExamen.Click
        E_GrupoExamen.Show()
    End Sub
    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        A_Proveedor.Show()
    End Sub

End Class