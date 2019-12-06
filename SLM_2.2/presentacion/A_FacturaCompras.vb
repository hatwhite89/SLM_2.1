﻿Public Class A_FacturaCompras
    'Objetos de Clase
    Dim FacCompra As New ClsFacturaCompra
    Dim DetalleFacCompra As New ClsDetalleFacturaCompra
    Private Sub A_FacturaCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Presionar ESC para cerrar ventana
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

                'Registro de detalle de factura
                Dim dt As New DataTable
                'Capturar código de la factura creada
                dt = FacCompra.capturarCodFacturaCompra
                Dim row As DataRow = dt.Rows(0)
                'Mostrar codigo en textbox 
                txtCodFactura.Text = CStr(row("codFactura"))
                Dim fila As Integer

                'Recorrer filas para ingreso de detalle de factura
                For fila = 0 To dtDetalleFactura.Rows.Count - 2

                    'Insertar detalle de compra
                    DetalleFacCompra.Cod_Factura = Convert.ToInt32(txtCodFactura.Text)
                    DetalleFacCompra.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(fila).Cells(0).Value())
                    DetalleFacCompra.Descripcio_n = dtDetalleFactura.Rows(fila).Cells(2).Value()
                    DetalleFacCompra.Mont_o = Convert.ToDouble((dtDetalleFactura.Rows(fila).Cells(3).Value()))
                    Dim stock As String = dtDetalleFactura.Rows(fila).Cells(4).Value()
                    DetalleFacCompra.Tipo_Stock = stock
                    DetalleFacCompra.Objeto_s = dtDetalleFactura.Rows(fila).Cells(1).Value()

                    'Funcion de registro de detalle
                    DetalleFacCompra.registrarDetalleFactura()
                Next

                MessageBox.Show("La factura se registro exitosamente.")

            End With

            'Cerrar Formulario de creacion de facturas
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar la factura de compra. Detalles: " + ex.Message)
        End Try

        Me.Close()
        A_ListadoFacturaCompra.Show()

    End Sub

    Private Sub btnBuscarTerminoPago_Click(sender As Object, e As EventArgs) Handles btnBuscarTerminoPago.Click
        'Abrir busqueda de termino de pago
        A_ListarTerminoPago.ShowDialog()
    End Sub

    Private Sub dtDetalleFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleFactura.CellEndEdit

        Try
            Dim Cuenta As New ClsCuenta
            'Capturar codigo de cuenta
            With Cuenta

                .Cuent_a = dtDetalleFactura.Rows(e.RowIndex).Cells(0).Value()

            End With
            'Capturar informacion de cuenta
            Dim dt As New DataTable
            dt = Cuenta.Comprobar



            If dt.Rows.Count > 0 Then

                Dim row As DataRow = dt.Rows(0)
                Dim nombre As String
                nombre = row("nombre")
                'Asignar busqueda en Datagrid
                dtDetalleFactura.Rows.Remove(dtDetalleFactura.Rows(e.RowIndex.ToString))
                dtDetalleFactura.Rows.Insert(e.RowIndex.ToString, New String() {Cuenta.Cuent_a, " ", nombre})

            Else
                MsgBox("La cuenta no existe.")

            End If

        Catch ex As Exception

        End Try

    End Sub



    Private Sub txtCodProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodProveedor.TextChanged
        'Mostrar nombre de Proveedor ingresado
        Try

            If (txtCodProveedor.Text <> "") Then
                Try
                    Dim Pro As New ClsProveedor
                    With Pro
                        .Cod_Proveedor = Convert.ToInt32(txtCodProveedor.Text)
                    End With


                    Dim dt As New DataTable
                    dt = Pro.capturarNombreProveedor()

                    Dim row As DataRow = dt.Rows(0)
                    txtNombreProveedor.Text = row("nombreProveedor")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dtDetalleFactura_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtDetalleFactura.CellMouseDoubleClick
        'Abrir formulario con doble click en celda Objetos

        'Capturar numero de fila seleccionada
        lblFila.Text = e.RowIndex

        'Listar objetos en Datagrid
        If e.ColumnIndex = 1 Then

            A_ListarObjetos.Show()

        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        A_ListadoFacturaCompra.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            'Registrar nueva factura de compra
            With FacCompra

                'variables
                .Cod_Factura = txtCodFactura.Text
                .Cod_Proveedor = txtCodProveedor.Text
                .Nombre_Proveedor = txtNombreProveedor.Text
                .Fecha_Factura = dtpFechaFactura.Value
                .Fecha_Transaccion = dtpTransaccion.Value
                .Fecha_Vencimiento = dtpVencimiento.Value
                .Moned_a = txtMoneda.Text
                .Terminos_Pago = txtTerminoPago.Text
                .Tota_l = txtTotal.Text
                'registro de  factura compra
                .modificarFacturaCompra()

                'Registro de detalle de factura
                Dim dt As New DataTable
                'Capturar código de la factura creada
                dt = FacCompra.capturarCodFacturaCompra
                Dim row As DataRow = dt.Rows(0)
                'Mostrar codigo en textbox 
                txtCodFactura.Text = CStr(row("codFactura"))
                Dim fila As Integer

                'Recorrer filas para ingreso de detalle de factura
                For fila = 0 To dtDetalleFactura.Rows.Count - 2

                    'Insertar detalle de compra
                    DetalleFacCompra.Cod_Factura = Convert.ToInt32(txtCodFactura.Text)
                    DetalleFacCompra.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(fila).Cells(0).Value())
                    DetalleFacCompra.Descripcio_n = dtDetalleFactura.Rows(fila).Cells(2).Value()
                    DetalleFacCompra.Mont_o = Convert.ToDouble((dtDetalleFactura.Rows(fila).Cells(3).Value()))
                    Dim stock As String = dtDetalleFactura.Rows(fila).Cells(4).Value()
                    DetalleFacCompra.Tipo_Stock = stock
                    DetalleFacCompra.Objeto_s = dtDetalleFactura.Rows(fila).Cells(1).Value()

                    'Funcion de registro de detalle
                    DetalleFacCompra.registrarDetalleFactura()
                Next

                MessageBox.Show("La factura se modifico exitosamente.")

            End With

            'Cerrar Formulario de creacion de facturas
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al guardar la factura de compra. Detalles: " + ex.Message)
        End Try

        Me.Close()
        A_ListadoFacturaCompra.ShowDialog()

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Dim Nueva As New A_FacturaCompras
        Nueva.Show()
        Me.Close()

    End Sub

    Private Sub A_FacturaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmb As New DataGridViewComboBoxColumn()
        dtDetalleFactura.Columns.Add(cmb)
        cmb.HeaderText = "Tipo Stock"
        cmb.Items.Add("Comprado")
        cmb.Items.Add("Consignado")
        cmb.Name = "cbx"

    End Sub

End Class