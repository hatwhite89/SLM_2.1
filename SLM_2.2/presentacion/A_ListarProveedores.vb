Public Class A_ListarProveedores
    'Objeto Proveedor
    Dim proveedor As New ClsProveedor
    Private Sub A_ListarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar data en datagrid
        dtProveedor.DataSource = proveedor.listarProveedores



    End Sub

    Private Sub dtProveedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtProveedor.CellDoubleClick

        Dim dt As DataTable = dtProveedor.DataSource
        Dim row As DataRow = dt.Rows(e.RowIndex)

        Try
            'Cargar informacion de proveedor
            If lblForm.Text = "facturaCompra" Then

                A_FacturaCompras.txtCodProveedor.Text = row("codProveedor")

            Else

                A_Cheques.txtcodProvee.Text = row("codBreve") 'Codigo Proveedor
                A_Cheques.txtNombreProvee.Text = row("nombreProveedor")  'Nombre de proveedor

            End If

            Me.Close()
        Catch ex As Exception
            MsgBox("No se ha seleccionado una opción.")
        End Try



    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        'Busqueda de Proveedor
        Try

            Dim Dato As New DataView

            'Actualizar datos en datagrid con textbox
            proveedor.Nombre_Proveedor = txtBusqueda.Text
            Dato = proveedor.buscarProveedor.DefaultView
            dtProveedor.DataSource = Dato

        Catch ex As Exception

        End Try

    End Sub
End Class