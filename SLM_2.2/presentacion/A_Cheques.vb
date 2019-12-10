Public Class A_Cheques
    'Objeto Cheques
    Dim cheque As New ClsCheques

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click









    End Sub

    Private Sub txtcodProvee_DoubleClick(sender As Object, e As EventArgs) Handles txtcodProvee.DoubleClick
        A_ListarProveedores.ShowDialog()

    End Sub

    Private Sub lblEstado_TextChanged(sender As Object, e As EventArgs) Handles lblEstado.TextChanged

        If lblEstado.Text = "Habilitado" Then

            rbtnChequera.Checked = True

        ElseIf lblEstado.Text = "Emitido" Then

            rbtnEmitido.Checked = True

        ElseIf lblEstado.Text = "Acreditado" Then

            rbtnAcreditado.Checked = True

        ElseIf lblEstado.Text = "Cancelado" Then

            rbtnCancelado.Checked = True

        ElseIf lblEstado.Text = "Rechazado" Then

            rbtnAcreditado.Checked = True

        End If

    End Sub
End Class