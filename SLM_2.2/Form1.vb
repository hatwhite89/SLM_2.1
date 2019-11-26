Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba Cambio
    End Sub
    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click
        'Abrir formulario menu contabilidad.
        frmMenuConta.ShowDialog()
    End Sub
    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click
        M_MenuLaboratorio.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        E_DetalleExamenes.Show()
    End Sub

End Class
