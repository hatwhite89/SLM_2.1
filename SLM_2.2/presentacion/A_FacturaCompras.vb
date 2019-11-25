Public Class A_FacturaCompras

    Dim FacCompra As New ClsFacturaCompra
    Private Sub A_FacturaCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            'Registrar nueva factura de compra
            With FacCompra

                'variables
                .Cod_Proveedor = txtCodProveedor.Text
                .Nombre_Proveedor = txtNombreProveedor.Text
                .Fecha_Factura = dtpFechaFactura.Value
                .Fecha_Transaccion = dtpTransaccion.Value
                .Fecha_Vencimiento = dtpVencimiento.Value
                .Moned_a = txtMoneda.Text
                .Terminos_Pago = txtTerminoPago.Text
                .Tota_l = txtTotal.Text
                'registro de  factura compra
                .registrarNuevaFacturaCompra()
                MessageBox.Show("La factura se registro exitosamente.")

            End With

            'Cerrar Formulario de creacion de facturas
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar el registro." + ex.Message)
        End Try

        Me.Close()
        A_ListadoFacturaCompra.Show()

    End Sub

    Private Sub btnBuscarTerminoPago_Click(sender As Object, e As EventArgs) Handles btnBuscarTerminoPago.Click
        A_ListarTerminoPago.Show()
    End Sub

    Private Sub dtDetalleFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleFactura.CellEndEdit

        Dim Cuenta As New ClsCuenta

        With Cuenta

            .Cuent_a = dtDetalleFactura.Rows(e.RowIndex).Cells(0).Value()

        End With

        Dim dt As New DataTable
        dt = Cuenta.BuscarCuenta

        Dim row As DataRow = dt.Rows(0)

        Dim nombre As String
        nombre = row("nombre")

        dtDetalleFactura.Rows.Remove(dtDetalleFactura.Rows(e.RowIndex.ToString))

        dtDetalleFactura.Rows.Insert(e.RowIndex.ToString, New String() {Cuenta.Cuent_a, " ", nombre})




    End Sub

    Private Sub dtDetalleFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleFactura.CellClick

        'Listar objetos en Datagrid
        If e.ColumnIndex = 1 Then

            A_ListarObjetos.Show()

        End If



    End Sub


End Class