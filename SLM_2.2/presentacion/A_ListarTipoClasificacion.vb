Public Class A_ListarTipoClasificacion
    Dim Clasific As New ClsTipoClasificacion
    Private Sub A_ListarTipoClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtTipoClasific)
        'Listar en datagrid
        dtTipoClasific.DataSource = Clasific.SeleccionarTipoClasificacion

    End Sub

    Private Sub dtTipoClasific_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtTipoClasific.CellMouseDoubleClick

        'Mostrar en A_CategoriaProveedor la clasificacion seleccionada
        A_CategoriaProveedor.txtClasifica.Text = dtTipoClasific.Rows(e.RowIndex).Cells(0).Value
        Me.Close()


    End Sub


End Class