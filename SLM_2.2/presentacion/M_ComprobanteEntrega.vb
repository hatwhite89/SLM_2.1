Public Class M_ComprobanteEntrega
    Public numeroFactura As Integer
    Private Sub M_ComprobanteEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReporte As New M_CryComprobanteEntrega
        objReporte.SetParameterValue("@numero", numeroFactura)
        objReporte.SetParameterValue("@numeroFactura", numeroFactura)

        CrystalReportViewer1.ReportSource = objReporte
    End Sub
End Class