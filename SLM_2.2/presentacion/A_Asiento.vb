Public Class frmAsientos
    Dim codigoDetalle As New ArrayList
    Private Sub frmAsientos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dtDetalleAsiento)

            If dtDetalleAsiento.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtDetalleAsiento.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If

            If txtNro.Text = "" Then

                MsgBox("El registro de hará bajo el periodo contable vigente.")
                txtNro.Enabled = False

                'botones
                btnCrear.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Enabled = True

            ElseIf txtNro.Text = lblCodAsiento.Text Then

                btnCrear.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Enabled = False

                Dim Detalle As New ClsDetalleAsiento

                With Detalle

                    .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                    .Origen_ = lblOrigen.Text

                    Dim dt As DataTable
                    Dim row As DataRow

                    dt = .VerDetalleAsiento

                    For index As Integer = 0 To dt.Rows.Count - 1
                        row = dt.Rows(index)

                        Dim cuenta As New ClsCuenta
                        Dim data As DataTable
                        Dim rows As DataRow

                        cuenta.Cuent_a = Convert.ToInt32(row("cuenta"))

                        data = cuenta.Comprobar
                        rows = data.Rows(0)

                        dtDetalleAsiento.Rows.Add(New String() {(row("codDetalle")), (row("cuenta")), CStr(rows("nombre")), CStr(row("debe")), CStr(row("haber")), CStr(row("haber"))})

                    Next

                End With

            Else
                btnCrear.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Enabled = False


                Dim Detalle As New ClsDetalleAsiento

                With Detalle

                    .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                    .Origen_ = lblOrigen.Text

                    Dim dt As DataTable
                    Dim row As DataRow

                    dt = .VerDetalleAsiento

                    For index As Integer = 0 To dt.Rows.Count - 1
                        row = dt.Rows(index)

                        Dim cuenta As New ClsCuenta
                        Dim data As DataTable
                        Dim rows As DataRow

                        cuenta.Cuent_a = Convert.ToInt32(row("cuenta"))

                        data = cuenta.Comprobar
                        rows = data.Rows(0)
                        dtDetalleAsiento.Rows.Add(New String() {(row("codDetalle")), (row("cuenta")), CStr(rows("nombre")), CStr(row("debe")), CStr(row("haber"))})

                    Next

                End With


            End If


        Catch ex As Exception
            'MsgBox("Error:" + ex.Message)
        End Try


        Try
            'Suma de columna Debe
            Dim Total As Double
            'Dim Col As Integer = 2
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total += Val(row.Cells(3).Value)
            Next
            txtTotalDebe.Text = Total.ToString

            'Suma de columna Haber
            Dim Total2 As Double
            'Dim Col2 As Integer = 3
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total2 += Val(row.Cells(4).Value)
            Next
            txtTotalHaber.Text = Total2.ToString
        Catch ex As Exception
            MsgBox("Error al sumar debe o haber." + ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        If lblForm.Text <> "Listado" Then
            Me.Close()
        Else
            A_ListadoAsientos.Show()
            Me.Close()
        End If

    End Sub

    Sub Limpiar()

        txtNro.Clear()
        txtTexto.Clear()
        dtpFecha.ResetText()
        dtDetalleAsiento.Rows.Clear()
        lblCodAsiento.Text = "-"
        txtTotalDebe.Clear()
        txtTotalHaber.Clear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            Dim n As String = MsgBox("¿Desea guardar el nuevo asiento?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then


                Dim asiento As New ClsAsientoContable
                Dim dasiento As New ClsDetalleAsiento
                Dim periodoContable As New ClsPeriodoContable
                Dim dt As New DataTable
                Dim row As DataRow
                Dim codigoAsient As String
                Dim codPeriodo As String


                Dim dtp As New DataTable
                Dim rowp As DataRow
                dtp = periodoContable.periodoContableActivo()
                rowp = dtp.Rows(0)

                codPeriodo = rowp("codPeriodo").ToString


                With asiento
                    .Cod_Periodo = Convert.ToInt32(codPeriodo)
                    .Descrip = txtTexto.Text
                    .Fecha_ = dtpFecha.Value
                    .Campo_Llave = 0
                    .Estado_ = chkAnular.Checked
                    .Origen_ = "manual"

                    codigoAsient = .registrarAsiento()
                    lblCodAsiento.Text = codigoAsient

                    If codigoAsient > 0 Then
                        Dim codigoDetalle As String
                        ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Registro de detalle de asiento 

                        With dasiento

                            For i = 0 To dtDetalleAsiento.Rows.Count - 2

                                '.Cod_Detalle = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(0).Value)
                                .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                                .Cuenta_ = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(1).Value)
                                .Debe_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(3).Value)
                                .Haber_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(4).Value)
                                .Origen_ = "manual"
                                codigoDetalle = .registrarDetalleAsiento()

                                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::GUARDA EN CENTRO DE COSTO

                                If dtDetalleAsiento.Rows(i).Cells(5).Value <> "" Then

                                    Dim cc As New ClsCentoCostos_Asientos

                                    With cc

                                        .id_asientos_ = Integer.Parse(lblCodAsiento.Text)
                                        .id_detalleasiento_ = Integer.Parse(codigoDetalle)
                                        .idcentrocostos_ = Integer.Parse(dtDetalleAsiento.Rows(i).Cells(5).Value)
                                        .codSucursal_ = Integer.Parse(dtDetalleAsiento.Rows(i).Cells(7).Value)
                                        .REGISTRO_ASIENTO_CC()

                                    End With

                                End If
                                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::FIN GUARDA EN CENTRO DE COSTO

                            Next

                        End With

                    End If

                    Try
                        .Cod_Periodo = Convert.ToInt32(codPeriodo)
                        .Descrip = txtTexto.Text
                        .Fecha_ = dtpFecha.Value
                        .Campo_Llave = Convert.ToInt32(lblCodAsiento.Text)
                        .Cod_ = Convert.ToInt32(lblCodAsiento.Text)
                        .Estado_ = chkAnular.Checked
                        .Origen_ = "manual"

                        .ActualizarAsiento()

                        MsgBox("Se registro el asiento contable manual.")
                        Limpiar()
                    Catch ex As Exception
                        'MsgBox("modificacion " + ex.Message)
                    End Try

                End With

            End If
        Catch ex As Exception
            MsgBox("Error al registrar nuevo asiento :" + ex.Message)
        End Try

    End Sub

    Private Sub dtDetalleAsiento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleAsiento.CellDoubleClick

        Try
            lblfila.Text = e.RowIndex
            If e.ColumnIndex = 1 Then

                A_ListarCuentas.lblForm.Text = "asientos"
                A_ListarCuentas.Show()
                A_ListarCuentas.BringToFront()
                A_ListarCuentas.WindowState = WindowState.Normal

            ElseIf e.ColumnIndex = 6 Then

                A_ListadoCentroCosto.lblform.Text = "Asiento"
                A_ListadoCentroCosto.Show()
                A_ListadoCentroCosto.BringToFront()
                A_ListadoCentroCosto.WindowState = WindowState.Normal

            ElseIf e.ColumnIndex = 8 Then

                M_Sucursal.lblform.Text = "Asiento"
                M_Sucursal.Show()
                M_Sucursal.BringToFront()
                M_Sucursal.WindowState = WindowState.Normal

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Validar solo numeros para celdas

    Private Sub dtDetalleAsiento_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtDetalleAsiento.EditingControlShowing

        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros

    End Sub

    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim Celda As DataGridViewCell = Me.dtDetalleAsiento.CurrentCell()

        If Celda.ColumnIndex = 3 Then

            If e.KeyChar = "."c Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If

        ElseIf Celda.ColumnIndex = 4 Then

            If e.KeyChar = "."c Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub dtDetalleAsiento_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleAsiento.CellEndEdit
        If e.ColumnIndex = 3 Then

            'Suma de columna Debe
            Dim Total As Double
            Dim Col As Integer = 3
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total += Val(row.Cells(3).Value)
            Next
            txtTotalDebe.Text = Total.ToString

        ElseIf e.ColumnIndex = 4 Then

            'Suma de columna Haber
            Dim Total2 As Double
            Dim Col2 As Integer = 4
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total2 += Val(row.Cells(4).Value)
            Next
            txtTotalHaber.Text = Total2

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        Try

            Dim n As String = MsgBox("¿Desea modificar la información del asiento?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then
                'Modificar asiento contable
                Dim asientom As New ClsAsientoContable
                Dim asientod As New ClsDetalleAsiento

                With asientom

                    .Cod_ = Convert.ToInt32(lblCodAsiento.Text)
                    .Cod_Periodo = 1
                    .Descrip = txtTexto.Text
                    .Fecha_ = dtpFecha.Value
                    .Campo_Llave = Convert.ToInt32(txtNro.Text)
                    .Estado_ = chkAnular.Checked
                    .Origen_ = "manual"
                    .ActualizarAsiento()

                    If .ActualizarAsiento() = 1 Then

                        'registro o actualizacion detalle de factura

                        For i As Integer = 0 To dtDetalleAsiento.Rows.Count - 2
                            If dtDetalleAsiento.Rows(i).Cells(0).Value() = 0 Then
                                'agrega
                                With asientod
                                    '.Cod_Detalle = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(0).Value)
                                    .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                                    .Cuenta_ = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(1).Value)
                                    .Debe_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(3).Value)
                                    .Haber_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(4).Value)
                                    .Origen_ = "manual"
                                End With

                                If asientod.registrarDetalleAsiento() = 0 Then
                                    MsgBox("Error al querer insertar el detalle de factura.", MsgBoxStyle.Critical)
                                End If
                                MsgBox("fin agrega")
                            Else
                                'actualiza los detalles de asiento

                                With asientod
                                    .Cod_Detalle = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(0).Value)
                                    .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                                    .Cuenta_ = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(1).Value)
                                    .Debe_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(3).Value)
                                    .Haber_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(4).Value)
                                    .Origen_ = "manual"
                                End With

                                If asientod.modificarDetalleAsiento() = 0 Then
                                    MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                                End If

                            End If
                        Next

                        For index As Integer = 0 To codigoDetalle.Count - 1
                            asientod.Cod_Detalle = Convert.ToInt64(codigoDetalle(index))
                            If asientod.EliminarDetalleAsiento() <> 1 Then
                                MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                            End If
                        Next

                        codigoDetalle.Clear()

                        MessageBox.Show("La factura se modifico exitosamente.")
                        Me.Close()
                        A_ListadoAsientos.Show()

                    End If
                End With 'FactCompra

            End If 'desea guardar

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub dtDetalleAsiento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleAsiento.CellClick
        If e.ColumnIndex = 9 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar la cuenta del asiento?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then

                    If dtDetalleAsiento.Rows(e.RowIndex).Cells(0).Value() <> "0" Then

                        codigoDetalle.Add(Me.dtDetalleAsiento.Rows(e.RowIndex).Cells(0).Value())

                    End If

                    dtDetalleAsiento.Rows.Remove(dtDetalleAsiento.Rows(e.RowIndex.ToString))

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

End Class