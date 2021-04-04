Public Class ReporteOrdenCompraParciales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RptDocument As New rpt_ordenMensualCerradas
        RptDocument.SetParameterValue("@fecha1", "01/01/1999")
        RptDocument.SetParameterValue("@fecha2", Date.Now)
        RptDocument.SetParameterValue("@estado", "Abierta")
        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub


End Class