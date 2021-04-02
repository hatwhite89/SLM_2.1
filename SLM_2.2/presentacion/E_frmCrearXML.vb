Imports System.Xml

Public Class E_frmCrearXML
    Private Sub E_frmCrearXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim writer As New XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory() + "\books.xml", System.Text.Encoding.UTF8)
        ' writer.WriteAttributeString("id", "2")
        writer.WriteStartDocument(True)

        'writer.WriteName("id")


        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Factura")
        writer.WriteAttributeString("id", "novel")


        writer.WriteElementString("num_factura", "Valor")
        writer.WriteElementString("num_cedula", "1")
        writer.WriteElementString("nombre_completo_cliente", "$500.23")
        writer.WriteElementString("fecha_nacimiento", "1")
        writer.WriteElementString("correo", "1")
        writer.WriteElementString("direccion_entrega_sede", "1")
        writer.WriteElementString("medico", "1")
        writer.WriteElementString("status", "1")
        writer.WriteElementString("sexo", "1")
        writer.WriteElementString("total_factura", "1")
        writer.WriteElementString("examen", "1")

        writer.WriteEndDocument()
        writer.Flush()




    End Sub
End Class