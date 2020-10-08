Public Class E_HojaTrabajo
    'Dim dv As DataView
    Public ds As New DataSet  'Orden de los examenes por grupo o laboratorio
    Dim celda, fila As Integer 'capturar columna y fila para agregar plantilla
    Private Sub E_HojaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        alternarColoFilasDatagridview(dgvHojaTrab)
        txtHora.Text = Date.Now.ToLongTimeString
        txtFecha.Text = Date.Today

        dgvHojaTrab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        'CARGA DE PLANTILLAS :::::::::::::::::::::::::::::::::::::::::...

        Dim plantilla As New ClsPlantillaResultado

        Dim dt As New DataTable

        dt = plantilla.listarPlantillas

        cbxPlantillas.DataSource = dt
        cbxPlantillas.DisplayMember = "simbolo"
        cbxPlantillas.SelectedIndex = 0

        '...::::::::::::::::::::::::::::::::::::::::::::::::::::::::::...

    End Sub
    Private Sub dgvHojaTrab_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHojaTrab.CellEndEdit
        'Actualizar el detalle de orden de trabajo 
        If e.ColumnIndex > 4 Then
            Try
                If (Trim(dgvHojaTrab.Rows(e.RowIndex).Cells(e.ColumnIndex).Value()) <> "") Then

                    Dim objOrdDet As New ClsOrdenTrabajoDetalle
                    With objOrdDet
                        .cod_orden_trabajo_ = dgvHojaTrab.Rows(e.RowIndex).Cells(0).Value()
                        .resultado_ = dgvHojaTrab.Rows(e.RowIndex).Cells(e.ColumnIndex).Value()
                        .nombreItemDetalle_ = dgvHojaTrab.Columns.Item(e.ColumnIndex).Name
                        .estado_ = "Procesado"
                    End With
                    If objOrdDet.ModificarOrdenTrabajoDetalle2() <> 1 Then
                        'En caso que no exista el detalle de orden de trabajo entonces le asigna un valor nulo o vacio
                        dgvHojaTrab.Rows(e.RowIndex).Cells(e.ColumnIndex).Value() = ""
                    End If
                End If
            Catch ex As Exception
                Try
                    dgvHojaTrab.Rows(e.RowIndex).Cells(e.ColumnIndex).Value() = ""
                Catch ex2 As Exception

                End Try
            End Try
        End If
    End Sub

    Private Sub dgvHojaTrab_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHojaTrab.CellClick
        Try
            If e.ColumnIndex > 4 Then
                'Mostrar valores de la fila seleccionada
                txtOrden.Text = dgvHojaTrab.Rows(e.RowIndex).Cells(0).Value()
                txtPaciente.Text = dgvHojaTrab.Rows(e.RowIndex).Cells(1).Value()
                txtParametro.Text = dgvHojaTrab.Columns.Item(e.ColumnIndex).Name
                txtValorActual.Text = dgvHojaTrab.Rows(e.RowIndex).Cells(e.ColumnIndex).Value()
                celda = Convert.ToInt32(dgvHojaTrab.CurrentCell.ColumnIndex.ToString)
                fila = Convert.ToInt32(dgvHojaTrab.CurrentCell.RowIndex.ToString)

                'buscar valores referencia 
                If (Trim(txtParametro.Text) <> "") Then
                    'Try
                    '    Dim objCat As New ClsCategoria
                    '    With objCat
                    '        .codigoCategoria_ = txtParametro.Text
                    '    End With
                    '    Dim dt As New DataTable
                    '    dt = objCat.BuscarCategoriaCode()
                    '    Dim row As DataRow = dt.Rows(0)
                    '    txtnombreCategoria.Text = CStr(row("descripcion"))
                    '    lblcodeCategoria.Text = CStr(row("codigo"))
                    '    txtcodigoCategoria.BackColor = Color.White
                    'Catch ex As Exception
                    '    txtcodigoCategoria.BackColor = Color.Red
                    '    lblcodeCategoria.Text = ""
                    '    txtnombreCategoria.Text = ""
                    'End Try
                End If

            Else
                txtOrden.Text = dgvHojaTrab.Rows(e.RowIndex).Cells(0).Value()
                txtPaciente.Text = dgvHojaTrab.Rows(e.RowIndex).Cells(1).Value()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizarVista_Click(sender As Object, e As EventArgs) Handles btnActualizarVista.Click
        Try
            'If dgvHojaTrab.Rows.Count > 1 Then
            ds.Tables(0).Rows.Clear()
            ' End If

            Dim pendienteMuestra, noProcesado, enProceso, procesado, validado As String

            If cbxPendMuestra.Checked Then
                pendienteMuestra = "Pendiente Muestra"
            Else
                pendienteMuestra = Nothing
            End If
            If cbxNoProcesado.Checked Then
                noProcesado = "No Procesado"
            Else
                noProcesado = Nothing
            End If
            If cbxEnProceso.Checked Then
                enProceso = "En Proceso"
            Else
                enProceso = Nothing
            End If
            If cbxProcesado.Checked Then
                procesado = "Procesado"
            Else
                procesado = Nothing
            End If
            If cbxValidado.Checked Then
                validado = "Validado"
            Else
                validado = Nothing
            End If

            Dim edad As String
            Dim dt As New DataTable
            Dim row As DataRow


            Dim colColl As DataColumnCollection = ds.Tables("HojaTrabajo").Columns

            'orden de trabajo
            Dim objOrdTrab As New ClsOrdenDeTrabajo
            'Dim dt As New DataTable ' ordenes de trabajo
            Dim rowO As DataRow ' fila orden de trabajo

            'detalle orden de trabajo
            Dim objOrdTrabDet As New ClsOrdenTrabajoDetalle
            Dim dtDet As New DataTable ' detalle orden de trabajo
            Dim rowDet As DataRow ' fila detalle orden de trabajo

            'parametros de busqueda
            objOrdTrab.codigoSubArea_ = Convert.ToInt64(lblCodeSubArea.Text)
            objOrdTrab.codigoSucursal_ = Convert.ToInt64(lblCodeSucursal.Text)
            Dim dv As DataView = objOrdTrab.ActualizarListadoHojaDeTrabajo(pendienteMuestra, noProcesado, enProceso, procesado, validado).DefaultView

            'dv.RowFilter = String.Format("codigoSucursal Like '%{0}%'", txtsucursal.Text)
            'dv.RowFilter = "codigoSubArea=" & Integer.Parse(lblCodeSubArea.Text)
            dt = dv.ToTable
            For index As Integer = 0 To dt.Rows.Count - 1
                rowO = dt.Rows(index)
                edad = CalcularEdad(Convert.ToDateTime(rowO("fechaNacimiento")))

                row = ds.Tables("HojaTrabajo").Rows.Add

                row.Item(0) = CStr(rowO("cod_orden_trabajo"))
                If rowO("estadoFactura") = "0" Then
                    row.Item(1) = CStr(rowO("paciente"))
                    row.Item(colColl.IndexOf("Estado")) = CStr(rowO("estado"))
                Else
                    row.Item(1) = CStr(rowO("paciente") & " (ANULADA)")
                    row.Item(colColl.IndexOf("Estado")) = "ANULADA"
                End If
                row.Item(2) = edad
                row.Item(3) = CStr(rowO("genero"))
                row.Item(4) = CStr(rowO("medico"))

                'LLENADO DETALLE ORDEN DE TRABAJO
                objOrdTrabDet.cod_orden_trabajo_ = Convert.ToInt64(rowO("cod_orden_trabajo"))
                dtDet = objOrdTrabDet.BuscarOrdenTrabajoDetalle
                For index2 As Integer = 0 To dtDet.Rows.Count - 1
                    rowDet = dtDet.Rows(index2)
                    'marcar los * 

                    If IsDBNull(rowDet("resultado")) = True Then
                        row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = "*"
                    ElseIf CStr(rowDet("resultado")) = "0" Then
                        row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = "*"
                    Else
                        row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = CStr(rowDet("resultado"))
                    End If
                Next
            Next

            'le asigno la tabla
            dgvHojaTrab.DataSource = ds.Tables(0)

            If rbtnNombrePaciente.Checked Then
                dgvHojaTrab.Sort(dgvHojaTrab.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            ElseIf rbtnNroOrdTrab.Checked Then
                dgvHojaTrab.Sort(dgvHojaTrab.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            ElseIf rbtnCortesia.Checked Then

            ElseIf rbtnUrgentes.Checked Then

            End If

        Catch ex As Exception
            MsgBox("Actualizar listado: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    'Private Sub btnActualizarVista_Click(sender As Object, e As EventArgs) Handles btnActualizarVista.Click
    '    Try
    '        If dgvHojaTrab.Rows.Count > 1 Then
    '            ds.Tables(0).Rows.Clear()
    '        End If
    '        Dim pendienteMuestra, noProcesado, enProceso, procesado, validado As String
    '        If cbxPendMuestra.Checked Then
    '            pendienteMuestra = "Pendiente Muestra"
    '        Else
    '            pendienteMuestra = Nothing
    '        End If
    '        If cbxNoProcesado.Checked Then
    '            noProcesado = "No Procesado"
    '        Else
    '            noProcesado = Nothing
    '        End If
    '        If cbxEnProceso.Checked Then
    '            enProceso = "En Proceso"
    '        Else
    '            enProceso = Nothing
    '        End If
    '        If cbxProcesado.Checked Then
    '            procesado = "Procesado"
    '        Else
    '            procesado = Nothing
    '        End If
    '        If cbxValidado.Checked Then
    '            validado = "Validado"
    '        Else
    '            validado = Nothing
    '        End If

    '        Dim edad As String
    '        Dim dt As New DataTable
    '        Dim row As DataRow


    '        Dim colColl As DataColumnCollection = ds.Tables("HojaTrabajo").Columns


    '        'orden de trabajo
    '        Dim objOrdTrab As New ClsOrdenDeTrabajo
    '        'Dim dt As New DataTable ' ordenes de trabajo
    '        Dim rowO As DataRow ' fila orden de trabajo

    '        'detalle orden de trabajo
    '        Dim objOrdTrabDet As New ClsOrdenTrabajoDetalle
    '        Dim dtDet As New DataTable ' detalle orden de trabajo
    '        Dim rowDet As DataRow ' fila detalle orden de trabajo

    '        'parametros de busqueda
    '        objOrdTrab.codigoSubArea_ = Convert.ToInt64(lblCodeSubArea.Text)
    '        objOrdTrab.codigoSucursal_ = Convert.ToInt64(lblCodeSucursal.Text)
    '        'Dim dv As DataView = objOrdTrab.ActualizarListadoHojaDeTrabajo(pendienteMuestra, noProcesado, enProceso, procesado, validado).DefaultView
    '        dt = objOrdTrab.ActualizarListadoHojaDeTrabajo(pendienteMuestra, noProcesado, enProceso, procesado, validado)
    '        'ds.Tables(0).DefaultView.RowFilter = "codigoSubArea LIKE '*" & lblCodeSubArea.Text & "*'"
    '        'dv.RowFilter = String.Format("codigoSubArea Like '%{0}%'", lblCodeSubArea.Text)
    '        For index As Integer = 0 To dt.Rows.Count - 1
    '            rowO = dt.Rows(index)
    '            edad = CalcularEdad(Convert.ToDateTime(rowO("fechaNacimiento")))

    '            row = ds.Tables("HojaTrabajo").Rows.Add

    '            row.Item(0) = CStr(rowO("cod_orden_trabajo"))
    '            If rowO("estadoFactura") = "0" Then
    '                row.Item(1) = CStr(rowO("paciente"))
    '                row.Item(colColl.IndexOf("Estado")) = CStr(rowO("estado"))
    '            Else
    '                row.Item(1) = CStr(rowO("paciente") & " (ANULADA)")
    '                row.Item(colColl.IndexOf("Estado")) = "ANULADA"
    '            End If
    '            row.Item(2) = edad
    '            row.Item(3) = CStr(rowO("genero"))
    '            row.Item(4) = CStr(rowO("medico"))

    '            'LLENADO DETALLE ORDEN DE TRABAJO
    '            objOrdTrabDet.cod_orden_trabajo_ = Convert.ToInt64(rowO("cod_orden_trabajo"))
    '            dtDet = objOrdTrabDet.BuscarOrdenTrabajoDetalle
    '            For index2 As Integer = 0 To dtDet.Rows.Count - 1
    '                rowDet = dtDet.Rows(index2)
    '                'marcar los * 

    '                If IsDBNull(rowDet("resultado")) = True Then
    '                    row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = "*"
    '                ElseIf CStr(rowDet("resultado")) = "0" Then
    '                    row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = "*"
    '                Else
    '                    row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = CStr(rowDet("resultado"))
    '                End If
    '            Next
    '        Next

    '        'le asigno la tabla
    '        dgvHojaTrab.DataSource = ds.Tables(0)

    '        If rbtnNombrePaciente.Checked Then
    '            dgvHojaTrab.Sort(dgvHojaTrab.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    '        ElseIf rbtnNroOrdTrab.Checked Then
    '            dgvHojaTrab.Sort(dgvHojaTrab.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    '        ElseIf rbtnCortesia.Checked Then

    '        ElseIf rbtnUrgentes.Checked Then

    '        End If

    '    Catch ex As Exception
    '        MsgBox("Actualizar listado: " & ex.Message, MsgBoxStyle.Critical)
    '    End Try

    'End Sub

    Private Function CalcularEdad(ByVal fecha As Date) As String
        Dim yr As Integer = DateDiff(DateInterval.Year, fecha, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, fecha, Now)
        Dim day As Integer = DateDiff(DateInterval.Day, fecha, Now)
        Dim edad As String = ""

        If (Now.Month < fecha.Month) Then
            yr -= 1
        ElseIf (Now.Month = fecha.Month And Now.Day < fecha.Day) Then
            yr -= 1
        End If

        If (yr = 0 And month = 1 And Now.Day < fecha.Day) Then
            month -= 1
        End If

        If (yr >= 1) Then
            edad = yr & "a"
        ElseIf (yr = 0 And month > 0) Then
            edad = month & "m"
        Else
            edad = day & "d"
        End If

        'retorna la edad 
        Return edad
    End Function
    Private Sub LlenadoDatos()


    End Sub

    Private Sub btnDetalleResultado_Click(sender As Object, e As EventArgs) Handles btnDetalleResultado.Click
        A_PlantillasDeResultado.Show()
    End Sub

    Private Sub btnValoresRef_Click(sender As Object, e As EventArgs) Handles btnValoresRef.Click
        If txtParametro.Text <> "" Then
            M_ListadoValoresReferencia.lblcodeCateCli.Text = txtParametro.Text
            M_ListadoValoresReferencia.ShowDialog()
        End If
    End Sub

    Private Sub ValidarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidarDatosToolStripMenuItem.Click
        Try
            Dim n As String = MsgBox("¿Desea validar la orden de trabajo?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then
                Dim objOrdTrab As New ClsOrdenDeTrabajo
                With objOrdTrab
                    .cod_orden_trabajo_ = Integer.Parse(txtOrden.Text)
                    .coUsuario_ = Integer.Parse(Form1.lblUserCod.Text)

                    'Procedimiento actualizar orden de trabajo
                    If .ModificarOrdenDeTrabajoEstadoValidado() = 1 Then
                        MsgBox("Validado correctamente.", MsgBoxStyle.Information)
                        Dim colColl As DataColumnCollection = ds.Tables("HojaTrabajo").Columns
                        dgvHojaTrab.Rows(fila).Cells(colColl.IndexOf("Estado")).Value = "Validado"
                        dgvHojaTrab.Rows.Remove(dgvHojaTrab.Rows(fila))
                    Else
                        MsgBox("Error al momento de validar la orden de trabajo.", MsgBoxStyle.Critical, "Validación.")
                    End If

                End With
            End If
        Catch ex As Exception
            MsgBox("Error al validar: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbxPlantillas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPlantillas.SelectedIndexChanged

        Try

            dgvHojaTrab.Rows(fila).Cells(celda).Value = dgvHojaTrab.Rows(fila).Cells(celda).Value + cbxPlantillas.Text

        Catch ex As Exception

        End Try


    End Sub


End Class