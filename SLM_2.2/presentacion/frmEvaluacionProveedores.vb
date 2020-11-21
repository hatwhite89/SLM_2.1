Imports System.Data.SqlClient

Public Class frmEvaluacionProveedores
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcal1.Text = "" Or txtcal2.Text = "" Or txtcal3.Text = "" Or txtcal4.Text = "" Or txtcal5.Text = "" Or txtcal6.Text = "" Or txtcal7.Text = "" Or txtcal8.Text = "" Or txtcal9.Text = "" Or txtcal10.Text = "" Or txtcal11.Text = "" Then
            MsgBox("Debe agregar todas las calificaciones")
            Exit Sub
        End If
        Promediar()
        Dim cls As New clsCalificicacionProveedores
        With cls
            .Id12 = txtcal1.Text
            .Id21 = txtcal2.Text
            .Id31 = txtcal3.Text
            .Id41 = txtcal4.Text
            .Id51 = txtcal5.Text
            .Id61 = txtcal6.Text
            .Id71 = txtcal7.Text
            .Id81 = txtcal8.Text
            .Id91 = txtcal9.Text
            .Id101 = txtcal10.Text
            .Id111 = txtcal11.Text
            .Id_oc1 = TextBox1.Text
            .Id_proveedor1 = cod_proveedor
            .Id_usuario1 = codigo_usuario
            .Id_departamento2 = ComboBox1.SelectedValue


        End With
        If cls.RegistraCalificacion() = "1" Then
            MsgBox("Registrado exitosamente")
            Button1.Enabled = False
        End If
    End Sub
    Public Sub Promediar()
        Dim contador As Integer
        Dim denominador As Integer

        If txtcal1.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal2.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal3.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal4.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal5.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal6.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal7.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal8.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal9.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal10.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal11.Text <> "0" Then
            contador = contador + 100
        End If

        Try
            Dim nota As Double
            nota = ((Integer.Parse(txtcal1.Text) + Integer.Parse(txtcal2.Text) + Integer.Parse(txtcal3.Text) + Integer.Parse(txtcal4.Text) + Integer.Parse(txtcal5.Text) + Integer.Parse(txtcal6.Text) + Integer.Parse(txtcal7.Text) + Integer.Parse(txtcal8.Text) + Integer.Parse(txtcal9.Text) + Integer.Parse(txtcal10.Text) + Integer.Parse(txtcal11.Text)) / contador) * 100
            Label37.Text = Format(nota, "0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Button1.Enabled = False
        Try
            Dim objP As New ClsEvaluacionProveedor
            With objP
                .Id_oc1 = TextBox1.Text
            End With
            Dim dt As New DataTable
            dt = objP.validarOrdenCompra(TextBox1.Text)
            Dim row As DataRow = dt.Rows(0)

            TextBox4.Text = CStr(row("estado"))
            MsgBox("Esta Orden de compra ya se encuentra calificada")

        Catch ex As Exception

            TextBox4.Text = ""

            Try
                Dim objP As New ClsEvaluacionProveedor
                With objP
                    .Id_oc1 = TextBox1.Text
                End With
                Dim dt As New DataTable
                dt = objP.listarProveedoresOC2(TextBox1.Text)
                Dim row As DataRow = dt.Rows(0)

                TextBox2.Text = CStr(row("nombreProveedor"))
                cod_proveedor = CStr(row("codProveedor"))
                Button1.Enabled = True
                MsgBox("Puede calificar esta orden de compra")
                TextBox4.Text = "Sin calificar"
            Catch ex2 As Exception
                MsgBox("No existe esta orden de compra")
                TextBox4.Text = "No existe"
            End Try



        End Try


    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)


    End Sub


    Public Sub sumarData()

        Dim existencia, Total, precio As Double
        Dim cantidad, contador As Integer

        contador = -1
        For Each row As DataGridViewRow In Me.DataGridView1.Rows

            cantidad += Val(row.Cells(6).Value)
            contador += 1
        Next
        Label12.Text = (cantidad / contador).ToString


    End Sub

    Private Sub frmEvaluacionProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        autoCompletarTexbox(TextBox6)

        Dim clsD As New ClsDepartamento

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarDepartamentos)

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "codigo"
    End Sub


    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select * from Proveedor", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombreProveedor"))

            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim cls As New ClsEvaluacionProveedor
        TextBox7.Text = cls.RecuperarCodigoProveedor2(TextBox6.Text)


    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim clsDeOC As New ClsEvaluacionProveedor
            Dim dvOC As DataView = clsDeOC.calcularEvaluacion(TextBox7.Text, DateTimePicker1.Value, DateTimePicker2.Value).DefaultView
            DataGridView1.DataSource = dvOC

            sumarData2()


        Catch ex As Exception

        End Try
    End Sub
    Public Sub sumarData2()

        Dim calificacion, resultado As Double
        Dim cantidad As Integer = 0
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            calificacion += Val(row.Cells(0).Value)
            cantidad += 1

        Next

        resultado = (calificacion / (cantidad - 1))
        Label12.Text = Format(resultado, "0.00")


    End Sub
    Function GridAExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add 'crea el libro de excel 
            exHoja = exLibro.Worksheets.Add() 'cuenta filas y columnas
            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1 'titulo en negritas
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            'alineacion al centro
            exHoja.Columns.AutoFit() 'autoajuste de la columna
            exHoja.Columns.HorizontalAlignment = 2
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(DataGridView1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox6.Clear()
    End Sub
End Class