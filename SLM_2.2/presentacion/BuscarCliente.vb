Public Class BuscarCliente
    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        If (mtxtidCliente.MaskCompleted = True) Then
            'gbxinformacion.Visible = True
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

    Private Sub btncrearCliente_Click(sender As Object, e As EventArgs)
        If (mtxtid.MaskCompleted = True And txtnombre.Text <> "" And txttelefono.Text <> "" And txtcorreo.Text <> "" And rtxtdireccion.Text <> "") Then
            mtxtidCliente.Text = ""
            'gbxinformacion.Visible = False
            Me.Close()
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

End Class