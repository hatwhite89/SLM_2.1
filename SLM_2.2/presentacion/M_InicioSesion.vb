Public Class M_InicioSesion
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click

        'Login

        Try

            Dim usuario As New ClsUsuario

            With usuario

                .Usuario_ = txtusuario.Text
                .password_ = Encriptar(txtPassword.Text)

            End With

            Dim dt As New DataTable
            Dim row As DataRow

            dt = usuario.Login

            If dt.Rows.Count < 0 Then
                MsgBox("Error al ingresar. Verifique usuario y contraseña.")
            Else
                row = dt.Rows(0)
                If row("estado") = 0 Then

                    MsgBox("Su usuario ha sido deshabilitado. Contactar al administrador")

                Else

                    Form1.Show()
                    Form1.lblMiUser.Text = txtusuario.Text
                    txtusuario.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()

                End If

            End If

        Catch ex As Exception
            MsgBox("El usuario no existe o hubo un error.")
        End Try

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub M_InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinEngine1.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Sports\SportsBlue.ssk"

    End Sub
End Class