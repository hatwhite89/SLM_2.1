Imports Microsoft.Office.Interop.Excel

Public Class A_ConfiguracionFeriados
    Private Sub A_ConfiguracionFeriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            btnGuardar.Enabled = True


            cargardata()

        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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


            ElseIf rbtDiaEspecifico.Checked = True Then

                'Bucle que recorre fechas'
                Do While (fechaControl <= fechaFin)
                    'Comprobamos que la fecha actual sea un día entre semana'

                    If cbxDia.Text = "Domingo" Then

                        If fechaControl.DayOfWeek = DayOfWeek.Sunday Then
                            MsgBox(fechaControl)
                            fechasEntreSemana.Add(fechaControl)

                        End If

                        fechaControl = fechaControl.AddDays(1)

                    ElseIf cbxDia.Text = "Sábado" Then

                        If fechaControl.DayOfWeek = DayOfWeek.Saturday Then
                            'MsgBox(fechaControl) Imprime fechas
                            fechasEntreSemana.Add(fechaControl)

                        End If

                        fechaControl = fechaControl.AddDays(1)
                        With feriado

                            .CodBreve_ = txtCodBreve.Text
                            .Descrip_ = txtDescripcion.Text
                            .Fecha_ = fechaControl
                            .registrarNuevoFeriado()

                        End With


                    End If

                Loop
                MsgBox("Se registraron las fechas para el día indicado.")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub Limpiar()
        txtCodBreve.Clear()
        txtDescripcion.Clear()

        rbtRango.Checked = False
        rbtFecha.Checked = False
        rbtDiaEspecifico.Checked = False

        dtpDesde.Value = DateTime.Now
        dtpHasta.Value = DateTime.Now
        dtpFecha.Value = DateTime.Now

    End Sub

    Private Sub rbtDiaEspecifico_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaEspecifico.CheckedChanged

        cbxDia.Enabled = True

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Sub cargardata()

        Dim feriado As New ClsFeriados

        Dim dt As DataTable
        Dim row As DataRow
        Dim a As Integer = 0

        dt = feriado.listarFeriados

        For a = 0 To dt.Rows.Count - 1

            row = dt.rows(a)




        Next







    End Sub
End Class