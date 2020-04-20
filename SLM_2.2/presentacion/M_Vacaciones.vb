Public Class M_Vacaciones

    Private Sub txtJefeDepto_TextChanged(sender As Object, e As EventArgs) Handles txtJefeDepto.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Depto"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtTalentoHumano_TextChanged(sender As Object, e As EventArgs) Handles txtTalentoHumano.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Humano"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtSupervisor_TextChanged(sender As Object, e As EventArgs) Handles txtSupervisor.Click
        If lblEstado.Text <> "Deshabilitado" Then
            M_ListadoEmpleados.lblform.Text = "M_Vacaciones_Supervisor"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtEmpleado.Click
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
            If txtEmpleado.TextLength = 0 Then
                txtEmpleado.BackColor = Color.Red
            Else
                txtEmpleado.BackColor = Color.White
            End If
            'If txtjefeInmediato.TextLength = 0 Then
            '    txtjefeInmediato.BackColor = Color.Red
            'Else
            '    txtjefeInmediato.BackColor = Color.White
            'End If
            If txtTalentoHumano.TextLength = 0 Then
                txtTalentoHumano.BackColor = Color.Red
            Else
                txtTalentoHumano.BackColor = Color.White
            End If
            'If Trim(rtxtAsunto.Text) = "" Then
            '    rtxtAsunto.BackColor = Color.Red
            'Else
            '    sinDobleEspacio(rtxtAsunto.Text)
            '    rtxtAsunto.BackColor = Color.White
            'End If
            If (txtEmpleado.BackColor = Color.White And txtTalentoHumano.BackColor = Color.White And rtxtMotivoInasistencia.BackColor = Color.White) Then
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
            If txtEmpleado.TextLength = 0 Then
                txtEmpleado.BackColor = Color.Red
            Else
                txtEmpleado.BackColor = Color.White
            End If
            'If txtjefeInmediato.TextLength = 0 Then
            '    txtjefeInmediato.BackColor = Color.Red
            'Else
            '    txtjefeInmediato.BackColor = Color.White
            'End If
            If txtTalentoHumano.TextLength = 0 Then
                txtTalentoHumano.BackColor = Color.Red
            Else
                txtTalentoHumano.BackColor = Color.White
            End If
            'If Trim(rtxtAsunto.Text) = "" Then
            '    rtxtAsunto.BackColor = Color.Red
            'Else
            '    sinDobleEspacio(rtxtAsunto.Text)
            '    rtxtAsunto.BackColor = Color.White
            'End If
            If (txtEmpleado.BackColor = Color.White And txtcodigo.Text <> "" And txtTalentoHumano.BackColor = Color.White And rtxtMotivoInasistencia.BackColor = Color.White) Then
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
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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
        Me.dgbtabla.Columns("codigoSupervisor").Visible = False
        Me.dgbtabla.Columns("codigoJefeDepto").Visible = False
        Me.dgbtabla.Columns("codigoTalentoHumano").Visible = False
    End Sub
End Class