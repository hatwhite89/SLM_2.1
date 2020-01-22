Public Class M_Arqueos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtcodigoMaquina.Text <> "") Then
            Try
                Dim t, t2, t3, t4, t5 As Double
                Dim objTerm As New ClsArqueos
                With objTerm
                    .codigoMaquinaLocal_ = txtcodigoMaquina.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarArqueo()
                Dim row As DataRow = dt.Rows(0)
                t = Convert.ToDouble(row("efectivo"))
                t2 = Convert.ToDouble(row("tarjeta"))
                t3 = Convert.ToDouble(row("vuelto"))
                t4 = Convert.ToDouble(row("total"))
                t5 = Convert.ToDouble(row("fondo"))
                MsgBox("Efectivo facturado: " & t - t3 & ", Tarjeta: " & t2 & ", Total facturado: " & t4 & ", Fondo Aperturado: " & t5 & ", Total Efectivo en Caja: " & ((t - t3) + t5))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class