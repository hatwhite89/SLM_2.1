Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba Cambio
    End Sub

    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click
        'Abrir formulario menu contabilidad.
        frmMenuConta.Show()
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs)
        M_BuscarFactura.ShowDialog()
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs)
        M_BuscarCotizacion.ShowDialog()
    End Sub

    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click
        M_MenuLaboratorio.ShowDialog()
    End Sub
End Class
