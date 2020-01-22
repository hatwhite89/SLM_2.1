Public Class A_ListadoAsientos

    Dim asiento As New ClsAsientoContable

    Private Sub A_ListadoAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtAsientos.DataSource = asiento.listarAsientos()

        dtAsientos.Columns("cod_asiento").Visible = False
        dtAsientos.Columns("codPeriodo").Visible = False
        dtAsientos.Columns("fecha").Visible = False
        dtAsientos.Columns("descripcion").Width = 320


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

                asi.Campo_Llave = campoLlave

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
        dtAsientos.DataSource = asiento.listarAsientos()

        dtAsientos.Columns("cod_asiento").Visible = False
        dtAsientos.Columns("codPeriodo").Visible = False
        dtAsientos.Columns("fecha").Visible = False
        dtAsientos.Columns("descripcion").Width = 320
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
            frmAsientos.lblForm.Text = "Listado"
            Me.Close()
            frmAsientos.Show()
        Catch ex As Exception

        End Try




    End Sub
End Class