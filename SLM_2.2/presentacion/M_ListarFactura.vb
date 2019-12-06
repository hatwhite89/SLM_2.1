Public Class M_ListarFactura
    Private Sub M_BuscarCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objFact As New ClsFactura
        Dim dv As DataView = objFact.SeleccionarFactura.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.dgbtabla.Columns("codigo").Visible = False
    End Sub
    Private Sub seleccionarFacturas()
        Dim objFact As New ClsFactura
        Dim dv As DataView = objFact.SeleccionarFactura.DefaultView
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
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea agregar la factura al recibo?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                M_Recibo.dgbtabla.Rows.Add(New String() {"0", dgbtabla.Rows(e.RowIndex).Cells(1).Value(), dgbtabla.Rows(e.RowIndex).Cells(5).Value(), dgbtabla.Rows(e.RowIndex).Cells(6).Value(), dgbtabla.Rows(e.RowIndex).Cells(3).Value(), "LPS", dgbtabla.Rows(e.RowIndex).Cells(7).Value(), "LPS", dgbtabla.Rows(e.RowIndex).Cells(7).Value()})
                M_Recibo.calcularTotal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "    subir", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroB.TextChanged
        If (txtnumeroB.Text <> "") Then
            Try
                Dim objFact As New ClsFactura
                objFact.numero_ = txtnumeroB.Text
                Dim dv As DataView = objFact.BuscarFactura.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarFacturas()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        If (txtnombreB.Text <> "") Then
            Try
                Dim objFact As New ClsFactura
                objFact.nombreCliente_ = txtnombreB.Text
                Dim dv As DataView = objFact.BuscarFacturaCliente.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarFacturas()
        End If
    End Sub

End Class