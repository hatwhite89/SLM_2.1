Public Class M_BuscarCuenta
    Private Sub M_BuscarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCuenta As New ClsCuenta
        Dim dv As DataView = objCuenta.listarCuentas.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If lbltipoCta.Text = "Contado" Then
                M_TerminosPago.txtcodigoCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                M_TerminosPago.txtnombreCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                Me.Close()
            ElseIf lbltipoCta.Text = "Ventas" Then
                M_TerminosPago.txtcodigoCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                M_TerminosPago.txtnombreCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class