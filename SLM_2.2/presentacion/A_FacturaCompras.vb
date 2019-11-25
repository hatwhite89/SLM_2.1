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
End Class