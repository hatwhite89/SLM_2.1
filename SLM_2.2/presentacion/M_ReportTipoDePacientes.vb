Public Class M_ReportTipoDePacientes
    Private Sub M_ReportTipoDePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'le asigno un valor a los parametros del procedimiento almacenado
        Dim objReporte As New M_CryTiposDePacientes
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        CrystalReportViewer1.ReportSource = objReporte
    End Sub
End Class