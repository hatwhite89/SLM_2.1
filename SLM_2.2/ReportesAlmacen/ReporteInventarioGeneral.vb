Public Class ReporteInventarioGeneral
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RptDocument As New rpt_inventarioGeneral



        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub

    Private Sub ReporteInventarioGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class