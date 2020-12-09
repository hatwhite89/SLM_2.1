Public Class MM_VistaIngresos
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub


    Sub limpiar()
        dgvIngresos.DataSource = Nothing
        dtpDesde.Value = Date.Now
        dtpHasta.Value = Date.Now
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Try

            'COnsulta de ingresos
            Dim fechaDesde, fechaHasta As Date

            fechaDesde = dtpDesde.Value
            fechaHasta = dtpHasta.Value

            dgvIngresos.DataSource = VistaDeIngresos(fechaDesde, fechaHasta)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub MM_VistaIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgvIngresos)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        E_frmInventario.GridAExcel(dgvIngresos)
    End Sub
End Class