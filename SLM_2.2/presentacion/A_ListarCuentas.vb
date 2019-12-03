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
        frmFormaPago.txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(0).Value

        'Cerrar forma al seleccionar
        Me.Close()

    End Sub
End Class