Public Class frmAsientos

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

            'habilitar celdas para edicion de DEBE y HABER
            'dtDetalleAsiento.Columns("Debe").ReadOnly = True
            'dtDetalleAsiento.Columns("Haber").ReadOnly = True


            If txtNro.Text = "" Then

                MsgBox("El registro de hará bajo el periodo contable vigente.")
                txtNro.Enabled = True



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




            Else
                btnCrear.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Enabled = False


                Dim Detalle As New ClsDetalleAsiento

                With Detalle

                    .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)

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
            '  MsgBox("Error:" + ex.Message)
        End Try


        Try
            'Suma de columna Debe
            Dim Total As Single
            'Dim Col As Integer = 2
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total += Val(row.Cells(3).Value)
            Next
            txtTotalDebe.Text = Total.ToString

            'Suma de columna Haber
            Dim Total2 As Single
            'Dim Col2 As Integer = 3
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total2 += Val(row.Cells(4).Value)
            Next
            txtTotalHaber.Text = Total2.ToString
        Catch ex As Exception
            MsgBox("suma" + ex.Message)
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
                Dim dt As New DataTable
                Dim row As DataRow

                With asiento

                    .Cod_Periodo = 1
                    .Descrip = txtTexto.Text
                    .Fecha_ = dtpFecha.Value
                    .Campo_Llave = 0

                    If .registrarAsiento() = 1 Then
                        dt = .capturarCodAsiento()
                        row = dt.Rows(0)

                        'mostrar informacion de asiento guardado reciente
                        lblCodAsiento.Text = row("cod_asiento")
                        txtNro.Text = row("cod_asiento")
                        txtTexto.Text = row("descripcion")
                        dtpFecha.Value = row("fecha")

                        'registro de detalle de asiento 

                        With dasiento

                            For i = 0 To dtDetalleAsiento.Rows.Count - 1

                                '.Cod_Detalle = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(0).Value)
                                .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                                .Cuenta_ = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(1).Value)
                                .Debe_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(3).Value)
                                .Haber_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(4).Value)
                                .registrarDetalleAsiento()

                            Next

                        End With

                    End If




                    Try
                        .Cod_Periodo = 1
                        .Descrip = txtTexto.Text
                        .Fecha_ = dtpFecha.Value
                        .Campo_Llave = Convert.ToInt32(lblCodAsiento.Text)
                        .Cod_ = Convert.ToInt32(lblCodAsiento.Text)

                        .ActualizarAsiento()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    MsgBox("Se registro exitosamente.")
                    Limpiar()
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtDetalleAsiento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetalleAsiento.CellDoubleClick

        Try

            If e.ColumnIndex = 1 Then

                A_ListarCuentas.lblForm.Text = "asientos"
                A_ListarCuentas.ShowDialog()


            ElseIf e.ColumnIndex = 5 Then
                Try
                    Dim n As String = MsgBox("¿Desea eliminar la cuenta del asiento?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dtDetalleAsiento.Rows.Remove(dtDetalleAsiento.Rows(e.RowIndex.ToString))

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
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
            Dim Total As Single
            Dim Col As Integer = 2
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total += Val(row.Cells(2).Value)
            Next
            txtTotalDebe.Text = Total.ToString

        ElseIf e.ColumnIndex = 4 Then

            'Suma de columna Haber
            Dim Total2 As Single
            Dim Col2 As Integer = 3
            For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                Total2 += Val(row.Cells(3).Value)
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
                    .ActualizarAsiento()
                End With

                With asientod

                    For i = 0 To dtDetalleAsiento.Rows.Count - 1

                        .Cod_Detalle = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(0).Value)
                        .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)
                        .Cuenta_ = Convert.ToInt32(dtDetalleAsiento.Rows(i).Cells(1).Value)
                        .Debe_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(3).Value)
                        .Haber_ = Convert.ToDouble(dtDetalleAsiento.Rows(i).Cells(4).Value)

                        .modificarDetalleAsiento()

                    Next

                End With
            End If

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

End Class