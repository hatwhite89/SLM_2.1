Imports System.IO

Public Class E_frmEntregaResultados
    Private Sub E_frmEntregaResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CARGAR DATOS AL GRIDVIEW 
        Dim clsDeOC As New ClsResultados
        Dim dvOC As DataView = clsDeOC.ListarResultadosEnviados(TextBox3.Text).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'LLAMAR CRYSTAL
            Dim RptDocument As New E_ReporteResultadoIndividual
            Dim clsc As New ClsOrdenDeTrabajo
            Try
                RptDocument.SetParameterValue("@id_orden", TextBox3.Text)
                RptDocument.SetDatabaseLogon("sa", "Lbm2019")
                RptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Path.Combine(Application.StartupPath, "Resultados\resultado" + TextBox1.Text.ToString + ".pdf"))
                id_orden_interna_crystal = TextBox3.Text
                enviarMailResultado(clsc.RecuperarCorreo(TextBox3.Text), TextBox3.Text)
                MsgBox("Resultados enviados al correo " + clsc.RecuperarCorreo(TextBox3.Text).ToString)
            Catch ex As Exception
                MsgBox(ex)
            End Try


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id_orden_interna_crystal = TextBox3.Text
        E_frm_ResultadoIndividual.Show()
    End Sub
End Class