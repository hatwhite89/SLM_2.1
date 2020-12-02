Public Class frmTipoDeposito
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs)
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
        Limpiar()
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
        Limpiar()

    End Sub

    Private Sub frmTipoDeposito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar tecla ESC para cerrar formulario.
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Sub Limpiar()
        'Limpia todos los campos del formulario Deposito
        frmDeposito.txtNro.Text = ""
        frmDeposito.dtpFecha.ResetText()
        frmDeposito.txtBanco.Text = ""
        frmDeposito.txtContado.Text = ""
        frmDeposito.txtTipoConta.Text = ""
        frmDeposito.txtTotalDep.Text = ""
        frmDeposito.txtMoneda.Text = "Lps"
        frmDeposito.txtMonBase.Text = "1"
        frmDeposito.txtComision.Text = ""
        frmDeposito.txtCajero.Text = ""
        frmDeposito.txtComentario.Text = ""

    End Sub

    Private Sub frmTipoDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class