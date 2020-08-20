Public Class M_Permisos

    Private Sub txtjefeInmediato_TextChanged(sender As Object, e As EventArgs) Handles txtjefeInmediato.Click
        If dtpFecha.Enabled Then
            M_ListadoEmpleados.lblform.Text = "M_Permisos_JefeInmediato"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtTalentoHumano_TextChanged(sender As Object, e As EventArgs) Handles txtTalentoHumano.Click
        If dtpFecha.Enabled Then
            M_ListadoEmpleados.lblform.Text = "M_Permisos_TalentoHumano"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub txtEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtEmpleado.Click
        If dtpFecha.Enabled Then
            M_ListadoEmpleados.lblform.Text = "M_Permisos_Empleado"
            M_ListadoEmpleados.ShowDialog()
        End If
    End Sub
    Private Sub limpiar()

        txtcodigo.Text = ""
        dtpEntradaTarde.ResetText()
        dtpFecha.ResetText()
        dtpSalidaTarde.ResetText()
        dtpSalidaTemprano.ResetText()
        rtxtAsunto.Text = ""
        txtjefeInmediato.Text = ""
        txtTalentoHumano.Text = ""
        lblcodigoEmpleado.Text = ""
        lblcodeJefeInme.Text = ""
        lblcodeTalentoHumano.Text = ""
        txtEmpleado.Text = ""
        rbtnNo.Checked = True

        dtpEntradaTarde.Enabled = True
        dtpFecha.Enabled = True
        dtpSalidaTarde.Enabled = True
        dtpSalidaTemprano.Enabled = True
        rtxtAsunto.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True

        dtpEntradaTarde.Format = DateTimePickerFormat.Custom
        dtpEntradaTarde.CustomFormat = " "

        dtpSalidaTarde.Format = DateTimePickerFormat.Custom
        dtpSalidaTarde.CustomFormat = " "

        dtpSalidaTemprano.Format = DateTimePickerFormat.Custom
        dtpSalidaTemprano.CustomFormat = " "
    End Sub
    Private Sub dtpEntradaTarde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpEntradaTarde.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpEntradaTarde.Format = DateTimePickerFormat.Time
                dtpEntradaTarde.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpEntradaTarde.Format = DateTimePickerFormat.Custom
                dtpEntradaTarde.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpSalidaTarde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpSalidaTarde.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpSalidaTarde.Format = DateTimePickerFormat.Time
                dtpSalidaTarde.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpSalidaTarde.Format = DateTimePickerFormat.Custom
                dtpSalidaTarde.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpfechaBaja_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpSalidaTemprano.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpSalidaTemprano.Format = DateTimePickerFormat.Time
                dtpSalidaTemprano.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpSalidaTemprano.Format = DateTimePickerFormat.Custom
                dtpSalidaTemprano.CustomFormat = " "
        End Select

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub deshabilitar()

        dtpEntradaTarde.Enabled = False
        dtpFecha.Enabled = False
        dtpSalidaTarde.Enabled = False
        dtpSalidaTemprano.Enabled = False
        rtxtAsunto.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
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
            If txtjefeInmediato.TextLength = 0 Then
                txtjefeInmediato.BackColor = Color.Red
            Else
                txtjefeInmediato.BackColor = Color.White
            End If
            If txtTalentoHumano.TextLength = 0 Then
                txtTalentoHumano.BackColor = Color.Red
            Else
                txtTalentoHumano.BackColor = Color.White
            End If
            If Trim(rtxtAsunto.Text) = "" Then
                rtxtAsunto.BackColor = Color.Red
            Else
                sinDobleEspacio(rtxtAsunto.Text)
                rtxtAsunto.BackColor = Color.White
            End If
            If (txtEmpleado.BackColor = Color.White And txtjefeInmediato.BackColor = Color.White And txtTalentoHumano.BackColor = Color.White And rtxtAsunto.BackColor = Color.White) Then
                Dim objPerm As New ClsPermisos
                With objPerm
                    .fecha_ = dtpFecha.Value
                    If Trim(dtpEntradaTarde.Text) <> "" Then
                        .entradaTarde_ = dtpEntradaTarde.Value
                    Else
                        .entradaTarde_ = Nothing
                    End If
                    If Trim(dtpSalidaTarde.Text) <> "" Then
                        .salidaTarde_ = dtpSalidaTarde.Value
                    Else
                        .salidaTarde_ = Nothing
                    End If
                    If Trim(dtpSalidaTemprano.Text) <> "" Then
                        .salidaTemprano_ = dtpSalidaTemprano.Value
                    Else
                        .salidaTemprano_ = Nothing
                    End If
                    .asunto_ = rtxtAsunto.Text
                    .codigoEmpleado_ = lblcodigoEmpleado.Text
                    .codigoJefeInmediato_ = lblcodeJefeInme.Text
                    .codigoTalentoHumano_ = lblcodeTalentoHumano.Text
                    .goseSueldo_ = rbtnSi.Checked
                End With
                If objPerm.RegistrarNuevoPermiso() = 1 Then
                    MsgBox("Registrado el permiso especial correctamente.", MsgBoxStyle.Information)
                    seleccionarPermisos()
                    deshabilitar()
                Else
                    MsgBox("Error al querer registrar el permiso especial.", MsgBoxStyle.Information)
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
            If txtjefeInmediato.TextLength = 0 Then
                txtjefeInmediato.BackColor = Color.Red
            Else
                txtjefeInmediato.BackColor = Color.White
            End If
            If txtTalentoHumano.TextLength = 0 Then
                txtTalentoHumano.BackColor = Color.Red
            Else
                txtTalentoHumano.BackColor = Color.White
            End If
            If Trim(rtxtAsunto.Text) = "" Then
                rtxtAsunto.BackColor = Color.Red
            Else
                sinDobleEspacio(rtxtAsunto.Text)
                rtxtAsunto.BackColor = Color.White
            End If
            If (txtEmpleado.BackColor = Color.White And txtjefeInmediato.BackColor = Color.White And txtTalentoHumano.BackColor = Color.White And rtxtAsunto.BackColor = Color.White) Then
                Dim objPerm As New ClsPermisos
                With objPerm
                    .codigo_ = txtcodigo.Text
                    .fecha_ = dtpFecha.Value
                    If Trim(dtpEntradaTarde.Text) <> "" Then
                        .entradaTarde_ = dtpEntradaTarde.Value
                    Else
                        .entradaTarde_ = Nothing
                    End If
                    If Trim(dtpSalidaTarde.Text) <> "" Then
                        .salidaTarde_ = dtpSalidaTarde.Value
                    Else
                        .salidaTarde_ = Nothing
                    End If
                    If Trim(dtpSalidaTemprano.Text) <> "" Then
                        .salidaTemprano_ = dtpSalidaTemprano.Value
                    Else
                        .salidaTemprano_ = Nothing
                    End If
                    .asunto_ = rtxtAsunto.Text
                    .codigoEmpleado_ = lblcodigoEmpleado.Text
                    .codigoJefeInmediato_ = lblcodeJefeInme.Text
                    .codigoTalentoHumano_ = lblcodeTalentoHumano.Text
                    .goseSueldo_ = rbtnSi.Checked
                End With

                If objPerm.ModificarPermisos() = 1 Then
                    MsgBox("Actualizado el permiso especial correctamente.", MsgBoxStyle.Information)
                    seleccionarPermisos()
                    deshabilitar()
                Else
                    MsgBox("Error al querer actualizar el permiso especial.", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                limpiar()

                txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                dtpFecha.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                rtxtAsunto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
                lblcodigoEmpleado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                lblcodeJefeInme.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                lblcodeTalentoHumano.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value()
                'valida que no sea nulo para poner la hora ingresada.
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value().ToString) <> "" Then
                    dtpEntradaTarde.Format = DateTimePickerFormat.Time
                    dtpEntradaTarde.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value().ToString
                End If
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value().ToString) <> "" Then
                    dtpSalidaTemprano.Format = DateTimePickerFormat.Time
                    dtpSalidaTemprano.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value().ToString
                End If
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value().ToString) <> "" Then
                    dtpSalidaTarde.Format = DateTimePickerFormat.Time
                    dtpSalidaTarde.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value().ToString
                End If
                If Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value() Then
                    rbtnSi.Checked = True
                Else
                    rbtnNo.Checked = True
                End If

                btnmodificar.Enabled = True
                btnguardar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "factura") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el permiso especial?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    'M_Factura.txtcodigoSede.Text = txtcodigo.Text
                    'M_Factura.txtnombreSede.Text = txtnombre.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub M_Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarPermisos()
        Me.dgbtabla.Columns("codigoTalentoHumano").Visible = False
        Me.dgbtabla.Columns("codigoJefeInmediato").Visible = False
        'Me.dgbtabla.Columns("miercoles").Visible = False
        'Me.dgbtabla.Columns("jueves").Visible = False
        'Me.dgbtabla.Columns("viernes").Visible = False
        'Me.dgbtabla.Columns("sabado").Visible = False
        'Me.dgbtabla.Columns("domingo").Visible = False
        'Me.dgbtabla.Columns("observacion").Visible = False
    End Sub
    Private Sub seleccionarPermisos()
        Try
            Dim objPerm As New ClsPermisos
            Dim dv As DataView = objPerm.SeleccionarPermisos.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            deshabilitar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objPerm As New ClsPermisos
            With objPerm
                .asunto_ = txtnombreB.Text
            End With
            Dim dv As DataView = objPerm.BuscarPermisosNombre.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblcodeJefeInme_TextChanged(sender As Object, e As EventArgs) Handles lblcodeJefeInme.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeJefeInme.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtjefeInmediato.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodeTalentoHumano_TextChanged(sender As Object, e As EventArgs) Handles lblcodeTalentoHumano.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodeTalentoHumano.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtTalentoHumano.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblcodigoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles lblcodigoEmpleado.TextChanged
        Try
            Dim objEmp As New ClsEmpleados
            With objEmp
                .codigo_ = lblcodigoEmpleado.Text
            End With
            Dim dt As New DataTable
            dt = objEmp.BuscarEmpleadosPorCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtEmpleado.Text = CStr(row("nombreCompleto"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtjefeInmediato_TextChanged_1(sender As Object, e As EventArgs) Handles txtjefeInmediato.TextChanged
        If txtjefeInmediato.Text <> "" Then
            txtjefeInmediato.BackColor = Color.White
        End If

    End Sub

    Private Sub txtTalentoHumano_TextChanged_1(sender As Object, e As EventArgs) Handles txtTalentoHumano.TextChanged
        If txtTalentoHumano.Text <> "" Then
            txtTalentoHumano.BackColor = Color.White
        End If
    End Sub

    Private Sub txtEmpleado_TextChanged_1(sender As Object, e As EventArgs) Handles txtEmpleado.TextChanged
        If txtEmpleado.Text <> "" Then
            txtEmpleado.BackColor = Color.White
        End If
    End Sub
End Class