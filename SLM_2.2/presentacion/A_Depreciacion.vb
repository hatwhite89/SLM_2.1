Public Class A_Depreciacion

    'Falta Agregar Conexion de Base de datos.Solo calcula en ventana.
    'Falta Agregar Validación en campos.
    'Posible agregar procedimiento para impresion en CrystalReport.

    Private Formato_Decimales As String = "###,###,###,##.00"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtDepreciacion.Rows.Clear()
        dtDepreciacion.DataSource = Nothing
        Calcular_Depreciacion()
    End Sub

    'Calculo de Depreciación
    Sub Calcular_Depreciacion()
        Try

            Dim coste As Decimal = Convert.ToDecimal(txtCosto.Text)
            Dim vr As Decimal = Convert.ToDecimal(txtValorResidual.Text)
            Dim d As Decimal = 0
            Dim vu As Integer = 0
            Dim f As Decimal = 0
            Dim f2 As Decimal = 0
            Dim liDias As Integer
            Dim liMeses As Integer
            Dim liAños As Integer
            Dim variable As String = ""

            liAños = DateDiff(DateInterval.Year, dtpCreacion.Value.Date, dtpFechaCalculo.Value.Date)
            liMeses = DateDiff(DateInterval.Month, dtpCreacion.Value.Date, dtpFechaCalculo.Value.Date)
            liDias = DateDiff(DateInterval.Day, dtpCreacion.Value.Date, dtpFechaCalculo.Value.Date)

            'Seleccion de Depreciacion
            If (rbtAnual.Checked) Then
                vu = liAños + 1
            ElseIf (rbtMensual.Checked) Then
                vu = liMeses + 11
            Else
                vu = liDias
            End If

            For i = 0 To vu - 1

                If (d <= coste) Then
                    d = (coste - vr) / vu
                End If

                If (dtDepreciacion.RowCount = 0) Then
                    f = d
                    f2 = coste - d
                    If (rbtAnual.Checked) Then
                        variable = dtpCreacion.Value.Date.Year.ToString
                    ElseIf (rbtMensual.Checked) Then
                        variable = (dtpCreacion.Value.Date).ToShortDateString.ToString
                    Else
                        variable = (dtpCreacion.Value.Date).ToShortDateString.ToString
                    End If
                    dtDepreciacion.Rows.Add(variable, d.ToString(Formato_Decimales), d.ToString(Formato_Decimales), f2.ToString(Formato_Decimales))
                Else
                    f = d + f
                    f2 = (coste - f)
                    If (rbtAnual.Checked) Then
                        variable = DateAdd(DateInterval.Year, i, dtpCreacion.Value.Date).Year.ToString
                    ElseIf (rbtMensual.Checked) Then
                        variable = DateAdd(DateInterval.Month, i, dtpCreacion.Value.Date).ToShortDateString.ToString
                    Else
                        variable = DateAdd(DateInterval.Day, i, dtpCreacion.Value.Date).ToShortDateString.ToString
                    End If
                    dtDepreciacion.Rows.Add(variable, d.ToString(Formato_Decimales), f.ToString(Formato_Decimales), f2.ToString(Formato_Decimales))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try
    End Sub 'Fin Calculo depreciación
End Class