Public Class A_Planilla
    Dim codigoDetallePlanilla As New ArrayList
    Dim objPlan As New ClsPlanilla
    Dim objDetPlan As New ClsDetallePlanilla
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        Try
            txtCodigo.Clear()
            txtCodigoBreve.Clear()
            txtDescripcion.Clear()
            dgvEmpleados.Rows.Clear()

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub A_Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'agrgear el boton para eliminar un empleado de la capacitacion
        If dgvEmpleados.Columns.Contains("btnEliminar") = False Then
            Dim btn As New DataGridViewButtonColumn()
            dgvEmpleados.Columns.Add(btn)
            btn.HeaderText = "Eliminar"
            btn.Text = "Eliminar"
            btn.Name = "btnEliminar"
            btn.UseColumnTextForButtonValue = True
        End If
        lblcantidad.Text = dgvEmpleados.Rows.Count - 1
    End Sub
    Private Sub dgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        Try
            Dim n As String
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 2 Then
                    M_ListadoEmpleados.lblform.Text = "A_Planilla"
                    M_ListadoEmpleados.lblfila.Text = e.RowIndex
                    M_ListadoEmpleados.Show()
                ElseIf e.ColumnIndex = 5 And Me.dgvEmpleados.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    n = MsgBox("¿Desea eliminar el empleado de la planilla?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgvEmpleados.Rows.Remove(dgvEmpleados.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 5 And Me.dgvEmpleados.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    n = MsgBox("¿Desea eliminar el empleado de la planilla?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoDetallePlanilla.Add(Me.dgvEmpleados.Rows(e.RowIndex).Cells(0).Value())
                        dgvEmpleados.Rows.Remove(dgvEmpleados.Rows(e.RowIndex.ToString))
                    End If
                End If
            End If
            lblcantidad.Text = dgvEmpleados.Rows.Count - 1
        Catch ex As Exception
            MsgBox("Seleccionar el datagridview: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub sinDobleEspacio(ByRef cadena As String)
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        cadena = RTrim(texto)
    End Sub
    Public Function validarEmpleados(ByVal codigoEmpleado As Integer) As Boolean
        For index As Integer = 0 To dgvEmpleados.Rows.Count - 2
            If (dgvEmpleados.Rows(index).Cells(1).Value() = codigoEmpleado) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            sinDobleEspacio(txtDescripcion.Text)
            sinDobleEspacio(txtCodigoBreve.Text)
            If (Trim(txtDescripcion.Text) <> "" And Trim(txtCodigoBreve.Text) <> "" And dgvEmpleados.Rows.Count > 1) Then

                With objPlan
                    .descripcion_ = txtDescripcion.Text
                    .codigoBreve_ = txtCodigoBreve.Text
                End With

                If objPlan.RegistrarNuevaPlanilla() = 1 Then
                    'deshabilitar()
                    btnGuardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objPlan.CapturarPlanilla()
                    Dim row As DataRow = dt.Rows(0)

                    txtCodigo.Text = CStr(row("codPlanilla"))
                    For index As Integer = 0 To dgvEmpleados.Rows.Count - 2
                        With objDetPlan
                            .codPlanilla_ = txtCodigo.Text
                            .codEmpleado_ = dgvEmpleados.Rows(index).Cells(1).Value()
                        End With
                        If objDetPlan.RegistrarNuevoDetallePlanilla() = 0 Then
                            MsgBox("Error al querer insertar el detalle de planilla.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrada la planilla con éxito.", MsgBoxStyle.Information)

                    'ACTUALIZAR LISTADO DE PLANILLA
                    A_BuscarPlanilla.seleccionarPlanilla()
                Else
                    MsgBox("Error al querer ingresar la planilla.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            sinDobleEspacio(txtDescripcion.Text)
            sinDobleEspacio(txtCodigoBreve.Text)
            If (Trim(txtDescripcion.Text) <> "" And Trim(txtCodigoBreve.Text) <> "" And dgvEmpleados.Rows.Count > 1 And Trim(txtCodigo.Text) <> "") Then

                With objPlan
                    .codPlanilla_ = Convert.ToInt64(txtCodigo.Text)
                    .descripcion_ = txtDescripcion.Text
                    .codigoBreve_ = txtCodigoBreve.Text
                End With

                If objPlan.ActualizarPlanilla() = 1 Then
                    For index As Integer = 0 To codigoDetallePlanilla.Count - 1
                        'ELIMINA LOS DETALLE DE PLANILLA
                        objDetPlan.codDetPlanilla_ = Convert.ToInt64(codigoDetallePlanilla(index))
                        If objDetPlan.EliminarDetallePlanilla() <> 1 Then
                            MsgBox("Error al querer modificar el detalle de planilla.", MsgBoxStyle.Critical)
                        End If
                    Next
                    codigoDetallePlanilla.Clear()
                    For index As Integer = 0 To dgvEmpleados.Rows.Count - 2
                        If dgvEmpleados.Rows(index).Cells(0).Value() = "" Then
                            'agrega
                            With objDetPlan
                                .codPlanilla_ = Convert.ToInt64(txtCodigo.Text)
                                .codEmpleado_ = dgvEmpleados.Rows(index).Cells(1).Value()
                            End With
                            If objDetPlan.RegistrarNuevoDetallePlanilla() = 0 Then
                                MsgBox("Error al querer modificar el detalle de planilla.", MsgBoxStyle.Critical)
                            End If
                        Else
                            'actualiza 
                            With objDetPlan
                                .codDetPlanilla_ = dgvEmpleados.Rows(index).Cells(0).Value()
                                .codPlanilla_ = Convert.ToInt64(txtCodigo.Text)
                                .codEmpleado_ = dgvEmpleados.Rows(index).Cells(1).Value()
                            End With
                            If objDetPlan.ActualizarDetallePlanilla() = 0 Then
                                MsgBox("Error al querer modificar el detalle de planilla.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    MsgBox("Actualizada la planilla con éxito.", MsgBoxStyle.Information)
                    btnGuardar.Enabled = False
                    btnModificar.Enabled = True
                End If
                'ACTUALIZAR LISTADO DE PLANILLA
                A_BuscarPlanilla.seleccionarPlanilla()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
        Me.Close()
    End Sub
End Class