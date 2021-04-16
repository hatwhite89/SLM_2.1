Public Class A_ListadoAsientos

    Dim asiento As New ClsAsientoContable

    Private Sub A_ListadoAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dtAsientos.DataSource = asiento.listarAsientos()

            dtAsientos.Columns("cod_asiento").Visible = False
            dtAsientos.Columns("codPeriodo").Visible = False
            dtAsientos.Columns("fecha").Visible = False

            dtAsientos.Columns("campoLlave").HeaderText = "Transf."
            dtAsientos.Columns("descripcion").HeaderText = "Descripción"
            dtAsientos.Columns("descripcion").Width = 320


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtCod_TextChanged(sender As Object, e As EventArgs) Handles txtCod.TextChanged

        Dim Dato As New DataTable
        Dim asi As New ClsAsientoContable

        Try

            If txtCod.Text = "" Then

                dtAsientos.DataSource = asiento.listarAsientos()

                dtAsientos.Columns("cod_asiento").Visible = False
                dtAsientos.Columns("codPeriodo").Visible = False
                dtAsientos.Columns("fecha").Visible = False

                dtAsientos.Columns("descripcion").Width = 320
            Else

                Dim campoLlave As Integer = Convert.ToInt32(txtCod.Text)

                asi.Campo_Llave = Convert.ToInt32(campoLlave)

                dtAsientos.DataSource = asi.buscarAsiento()

                dtAsientos.Columns("cod_asiento").Visible = False
                dtAsientos.Columns("codPeriodo").Visible = False
                dtAsientos.Columns("fecha").Visible = False
                dtAsientos.Columns("descripcion").Width = 320

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Try

            dtAsientos.DataSource = asiento.listarAsientos()

            dtAsientos.Columns("cod_asiento").Visible = False
            dtAsientos.Columns("codPeriodo").Visible = False
            dtAsientos.Columns("fecha").Visible = False
            dtAsientos.Columns("descripcion").Width = 320

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtAsientos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtAsientos.CellDoubleClick

        Try
            Dim dt As DataTable
            Dim row As DataRow

            dt = dtAsientos.DataSource
            row = dt.Rows(e.RowIndex)

            frmAsientos.txtNro.Text = row("campoLlave")
            frmAsientos.dtpFecha.Value = row("fecha")
            frmAsientos.txtTexto.Text = row("descripcion")
            frmAsientos.lblCodAsiento.Text = row("cod_asiento")
            frmAsientos.chkAnular.Checked = row("estado")
            frmAsientos.lblForm.Text = "Listado"
            frmAsientos.lblOrigen.Text = row("Origen")
            Me.Close()
            frmAsientos.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod.KeyPress
        'Solo acepta numeros.
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnIngresarAsiento_Click(sender As Object, e As EventArgs) Handles btnIngresarAsiento.Click
        Try
            frmAsientos.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub MantenimientoCCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoCCToolStripMenuItem.Click
        Try

            A_CentrodeCosto.Show()
            A_CentrodeCosto.BringToFront()
            A_CentrodeCosto.WindowState = WindowState.Normal

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteCCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCCToolStripMenuItem.Click
        Try

            reporteCentroCostos.Show()
            reporteCentroCostos.BringToFront()
            reporteCentroCostos.WindowState = WindowState.Normal

        Catch ex As Exception

        End Try
    End Sub

    Private Sub IngresosPorAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosPorAreaToolStripMenuItem.Click
        Try
            Me.Close()
            MM_VistaIngresos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InformeAsientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeAsientosToolStripMenuItem.Click
        Try
            A_InformeAsientos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MayorDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayorDeCuentasToolStripMenuItem.Click
        Try
            reporteMayorCuentas.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VistaDeIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaDeIngresosToolStripMenuItem.Click
        Try
            MM_Ingresos.Show()
            MM_Ingresos.BringToFront()
            MM_Ingresos.WindowState = WindowState.Normal


        Catch ex As Exception

        End Try
    End Sub
End Class