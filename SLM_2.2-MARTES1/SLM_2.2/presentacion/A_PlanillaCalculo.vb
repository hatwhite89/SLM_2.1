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
            Dim sueldo, resultado, dias As Double
            Dim dev, ihss, retISR, embargos, prestamocof, adelanto, prestamorap, retOptica, retPrestamo, ImpVecinal, rapVolu, retRap As Double

            ihss = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(6).Value)
            retISR = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(7).Value)
            embargos = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(8).Value)
            prestamocof = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(9).Value)
            adelanto = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(10).Value)
            prestamorap = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(11).Value)
            retOptica = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(12).Value)
            retPrestamo = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(13).Value)
            ImpVecinal = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(14).Value)
            rapVolu = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(15).Value)
            retRap = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(16).Value)
            sueldo = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(1).Value)
            dev = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(5).Value)


            If e.ColumnIndex = 4 Then ' DIAS FALTADOS

                If chkDiasFaltados.Checked = False Then

                    dias = Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(4).Value)
                    resultado = (sueldo / 30) * dias
                    dtData.Rows(e.RowIndex).Cells(4).Value = Math.Round(resultado, 2)

                End If

                sumaDiasFaltados()
            ElseIf e.ColumnIndex = 2 Then 'Adicional

                sumaAdicional()

            ElseIf e.ColumnIndex = 3 Then 'TIEMPO EXTRA

                Dim dte As New DataTable
                Dim rowe As DataRow
                Dim valor As Double
                Dim horaExtra() As String
                Dim hora, min, total, horariotrabajo As Integer
                Dim empleado As New ClsEmpleados
                empleado.codigo_ = Convert.ToInt32(dtData.Rows(e.RowIndex).Cells(18).Value)
                dte = empleado.HorasTrabajo
                rowe = dte.Rows(0)
                horariotrabajo = Convert.ToInt32(rowe("Horas"))

                'Conversion de horas a minutos
                horaExtra = Split(dtData.Rows(e.RowIndex).Cells(3).Value, ":")
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
                dtData.Rows(e.RowIndex).Cells(3).Value = Math.Round(valor, 2)

                sumaHExtra()

            ElseIf e.ColumnIndex = 7 Then 'Retencion ISR

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap - retISR

                SumaRetISR()

            ElseIf e.ColumnIndex = 8 Then 'embargos

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaEmbargos()
            ElseIf e.ColumnIndex = 9 Then 'prestamo cofinter

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaCofinter()
            ElseIf e.ColumnIndex = 10 Then 'adelantos

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaAdelantos()
            ElseIf e.ColumnIndex = 11 Then 'prestamo rap

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaPrestamoRap()
            ElseIf e.ColumnIndex = 12 Then 'Retencion optica

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaRetOptica()
            ElseIf e.ColumnIndex = 13 Then 'Retencion prestamo

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaRetPrestamo()
            ElseIf e.ColumnIndex = 14 Then 'Imp. Veci.

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaImpVecinal()
            ElseIf e.ColumnIndex = 15 Then 'RapVol

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaRapVoluntario()
            ElseIf e.ColumnIndex = 16 Then 'Retencion RAP

                dtData.Rows(e.RowIndex).Cells(17).Value = dev - ihss - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

                SumaRetRAP()

            End If



            'ACTUALIZAR SUELDO DEVENGADO
            Dim textra, dfalta, devengado, Adicional As Double

            textra = dtData.Rows(e.RowIndex).Cells(3).Value
            dfalta = dtData.Rows(e.RowIndex).Cells(4).Value
            Adicional = dtData.Rows(e.RowIndex).Cells(2).Value

            dtData.Rows(e.RowIndex).Cells(5).Value = (Convert.ToDouble(dtData.Rows(e.RowIndex).Cells(1).Value) + textra + Adicional) - dfalta

            devengado = dtData.Rows(e.RowIndex).Cells(5).Value
            ActualizarSumaDevengado()

            'dtData.Rows(e.RowIndex).Cells(17).Value = devengado - retISR - embargos - prestamocof - adelanto - prestamorap - retOptica - retPrestamo - ImpVecinal - rapVolu - retRap

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub txtIHSS_TextChanged(sender As Object, e As EventArgs) Handles txtIHSS.TextChanged

        Try
            Dim devengado As Double
            For a = 0 To dtData.Rows.Count - 1

                devengado = dtData.Rows(a).Cells(5).Value
                dtData.Rows(a).Cells(6).Value = txtIHSS.Text
                dtData.Rows(a).Cells(17).Value = Math.Round(devengado - Convert.ToDouble(txtIHSS.Text), 2)

            Next

            Dim totalihss As Double

            For j = 0 To dtData.Rows.Count - 2

                totalihss = Convert.ToDouble(dtData.Rows(j).Cells(6).Value) + totalihss

            Next

            dtData.Rows(dtData.Rows.Count - 1).Cells(6).Value = Math.Round(totalihss, 2)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Try

            Dim empleado As New ClsEmpleados

            For a = 0 To dtData.Rows.Count - 2

                Dim dt As New DataTable
                Dim row As DataRow
                Dim nombre As String = dtData.Rows(a).Cells(0).Value
                Dim salario As String = dtData.Rows(a).Cells(17).Value

                empleado.codigo_ = Convert.ToInt32(dtData.Rows(a).Cells(18).Value)
                dt = empleado.BuscarDatosEmpleadoPorCodigo
                row = dt.Rows(0)

                A_VistaPlanillaExcel.dtPlanilla.Rows.Add(New String() {row("nIdentidad"), row("cuentaBancaria"), nombre, salario})

            Next

            A_VistaPlanillaExcel.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtData_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtData.CellValueChanged
        Try
            If e.ColumnIndex = 17 Then
                ActualizarSumaNeto()
            End If

        Catch ex As Exception

        End Try

    End Sub


    Sub sumaAdicional()

        Dim Total As Double
        Dim Col As Integer = 2
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub
    Sub sumaHExtra()

        Dim Total As Double
        Dim Col As Integer = 3
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(3).Value = Math.Round(Total, 2)

    End Sub



    Sub sumaDiasFaltados()
        Dim Total As Double
        Dim Col As Integer = 4
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(4).Value = Math.Round(Total, 2)

    End Sub

    Sub ActualizarSumaDevengado()

        Dim Total As Double
        Dim Col As Integer = 5
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(5).Value = Math.Round(Total, 2)

    End Sub



    Sub ActualizarSumaNeto()

        Dim Total As Double
        Dim Col As Integer = 17
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(17).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaRetISR()

        Dim Total As Double
        Dim Col As Integer = 7
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaEmbargos()

        Dim Total As Double
        Dim Col As Integer = 8
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaCofinter()

        Dim Total As Double
        Dim Col As Integer = 9
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaAdelantos()

        Dim Total As Double
        Dim Col As Integer = 10
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaPrestamoRap()

        Dim Total As Double
        Dim Col As Integer = 11
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub


    Sub SumaRetOptica()

        Dim Total As Double
        Dim Col As Integer = 12
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaRetPrestamo()

        Dim Total As Double
        Dim Col As Integer = 13
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaImpVecinal()

        Dim Total As Double
        Dim Col As Integer = 14
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaRapVoluntario()

        Dim Total As Double
        Dim Col As Integer = 15
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Sub SumaRetRAP()

        Dim Total As Double
        Dim Col As Integer = 16
        For j = 0 To dtData.Rows.Count - 2
            Total += Convert.ToDouble(dtData.Rows(j).Cells(Col).Value)
        Next

        dtData.Rows(dtData.Rows.Count - 1).Cells(Col).Value = Math.Round(Total, 2)

    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        Try
            E_frmInventario.GridAExcel(dtData)
        Catch ex As Exception

        End Try
    End Sub

End Class