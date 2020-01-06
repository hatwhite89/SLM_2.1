Public Class M_ComprobanteEntrega
    Public numeroFactura As Integer
    Private Sub M_ComprobanteEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReporte As New M_CryComprobanteEntrega
        objReporte.SetParameterValue("@numero", numeroFactura)
        objReporte.SetParameterValue("@numeroFactura", numeroFactura)
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        CrystalReportViewer1.ReportSource = objReporte
    End Sub
    Private Sub ImprimirRecibo()
        Dim objReporte As New M_CryComprobanteEntrega
        objReporte.SetParameterValue("@numero", numeroFactura)
        objReporte.SetParameterValue("@numeroFactura", numeroFactura)
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        CrystalReportViewer1.ReportSource = objReporte
    End Sub
End Class