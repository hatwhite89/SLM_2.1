Public Class E_DetalleExamenes

    'Objeto Item
    Dim Item As New ClsItemExamen

    'Arreglo de codigos a eliminar
    Dim codigoItemDetalle As ArrayList = New ArrayList()

    Private Sub E_DetalleExamenes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Limpiar()
            Me.Close()
        End If
    End Sub

    Sub Limpiar()

        Try
            txtCodExamen.Text = ""
            txtCodInterno.Text = ""
            txtCodBreve.Text = ""
            txtDescripcion.Text = ""
            txtGrupo.Text = ""
            txtPrecioBase.Text = ""
            txtClasificación.Text = ""
            txtAbreviatura.Text = ""
            txtComentario.Text = ""
            txtCodigoSubArea.ResetText()
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
            If (Trim(txtCodBreve.Text) = "") Then
                MsgBox("Debe ingresar el código breve.")
                Exit Sub
            End If
            If (Trim(txtGrupo.Text) = "") Then
                MsgBox("Debe ingresar o seleccionar el grupo de examen.")
                Exit Sub
            End If
            If (Trim(txtCodigoSubArea.Text) = "") Then
                MsgBox("Debe seleccionar la subárea que pertenece el item.")
                Exit Sub
            End If
            If (Trim(txtDescripcion.Text) = "") Then
                MsgBox("Debe ingresar una descripción del item facturable.")
                Exit Sub
            End If
            If (Trim(txtPrecioBase.Text) = "") Then
                txtPrecioBase.Text = "0"
                'Exit Sub
            End If

            With Item
                .Cod_Interno = Convert.ToInt32(txtCodInterno.Text)
                .Cod_Breve = txtCodBreve.Text
                .Descripcio_n = txtDescripcion.Text
                .Grup_o = lblcodigoGrupo.Text
                .Precio_Base = Convert.ToDouble(txtPrecioBase.Text)
                .Clasificacio_n = txtClasificación.Text
                .Abreviatur_a = txtAbreviatura.Text
                .Comentari_o = txtComentario.Text
                .Estad_o = chkEstado.Checked
                .codigoSubArea_ = txtCodigoSubArea.Text

                If .registrarNuevoItemExamen() = 0 Then
                    MsgBox("Error al querer insertar el item.")
                    Exit Sub
                End If
                dtItem.DataSource = .listarItemExamen()
            End With

            Dim dt As New DataTable
            dt = Item.CapturarItem()
            Dim row As DataRow = dt.Rows(0)

            txtCodExamen.Text = CStr(row("codItemExa"))

            Dim objItemDet As New ClsItemExamenDetalle

            'se puede guardar si esta vacio.

            For index As Integer = 0 To dtResultados.Rows.Count - 2
                With objItemDet

                    .codigoItemExamen_ = Convert.ToInt64(txtCodExamen.Text)
                    .Nombre_ = dtResultados.Rows(index).Cells(1).Value()
                    .codigoUnidad_ = dtResultados.Rows(index).Cells(2).Value()

                End With
                If objItemDet.RegistrarNuevoItemExamenDetalle() = 0 Then
                    MsgBox("Error al querer insertar el posible resultado.")
                    Exit Sub
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
                If e.ColumnIndex = 3 And Me.dtResultados.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    E_ListarUnidades.lblFila.Text = e.RowIndex
                    E_ListarUnidades.lblNombre.Text = Me.dtResultados.Rows(e.RowIndex).Cells(1).Value().ToString()
                    E_ListarUnidades.lblbandera.Text = 1
                    E_ListarUnidades.Show()
                ElseIf e.ColumnIndex = 3 And Me.dtResultados.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    E_ListarUnidades.lblFila.Text = e.RowIndex
                    E_ListarUnidades.lblNombre.Text = Me.dtResultados.Rows(e.RowIndex).Cells(1).Value().ToString()
                    E_ListarUnidades.lblbandera.Text = 0
                    E_ListarUnidades.lblcodeItemExamenDet.Text = Me.dtResultados.Rows(e.RowIndex).Cells(0).Value().ToString()
                    E_ListarUnidades.Show()
                ElseIf e.ColumnIndex = 5 And Me.dtResultados.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    Dim n As String = MsgBox("¿Desea eliminar el resultado del examen?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dtResultados.Rows.Remove(dtResultados.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 5 And Me.dtResultados.Rows(e.RowIndex).Cells(0).Value() <> "" Then
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
            btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False

            txtCodExamen.Text = dtItem.Rows(e.RowIndex).Cells(0).Value
            txtCodInterno.Text = dtItem.Rows(e.RowIndex).Cells(1).Value
            txtCodBreve.Text = dtItem.Rows(e.RowIndex).Cells(2).Value
            txtDescripcion.Text = dtItem.Rows(e.RowIndex).Cells(3).Value

            'txtGrupo.Text = dtItem.Rows(e.RowIndex).Cells(4).Value
            lblcodigoGrupo.Text = dtItem.Rows(e.RowIndex).Cells(4).Value

            txtPrecioBase.Text = dtItem.Rows(e.RowIndex).Cells(5).Value
            txtClasificación.Text = dtItem.Rows(e.RowIndex).Cells(6).Value
            txtAbreviatura.Text = dtItem.Rows(e.RowIndex).Cells(7).Value
            txtComentario.Text = dtItem.Rows(e.RowIndex).Cells(8).Value
            chkEstado.Checked = dtItem.Rows(e.RowIndex).Cells(9).Value
            txtCodigoSubArea.Text = dtItem.Rows(e.RowIndex).Cells(10).Value

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

        Catch ex As Exception

        End Try

    End Sub

    Private Sub E_DetalleExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Listar Item
            dtItem.DataSource = Item.listarItemExamen

            'agregar boton
            If dtResultados.Columns.Contains("btnValorRef") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtResultados.Columns.Add(btn)
                btn.HeaderText = "V. Ref"
                btn.Text = "Valor Ref."
                btn.Name = "btnValor"
                btn.UseColumnTextForButtonValue = True
            End If

            If dtResultados.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtResultados.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If



            btnCrear.Enabled = False
            btnModificar.Enabled = False

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
            If (Trim(txtCodBreve.Text) = "") Then
                MsgBox("Debe ingresar el código breve.")
                Exit Sub
            End If
            If (Trim(txtGrupo.Text) = "") Then
                MsgBox("Debe ingresar o seleccionar el grupo de examen.")
                Exit Sub
            End If
            If (Trim(txtCodigoSubArea.Text) = "") Then
                MsgBox("Debe seleccionar la subárea que pertenece el item.")
                Exit Sub
            End If
            If (Trim(txtDescripcion.Text) = "") Then
                MsgBox("Debe ingresar una descripción del item facturable.")
                Exit Sub
            End If
            If (Trim(txtPrecioBase.Text) = "") Then
                txtPrecioBase.Text = "0"
                Exit Sub
            End If


            With Item
                .Cod_ItemExa = Convert.ToInt64(txtCodExamen.Text)
                .Cod_Interno = Convert.ToInt32(txtCodInterno.Text)
                .Cod_Breve = txtCodBreve.Text
                .Descripcio_n = txtDescripcion.Text
                .Grup_o = lblcodigoGrupo.Text
                .Precio_Base = Convert.ToDouble(txtPrecioBase.Text)
                .Clasificacio_n = txtClasificación.Text
                .Abreviatur_a = txtAbreviatura.Text
                .Comentari_o = txtComentario.Text
                .Estad_o = chkEstado.Checked
                .codigoSubArea_ = txtCodigoSubArea.Text

                If .modificarItemExamen() = 0 Then
                    MsgBox("Error al querer actualizar el item.")
                    Exit Sub
                End If
                dtItem.DataSource = .listarItemExamen()
            End With
            '''''''
            Dim objItemDet As New ClsItemExamenDetalle
            For index As Integer = 0 To codigoItemDetalle.Count - 1
                'elimina
                objItemDet.codigo_ = Convert.ToInt64(codigoItemDetalle(index))
                If objItemDet.EliminarItemDetalle() <> 1 Then
                    MsgBox("Error al querer modificar el detalle del item.")
                End If
            Next
            codigoItemDetalle.Clear()
            For index As Integer = 0 To dtResultados.Rows.Count - 2
                If dtResultados.Rows(index).Cells(0).Value() = "" Then
                    'agrega
                    MsgBox(dtResultados.Rows(index).Cells(1).Value())
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
                    MsgBox(dtResultados.Rows(index).Cells(1).Value())
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
            If (lblform.Text = "M_ListaPrecios") Then
                Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(4).Value()
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el examen seleccionado?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    If (M_ListaPrecios.validarItem(dtItem.Rows(e.RowIndex).Cells(0).Value()) = 0) Then
                        If Convert.ToInt64(lblFila.Text) >= 0 And temp <> "" Then
                            M_ListaPrecios.dgbtabla.Rows.Remove(M_ListaPrecios.dgbtabla.Rows(lblFila.Text))
                        End If
                        M_ListaPrecios.dgbtabla.Rows.Insert(lblFila.Text, New String() {"", "", dtItem.Rows(e.RowIndex).Cells(0).Value(), dtItem.Rows(e.RowIndex).Cells(3).Value(), temp})
                        Me.Close()
                    Else
                        MsgBox("Ya a sido agregado anteriormente el examen o grupo de examen.")
                    End If
                End If
            ElseIf (lblform.Text = "M_Precio") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el examen seleccionado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Precio.txtcodigoItem.Text = txtCodExamen.Text
                    Me.Close()
                End If
            ElseIf (lblForm.Text = "M_DiarioFacturacion") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el examen en el diario de facturación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_ListaPrecios.lblcodeT.Text = lblcode.Text
                    M_DiarioFacturacion.txtExamen.Text = txtDescripcion.Text
                    Me.Close()
                End If
            ElseIf (lblform.Text = "MM_TomaDeMuestras") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el examen en la toma de muestra?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    MM_TomaDeMuestras.lblcodexamen.Text = txtCodExamen.Text
                    MM_TomaDeMuestras.txtCodExamen.Text = txtCodInterno.Text
                    MM_TomaDeMuestras.txtExamen.Text = txtDescripcion.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGrupoExamen_Click(sender As Object, e As EventArgs) Handles btnGrupoExamen.Click
        E_GrupoExamen.lblform.Text = "E_DetalleExamenes"
        E_GrupoExamen.Show()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Private Sub txtSubArea_CLICK(sender As Object, e As EventArgs) Handles txtCodigoSubArea.Click
        Try
            'validacion antes del llenado
            If Trim(lblcodigoGrupo.Text) <> "" And Trim(lblcodigoGrupo.Text) <> "label" Then
                E_ListarSubAreasXArea.lblcodeArea.Text = lblcodigoGrupo.Text
                E_ListarSubAreasXArea.lblform.Text = "E_DetalleExamenes"
                E_ListarSubAreasXArea.Show()
            Else
                MsgBox("Debe seleccionar el grupo de examen.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtGrupo_TextChanged(sender As Object, e As EventArgs) Handles txtGrupo.TextChanged
        If (Trim(txtGrupo.Text) <> "") Then
            Try
                Dim objGroup As New ClsGrupoExamen
                With objGroup
                    .codigoGrupoExamen_ = txtGrupo.Text
                End With
                Dim dt As New DataTable
                dt = objGroup.BuscarGrupoExamenCodigoBreve()
                Dim row As DataRow = dt.Rows(0)
                lblcodigoGrupo.Text = CStr(row("codigo"))
                txtGrupo.BackColor = Color.White
                If lblcodeSubGrupo.Text <> lblcodigoGrupo.Text Then
                    txtCodigoSubArea.Text = ""
                End If
            Catch ex As Exception
                lblcodigoGrupo.Text = ""
                txtGrupo.BackColor = Color.Red
            End Try
        Else
            lblcodigoGrupo.Text = ""
            txtGrupo.BackColor = Color.White
        End If
    End Sub
    Private Sub lblcodigoGrupo_TextChanged(sender As Object, e As EventArgs) Handles lblcodigoGrupo.TextChanged
        If (Trim(lblcodigoGrupo.Text) <> "") Then
            Try
                Dim objGroup As New ClsGrupoExamen
                With objGroup
                    .codigo_ = lblcodigoGrupo.Text
                End With
                Dim dt As New DataTable
                dt = objGroup.BuscarGrupoExamenCodigo()
                Dim row As DataRow = dt.Rows(0)
                txtGrupo.Text = CStr(row("codigoGrupoExamen"))
                txtGrupo.BackColor = Color.White
            Catch ex As Exception
                lblcodigoGrupo.Text = ""
                txtGrupo.BackColor = Color.Red
                'validacion
                lblcodeSubGrupo.Text = ""
                txtCodigoSubArea.Text = ""
            End Try
        Else
            lblcodigoGrupo.Text = ""
            txtGrupo.BackColor = Color.White
            'validacion
            lblcodeSubGrupo.Text = ""
            txtCodigoSubArea.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'E_SubArea.lblform.Text = "M_BuscarCapacitaciones"
        'E_SubArea.Show()
        M_BuscarCapacitaciones.lblform.Text = "M_BuscarCapacitaciones"
        M_BuscarCapacitaciones.Show()
    End Sub

    Private Sub dtResultados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtResultados.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        E_Unidad.Show()
    End Sub
End Class