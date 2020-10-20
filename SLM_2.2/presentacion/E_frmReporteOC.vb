Imports Microsoft.Reporting.WinForms

Public Class E_frmReporteOC
    Private Sub E_frmReporteOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Reporte_OrdenCompraTableAdapter1.Fill(Me.DataSet1.Reporte_OrdenCompra, 1047)
        Dim parametro(0) As ReportParameter

        parametro(0) = New ReportParameter("id_oc", 1047)
        ReportViewer1.LocalReport.SetParameters(parametro)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
End Class