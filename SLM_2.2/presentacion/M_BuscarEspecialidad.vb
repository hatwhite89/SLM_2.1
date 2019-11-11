Public Class M_BuscarEspecialidad

    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        M_CrearEspecialidad.ShowDialog()
    End Sub
End Class