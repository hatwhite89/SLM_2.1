Public Class M_Recibo
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
        M_BuscarRecibo.dgbtabla.Rows.Clear()

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

            dtpFechaTrans.Enabled = True
            rtxtReferencia.ReadOnly = False
            txtcodigoFormaPago.ReadOnly = False
            cbxInfoClte.Enabled = True
            cbxOk.Enabled = True
            'dgbtabla.ReadOnly = False
            txtMoneda.ReadOnly = False

            btnmodificar.Enabled = False
            btnguardar.Enabled = True
            ' MsgBox("entra")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub deshabilitar()

        dtpFechaTrans.Enabled = False
        rtxtReferencia.ReadOnly = True
        txtcodigoFormaPago.ReadOnly = True
        cbxInfoClte.Enabled = False
        cbxOk.Enabled = False
        'dgbtabla.ReadOnly = True
        txtMoneda.ReadOnly = True

        btnmodificar.Enabled = True
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
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            rtxtReferencia.Text = sinDobleEspacio(rtxtReferencia.Text)
            If (Trim(rtxtReferencia.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "" And dgbtabla.Rows.Count > 1 And Trim(txtMoneda.Text) <> "") Then

                Dim objRbo As New ClsRecibo

                With objRbo
                    .fechaTrans_ = dtpFechaTrans.Value
                    .referencia_ = rtxtReferencia.Text
                    .codigoFormaPago_ = lblcodeFormaPago.Text
                    .infoClte_ = cbxInfoClte.Checked
                    .ok_ = cbxOk.Checked
                    .moneda_ = txtMoneda.Text
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
                            .numeroFactura_ = dgbtabla.Rows(index).Cells(0).Value()
                        End With
                        If objDetRbo.RegistrarNuevoDetalleRecibo() = 0 Then
                            MsgBox("Error al querer insertar el detalle del recibo.")
                        End If
                    Next
                    MsgBox("Registrado el recibo correctamente.")
                Else
                    MsgBox("Error al querer ingresar el recibo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub

    Public Sub calcularTotal()
        Dim total As Double
        For index As Integer = 0 To dgbtabla.Rows.Count - 1
            total += Convert.ToDouble(dgbtabla.Rows(index).Cells(7).Value())
        Next
        txtDepositado.Text = total
    End Sub
    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.ColumnIndex = 0 Then
                M_ListarFactura.ShowDialog()
            ElseIf e.ColumnIndex = 8 Then
                Dim n As String = MsgBox("¿Desea eliminar la factura del recibo?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                    calcularTotal()
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
        Dim btn As New DataGridViewButtonColumn()
        dgbtabla.Columns.Add(btn)
        btn.HeaderText = "Eliminar"
        btn.Text = "Eliminar"
        btn.Name = "btnEliminar"
        btn.UseColumnTextForButtonValue = True
    End Sub
End Class