Public Class M_BuscarMedico
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtnombre.Text = ""
        Me.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        M_CrearMedico.ShowDialog()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If (txtnombre.Text <> "") Then

        Else
            MsgBox("Debe ingresar el nombre del médico a buscar.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub
End Class