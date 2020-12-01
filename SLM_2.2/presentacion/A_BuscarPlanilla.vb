Public Class A_BuscarPlanilla
    Dim objPlan As New ClsPlanilla
    Dim objDetPlan As New ClsDetallePlanilla
    Dim dv As DataView = objPlan.SeleccionarPlanilla.DefaultView
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        A_Planilla.limpiar()
        A_Planilla.ShowDialog()
    End Sub
    Public Sub seleccionarPlanilla()
        dv = objPlan.SeleccionarPlanilla.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub M_BuscarCapacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarPlanilla()

        'CAMBIO DE NOMBRE COLUMNAS
        dgbtabla.Columns("codPlanilla").HeaderText = "Código"
        dgbtabla.Columns("codigoBreve").HeaderText = "Código Breve"
        dgbtabla.Columns("descripcion").HeaderText = "Descripción"
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionB.TextChanged
        dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtDescripcionB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la planilla.", MsgBoxStyle.Exclamation)
            txtDescripcionB.Text = ""
            seleccionarPlanilla()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            'lblform.Text = "A_BuscarPlanilla"
            Dim n As String = ""
            If lblform.Text = "formulario" Then

                'Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea ver la planilla seleccionada?", MsgBoxStyle.YesNo)

                End If
                If n = vbYes Then
                    'Llenado campos de capacitacion
                    A_Planilla.txtCodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    A_Planilla.txtCodigoBreve.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    A_Planilla.txtDescripcion.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()

                    objDetPlan.codPlanilla_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dt = objDetPlan.BuscarDetallePlanilla()
                    For index As Integer = 0 To dt.Rows.Count - 1
                        'Llenado beneficiarios
                        row = dt.Rows(index)
                        Dim adelanto As Double
                        adelanto = (Convert.ToDouble(row("salario")) * 30) / 100
                        A_Planilla.dgvEmpleados.Rows.Add(New String() {CStr(row("codDetPlanilla")), CStr(row("codEmpleado")), CStr(row("nIdentidad")), CStr(row("cuentaBancaria")), CStr(row("nombreCompleto")), CStr(row("salario")), adelanto})
                    Next
                End If
                A_Planilla.btnGuardar.Enabled = False
                A_Planilla.btnModificar.Enabled = True
                A_Planilla.ShowDialog()

            ElseIf lblform.Text = "A_PlanillaCalculo" Then 'Inicio condicion Planilla Calculo


                If A_PlanillaCalculo.dtData.Rows.Count > 1 Then

                    If e.RowIndex >= 0 Then
                        n = MsgBox("¿Desea insertar la planilla seleccionada?", MsgBoxStyle.YesNo)

                    End If
                    If n = vbYes Then
                        A_PlanillaCalculo.dtData.Rows.Clear()
                        A_PlanillaCalculo.txtCodPlanilla.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                        A_PlanillaCalculo.txtDescripcionPlanilla.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()

                        objDetPlan.codPlanilla_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                        dt = objDetPlan.BuscarDetallePlanilla()
                        For index As Integer = 0 To dt.Rows.Count - 1
                            'Llenado beneficiarios
                            row = dt.Rows(index)
                            A_PlanillaCalculo.dtData.Rows.Add(New String() {CStr(row("nombreCompleto")), CStr(row("salario")), "0", "0", "0", CStr(row("salario")), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", CStr(row("salario")), CStr(row("codEmpleado"))})
                        Next

                        'Totalizar
                        TotalSalarios()
                    End If
                Else
                    If e.RowIndex >= 0 Then
                        n = MsgBox("¿Desea insertar la planilla seleccionada?", MsgBoxStyle.YesNo)

                    End If
                    If n = vbYes Then
                        'A_PlanillaCalculo.dtData.Rows.Clear()
                        A_PlanillaCalculo.txtCodPlanilla.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                        A_PlanillaCalculo.txtDescripcionPlanilla.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()

                        objDetPlan.codPlanilla_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                        dt = objDetPlan.BuscarDetallePlanilla()
                        For index As Integer = 0 To dt.Rows.Count - 1
                            'Llenado beneficiarios
                            row = dt.Rows(index)
                            A_PlanillaCalculo.dtData.Rows.Add(New String() {CStr(row("nombreCompleto")), CStr(row("salario")), "0", "0", "0", CStr(row("salario")), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", CStr(row("salario")), CStr(row("codEmpleado"))})
                        Next
                        TotalSalarios()
                    End If
                End If

                Me.Close()
                'fin condicion Planilla Calculo
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
            A_PlanillaCalculo.Show()
        Catch ex As Exception

        End Try
    End Sub

    Sub TotalSalarios()
        Dim totalSalario As Double
        A_PlanillaCalculo.dtData.Rows.Add("TOTALES:", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0")

        For j = 0 To A_PlanillaCalculo.dtData.Rows.Count - 2

            totalSalario = Convert.ToDouble(A_PlanillaCalculo.dtData.Rows(j).Cells(1).Value) + totalSalario

        Next

        A_PlanillaCalculo.dtData.Rows(A_PlanillaCalculo.dtData.Rows.Count - 1).Cells(1).Value = Math.Round(totalSalario, 2)
        A_PlanillaCalculo.dtData.Rows(A_PlanillaCalculo.dtData.Rows.Count - 1).Cells(5).Value = Math.Round(totalSalario, 2)
        A_PlanillaCalculo.dtData.Rows(A_PlanillaCalculo.dtData.Rows.Count - 1).Cells(17).Value = Math.Round(totalSalario, 2)

        Dim style As New DataGridViewCellStyle
        style.Font = New Font("Arial", 9, FontStyle.Bold)
        A_PlanillaCalculo.dtData.Rows(A_PlanillaCalculo.dtData.Rows.Count - 1).DefaultCellStyle = style
        A_PlanillaCalculo.dtData.Rows(A_PlanillaCalculo.dtData.Rows.Count - 1).ReadOnly = True

    End Sub
End Class