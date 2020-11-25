Public Class M_ReporteriaTalentoHumano
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub dtpFechaInicial_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaInicial.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFechaInicial.Format = DateTimePickerFormat.Short
                dtpFechaInicial.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFechaInicial.Format = DateTimePickerFormat.Custom
                dtpFechaInicial.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpFechaFinal_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaFinal.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFechaFinal.Format = DateTimePickerFormat.Short
                dtpFechaFinal.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFechaFinal.Format = DateTimePickerFormat.Custom
                dtpFechaFinal.CustomFormat = " "
        End Select

    End Sub

    Private Sub cmbxReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxReporte.SelectedIndexChanged
        If cmbxReporte.SelectedIndex = 0 Then
            'Reporte Personal Activo
            lblEmpleado.Visible = False
            lblFechaFinal.Visible = False
            lblFechaInicial.Visible = False
            lblHorario.Visible = False

            txtnombreEmpleado.Visible = False
            dtpFechaFinal.Visible = False
            dtpFechaInicial.Visible = False
            cmbxHorario.Visible = False

        ElseIf cmbxReporte.SelectedIndex = 1 Then
            'Reporte Personal Inactivo
            lblEmpleado.Visible = False
            lblFechaFinal.Visible = False
            lblFechaInicial.Visible = False
            lblHorario.Visible = False

            txtnombreEmpleado.Visible = False
            dtpFechaFinal.Visible = False
            dtpFechaInicial.Visible = False
            cmbxHorario.Visible = False
        ElseIf cmbxReporte.SelectedIndex = 2 Then
            'Reporte Capacitaciones
            lblEmpleado.Visible = False
            lblFechaFinal.Visible = True
            lblFechaInicial.Visible = True
            lblHorario.Visible = False

            txtnombreEmpleado.Visible = False
            dtpFechaFinal.Visible = True
            dtpFechaInicial.Visible = True
            cmbxHorario.Visible = False

            dtpFechaInicial.Value = Date.Now
            dtpFechaFinal.Value = Date.Now
        ElseIf cmbxReporte.SelectedIndex = 3 Then
            'Reporte Permisos
            lblEmpleado.Visible = True
            lblFechaFinal.Visible = True
            lblFechaInicial.Visible = True
            lblHorario.Visible = False

            txtnombreEmpleado.Visible = True
            dtpFechaFinal.Visible = True
            dtpFechaInicial.Visible = True
            cmbxHorario.Visible = False

            txtnombreEmpleado.Clear()

            dtpFechaInicial.Format = DateTimePickerFormat.Custom
            dtpFechaInicial.CustomFormat = " "

            dtpFechaFinal.Format = DateTimePickerFormat.Custom
            dtpFechaFinal.CustomFormat = " "

            dtpFechaFinal.Value = Date.Now
        ElseIf cmbxReporte.SelectedIndex = 4 Then
            'Reporte Horarios de Trabajo
            lblEmpleado.Visible = False
            lblFechaFinal.Visible = False
            lblFechaInicial.Visible = False
            lblHorario.Visible = True

            txtnombreEmpleado.Visible = False
            dtpFechaFinal.Visible = False
            dtpFechaInicial.Visible = False
            cmbxHorario.Visible = True

            llenarHorarios()
        End If
    End Sub

    Public Sub llenarHorarios()
        'llenar el combo box Horarios de Trabajo
        Try
            Dim objHora As New ClsHorarios
            Dim dt As New DataTable
            dt = objHora.SeleccionarHorario

            cmbxHorario.DataSource = dt
            cmbxHorario.DisplayMember = "nombre"
            cmbxHorario.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub txtnombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtnombreEmpleado.Click
        M_ListadoEmpleados.lblform.Text = "M_ReporteriaTalentoHumano"
        M_ListadoEmpleados.ShowDialog()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If cmbxReporte.SelectedIndex = 0 Then
            'Reporte Personal Activo
            Dim objReporte As New M_CryReportePersonalActivo
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = objReporte
        ElseIf cmbxReporte.SelectedIndex = 1 Then
            'Reporte Personal Inactivo
            Dim objReporte As New M_CryReportePersonalInactivo
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = objReporte
        ElseIf cmbxReporte.SelectedIndex = 2 Then
            'Reporte Capacitaciones
            Dim objReporte As New M_CryReporteCapacitaciones
            If Trim(dtpFechaInicial.Text) <> "" And Trim(dtpFechaFinal.Text) <> "" Then
                objReporte.SetParameterValue("@fechaInicial", dtpFechaInicial.Value)
                objReporte.SetParameterValue("@fechaFinal", dtpFechaFinal.Value)
            Else
                MsgBox("Debe ingresar la fecha inicial y la fecha final.", MsgBoxStyle.Information, "Validación.")
                Exit Sub
            End If
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = objReporte
        ElseIf cmbxReporte.SelectedIndex = 3 Then
            'Reporte Permisos
            Dim objReporte As New M_CryReportePermisosXEmpleadoYFechas
            If Trim(txtnombreEmpleado.Text) <> "" Then
                objReporte.SetParameterValue("@codigoEmpleado", Convert.ToInt64(lblcodeEmpleado.Text))
            Else
                MsgBox("Vacio empleado")
                objReporte.SetParameterValue("@codigoEmpleado", Nothing)
            End If
            If Trim(dtpFechaInicial.Text) <> "" And Trim(dtpFechaFinal.Text) <> "" Then
                objReporte.SetParameterValue("@fechaInicial", dtpFechaInicial.Value)
                objReporte.SetParameterValue("@fechaFinal", dtpFechaFinal.Value)
            Else
                MsgBox("Vacio fechas")
                objReporte.SetParameterValue("@fechaInicial", Nothing)
                objReporte.SetParameterValue("@fechaFinal", Nothing)
            End If
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = objReporte
        ElseIf cmbxReporte.SelectedIndex = 4 Then
            'Reporte Horarios de Trabajo
            Dim objReporte As New M_CryReporteHorarioTrabajo
            objReporte.SetParameterValue("@codigoHorario", Convert.ToInt64(cmbxHorario.SelectedValue))
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = objReporte
        End If
    End Sub
End Class