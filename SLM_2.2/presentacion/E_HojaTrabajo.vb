Public Class E_HojaTrabajo

    Public ds As New DataSet  'Orden de los examenes por grupo o laboratorio
    Private Sub E_HojaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgvHojaTrab)
        txtHora.Text = Date.Now.ToLongTimeString
        txtFecha.Text = Date.Today

        dgvHojaTrab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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
        Dim objSuc As New ClsOrdenDeTrabajo
        Dim dv As DataView = objSuc.ActualizarListadoHojaDeTrabajo(pendienteMuestra, noProcesado, enProceso, procesado, validado).DefaultView

    End Sub

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
End Class