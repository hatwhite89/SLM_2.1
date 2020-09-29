Public Class frmPagos

    Dim formaPago As New ClsFormaPago
    Dim factuCompra As New ClsFacturaCompra
    Dim pagos As New ClsPago
    Dim detallePago As New ClsDetallePago

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
        A_ListarFormasPagoPF.ShowDialog()

    End Sub

    Private Sub dtDetallePagos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellEndEdit
        'Bloqueo de Celdas 
        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        dtDetallePagos.Columns(3).ReadOnly = True

        Try
            Dim dt As New DataTable
            With factuCompra
                .Cod_Factura = dtDetallePagos.Rows(e.RowIndex).Cells(0).Value
                dt = .comprobarFactura() 'Comprobar existencia de factura compra

                If dt.Rows.Count < 0 Then 'Si la factura existe, llenar campos

                    Dim row As DataRow = dt.Rows(0)
                    dtDetallePagos.Rows(e.RowIndex).Cells(1).Value = row("nombreProveedor")
                    dtDetallePagos.Rows(e.RowIndex).Cells(2).Value = row("moneda")
                    dtDetallePagos.Rows(e.RowIndex).Cells(3).Value = row("total")

                    'Sumar totales de factura

                    lblTotalSuma.Text = dtDetallePagos.Rows(e.RowIndex).Cells(3).Value

                End If

            End With
        Catch ex As Exception
            MsgBox("La factura de compra no existe o hubo un error. Verifique el código.")
        End Try

    End Sub

    Private Sub dtDetallePagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellClick
        'Bloqueo de edicion de celdas
        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        dtDetallePagos.Columns(3).ReadOnly = True

        If e.ColumnIndex = 6 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar la factura?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
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
        txtCodOrden.Text = ""
        dtpFechaP.ResetText()
        dtpFechaT.ResetText()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim n As String = MsgBox("¿Desea guardar el pago?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then


                'Ingresar un nuevo pago
                If txtFormaP.Text <> "" Then

                    dtDetallePagos.Enabled = True
                    Dim ObjFpago As New ClsFormaPago
                    Dim dt As DataTable
                    ObjFpago.Cod = txtFormaP.Text

                    dt = ObjFpago.buscarCodigoFormaPago()

                    If dt.Rows.Count > 0 Then ' Conteo de filas

                        With pagos

                            'Variables
                            .Forma_Pago = txtFormaP.Text
                            .Cuenta_Banco = txtCtaBanco.Text
                            .Comentari_o = txtComentario.Text
                            .Fecha_transfer = dtpFechaT.Value
                            .Fecha_Pago = dtpFechaP.Value
                            .Referenci_a = txtReferencia.Text
                            .Paga_do = chkPagado.Checked
                            .Suma_Total = lblTotalSuma.Text
                            'Ingresar registro en base de datos
                            .registrarNuevoPago()

                        End With

                        'Registro Detalle de Pago
                        Dim dt2 As DataTable
                        'Capturar codigo del pago guardado
                        dt2 = pagos.capturarUltimoPago

                        Dim row As DataRow = dt2.Rows(0)
                        txtNro.Text = CStr(row("codPago"))

                    End If 'If conteo de filas

                    If dtDetallePagos.Rows.Count > 1 Then

                        'Recorrer filas para ingreso de detalle de factura
                        For fila = 0 To dtDetallePagos.Rows.Count - 2
                            Try

                                'Insertar detalle de pago
                                detallePago.Cod_Pago = Convert.ToInt32(txtNro.Text)

                                Try
                                    Dim a As Integer
                                    a = Convert.ToInt32(dtDetallePagos.Rows(fila).Cells(0).Value)

                                    If dtDetallePagos.Rows(fila).Cells(0).Value <> "" Then

                                        detallePago.Cod_Factura = a

                                    Else

                                        detallePago.Cod_Factura = Convert.ToInt32(dtDetallePagos.Rows(fila - 1).Cells(0).Value)

                                    End If

                                Catch ex As Exception

                                End Try

                                Try
                                    If dtDetallePagos.Rows(fila).Cells(4).Value = "" Then
                                        detallePago.Forma_Pago = "-"
                                    Else
                                        detallePago.Forma_Pago = dtDetallePagos.Rows(fila).Cells(4).Value.ToString

                                    End If

                                Catch ex As Exception
                                    MsgBox("formapago")
                                End Try

                                Try
                                    If dtDetallePagos.Rows(fila).Cells(5).Value = "" Then

                                        detallePago.Nro_Cheque = "-"

                                    Else
                                        detallePago.Nro_Cheque = dtDetallePagos.Rows(fila).Cells(5).Value.ToString

                                    End If

                                Catch ex As Exception
                                    MsgBox("es el numero de cheque")
                                End Try

                                Try
                                    detallePago.Monto_ = Convert.ToDouble(dtDetallePagos.Rows(fila).Cells(3).Value.ToString)

                                Catch ex As Exception
                                    MsgBox("es el monto")
                                End Try

                                'Funcion de registro de detalle
                                detallePago.registrarDetallePago()

                            Catch ex As Exception
                                MsgBox("Error en detalle." + ex.Message)
                            End Try

                        Next

                    Else
                        MsgBox("No existe un detalle de pago.")
                    End If

                Else

                    txtFormaP.BackColor = Color.Red

                End If 'Verificar que campo txtFormaPago no este vacio.

                Me.Close()
                A_ListarPagos.ShowDialog()
            End If 'validacion
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtDetallePagos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellDoubleClick

        If e.ColumnIndex = 4 Then

            'Columna de Forma de Pago
            A_ListarFormasPagoPF.lblForm.Text = "DetallePagoFormaPagos"
            lblFila.Text = e.RowIndex
            A_ListarFormasPagoPF.ShowDialog()

        ElseIf e.ColumnIndex = 5 Then

            'Columna de Cheques
            lblFila.Text = e.RowIndex
            A_ListarChequesHabilitados.Show()
            lblFila.Text = e.RowIndex

        ElseIf e.ColumnIndex = 0 Then

            A_ListarFacCompraPagos.Show()
            lblFila.Text = e.RowIndex

        End If

    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

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
                dtDetallePagos.Columns(3).ReadOnly = True
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
        A_ListarPagos.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            Dim n As String = MsgBox("¿Desea modificar el pago?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                'Ingresar un nuevo pago
                If txtFormaP.Text <> "" Then

                    dtDetallePagos.Enabled = True
                    Dim ObjFpago As New ClsFormaPago
                    Dim dt As DataTable
                    ObjFpago.Cod = txtFormaP.Text

                    dt = ObjFpago.buscarCodigoFormaPago()

                    If dt.Rows.Count > 0 Then ' Conteo de filas

                        With pagos

                            'Variables
                            .Cod_Pago = Convert.ToInt32(txtNro.Text)
                            .Forma_Pago = txtFormaP.Text
                            .Cuenta_Banco = txtCtaBanco.Text
                            .Comentari_o = txtComentario.Text
                            .Fecha_transfer = dtpFechaT.Value
                            .Fecha_Pago = dtpFechaP.Value
                            .Referenci_a = txtReferencia.Text
                            .Paga_do = chkPagado.Checked
                            .Suma_Total = lblTotalSuma.Text

                            'Ingresar registro en base de datos
                            .modificarPago()

                        End With

                    End If 'If conteo de filas

                    If dtDetallePagos.Rows.Count > 1 Then

                        'Recorrer filas para ingreso de detalle de factura
                        For fila = 0 To dtDetallePagos.Rows.Count - 2
                            Try

                                'Insertar detalle de pago
                                detallePago.Cod_Pago = Convert.ToInt32(txtNro.Text)

                                Try
                                    Dim a As Integer
                                    a = Convert.ToInt32(dtDetallePagos.Rows(fila).Cells(0).Value)

                                    If dtDetallePagos.Rows(fila).Cells(0).Value <> "" Then

                                        detallePago.Cod_Factura = a

                                    Else

                                        detallePago.Cod_Factura = Convert.ToInt32(dtDetallePagos.Rows(fila - 1).Cells(0).Value)

                                    End If

                                Catch ex As Exception

                                End Try

                                Try
                                    If dtDetallePagos.Rows(fila).Cells(4).Value = "" Then
                                        detallePago.Forma_Pago = "-"
                                    Else
                                        detallePago.Forma_Pago = dtDetallePagos.Rows(fila).Cells(4).Value.ToString

                                    End If

                                Catch ex As Exception
                                    MsgBox("formapago")
                                End Try

                                Try
                                    If dtDetallePagos.Rows(fila).Cells(5).Value = "" Then

                                        detallePago.Nro_Cheque = "-"

                                    Else
                                        detallePago.Nro_Cheque = dtDetallePagos.Rows(fila).Cells(5).Value.ToString

                                    End If

                                Catch ex As Exception
                                    MsgBox("es el numero de cheque")
                                End Try

                                Try
                                    detallePago.Monto_ = Convert.ToDouble(dtDetallePagos.Rows(fila).Cells(3).Value.ToString)

                                Catch ex As Exception
                                    MsgBox("es el monto")
                                End Try

                                'Funcion de registro de detalle
                                detallePago.modificarDetallePago()

                            Catch ex As Exception
                                MsgBox("Error en detalle." + ex.Message)
                            End Try

                        Next

                    Else
                        MsgBox("No existe un detalle de pago.")
                    End If

                Else

                    txtFormaP.BackColor = Color.Red

                End If 'Verificar que campo txtFormaPago no este vacio.

                Me.Close()
                A_ListarPagos.ShowDialog()

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
End Class