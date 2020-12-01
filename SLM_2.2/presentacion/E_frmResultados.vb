Public Class Resultados
    Private Sub E_frmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim clsR As New ClsResultados
            Dim ds As New DataTable
            ds.Load(clsR.RecuperarListadoFacturas(TextBox2.Text))

            BindingSource1.DataSource = ds

            DataGridView1.DataSource = BindingSource1
        Catch ex As Exception

        End Try


    End Sub
End Class