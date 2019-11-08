Public Class frmDeposito

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ListarDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDepositosToolStripMenuItem.Click
        frmAsientos.Show()
    End Sub

    Private Sub txtComision_TextChanged(sender As Object, e As EventArgs) Handles txtComision.TextChanged

        'Calculo de comisiones
        If txtFormaPago.Text = "" Then

            txtComision.Text = txtContado.Text * 2.95 'Comision Banpais

        ElseIf txtFormaPago.Text = "" Then

            txtComision.Text = txtContado.Text * 2.6 'Comision Ficohsa

        ElseIf txtFormaPago.Text = "" Then

            txtComision.Text = txtContado.Text * 3.15 'Comision BAC

        End If 'Final if comisiones
    End Sub

    Private Sub frmDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarDepositos.Show()
    End Sub
End Class