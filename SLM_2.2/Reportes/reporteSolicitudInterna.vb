Public Class reporteSolicitudInterna
    Private Sub reporteSolicitudInterna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim RptDocument As New rpt_solicitudInterna


            RptDocument.SetParameterValue("@id_oi", codigo_orden_interna)
            RptDocument.SetDatabaseLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = RptDocument
        Catch ex As Exception

        End Try

    End Sub
End Class