Public Class M_Empleados
    Dim Imagen As String
    'Dim img As Image
    'Dim datos As Byte()
    Private Sub btnPuestoTrabajo_Click(sender As Object, e As EventArgs) Handles btnPuestoTrabajo.Click
        M_PuestoTrabajo.lblform.Text = "Empleados"
        M_PuestoTrabajo.ShowDialog()
    End Sub

    Private Sub btnProfesion_Click(sender As Object, e As EventArgs) Handles btnProfesion.Click
        M_Profesion.lblform.Text = "Empleados"
        M_Profesion.ShowDialog()
    End Sub
    Public Sub limpiar()
        Try
            txtcodigo.Text = ""
            txtnombre1.Text = ""
            txtnombre2.Text = ""
            txtapellido1.Text = ""
            txtapellido2.Text = ""
            txtnombreCompleto.Text = ""
            lblcodigoArea.Text = ""
            txtcodigoArea.Text = ""
            cbxCrearPersona.Checked = False
            dtpfechaAlta.Value = Date.Now
            mtxtidentidad.Text = ""

            txtseguroSocial.Text = ""
            txtseguroVida.Text = ""
            txtcodigoHorario.Text = ""
            txtbanco.Text = ""
            txtcuentaBancaria.Text = ""
            txtcodigoFormaPago.Text = ""

            rtxtmotivoBaja.Text = ""
            txtcodigoPuestoTrabajo.Text = ""
            txtdepartamento.Text = ""
            cmbxtipoCuenta.SelectedItem = ""

            cmbxcodigoContrato.SelectedItem = ""
            cmbxestadoLaboral.SelectedItem = ""
            rtxtdireccion.Text = ""
            rtxtdireccion2.Text = ""
            txtcorreo.Text = ""
            txtcorreo2.Text = ""
            txttelefono.Text = ""
            txtcelular.Text = ""
            txtRTN.Text = ""
            dtpfechaNacimiento.Value = Date.Now
            rtxtlugarNacimiento.Text = ""
            txtcodigoProfesion.Text = ""

            'caso de emergencias
            txtgrupoSanguineo.Text = ""
            txtcontactoUrgencias.Text = ""
            txttelUrgencias.Text = ""
            txtcelularUrgencias.Text = ""

            txtcontactoUrgencias2.Text = ""
            txttelUrgencias2.Text = ""
            txtcelularUrgencias2.Text = ""


            txtnombreConyugue.Text = ""
            txtnombrePadre.Text = ""
            txtnombreMadre.Text = ""


            rbtnmasculino.Checked = True
            lblEstadoCvl.Text = "Soltero"
            rbtnsoltero.Checked = True

            dtpfechaBaja.Format = DateTimePickerFormat.Custom
            dtpfechaBaja.CustomFormat = " "

            dtpFechaAvisoBaja.Format = DateTimePickerFormat.Custom
            dtpFechaAvisoBaja.CustomFormat = " "

            btnmodificar.Enabled = False

            lblform.Text = ""


            'picture box
            pbxEmpleado.Image = Nothing
            txtRuta.Text = ""

        Catch ex As Exception
            MsgBox("En la limpieza: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoProfesion_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoProfesion.TextChanged
        If (txtcodigoProfesion.Text <> "") Then
            Try
                Dim objProf As New ClsProfesion
                With objProf
                    .Codigo_ = txtcodigoProfesion.Text
                End With
                Dim dt As New DataTable
                dt = objProf.BuscarProfesionCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionProfesion.Text = CStr(row("descripcion"))
                txtcodigoProfesion.BackColor = Color.White
            Catch ex As Exception
                txtcodigoProfesion.BackColor = Color.Red
                txtdescripcionProfesion.Text = ""
            End Try
        Else
            txtcodigoProfesion.Text = ""
            txtdescripcionProfesion.Text = ""
            txtcodigoProfesion.BackColor = Color.White
        End If
    End Sub

    Private Sub txtcodigoPuestoTrabajo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoPuestoTrabajo.TextChanged
        If (txtcodigoPuestoTrabajo.Text <> "") Then
            Try
                Dim objPuesto As New ClsPuestoTrabajo
                With objPuesto
                    .Codigo_ = txtcodigoPuestoTrabajo.Text
                End With
                Dim dt As New DataTable
                dt = objPuesto.BuscarPuestoTrabajoCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionPuesto.Text = CStr(row("descripcion"))
                txtcodigoPuestoTrabajo.BackColor = Color.White
            Catch ex As Exception
                txtcodigoPuestoTrabajo.BackColor = Color.Red
                txtdescripcionPuesto.Text = ""
            End Try
        Else
            txtcodigoPuestoTrabajo.Text = ""
            txtdescripcionPuesto.Text = ""
            txtcodigoPuestoTrabajo.BackColor = Color.White
        End If
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        E_GrupoExamen.lblform.Text = "Empleados"
        E_GrupoExamen.ShowDialog()
    End Sub

    Private Sub lblcodigoArea_TextChanged(sender As Object, e As EventArgs) Handles lblcodigoArea.TextChanged
        If (lblcodigoArea.Text <> "") Then
            Try
                Dim objGroup As New ClsGrupoExamen
                With objGroup
                    .codigo_ = lblcodigoArea.Text
                End With
                Dim dt As New DataTable
                dt = objGroup.BuscarGrupoExamenCodigo()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionArea.Text = CStr(row("nombre"))
                txtcodigoArea.Text = CStr(row("codigoGrupoExamen"))
                txtcodigoArea.BackColor = Color.White
            Catch ex As Exception
                txtcodigoArea.BackColor = Color.Red
                txtdescripcionArea.Text = ""
                lblcodigoArea.Text = ""
            End Try
        End If
    End Sub
    Private Sub txtcodigoArea_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoArea.TextChanged
        If (txtcodigoArea.Text <> "") Then
            Try
                Dim objGroup As New ClsGrupoExamen
                With objGroup
                    .codigoGrupoExamen_ = txtcodigoArea.Text
                End With
                Dim dt As New DataTable
                dt = objGroup.BuscarGrupoExamenCodigoBreve()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionArea.Text = CStr(row("nombre"))
                lblcodigoArea.Text = CStr(row("codigo"))
                txtcodigoArea.BackColor = Color.White
            Catch ex As Exception
                txtcodigoArea.BackColor = Color.Red
                txtdescripcionArea.Text = ""
                lblcodigoArea.Text = ""
            End Try
        Else
            txtcodigoArea.Text = ""
            txtdescripcionArea.Text = ""
            lblcodigoArea.Text = ""
            txtcodigoArea.BackColor = Color.White
        End If
    End Sub

    Private Sub M_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenar el combo box CONTRATOS
        Try
            Dim objContratos As New ClsContratos
            Dim dt As New DataTable
            dt = objContratos.SeleccionarContratos
            Dim cant As Integer = dt.Rows.Count
            Dim row As DataRow
            cmbxcodigoContrato.Items.Clear()
            For index As Integer = 0 To cant - 1
                row = dt.Rows(index)
                cmbxcodigoContrato.Items.Add(CStr(row("descripcion")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub dtpfechaBaja_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpfechaBaja.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpfechaBaja.Format = DateTimePickerFormat.Short
                dtpfechaBaja.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpfechaBaja.Format = DateTimePickerFormat.Custom
                dtpfechaBaja.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpFechaAvisoBaja_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaAvisoBaja.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFechaAvisoBaja.Format = DateTimePickerFormat.Short
                dtpFechaAvisoBaja.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFechaAvisoBaja.Format = DateTimePickerFormat.Custom
                dtpFechaAvisoBaja.CustomFormat = " "
        End Select

    End Sub

    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs)
        E_GrupoExamen.lblform.Text = "Empleados"
        E_GrupoExamen.ShowDialog()
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
    Private Sub lblEstadoOrden_TextChanged(sender As Object, e As EventArgs) Handles lblEstadoCvl2.TextChanged
        Try
            Select Case lblEstadoCvl2.Text
                Case "Soltero"
                    rbtnsoltero.Checked = True
                Case "Casado"
                    rbtncasado.Checked = True
                Case "Viudo"
                    rbtnviudo.Checked = True
                Case "Divorciado"
                    rbtndivorciado.Checked = True
                Case "Separado"
                    rbtnseparado.Checked = True
                Case "Concuvinado"
                    rbtnconcuvinato.Checked = True
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub RadioButtonX_CheckedChanged(sender As Object, e As EventArgs) Handles rbtncasado.CheckedChanged, rbtnconcuvinato.CheckedChanged,
                                                rbtndivorciado.CheckedChanged, rbtnseparado.CheckedChanged, rbtnsoltero.CheckedChanged,
                                                rbtnviudo.CheckedChanged
        Try
            Select Case sender.name
                Case "rbtnsoltero"
                    lblEstadoCvl.Text = "Soltero"
                Case "rbtncasado"
                    lblEstadoCvl.Text = "Casado"
                Case "rbtnviudo"
                    lblEstadoCvl.Text = "Viudo"
                Case "rbtndivorciado"
                    lblEstadoCvl.Text = "Divorciado"
                Case "rbtnseparado"
                    lblEstadoCvl.Text = "Separado"
                Case "rbtnconcuvinato"
                    lblEstadoCvl.Text = "Concuvinado"
            End Select

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If Trim(txtnombreCompleto.Text) = "" Then
                MsgBox("Debe llenar los campos faltantes.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Trim(txtnombre1.Text) = "" Then
                sinDobleEspacio(txtnombre1.Text)
            End If
            If Trim(txtapellido1.Text) = "" Then
                sinDobleEspacio(txtapellido1.Text)
            End If
            If Trim(txtapellido2.Text) = "" Then
                sinDobleEspacio(txtapellido2.Text)
            End If
            'If Trim(txtpagoPaciente.Text) = "" Then
            '    txtpagoPaciente.Text = "0"
            'End If
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            ElseIf (rbtnfemenino.Checked) Then
                genero = "Femenino"
            Else
                genero = ""
                MsgBox("Debe seleccionar el genero del empleado.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim dt As New DataTable
            'Dim row As DataRow

            If (txtnombreCompleto.Text <> "" And Trim(txtcodigoHorario.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "") Then

                Dim objEmp As New ClsEmpleados
                With objEmp
                    .Nombre1_ = txtnombre1.Text
                    .Nombre2_ = txtnombre2.Text
                    .Apellido1_ = txtapellido1.Text
                    .Apellido2_ = txtapellido2.Text
                    .NombreCompleto_ = txtnombreCompleto.Text
                    .codigoGrupo_ = Convert.ToInt64(lblcodigoArea.Text)
                    .crearPersona_ = cbxCrearPersona.Checked
                    .fechaAlta_ = dtpfechaAlta.Value
                    .nIdentidad_ = mtxtidentidad.Text

                    .nSeguroSocial_ = txtseguroSocial.Text
                    .nSeguroVida_ = txtseguroVida.Text
                    .codigoHorario_ = Convert.ToInt64(txtcodigoHorario.Text)
                    .banco_ = txtbanco.Text
                    .cuentaBancaria_ = txtcuentaBancaria.Text
                    .codigoFormaPago_ = Convert.ToInt64(txtcodigoFormaPago.Text)
                    'MsgBox("antes de la valicacion fecha baja")
                    If Trim(dtpfechaBaja.Text) <> "" Then
                        .fechaBaja_ = dtpfechaBaja.Value
                    Else
                        .fechaBaja_ = Nothing
                    End If
                    If Trim(dtpFechaAvisoBaja.Text) <> "" Then
                        .fechaAvisoBaja_ = dtpFechaAvisoBaja.Value
                    Else
                        .fechaAvisoBaja_ = Nothing
                    End If
                    '.fechaBaja_ = dtpfechaBaja.Text
                    '.fechaAvisoBaja_ = dtpFechaAvisoBaja.Text
                    MsgBox("paso")
                    .motivoBaja_ = rtxtmotivoBaja.Text
                    .codigoPuestoTrab_ = Convert.ToInt64(txtcodigoPuestoTrabajo.Text)
                    .departamento_ = txtdepartamento.Text
                    .tipoCuenta_ = cmbxtipoCuenta.SelectedItem.ToString

                    .codigoContrato_ = Convert.ToInt64("1")
                    .estadoLaboral_ = cmbxestadoLaboral.SelectedItem.ToString
                    .direccion1_ = rtxtdireccion.Text
                    .direccion2_ = rtxtdireccion2.Text
                    .correo1_ = txtcorreo.Text
                    .correo2_ = txtcorreo2.Text
                    .telefono_ = txttelefono.Text
                    .celular_ = txtcelular.Text
                    .rtn_ = txtRTN.Text
                    .fechaNacimiento_ = dtpfechaNacimiento.Value
                    .lugarNacimiento_ = rtxtlugarNacimiento.Text
                    .codigoProfesion_ = txtcodigoProfesion.Text

                    .grupoSangineo_ = txtgrupoSanguineo.Text
                    .contactoUrgencias_ = txtcontactoUrgencias.Text
                    .telUrgencias_ = txttelUrgencias.Text
                    .celUrgencias_ = txtcelularUrgencias.Text
                    .nombreConyugue_ = txtnombreConyugue.Text
                    .nombrePadre_ = txtnombrePadre.Text
                    .nombreMadre_ = txtnombreMadre.Text
                    .genero_ = genero
                    .estadoCivil_ = lblEstadoCvl.Text
                    'imagen
                    .imagen_ = txtRuta.Text
                    .contactoUrgencias2_ = txtcontactoUrgencias2.Text
                    .telUrgencias2_ = txttelUrgencias2.Text
                    .celUrgencias2_ = txtcelularUrgencias2.Text
                End With

                If objEmp.RegistrarNuevoEmpleados() = 1 Then

                    MsgBox("Registrado el empleado correctamente.", MsgBoxStyle.Information)

                    dt = objEmp.CapturarEmpleados()
                    Dim row As DataRow = dt.Rows(0)
                    txtcodigo.Text = CStr(row("codigo"))

                    btnguardar.Enabled = False
                    btnmodificar.Enabled = True
                Else
                    MsgBox("Error al querer registrar el empleado.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
            'M_BuscarFactura.seleccionarFacturas()

            '::::::::::::::::::::::::::::::::::::::::::::: INSERTAR BITACORA ::::::::::::::::::::::
            'Dim Bitacora As New ClsBitacora

            'With Bitacora
            '    .usuario_ = "1"
            '    .accion_ = "Creación de un empleado."
            '    .fecha_ = Date.Now
            '    .registrarBitacora()
            'End With
            '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtnombre1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtnombre1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre1.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        txtnombre1.Select(txtnombre1.Text.Length, 0)
    End Sub
    Private Sub txtnombre2_TextChanged_1(sender As Object, e As EventArgs) Handles txtnombre2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub txtnombre2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre2.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        txtnombre2.Select(txtnombre2.Text.Length, 0)
    End Sub
    Private Sub txtapellido1_TextChanged_1(sender As Object, e As EventArgs) Handles txtapellido1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtapellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido1.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        txtapellido1.Select(txtapellido1.Text.Length, 0)
    End Sub
    Private Sub txtapellido2_TextChanged(sender As Object, e As EventArgs) Handles txtapellido2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub txtapellido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido2.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        txtapellido2.Select(txtapellido2.Text.Length, 0)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape And lblform.Text = "M_BuscarEmpleados") Then
            limpiar()
            M_BuscarEmpleados.ShowDialog()
            Me.Close()
        ElseIf (e.KeyCode = Keys.Escape And lblform.Text = "") Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If lblform.Text = "M_BuscarEmpleados" Then
            limpiar()
            M_BuscarEmpleados.ShowDialog()
            Me.Close()
        Else
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If Trim(txtnombreCompleto.Text) = "" Then
                MsgBox("Debe llenar los campos faltantes.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Trim(txtnombre1.Text) = "" Then
                sinDobleEspacio(txtnombre1.Text)
            End If
            If Trim(txtapellido1.Text) = "" Then
                sinDobleEspacio(txtapellido1.Text)
            End If
            If Trim(txtapellido2.Text) = "" Then
                sinDobleEspacio(txtapellido2.Text)
            End If
            'If Trim(txtpagoPaciente.Text) = "" Then
            '    txtpagoPaciente.Text = "0"
            'End If
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            ElseIf (rbtnfemenino.Checked) Then
                genero = "Femenino"
            Else
                genero = ""
                MsgBox("Debe seleccionar el genero del empleado.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim dt As New DataTable
            'Dim row As DataRow

            If (txtcodigo.Text <> "") Then

                Dim objEmp As New ClsEmpleados
                With objEmp
                    .codigo_ = txtcodigo.Text
                    .Nombre1_ = txtnombre1.Text
                    .Nombre2_ = txtnombre2.Text
                    .Apellido1_ = txtapellido1.Text
                    .Apellido2_ = txtapellido2.Text
                    .NombreCompleto_ = txtnombreCompleto.Text
                    .codigoGrupo_ = Convert.ToInt64(lblcodigoArea.Text)
                    .crearPersona_ = cbxCrearPersona.Checked
                    .fechaAlta_ = dtpfechaAlta.Value
                    .nIdentidad_ = mtxtidentidad.Text

                    .nSeguroSocial_ = txtseguroSocial.Text
                    .nSeguroVida_ = txtseguroVida.Text
                    .codigoHorario_ = Convert.ToInt64(txtcodigoHorario.Text)
                    .banco_ = txtbanco.Text
                    .cuentaBancaria_ = txtcuentaBancaria.Text
                    .codigoFormaPago_ = Convert.ToInt64(txtcodigoFormaPago.Text)
                    'MsgBox("antes de la valicacion fecha baja")
                    If Trim(dtpfechaBaja.Text) <> "" Then
                        .fechaBaja_ = dtpfechaBaja.Value
                    Else
                        .fechaBaja_ = Nothing
                    End If
                    If Trim(dtpFechaAvisoBaja.Text) <> "" Then
                        .fechaAvisoBaja_ = dtpFechaAvisoBaja.Value
                    Else
                        .fechaAvisoBaja_ = Nothing
                    End If
                    '.fechaBaja_ = dtpfechaBaja.Text
                    '.fechaAvisoBaja_ = dtpFechaAvisoBaja.Text
                    MsgBox("paso")
                    .motivoBaja_ = rtxtmotivoBaja.Text
                    .codigoPuestoTrab_ = Convert.ToInt64(txtcodigoPuestoTrabajo.Text)
                    .departamento_ = txtdepartamento.Text
                    .tipoCuenta_ = cmbxtipoCuenta.SelectedItem.ToString

                    .codigoContrato_ = Convert.ToInt64("1")
                    .estadoLaboral_ = cmbxestadoLaboral.SelectedItem.ToString
                    .direccion1_ = rtxtdireccion.Text
                    .direccion2_ = rtxtdireccion2.Text
                    .correo1_ = txtcorreo.Text
                    .correo2_ = txtcorreo2.Text
                    .telefono_ = txttelefono.Text
                    .celular_ = txtcelular.Text
                    .rtn_ = txtRTN.Text
                    .fechaNacimiento_ = dtpfechaNacimiento.Value
                    .lugarNacimiento_ = rtxtlugarNacimiento.Text
                    .codigoProfesion_ = txtcodigoProfesion.Text

                    .grupoSangineo_ = txtgrupoSanguineo.Text
                    .contactoUrgencias_ = txtcontactoUrgencias.Text
                    .telUrgencias_ = txttelUrgencias.Text
                    .celUrgencias_ = txtcelularUrgencias.Text
                    .nombreConyugue_ = txtnombreConyugue.Text
                    .nombrePadre_ = txtnombrePadre.Text
                    .nombreMadre_ = txtnombreMadre.Text
                    .genero_ = genero
                    .estadoCivil_ = lblEstadoCvl.Text
                    'imagen
                    .imagen_ = txtRuta.Text
                    .contactoUrgencias2_ = txtcontactoUrgencias2.Text
                    .telUrgencias2_ = txttelUrgencias2.Text
                    .celUrgencias2_ = txtcelularUrgencias2.Text
                End With

                If objEmp.ModificarEmpleados() = 1 Then

                    MsgBox("Modificado los datos del empleado correctamente.", MsgBoxStyle.Information)

                    btnguardar.Enabled = False
                    btnmodificar.Enabled = True
                Else
                    MsgBox("Error al querer actualizar los datos del empleado.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
            'M_BuscarFactura.seleccionarFacturas()

            '::::::::::::::::::::::::::::::::::::::::::::: INSERTAR BITACORA ::::::::::::::::::::::
            'Dim Bitacora As New ClsBitacora

            'With Bitacora
            '    .usuario_ = "1"
            '    .accion_ = "Creación de un empleado."
            '    .fecha_ = Date.Now
            '    .registrarBitacora()
            'End With
            '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtcodigoHorario_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoHorario.Click
        M_Horarios.lblform.Text = "M_Empleados"
        M_Horarios.ShowDialog()
    End Sub

    Private Sub txtcodigoFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.Click
        A_ListarFormasPagoPF.lblForm.Text = "M_Empleados"
        A_ListarFormasPagoPF.ShowDialog()
    End Sub

    Private Sub cmbxcodigoContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxcodigoContrato.Click
        'M_Contratos.ShowDialog()
    End Sub
    Private Sub btnBuscarImage_Click(sender As Object, e As EventArgs) Handles btnBuscarImage.Click
        SubirImagen()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        txtRuta.Text = ""
        pbxEmpleado.Image = Nothing
    End Sub
    Sub SubirImagen() 'Metodo que selecciona imagen

        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then

                Imagen = OpenFileDialog1.FileName
                txtRuta.Text = Imagen.ToString
                Dim largo As Integer = Imagen.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        txtRuta.Text = ""
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                    pbxEmpleado.Load(Imagen)
                End If

                pbxEmpleado.Load(Imagen)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la imagen." + ex.Message)
        End Try

    End Sub

End Class