Public Class M_ListarTerminoPago
    Private Sub M_ListarTerminoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarTerminoPago()
        Me.dgbtabla.Columns("codigo").Visible = False
        Me.dgbtabla.Columns("diasNeto").Visible = False
        Me.dgbtabla.Columns("codigoCtaContado").Visible = False
        Me.dgbtabla.Columns("codigoCtaVentas").Visible = False
        Me.dgbtabla.Columns("codigoTipoTermino").Visible = False
    End Sub
    Private Sub seleccionarTerminoPago()
        Dim objTerm As New ClsTerminoPago
        Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
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
                n = MsgBox("¿Desea utilizar el término de pago seleccionado?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                A_Proveedor.lblCodeTerminoPago.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionB.TextChanged
        If (txtDescripcionB.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago
                objTerm.Descripcion1 = txtDescripcionB.Text
                Dim dv As DataView = objTerm.BuscarTerminoPago.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarTerminoPago()
        End If
    End Sub

    Private Sub txtCodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        If (txtCodigoB.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago
                objTerm.codigoTerminoPago_ = txtCodigoB.Text
                Dim dv As DataView = objTerm.BuscarTerminoPagoCode.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarTerminoPago()
        End If
    End Sub
End Class