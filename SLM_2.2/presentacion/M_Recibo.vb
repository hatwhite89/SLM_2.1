Public Class M_Recibo
    Private Sub btnbuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnbuscarFormaPago.Click
        A_ListarFormasPagoPF.lblForm.Text = "M_Recibo"
        A_ListarFormasPagoPF.ShowDialog()
    End Sub

    Private Sub txtcodigoFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.TextChanged
        If (txtcodigoFormaPago.Text <> "") Then
            Try
                Dim objFrmPgo As New ClsFormaPago
                With objFrmPgo
                    .Cod = txtcodigoFormaPago.Text
                End With
                Dim dt As New DataTable
                dt = objFrmPgo.buscarCodigoFormaPago()
                Dim row As DataRow = dt.Rows(0)
                txtnombreFormaPago.Text = CStr(row("nombreBanco"))
                lblcodeFormaPago.Text = CStr(row("codFormaPago"))
                txtcodigoFormaPago.BackColor = Color.White
            Catch ex As Exception
                txtcodigoFormaPago.BackColor = Color.Red
                txtnombreFormaPago.Text = ""
            End Try
        Else
            txtcodigoFormaPago.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            txtcodigoFormaPago.BackColor = Color.White
        End If
    End Sub
End Class