Imports Microsoft.Office.Interop.Excel

Public Class A_ConfiguracionFeriados
    Private Sub A_ConfiguracionFeriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            btnGuardar.Enabled = True




        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim feriado As New ClsFeriados


            If rbtFecha.Checked = True Then

                With feriado

                    .CodBreve_ = txtCodBreve.Text
                    .Descrip_ = txtDescripcion.Text
                    .Fecha_ = dtpFecha.Value
                    If .registrarNuevoFeriado() = 1 Then
                        MsgBox("Se registro el feriado")
                    End If
                    Limpiar()

                End With

            ElseIf rbtRango.Checked = True Then

                Dim fechaInicio As Date = dtpDesde.Value
                Dim fechaFin As Date = dtpHasta.Value
                'Declaración de variables que necesitamos para el algoritmo'
                Dim fechaControl As Date = fechaInicio
                Dim fechasEntreSemana As New List(Of Date)
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

            End If






        Catch ex As Exception

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
End Class