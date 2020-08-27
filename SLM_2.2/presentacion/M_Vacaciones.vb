Public Class M_Vacaciones

    Private Sub txtJefeDepto_Click(sender As Object, e As EventArgs) Handles txtJefeDepto.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Depto"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtTalentoHumano_Click(sender As Object, e As EventArgs) Handles txtTalentoHumano.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Humano"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtSupervisor_Click(sender As Object, e As EventArgs) Handles txtSupervisor.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Supervisor"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtEmpleado_Click(sender As Object, e As EventArgs) Handles txtEmpleado.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Empleado"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub limpiar()
        lblEstado.Text = ""
        txtcodigo.Text = ""
        txtEmpleado.Text = ""
        dtpFechaInasistencia.ResetText()
        rbtnNo.Checked = True
        rtxtMotivoInasistencia.Text = ""
        rtxtcubrira.Text = ""
        rtxtObservaciones.Text = ""
        txtFirmaEmpleado.Text = ""
        txtSupervisor.Text = ""
        txtJefeDepto.Text = ""
        txtTalentoHumano.Text = ""
        lblcodeEmpleado.Text = ""
        lblcodeSupervisor.Text = ""
        lblcodeJefeDepto.Text = ""
        lblcodeSupervisor.Text = ""

        txtnombreB.Text = ""

        dtpFechaInasistencia.Enabled = True
        dtpfecha.Enabled = True
        rbtnNo.Enabled = True
        rbtnSi.Enabled = True
        rtxtMotivoInasistencia.ReadOnly = False
        rtxtcubrira.ReadOnly = False
        rtxtObservaciones.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True

        dtpfecha.Format = DateTimePickerFormat.Custom
        dtpfecha.CustomFormat = " "
    End Sub
    Private Sub dtpEntradaTarde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpfecha.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpfecha.Format = DateTimePickerFormat.Time
                dtpfecha.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpfecha.Format = DateTimePickerFormat.Custom
                dtpfecha.CustomFormat = " "
        End Select

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub sinDobleEspacio(ByRef cadena As String)
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        cadena = RTrim(texto)
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If (Trim(txtEmpleado.Text) <> "" And Trim(txtTalentoHumano.Text) <> "" And Trim(txtJefeDepto.Text) <> "" And Trim(txtSupervisor.Text) <> "" And Trim(rtxtMotivoInasistencia.Text) <> "") Then
                Dim objVac As New ClsVacaciones
                With objVac
                    .codigoEmpleado_ = lblcodeEmpleado.Text
                    .fechaInasistencia_ = dtpFechaInasistencia.Value
                    .motivoInasistencia_ = rtxtMotivoInasistencia.Text
                    .notifico_ = rbtnSi.Checked
                    'validacion fecha nula 
                    If Trim(dtpfecha.Text) <> "" Then
                        .fecha_ = dtpfecha.Value
                    Else
                        .fecha_ = Nothing
                    End If
                    .cubrira_ = rtxtcubrira.Text
                    .observaciones_ = rtxtObservaciones.Text
                    .codigoSupervisor_ = lblcodeSupervisor.Text
                    .codigoJefeDepto_ = lblcodeJefeDepto.Text
                    .codigoTalentoHumano_ = lblcodeTalHum.Text
                End With
                If objVac.RegistrarNuevoVacaciones() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information)
                    seleccionarVacaciones()
                    deshabilitar()
                Else
                    MsgBox("Error al querer registrar la solicitud.", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            If (txtcodigo.Text <> "" And Trim(txtEmpleado.Text) <> "" And Trim(txtTalentoHumano.Text) <> "" And Trim(txtJefeDepto.Text) <> "" And Trim(txtSupervisor.Text) <> "" And Trim(rtxtMotivoInasistencia.Text) <> "") Then
                Dim objVac As New ClsVacaciones
                With objVac
                    .codigo_ = txtcodigo.Text
                    .codigoEmpleado_ = lblcodeEmpleado.Text
                    .fechaInasistencia_ = dtpFechaInasistencia.Value
                    .motivoInasistencia_ = rtxtMotivoInasistencia.Text
                    .notifico_ = rbtnSi.Checked
                    'validacion fecha nula 
                    If Trim(dtpfecha.Text) <> "" Then
                        .fecha_ = dtpfecha.Value
                    Else
                        .fecha_ = Nothing
                    End If
                    .cubrira_ = rtxtcubrira.Text
                    .observaciones_ = rtxtObservaciones.Text
                    .codigoSupervisor_ = lblcodeSupervisor.Text
                    .codigoJefeDepto_ = lblcodeJefeDepto.Text
                    .codigoTalentoHumano_ = lblcodeTalHum.Text
                End With
                If objVac.ModificarVacaciones() = 1 Then
                    MsgBox("Actualizado correctamente.", MsgBoxStyle.Information)
                    seleccionarVacaciones()
                    deshabilitar()
                Else
                    MsgBox("Error al querer registrar la solicitud.", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub seleccionarVacaciones()
        Try
            Dim objVac As New ClsVacaciones
            Dim dv As DataView = objVac.SeleccionarVacaciones.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objVac As New ClsVacaciones
            With objVac
                .nombre_ = txtnombreB.Text
            End With
            Dim dv As DataView = objVac.BuscarVacacionesNombre.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub deshabilitar()

        lblEstado.Text = "Deshabilitado"
        dtpFechaInasistencia.Enabled = False
        dtpfecha.Enabled = False
        rbtnNo.Enabled = False
        rbtnSi.Enabled = False
        rtxtMotivoInasistencia.ReadOnly = True
        rtxtcubrira.ReadOnly = True
        rtxtObservaciones.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub M_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarVacaciones()
        alternarColoFilasDatagridview(dgbtabla)
        Me.dgbtabla.Columns("codigoSupervisor").Visible = False
        Me.dgbtabla.Columns("codigoJefeDepto").Visible = False
        Me.dgbtabla.Columns("codigoTalentoHumano").Visible = False
    End Sub

    Private Sub lblcodeTalHum_TextChanged(sender As Object, e As EventArgs) Handles lblcodeTalHum.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeTalHum.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtTalentoHumano.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodeEmpleado_TextChanged(sender As Object, e As EventArgs) Handles lblcodeEmpleado.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeEmpleado.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtEmpleado.Text = CStr(row("nombreCompleto"))
            txtFirmaEmpleado.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodeSupervisor_TextChanged(sender As Object, e As EventArgs) Handles lblcodeSupervisor.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeSupervisor.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtSupervisor.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodeJefeDepto_TextChanged(sender As Object, e As EventArgs) Handles lblcodeJefeDepto.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeJefeDepto.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtJefeDepto.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                limpiar()

                txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                lblcodeEmpleado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                dtpFechaInasistencia.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                rtxtMotivoInasistencia.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                If Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value() Then
                    rbtnSi.Checked = True
                Else
                    rbtnNo.Checked = True
                End If
                'valida que no sea nulo para poner la hora ingresada.
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value().ToString) <> "" Then
                    dtpfecha.Format = DateTimePickerFormat.Short
                    dtpfecha.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value().ToString
                End If
                'If IsDBNull(Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()) = False Then
                '    dtpfecha.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
                'Else
                '    dtpfecha.Format = DateTimePickerFormat.Custom
                '    dtpfecha.CustomFormat = " "
                'End If
                rtxtcubrira.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                rtxtObservaciones.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                lblcodeSupervisor.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value()
                lblcodeJefeDepto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value()
                lblcodeTalHum.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(10).Value()

                Dim objEmp As New ClsEmpleados
                With objEmp
                    .codigo_ = lblcodeTalHum.Text
                End With
                Dim dt As New DataTable
                dt = objEmp.BuscarEmpleadosPorCodigo()
                Dim row As DataRow = dt.Rows(0)
                txtTalentoHumano.Text = CStr(row("nombreCompleto"))

                btnmodificar.Enabled = True
                btnguardar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class