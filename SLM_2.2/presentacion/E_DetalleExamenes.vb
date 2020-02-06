Public Class E_DetalleExamenes

    'Objeto Item
    Dim Item As New ClsItemExamen

    'Arreglo de codigos a eliminar
    Dim codigoItemDetalle As ArrayList = New ArrayList()

    Sub Limpiar()

        Try
            txtCodBreve.Text = ""
            txtDescripcion.Text = ""
            txtGrupo.Text = ""
            txtPrecioBase.Text = ""
            txtClasificación.Text = ""
            txtAbreviatura.Text = ""
            txtComentario.Text = ""
            dtResultados.Rows.Clear()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            'Ingreso de nuevo registro
            If (dtResultados.Rows.Count <= 1) Then
                MsgBox("Debe ingresar un resultado de examen por lo menos.")
                Exit Sub
            End If

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
                dtItem.DataSource = .listarItemExamen()
            End With

            Dim dt As New DataTable
            dt = Item.CapturarItem()
            Dim row As DataRow = dt.Rows(0)

            txtCodExamen.Text = CStr(row("codItemExa"))

            Dim objItemDet As New ClsItemExamenDetalle
            For index As Integer = 0 To dtResultados.Rows.Count - 2
                With objItemDet
                    .codigoItemExamen_ = Convert.ToInt64(txtCodExamen.Text)
                    .Nombre_ = dtResultados.Rows(index).Cells(1).Value()
                    .codigoUnidad_ = dtResultados.Rows(index).Cells(2).Value()
                End With
                If objItemDet.RegistrarNuevoItemExamenDetalle() = 0 Then
                    MsgBox("Error al querer insertar el posible resultado.")
                End If
            Next

            Limpiar()
            MessageBox.Show("El registro se ha guardado exitosamente.")

        Catch ex As Exception

            MessageBox.Show("Error al guardar." + ex.Message)

        End Try


    End Sub
    Private Sub dtResultados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtResultados.CellClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 3 Then
                    E_ListarUnidades.lblFila.Text = e.RowIndex
                    E_ListarUnidades.lblNombre.Text = Me.dtResultados.Rows(e.RowIndex).Cells(1).Value().ToString()
                    E_ListarUnidades.ShowDialog()
                ElseIf e.ColumnIndex = 4 And Me.dtResultados.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    Dim n As String = MsgBox("¿Desea eliminar el resultado del examen?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dtResultados.Rows.Remove(dtResultados.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 4 And Me.dtResultados.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    Dim n As String = MsgBox("¿Desea eliminar el resultado del examen?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoItemDetalle.Add(Me.dtResultados.Rows(e.RowIndex).Cells(0).Value())
                        dtResultados.Rows.Remove(dtResultados.Rows(e.RowIndex.ToString))
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("dtResultados  " & ex.Message, MsgBoxStyle.Critical)
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
        Try
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

            dtResultados.Rows.Clear()

            Dim dt As New DataTable
            Dim row As DataRow
            Dim objItemDet As New ClsItemExamenDetalle
            objItemDet.codigoItemExamen_ = dtItem.Rows(e.RowIndex).Cells(0).Value
            dt = objItemDet.BuscarItemExamenDetalle()
            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                dtResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("codigoUnidad")), CStr(row("unidad_codigo_breve"))})
            Next

            M_Precio.txtcodigoItem.Text = txtCodExamen.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub E_DetalleExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Listar Item
            dtItem.DataSource = Item.listarItemExamen

            'agregar boton
            If dtResultados.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtResultados.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If

            btnCrear.Visible = False
            btnModificar.Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            'Modificacion de nuevo registro
            If (dtResultados.Rows.Count <= 1) Then
                MsgBox("Debe ingresar un resultado de examen por lo menos.")
                Exit Sub
            End If

            With Item
                .Cod_ItemExa = Convert.ToInt64(txtCodExamen.Text)
                .Cod_Breve = txtCodBreve.Text
                .Descripcio_n = txtDescripcion.Text
                .Grup_o = txtGrupo.Text
                .Precio_Base = Convert.ToDouble(txtPrecioBase.Text)
                .Clasificacio_n = txtClasificación.Text
                .Abreviatur_a = txtAbreviatura.Text
                .Comentari_o = txtComentario.Text
                .Estad_o = chkEstado.Checked

                .modificarItemExamen()
                dtItem.DataSource = .listarItemExamen()
            End With
            '''''''
            Dim objItemDet As New ClsItemExamenDetalle
            For index As Integer = 0 To codigoItemDetalle.Count - 1
                'elimina
                objItemDet.codigo_ = Convert.ToInt64(codigoItemDetalle(index))
                If objItemDet.EliminarItemDetalle() <> 1 Then
                    MsgBox("Error al querer modificar el recibo")
                End If
            Next
            codigoItemDetalle.Clear()
            For index As Integer = 0 To dtResultados.Rows.Count - 2
                If dtResultados.Rows(index).Cells(0).Value() = "" Then
                    'agrega
                    With objItemDet
                        .codigoItemExamen_ = Convert.ToInt64(txtCodExamen.Text)
                        .Nombre_ = dtResultados.Rows(index).Cells(1).Value()
                        .codigoUnidad_ = dtResultados.Rows(index).Cells(2).Value()
                    End With
                    If objItemDet.RegistrarNuevoItemExamenDetalle() = 0 Then
                        MsgBox("Error al querer insertar el posible resultado.")
                    End If
                Else
                    'actualiza el detalle de los items
                    With objItemDet
                        .codigo_ = dtResultados.Rows(index).Cells(0).Value()
                        .codigoItemExamen_ = Convert.ToInt64(txtCodExamen.Text)
                        .Nombre_ = dtResultados.Rows(index).Cells(1).Value()
                        .codigoUnidad_ = dtResultados.Rows(index).Cells(2).Value()
                    End With
                    If objItemDet.ModificarItemExamenDetalle() = 0 Then
                        MsgBox("Error al querer insertar el posible resultado.")
                    End If
                End If
            Next
            Limpiar()
            MessageBox.Show("El registro se ha modificado exitosamente.")

        Catch ex As Exception

            MessageBox.Show("Error al modificar." + ex.Message)


        End Try




    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtItem.CellMouseDoubleClick
        Try
            Dim n As String = ""
            Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(3).Value()
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea utilizar el examen que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                If (M_ListaPrecios.validarItem(dtItem.Rows(e.RowIndex).Cells(0).Value()) = 0) Then
                    If Convert.ToInt64(lblFila.Text) >= 0 And temp <> "" Then
                        M_ListaPrecios.dgbtabla.Rows.Remove(M_ListaPrecios.dgbtabla.Rows(lblFila.Text))
                    End If
                    M_ListaPrecios.dgbtabla.Rows.Insert(lblFila.Text, New String() {"", "", dtItem.Rows(e.RowIndex).Cells(0).Value(), temp})
                    Me.Close()
                Else
                    MsgBox("Ya a sido agregado anteriormente el examen o grupo de examen.")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
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