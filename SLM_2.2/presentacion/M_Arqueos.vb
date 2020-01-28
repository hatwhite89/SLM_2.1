Public Class M_Arqueos
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
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

                If IsDBNull(row("efectivo")) = False Then
                    t = Convert.ToDouble(row("efectivo"))
                Else
                    t = 0
                End If

                If IsDBNull(row("tarjeta")) = False Then
                    t2 = Convert.ToDouble(row("tarjeta"))
                Else
                    t2 = 0
                End If

                If IsDBNull(row("vuelto")) = False Then
                    t3 = Convert.ToDouble(row("vuelto"))
                Else
                    t3 = 0
                End If

                If IsDBNull(row("total")) = False Then
                    t4 = Convert.ToDouble(row("total"))
                Else
                    t4 = 0
                End If

                If IsDBNull(row("fondo")) = False Then
                    t5 = Convert.ToDouble(row("fondo"))
                Else
                    t5 = 0
                End If

                MsgBox("Efectivo facturado: " & t - t3 & ", Tarjeta: " & t2 & ", Total facturado: " & t4 & ", Fondo Aperturado: " & t5 & ", Total Efectivo en Caja: " & ((t - t3) + t5))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class