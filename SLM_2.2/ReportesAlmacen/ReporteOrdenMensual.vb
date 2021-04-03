Public Class ReporteOrdenMensual
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RptDocument As New rpt_ordenMensual
        RptDocument.SetParameterValue("@fecha1", DateTimePicker1.Value.Date)
        RptDocument.SetParameterValue("@fecha2", DateTimePicker2.Value.Date)
        RptDocument.SetParameterValue("@estado", ComboBox2.SelectedText)
        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub
End Class