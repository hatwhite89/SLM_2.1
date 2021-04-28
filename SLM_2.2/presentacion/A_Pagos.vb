Public Class frmPagos

    Dim formaPago As New ClsFormaPago
    Dim factuCompra As New ClsFacturaCompra
    Dim pagos As New ClsPago
    Dim detallePago As New ClsDetallePago
    Dim codigoDetallePago As New ArrayList

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        'Cerrar Ventana Pagos
        Me.Close()

    End Sub

    Private Sub frmPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Presionar ESC para salida
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            'frmMenuConta.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarFormaPago.Click

        'Mostrar formas de pago
        A_ListarFormasPagoPF.lblForm.Text = "Pagos"
        A_ListarFormasPagoPF.Show()
    End Sub

    Private Sub dtDetallePagos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellEndEdit
        'Bloqueo de Celdas 
        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        'dtDetallePagos.Columns(3).ReadOnly = False

        Try

            If e.ColumnIndex = 3 Then

                lblTotalSuma.Text = 0.0
                For a = 0 To dtDetallePagos.Rows.Count - 1
                    lblTotalSuma.Text = Convert.ToDouble(dtDetallePagos.Rows(a).Cells(3).Value) + Convert.ToDouble(lblTotalSuma.Text)
                Next

            ElseIf e.ColumnIndex = 0 Then

                Dim dt As New DataTable
                With factuCompra
                    .Cod_Factura = dtDetallePagos.Rows(e.RowIndex).Cells(0).Value
                    dt = .comprobarFactura() 'Comprobar existencia de factura compra

                    If dt.Rows.Count > 0 Then 'Si la factura existe, llenar campos

                        Dim row As DataRow = dt.Rows(0)
                        If row("estado") = "Pagada" Then
                            'Si la factura fue pagada, no agregar al pago
                            dtDetallePagos.Rows.Remove(dtDetallePagos.Rows(e.RowIndex.ToString))
                            MsgBox("La factura ya fue pagada, no se agregara al pago.")

                        Else

                            dtDetallePagos.Rows.Remove(dtDetallePagos.Rows(e.RowIndex.ToString))
                            dtDetallePagos.Rows.Insert(e.RowIndex.ToString, New String() {row("codfactura"), row("nombreProveedor"), row("moneda"), row("pendiente"), "", "", "0"})
                            lblCodigoProveedor.Text = row("codProveedor")
                            'Sumar totales de factura
                            lblTotalSuma.Text = dtDetallePagos.Rows(e.RowIndex).Cells(3).Value


                        End If

                    End If

                End With
            ElseIf e.ColumnIndex = 5 Then
                chkPagado.Checked = True
            End If

        Catch ex As Exception
            MsgBox("La factura de compra no existe o hubo un error. Verifique el código.")
        End Try

    End Sub

    Private Sub dtDetallePagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellClick
        'Bloqueo de edicion de celdas
        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        'dtDetallePagos.Columns(3).ReadOnly = True

        If e.ColumnIndex = 7 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar la factura?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    If dtDetallePagos.Rows(e.RowIndex).Cells(6).Value() <> "0" Then

                        codigoDetallePago.Add(Me.dtDetallePagos.Rows(e.RowIndex).Cells(6).Value())

                    End If

                    dtDetallePagos.Rows.Remove(dtDetallePagos.Rows(e.RowIndex.ToString))

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            suma()

        End If

    End Sub

    Private Sub dtDetallePagos_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtDetallePagos.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
    End Sub

    'Solo permitir numeros en celda codigo y nro de cheque

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim Celda As DataGridViewCell = Me.dtDetallePagos.CurrentCell()

        If Celda.ColumnIndex = 0 Or Celda.ColumnIndex = 5 Then
            If e.KeyChar = "."c Then
                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub limpiar() 'Limpiar todos los campos

        txtNro.Text = ""
        txtComentario.Text = ""
        txtCtaBanco.Text = ""
        txtFormaP.Text = ""
        dtpFechaP.ResetText()
        dtpFechaT.ResetText()
        dtDetallePagos.Rows.Clear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If dtDetallePagos.Rows(0).Cells(5).Value <> "" Then
            chkPagado.Checked = True
        End If

        Try
            Dim n As String = MsgBox("¿Desea guardar el pago?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then 'validacion

                'Ingresar un nuevo pago
                If txtFormaP.Text <> "" Then

                    Dim codigoPago As String
                    With pagos

                        'Variables de Pago
                        .codForma_Pago = Convert.ToInt32(lblCodFormaPago.Text)
                        .Comentari_o = txtComentario.Text
                        .Fecha_transfer = dtpFechaT.Value
                        .Fecha_Pago = dtpFechaP.Value
                        .Referenci_a = txtReferencia.Text
                        .Paga_do = chkPagado.Checked
                        .Suma_Total = lblTotalSuma.Text
                        'Ingresar registro en base de datos
                        'MsgBox("antes")
                        codigoPago = .registrarNuevoPago()
                        'MsgBox("despues")
                    End With
                    ' MsgBox(codigoPago)

                    'Ingresar detalle de pago
                    For a = 0 To dtDetallePagos.Rows.Count - 2
                        With detallePago

                            .Cod_Pago = Convert.ToInt32(codigoPago)
                            .Cod_Factura = Convert.ToInt32(dtDetallePagos.Rows(a).Cells(0).Value)

                            If dtDetallePagos.Rows(a).Cells(4).Value = "" Then
                                .Forma_Pago = "-"
                            Else
                                .Forma_Pago = dtDetallePagos.Rows(a).Cells(4).Value.ToString

                            End If

                            If dtDetallePagos.Rows(a).Cells(5).Value = "" Then

                                .Nro_Cheque = "-"

                            Else
                                .Nro_Cheque = dtDetallePagos.Rows(a).Cells(5).Value.ToString

                            End If

                            .Monto_ = Convert.ToDouble(dtDetallePagos.Rows(a).Cells(3).Value.ToString)

                            .registrarDetallePago()

                        End With
                    Next

                    ':::::::::ACTUALIZAR PENDIENTE DE FACTURA DE COMPRA::::::::::::::::
                    Dim codfactura As Integer
                    Dim resultadof, pendiente, montoc As Double
                    Dim factura As New ClsFacturaCompra
                    Dim dtP As New DataTable
                    Dim rowf As DataRow
                    'MsgBox("Se crearon variables")

                    codfactura = dtDetallePagos.Rows(0).Cells(0).Value
                    'MsgBox("Se capturo codigo de fact")

                    factura.Cod_Factura = Convert.ToInt32(codfactura)
                    dtP = factura.comprobarFactura
                    rowf = dtP.Rows(0)
                    'MsgBox("Busco la factura")

                    montoc = Convert.ToDouble(lblTotalSuma.Text)
                    pendiente = Convert.ToDouble(rowf("pendiente"))
                    resultadof = pendiente - montoc
                    'MsgBox("Ya resto " + resultadof.ToString)

                    factura.Cod_Factura = Convert.ToInt32(codfactura)
                    factura.Pendiente_ = Convert.ToDouble(resultadof)

                    'cambio de estado
                    If resultadof = 0 Then
                        factura.Estado_ = "Pagada"
                    Else
                        factura.Estado_ = "Pendiente"
                    End If

                    factura.SaldoPendiente()
                    ' MsgBox("Ya actualizo")


                    '.........................................................

                    MsgBox("Se registro un nuevo pago.")

                End If 'ingresar nuevo pago

            End If 'validacion
            limpiar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtDetallePagos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellDoubleClick

        If e.ColumnIndex = 4 Then

            'Columna de Forma de Pago
            A_ListarFormasPagoPF.lblForm.Text = "DetallePagoFormaPagos"
            lblFila.Text = e.RowIndex
            A_ListarFormasPagoPF.Show()


        ElseIf e.ColumnIndex = 5 Then
            Dim data As String = dtDetallePagos.Rows(e.RowIndex).Cells(5).Value
            'MsgBox("data" = data)

            Try
                If data <> "False" Then
                    'Columna de Cheques

                    lblFila.Text = e.RowIndex
                    A_ListarChequesHabilitados.Show()

                    '
                    'Else

                    '    Try
                    '        Dim nroCheque As Integer
                    '        Dim cheque As New ClsCheques
                    '        Dim dt As New DataTable
                    '        Dim row As DataRow
                    '        nroCheque = Convert.ToInt32(dtDetallePagos.Rows(e.RowIndex).Cells(5).Value.ToString)

                    '        cheque.Cod_Cheque = nroCheque

                    '        dt = cheque.BuscarChequeXCodigo()

                    '        If dt.Rows.Count = 0 Then
                    '            MsgBox("El numero pertenece a un pago por transferencia.")
                    '        Else
                    '            row = dt.Rows(0)

                    '            'llenar campos de formulario con data de cheque
                    '            With A_Cheques

                    '                .txtNro.Text = row("codCheque")
                    '                .txtNroCheq.Text = row("nroCheque")
                    '                .txtMonto.Text = row("monto")
                    '                .dtpFechaReg.Value = row("fechaReg")
                    '                .dtpFechaVto.Value = row("fechaVto")
                    '                .txtMoneda.Text = row("moneda")
                    '                .lblEstado.Text = row("estado")
                    '                .txtcodProvee.Text = row("codBreveProveedor")
                    '                .txtNombreProvee.Text = row("nombreProveedor")
                    '                .txtBanco.Text = row("codBreveBanco")
                    '                '.txtNroCtaBanco.Text = row2("nroCtaBanco")
                    '                .txtnombreBanco.Text = row("nombreBanco")
                    '                .dtpAcredita.Value = row("fechaacreditacion")
                    '                .dtpRechazo.Value = row("fechaRechazo")
                    '                .dtpEmision.Value = row("fechaEmision")
                    '                .dtpCancelado.Value = row("fechaCancelado")
                    '                .txtCtaOrigen.Text = row("ctaOrigen")
                    '                .txtCtaDestino.Text = row("ctaDestino")
                    '                .txtCtaTemporal.Text = row("ctaTemporal")
                    '                .lblForm.Text = "ChequeSeleccionado"
                    '                .Show()

                    '            End With
                    '        End If

                    '    Catch ex As Exception
                    '        MsgBox("aqui perrin" + ex.Message)
                    '    End Try





                End If

            Catch ex As Exception
                MsgBox("aqui es" + ex.Message)
            End Try

        ElseIf e.ColumnIndex = 0 Then

                A_ListarFacCompraPagos.Show()
            lblFila.Text = e.RowIndex

        End If

    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dtDetallePagos)
            If txtNro.Text <> "" Then

                btnModificar.Enabled = True
                btnCrear.Enabled = True
                btnGuardar.Enabled = False

            End If

            'bloquear datos si pago ya fue realizado
            If chkPagado.Checked = True Then

                dtDetallePagos.Columns(0).ReadOnly = True
                dtDetallePagos.Columns(1).ReadOnly = True
                dtDetallePagos.Columns(2).ReadOnly = True
                'dtDetallePagos.Columns(3).ReadOnly = True
                dtDetallePagos.Columns(4).ReadOnly = True

                btnModificar.Enabled = False
                btnCrear.Enabled = False
                btnGuardar.Enabled = False

            End If

            'habilitar boton para eliminar fila
            If dtDetallePagos.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtDetallePagos.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If

            suma()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub dtDetallePagos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dtDetallePagos.RowsAdded

        suma()

    End Sub

    Private Sub txtFormaP_TextChanged(sender As Object, e As EventArgs) Handles txtFormaP.TextChanged
        If txtFormaP.BackColor = Color.Red Then
            txtFormaP.BackColor = Color.White
        End If
    End Sub

    Sub suma()
        Dim Total2 As Double
        Dim Col2 As Integer = 3
        For Each row As DataGridViewRow In dtDetallePagos.Rows
            Total2 += Convert.ToDouble(row.Cells(Col2).Value)
        Next
        lblTotalSuma.Text = Total2
    End Sub

    Public Function validarFacturaPago(ByVal codigo As Integer)
        For index As Integer = 0 To dtDetallePagos.Rows.Count - 2
            If (dtDetallePagos.Rows(index).Cells(0).Value().ToString = codigo) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        A_ListarPagos.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            Dim n As String = MsgBox("¿Desea modificar el pago?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then 'validacion


                'actualizar datos de pago
                With pagos

                    'Variables de Pago
                    .Cod_Pago = Integer.Parse(txtNro.Text)
                    .codForma_Pago = Convert.ToInt32(lblCodFormaPago.Text)
                    .Comentari_o = txtComentario.Text
                    .Fecha_transfer = dtpFechaT.Value
                    .Fecha_Pago = dtpFechaP.Value
                    .Referenci_a = txtReferencia.Text
                    .Paga_do = chkPagado.Checked
                    .Suma_Total = lblTotalSuma.Text

                    'realizar modificacion y comprobacion de guardado para modificar detalle
                    If .modificarPago = 1 Then


                        'modificar detalle de pago
                        For i As Integer = 0 To dtDetallePagos.Rows.Count - 2
                            If dtDetallePagos.Rows(i).Cells(6).Value() = 0 Then
                                'agrega
                                With detallePago

                                    .Cod_Pago = Convert.ToInt32(txtNro.Text)
                                    .Cod_Factura = Convert.ToInt32(dtDetallePagos.Rows(i).Cells(0).Value)

                                    If dtDetallePagos.Rows(i).Cells(4).Value = "" Then
                                        .Forma_Pago = "-"
                                    Else
                                        .Forma_Pago = dtDetallePagos.Rows(i).Cells(4).Value.ToString

                                    End If

                                    If dtDetallePagos.Rows(i).Cells(5).Value = "" Then

                                        .Nro_Cheque = "-"

                                    Else
                                        .Nro_Cheque = dtDetallePagos.Rows(i).Cells(5).Value.ToString

                                    End If

                                    .Monto_ = Convert.ToDouble(dtDetallePagos.Rows(i).Cells(3).Value.ToString)

                                End With

                                If detallePago.registrarDetallePago = 0 Then
                                    MsgBox("Error al querer insertar el detalle de factura.", MsgBoxStyle.Critical)
                                End If
                                'MsgBox("fin agrega")
                            Else
                                'actualiza los detalles de asiento

                                With detallePago

                                    With detallePago

                                        .Cod_Detalle = Convert.ToInt32(dtDetallePagos.Rows(i).Cells(6).Value)
                                        '.Cod_Pago = Convert.ToInt32(txtNro.Text)
                                        .Cod_Factura = Convert.ToInt32(dtDetallePagos.Rows(i).Cells(0).Value)

                                        If dtDetallePagos.Rows(i).Cells(4).Value = "" Then
                                            .Forma_Pago = "-"
                                        Else
                                            .Forma_Pago = dtDetallePagos.Rows(i).Cells(4).Value.ToString

                                        End If

                                        If dtDetallePagos.Rows(i).Cells(5).Value = "" Then

                                            .Nro_Cheque = "-"

                                        Else
                                            .Nro_Cheque = dtDetallePagos.Rows(i).Cells(5).Value.ToString

                                        End If

                                        .Monto_ = Convert.ToDouble(dtDetallePagos.Rows(i).Cells(3).Value.ToString)

                                    End With

                                End With

                                If detallePago.modificarDetallePago() = 0 Then
                                    MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                                End If

                            End If
                        Next

                    End If

                End With

                For index As Integer = 0 To codigoDetallePago.Count - 1
                    detallePago.Cod_Detalle = Convert.ToInt64(codigoDetallePago(index))
                    If detallePago.EliminarDetallePago() <> 1 Then
                        MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                    End If
                Next

                codigoDetallePago.Clear()

                MessageBox.Show("El pago de modificó exitosamente.")
                Me.Close()
                A_ListarPagos.Show()

            End If ' validacion
        Catch ex As Exception
            MsgBox("Error. " + ex.Message)
        End Try

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        limpiar()
        dtDetallePagos.DataSource = Nothing
        btnModificar.Enabled = False
        btnCrear.Enabled = False
        btnGuardar.Enabled = True

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub frmPagos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'If dtDetallePagos.Rows(0).Cells(5).Value <> "" Then

        '    If MessageBox.Show("El Pago tiene un cheque vinculado, se guardara automaticamente ¿Seguro que desea cerrar el formulario?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        '        e.Cancel = True
        '    End If

        'End If

    End Sub
End Class