Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba Cambio
    End Sub

    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click
        'Abrir formulario menu contabilidad.
        frmMenuConta.Show()
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        M_Factura2.Show()
    End Sub
End Class
