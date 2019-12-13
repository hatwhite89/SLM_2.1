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
                lblcodeCategoria.Text = CStr(row("codigoCategoria"))
                lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))

                'buscar el codigoCategoriaCliente y descripcion

                Dim objCat As New ClsCategoria
                objCat.codigo_ = lblcodeCategoria.Text
                dt = objCat.BuscarCategoriaNumero()
                row = dt.Rows(0)
                txtcodigoCategoria.Text = CStr(row("codigoCategoriaCliente"))
                txtnombreCategoria.Text = CStr(row("descripcion"))

                'buscar el codigoterminoPago y descripcion

                Dim objTerm As New ClsTerminoPago
                objTerm.codigo_ = lblcodeTerminoPago.Text
                dt = objTerm.BuscarTerminoPagoNumero()
                row = dt.Rows(0)
                txtcodigoTermino.Text = CStr(row("codigoTerminoPago"))
                txtnombreTerminos.Text = CStr(row("descripcion"))

                gbxinfoCliente.Visible = True
                btnactualizarCliente.Enabled = True
                btnguardarCliente.Enabled = False
                btnseleccionarCliente.Enabled = True

            Catch ex As Exception
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
        txtcodigoCategoria.ReadOnly = False
        rbtnmasculino.Enabled = True
        rbtnfemenino.Enabled = True
        txtaseguradora.ReadOnly = False
        txtconvenio.ReadOnly = False
        txtcodigoTermino.ReadOnly = False

        btnterminosPago.Enabled = True
        btnconvenio.Enabled = True
        btnaseguradora.Enabled = True
        btncategoria.Enabled = True
        btnclasificacion.Enabled = True
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
        txtcodigoCategoria.ReadOnly = True
        rbtnmasculino.Enabled = False
        rbtnfemenino.Enabled = False
        txtaseguradora.ReadOnly = True
        txtconvenio.ReadOnly = True
        txtcodigoTermino.ReadOnly = True

        btnterminosPago.Enabled = False
        btnconvenio.Enabled = False
        btnaseguradora.Enabled = False
        btncategoria.Enabled = False
        btnclasificacion.Enabled = False
    End Sub
    Private Sub btnactualizarCliente_Click(sender As Object, e As EventArgs) Handles btnactualizarCliente.Click
        Try

            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            Else
                genero = "Femenino"
            End If

            Dim numero As Integer = 0
            If (txttelefonoTrabajo.Text <> "") Then
                numero += 1
            ElseIf (txttelefonoCasa.Text <> "") Then
                numero += 1
            ElseIf (txtcelular.Text <> "") Then
                numero += 1
            End If

            If (genero <> "" And txtcodigoTermino.Text <> "" And txtcodigoTermino.BackColor = Color.White And txtcodigoCategoria.Text <> "" And txtcodigoCategoria.BackColor = Color.White And numero > 0 And Trim(txtnombre1.Text) <> "" And Trim(txtapellido1.Text) <> "" And Trim(txtapellido2.Text) <> "" And dtpfechaNacimiento.Text <> "" And txtcodigoClasificacion.Text <> "") Then

                txtnombreCompleto.Text = sinDobleEspacio(txtnombreCompleto.Text)

                Dim objClient As New ClsCliente
                With objClient
                    .Codigo1 = Convert.ToInt32(txtcodigo.Text)
                    .NombreCompleto1 = txtnombreCompleto.Text
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
                    .codigoCategoria1 = Convert.ToInt32(lblcodeCategoria.Text)
                    .codigoTerminoPago1 = Convert.ToInt32(lblcodeTerminoPago.Text)
                End With

                If objClient.ModificarCliente() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Deshabilitar()

                    btnactualizarCliente.Enabled = False
                    btnseleccionarCliente.Enabled = True
                    btnguardarCliente.Enabled = False
                Else
                    MsgBox("Error al querer modificar el cliente.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
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

            If (genero <> "" And txtcodigoTermino.Text <> "" And txtcodigoTermino.BackColor = Color.White And txtcodigoCategoria.Text <> "" And txtcodigoCategoria.BackColor = Color.White And numero > 0 And Trim(txtnombre1.Text) <> "" And Trim(txtapellido1.Text) <> "" And Trim(txtapellido2.Text) <> "" And dtpfechaNacimiento.Text <> "" And txtcodigoClasificacion.Text <> "") Then

                txtnombreCompleto.Text = sinDobleEspacio(txtnombreCompleto.Text)

                Dim objClient As New ClsCliente
                With objClient
                    .NombreCompleto1 = txtnombreCompleto.Text
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
                    .codigoCategoria1 = Convert.ToInt32(lblcodeCategoria.Text)
                    .codigoTerminoPago1 = Convert.ToInt32(lblcodeTerminoPago.Text)
                End With

                If objClient.RegistrarNuevoCliente() = 1 Then
                    MsgBox("Registrado correctamente.")
                    Deshabilitar()
                    Dim objClient2 As New ClsCliente
                    With objClient2
                        .Identidad1 = mtxtidentidadClienteB.Text
                    End With

                    Dim dt As New DataTable
                    dt = objClient2.BuscarCliente()
                    Dim row As DataRow = dt.Rows(0)

                    txtcodigo.Text = CStr(row("codigo"))

                    btnactualizarCliente.Enabled = False
                    btnguardarCliente.Enabled = False
                    btnseleccionarCliente.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el cliente.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
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
    Public Sub limpiar()
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
        txtcodigoTermino.Text = "CO"
        txtcodigoCategoria.Text = ""

        rbtnfemenino.Checked = False
        rbtnmasculino.Checked = False
        gbxinfoCliente.Visible = False

        Habilitar()
    End Sub
    Private Sub btnseleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnseleccionarCliente.Click
        M_Factura.txtcodigoCliente.Text = txtcodigo.Text
        M_Factura.txtnombreCliente.Text = txtnombreCompleto.Text

        M_ClienteVentana.txtnombreCompleto.Text = UCase(txtnombreCompleto.Text)
        M_ClienteVentana.txtnombreTerminos.Text = txtnombreTerminos.Text
        M_ClienteVentana.txtnombreCategoria.Text = txtnombreCategoria.Text
        M_ClienteVentana.txtnombreConvenio.Text = txtnombreConvenio.Text
        M_ClienteVentana.txtnombreAseguradora.Text = txtnombreAseguradora.Text
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
                txtcodigoClasificacion.BackColor = Color.White
            Catch ex As Exception
                txtcodigoClasificacion.BackColor = Color.Red
                txtnombreClasificacion.Text = ""
            End Try
        Else
            txtcodigoClasificacion.Text = ""
            txtnombreClasificacion.Text = ""
            txtcodigoClasificacion.BackColor = Color.White
        End If
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        gbxinfoCliente.Visible = True
        mtxtidentidad.ReadOnly = False

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
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Private Sub btnbuscarPorNombre_Click(sender As Object, e As EventArgs) Handles btnbuscarPorNombre.Click
        If (Trim(txtnombreB.Text) <> "") Then
            Try
                Habilitar()
                Dim genero As String = ""
                Dim objClient As New ClsCliente
                With objClient
                    .NombreCompleto1 = sinDobleEspacio(txtnombreB.Text)
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
                lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))
                lblcodeCategoria.Text = CStr(row("codigoCategoria"))

                'buscar el codigoCategoriaCliente y descripcion

                Dim objCat As New ClsCategoria
                objCat.codigo_ = lblcodeCategoria.Text
                dt = objCat.BuscarCategoriaNumero()
                row = dt.Rows(0)
                txtcodigoCategoria.Text = CStr(row("codigoCategoriaCliente"))
                txtnombreCategoria.Text = CStr(row("descripcion"))

                'buscar el codigoterminoPago y descripcion

                Dim objTerm As New ClsTerminoPago
                objTerm.codigo_ = lblcodeTerminoPago.Text
                dt = objTerm.BuscarTerminoPagoNumero()
                row = dt.Rows(0)
                txtcodigoTermino.Text = CStr(row("codigoTerminoPago"))
                txtnombreTerminos.Text = CStr(row("descripcion"))

                'Habilitar botones
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
    Private Sub btncategoria_Click(sender As Object, e As EventArgs) Handles btncategoria.Click
        M_Categoria.ShowDialog()
    End Sub
    Private Sub btnterminosPago_Click(sender As Object, e As EventArgs) Handles btnterminosPago.Click
        M_TerminosPago.lblform.Text = "cliente"
        M_TerminosPago.ShowDialog()
    End Sub
    Private Sub txtcodigoTermino_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTermino.TextChanged
        If (txtcodigoTermino.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigoTerminoPago_ = txtcodigoTermino.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarTerminoPagoCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreTerminos.Text = CStr(row("descripcion"))
                lblcodeTerminoPago.Text = CStr(row("codigo"))
                txtcodigoTermino.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTermino.BackColor = Color.Red
                txtnombreTerminos.Text = ""
            End Try
        Else
            txtcodigoTermino.Text = ""
            txtnombreTerminos.Text = ""
            lblcodeTerminoPago.Text = ""
            txtcodigoTermino.BackColor = Color.White
        End If
    End Sub
    Private Sub txtcodigoCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCategoria.TextChanged
        If (txtcodigoCategoria.Text <> "") Then
            Try
                Dim objCat As New ClsCategoria
                With objCat
                    .codigoCategoria_ = txtcodigoCategoria.Text
                End With
                Dim dt As New DataTable
                dt = objCat.BuscarCategoriaCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCategoria.Text = CStr(row("descripcion"))
                lblcodeCategoria.Text = CStr(row("codigo"))
                txtcodigoCategoria.BackColor = Color.White
            Catch ex As Exception
                txtcodigoCategoria.BackColor = Color.Red
                txtnombreCategoria.Text = ""
            End Try
        Else
            txtcodigoCategoria.Text = ""
            txtnombreCategoria.Text = ""
            lblcodeCategoria.Text = ""
            txtcodigoCategoria.BackColor = Color.White
        End If
    End Sub
    Private Sub txtapellido1_TextChanged_1(sender As Object, e As EventArgs) Handles txtapellido1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub txtnombre2_TextChanged_1(sender As Object, e As EventArgs) Handles txtnombre2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub lblcodeTerminoPago_TextChanged(sender As Object, e As EventArgs) Handles lblcodeTerminoPago.TextChanged
        Try
            Dim objTerm As New ClsTerminoPago
            With objTerm
                .codigo_ = lblcodeTerminoPago.Text
            End With
            Dim dt As New DataTable
            dt = objTerm.BuscarTerminoPagoNumero()
            Dim row As DataRow = dt.Rows(0)
            txtnombreTerminos.Text = CStr(row("descripcion"))
            txtcodigoTermino.Text = CStr(row("codigoTerminoPago"))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub lblcodeCategoria_TextChanged(sender As Object, e As EventArgs) Handles lblcodeCategoria.TextChanged
        Try
            Dim objCat As New ClsCategoria
            With objCat
                .codigo_ = lblcodeCategoria.Text
            End With
            Dim dt As New DataTable
            dt = objCat.BuscarCategoriaNumero()
            Dim row As DataRow = dt.Rows(0)
            txtnombreCategoria.Text = CStr(row("descripcion"))
            txtcodigoCategoria.Text = CStr(row("codigoCategoriaCliente"))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub dtpfechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaNacimiento.ValueChanged
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpfechaNacimiento.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, dtpfechaNacimiento.Value, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, dtpfechaNacimiento.Value, Now) Mod 30 - 10
        MsgBox(yr & " Years, " & month & " Months ")
    End Sub
End Class