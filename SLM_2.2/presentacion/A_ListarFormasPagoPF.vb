Public Class A_ListarFormasPagoPF
    Dim forma As New ClsFormaPago
    Private Sub A_ListarFormasPagoPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar data formas de pago
        dtFormasPago.DataSource = forma.listarFormaPago
    End Sub

    Private Sub dtFormasPago_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtFormasPago.CellMouseDoubleClick
        'Capturar codigo en textbox de forma pagos
        frmPagos.txtFormaP.Text = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
        frmPagos.txtComentario.Text = dtFormasPago.Rows(e.RowIndex).Cells(1).Value
        frmPagos.txtCtaBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(2).Value

        Me.Close()

    End Sub

    Private Sub A_ListarFormasPagoPF_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'presionar ESC para cerrar
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class