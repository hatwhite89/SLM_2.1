﻿Public Class M_CrearCliente
    Private Sub btncrearCliente_Click(sender As Object, e As EventArgs) Handles btncrearCliente.Click
        If (mtxtid.MaskCompleted = True And txtnombre.Text <> "" And txttelefono.Text <> "" And txtcorreo.Text <> "" And cbxestadoCivil.Text <> "" And cbxtipo.Text <> "" And rtxtdireccion.Text <> "") Then


            Me.Close()
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

    Private Sub M_CrearCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class