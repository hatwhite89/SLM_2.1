Public Class frmMenuConta
    Private Sub btnDepoBanc_Click(sender As Object, e As EventArgs)
        'Abrir formulario Depositos

        Me.Hide()
    End Sub
    Private Sub btnPagos_Click(sender As Object, e As EventArgs)

        Me.Hide()
    End Sub
    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs)
        frmFormaPago.Show()
        Me.Hide()
    End Sub
    Private Sub frmMenuConta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        A_Cuenta.Show()
        Me.Hide()
    End Sub
    Private Sub btnCategoria_Click(sender As Object, e As EventArgs)
        A_CategoriaProveedor.Show()
        Me.Hide()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs)
        A_Proveedor.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        A_Bancos.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        A_Chequera.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        A_ListadoFacturaCompra.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        A_ListadoCheques.Show()
        Me.Hide()
    End Sub

    Private Sub frmMenuConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class