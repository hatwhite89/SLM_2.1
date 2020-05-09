
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Security.Cryptography

Module ModulosVarios

    '::::::::::::::::::::::::::::: Importar Excel ::::::::::::::::::::::::
    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        If myFileDialog.FileName.ToString <> "" Then

            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Ingrese el nombre de la hoja a importar", "Complete")
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"

            Catch ex As Exception
                MsgBox("Inserte un nombre válido de la Hoja que desea importar.", MsgBoxStyle.Information, "Información")
            Finally
                conn.Close()
            End Try

            MsgBox("Se ha cargado la importación correctamente. ", MsgBoxStyle.Information, "Importado con exito")

        Else

            MsgBox("No se logro la importación.")

        End If

    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::Final Importar Excel

    '::::::::::::::::::::::::::::: Numeros y Comas :::::::::::::::::::::::::::

    Public CODIGOSEPARADOR As Char = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator


    Sub NUMEROSCOMA(EV As KeyPressEventArgs, DECIMALES As Integer, TXB As TextBox)

        'PALNUMEROS(e, 2, sender)
        'El 2 es la cantidad de decimales 

        If DECIMALES < 0 Then DECIMALES = 0

        If EV.KeyChar = Convert.ToChar(Keys.Return) Then
            EV.Handled = True
            TXB.Focus()
        ElseIf EV.KeyChar = ","c Then
            If (TXB.Text.IndexOf(","c) >= 0) Or (DECIMALES = 0) Then
                EV.Handled = True
            Else
                EV.KeyChar = CODIGOSEPARADOR  REM","c
            End If
        ElseIf EV.KeyChar = "-"c And TXB.TextLength = 0 Then
            EV.KeyChar = "-"c
        ElseIf TXB.Text.IndexOf(","c) > 0 Then
            If (TXB.Text.Length - TXB.Text.IndexOf(","c) > DECIMALES) And (TXB.SelectionStart > TXB.Text.IndexOf(","c)) And (Not (Char.IsControl(EV.KeyChar))) Then
                EV.Handled = True
            End If
        ElseIf Not (Char.IsControl(EV.KeyChar) Or Char.IsDigit(EV.KeyChar)) Then
            EV.Handled = True
        End If
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::Final Numeros y Comas


    '::::::::::::::::::::::::::::: Numeros y Puntos :::::::::::::::::::::::::::

    Public CODIGOSEPARA As Char = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator

    Sub NUMEROSPUNTO(EV As KeyPressEventArgs, DECIMALES As Integer, TXB As TextBox)

        'PALNUMEROS(e, 2, sender)
        'El 2 es la cantidad de decimales 

        If DECIMALES < 0 Then DECIMALES = 0

        If EV.KeyChar = Convert.ToChar(Keys.Return) Then
            EV.Handled = True
            TXB.Focus()
        ElseIf EV.KeyChar = "."c Then
            If (TXB.Text.IndexOf(","c) >= 0) Or (DECIMALES = 0) Then
                EV.Handled = True
            Else
                EV.KeyChar = CODIGOSEPARA  REM","c
            End If
        ElseIf EV.KeyChar = "-"c And TXB.TextLength = 0 Then
            EV.KeyChar = "-"c
        ElseIf TXB.Text.IndexOf(","c) > 0 Then
            If (TXB.Text.Length - TXB.Text.IndexOf(","c) > DECIMALES) And (TXB.SelectionStart > TXB.Text.IndexOf(","c)) And (Not (Char.IsControl(EV.KeyChar))) Then
                EV.Handled = True
            End If
        ElseIf Not (Char.IsControl(EV.KeyChar) Or Char.IsDigit(EV.KeyChar)) Then
            EV.Handled = True
        End If
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::Final Numeros y Punto



    ':::::::::::::::::::::::::: ENVIO DE CORREO ELECTRONICO::::::::::::::::::::::::::::
    'Enviar correo Dinamico
    Sub enviarMail(correoSalida As String, pass As String, puerto As Integer, sslOK As Boolean, host As String, correoNoti As String, texto As String)

        'In the shadows of the moon

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(correoSalida, pass)
            Smtp_Server.Port = puerto
            Smtp_Server.EnableSsl = sslOK
            Smtp_Server.Host = host

            e_mail = New MailMessage()
            'txtfrom.text
            e_mail.From = New MailAddress(correoSalida)
            'txtto.text
            e_mail.To.Add(correoNoti)
            e_mail.Subject = "ALERTA DE SISTEMA"
            e_mail.IsBodyHtml = False
            'txtMessage.text
            e_mail.Body = texto
            Smtp_Server.Send(e_mail)

            'omitir mensaje
            MsgBox("Mail Sent")

        Catch ex As Exception
            MsgBox("No se envío el correo. " + ex.Message)
        End Try

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: Final envio de Correo Electronico




    ':::::::::::::::::::::::::::::::::::::: Encriptar Password

    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function
    ':::::::::::::::::::::::::::::::::::::: Final Encriptar Password


    ':::::::::::::::::::::::::::::::::::::: Desencriptar Password

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    ':::::::::::::::::::::::::::::::::::::: Final desencriptar Password



    ':::::::::::::::::::::::::::::::::::::: LOGIN
    Public Function LOGIN(User As String, Password As String)
        Try

            Dim usuario As New ClsUsuario

            With usuario

                .Usuario_ = User
                .password_ = Encriptar(Password)

            End With

            Dim dt As New DataTable
            Dim row As DataRow

            dt = usuario.Login

            If dt.Rows.Count < 0 Then 'Verificar existencia
                MsgBox("Error al ingresar. Verifique usuario y contraseña.")
            Else
                row = dt.Rows(0)
                If row("estado") = 0 Then

                    MsgBox("Su usuario ha sido deshabilitado. Contactar al administrador")

                Else

                    Form1.Show()
                    Form1.lblMiUser.Text = User
                    Form1.lblUserCod.Text = row("cod_usuario")
                    M_InicioSesion.txtusuario.Text = ""
                    M_InicioSesion.txtPassword.Text = ""
                    M_InicioSesion.Hide()

                End If

            End If ' final verificar existencia

        Catch ex As Exception
            MsgBox("Usuario o contraseña incorrectos. Vuelva a intentarlo.")
        End Try

    End Function




    ':::::::::::::::::::::::::::::::::::::::::::: FINAL LOGIN



    ':::::::::::::::::::::::::::::::::::::::::::: LOGIN PASS

    Public Function LOGINPASS(User As String)
        Try

            Dim usuario As New ClsUsuario

            With usuario

                .Usuario_ = User

            End With

            Dim dt As New DataTable
            Dim row As DataRow

            dt = usuario.LoginPass
            row = dt.Rows(0)

            If row("pass") = "#changepass#" Then
                A_CambioPassword.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox("Usuario incorrecto o hubo un error al realizar la consulta. Vuelva a intentarlo.")
        End Try

    End Function

    ':::::::::::::::::::::::::::::::::::::::::::: FINAL LOGIN

End Module
