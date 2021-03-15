Public Class reporteCentroCostos
    Private Sub reporteCentroCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try

            Dim objReporte As New rpt_centrodecostos


            objReporte.SetParameterValue("@fecha1", dtpFechaDesde.Value)
            objReporte.SetParameterValue("@fecha2", dtpFechaHasta.Value)
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = objReporte

        Catch ex As Exception

        End Try
    End Sub
End Class