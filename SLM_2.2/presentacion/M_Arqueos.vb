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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim row As DataRow
        Dim objAp As New ClsApertura
        Dim fondo As Double
        dt = objAp.CierreCaja(Convert.ToInt64(txtCaja2.Text), 1)

        row = dt.Rows(0)

        If IsDBNull(row("fondo")) = False Then
            fondo = Convert.ToDouble(row("fondo"))
        Else
            fondo = 0
        End If
        'le asigno un valor a los parametros del procedimiento almacenado
        Dim objReporte As New M_CierreCaja

        objReporte.SetParameterValue("@codigoCajero", Convert.ToInt64(txtCaja2.Text))
        objReporte.SetParameterValue("efectivo", Convert.ToDouble(row("efectivo")) - Convert.ToDouble(row("vuelto")))
        objReporte.SetParameterValue("tarjeta", Convert.ToDouble(row("tarjeta")))
        objReporte.SetParameterValue("total", Convert.ToDouble(row("total")))
        objReporte.SetParameterValue("fondo", fondo)
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        M_ComprobanteEntrega.CrystalReportViewer1.ReportSource = objReporte
        M_ComprobanteEntrega.ShowDialog()
    End Sub
End Class