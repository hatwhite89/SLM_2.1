﻿Public Class A_VistaPlanillaExcel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try


            E_frmInventario.GridAExcel(dtPlanilla)
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub A_VistaPlanillaExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtPlanilla)
    End Sub
End Class