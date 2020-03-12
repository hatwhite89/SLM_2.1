Public Class M_Arqueos
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If (txtcodigoMaquina.Text <> "") Then
            Try
                Dim t, t2, t3, t4, t5 As Double
                Dim efectivo, tarjeta, vuelto, total, fondo As Double
                Dim objTerm As New ClsArqueos
                With objTerm
                    .codigoMaquinaLocal_ = txtcodigoMaquina.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarArqueo()
                Dim row As DataRow = dt.Rows(0)

                If IsDBNull(row("efectivo")) = False Then
                    efectivo = Convert.ToDouble(row("efectivo"))
                Else
                    efectivo = 0
                End If

                If IsDBNull(row("tarjeta")) = False Then
                    tarjeta = Convert.ToDouble(row("tarjeta"))
                Else
                    tarjeta = 0
                End If

                If IsDBNull(row("vuelto")) = False Then
                    vuelto = Convert.ToDouble(row("vuelto"))
                Else
                    vuelto = 0
                End If

                If IsDBNull(row("total")) = False Then
                    total = Convert.ToDouble(row("total"))
                Else
                    total = 0
                End If

                If IsDBNull(row("fondo")) = False Then
                    fondo = Convert.ToDouble(row("fondo"))
                Else
                    fondo = 0
                End If

                MsgBox("Efectivo facturado: " & efectivo - vuelto & ", Tarjeta: " & tarjeta & ", Total facturado: " & total & ", Fondo Aperturado: " & fondo & ", Total Efectivo en Caja: " & ((efectivo - vuelto) + fondo))
                'MsgBox("Efectivo facturado: " & t - t3 & ", Tarjeta: " & t2 & ", Total facturado: " & t4 & ", Fondo Aperturado: " & t5 & ", Total Efectivo en Caja: " & ((t - t3) + t5))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim dt As New DataTable
            Dim row As DataRow
            Dim objAp As New ClsApertura
            Dim fondo, efectivo, vuelto, tarjeta, total As Double
            dt = objAp.CierreCaja(Convert.ToInt64(txtCaja2.Text), 1)

            row = dt.Rows(0)

            If IsDBNull(row("fondo")) = False Then
                fondo = Convert.ToDouble(row("fondo"))
            Else
                fondo = 0
            End If

            If IsDBNull(row("efectivo")) = False Then
                efectivo = Convert.ToDouble(row("efectivo"))
            Else
                efectivo = 0
            End If

            If IsDBNull(row("vuelto")) = False Then
                vuelto = Convert.ToDouble(row("vuelto"))
            Else
                vuelto = 0
            End If

            If IsDBNull(row("tarjeta")) = False Then
                tarjeta = Convert.ToDouble(row("tarjeta"))
            Else
                tarjeta = 0
            End If

            If IsDBNull(row("total")) = False Then
                total = Convert.ToDouble(row("total"))
            Else
                total = 0
            End If
            'le asigno un valor a los parametros del procedimiento almacenado
            Dim objReporte As New M_CierreCaja

            objReporte.SetParameterValue("@codigoCajero", Convert.ToInt64(txtCaja2.Text))
            objReporte.SetParameterValue("efectivo", efectivo - vuelto)
            objReporte.SetParameterValue("tarjeta", tarjeta)
            objReporte.SetParameterValue("total", total)
            objReporte.SetParameterValue("fondo", fondo)
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")

            M_ComprobanteEntrega.CrystalReportViewer1.ReportSource = objReporte
            M_ComprobanteEntrega.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub


End Class