Public Class A_PlanillaCalculo
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            A_BuscarPlanilla.lblform.Text = "A_PlanillaCalculo"
            A_BuscarPlanilla.Show()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtData_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtData.CellEndEdit

        Try
            Dim sueldo, resultado, dias, horas As Double
            Dim ihss, retISR, embargos, prestamocof, adelanto, prestamorap, retOptica, retPrestamo, ImpVecinal, rapVolu, retRap


            retISR = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(6).Value)
            embargos = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(7).Value)
            prestamocof = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(8).Value)
            adelanto = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(9).Value)
            prestamorap = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(10).Value)
            retOptica = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(11).Value)
            retPrestamo = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(12).Value)
            ImpVecinal = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(13).Value)
            rapVolu = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(14).Value)
            retRap = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(15).Value)
            sueldo = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(1).Value)


            If e.ColumnIndex = 3 Then ' DIAS FALTADOS

                If chkDiasFaltados.Checked = False Then

                    dias = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(3).Value)
                    resultado = (sueldo / 30) * dias
                    dtData.Rows(e.RowIndex).Cells(3).Value = Math.Round(resultado, 2)

                End If

            ElseIf e.ColumnIndex = 2 Then 'TIEMPO EXTRA

                Dim dte As New DataTable
                Dim rowe As DataRow
                Dim valor As Double
                Dim horaExtra() As String
                Dim hora, min, total, horariotrabajo As Integer
                Dim empleado As New ClsEmpleados
                empleado.codigo_ = Convert.ToInt32(dtData.Rows(e.RowIndex).Cells(17).Value)
                dte = empleado.HorasTrabajo
                rowe = dte.Rows(0)
                horariotrabajo = Convert.ToInt32(rowe("Horas"))

                'Conversion de horas a minutos
                horaExtra = Split(dtData.Rows(e.RowIndex).Cells(2).Value, ":")
                For i = 0 To UBound(horaExtra)
                    'horas a minutos
                    If i = 0 Then
                        hora = horaExtra(0)
                        hora = hora * 60
                    End If
                    'minutos
                    If i = 1 Then
                        min = horaExtra(1)
                    End If
                Next

                'total de minutos
                total = hora + min
                'Formula
                valor = ((((sueldo / 30) / horariotrabajo) / 60) * 1.25) * total
                dtData.Rows(e.RowIndex).Cells(2).Value = Math.Round(valor, 2)

            End If

            'ACTUALIZAR SUELDO DEVENGADO
            Dim textra, dfalta, devengado As Double

            textra = dtData.Rows(e.RowIndex).Cells(2).Value
            dfalta = dtData.Rows(e.RowIndex).Cells(3).Value

            dtData.Rows(e.RowIndex).Cells(4).Value = (Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(1).Value) + textra) - dfalta

            devengado = dtData.Rows(e.RowIndex).Cells(4).Value
            dtData.Rows(e.RowIndex).Cells(16).Value = devengado - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap


        Catch ex As Exception
            'MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub txtIHSS_TextChanged(sender As Object, e As EventArgs) Handles txtIHSS.TextChanged

        Try
            Dim devengado As Double
            For a = 0 To dtData.Rows.Count - 1
                devengado = dtData.Rows(a).Cells(4).Value
                dtData.Rows(a).Cells(5).Value = txtIHSS.Text
                dtData.Rows(a).Cells(16).Value = Math.Round(devengado - Convert.ToDouble(txtIHSS.Text), 2)
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Try
            Dim empleado As New ClsEmpleados

            For a = 0 To dtData.Rows.Count - 1

                Dim dt As New DataTable
                Dim row As DataRow
                Dim nombre As String = dtData.Rows(a).Cells(0).Value
                Dim salario As String = dtData.Rows(a).Cells(16).Value

                empleado.codigo_ = Convert.ToInt32(dtData.Rows(a).Cells(17).Value)
                dt = empleado.BuscarDatosEmpleadoPorCodigo
                row = dt.Rows(0)

                A_VistaPlanillaExcel.dtPlanilla.Rows.Add(New String() {row("nIdentidad"), row("cuentaBancaria"), nombre, salario})

            Next

            A_VistaPlanillaExcel.Show()

        Catch ex As Exception

        End Try

    End Sub
End Class