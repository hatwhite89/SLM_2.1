Public Class MM_TomaDeMuestras

    Dim tomaMuestra As New ClsTomaDeMuestras
    Dim objPreguntas As New ClsPreguntasMuestra
    Dim examen As New ClsItemExamen
    Dim codigoPreguntasM As New ArrayList

    Private Sub txtCodExamen_TextChanged(sender As Object, e As EventArgs) Handles txtCodExamen.TextChanged
        Try
            Dim codigoInterno As Integer
            codigoInterno = Integer.Parse(txtCodExamen.Text)

            With examen
                Dim dt As New DataTable
                Dim row As DataRow

                .Cod_Interno = codigoInterno
                dt = .BuscarItemExamInterno
                row = dt.Rows(0)

                txtCodExamen.Text = row("codInterno")
                txtExamen.Text = row("descripcion")
                lblcodexamen.Text = row("codItemExa")
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtCodExamen_DoubleClick(sender As Object, e As EventArgs) Handles txtCodExamen.DoubleClick
        Try
            E_DetalleExamenes.lblform.Text = "MM_TomaDeMuestras"
            E_DetalleExamenes.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodexamen_TextChanged(sender As Object, e As EventArgs) Handles lblcodexamen.TextChanged
        Try
            If Trim(lblcodexamen.Text) <> "" And Trim(lblcodexamen.Text) <> "lblcodexamen" Then
                With examen
                    Dim dt As New DataTable
                    Dim row As DataRow
                    .Cod_ItemExa = lblcodexamen.Text
                    dt = .BuscarItemExam
                    row = dt.Rows(0)

                    txtCodExamen.Text = row("codInterno")
                    txtExamen.Text = row("descripcion")
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If txtCodigo.Text <> "" And txtDescripcion.Text <> "" And lblcodexamen.Text <> "" And dgvPreguntas.Rows.Count > 1 Then

                With tomaMuestra
                    .codMuestra_ = Integer.Parse(txtCodigo.Text)
                    .codExamen_ = Integer.Parse(lblcodexamen.Text)
                    .Descripcion_ = txtDescripcion.Text
                End With

                If tomaMuestra.modificarRegistro() = 1 Then
                    For index As Integer = 0 To codigoPreguntasM.Count - 1
                        'elimina
                        objPreguntas.codPregunta_ = Convert.ToInt64(codigoPreguntasM(index))
                        If objPreguntas.EliminarPreguntaMuestra() <> 1 Then
                            MsgBox("Error al querer modificar la toma de muestra.", MsgBoxStyle.Critical, "Validación.")
                        End If
                    Next
                    codigoPreguntasM.Clear()
                    For index As Integer = 0 To dgvPreguntas.Rows.Count - 2
                        If Trim(dgvPreguntas.Rows(index).Cells(0).Value()) = "" Then
                            'agrega
                            With objPreguntas
                                .codMuestra_ = Integer.Parse(txtCodigo.Text)
                                .enunciado_ = dgvPreguntas.Rows(index).Cells(1).Value()
                                .estado_ = 0
                                'If dgvPreguntas.Rows(index).Cells(2).Value().ToString = "Si" Then
                                '    .estado_ = True
                                'Else
                                '    .estado_ = False
                                'End If
                                .nota_ = dgvPreguntas.Rows(index).Cells(3).Value()
                            End With
                            If objPreguntas.RegistrarNuevaPreguntaMuestra() = 0 Then
                                MsgBox("Error al querer insertar preguntas en la toma de muestra.", MsgBoxStyle.Critical)
                            End If
                        Else

                            'actualiza 
                            With objPreguntas
                                .codPregunta_ = dgvPreguntas.Rows(index).Cells(0).Value()
                                .codMuestra_ = Integer.Parse(txtCodigo.Text)
                                .enunciado_ = dgvPreguntas.Rows(index).Cells(1).Value()
                                .estado_ = 0
                                'If dgvPreguntas.Rows(index).Cells(2).Value().ToString = "Si" Then
                                '    .estado_ = True
                                'Else
                                '    .estado_ = False
                                'End If
                                .nota_ = dgvPreguntas.Rows(index).Cells(3).Value()
                            End With
                            If objPreguntas.ModificarPreguntasMuestra() = 0 Then
                                MsgBox("Error al querer modificar la pregunta.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information, "Validación.")
                    btnModificar.Enabled = False
                    MM_ListadoTomaMuestras.listarTomaMuestra()
                End If

            Else
                MsgBox("Debe llenar los campos obligatorios.", MsgBoxStyle.Critical, "Validación.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub dgvPreguntas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPreguntas.CellClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 4 And lblEstado.Text = "Nuevo" Then
                    Dim n As String = MsgBox("¿Desea eliminar de la toma de muestra?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgvPreguntas.Rows.Remove(dgvPreguntas.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 4 And lblEstado.Text = "Modificar" And Me.dgvPreguntas.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    Dim n As String = MsgBox("¿Desea eliminar de la toma de muestra?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoPreguntasM.Add(Me.dgvPreguntas.Rows(e.RowIndex).Cells(0).Value())
                        dgvPreguntas.Rows.Remove(dgvPreguntas.Rows(e.RowIndex.ToString))
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtDescripcion.Text <> "" And lblcodexamen.Text <> "" And dgvPreguntas.Rows.Count > 1 Then
                Dim codigoTomaMuestra As String

                With tomaMuestra
                    .codExamen_ = Integer.Parse(lblcodexamen.Text)
                    .Descripcion_ = txtDescripcion.Text

                    'Insertar toma de muestra
                    codigoTomaMuestra = .registrarNuevo
                End With

                'Preguntas Muestra
                For index As Integer = 0 To dgvPreguntas.Rows.Count - 2
                    With objPreguntas
                        .codMuestra_ = Integer.Parse(codigoTomaMuestra)
                        .enunciado_ = dgvPreguntas.Rows(index).Cells(1).Value()
                        .estado_ = 0
                        'If dgvPreguntas.Rows(index).Cells(2).Value().ToString = "Si" Then
                        '    .estado_ = True
                        'Else
                        '    .estado_ = False
                        'End If
                        .nota_ = dgvPreguntas.Rows(index).Cells(3).Value()
                    End With
                    If objPreguntas.RegistrarNuevaPreguntaMuestra() = 0 Then
                        MsgBox("Error al querer insertar las preguntas de la muestra.", MsgBoxStyle.Critical)
                    End If
                Next
                MsgBox("Registrada la toma de muestra correctamente.", MsgBoxStyle.Information, "Validación.")
                MM_ListadoTomaMuestras.listarTomaMuestra()

                btnModificar.Enabled = False
                btnGuardar.Enabled = False
            Else
                MsgBox("Debe llenar los campos obligatorios.", MsgBoxStyle.Critical, "Validación.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        txtCodigo.ResetText()
        txtDescripcion.ResetText()
        lblcodexamen.ResetText()
        txtCodExamen.ResetText()
        dgvPreguntas.Rows.Clear()
        lblEstado.Text = "Nuevo"
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub MM_TomaDeMuestras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.dgvPreguntas.Columns("codigo").Visible = False

            If dgvPreguntas.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dgvPreguntas.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If
            alternarColoFilasDatagridview(dgvPreguntas)
        Catch ex As Exception

        End Try
    End Sub
End Class