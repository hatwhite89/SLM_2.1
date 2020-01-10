Public Class M_ListadoPromociones
    Private Sub M_ListadoPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea utilizar la promoción en la factura?", MsgBoxStyle.YesNo)
            End If
            If n = vbYes Then
                M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class