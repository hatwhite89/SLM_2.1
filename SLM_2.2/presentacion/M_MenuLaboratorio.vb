﻿Public Class M_MenuLaboratorio
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        M_ListarClientes.ShowDialog()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnMedico_Click_1(sender As Object, e As EventArgs) Handles btnMedico.Click
        M_Medico.ShowDialog()
    End Sub
    Private Sub btnExamenes_Click(sender As Object, e As EventArgs) Handles btnExamenes.Click
        E_DetalleExamenes.ShowDialog()
    End Sub

    Private Sub btnSede_Click(sender As Object, e As EventArgs) Handles btnSede.Click
        M_Sede.ShowDialog()
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        M_Sucursal.ShowDialog()
    End Sub
End Class