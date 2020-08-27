Public Class A_Candidatos
    Private Sub A_Candidatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Sub limpiar()

        txtNombre.Clear()
        txtContacto.Clear()
        txtDescripcion.Clear()
        txtProfesion.Clear()
        txtArea.Clear()
        txtCargo.Clear()
        dtpFecha.Value = Date.Now

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False

    End Sub
End Class