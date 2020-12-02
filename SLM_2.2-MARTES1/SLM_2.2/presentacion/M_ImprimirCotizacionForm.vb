Public Class M_ImprimirCotizacionForm
    Public numeroCotizacion As Integer
    Public fechaNacimiento As Date
    Private Sub M_ComprobanteEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim objReporte As New M_ImprimirCotizacion
        'objReporte.SetParameterValue("@numero", numeroCotizacion)
        'objReporte.SetParameterValue("@numeroCotizacion", numeroCotizacion)
        'objReporte.SetParameterValue("@fechaNacimiento", fechaNacimiento)
        'objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        'CrystalReportViewer1.ReportSource = objReporte
    End Sub
    Private Sub ImprimirCotizacion()
        'Dim objReporte As New M_ImprimirCotizacion
        'objReporte.SetParameterValue("@numero", numeroCotizacion)
        'objReporte.SetParameterValue("@numeroCotizacion", numeroCotizacion)
        'objReporte.SetParameterValue("@fechaNacimiento", fechaNacimiento)
        'objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        'CrystalReportViewer1.ReportSource = objReporte
    End Sub
End Class