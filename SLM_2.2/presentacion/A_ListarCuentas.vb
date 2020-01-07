Public Class A_ListarCuentas


    Dim cuentas As New ClsCuenta
    Private Sub A_ListarCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar cuentas en DataGrid
        dtCuentas.DataSource = cuentas.listarCuentasNombre()

    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Dim Dato As New DataView

        Try
            'Actualizar datos en datagrid con textbox
            cuentas.Nombr_e = txtBusqueda.Text

            Dato = cuentas.buscarCtaXNombre.DefaultView
            dtCuentas.DataSource = Dato
        Catch ex As Exception
            'MessageBox.Show("El código es incorrecto o el campo está vacio.")
        End Try

    End Sub
    Private Sub dtCuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellDoubleClick
        'Seleccionar campo cuenta para formulario forma pago

        If lblForm.Text = "facturaCompra" Then

            Dim cuenta, nombre As String

            cuenta = dtCuentas.Rows(e.RowIndex).Cells(0).Value
            nombre = dtCuentas.Rows(e.RowIndex).Cells(1).Value

            'Asignar busqueda en Datagrid
            'A_FacturaCompras.dtDetalleFactura.Rows.Remove(A_FacturaCompras.dtDetalleFactura.Rows(e.RowIndex.ToString))
            A_FacturaCompras.dtDetalleFactura.Rows.Add(New String() {cuenta, " ", " ", nombre})

        Else

            frmFormaPago.txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(0).Value

        End If

        'Cerrar forma al seleccionar
        Me.Close()

    End Sub
End Class