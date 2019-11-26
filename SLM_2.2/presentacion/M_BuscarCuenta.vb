Public Class M_BuscarCuenta
    Private Sub M_BuscarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCuenta As New ClsCuenta
        Dim dv As DataView = objCuenta.seleccionarCuentas.DefaultView
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
            Dim objCuenta As New ClsCuenta
            Dim dt As New DataTable
            objCuenta.Cuent_a = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            dt = objCuenta.BuscarCuenta()
            Dim row As DataRow = dt.Rows(0)
            If lbltipoCta.Text = "Contado" Then
                M_TerminosPago.txtcodigoCtaContado.Text = CStr(row("codCuenta"))
                M_TerminosPago.txtnombreCtaContado.Text = CStr(row("cuenta"))
                Me.Close()
            ElseIf lbltipoCta.Text = "Ventas" Then
                M_TerminosPago.txtcodigoCtaVentas.Text = CStr(row("codCuenta"))
                M_TerminosPago.txtnombreCtaVentas.Text = CStr(row("cuenta"))
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If (txtcuentaB.Text <> "") Then
            Try
                Dim objCuenta As New ClsCuenta
                objCuenta.Cuent_a = txtcuentaB.Text
                Dim dv As DataView = objCuenta.BuscarCuenta.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la cuenta.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcuentaB.Text = ""
        End If
    End Sub
End Class