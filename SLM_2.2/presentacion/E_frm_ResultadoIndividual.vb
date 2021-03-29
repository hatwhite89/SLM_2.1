Imports System.IO
Imports System.Net.Mail

Public Class E_frm_ResultadoIndividual
    Private Sub E_frm_ResultadoIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim RptDocument As New E_ReporteResultadoIndividual

        Try

            'RptDocument.SetParameterValue("@numeroFactura", id_resultado)
            RptDocument.SetParameterValue("@id_orden", id_orden_interna_crystal)

            RptDocument.SetDatabaseLogon("sa", "Lbm2019")
            CrystalReportViewer1.ReportSource = RptDocument
            RptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Path.Combine(Application.StartupPath, "Resultados\resultado" + id_orden_interna_crystal.ToString + ".pdf"))
            'enviarMailResultado("sinergia@laboratoriosmedicos.hn", "Lmsinergia2020", "587", True, "mail.laboratoriosmedicos.hn", "erickgallardo89@yahoo.com", "Resultados")


        Catch ex As Exception

        End Try

    End Sub

    Private Sub enviarMailResultado(correoSalida As String, pass As String, puerto As Integer, sslOK As Boolean, host As String, correoNoti As String, texto As String)

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
            e_mail.Subject = "ENTREGA DE RESULTADOS LABORATORIOS MEDICOS"

            Dim archivos As String = Path.Combine(Application.StartupPath, "Resultados\resultado" + id_orden_interna_crystal + ".pdf")




            Dim archivoAdjunto As New System.Net.Mail.Attachment(archivos)

            e_mail.Attachments.Add(archivoAdjunto)



            e_mail.IsBodyHtml = True
            'txtMessage.text
            Dim body As String
            body = "<p>Buenos dias estimado cliente de Laboratorios Medicos, le adjuntamos los resultados de sus examenes.</p>
<p>Cualquier consulta o duda puede comunicarse al telefono 2222-2222 donde gustosamente le atenderemos.</p>
<p>Agradecemos su confianza.</p>
<p>Laboratorios Medicos.</p>"
            e_mail.Body = body
            Smtp_Server.Send(e_mail)

            'omitir mensaje
            MsgBox("Mail Enviado")

        Catch ex As Exception
            MsgBox("No se envío el correo. " + ex.Message)
        End Try

    End Sub

End Class