﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Resultados
    Dim numeroFactura As Integer
    Private Sub E_frmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim clsR As New ClsResultados
            Dim ds As New DataTable
            ds.Load(clsR.RecuperarListadoFacturas(TextBox2.Text))

            BindingSource1.DataSource = ds

            DataGridView1.DataSource = BindingSource1
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim clsR As New ClsResultados
            Dim ds As New DataTable
            ds.Load(clsR.RecuperarListadoFacturasPorID(TextBox1.Text))

            BindingSource2.DataSource = ds

            DataGridView2.DataSource = BindingSource2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel_global(DataGridView2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel_global(DataGridView1)
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        id_orden_interna_crystal = Integer.Parse(DataGridView2.Rows(e.RowIndex).Cells(6).Value)
        id_resultado = Integer.Parse(DataGridView2.Rows(e.RowIndex).Cells(6).Value)
        E_frm_ResultadoIndividual.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(System.AppDomain.CurrentDomain.BaseDirectory() & "E_ReporteResultadoIndividual.rpt")
        Report.ExportToDisk(ExportFormatType.PortableDocFormat, "resultado.pdf")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
End Class