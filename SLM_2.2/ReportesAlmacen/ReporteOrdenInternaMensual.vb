Public Class ReporteOrdenInternaMensual
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RptDocument As New rpt_oiMensualBien
        RptDocument.SetParameterValue("@fecha1", DateTimePicker1.Value.Date)
        RptDocument.SetParameterValue("@fecha2", DateTimePicker2.Value.Date)

        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub
End Class