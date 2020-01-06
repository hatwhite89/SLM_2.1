Public Class A_ListarCategoriasProveedor
    'Objeto Categoria
    Dim Cate As New ClsCategoriaProveedor
    Private Sub A_ListarCategoriasProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Categorias
        dtCategorias.DataSource = Cate.listarNombreDescripCategoriasProveedor()

    End Sub

    Private Sub dtCategorias_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtCategorias.CellMouseDoubleClick

        Dim temp As Integer = Me.dtCategorias.Rows(e.RowIndex).Cells(2).Value().ToString
        A_Proveedor.cbxCategoria.SelectedIndex = temp - 1

        Me.Close()

    End Sub
End Class