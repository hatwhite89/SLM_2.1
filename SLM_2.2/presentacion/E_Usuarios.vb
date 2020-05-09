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

        txtCodigo.Text = ""
        txtUsuario.Text = ""
        txtPass.Text = ""
        txtPerfil.Text = ""
        chkHabilitar.Checked = False

    End Sub

    Private Sub E_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtUsuarios.DataSource = usuario.listarUsuarios

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUsuarios.CellDoubleClick

        Try

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

            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnCambio.Visible = True


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
End Class