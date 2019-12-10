Public Class A_ListarProveedores
    'Objeto Proveedor
    Dim proveedor As New ClsProveedor
    Private Sub A_ListarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar data en datagrid
        dtProveedor.DataSource = proveedor.listarProveedores

    End Sub

    Private Sub dtProveedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtProveedor.CellDoubleClick

        'Cargar informacion de proveedor

        A_Cheques.txtcodProvee.Text = dtProveedor.Rows(e.RowIndex).Cells(1).Value 'Codigo Proveedor
        A_Cheques.txtNombreProvee.Text = dtProveedor.Rows(e.RowIndex).Cells(4).Value 'Nombre de proveedor
        A_Cheques.txtTributario.Text = dtProveedor.Rows(e.RowIndex).Cells(3).Value 'Id tributario
        Me.Close()

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        'Busqueda de Proveedor

        Dim Dato As New DataView

        'Actualizar datos en datagrid con textbox
        proveedor.Nombre_Proveedor = txtBusqueda.Text
        Dato = proveedor.buscarProveedor.DefaultView
        dtProveedor.DataSource = Dato

    End Sub
End Class