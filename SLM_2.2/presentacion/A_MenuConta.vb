Public Class frmMenuConta
    Private Sub btnDepoBanc_Click(sender As Object, e As EventArgs) Handles btnDepoBanc.Click
        'Abrir formulario Depositos

        frmTipoDeposito.Show()

    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        frmPagos.Show()
    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        frmFormaPago.Show()
    End Sub

    Private Sub frmMenuConta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        A_Cuenta.Show()
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoriaProveedor.Click

        A_CategoriaProveedor.Show()

    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        A_Proveedor.Show()
    End Sub


End Class