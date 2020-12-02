Public Class E_frmAgregarProductoOC
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub E_frmAgregarProductoOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TableUM As New DataTable
        Dim clsP As New ClsProducto
        '  TableUM.Load(clsP.)

        DataGridView1.DataSource = TableUM
    End Sub
End Class