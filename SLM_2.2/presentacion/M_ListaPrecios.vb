﻿Public Class M_ListaPrecios

    Dim codigoDetallePriceList As ArrayList = New ArrayList()

    Public Sub limpiar()
        Try
            txtcodigo.Text = ""
            txtcodigoBreve.Text = ""
            txtDescripcion.Text = ""
            txtcodigoTermino.Clear()
            txtrtn.Clear()
            txtPorcentaje.Clear()
            rbtnConvenioNo.Checked = True
            rbtnPagoNo.Checked = True

            dgbtabla.Rows.Clear()

            txtcodigoBreve.ReadOnly = False
            txtDescripcion.ReadOnly = False
            txtcodigoTermino.ReadOnly = False
            txtPorcentaje.ReadOnly = False


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
                    .tipoConvenio_ = rbtnConvenioSi.Checked
                    If rbtnConvenioSi.Checked Then
                        .codigoTerminoPago_ = lblcodeT.Text
                        If Trim(txtrtn.Text) <> "" Then
                            .rtn_ = txtrtn.Text
                        Else
                            MsgBox("Debe ingresar el rtn.", MsgBoxStyle.Information, "Validación.")
                            Exit Sub
                        End If
                        If rbtnPagoSi.Checked Then
                            .solicitaPago_ = rbtnPagoSi.Checked
                            If Trim(txtPorcentaje.Text) <> "" Then
                                .porcentaje_ = Integer.Parse(txtPorcentaje.Text)
                            Else
                                MsgBox("Debe ingresar el porcentaje a pagar de la factura.", MsgBoxStyle.Information, "Validación.")
                                Exit Sub
                            End If
                        End If
                    End If
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
                            .codigoDescuento_ = dgbtabla.Rows(index).Cells(4).Value()
                        End With
                        If objDetPrice.RegistrarNuevoDetalleListaPrecios() = 0 Then
                            MsgBox("Error al querer insertar el detalle de la lista de precios.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrada la lista de precios correctamente.", MsgBoxStyle.Information)
                    M_ListadoDePrecios.seleccionarListaPrecios()
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
                    .tipoConvenio_ = rbtnConvenioSi.Checked
                    If rbtnConvenioSi.Checked Then
                        .codigoTerminoPago_ = lblcodeT.Text
                        If Trim(txtrtn.Text) <> "" Then
                            .rtn_ = txtrtn.Text
                        Else
                            MsgBox("Debe ingresar el rtn.", MsgBoxStyle.Information, "Validación.")
                            Exit Sub
                        End If
                        If rbtnPagoSi.Checked Then
                            .solicitaPago_ = rbtnPagoSi.Checked
                            If Trim(txtPorcentaje.Text) <> "" Then
                                .porcentaje_ = Integer.Parse(txtPorcentaje.Text)
                            Else
                                MsgBox("Debe ingresar el porcentaje a pagar de la factura.", MsgBoxStyle.Information, "Validación.")
                                Exit Sub
                            End If
                        End If
                    End If
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
                        If dgbtabla.Rows(index).Cells(0).Value() = "" Then
                            'agrega
                            With objDetPrice
                                .codigoListaPrecios_ = txtcodigo.Text
                                .codigoGrupoItem_ = dgbtabla.Rows(index).Cells(2).Value()
                                .codigoDescuento_ = dgbtabla.Rows(index).Cells(4).Value()
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
                                .codigoDescuento_ = dgbtabla.Rows(index).Cells(4).Value()
                            End With
                            If objDetPrice.ModificarDetalleListaPrecios() = 0 Then
                                MsgBox("Error al querer modificar el detalle de la lista de precios.")
                            End If
                        End If
                    Next
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)
                    M_ListadoDePrecios.seleccionarListaPrecios()
                Else
                    MsgBox("Error al querer ingresar la lista de precios.", MsgBoxStyle.Critical)
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
            'btnmodificar.Enabled = False
        Catch ex As Exception

        End Try
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 2 Then
                    E_DetalleExamenes.lblFila.Text = e.RowIndex.ToString
                    E_DetalleExamenes.lblform.Text = "M_ListaPrecios"
                    E_DetalleExamenes.Show()
                ElseIf e.ColumnIndex = 5 Then
                    M_Descuentos.lblform.Text = "M_ListaPrecios"
                    M_Descuentos.lblFila.Text = e.RowIndex.ToString
                    M_Descuentos.Show()
                ElseIf e.ColumnIndex = 6 And dgbtabla.Rows(e.RowIndex).Cells(0).Value() = "" Then
                    Dim n As String = MsgBox("¿Desea eliminarlo de la lista de precios?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                    End If
                ElseIf e.ColumnIndex = 6 And Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value() <> "" Then
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

    Private Sub rbtnSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnConvenioSi.CheckedChanged
        'habilito el termino de pago a ingresar
        Try
            If rbtnConvenioSi.Checked Then
                lblrtn.Visible = True
                txtrtn.Visible = True
                rbtnConvenioSi.Checked = True
                lblTerminoPago.Visible = True
                btnbuscarTermino.Visible = True
                txtcodigoTermino.Visible = True
                txtDescripcionTermino.Visible = True
                lblPorcentaje.Visible = True
                txtPorcentaje.Visible = True
                lblSolicitaEfectivo.Visible = True
                rbtnPagoSi.Visible = True
                rbtnPagoNo.Visible = True
                rbtnPagoSi.Checked = True
            ElseIf rbtnConvenioNo.Checked Then
                lblrtn.Visible = False
                txtrtn.Visible = False
                rbtnConvenioNo.Checked = True
                lblTerminoPago.Visible = False
                btnbuscarTermino.Visible = False
                txtcodigoTermino.Visible = False
                txtDescripcionTermino.Visible = False
                lblPorcentaje.Visible = False
                txtPorcentaje.Visible = False
                lblSolicitaEfectivo.Visible = False
                rbtnPagoSi.Visible = False
                rbtnPagoNo.Visible = False
            End If
        Catch ex As Exception
            'Magnolia
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub rbtnNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnConvenioNo.CheckedChanged
        'habilito el termino de pago a ingresar
        Try
            If rbtnConvenioSi.Checked Then
                lblrtn.Visible = True
                txtrtn.Visible = True
                lblTerminoPago.Visible = True
                btnbuscarTermino.Visible = True
                txtcodigoTermino.Visible = True
                txtDescripcionTermino.Visible = True
                lblPorcentaje.Visible = True
                txtPorcentaje.Visible = True
                lblSolicitaEfectivo.Visible = True
                rbtnPagoSi.Visible = True
                rbtnPagoNo.Visible = True
                rbtnPagoSi.Checked = True
            ElseIf rbtnConvenioNo.Checked Then
                lblrtn.Visible = False
                txtrtn.Visible = False
                lblTerminoPago.Visible = False
                btnbuscarTermino.Visible = False
                txtcodigoTermino.Visible = False
                txtDescripcionTermino.Visible = False
                lblPorcentaje.Visible = False
                txtPorcentaje.Visible = False
                lblSolicitaEfectivo.Visible = False
                rbtnPagoSi.Visible = False
                rbtnPagoNo.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnbuscarTermino_Click(sender As Object, e As EventArgs) Handles btnbuscarTermino.Click
        M_TerminosPago.lblform.Text = "M_ListaPrecios"
        M_TerminosPago.Show()
    End Sub

    Private Sub txtcodigoTermino_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTermino.TextChanged
        If (txtcodigoTermino.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigoTerminoPago_ = txtcodigoTermino.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarTerminoPagoCode()
                Dim row As DataRow = dt.Rows(0)
                txtDescripcionTermino.Text = CStr(row("descripcion"))
                lblcodeT.Text = CStr(row("codigo"))
                txtcodigoTermino.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTermino.BackColor = Color.Red
                txtDescripcionTermino.Text = ""
                lblcodeT.Text = ""
            End Try
        Else
            txtcodigoTermino.Text = ""
            txtDescripcionTermino.Text = ""
            lblcodeT.Text = ""
            txtcodigoTermino.BackColor = Color.White
        End If
    End Sub
    Private Sub lblcodeT_TextChanged(sender As Object, e As EventArgs) Handles lblcodeT.TextChanged
        If (lblcodeT.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigo_ = lblcodeT.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarTerminoPagoNumero()
                Dim row As DataRow = dt.Rows(0)
                txtDescripcionTermino.Text = CStr(row("descripcion"))
                txtcodigoTermino.Text = CStr(row("codigoTerminoPago"))
                txtcodigoTermino.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTermino.BackColor = Color.Red
                txtDescripcionTermino.Text = ""
                lblcodeT.Text = ""
            End Try
        Else
            txtcodigoTermino.Text = ""
            txtDescripcionTermino.Text = ""
            lblcodeT.Text = ""
            txtcodigoTermino.BackColor = Color.White
        End If
    End Sub

    Private Sub rbtnEfectivoSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPagoSi.CheckedChanged
        'HABILITAR LA OPCION DE INGRESAR PORCENTAJE
        If rbtnPagoSi.Checked Then
            lblPorcentaje.Visible = True
            txtPorcentaje.Visible = True
        ElseIf rbtnPagoNo.Checked Then
            lblPorcentaje.Visible = False
            txtPorcentaje.Visible = False
        End If
    End Sub

    Private Sub rbtnEfectivoNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPagoNo.CheckedChanged
        'HABILITAR LA OPCION DE INGRESAR PORCENTAJE
        If rbtnPagoSi.Checked Then
            lblPorcentaje.Visible = True
            txtPorcentaje.Visible = True
        ElseIf rbtnPagoNo.Checked Then
            lblPorcentaje.Visible = False
            txtPorcentaje.Visible = False
        End If
    End Sub
    'SOLO NUMEROS
    Private Sub txtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        M_ImportarListasPrecios.Show()
    End Sub
End Class