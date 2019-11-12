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
        frmDeposito.txtComision.Visible = True
        frmDeposito.lblComision.Visible = True
        frmDeposito.lblTipoDeposito.Text = "Tarjeta"

        frmDeposito.txtNro.Text = ""
        frmDeposito.dtpFecha.ResetText()
        frmDeposito.txtBanco.Text = ""
        frmDeposito.txtContado.Text = ""
        frmDeposito.txtTipoConta.Text = ""
        frmDeposito.txtTotalDep.Text = ""
        frmDeposito.txtMoneda.Text = "Lps"
        frmDeposito.txtMonBase.Text = ""
        frmDeposito.txtComision.Text = ""
        frmDeposito.txtCajero.Text = ""
        frmDeposito.txtComentario.Text = ""


    End Sub
    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        'Cerrar ventana TipoDeposito.
        Me.Close()
        'Abrir ventana Deposito Bancario.
        frmDeposito.Show()
        'Cambio de variable Tipo de Deposito.
        frmDeposito.txtComision.Visible = False
        frmDeposito.lblComision.Visible = False

        frmDeposito.lblTipoDeposito.Text = "Deposito Bancario"


        frmDeposito.txtNro.Text = ""
        frmDeposito.dtpFecha.ResetText()
        frmDeposito.txtBanco.Text = ""
        frmDeposito.txtContado.Text = ""
        frmDeposito.txtTipoConta.Text = ""
        frmDeposito.txtTotalDep.Text = ""
        frmDeposito.txtMoneda.Text = "Lps"
        frmDeposito.txtMonBase.Text = ""
        frmDeposito.txtComision.Text = ""
        frmDeposito.txtCajero.Text = ""
        frmDeposito.txtComentario.Text = ""
    End Sub
End Class