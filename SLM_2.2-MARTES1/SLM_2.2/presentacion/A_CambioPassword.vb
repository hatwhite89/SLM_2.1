Public Class A_CambioPassword

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        M_InicioSesion.txtusuario.Text = ""
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

        'Cambiar Caracter
        If txtPass.PasswordChar = "*" Then

            txtPass.PasswordChar = ""

        Else

            txtPass.PasswordChar = "*"

        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim n As String = MsgBox("¿Desea guardar la nueva contraseña?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                If txtPass.Text <> "" Then

                    Dim usuario As New ClsUsuario

                    With usuario

                        .Usuario_ = M_InicioSesion.txtusuario.Text
                        .password_ = Encriptar(txtPass.Text)

                        If .CambioPass = 1 Then
                            MsgBox("Se actualizo su contraseña. Ingrese su usuario y nueva contraseña para poder ingresar.")
                            Me.Close()
                            M_InicioSesion.Limpiar()
                        End If

                    End With

                End If
            End If


        Catch ex As Exception
            MsgBox("Ocurrio un error. " + ex.Message)
        End Try

    End Sub

    Private Sub A_CambioPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub A_CambioPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class