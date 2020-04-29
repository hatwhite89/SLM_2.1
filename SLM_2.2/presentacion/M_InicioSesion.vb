Public Class M_InicioSesion
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click

        'Login
        LOGIN(txtusuario.Text, txtPassword.Text)

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub M_InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub


    ' Sub INICIO_DE_SESION()
    'try

    '        dim usuario as new clsusuario

    '        with usuario

    '            .usuario_ = txtusuario.text
    '            .password_ = encriptar(txtpassword.text)

    '        end with

    '        dim dt as new datatable
    '        dim row as datarow

    '        dt = usuario.login

    '        if dt.rows.count < 0 then
    '            msgbox("error al ingresar. verifique usuario y contraseña.")
    '        else
    '            row = dt.rows(0)
    '            if row("estado") = 0 then

    '                msgbox("su usuario ha sido deshabilitado. contactar al administrador")

    '            else

    '                form1.show()
    '                form1.lblmiuser.text = txtusuario.text
    '                form1.lblusercod.text = row("cod_usuario")
    '                txtusuario.text = ""
    '                txtpassword.text = ""
    '                me.hide()

    '            end if

    '        end if

    '    catch ex as exception
    '        msgbox("el usuario no existe o hubo un error.")
    '    end try


    'end sub



End Class