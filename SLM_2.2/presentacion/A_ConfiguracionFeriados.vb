

Public Class A_ConfiguracionFeriados


    Private Sub A_ConfiguracionFeriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            btnGuardar.Enabled = True

            cargardata()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim n As String = MsgBox("¿Desea guardar el registro de fechas?", MsgBoxStyle.YesNo, "Validación")

        If n = vbYes Then
            Try

                Dim feriado As New ClsFeriados

                Dim fechaInicio As Date = dtpDesde.Value
                Dim fechaFin As Date = dtpHasta.Value
                Dim fechaControl As Date = fechaInicio
                Dim fechasEntreSemana As New List(Of Date)


                If rbtFecha.Checked = True Then 'Fecha Especifica

                    With feriado

                        .CodBreve_ = txtCodBreve.Text
                        .Descrip_ = txtDescripcion.Text
                        .Fecha_ = dtpFecha.Value
                        If .registrarNuevoFeriado() = 1 Then
                            MsgBox("Se registro el feriado")
                        End If
                        Limpiar()
                        limpiargrid()
                        cargardata()
                    End With

                ElseIf rbtRango.Checked = True Then 'Rango de fechas


                    'Bucle que recorre fechas'
                    Do While (fechaControl <= fechaFin)
                        'Comprobamos que la fecha actual sea un día entre semana'
                        If Weekday(fechaControl) < 6 Then
                            fechasEntreSemana.Add(fechaControl)

                        End If
                        fechaControl = fechaControl.AddDays(1)
                        With feriado

                            .CodBreve_ = txtCodBreve.Text
                            .Descrip_ = txtDescripcion.Text
                            .Fecha_ = fechaControl
                            .registrarNuevoFeriado()

                        End With

                    Loop

                    MsgBox("Se registraron las fechas")
                    Limpiar()
                    limpiargrid()
                    cargardata()

                ElseIf rbtDiaEspecifico.Checked = True Then

                    'Bucle que recorre fechas'
                    Do While (fechaControl <= fechaFin)
                        'Comprobamos que la fecha actual sea un día entre semana'

                        If cbxDia.Text = "Domingo" Then

                            If fechaControl.DayOfWeek = DayOfWeek.Sunday Then
                                'MsgBox(fechaControl)
                                With feriado

                                    .CodBreve_ = txtCodBreve.Text
                                    .Descrip_ = txtDescripcion.Text
                                    .Fecha_ = fechaControl
                                    .registrarNuevoFeriado()

                                End With
                                fechasEntreSemana.Add(fechaControl)

                            End If

                            fechaControl = fechaControl.AddDays(1)


                        ElseIf cbxDia.Text = "Sábado" Then

                            If fechaControl.DayOfWeek = DayOfWeek.Saturday Then
                                'MsgBox(fechaControl) Imprime fechas
                                With feriado

                                    .CodBreve_ = txtCodBreve.Text
                                    .Descrip_ = txtDescripcion.Text
                                    .Fecha_ = fechaControl
                                    .registrarNuevoFeriado()

                                End With
                                fechasEntreSemana.Add(fechaControl)

                            End If

                            fechaControl = fechaControl.AddDays(1)

                        End If



                    Loop
                    MsgBox("Se registraron las fechas para el día indicado.")
                    Limpiar()
                    limpiargrid()
                    cargardata()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Sub Limpiar()
        txtCodBreve.Clear()
        txtDescripcion.Clear()
        txtCodigo.Clear()

        rbtRango.Checked = False
        rbtFecha.Checked = False
        rbtDiaEspecifico.Checked = False

        dtpDesde.Value = DateTime.Now
        dtpHasta.Value = DateTime.Now
        dtpFecha.Value = DateTime.Now

        cbxDia.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        dtpFecha.Enabled = False
    End Sub

    Private Sub rbtDiaEspecifico_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaEspecifico.CheckedChanged

        If rbtDiaEspecifico.Checked = True Then

            cbxDia.Enabled = True
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
        Else
            cbxDia.Enabled = False
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Sub cargardata()

        Dim dt As New DataTable
        Dim row As DataRow
        Dim feriado As New ClsFeriados

        dt = feriado.listarFeriados

        For a = 0 To dt.Rows.Count - 1
            row = dt.Rows(a)
            dtFeriados.Rows.Add(New String() {(row("codFeriado")), CStr(row("codbreve")), row("descrip"), row("fecha")})
        Next



    End Sub

    Sub limpiargrid()

        dtFeriados.Rows.Clear()

    End Sub

    Private Sub rbtRango_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRango.CheckedChanged

        If rbtRango.Checked = True Then
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
        Else
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False

        End If


    End Sub

    Private Sub rbtFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFecha.CheckedChanged
        If rbtFecha.Checked = True Then
            dtpFecha.Enabled = True
        Else
            dtpFecha.Enabled = False
        End If
    End Sub

    Private Sub dtFeriados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFeriados.CellDoubleClick

        Dim n As String = MsgBox("¿Desea cargar el registro de fecha?", MsgBoxStyle.YesNo, "Validación")

        If n = vbYes Then
            Try

                txtCodigo.Text = dtFeriados.Rows(e.RowIndex).Cells(0).Value
                txtCodBreve.Text = dtFeriados.Rows(e.RowIndex).Cells(1).Value
                txtDescripcion.Text = dtFeriados.Rows(e.RowIndex).Cells(2).Value
                dtpFecha.Value = dtFeriados.Rows(e.RowIndex).Cells(3).Value
                dtpFecha.Enabled = True
                btnCrear.Enabled = True
                btnGuardar.Enabled = False
                btnModificar.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim n As String = MsgBox("¿Desea modificar el registro de fecha?", MsgBoxStyle.YesNo, "Validación")

        If n = vbYes Then
            Try

                Dim feriadom As New ClsFeriados

                With feriadom

                    .Cod = Convert.ToInt32(txtCodigo.Text)
                    .CodBreve_ = txtCodBreve.Text
                    .Descrip_ = txtDescripcion.Text
                    .Fecha_ = dtpFecha.Value

                    If .modificarFeriado = 1 Then
                        MsgBox("Se modificó el registro.")
                    End If


                End With
                Limpiar()
                limpiargrid()
                cargardata()

                btnCrear.Enabled = False
                btnGuardar.Enabled = True
                btnModificar.Enabled = False

            Catch ex As Exception
                MsgBox("Hubo un error. Detalle: " + ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim n As String = MsgBox("¿Desealimpiar y crear un nuevo registro?", MsgBoxStyle.YesNo, "Validación")

        If n = vbYes Then
            btnCrear.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            Limpiar()
        End If
    End Sub
End Class