Public Class reporteOrdenCompra
    Private Sub reporteOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptDocument As New rpt_ordenCompra


        RptDocument.SetParameterValue("@id_oc", codigo_oc)
        RptDocument.SetDatabaseLogon("sa", "Lbm2019")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub

    Private Sub rpt_ordenCompra1_InitReport(sender As Object, e As EventArgs) Handles rpt_ordenCompra1.InitReport

    End Sub
End Class