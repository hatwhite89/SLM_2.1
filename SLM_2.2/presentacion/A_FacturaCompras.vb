Public Class A_FacturaCompras
    'Objetos de Clase
    Dim FacCompra As New ClsFacturaCompra
    Dim DetalleFacCompra As New ClsDetalleFacturaCompra
    Dim codigoDetalleFacturaCompra As New ArrayList
    Private Sub A_FacturaCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Presionar ESC para cerrar ventana
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim codigoFacturaCompra As String
        Dim n As String = MsgBox("¿Desea guardar la Factura de Compra?", MsgBoxStyle.YesNo, "Validación")
        If n = vbYes Then

            If txtCodProveedor.Text <> "" And txtTerminoPago.Text <> "" And txtTotal.Text <> "" And txtTotal.Text = lblTotal.Text Then

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
                        .Cod_TerminoPago = Convert.ToInt32(lblCodTerminoPago.Text)
                        .Tota_l = txtTotal.Text
                        .Descripcion_ = txtDescripcion.Text
                        .Estado_ = "Ingresada"
                        .Nro_Factura = txtNroFactura.Text
                        .Pendiente_ = txtTotal.Text

                    End With

                    'Registro de detalle de factura
                    If dtDetalleFactura.Rows.Count > 1 Then 'if detalle de factura

                        Dim fila As Integer
                        'Registro de factura en BD
                        'MsgBox("antes de guardar factura")
                        codigoFacturaCompra = FacCompra.registrarNuevaFacturaCompra()

                        ' MsgBox("codigo: " + codigoFacturaCompra)
                        For fila = 0 To dtDetalleFactura.Rows.Count - 2
                            'MsgBox(fila)
                            If (A_Promociones.validarDetalle(dtDetalleFactura.Rows(fila).Cells(1).Value)) = 0 Then

                                'Insertar detalle de compra
                                DetalleFacCompra.Cod_Factura = Convert.ToInt32(codigoFacturaCompra)
                                DetalleFacCompra.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(fila).Cells(1).Value())
                                DetalleFacCompra.Are_a = dtDetalleFactura.Rows(fila).Cells(2).Value
                                DetalleFacCompra.Sed_e = dtDetalleFactura.Rows(fila).Cells(3).Value
                                DetalleFacCompra.Descripcio_n = dtDetalleFactura.Rows(fila).Cells(4).Value()
                                DetalleFacCompra.Mont_o = Convert.ToDouble((dtDetalleFactura.Rows(fila).Cells(5).Value()))

                                'Funcion de registro de detalle
                                DetalleFacCompra.registrarDetalleFactura()

                            Else
                                MsgBox("Error. El código esta duplicado.")
                            End If

                        Next


                    Else ' else detalle de factura
                        MsgBox("Falta detalle de Factura. No se guardo la factura")

                    End If ' if detalle de factura

                    ':::::::::::::::ASIENTO CONTABLE DE FACTURA DE COMPRA

                    Dim asiento As New ClsAsientoContable
                    Dim detalleasiento As New ClsDetalleAsiento
                    Dim periodocontable As New ClsPeriodoContable
                    Dim proveedor As New ClsProveedor
                    Dim codigoAsiento As String

                    'Capturando periodo contable
                    Dim codPeriodo As String

                    Dim dtp As New DataTable
                    Dim rowp As DataRow
                    dtp = periodocontable.periodoContableActivo()
                    rowp = dtp.Rows(0)
                    codPeriodo = rowp("codPeriodo").ToString

                    'capturando cuenta de proveedor
                    Dim dtpro As New DataTable
                    Dim rowpro As DataRow

                    proveedor.Cod_Proveedor = Integer.Parse(txtCodProveedor.Text)
                    dtpro = proveedor.cuentaProveedor()
                    rowpro = dtpro.rows(0)
                    'MsgBox("El proveedor:" + rowpro("codCuenta"))
                    'Insertando Asiento

                    With asiento

                        .Cod_Periodo = Convert.ToInt32(codPeriodo)
                        .Descrip = txtDescripcion.Text
                        .Fecha_ = dtpFechaFactura.Value
                        .Campo_Llave = 0
                        .Estado_ = 0
                        .Origen_ = "FacturaCompra"
                        codigoAsiento = .registrarAsiento
                    End With

                    With detalleasiento
                        .Cod_Asiento = Convert.ToInt32(codigoAsiento)
                        .Cuenta_ = rowpro("cuenta")
                        .Debe_ = 0
                        .Haber_ = Convert.ToDouble(txtTotal.Text)
                        .Origen_ = "FacturaCompra"
                        .registrarDetalleAsiento()

                    End With


                    For i = 0 To dtDetalleFactura.Rows.Count - 1
                        With detalleasiento
                            .Cod_Asiento = Convert.ToInt32(codigoAsiento)
                            .Cuenta_ = dtDetalleFactura.Rows(i).Cells(1).Value
                            .Debe_ = Convert.ToDouble(dtDetalleFactura.Rows(i).Cells(5).Value)
                            .Haber_ = 0
                            .Origen_ = "FacturaCompra"
                            .registrarDetalleAsiento()

                        End With

                    Next

                    ':::::::::::::::::FIN ASIENTO CONTABLE



                    MessageBox.Show("La factura se registro exitosamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al guardar la factura de compra. Detalles: " + ex.Message)
                End Try

                Limpiar()

                Me.Close()
                A_ListadoFacturaCompra.Show()

            Else 'if campos vacios

                MsgBox("Existen campos vacíos o hubo un error.")

                If txtCodProveedor.Text = "" Then
                    txtCodProveedor.BackColor = Color.Red
                    txtNombreProveedor.BackColor = Color.Red
                ElseIf txtTerminoPago.Text = "" Then
                    txtTerminoPago.BackColor = Color.Red
                ElseIf txtTotal.Text = "" Then
                    txtTotal.BackColor = Color.Red
                ElseIf txtMoneda.Text = "" Then
                    txtMoneda.BackColor = Color.Red
                ElseIf txtTotal.Text <> lblTotal.Text Then
                    MsgBox("Los totales no coinciden.Revise el detalle de Factura de Compra.")
                    txtTotal.BackColor = Color.Yellow
                    lblTotal.BackColor = Color.Yellow
                End If

            End If 'if campos vacios
        End If 'desea guardar

    End Sub

    Private Sub btnBuscarTerminoPago_Click(sender As Object, e As EventArgs) Handles btnBuscarTerminoPago.Click
        'Abrir busqueda de termino de pago
        A_ListarTerminoPago.ShowDialog()
    End Sub

    Public Function validarDetalle(ByVal codigo As Integer)
        For index As Integer = 0 To dtDetalleFactura.Rows.Count - 2
            If (dtDetalleFactura.Rows(index).Cells(1).Value().ToString = codigo) Then
                Return 1
            End If
        Next
        Return 0
    End Function

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
                    txtNombreProveedor.BackColor = Color.White
                Catch ex As Exception
                    MessageBox.Show("El proveedor no existe o hubo un error." + ex.Message)
                End Try

            Else

                txtNombreProveedor.Text = ""

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        txtCodProveedor.BackColor = Color.White

    End Sub

    Private Sub dtDetalleFactura_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtDetalleFactura.CellMouseDoubleClick
        'Abrir formulario con doble click en celda Objetos

        'Capturar numero de fila seleccionada
        lblFila.Text = e.RowIndex


        'Listar objetos en Datagrid
        If e.ColumnIndex = 2 Then

            A_ListarObjetos.Show()
            A_ListarObjetos.lblForm.Text = "area"

        ElseIf e.ColumnIndex = 3 Then

            A_ListarObjetos.Show()
            A_ListarObjetos.lblForm.Text = "sede"

        ElseIf e.ColumnIndex = 1 Then

            A_ListarCuentas.Show()
            A_ListarCuentas.lblForm.Text = "facturaCompra"

        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        A_ListadoFacturaCompra.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim n As String = MsgBox("¿Desea modificar la Factura de Compra?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then


                'Registrar nueva factura de compra
                With FacCompra
                    'MsgBox("Variables")
                    'variables
                    .Cod_Factura = txtCodFactura.Text
                    .Cod_Proveedor = txtCodProveedor.Text
                    .Nombre_Proveedor = txtNombreProveedor.Text
                    .Fecha_Factura = dtpFechaFactura.Value
                    .Fecha_Transaccion = dtpTransaccion.Value
                    .Fecha_Vencimiento = dtpVencimiento.Value
                    .Moned_a = txtMoneda.Text
                    .Cod_TerminoPago = Convert.ToInt32(lblCodTerminoPago.Text)
                    .Tota_l = txtTotal.Text
                    .Descripcion_ = txtDescripcion.Text
                    .Estado_ = lblEstado.Text
                    .Pendiente_ = lblSaldoPend.Text
                    .Nro_Factura = txtNroFactura.Text

                    If .modificarFacturaCompra() = 1 Then

                        'registro o actualizacion detalle de factura

                        For fila As Integer = 0 To dtDetalleFactura.Rows.Count - 2
                            If dtDetalleFactura.Rows(fila).Cells(0).Value() = 0 Then
                                'agrega

                                With DetalleFacCompra

                                    DetalleFacCompra.Cod_Factura = Convert.ToInt32(txtCodFactura.Text)
                                    DetalleFacCompra.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(fila).Cells(1).Value())
                                    DetalleFacCompra.Descripcio_n = dtDetalleFactura.Rows(fila).Cells(4).Value()
                                    DetalleFacCompra.Mont_o = Convert.ToDouble((dtDetalleFactura.Rows(fila).Cells(5).Value()))
                                    DetalleFacCompra.Are_a = dtDetalleFactura.Rows(fila).Cells(2).Value()
                                    DetalleFacCompra.Sed_e = dtDetalleFactura.Rows(fila).Cells(3).Value()
                                End With

                                If DetalleFacCompra.registrarDetalleFactura() = 0 Then
                                    MsgBox("Error al querer insertar el detalle de factura.", MsgBoxStyle.Critical)
                                End If
                                MsgBox("fin agrega")
                            Else
                                'actualiza los detalles de factura

                                With DetalleFacCompra

                                    DetalleFacCompra.Cod = Integer.Parse(dtDetalleFactura.Rows(fila).Cells(0).Value())
                                    DetalleFacCompra.Cod_Factura = Convert.ToInt32(txtCodFactura.Text)
                                    DetalleFacCompra.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(fila).Cells(1).Value())
                                    DetalleFacCompra.Descripcio_n = dtDetalleFactura.Rows(fila).Cells(4).Value()
                                    DetalleFacCompra.Mont_o = Convert.ToDouble((dtDetalleFactura.Rows(fila).Cells(5).Value()))
                                    DetalleFacCompra.Are_a = dtDetalleFactura.Rows(fila).Cells(2).Value()
                                    DetalleFacCompra.Sed_e = dtDetalleFactura.Rows(fila).Cells(3).Value()
                                End With

                                If DetalleFacCompra.modificarDetalleFactura() = 0 Then
                                    MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                                End If

                            End If
                        Next

                        For index As Integer = 0 To codigoDetalleFacturaCompra.Count - 1
                            DetalleFacCompra.Cod = Convert.ToInt64(codigoDetalleFacturaCompra(index))
                            If DetalleFacCompra.EliminarDetalleFacturaCompra() <> 1 Then
                                MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                            End If
                        Next

                        codigoDetalleFacturaCompra.Clear()

                        MessageBox.Show("La factura se modifico exitosamente.")

                        Limpiar()
                    End If
                End With

                'Cerrar Formulario de creacion de facturas
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar la factura de compra. Detalles: " + ex.Message)
        End Try

        Me.Close()
        A_ListadoFacturaCompra.ShowDialog()

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Limpiar()
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        'Dim Nueva As New A_FacturaCompras
        'Nueva.Show()
        'Me.Close()

    End Sub

    Private Sub A_FacturaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            'colores datagrid
            alternarColoFilasDatagridview(dtDetalleFactura)

            'bloquear si fue pagada
            If lblEstado.Text = "Pagada" Then
                btnModificar.Enabled = False
                btnGuardar.Enabled = False
            End If


            'Cargar termino de pago
            Dim terminopago As New ClsTerminoPago
            Dim dt As New DataTable
            Dim row As DataRow
            If txtCodFactura.Text <> "" Then

                terminopago.codigo_ = Convert.ToInt32(lblCodTerminoPago.Text)
                dt = terminopago.listarBusquedaTerminoPago
                row = dt.Rows(0)
                txtTerminoPago.Text = row("descripcion")

            End If

            If dtDetalleFactura.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtDetalleFactura.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub A_FacturaCompras_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'frmMenuConta.Show()
    End Sub

    Private Sub txtCodProveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtCodProveedor.MouseDoubleClick

        'Listado de Proveedores para seleccionar
        With A_ListarProveedores

            .Show()
            .lblForm.Text = "facturaCompra"

        End With

    End Sub

    Private Sub txtNroFactura_TextChanged(sender As Object, e As EventArgs) Handles txtNroFactura.TextChanged
        With txtNroFactura
            .BackColor = Color.White
        End With
    End Sub

    Private Sub txtTerminoPago_TextChanged(sender As Object, e As EventArgs) Handles txtTerminoPago.TextChanged
        txtTerminoPago.BackColor = Color.White

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        txtTotal.BackColor = Color.White
    End Sub

    Private Sub txtMoneda_TextChanged(sender As Object, e As EventArgs) Handles txtMoneda.TextChanged
        txtMoneda.BackColor = Color.White
    End Sub

    Private Sub txtNroFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFactura.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProveedor.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtDetalleFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleFactura.CellEndEdit


        If e.ColumnIndex = 1 Then


            Try

                Dim cuenta As New ClsCuenta
                Dim data As DataTable
                Dim rows As DataRow

                cuenta.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(e.RowIndex).Cells(1).Value)

                data = cuenta.Comprobar
                rows = data.Rows(0)

                dtDetalleFactura.Rows.Remove(dtDetalleFactura.Rows(e.RowIndex.ToString))
                dtDetalleFactura.Rows.Insert(e.RowIndex.ToString, New String() {"0", cuenta.Cuent_a, "", "", rows("nombre"), ""})

            Catch ex As Exception

                Try
                    dtDetalleFactura.Rows.Remove(dtDetalleFactura.Rows(e.RowIndex.ToString))
                Catch ex2 As Exception

                End Try

            End Try

        ElseIf e.ColumnIndex = 5 Then

            Dim Total As Double
            Dim Col As Integer = 5
            For Each row As DataGridViewRow In dtDetalleFactura.Rows
                Total += Convert.ToDouble(row.Cells(Col).Value)
            Next
            lblTotal.Text = Total

            txtTotal.BackColor = Color.White
            lblTotal.BackColor = Color.Transparent

        End If

    End Sub

    Private Sub dtDetalleFactura_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtDetalleFactura.CellMouseClick

        If e.ColumnIndex = 2 Then

            Try

                Dim cuenta As New ClsCuenta
                Dim data As DataTable
                Dim rows As DataRow

                cuenta.Cuent_a = Convert.ToInt32(dtDetalleFactura.Rows(e.RowIndex).Cells(1).Value)

                data = cuenta.Comprobar
                rows = data.Rows(0)

                dtDetalleFactura.Rows.Remove(dtDetalleFactura.Rows(e.RowIndex.ToString))
                dtDetalleFactura.Rows.Insert(e.RowIndex.ToString, New String() {"0", cuenta.Cuent_a, "", "", rows("nombre")})

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub dtDetalleFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleFactura.CellClick
        If e.ColumnIndex = 6 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar la cuenta de la factura?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then

                    If dtDetalleFactura.Rows(e.RowIndex).Cells(0).Value() <> "0" Then

                        codigoDetalleFacturaCompra.Add(Me.dtDetalleFactura.Rows(e.RowIndex).Cells(0).Value())

                    End If

                    dtDetalleFactura.Rows.Remove(dtDetalleFactura.Rows(e.RowIndex.ToString))

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Sub Limpiar()
        txtCodFactura.Clear()
        txtNroFactura.Clear()
        txtCodProveedor.Clear()
        txtNombreProveedor.Clear()
        txtTerminoPago.Clear()
        txtTotal.Clear()
        txtMoneda.Text = "Lps"
        lblEstado.Text = "---"
        txtDescripcion.Clear()
        dtpFechaFactura.ResetText()
        dtpTransaccion.ResetText()
        dtpVencimiento.ResetText()

        dtDetalleFactura.Rows.Clear()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

End Class