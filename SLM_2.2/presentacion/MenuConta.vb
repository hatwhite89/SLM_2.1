Public Class frmMenuConta
    Private Sub btnDepoBanc_Click(sender As Object, e As EventArgs) Handles btnDepoBanc.Click
        'Abrir formulario Depositos

        frmTipoDeposito.Show()

    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        frmPagos.Show()
    End Sub
End Class