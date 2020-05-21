Public Class E_frmProveedorOC
    Dim clsProve As New ClsProveedor
    Dim dvProveedor As DataView = clsProve.listarProveedoresOC.DefaultView
    Public Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim f As New E_frmOrdenCompra




        nombre_proveedorOC = DataGridView1.Rows(e.RowIndex).Cells(3).Value


    End Sub

    Public Sub E_frmProveedorOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clsProve As New ClsProveedor

        Dim dvProveedor As DataView = clsProve.listarProveedoresOC.DefaultView
        DataGridView1.DataSource = dvProveedor
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dvProveedor.RowFilter = String.Format("CONVERT(nombreProveedor, System.String) LIKE '%{0}%'", TextBox1.Text)
        DataGridView1.DataSource = dvProveedor
    End Sub
End Class