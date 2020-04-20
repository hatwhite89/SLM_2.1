Public Class A_ConfiguracionCorreo

    Dim servidor As New ClsServidorCorreo
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            With servidor

                .correo_Salida = txtCorreoSalida.Text
                .Password = txtPassword.Text
                .Port = Convert.ToInt32(txtPuerto.Text)
                .Hos_t = txtHost.Text
                .ssl_ok = chkSSL.Checked
                .correo_Entrada = txtCorreoNoti.Text

                If .registrarServidorCorreo = 1 Then
                    MsgBox("Se ha creado el servidor de correo para notificaciones.")
                End If

            End With

        Catch ex As Exception
            MsgBox("No se pudo guardar el registro." + ex.Message)
        End Try
    End Sub

    Private Sub A_ConfiguracionCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        Dim rows As DataRow

        Try

            dt = servidor.verServidor
            rows = dt.Rows(0)
            lblCodigo.Text = rows("cod_Correo")
            txtCorreoSalida.Text = rows("correoSalida")
            txtPassword.Text = rows("pass")
            txtPuerto.Text = rows("puerto")
            txtHost.Text = rows("host")
            chkSSL.Checked = rows("sslOK")
            txtCorreoNoti.Text = rows("correoEntrada")

            If txtCorreoSalida.Text <> "" And txtPassword.Text <> "" And txtPuerto.Text <> "" And txtHost.Text <> "" And txtCorreoNoti.Text <> "" Then

                btnGuardar.Enabled = False
                btnModificar.Enabled = True
            Else
                btnModificar.Enabled = False
                btnGuardar.Enabled = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnProbar_Click(sender As Object, e As EventArgs) Handles btnProbar.Click

        If txtCorreoSalida.Text <> "" And txtPassword.Text <> "" And txtPuerto.Text <> "" And txtHost.Text <> "" And txtCorreoNoti.Text <> "" Then

            enviarMail(txtCorreoSalida.Text, txtPassword.Text, Convert.ToInt32(txtPuerto.Text), chkSSL.Checked, txtHost.Text, txtCorreoNoti.Text, "El correo se configuro exitosamente.")

        Else
            MsgBox("Debe ingresar la información para poder realizar pruebas")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If txtCorreoSalida.Text <> "" And txtPassword.Text <> "" And txtPuerto.Text <> "" And txtHost.Text <> "" And txtCorreoNoti.Text <> "" Then


            With servidor

                .Cod = Convert.ToInt32(lblCodigo.Text)
                .correo_Salida = txtCorreoSalida.Text
                .Password = txtPassword.Text
                .Port = Convert.ToInt32(txtPuerto.Text)
                .Hos_t = txtHost.Text
                .ssl_ok = chkSSL.Checked
                .correo_Entrada = txtCorreoNoti.Text

                If .modificarServidorCorreo = 1 Then
                    MsgBox("Se ha modificado el servidor de correo para notificaciones.")
                End If

            End With

        Else
            MsgBox("No se modificó el servidor, la información está incompleta.")
        End If


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub A_ConfiguracionCorreo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtPuerto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuerto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class