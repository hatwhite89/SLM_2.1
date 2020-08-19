Public Class E_HojaTrabajo
    Private Sub E_HojaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgvHojaTrab)
        txtHora.Text = Date.Now.ToLongTimeString
        txtFecha.Text = Date.Today
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
End Class