﻿Public Class frmMenuConta
    Private Sub btnDepoBanc_Click(sender As Object, e As EventArgs) Handles btnDepoBanc.Click
        'Abrir formulario Depositos

        frmTipoDeposito.Show()
        Me.Hide()

    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        A_ListarPagos.Show()
        Me.Hide()
    End Sub
    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        frmFormaPago.Show()
        Me.Hide()
    End Sub
    Private Sub frmMenuConta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        A_Cuenta.Show()
        Me.Hide()
    End Sub
    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoriaProveedor.Click

        A_CategoriaProveedor.Show()
        Me.Hide()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        A_Proveedor.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBancos.Click
        A_Bancos.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A_Chequera.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        A_ListadoFacturaCompra.Show()
        Me.Hide()
    End Sub
End Class