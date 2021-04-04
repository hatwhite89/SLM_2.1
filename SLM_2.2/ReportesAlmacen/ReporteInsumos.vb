Public Class ReporteInsumos
    Private Sub ReporteInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAlmacen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim RptDocument As New rpt_reporteInsumos
        RptDocument.SetParameterValue("@id_almacen", ComboBox1.SelectedValue.ToString)
        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub

    Private Sub ComboAlmacen()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "nombre_almacen"
        ComboBox1.ValueMember = "id_almacen"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RptDocument As New rpt_reporteInsumos
        RptDocument.SetParameterValue("@id_almacen", "0")
        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
        CrystalReportViewer1.ReportSource = RptDocument
    End Sub
End Class