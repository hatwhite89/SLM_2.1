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

                If dt.Rows.Count > 0 Then 'Si la factura existe, llenar campos

                    Dim row As DataRow = dt.Rows(0)
                    dtDetallePagos.Rows(e.RowIndex).Cells(1).Value = row("nombreProveedor")
                    dtDetallePagos.Rows(e.RowIndex).Cells(2).Value = row("moneda")
                    dtDetallePagos.Rows(e.RowIndex).Cells(3).Value = row("total")


                    'Sumar totales de factura

                    lblTotalSuma.Text = dtDetallePagos.Rows(e.RowIndex).Cells(3).Value

                Else
                    MsgBox("La factura de compra no existe. Verifique el código.")
                End If

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtDetallePagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellClick
        'Bloqueo de edicion de celdas
        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        dtDetallePagos.Columns(3).ReadOnly = True

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

        'Ingresar un nuevo pago
        If txtFormaP.Text <> "" Then

            dtDetallePagos.Enabled = True
            Dim ObjFpago As New ClsFormaPago
            Dim dt As DataTable
            ObjFpago.Cod = txtFormaP.Text

            dt = ObjFpago.buscarCodigoFormaPago()



            If dt.Rows.Count > 0 Then

                With pagos

                    'Variables
                    .Forma_Pago = txtFormaP.Text
                    .Cuenta_Banco = txtCtaBanco.Text
                    .Comentari_o = txtComentario.Text
                    .Fecha_transfer = dtpFechaT.Value
                    .Fecha_Pago = dtpFechaP.Value
                    .Referenci_a = txtReferencia.Text
                    .Paga_do = chkPagado.Checked
                    .Cod_Orden = txtCodOrden.Text
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

        End If 'Verificar que campo txtFormaPago no este vacio.

        'Recorrer filas para ingreso de detalle de factura
        For fila = 0 To dtDetallePagos.Rows.Count - 2
            Try

                'Insertar detalle de pago
                detallePago.Cod_Pago = Convert.ToInt32(txtNro.Text)
                detallePago.Cod_Factura = Convert.ToInt32(dtDetallePagos.Rows(fila).Cells(0).Value)
                detallePago.Forma_Pago = dtDetallePagos.Rows(fila).Cells(4).Value
                detallePago.Nro_Cheque = +dtDetallePagos.Rows(fila).Cells(5).Value

                'Funcion de registro de detalle
                detallePago.registrarDetallePago()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next
        Me.Close()
        A_ListarPagos.ShowDialog()

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
            'A_ListarChequesHabilitados.l
            lblFila.Text = e.RowIndex

        ElseIf e.ColumnIndex = 0 Then

            A_ListarFacCompraPagos.Show()
            lblFila.Text = e.RowIndex

        End If

    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'bloquear datos si pago ya fue realizado
        If chkPagado.Checked = True Then

            dtDetallePagos.Columns(0).ReadOnly = True
            dtDetallePagos.Columns(1).ReadOnly = True
            dtDetallePagos.Columns(2).ReadOnly = True
            dtDetallePagos.Columns(3).ReadOnly = True
            dtDetallePagos.Columns(4).ReadOnly = True

        End If

    End Sub


End Class