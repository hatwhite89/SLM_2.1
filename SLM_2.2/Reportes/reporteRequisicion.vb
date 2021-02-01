Imports Microsoft.Reporting.WinForms
Imports Microsoft.SqlServer

Public Class reporteRequisicion
    Private Sub reporteRequisicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptDocument As New rpt_Requisicion


        RptDocument.SetParameterValue("@cod_requisicion", codigo_requisicion)
        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class