Public Class E_ListarSubAreas

    'Objeto SubAreas
    Dim SubA As New ClsSubArea

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        E_SubArea.ShowDialog()

    End Sub

    Private Sub eg_frmListarSubAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar listado de Subareas
        dgbSubAreas.DataSource = SubA.listarSubAreas

    End Sub
End Class