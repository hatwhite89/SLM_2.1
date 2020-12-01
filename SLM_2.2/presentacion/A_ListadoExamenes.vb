Public Class A_ListadoExamenes
    Dim exam As New ClsItemExamen
    Private Sub A_ListadoExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            dgvExamenes.DataSource = exam.listarItemExamen

            If dgvExamenes.Columns.Contains("codItemExa") Then

                dgvExamenes.Columns("codItemExa").Visible = False

                dgvExamenes.Columns("codInterno").HeaderText = "Código"
                dgvExamenes.Columns("codBreve").HeaderText = "Cód. Breve"
                dgvExamenes.Columns("descripcion").HeaderText = "Descripción"
                dgvExamenes.Columns("comentario").HeaderText = "Comentario"

                dgvExamenes.Columns("grupo").Visible = False
                dgvExamenes.Columns("precioBase").Visible = False
                dgvExamenes.Columns("clasificacion").Visible = False
                dgvExamenes.Columns("abreviatura").Visible = False
                dgvExamenes.Columns("estado").Visible = False
                dgvExamenes.Columns("codigoSubArea").Visible = False

            End If

        Catch ex As Exception

        End Try
        alternarColoFilasDatagridview(dgvExamenes)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try

            If txtBuscar.Text = "" Then

                dgvExamenes.DataSource = exam.listarItemExamen

                If dgvExamenes.Columns.Contains("codItemExa") Then

                    dgvExamenes.Columns("codItemExa").Visible = False

                    dgvExamenes.Columns("codInterno").HeaderText = "Código"
                    dgvExamenes.Columns("codBreve").HeaderText = "Cód. Breve"
                    dgvExamenes.Columns("descripcion").HeaderText = "Descripción"
                    dgvExamenes.Columns("comentario").HeaderText = "Comentario"

                    dgvExamenes.Columns("grupo").Visible = False
                    dgvExamenes.Columns("precioBase").Visible = False
                    dgvExamenes.Columns("clasificacion").Visible = False
                    dgvExamenes.Columns("abreviatura").Visible = False
                    dgvExamenes.Columns("estado").Visible = False
                    dgvExamenes.Columns("codigoSubArea").Visible = False
                End If
            Else
                    'Busqueda de examen por codigo interno
                    exam.Cod_Interno = Convert.ToInt32(txtBuscar.Text)
                    dgvExamenes.DataSource = exam.BuscarItemExamInterno

                    If dgvExamenes.Columns.Contains("codItemExa") Then

                        dgvExamenes.Columns("codItemExa").Visible = False

                        dgvExamenes.Columns("codInterno").HeaderText = "Código"
                        dgvExamenes.Columns("codBreve").HeaderText = "Cód. Breve"
                        dgvExamenes.Columns("descripcion").HeaderText = "Descripción"
                        dgvExamenes.Columns("comentario").HeaderText = "Comentario"

                        dgvExamenes.Columns("grupo").Visible = False
                        dgvExamenes.Columns("precioBase").Visible = False
                        dgvExamenes.Columns("clasificacion").Visible = False
                        dgvExamenes.Columns("abreviatura").Visible = False
                        dgvExamenes.Columns("estado").Visible = False
                        dgvExamenes.Columns("codigoSubArea").Visible = False

                    End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvExamenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExamenes.CellDoubleClick

        Try

            Dim dt As New DataTable
            Dim row As DataRow

            dt = dgvExamenes.DataSource
            row = dt.Rows(e.RowIndex)

            A_Informes.lblCodExamen.Text = row("codItemExa")
            A_Informes.txtCodExamen.Text = row("codInterno")
            A_Informes.txtNombreExamen.Text = row("descripcion")

            Me.Close()

        Catch ex As Exception

        End Try



    End Sub
End Class