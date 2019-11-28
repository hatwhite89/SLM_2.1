Public Class eg_frmListarSubAreas

    'Objeto SubAreas
    Dim SubA As New ClsSubArea

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        eg_frmSubArea.ShowDialog()

    End Sub

    Private Sub eg_frmListarSubAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar listado de Subareas
        dgbSubAreas.DataSource = SubA.listarSubAreas

    End Sub
End Class