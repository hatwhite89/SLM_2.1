Public Class E_frm_ResultadoIndividual
    Private Sub E_frm_ResultadoIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim RptDocument As New E_ReporteResultadoIndividual


            RptDocument.SetParameterValue("@numeroFactura", id_resultado)
            RptDocument.SetDatabaseLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = RptDocument
        Catch ex As Exception

        End Try


    End Sub
End Class