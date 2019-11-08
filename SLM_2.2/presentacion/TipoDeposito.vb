Public Class frmTipoDeposito
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'Cerrar ventana TipoDeposito.
        Me.Close()
    End Sub
    Private Sub btnTarjeta_Click(sender As Object, e As EventArgs) Handles btnTarjeta.Click
        'Cerrar ventana Tipo Deposito.
        Me.Close()
        'Abrir ventana Deposito Tarjeta.
        frmDeposito.Show()
        'Cambio de variable Tipo de Deposito.
        frmDeposito.lblTipoDeposito.Text = "Tarjeta"
    End Sub
    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        'Cerrar ventana TipoDeposito.
        Me.Close()
        'Abrir ventana Deposito Bancario.
        frmDeposito.Show()
        'Cambio de variable Tipo de Deposito.
        frmDeposito.lblTipoDeposito.Text = "Deposito Bancario"
    End Sub
End Class