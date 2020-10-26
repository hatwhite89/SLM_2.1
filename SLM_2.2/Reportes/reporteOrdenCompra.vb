Public Class reporteOrdenCompra
    Private Sub reporteOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptDocument As New rpt_ordenCompra


        RptDocument.SetParameterValue("@id_oc", codigo_oc)
        RptDocument.SetDatabaseLogon("sa", "Lbm2019")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub
End Class