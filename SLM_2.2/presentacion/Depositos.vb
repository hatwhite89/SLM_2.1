Public Class frmDeposito

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ListarDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDepositosToolStripMenuItem.Click
        frmAsientos.Show()
    End Sub

    Private Sub txtComision_TextChanged(sender As Object, e As EventArgs) Handles txtComision.TextChanged


    End Sub

    Private Sub frmDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarDepositos.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class