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
End Class