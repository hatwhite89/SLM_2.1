
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.Net.Mail

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

End Module
