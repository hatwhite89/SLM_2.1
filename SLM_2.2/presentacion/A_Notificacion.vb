Imports System.Net.Mail

Public Class A_Notificacion

    Dim x As Integer
    Dim notificacion As New ClsNotificaciones

    Private Sub A_Notificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height)

            My.Computer.Audio.Play(My.Resources.Definite_c47a609e_37f4_4678_9cb8_79a06e5845bb, AudioPlayMode.Background)

            Dim cai As New ClsCAI
            Dim numfact, dias As DataTable
            Dim rowD, rowsF As DataRow

            numfact = cai.ContarFacturas
            dias = cai.DiaVencimiento

            rowD = dias.Rows(0)
            rowsF = numfact.Rows(0)

            'Validacion de Dias faltantes

            If Convert.ToInt32(rowD("diasFaltantes")) < 0 Then

                lblMensajeDias.Text = "**ALERTA** Las facturas ya vencieron."

            Else

                lblMensajeDias.Text = "En " & rowD("diasFaltantes") & " días vence la Facturación."

                lblMensajeFact.Text = "Quedan " & rowsF("disponible") & " facturas disponibles."

            End If

            '::::::::::::::::::::::::::ENVIO DE CORREO CON ALERTA

            Dim notificar As New ClsServidorCorreo
            Dim dt As New DataTable
            Dim row As DataRow

            dt = notificar.verServidor
            row = dt.Rows(0)
            Dim correoSalida As String = row("correoSalida")
            Dim pass As String = row("pass")
            Dim puerto As Integer = Integer.Parse(row("puerto"))
            Dim sslOK As Boolean = row("sslOK")
            Dim host As String = row("host")
            Dim correoNoti As String = row("correoEntrada")
            Dim texto As String = lblMensajeDias.Text + " , " + lblMensajeDias.Text


            enviarMail(correoSalida, pass, puerto, sslOK, host, correoNoti, texto)
            'Mostrar ventana de alerta
            Form1.pbxNoti.Visible = True
            ':::::::::::::::::::::::::::::::FIN DE ALERTA POR CORREO

            'INSERTAR ALERTA EN BD
            Dim nombre, descripcion As String

            nombre = "Advertencia Factura"

            descripcion = lblMensajeDias.Text + "," + lblMensajeFact.Text

            With notificacion

                .nombreAlerta_ = nombre
                .descripcion_ = descripcion
                .estado_ = 0

                .registrarNotificacion()

            End With

        Catch ex As Exception
            MsgBox("Hubo un error al notificar evento de SLM. Detalle: " + ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Cerrar cuando la opacidad sea 0
        If Me.Opacity = 0 Then Me.Close()

        'Contador
        If Not x = 5000 Then x += 0.3

        'Restar en opacidad
        If x < 5000 Then

            Me.Opacity -= 0.003

        End If

        'Deslizar ventana
        If Not Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - 100 Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 2)
        End If

    End Sub

    Private Sub A_Notificacion_Click(sender As Object, e As EventArgs) Handles Me.Click

        Me.Opacity = 100

    End Sub

    Private Sub enviarCorreo()
        'In the shadows of the moon

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("sinergia@laboratoriosmedicos.hn", "Lmsinergia2020")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "mail.laboratoriosmedicos.hn"

            e_mail = New MailMessage()
            'txtfrom.text
            e_mail.From = New MailAddress("sinergia@laboratoriosmedicos.hn")
            'txtto.text
            e_mail.To.Add("mario200924@hotmail.com")
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            'txtMessage.text
            e_mail.Body = "Funciona el envio por correo."
            Smtp_Server.Send(e_mail)

            'omitir mensaje
            MsgBox("Mail Sent")

        Catch ex As Exception
            MsgBox("error correo" + ex.Message)
        End Try
    End Sub



End Class