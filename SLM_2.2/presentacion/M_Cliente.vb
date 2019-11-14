Public Class M_Cliente
    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        If (mtxtidentidadClienteB.MaskCompleted = True) Then
            Try
                Habilitar()
                Dim genero As String = ""
                Dim objClient As New ClsCliente
                With objClient
                    .Identidad1 = mtxtidentidadClienteB.Text
                End With

                Dim dt As New DataTable
                dt = objClient.BuscarCliente()
                Dim row As DataRow = dt.Rows(0)

                txtcodigo.Text = CStr(row("codigo"))
                txtscanId.Text = CStr(row("scanId"))
                mtxtidentidad.Text = CStr(row("identidad"))
                txtrtn.Text = CStr(row("rtn"))
                txtnombre1.Text = CStr(row("nombre1"))
                txtnombre2.Text = CStr(row("nombre2"))
                txtapellido1.Text = CStr(row("apellido1"))
                txtapellido2.Text = CStr(row("apellido2"))
                txtnombreCompleto.Text = CStr(row("nombreCompleto"))
                dtpfechaNacimiento.Text = CStr(row("fechaNacimiento"))
                genero = CStr(row("genero"))
                If (genero = "Masculino") Then
                    rbtnmasculino.Checked = True
                Else
                    rbtnfemenino.Checked = True
                End If
                rtxtdireccion.Text = CStr(row("direccion"))
                txttelefonoCasa.Text = CStr(row("telCasa"))
                txttelefonoTrabajo.Text = CStr(row("telTrabajo"))
                txtcelular.Text = CStr(row("celular"))
                txtcorreo.Text = CStr(row("correo1"))
                txtcorreo2.Text = CStr(row("correo2"))
                txtcodigoClasificacion.Text = CStr(row("codigoClasificacion"))

                gbxinfoCliente.Visible = True
                btnactualizarCliente.Enabled = True
                btnguardarCliente.Enabled = False
                btnseleccionarCliente.Enabled = True

            Catch ex As Exception
                'MsgBox("No existe el código del cliente.", MsgBoxStyle.Critical, "Validación")
                Dim n As String = MsgBox("No existe el código del cliente. ¿Desea crear un nuevo cliente?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    Dim id As String = mtxtidentidadClienteB.Text
                    btnactualizarCliente.Enabled = False
                    btnguardarCliente.Enabled = True
                    limpiar()
                    btnseleccionarCliente.Enabled = False
                    mtxtidentidadClienteB.Text = id
                    mtxtidentidad.Text = id
                    gbxinfoCliente.Visible = True
                Else
                    limpiar()
                End If

            End Try
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

    Private Sub btncrearCliente_Click(sender As Object, e As EventArgs)
        If (mtxtidentidad.MaskCompleted = True And txtnombreCompleto.Text <> "" And txttelefonoCasa.Text <> "" And txtcorreo.Text <> "" And rtxtdireccion.Text <> "") Then
            mtxtidentidadClienteB.Text = ""
            'gbxinformacion.Visible = False
            Me.Close()
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

    Private Sub btnclasificacion_Click(sender As Object, e As EventArgs) Handles btnclasificacion.Click
        M_ClasificacionContacto.ShowDialog()
    End Sub

    Private Sub Habilitar()
        txtcorreo.ReadOnly = False
        txtcorreo2.ReadOnly = False
        txtscanId.ReadOnly = False
        txtcelular.ReadOnly = False
        txtrtn.ReadOnly = False
        txtnombre1.ReadOnly = False
        txtnombre2.ReadOnly = False
        txtapellido1.ReadOnly = False
        txtapellido2.ReadOnly = False
        rtxtdireccion.ReadOnly = False
        txttelefonoCasa.ReadOnly = False
        txttelefonoTrabajo.ReadOnly = False
        txtcodigoClasificacion.ReadOnly = False
    End Sub

    Private Sub Deshabilitar()
        txtcorreo.ReadOnly = True
        txtcorreo2.ReadOnly = True
        txtscanId.ReadOnly = True
        txtcelular.ReadOnly = True
        txtrtn.ReadOnly = True
        txtnombre1.ReadOnly = True
        txtnombre2.ReadOnly = True
        txtapellido1.ReadOnly = True
        txtapellido2.ReadOnly = True
        rtxtdireccion.ReadOnly = True
        txttelefonoCasa.ReadOnly = True
        txttelefonoTrabajo.ReadOnly = True
        txtcodigoClasificacion.ReadOnly = True
    End Sub

    Private Sub btnactualizarCliente_Click(sender As Object, e As EventArgs) Handles btnactualizarCliente.Click
        Try

            If (txtnombre1.Text <> "" And txtapellido1.Text <> "" And txtapellido2.Text <> "" And dtpfechaNacimiento.Text <> "" And rtxtdireccion.Text <> "" And txtcelular.Text <> "") Then
                Dim testString As String = txtnombreCompleto.Text()
                Dim texto As String = ""
                Dim testArray() As String = Split(testString)
                Dim lastNonEmpty As Integer = -1
                For i As Integer = 0 To testArray.Length - 1
                    If testArray(i) <> "" Then
                        lastNonEmpty += 1
                        testArray(lastNonEmpty) = testArray(i)
                        texto += testArray(i) + " "
                    End If
                Next
                ReDim Preserve testArray(lastNonEmpty)
                txtnombreCompleto.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim genero As String = ""
                If (rbtnmasculino.Checked) Then
                    genero = "Masculino"
                Else
                    genero = "Femenino"
                End If
                Dim objClient As New ClsCliente
                With objClient
                    .Codigo1 = Convert.ToInt32(txtcodigo.Text)
                    .NombreCompleto1 = texto
                    .ScanId1 = txtscanId.Text
                    .Identidad1 = mtxtidentidadClienteB.Text
                    .Rtn1 = txtrtn.Text
                    .Nombre_1 = txtnombre1.Text
                    .Nombre_2 = txtnombre2.Text
                    .Apellido_1 = txtapellido1.Text
                    .Apellido_2 = txtapellido2.Text
                    .FechaNacimiento1 = dtpfechaNacimiento.Text
                    .Genero1 = genero
                    .Direccion1 = rtxtdireccion.Text
                    .TelCasa1 = txttelefonoCasa.Text
                    .TelTrabajo1 = txttelefonoTrabajo.Text
                    .Celular1 = txtcelular.Text
                    .Correo_1 = txtcorreo.Text
                    .Correo_2 = txtcorreo2.Text
                    .CodigoClasificacion1 = Convert.ToInt32(txtcodigoClasificacion.Text)
                End With

                If objClient.ModificarCliente() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Deshabilitar()


                    btnactualizarCliente.Enabled = True
                    btnseleccionarCliente.Enabled = True
                    btnguardarCliente.Enabled = False
                Else
                    MsgBox("Error al querer modificar el cliente.", MsgBoxStyle.Critical)
                End If


            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

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

    Private Sub txtnombre2_TextChanged(sender As Object, e As EventArgs) Handles txtnombre2.TextChanged
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

    Private Sub txtapellido1_TextChanged(sender As Object, e As EventArgs) Handles txtapellido1.TextChanged
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

    Private Sub btnguardarCliente_Click(sender As Object, e As EventArgs) Handles btnguardarCliente.Click
        Try
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            ElseIf (rbtnfemenino.Checked) Then
                genero = "Femenino"
            Else
                genero = ""
            End If

            Dim numero As Integer = 0
            If (txttelefonoTrabajo.Text <> "") Then
                numero += 1
            ElseIf (txttelefonoCasa.Text <> "") Then
                numero += 1
            ElseIf (txtcelular.Text <> "") Then
                numero += 1
            Else
                numero = 0
            End If

            If (genero <> "" And numero > 0 And txtnombre1.Text <> "" And txtapellido1.Text <> "" And txtapellido2.Text <> "" And dtpfechaNacimiento.Text <> "" And rtxtdireccion.Text <> "" And txtcodigoClasificacion.Text <> "") Then

                Dim testString As String = txtnombreCompleto.Text()
                Dim texto As String = ""
                Dim testArray() As String = Split(testString)
                Dim lastNonEmpty As Integer = -1
                For i As Integer = 0 To testArray.Length - 1
                    If testArray(i) <> "" Then
                        lastNonEmpty += 1
                        testArray(lastNonEmpty) = testArray(i)
                        texto += testArray(i) + " "
                    End If
                Next
                ReDim Preserve testArray(lastNonEmpty)
                txtnombreCompleto.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())

                Dim objClient As New ClsCliente
                With objClient
                    .NombreCompleto1 = texto
                    .ScanId1 = txtscanId.Text
                    .Identidad1 = mtxtidentidadClienteB.Text
                    .Rtn1 = txtrtn.Text
                    .Nombre_1 = txtnombre1.Text
                    .Nombre_2 = txtnombre2.Text
                    .Apellido_1 = txtapellido1.Text
                    .Apellido_2 = txtapellido2.Text
                    .FechaNacimiento1 = dtpfechaNacimiento.Text
                    .Genero1 = genero
                    .Direccion1 = rtxtdireccion.Text
                    .TelCasa1 = txttelefonoCasa.Text
                    .TelTrabajo1 = txttelefonoTrabajo.Text
                    .Celular1 = txtcelular.Text
                    .Correo_1 = txtcorreo.Text
                    .Correo_2 = txtcorreo2.Text
                    .CodigoClasificacion1 = Convert.ToInt32(txtcodigoClasificacion.Text)
                End With

                If objClient.RegistrarNuevoCliente() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim objClient2 As New ClsCliente
                    With objClient2
                        .Identidad1 = mtxtidentidadClienteB.Text
                    End With

                    Dim dt As New DataTable
                    dt = objClient2.BuscarCliente()
                    Dim row As DataRow = dt.Rows(0)

                    txtcodigo.Text = CStr(row("codigo"))

                    btnactualizarCliente.Enabled = True
                    btnguardarCliente.Enabled = False
                    btnseleccionarCliente.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el cliente.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtcodigoClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoClasificacion.KeyPress

        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If

    End Sub

    Private Sub limpiar()
        txtcorreo.ReadOnly = False
        txtcorreo2.ReadOnly = False
        txtscanId.ReadOnly = False
        txtcelular.ReadOnly = False
        txtrtn.ReadOnly = False
        txtnombre1.ReadOnly = False
        txtnombre2.ReadOnly = False
        txtapellido1.ReadOnly = False
        txtapellido2.ReadOnly = False
        rtxtdireccion.ReadOnly = False
        txttelefonoCasa.ReadOnly = False
        txttelefonoTrabajo.ReadOnly = False
        txtcodigoClasificacion.ReadOnly = False
        txtscanId.ReadOnly = False
        txtrtn.ReadOnly = False

        txtcorreo.Text = ""
        txtcorreo2.Text = ""
        txtscanId.Text = ""
        txtcelular.Text = ""
        txtrtn.Text = ""
        txtnombre1.Text = ""
        txtnombre2.Text = ""
        txtapellido1.Text = ""
        txtapellido2.Text = ""
        rtxtdireccion.Text = ""
        txttelefonoCasa.Text = ""
        txttelefonoTrabajo.Text = ""
        txtcodigoClasificacion.Text = ""
        txtnombreCompleto.Text = ""
        mtxtidentidad.Text = ""
        mtxtidentidadClienteB.Text = ""
        txtcodigo.Text = ""
        txtnombreClasificacion.Text = ""
        txtnombreB.Text = ""

        rbtnfemenino.Checked = False
        rbtnmasculino.Checked = False
        gbxinfoCliente.Visible = False
    End Sub

    Private Sub btnseleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnseleccionarCliente.Click
        M_Factura.txtcodigoCliente.Text = txtcodigo.Text
        M_Factura.txtnombreCliente.Text = txtnombreCompleto.Text
        limpiar()
        Me.Close()
    End Sub

    Private Sub txtcodigoClasificacion_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoClasificacion.TextChanged
        If (txtcodigoClasificacion.Text <> "") Then
            Try
                Dim objClas As New ClsClasificacionContacto
                With objClas
                    .Codigo1 = txtcodigoClasificacion.Text
                End With
                Dim dt As New DataTable
                dt = objClas.BuscarClasificacionContactoCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreClasificacion.Text = CStr(row("comentario"))
            Catch ex As Exception
                MsgBox("No existe el código de clasificación de contacto.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoClasificacion.Text = ""
            txtnombreClasificacion.Text = ""
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        gbxinfoCliente.Visible = True
        mtxtidentidad.ReadOnly = False

        btnnuevo.Enabled = False
        btnactualizarCliente.Enabled = False
        btnguardarCliente.Enabled = True
        btnseleccionarCliente.Enabled = False
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnpaciente_Click(sender As Object, e As EventArgs) Handles btnpaciente.Click
        Dim n As String = MsgBox("¿Desea crear un nuevo paciente?", MsgBoxStyle.YesNo, "Validación")
        If n = vbYes Then
            btnactualizarCliente.Enabled = False
            btnguardarCliente.Enabled = True
            limpiar()
            mtxtidentidad.ReadOnly = True
            txtrtn.ReadOnly = True
            txtscanId.ReadOnly = True
            btnseleccionarCliente.Enabled = False
            gbxinfoCliente.Visible = True
        Else
            limpiar()
        End If
    End Sub

    Private Sub btnbuscarPorNombre_Click(sender As Object, e As EventArgs) Handles btnbuscarPorNombre.Click
        If (txtnombreB.Text <> "") Then
            Try
                Habilitar()
                Dim genero As String = ""
                Dim objClient As New ClsCliente
                With objClient
                    .NombreCompleto1 = txtnombreB.Text
                End With

                Dim dt As New DataTable
                dt = objClient.BuscarClienteNombre()
                Dim row As DataRow = dt.Rows(0)

                txtcodigo.Text = CStr(row("codigo"))
                txtscanId.Text = CStr(row("scanId"))
                mtxtidentidad.Text = CStr(row("identidad"))
                txtrtn.Text = CStr(row("rtn"))
                txtnombre1.Text = CStr(row("nombre1"))
                txtnombre2.Text = CStr(row("nombre2"))
                txtapellido1.Text = CStr(row("apellido1"))
                txtapellido2.Text = CStr(row("apellido2"))
                txtnombreCompleto.Text = CStr(row("nombreCompleto"))
                dtpfechaNacimiento.Text = CStr(row("fechaNacimiento"))
                genero = CStr(row("genero"))
                If (genero = "Masculino") Then
                    rbtnmasculino.Checked = True
                Else
                    rbtnfemenino.Checked = True
                End If
                rtxtdireccion.Text = CStr(row("direccion"))
                txttelefonoCasa.Text = CStr(row("telCasa"))
                txttelefonoTrabajo.Text = CStr(row("telTrabajo"))
                txtcelular.Text = CStr(row("celular"))
                txtcorreo.Text = CStr(row("correo1"))
                txtcorreo2.Text = CStr(row("correo2"))
                txtcodigoClasificacion.Text = CStr(row("codigoClasificacion"))

                gbxinfoCliente.Visible = True
                btnactualizarCliente.Enabled = True
                btnguardarCliente.Enabled = False
                btnseleccionarCliente.Enabled = True

            Catch ex As Exception
                'MsgBox("No existe el código del cliente.", MsgBoxStyle.Critical, "Validación")
                Dim n As String = MsgBox("No existe el nombre del paciente. ¿Desea crear un nuevo paciente?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    Dim id As String = mtxtidentidadClienteB.Text
                    btnactualizarCliente.Enabled = False
                    btnguardarCliente.Enabled = True
                    limpiar()
                    btnseleccionarCliente.Enabled = False
                    mtxtidentidadClienteB.Text = id
                    mtxtidentidad.Text = id
                    gbxinfoCliente.Visible = True
                Else
                    limpiar()
                End If

            End Try
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub
End Class