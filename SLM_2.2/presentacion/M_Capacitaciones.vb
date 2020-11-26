Public Class M_Capacitaciones
    Dim codigoDetalleCapacitacion As New ArrayList
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        Try
            txtCodigo.ResetText()
            txtNombre.ResetText()
            txtProveedor.ResetText()
            dtpFecha.ResetText()
            txtCantidadHoras.ResetText()
            dgvBeneficiarios.Rows.Clear()

            btnguardar.Enabled = True
            btnmodificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub M_Capacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgvBeneficiarios)
        'agrgear el boton para eliminar un empleado de la capacitacion
        If dgvBeneficiarios.Columns.Contains("btnEliminar") = False Then
            Dim btn As New DataGridViewButtonColumn()
            dgvBeneficiarios.Columns.Add(btn)
            btn.HeaderText = "Eliminar"
            btn.Text = "Eliminar"
            btn.Name = "btnEliminar"
            btn.UseColumnTextForButtonValue = True
        End If
    End Sub
    Private Sub dgvBeneficiarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBeneficiarios.CellClick
        Try
            Dim n As String
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 2 Then
                    M_ListadoEmpleados.lblform.Text = "M_Capacitaciones"
                    M_ListadoEmpleados.lblfila.Text = e.RowIndex
                    M_ListadoEmpleados.Show()
                ElseIf e.ColumnIndex = 5 And Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    n = MsgBox("¿Desea eliminar el empleado de la capacitación?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgvBeneficiarios.Rows.Remove(dgvBeneficiarios.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 5 And Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    n = MsgBox("¿Desea eliminar el empleado de la capacitación?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoDetalleCapacitacion.Add(Me.dgvBeneficiarios.Rows(e.RowIndex).Cells(0).Value())
                        dgvBeneficiarios.Rows.Remove(dgvBeneficiarios.Rows(e.RowIndex.ToString))
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("dtResultados  " & ex.Message, MsgBoxStyle.Critical)
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
    Public Function validarBeneficiarios(ByVal codigoEmpleado As Integer) As Boolean
        For index As Integer = 0 To dgvBeneficiarios.Rows.Count - 2
            If (dgvBeneficiarios.Rows(index).Cells(1).Value() = codigoEmpleado) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            sinDobleEspacio(txtNombre.Text)
            sinDobleEspacio(txtProveedor.Text)
            If (Trim(txtNombre.Text) <> "" And Trim(txtCantidadHoras.Text) <> "" And dgvBeneficiarios.Rows.Count > 1 And Trim(txtProveedor.Text) <> "") Then

                Dim objCap As New ClsCapacitaciones

                With objCap
                    .fecha_ = dtpFecha.Value
                    .Nombre_ = txtNombre.Text
                    .cantidadHoras_ = txtCantidadHoras.Text
                    .proveedor_ = txtProveedor.Text
                End With

                If objCap.RegistrarNuevaCapacitacion() = 1 Then
                    'deshabilitar()
                    btnguardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objCap.CapturarCapacitacion()
                    Dim row As DataRow = dt.Rows(0)

                    txtCodigo.Text = CStr(row("codigo"))
                    Dim objDetCap As New ClsDetalleCapacitaciones
                    For index As Integer = 0 To dgvBeneficiarios.Rows.Count - 2
                        With objDetCap
                            .codigoCapacitacion_ = txtCodigo.Text
                            .codigoEmpleado_ = dgvBeneficiarios.Rows(index).Cells(1).Value()
                        End With
                        If objDetCap.RegistrarNuevoDetalleCapacitacion() = 0 Then
                            MsgBox("Error al querer insertar el detalle de capacitación.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrada la capacitacion con éxito.", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al querer ingresar la capacitación.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            sinDobleEspacio(txtNombre.Text)
            sinDobleEspacio(txtProveedor.Text)
            If (Trim(txtCodigo.Text) <> "" And Trim(txtNombre.Text) <> "" And Trim(txtCantidadHoras.Text) <> "" And dgvBeneficiarios.Rows.Count > 1 And Trim(txtProveedor.Text) <> "") Then

                Dim objCap As New ClsCapacitaciones
                Dim objDetCap As New ClsDetalleCapacitaciones

                With objCap
                    .codigo_ = Convert.ToInt64(txtCodigo.Text)
                    .fecha_ = dtpFecha.Value
                    .Nombre_ = txtNombre.Text
                    .cantidadHoras_ = txtCantidadHoras.Text
                    .proveedor_ = txtProveedor.Text
                End With

                If objCap.ModificarCapacitaciones() = 1 Then
                    For index As Integer = 0 To codigoDetalleCapacitacion.Count - 1
                        'ELIMINA LOS DETALLE DE CAPACITACIONES
                        objDetCap.codigo_ = Convert.ToInt64(codigoDetalleCapacitacion(index))
                        If objDetCap.EliminarDetalleCapacitacion() <> 1 Then
                            MsgBox("Error al querer modificar el detalle de capacitación.", MsgBoxStyle.Critical)
                        End If
                    Next
                    codigoDetalleCapacitacion.Clear()
                    For index As Integer = 0 To dgvBeneficiarios.Rows.Count - 2
                        If dgvBeneficiarios.Rows(index).Cells(0).Value() = "" Then
                            'agrega
                            With objDetCap
                                .codigoCapacitacion_ = Convert.ToInt64(txtCodigo.Text)
                                .codigoEmpleado_ = dgvBeneficiarios.Rows(index).Cells(1).Value()
                            End With
                            If objDetCap.RegistrarNuevoDetalleCapacitacion() = 0 Then
                                MsgBox("Error al querer modificar el detalle de capacitación.", MsgBoxStyle.Critical)
                            End If
                        Else
                            'actualiza 
                            With objDetCap
                                .codigo_ = dgvBeneficiarios.Rows(index).Cells(0).Value()
                                .codigoCapacitacion_ = Convert.ToInt64(txtCodigo.Text)
                                .codigoEmpleado_ = dgvBeneficiarios.Rows(index).Cells(1).Value()
                            End With
                            If objDetCap.ModificarDetalleCapacitacion() = 0 Then
                                MsgBox("Error al querer modificar el detalle de capacitación.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    MsgBox("Actualizada la capacitación con éxito.", MsgBoxStyle.Information)
                    btnguardar.Enabled = False
                    btnmodificar.Enabled = True
                End If
                'ACTUALIZAR LISTADO DE CAPACITACIONES
                M_BuscarCapacitaciones.SeleccionarCapacitaciones()
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Function GridAExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add 'crea el libro de excel 
            exHoja = exLibro.Worksheets.Add() 'cuenta filas y columnas
            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1 'titulo en negritas
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            'alineacion al centro
            exHoja.Columns.AutoFit() 'autoajuste de la columna
            exHoja.Columns.HorizontalAlignment = 2
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(dgvBeneficiarios)
    End Sub
End Class