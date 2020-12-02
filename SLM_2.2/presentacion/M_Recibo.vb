Public Class M_Recibo
    Dim codigoDetalleRecibo As ArrayList = New ArrayList()
    Private Sub btnbuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnbuscarFormaPago.Click
        A_ListarFormasPagoPF.lblForm.Text = "M_Recibo"
        A_ListarFormasPagoPF.ShowDialog()
    End Sub

    Private Sub txtcodigoFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.TextChanged
        If (txtcodigoFormaPago.Text <> "") Then
            Try
                Dim objFrmPgo As New ClsFormaPago
                With objFrmPgo
                    .Cod = txtcodigoFormaPago.Text
                End With

                Dim dt As New DataTable
                dt = objFrmPgo.buscarCodigoFormaPago()
                Dim row As DataRow = dt.Rows(0)
                txtnombreFormaPago.Text = CStr(row("nombreBanco"))
                lblcodeFormaPago.Text = CStr(row("codFormaPago"))
                txtcodigoFormaPago.BackColor = Color.White
            Catch ex As Exception
                txtcodigoFormaPago.BackColor = Color.Red
                txtnombreFormaPago.Text = ""
                lblcodeFormaPago.Text = ""
            End Try
        Else
            txtcodigoFormaPago.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            txtcodigoFormaPago.BackColor = Color.White
        End If
    End Sub
    Public Sub limpiar()

        Try
            txtnumero.Text = ""
            dtpFechaTrans.Value = Date.Now
            rtxtReferencia.Text = ""
            txtcodigoFormaPago.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            cbxInfoClte.Checked = False
            cbxOk.Checked = False
            txtMoneda.Text = "LPS"
            txtDepositado.Text = "0"
            rtxtObservaciones.Clear()
            lblEstado.Text = "Nuevo"

            dgbtabla.Rows.Clear()

            dtpFechaTrans.Enabled = True
            rtxtReferencia.ReadOnly = False
            txtcodigoFormaPago.ReadOnly = False
            cbxInfoClte.Enabled = True
            cbxOk.Enabled = True
            txtMoneda.ReadOnly = False
            rtxtObservaciones.ReadOnly = False

            btnbuscarFormaPago.Enabled = True
            btnmodificar.Enabled = False
            btnguardar.Enabled = True

            codigoDetalleRecibo.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub deshabilitar()

        dtpFechaTrans.Enabled = False
        rtxtReferencia.ReadOnly = True
        txtcodigoFormaPago.ReadOnly = True
        cbxInfoClte.Enabled = False
        cbxOk.Enabled = False
        txtMoneda.ReadOnly = True
        rtxtObservaciones.ReadOnly = True

        btnbuscarFormaPago.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False

    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Public Function validarFactura(ByVal numeroFactura As Integer) As Integer
        For index As Integer = 0 To dgbtabla.Rows.Count - 2
            If (dgbtabla.Rows(index).Cells(1).Value() = numeroFactura) Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            rtxtReferencia.Text = sinDobleEspacio(rtxtReferencia.Text)
            If (Trim(rtxtReferencia.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "" And txtcodigoFormaPago.BackColor = Color.White And dgbtabla.Rows.Count > 1 And Trim(txtMoneda.Text) <> "") Then

                Dim objRbo As New ClsRecibo

                With objRbo
                    .fechaTrans_ = dtpFechaTrans.Value
                    .referencia_ = rtxtReferencia.Text
                    .codigoFormaPago_ = lblcodeFormaPago.Text
                    .infoClte_ = cbxInfoClte.Checked
                    .ok_ = cbxOk.Checked
                    .moneda_ = txtMoneda.Text
                    .observaciones_ = rtxtObservaciones.Text
                    .depositado_ = Convert.ToDouble(txtDepositado.Text)
                End With

                If objRbo.RegistrarNuevoRecibo() = 1 Then
                    'deshabilitar()
                    btnguardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objRbo.CapturarRecibo()
                    Dim row As DataRow = dt.Rows(0)

                    txtnumero.Text = CStr(row("numero"))
                    Dim objDetRbo As New ClsDetalleRecibo
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        With objDetRbo
                            .codigoRecibo_ = txtnumero.Text
                            .numeroFactura_ = dgbtabla.Rows(index).Cells(1).Value()
                        End With
                        If objDetRbo.RegistrarNuevoDetalleRecibo() = 0 Then
                            MsgBox("Error al querer insertar el detalle del recibo.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrado el recibo correctamente.", MsgBoxStyle.Information)
                    M_BuscarRecibo.seleccionarRecibo()
                Else
                    MsgBox("Error al querer ingresar el recibo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            rtxtReferencia.Text = sinDobleEspacio(rtxtReferencia.Text)
            If (Trim(rtxtReferencia.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "" And txtcodigoFormaPago.BackColor = Color.White And dgbtabla.Rows.Count > 1 And Trim(txtMoneda.Text) <> "") Then

                Dim objRbo As New ClsRecibo
                With objRbo
                    .numero_ = txtnumero.Text
                    .fechaTrans_ = dtpFechaTrans.Value
                    .referencia_ = rtxtReferencia.Text
                    .codigoFormaPago_ = lblcodeFormaPago.Text
                    .infoClte_ = cbxInfoClte.Checked
                    .ok_ = cbxOk.Checked
                    .moneda_ = txtMoneda.Text
                    .observaciones_ = rtxtObservaciones.Text
                    .depositado_ = Convert.ToDouble(txtDepositado.Text)
                End With

                If objRbo.ModificarRecibo() = 1 Then
                    Dim objDetRbo As New ClsDetalleRecibo
                    For index As Integer = 0 To codigoDetalleRecibo.Count - 1
                        objDetRbo.codigo_ = Convert.ToInt64(codigoDetalleRecibo(index))
                        If objDetRbo.EliminarDetalleRecibo() <> 1 Then
                            MsgBox("Error al querer modificar el recibo")
                        End If
                    Next
                    codigoDetalleRecibo.Clear()
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        If dgbtabla.Rows(index).Cells(0).Value() = 0 Then
                            'agrega
                            With objDetRbo
                                .codigoRecibo_ = txtnumero.Text
                                .numeroFactura_ = dgbtabla.Rows(index).Cells(1).Value()
                            End With
                            If objDetRbo.RegistrarNuevoDetalleRecibo() = 0 Then
                                MsgBox("Error al querer insertar el detalle del recibo.", MsgBoxStyle.Critical)
                            End If
                        Else

                            'actualiza los recibos
                            With objDetRbo
                                .codigo_ = dgbtabla.Rows(index).Cells(0).Value()
                                .codigoRecibo_ = txtnumero.Text
                                .numeroFactura_ = dgbtabla.Rows(index).Cells(1).Value()
                            End With
                            If objDetRbo.ModificarDetalleRecibo() = 0 Then
                                MsgBox("Error al querer modificar el recibo.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)
                    'btnmodificar.Enabled = False
                End If

                If (cbxOk.Checked) Then
                    deshabilitar()
                End If
                M_BuscarRecibo.seleccionarRecibo()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub calcularTotal()
        Dim total As Double
        For index As Integer = 0 To dgbtabla.Rows.Count - 1
            total += Convert.ToDouble(dgbtabla.Rows(index).Cells(8).Value())
        Next
        txtDepositado.Text = total
    End Sub
    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 1 And lblEstado.Text <> "OK" Then
                    M_ListarFactura.ShowDialog()
                ElseIf e.ColumnIndex = 9 And lblEstado.Text = "Nuevo" Then
                    Dim n As String = MsgBox("¿Desea eliminar la factura del recibo?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                        calcularTotal()
                    End If
                ElseIf e.ColumnIndex = 9 And lblEstado.Text = "Modificar" And Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    Dim n As String = MsgBox("¿Desea eliminar la factura del recibo?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoDetalleRecibo.Add(Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value())
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                        calcularTotal()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub lblcodeFormaPago_TextChanged(sender As Object, e As EventArgs) Handles lblcodeFormaPago.TextChanged
        Try
            Dim objFmaPgo As New ClsFormaPago
            With objFmaPgo
                .Codigo_FormaPago = lblcodeFormaPago.Text
            End With
            Dim dt As New DataTable
            dt = objFmaPgo.buscarFormaPago()
            Dim row As DataRow = dt.Rows(0)
            txtcodigoFormaPago.Text = CStr(row("codigo"))
            txtnombreFormaPago.Text = UCase(CStr(row("nombreBanco")))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub M_Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.dgbtabla.Columns("codigo").Visible = False

            If dgbtabla.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dgbtabla.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If
        Catch ex As Exception

        End Try
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
End Class