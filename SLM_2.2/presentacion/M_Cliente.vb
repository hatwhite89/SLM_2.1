Imports System.Data.SqlClient

Public Class M_Cliente
    Dim objCli As New ClsCliente
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

                'llenar tipo clasificacion
                cmbxClasificacion.SelectedValue = txtcodigoClasificacion.Text

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
                MsgBox(ex.Message)
                Dim n As String = MsgBox("No existe el código del cliente. ¿Desea crear un nuevo cliente?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    Dim id As String = mtxtidentidadClienteB.Text
                    btnactualizarCliente.Enabled = False
                    btnguardarCliente.Enabled = True
                    limpiar()
                    btnseleccionarCliente.Enabled = False
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
        'M_ClasificacionContacto.lblform.Text = "M_Cliente"
        'M_ClasificacionContacto.show()
        M_TipoClasificacion.lbltipo.Text = "M_Cliente"
        M_TipoClasificacion.Show()
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
        'txtaseguradora.ReadOnly = False
        'txtconvenio.ReadOnly = False
        txtcodigoTermino.ReadOnly = False
        mtxtidentidad.ReadOnly = False

        btnterminosPago.Enabled = True
        'btnconvenio.Enabled = True
        'btnaseguradora.Enabled = True
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
            'MsgBox(cmbxClasificacion.SelectedValue)
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            Else
                genero = "Femenino"
            End If


            'al menos debe ingresar un telefono o correo
            Dim numero As Integer = 0
            If (txttelefonoTrabajo.Text <> "") Then
                numero += 1
            ElseIf (txttelefonoCasa.Text <> "") Then
                numero += 1
            ElseIf (txtcelular.Text <> "") Then
                numero += 1
            ElseIf (txtcorreo.Text <> "") Then
                numero += 1
            ElseIf (txtcorreo2.Text <> "") Then
                numero += 1
            Else
                numero = 0
            End If

            If (genero <> "" And txtcodigoTermino.Text <> "" And
                txtcodigoTermino.BackColor = Color.White And txtnombreCategoria.Text <> "" And
                txtcodigoCategoria.BackColor = Color.White And numero > 0 And Trim(txtnombre1.Text) <> "" And
                Trim(txtapellido1.Text) <> "" And dtpfechaNacimiento.Text <> "" And Trim(cmbxClasificacion.SelectedValue) <> "") Then
                'If (genero <> "" And Trim(rtxtdireccion.Text) <> "" And txtcodigoTermino.Text <> "" And txtcodigoTermino.BackColor = Color.White And txtcodigoCategoria.Text <> "" And txtcodigoCategoria.BackColor = Color.White And numero > 0 And Trim(txtnombre1.Text) <> "" And Trim(txtapellido1.Text) <> "" And Trim(txtapellido2.Text) <> "" And dtpfechaNacimiento.Text <> "" And txtcodigoClasificacion.Text <> "") Then

                txtnombreCompleto.Text = sinDobleEspacio(txtnombreCompleto.Text)

                Dim objClient As New ClsCliente
                With objClient
                    .Codigo1 = Convert.ToInt64(txtcodigo.Text)
                    .NombreCompleto1 = txtnombreCompleto.Text
                    .ScanId1 = txtscanId.Text
                    .Identidad1 = mtxtidentidad.Text
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
                    '.CodigoClasificacion1 = Convert.ToInt64(txtcodigoClasificacion.Text)
                    .CodigoClasificacion1 = Convert.ToInt64(cmbxClasificacion.SelectedValue)
                    .codigoCategoria1 = Convert.ToInt64(lblcodeCategoria.Text)
                    .codigoTerminoPago1 = Convert.ToInt64(lblcodeTerminoPago.Text)
                End With

                If objClient.ModificarCliente() = 1 Then
                    MsgBox("Modificado correctamente.")

                    'Deshabilitar()

                    btnactualizarCliente.Enabled = True
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
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtnombre1.Select(txtnombre1.Text.Length, 0)
    End Sub
    'Private Sub sinCaracteresYSimbolos(sender As Object, e As KeyPressEventArgs) Handles txtnombre2.KeyPress
    '    If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
    '        e.Handled = True
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSymbol(e.KeyChar) Then
    '        e.Handled = True
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsWhiteSpace(e.KeyChar) Then
    '        e.Handled = True
    '    Else
    '        e.Handled = False
    '    End If
    '    txtnombre2.Select(txtnombre2.Text.Length, 0)
    'End Sub
    Private Sub txtnombre2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre2.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtnombre2.Select(txtnombre2.Text.Length, 0)
    End Sub

    Private Sub txtapellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido1.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtapellido1.Select(txtapellido1.Text.Length, 0)
    End Sub
    Private Sub txtapellido2_TextChanged(sender As Object, e As EventArgs) Handles txtapellido2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub
    Private Sub txtapellido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido2.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        'txtapellido2.Select(txtapellido2.Text.Length, 0)
    End Sub
    Private Sub btnguardarCliente_Click(sender As Object, e As EventArgs) Handles btnguardarCliente.Click
        Try
            'genero
            Dim genero As String = ""
            If (rbtnmasculino.Checked) Then
                genero = "Masculino"
            ElseIf (rbtnfemenino.Checked) Then
                genero = "Femenino"
            Else
                genero = ""
            End If

            'al menos debe ingresar un telefono o correo
            Dim numero As Integer = 0
            If (txttelefonoTrabajo.Text <> "") Then
                numero += 1
            ElseIf (txttelefonoCasa.Text <> "") Then
                numero += 1
            ElseIf (txtcelular.Text <> "") Then
                numero += 1
            ElseIf (txtcorreo.Text <> "") Then
                numero += 1
            ElseIf (txtcorreo2.Text <> "") Then
                numero += 1
            Else
                numero = 0
            End If

            If (genero <> "" And txtcodigoTermino.Text <> "" And
                txtcodigoTermino.BackColor = Color.White And txtnombreCategoria.Text <> "" And
                txtcodigoCategoria.BackColor = Color.White And numero > 0 And Trim(txtnombre1.Text) <> "" And
                Trim(txtapellido1.Text) <> "" And dtpfechaNacimiento.Text <> "" And Trim(cmbxClasificacion.SelectedValue) <> "") Then
                'If (genero <> "" And Trim(rtxtdireccion.Text) <> "" And txtcodigoTermino.Text <> "" And txtcodigoTermino.BackColor = Color.White And txtnombreCategoria.Text <> "" And txtcodigoCategoria.BackColor = Color.White And numero > 0 And Trim(txtnombre1.Text) <> "" And Trim(txtapellido1.Text) <> "" And Trim(txtapellido2.Text) <> "" And dtpfechaNacimiento.Text <> "" And txtcodigoClasificacion.Text <> "") Then

                rtxtdireccion.Text = sinDobleEspacio(rtxtdireccion.Text)
                txtnombreCompleto.Text = sinDobleEspacio(txtnombreCompleto.Text)

                Dim objClient As New ClsCliente
                With objClient
                    .NombreCompleto1 = txtnombreCompleto.Text
                    .ScanId1 = txtscanId.Text
                    .Identidad1 = mtxtidentidad.Text
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
                    .CodigoClasificacion1 = Convert.ToInt64(cmbxClasificacion.SelectedValue)
                    '.CodigoClasificacion1 = Convert.ToInt64(txtcodigoClasificacion.Text)
                    .codigoCategoria1 = Convert.ToInt64(lblcodeCategoria.Text)
                    .codigoTerminoPago1 = Convert.ToInt64(lblcodeTerminoPago.Text)
                End With

                If objClient.RegistrarNuevoCliente() = 1 Then
                    MsgBox("Registrado correctamente.")
                    'Deshabilitar()
                    'Dim objClient2 As New ClsCliente
                    'With objClient2
                    '    .Identidad1 = mtxtidentidadClienteB.Text
                    'End With

                    'Dim dt As New DataTable
                    'dt = objClient2.BuscarCliente()
                    'Dim row As DataRow = dt.Rows(0)

                    'txtcodigo.Text = CStr(row("codigo"))

                    Dim dt As New DataTable
                    dt = objClient.CapturarCliente()
                    Dim row As DataRow = dt.Rows(0)
                    txtcodigo.Text = CStr(row("codigo"))

                    btnactualizarCliente.Enabled = True
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

        dtpfechaNacimiento.Value = Date.Today

        rbtnfemenino.Checked = False
        rbtnmasculino.Checked = False
        gbxinfoCliente.Visible = False

        Habilitar()
    End Sub
    Private Sub btnseleccionarCliente_Click(sender As Object, e As EventArgs) Handles btnseleccionarCliente.Click
        M_Factura.txtcodigoCliente.Text = txtcodigo.Text
        M_Factura.txtnombreCliente.Text = txtnombreCompleto.Text
        M_Factura.actualizarDatosCliente()

        M_ClienteVentana.txtnombreCompleto.Text = UCase(txtnombreCompleto.Text)
        M_ClienteVentana.txtnombreTerminos.Text = txtnombreTerminos.Text
        M_ClienteVentana.txtnombreCategoria.Text = txtnombreCategoria.Text
        M_ClienteVentana.txtnombreConvenio.Text = txtnombreConvenio.Text
        M_ClienteVentana.txtcorreo1.Text = txtcorreo.Text
        M_ClienteVentana.txtcorreo2.Text = txtcorreo2.Text
        M_ClienteVentana.txttelefonoCasa.Text = txttelefonoCasa.Text
        M_ClienteVentana.txttelefonoTrabajo.Text = txttelefonoTrabajo.Text
        M_ClienteVentana.txtcelular.Text = txtcelular.Text
        limpiar()
        Me.Close()
    End Sub

    Private Sub txtcodigoClasificacion_Click(sender As Object, e As EventArgs) Handles txtcodigoClasificacion.Click
        Try
            'REVISA QUE SE HAYA SELECCIONADO UNA CATEGORIA
            If Trim(txtnombreCategoria.Text) <> "" Then

                M_ListadoTipoClasificacion.lblBandera.Text = "1"
                M_ListadoTipoClasificacion.lblcodeCateCli.Text = lblcodeCategoria.Text
                M_ListadoTipoClasificacion.lblform.Text = "M_Cliente"
                M_ListadoTipoClasificacion.Show()

            Else

                MsgBox("Debe seleccionar una categoria de cliente.", MsgBoxStyle.Exclamation)

            End If
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub txtcodigoClasificacion_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoClasificacion.TextChanged
    '    If (txtcodigoClasificacion.Text <> "") Then
    '        Try
    '            Dim objClas As New ClsClasificacionContacto
    '            With objClas
    '                .Codigo1 = txtcodigoClasificacion.Text
    '            End With
    '            Dim dt As New DataTable
    '            dt = objClas.BuscarClasificacionContactoCode()
    '            Dim row As DataRow = dt.Rows(0)
    '            txtnombreClasificacion.Text = CStr(row("comentario"))
    '            txtcodigoClasificacion.BackColor = Color.White
    '        Catch ex As Exception
    '            txtcodigoClasificacion.BackColor = Color.Red
    '            txtnombreClasificacion.Text = ""
    '        End Try
    '    Else
    '        txtcodigoClasificacion.Text = ""
    '        txtnombreClasificacion.Text = ""
    '        txtcodigoClasificacion.BackColor = Color.White
    '    End If
    'End Sub
    Private Sub txtcodigoClasificacion_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoClasificacion.TextChanged
        If (txtcodigoClasificacion.Text <> "") Then
            Try

                objTipoCls.Codigo1 = txtcodigoClasificacion.Text

                Dim dt As New DataTable
                dt = objTipoCls.BuscarTipoClasificacionCode()
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
            'mtxtidentidad.ReadOnly = True
            'txtrtn.ReadOnly = True
            'txtscanId.ReadOnly = True
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

                'llenar tipo clasificacion
                cmbxClasificacion.SelectedValue = txtcodigoClasificacion.Text

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
                MsgBox("No existe el código del cliente. " + ex.Message, MsgBoxStyle.Critical, "Validación")
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
        M_Categoria.lblform.Text = "M_Cliente"
        M_Categoria.Show()
    End Sub
    Private Sub btnterminosPago_Click(sender As Object, e As EventArgs) Handles btnterminosPago.Click
        M_TerminosPago.lblform.Text = "cliente"
        M_TerminosPago.Show()
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
                lblcodeTerminoPago.Text = ""
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
                lblcodeCategoria.Text = CStr(row("codigo"))
                txtnombreCategoria.Text = CStr(row("descripcion"))
                txtcodigoCategoria.BackColor = Color.White
            Catch ex As Exception
                txtcodigoCategoria.BackColor = Color.Red
                lblcodeCategoria.Text = ""
                txtnombreCategoria.Text = ""
            End Try
        Else
            txtnombreCategoria.Text = ""
            lblcodeCategoria.Text = ""
            txtcodigoCategoria.BackColor = Color.Red
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
        Dim month As Integer = DateDiff(DateInterval.Month, dtpfechaNacimiento.Value, Now)
        Dim day As Integer = DateDiff(DateInterval.Day, dtpfechaNacimiento.Value, Now)

        If (Now.Month < dtpfechaNacimiento.Value.Month) Then
            yr -= 1
        ElseIf (Now.Month = dtpfechaNacimiento.Value.Month And Now.Day < dtpfechaNacimiento.Value.Day) Then
            yr -= 1
        End If

        If (yr = 0 And month = 1 And Now.Day < dtpfechaNacimiento.Value.Day) Then
            month -= 1
        End If

        If (yr >= 1) Then
            txtEdad.Text = yr & "a"
        ElseIf (yr = 0 And month > 0) Then
            txtEdad.Text = month & "m"
        Else
            txtEdad.Text = day & "d"
        End If
    End Sub

    Private Sub cargarVariables(ByVal campoTexto As TextBox)
        'Dim objCon As New ClsConnection
        'Dim cn As New SqlConnection
        'cn = objCon.getConexion

        Dim clsC As New ClsConnection
        Dim enunciado As SqlCommand
        Dim respuesta As SqlDataReader

        Try
            enunciado = New SqlCommand("select nombreCompleto FROM Cliente", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read

                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombreCompleto"))


            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    'Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
    '    If (Trim(txtnombreB.Text) <> "") Then
    '        Try
    '            'Habilitar()
    '            Dim genero As String = ""
    '            Dim objClient As New ClsCliente
    '            With objClient
    '                .NombreCompleto1 = sinDobleEspacio(txtnombreB.Text)
    '            End With

    '            Dim dt As New DataTable
    '            dt = objClient.BuscarClienteNombre()
    '            Dim row As DataRow = dt.Rows(0)

    '            txtnombreB.AutoCompleteCustomSource.Add(CStr(row("nombreCompleto")))

    '            'txtcodigo.Text = CStr(row("codigo"))
    '            'txtscanId.Text = CStr(row("scanId"))
    '            'mtxtidentidad.Text = CStr(row("identidad"))
    '            'txtrtn.Text = CStr(row("rtn"))
    '            'txtnombre1.Text = CStr(row("nombre1"))
    '            'txtnombre2.Text = CStr(row("nombre2"))
    '            'txtapellido1.Text = CStr(row("apellido1"))
    '            'txtapellido2.Text = CStr(row("apellido2"))
    '            'txtnombreCompleto.Text = CStr(row("nombreCompleto"))
    '            'dtpfechaNacimiento.Text = CStr(row("fechaNacimiento"))
    '            'genero = CStr(row("genero"))
    '            'If (genero = "Masculino") Then
    '            '    rbtnmasculino.Checked = True
    '            'Else
    '            '    rbtnfemenino.Checked = True
    '            'End If
    '            'rtxtdireccion.Text = CStr(row("direccion"))
    '            'txttelefonoCasa.Text = CStr(row("telCasa"))
    '            'txttelefonoTrabajo.Text = CStr(row("telTrabajo"))
    '            'txtcelular.Text = CStr(row("celular"))
    '            'txtcorreo.Text = CStr(row("correo1"))
    '            'txtcorreo2.Text = CStr(row("correo2"))
    '            'txtcodigoClasificacion.Text = CStr(row("codigoClasificacion"))
    '            'lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))
    '            'lblcodeCategoria.Text = CStr(row("codigoCategoria"))

    '            ''buscar el codigoCategoriaCliente y descripcion

    '            'Dim objCat As New ClsCategoria
    '            'objCat.codigo_ = lblcodeCategoria.Text
    '            'dt = objCat.BuscarCategoriaNumero()
    '            'row = dt.Rows(0)
    '            'txtcodigoCategoria.Text = CStr(row("codigoCategoriaCliente"))
    '            'txtnombreCategoria.Text = CStr(row("descripcion"))

    '            ''buscar el codigoterminoPago y descripcion

    '            'Dim objTerm As New ClsTerminoPago
    '            'objTerm.codigo_ = lblcodeTerminoPago.Text
    '            'dt = objTerm.BuscarTerminoPagoNumero()
    '            'row = dt.Rows(0)
    '            'txtcodigoTermino.Text = CStr(row("codigoTerminoPago"))
    '            'txtnombreTerminos.Text = CStr(row("descripcion"))

    '            ''Habilitar botones
    '            'gbxinfoCliente.Visible = True
    '            'btnactualizarCliente.Enabled = True
    '            'btnguardarCliente.Enabled = False
    '            'btnseleccionarCliente.Enabled = True

    '        Catch ex As Exception
    '            MsgBox("ERROR EN LA BUSQUEDA.", MsgBoxStyle.Critical, "Validación")


    '        End Try
    '    Else
    '        MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
    '    End If
    'End Sub

    Private Sub M_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargarVariables(txtnombreB)
        alternarColoFilasDatagridview(dgbtabla)
        'Dim dv As DataView = objCli.SeleccionarClientes.DefaultView
        'dgbtabla.DataSource = dv
        ''lblcantidad.Text = dv.Count
        'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub txtnombreCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtnombreCategoria.TextChanged
        If (Trim(txtnombreCategoria.Text) <> "") Then
            cmbxClasificacion.Enabled = True
            llenarTipoClasificacion()
        Else
            cmbxClasificacion.Enabled = False
            'cmbxClasificacion.Items.Clear()
        End If
    End Sub

    Dim objTipoCls As New ClsTipoClasificacion


    Private Sub llenarTipoClasificacion()
        Try
            'MsgBox(lblcodeCategoria.Text)
            'llenar el combobox tipo termino
            objTipoCls.codigoCategoriaCliente_ = Integer.Parse(lblcodeCategoria.Text)
            Dim dt As New DataTable
            dt = objTipoCls.BuscarTipoClasificacionCategoria()
            cmbxClasificacion.DataSource = dt
            cmbxClasificacion.DisplayMember = "comentario"
            cmbxClasificacion.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub cmbxClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxClasificacion.SelectedValueChanged
        Try
            'Seleccionar el termino de pago segun el tipo de clasificacion
            objTipoCls.Codigo1 = Integer.Parse(cmbxClasificacion.SelectedValue)
            Dim dt As New DataTable
            Dim row As DataRow
            dt = objTipoCls.BuscarTipoClasificacionCode()
            row = dt.Rows(0)
            If row("tipoConvenio").ToString Then
                lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))
            Else
                txtcodigoTermino.Text = "CO"
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            If Trim(txtnombreB.Text) <> "" Then
                objCli.NombreCompleto1 = txtnombreB.Text
                Dim dv As DataView = objCli.BuscarClienteNombre.DefaultView
                dgbtabla.DataSource = dv
                ocultarColumnas()
                'lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                dgbtabla.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            Habilitar()

            btnseleccionarCliente.Enabled = False
            gbxinfoCliente.Visible = True

            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtscanId.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            'If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value().ToString) <> "0" Then
            '    txtcodigoEspecialidad.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            'Else
            '    txtcodigoEspecialidad.Text = ""
            'End If
            mtxtidentidad.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtrtn.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            txtnombre1.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            txtnombre2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            txtapellido1.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
            txtapellido2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
            dtpfechaNacimiento.Value = Convert.ToDateTime(Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value())
            If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(10).Value().ToString) = "Masculino" Then
                rbtnmasculino.Checked = True
            Else
                rbtnfemenino.Checked = True
            End If
            rtxtdireccion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(11).Value()
            txttelefonoCasa.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(12).Value()
            txttelefonoTrabajo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(13).Value()
            txtcelular.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(14).Value()
            txtcorreo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(15).Value()
            txtcorreo2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(16).Value()
            lblcodeCategoria.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(18).Value()
            lblcodeTerminoPago.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(19).Value()
            cmbxClasificacion.SelectedValue = Me.dgbtabla.Rows(e.RowIndex).Cells(17).Value()
            'If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value().ToString) <> "0" Then
            '    txtcodigoEspecialidad2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
            'Else
            '    txtcodigoEspecialidad2.Text = ""
            'End If

            'btnmodificar.Enabled = True
            'btnguardar.Enabled = False
            'btnbuscarEspecialidad.Enabled = True
            'btnbuscarEspecialidad2.Enabled = True

            'txtcorreo.ReadOnly = False
            'txtcorreo2.ReadOnly = False
            'txttelefono.ReadOnly = False
            'txtcelular.ReadOnly = False
            'txtcodigoEspecialidad.ReadOnly = False
            'txtcodigoEspecialidad2.ReadOnly = False
            'txtcodigo.ReadOnly = True
            'txtnombreCompleto.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mtxtidentidadClienteB_MaskInputRejected(sender As Object, e As EventArgs) Handles mtxtidentidadClienteB.TextChanged
        Try
            If mtxtidentidadClienteB.Text.Equals(String.Empty) Then
                dgbtabla.DataSource = Nothing
            ElseIf trim(mtxtidentidadClienteB.Text) <> "    -    -     " Then
                objCli.Identidad1 = mtxtidentidadClienteB.Text
                Dim dv As DataView = objCli.BuscarCliente.DefaultView
                dgbtabla.DataSource = dv
                ocultarColumnas()
                'lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultarColumnas()
        'OCULTAR COLUMNAS
        Try
            Me.dgbtabla.Columns("scanId").Visible = False
            Me.dgbtabla.Columns("rtn").Visible = False
            Me.dgbtabla.Columns("correo1").Visible = False
            Me.dgbtabla.Columns("correo2").Visible = False
            Me.dgbtabla.Columns("direccion").Visible = False
            Me.dgbtabla.Columns("telCasa").Visible = False
            Me.dgbtabla.Columns("telTrabajo").Visible = False
            Me.dgbtabla.Columns("celular").Visible = False
            Me.dgbtabla.Columns("codigoClasificacion").Visible = False
            Me.dgbtabla.Columns("codigoTerminoPago").Visible = False
            Me.dgbtabla.Columns("codigoCategoria").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        M_BuscarClientes.lblForm.Text() = "Prueba"
        M_BuscarClientes.Show()
    End Sub
End Class