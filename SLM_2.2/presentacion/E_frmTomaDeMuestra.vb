Imports System.Data.SqlClient

Public Class E_frmTomaDeMuestra
    Private Sub E_frmTomaDeMuestra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New clsTomaDeMuestra
            TableUM.Load(clsP.RecuperarPreguntas(TextBox1.Text))
            BindingSource1.DataSource = TableUM

            DataGridView1.DataSource = BindingSource1
        Catch ex As Exception
            MsgBox("La factura que esta ingresando no tiene respuestas registradas")
        End Try

        Try
            Dim dt, dtFact, dtDetalle, dtPreguntas As New DataTable
            Dim rowFact, rowDetalle, rowPreguntas As DataRow
            Dim paciente As New ClsColaPacientes
            Dim codigodeCola As String
            Dim nombre As String




            dt = TraerDatosFactura(TextBox1.Text)
            Dim row As DataRow = dt.Rows(0)
            TextBox2.Text = CStr(row("nombreCompleto"))
            TextBox3.Text = CStr(row("genero"))
            TextBox4.Text = CStr(row("edad"))
        Catch ex As Exception
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End Try
        'Dim rpt As New CrystalReport1
        'rpt.PrintToPrinter(1, False, 1, 1)
    End Sub

    Public Function TraerDatosFactura(factura As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select c.nombreCompleto,c.genero,DATEDIFF(YEAR,c.fechaNacimiento,GETDATE()) as Edad from Factura f, Cliente c
where f.codigoCliente = c.codigo and f.numero ='" + factura + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using

    End Function
End Class