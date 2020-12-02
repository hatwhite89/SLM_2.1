Public Class E_Usuarios

    Dim usuario As New ClsUsuario
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            'Validacion de campos vacios
            If txtUsuario.Text <> "" And txtPerfil.Text <> "" Then

                With usuario

                    .Usuario_ = txtUsuario.Text
                    .password_ = Encriptar(txtPass.Text)
                    .perfil_ = txtPerfil.Text
                    .Estad_o = chkHabilitar.Checked
                    .Cod_Perfil = Convert.ToInt32(lblCodPerfil.Text)
                    If .registrarNuevoUsuario = 1 Then
                        MsgBox("El registro se ha guardado correctamente.")
                        Limpiar()
                        dtUsuarios.DataSource = .listarUsuarios
                    End If

                End With

            ElseIf txtUsuario.Text = "" Then
                txtUsuario.BackColor = Color.Red
            ElseIf txtPerfil.TextAlign = "" Then
                txtPerfil.BackColor = Color.Red
            End If

        Catch ex As Exception
            MsgBox("El usuario " + txtUsuario.Text + " ya existe o hubo un error al registrar el error.")
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            'Validacion de campos vacios
            If txtUsuario.Text <> "" And txtPerfil.Text <> "" Then

                With usuario
                    .Cod = Convert.ToInt32(txtCodigo.Text)
                    .Usuario_ = txtUsuario.Text
                    .password_ = Encriptar(txtPass.Text)
                    .perfil_ = txtPerfil.Text
                    .Estad_o = chkHabilitar.Checked
                    .Cod_Perfil = Convert.ToInt32(lblCodPerfil.Text)

                    If .ModificarUsuario = 1 Then
                        MsgBox("El registro se ha modificado correctamente.")
                        Limpiar()
                        dtUsuarios.DataSource = .listarUsuarios
                        btnGuardar.Enabled = True
                        btnModificar.Enabled = False
                    End If

                End With

            ElseIf txtUsuario.Text = "" Then

                txtUsuario.BackColor = Color.Red
            ElseIf txtPerfil.TextAlign = "" Then
                txtPerfil.BackColor = Color.Red

            End If

        Catch ex As Exception
            MsgBox("Hubo un error. " + ex.Message)
        End Try
    End Sub

    ':::::: Función para limpiar campos
    Sub Limpiar()

        txtCodigo.Clear()
        txtUsuario.Clear()
        txtPass.Clear()
        txtPerfil.Clear()
        lblCodPerfil.Text = ""
        txtNombreEmpleado.Clear()
        chkHabilitar.Checked = False

    End Sub

    Private Sub E_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            alternarColoFilasDatagridview(dtUsuarios)
            dtUsuarios.DataSource = usuario.listarUsuarios
            dtUsuarios.Columns("codPerfil").Visible = False

            'bloquear groupbox y campos
            If lblForm.Text = "M_DiarioFacturacion" Then
                Me.Text = "Seleccione un Usuario"
                btnGuardar.Visible = False
                btnModificar.Visible = False
                btnCancelar.Visible = False
                btnCambio.Visible = False
                chkHabilitar.Visible = False
                gbxDatos.Enabled = False
                btnImportar.Enabled = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUsuarios.CellDoubleClick

        Try

            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnCambio.Visible = True

            Limpiar()
            Dim dt As New DataTable
            dt = dtUsuarios.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)
            txtPass.PasswordChar = "*"
            txtCodigo.Text = row("cod_usuario")
            txtUsuario.Text = row("usuario")
            txtPass.Enabled = False
            txtPass.Text = Desencriptar(row("pass"))
            txtPerfil.Text = row("perfil")
            chkHabilitar.Checked = row("estado")
            lblCodPerfil.Text = row("codPerfil")

            'Consultar Nombre de Empleado
            Dim nombre_empleado As New ClsEmpleados
            nombre_empleado.codigo_ = Convert.ToInt32(row("codigo"))
            dt = nombre_empleado.BuscarDatosEmpleadoPorCodigo()
            row = dt.Rows(0)
            txtNombreEmpleado.Text = row("nombreCompleto")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnCambio.Visible = False
        txtPass.Enabled = True

    End Sub

    Private Sub btnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click

        Try
            With usuario

                .Cod = Convert.ToInt32(txtCodigo.Text)
                .CambioPassword()
                MsgBox("Se habilito el cambio de contraseña para el usuario " + txtUsuario.Text + ".")
                Limpiar()
                btnGuardar.Enabled = True
                btnModificar.Enabled = False
                btnCambio.Visible = False
                txtPass.Enabled = True

            End With
        Catch ex As Exception
            MsgBox("Hubo un error al habilitar el cambio de contraseña." + ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            A_ListadoPerfiles.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtUsuarios.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblForm.Text = "M_DiarioFacturacion") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el usuario en el diario de facturación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_ListaPrecios.lblcodeT.Text = lblcode.Text
                    M_DiarioFacturacion.txtUsuario.Text = txtUsuario.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        'Busqueda de usuarios por el campo usuario

        Try

            Dim dt As New DataTable
            Dim user As New ClsUsuario
            If txtBusqueda.Text = "" Then
                dtUsuarios.DataSource = user.listarUsuarios
            Else
                user.Usuario_ = txtBusqueda.Text
                dt = user.BuscarPorUsuario

                dtUsuarios.DataSource = dt

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Try

            M_ListadoEmpleados.lblform.Text = "E_Usuarios"
            M_ListadoEmpleados.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        A_ImportarUserAD.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        A_ConfiguracionFeriados.Show()

    End Sub
End Class