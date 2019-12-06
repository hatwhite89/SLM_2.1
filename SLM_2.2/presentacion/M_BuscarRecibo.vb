Public Class M_BuscarRecibo
    Private Sub M_BuscarRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarRecibo()
    End Sub
    Private Sub seleccionarRecibo()
        Dim objRbo As New ClsRecibo
        Dim dv As DataView = objRbo.SeleccionarRecibo.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Me.dgbtabla.Columns("codigoFormaPago").Visible = False
        Me.dgbtabla.Columns("infoClte").Visible = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver el recibo?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then

                M_Recibo.txtnumero.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                M_Recibo.cbxOk.Checked = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                M_Recibo.dtpFechaTrans.Value = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                M_Recibo.rtxtReferencia.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                M_Recibo.lblcodeFormaPago.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                M_Recibo.cbxInfoClte.Checked = dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                M_Recibo.txtDepositado.Text = dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                M_Recibo.txtMoneda.Text = dgbtabla.Rows(e.RowIndex).Cells(8).Value()

                Dim objDetRbo As New ClsDetalleRecibo
                objDetRbo.codigoRecibo_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Dim dt As New DataTable
                dt = objDetRbo.BuscarDetalleRecibo()
                Dim row As DataRow
                For index As Integer = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    M_Recibo.dgbtabla.Rows.Add(New String() {CStr(row("codigo")), CStr(row("Nro_Factura")), CStr(row("Cliente")), CStr(row("Texto")), CStr(row("Fecha_Pago")), CStr(row("M_Banco")), CStr(row("Monto_Banco")), CStr(row("M_Rec")), CStr(row("ValorRecibido"))})
                Next

                M_Recibo.btnguardar.Enabled = False

                If (M_Recibo.cbxOk.Checked = "1") Then
                    M_Recibo.lblEstado.Text = "OK"
                    M_Recibo.deshabilitar()
                Else
                    M_Recibo.lblEstado.Text = "Modificar"
                    M_Recibo.btnmodificar.Enabled = True
                End If

                M_Recibo.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroB.TextChanged
        If (txtNumeroB.Text <> "") Then
            Try
                Dim objRbo As New ClsRecibo
                objRbo.numero_ = txtNumeroB.Text
                Dim dv As DataView = objRbo.BuscarReciboNum.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarRecibo()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtReferenciaB.TextChanged
        If (txtReferenciaB.Text <> "") Then
            Try
                Dim objRbo As New ClsRecibo
                objRbo.referencia_ = txtReferenciaB.Text
                Dim dv As DataView = objRbo.BuscarReciboRef.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarRecibo()
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        'Me.Close
        M_Recibo.lblEstado.Text = "Nuevo"
        M_Recibo.limpiar()
        M_Recibo.ShowDialog()
    End Sub

End Class