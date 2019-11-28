Public Class E_DetalleExamenes

    'Objeto Item
    Dim Item As New ClsItemExamen

    Sub Limpiar()

        txtCodBreve.Text = ""
        txtDescripcion.Text = ""
        txtGrupo.Text = ""
        txtPrecioBase.Text = ""
        txtClasificación.Text = ""
        txtAbreviatura.Text = ""
        txtComentario.Text = ""

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            'Ingreso de nuevo registro

            With Item
                .Cod_Breve = txtCodBreve.Text
                .Descripcio_n = txtDescripcion.Text
                .Grup_o = txtGrupo.Text
                .Precio_Base = txtPrecioBase.Text
                .Clasificacio_n = txtClasificación.Text
                .Abreviatur_a = txtAbreviatura.Text
                .Comentari_o = txtComentario.Text
                .Estad_o = chkEstado.Checked

                .registrarNuevoItemExamen()
                Limpiar()
                dtItem.DataSource = .listarItemExamen()
                MessageBox.Show("El registro se ha guardado exitosamente")
            End With



        Catch ex As Exception

            MessageBox.Show("Error al guardar." + ex.Message)


        End Try


    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        If chkEstado.Checked = True Then
            lblEstado.Text = "Activo"
            lblEstado.ForeColor = Color.Green
        Else
            lblEstado.Text = "Inactivo"
            lblEstado.ForeColor = Color.Red
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtItem.CellClick

        btnCrear.Visible = True
        btnModificar.Visible = True
        btnGuardar.Visible = False

        txtCodExamen.Text = dtItem.Rows(e.RowIndex).Cells(0).Value
        txtCodBreve.Text = dtItem.Rows(e.RowIndex).Cells(1).Value
        txtDescripcion.Text = dtItem.Rows(e.RowIndex).Cells(2).Value
        txtGrupo.Text = dtItem.Rows(e.RowIndex).Cells(3).Value
        txtPrecioBase.Text = dtItem.Rows(e.RowIndex).Cells(4).Value
        txtClasificación.Text = dtItem.Rows(e.RowIndex).Cells(5).Value
        txtAbreviatura.Text = dtItem.Rows(e.RowIndex).Cells(6).Value
        txtComentario.Text = dtItem.Rows(e.RowIndex).Cells(7).Value
        chkEstado.Checked = dtItem.Rows(e.RowIndex).Cells(8).Value



    End Sub

    Private Sub E_DetalleExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar Item
        dtItem.DataSource = Item.listarItemExamen


        btnCrear.Visible = False
        btnModificar.Visible = False

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            'Modificacion de nuevo registro

            With Item
                .Cod_ItemExa = txtCodExamen.Text
                .Cod_Breve = txtCodBreve.Text
                .Descripcio_n = txtDescripcion.Text
                .Grup_o = txtGrupo.Text
                .Precio_Base = txtPrecioBase.Text
                .Clasificacio_n = txtClasificación.Text
                .Abreviatur_a = txtAbreviatura.Text
                .Comentari_o = txtComentario.Text
                .Estad_o = chkEstado.Checked

                .modificarItemExamen()
                Limpiar()
                dtItem.DataSource = .listarItemExamen()
                MessageBox.Show("El registro se ha modificado exitosamente.")
            End With



        Catch ex As Exception

            MessageBox.Show("Error al modificar." + ex.Message)


        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        E_GrupoExamen.Show()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True
    End Sub
End Class