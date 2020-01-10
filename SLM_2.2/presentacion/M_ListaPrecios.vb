﻿Public Class M_ListaPrecios
    Dim codigoDetallePriceList As ArrayList = New ArrayList()

    Public Sub limpiar()
        Try
            txtcodigo.Text = ""
            txtcodigoBreve.Text = ""
            txtDescripcion.Text = ""

            dgbtabla.Rows.Clear()

            txtcodigoBreve.ReadOnly = False
            txtDescripcion.ReadOnly = False

            btnmodificar.Enabled = False
            btnguardar.Enabled = True

            codigoDetallePriceList.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub deshabilitar()

        txtcodigoBreve.ReadOnly = True
        txtDescripcion.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False

    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            txtDescripcion.Text = sinDobleEspacio(txtDescripcion.Text)
            If (Trim(txtDescripcion.Text) <> "" And Trim(txtcodigoBreve.Text) <> "" And dgbtabla.Rows.Count > 1) Then

                Dim objPriceList As New ClsListaPrecios

                With objPriceList
                    .codigoBreve_ = txtcodigoBreve.Text
                    .descripcion_ = txtDescripcion.Text
                End With

                If objPriceList.RegistrarNuevaListaPrecios() = 1 Then
                    'deshabilitar()
                    btnguardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objPriceList.CapturarListaPrecios()
                    Dim row As DataRow = dt.Rows(0)

                    txtcodigo.Text = CStr(row("codigo"))
                    Dim objDetPrice As New ClsDetalleListaPrecios
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        With objDetPrice
                            .codigoListaPrecios_ = txtcodigo.Text
                            .codigoGrupoItem_ = dgbtabla.Rows(index).Cells(2).Value()
                            .codigoDescuento_ = dgbtabla.Rows(index).Cells(3).Value()
                        End With
                        If objDetPrice.RegistrarNuevoDetalleListaPrecios() = 0 Then
                            MsgBox("Error al querer insertar el detalle del recibo.")
                        End If
                    Next
                    MsgBox("Registrado el recibo correctamente.")
                Else
                    MsgBox("Error al querer ingresar el recibo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Public Function validarItem(ByVal codeItem As Integer)
        For index As Integer = 0 To dgbtabla.Rows.Count - 2
            If (dgbtabla.Rows(index).Cells(2).Value() = codeItem) Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            txtDescripcion.Text = sinDobleEspacio(txtDescripcion.Text)
            If (Trim(txtDescripcion.Text) <> "" And Trim(txtcodigoBreve.Text) <> "" And dgbtabla.Rows.Count > 1) Then

                Dim objPriceList As New ClsListaPrecios

                With objPriceList
                    .codigo_ = txtcodigo.Text
                    .codigoBreve_ = txtcodigoBreve.Text
                    .descripcion_ = txtDescripcion.Text
                End With

                If objPriceList.ModificarListaPrecios() = 1 Then

                    Dim objDetPrice As New ClsDetalleListaPrecios
                    For index As Integer = 0 To codigoDetallePriceList.Count - 1
                        objDetPrice.codigo_ = Convert.ToInt64(codigoDetallePriceList(index))
                        If objDetPrice.EliminarDetalleListaPrecios() <> 1 Then
                            MsgBox("Error al querer modificar la lista de precios.")
                        End If
                    Next
                    codigoDetallePriceList.Clear()
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        If dgbtabla.Rows(index).Cells(0).Value() = 0 Then
                            'agrega
                            With objDetPrice
                                .codigoListaPrecios_ = txtcodigo.Text
                                .codigoGrupoItem_ = dgbtabla.Rows(index).Cells(2).Value()
                                .codigoDescuento_ = dgbtabla.Rows(index).Cells(3).Value()
                            End With
                            If objDetPrice.RegistrarNuevoDetalleListaPrecios() = 0 Then
                                MsgBox("Error al querer insertar el detalle de la lista de precios.")
                            End If
                        Else
                            'modificar
                            With objDetPrice
                                .codigo_ = dgbtabla.Rows(index).Cells(0).Value()
                                .codigoListaPrecios_ = txtcodigo.Text
                                .codigoGrupoItem_ = dgbtabla.Rows(index).Cells(2).Value()
                                .codigoDescuento_ = dgbtabla.Rows(index).Cells(3).Value()
                            End With
                            If objDetPrice.ModificarDetalleListaPrecios() = 0 Then
                                MsgBox("Error al querer modificar el detalle de la lista de precios.")
                            End If
                        End If
                    Next
                    MsgBox("Modificado correctamente.")
                Else
                    MsgBox("Error al querer ingresar el recibo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub M_ListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If dgbtabla.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dgbtabla.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If
            btnmodificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 2 Then
                    E_DetalleExamenes.lblFila.Text = e.RowIndex.ToString
                    E_DetalleExamenes.ShowDialog()
                ElseIf e.ColumnIndex = 4 Then
                    M_Descuentos.lblFila.Text = e.RowIndex.ToString
                    M_Descuentos.ShowDialog()
                ElseIf e.ColumnIndex = 5 And dgbtabla.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    Dim n As String = MsgBox("¿Desea eliminarlo de la lista de precios?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 5 And Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    Dim n As String = MsgBox("¿Desea eliminarlo de la lista de precios?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoDetallePriceList.Add(Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value())
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class