Public Class M_InicioSesion
    Public clsL As New clsLogs
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click


        'Login

        If txtUsuario.Text <> "" And txtPassword.Text <> "" Then

            LOGIN(txtUsuario.Text, txtPassword.Text)
            'Limpiar()


        ElseIf txtUsuario.Text <> "" And txtPassword.Text = "" Then

            LOGINPASS(txtUsuario.Text)

        Else

            MsgBox("Error al ingresar al sistema. Debe ingresar usuario y contraseña.")
            With clsL
                .Usuario = txtUsuario.Text
                .Accion = "Intento Fallida De LOGIN"
            End With
            clsL.RegistrarInicioSesion()
        End If

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        ElseIf (e.KeyCode = Keys.Enter) Then
            btnInicioSesion.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Sub Limpiar()
        txtUsuario.Text = "Usuario"
        txtPassword.Text = "Contraseña"
    End Sub

    Private Sub M_InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UI_TitleBanner1_Click(sender As Object, e As EventArgs) Handles UI_TitleBanner1.Click

    End Sub
End Class