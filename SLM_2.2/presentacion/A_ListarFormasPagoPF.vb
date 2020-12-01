Public Class A_ListarFormasPagoPF
    Dim forma As New ClsFormaPago
    Private Sub A_ListarFormasPagoPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar data formas de pago
        dtFormasPago.DataSource = forma.listarFormaPago
        Me.dtFormasPago.Columns("codFormaPago").Visible = False
    End Sub

    Private Sub dtFormasPago_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtFormasPago.CellMouseDoubleClick



        'Recibe los campos para el formulario M_Recibo
        If (lblForm.Text = "M_Recibo") Then

            M_Recibo.lblcodeFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
            M_Recibo.txtcodigoFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(1).Value
            M_Recibo.txtnombreFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(5).Value

        ElseIf (lblForm.Text = "DetallePagoFormaPagos") Then
            Dim fp, fila As String
            'Seleccionar forma de pago en Detalle Pago
            fp = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
            fila = frmPagos.lblFila.Text

            frmPagos.dtDetallePagos.Rows(fila).Cells(4).Value = fp

        ElseIf (lblForm.Text = "Pagos") Then
            'Capturar codigo en textbox de forma pagos
            frmPagos.lblCodFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
            frmPagos.txtFormaP.Text = dtFormasPago.Rows(e.RowIndex).Cells(1).Value
            frmPagos.txtCtaBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(4).Value
            frmPagos.txtComentario.Text = dtFormasPago.Rows(e.RowIndex).Cells(5).Value
            frmPagos.lblNombreBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(8).Value


            frmPagos.dtDetallePagos.Enabled = True
        ElseIf (lblForm.Text = "M_Empleados") Then
            M_Empleados.txtcodigoFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
            M_Empleados.txtnombreFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(5).Value
        End If

        Me.Close()

    End Sub

    Private Sub A_ListarFormasPagoPF_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'presionar ESC para cerrar
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

End Class