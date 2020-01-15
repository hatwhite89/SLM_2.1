Public Class M_BuscarExamen
    Dim objPrice As New ClsPrecio
    Private Sub M_BuscarExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            objPrice.codigoListaPrecios_ = M_Factura.lblcodePriceList.Text
            Dim dv As DataView = objPrice.SeleccionarPrecios.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

            Me.dgbtabla.Columns("codigo").Visible = False
            Me.dgbtabla.Columns("codigoListaPrecios").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            If (txtnombreB.Text <> "") Then
                objPrice.descripcion_ = txtnombreB.Text
                objPrice.codigoListaPrecios_ = M_Factura.lblcodePriceList.Text
                Dim dv As DataView = objPrice.BuscarPrecioDescripcion.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            Dim code As Integer = Convert.ToInt32(dgbtabla.Rows(e.RowIndex).Cells(1).Value())

            Dim n As String = MsgBox("¿Desea agregar el examen a la factura?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes And M_Factura.validarFactura2(code) = 0 Then
                M_Factura.AgregarExamen(code)
                Me.Close()
            Else
                MsgBox("El examen ya a sido registrado en la factura.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class