Public Class M_ListadoPromociones
    Dim objPromo As New ClsPromociones
    Private Sub M_ListadoPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarPromociones()
        Me.dgbtabla.Columns("contador").Visible = False
        Me.dgbtabla.Columns("img").Visible = False
    End Sub
    Private Sub seleccionarPromociones()
        Dim dv As DataView = objPromo.SeleccionarPromociones.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            Dim dt As New DataTable
            Dim row As DataRow

            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea utilizar la promoción en la factura?", MsgBoxStyle.YesNo)
            End If
            If n = vbYes And M_Factura.validarFactura2(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) = 0 Then
                M_Factura.dgblistadoExamenes.Rows.Add(New String() {dgbtabla.Rows(e.RowIndex).Cells(0).Value(), "1", dgbtabla.Rows(e.RowIndex).Cells(5).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value(), M_Factura.dtpfechaFactura.Value.Date.AddDays(7), "0", dgbtabla.Rows(e.RowIndex).Cells(5).Value()})
                M_ClienteVentana.dgvtabla.Rows.Add(New String() {dgbtabla.Rows(e.RowIndex).Cells(0).Value(), "1", dgbtabla.Rows(e.RowIndex).Cells(5).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value(), M_Factura.dtpfechaFactura.Value.Date.AddDays(7), "0", dgbtabla.Rows(e.RowIndex).Cells(5).Value()})
                Dim objDetPromo As New ClsDetallePromociones
                objDetPromo.codigoPromocion_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                dt = objDetPromo.SeleccionarDetallePromocion()
                For index As Integer = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    M_Factura.dgblistadoExamenes.Rows.Add(New String() {CStr(row("codigoExamen")), "1", "0", CStr(row("descripcion")), M_Factura.dtpfechaFactura.Value.Date.AddDays(7), "0", "0"})
                    M_ClienteVentana.dgvtabla.Rows.Add(New String() {CStr(row("codigoExamen")), "1", "0", CStr(row("descripcion")), M_Factura.dtpfechaFactura.Value.Date.AddDays(7), "0", "0"})
                Next
                M_Factura.lblPromocion.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            Else
                MsgBox("La promoción ya a sido registrada en la factura.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class