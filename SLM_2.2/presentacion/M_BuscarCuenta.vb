Public Class M_BuscarCuenta
    Private Sub M_BuscarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCuenta As New ClsCuenta
        Dim dv As DataView = objCuenta.seleccionarCuentas.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        alternarColoFilasDatagridview(dgbtabla)
        Me.dgbtabla.Columns("codCuenta").Visible = False
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try

            Dim n As String = MsgBox("¿Desea seleccionar la cuenta?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then
                If lbltipoCta.Text = "Contado" Then
                    M_TerminosPago.lblcodeCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_TerminosPago.txtcodigoCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    M_TerminosPago.txtnombreCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    Me.Close()
                ElseIf lbltipoCta.Text = "Ventas" Then
                    M_TerminosPago.lblcodeCtaVentas.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_TerminosPago.txtcodigoCtaVentas.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    M_TerminosPago.txtnombreCtaVentas.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtcuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged

        Try
            Dim objCuenta As New ClsCuenta
            objCuenta.Nombr_e = txtnombreB.Text
            Dim dv As DataView = objCuenta.BuscarCuenta.DefaultView

            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
End Class