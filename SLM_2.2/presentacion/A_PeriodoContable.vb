Public Class A_PeriodoContable

    Dim periodo As New ClsPeriodoContable
    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click

        Try

            If dtpInicio.Value = dtpFinal.Value Or dtpFinal.Value < dtpInicio.Value Or dtpInicio.Value > dtpFinal.Value Then

                MsgBox("El rango de fecha es incorrecto.")

            Else

                With periodo

                    .Fecha_Inicio = dtpInicio.Value
                    .Fecha_Final = dtpFinal.Value
                    .Estad_o = 1

                    If .registrarPeriodoContable = 1 Then
                        MsgBox("El período se ha guardado exitosamente.")
                    End If

                End With

            End If

        Catch ex As Exception

        End Try

    End Sub
End Class