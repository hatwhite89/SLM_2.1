Imports System.Data.SqlClient

Public Class frmEvaluacionProveedorNormal
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcal1.Text = "" Or txtcal2.Text = "" Or txtcal3.Text = "" Or txtcal4.Text = "" Or txtcal5.Text = "" Or txtcal6.Text = "" Or txtcal7.Text = "" Or txtcal8.Text = "" Or txtcal9.Text = "" Or txtcal10.Text = "" Or txtcal11.Text = "" Or txtcal12.Text = "" Or txtcal13.Text = "" Then
            MsgBox("Debe agregar todas las calificaciones")
            Exit Sub
        End If

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
            .Id12c1 = txtcal12.Text
            .Id13c1 = txtcal13.Text
            .Id_proveedor1 = TextBox1.Text
            .Id_usuario1 = codigo_usuario
            .Id_departamento2 = ComboBox1.SelectedValue


        End With
        If cls.RegistraCalificacionProveedor = "1" Then
            MsgBox("Registrado exitosamente")
            Button1.Enabled = False
        End If

        Label37.Text = Format(((Integer.Parse(txtcal1.Text) + Integer.Parse(txtcal2.Text) + Integer.Parse(txtcal3.Text) + Integer.Parse(txtcal4.Text) + Integer.Parse(txtcal5.Text) + Integer.Parse(txtcal6.Text) + Integer.Parse(txtcal7.Text) + Integer.Parse(txtcal8.Text) + Integer.Parse(txtcal9.Text) + Integer.Parse(txtcal10.Text) + Integer.Parse(txtcal11.Text) + Integer.Parse(txtcal12.Text) + Integer.Parse(txtcal13.Text)) / 130) * 100, "0.00")
    End Sub

    Private Sub frmEvaluacionProveedorNormal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoCompletarTexbox(TextBox2)
        autoCompletarTexbox(TextBox6)
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)

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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim cls As New ClsEvaluacionProveedor
        TextBox1.Text = cls.RecuperarCodigoProveedor2(TextBox2.Text)
        cod_proveedor = ""
        Try
            Dim objP As New ClsEvaluacionProveedor

            Dim dt As New DataTable
            dt = objP.listarProveedoresEvaluacionNormal(TextBox1.Text)


            Dim row As DataRow = dt.Rows(0)


            cod_proveedor = CStr(row("id_proveedor"))
            TextBox1.Text = cod_proveedor
            TextBox4.Text = "Calificado"

        Catch ex2 As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Button1.Enabled = True
            TextBox4.Text = "No Calificado"
        Else
            Button1.Enabled = False
            TextBox4.Text = "Calificado"
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Try
            Dim cls As New ClsEvaluacionProveedor
            TextBox7.Text = cls.RecuperarCodigoProveedor2(TextBox6.Text)



        Catch ex2 As Exception

        End Try
    End Sub
    Public Sub sumarData2()

        Dim calificacion, resultado As Double
        Dim cantidad As Integer = 0
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            calificacion += Val(row.Cells(1).Value)
            cantidad += 1

        Next

        resultado = (calificacion / 130)
        Label12.Text = Format(resultado * 100, "0.00")


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.Clear()
        Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13 As String
        Try
            Dim objP As New ClsEvaluacionProveedor

            Dim dt As New DataTable
            dt = objP.listarProveedoresEvaluacionNormal(TextBox7.Text)


            Dim row As DataRow = dt.Rows(0)


            cod_proveedor = CStr(row("id_proveedor"))
            c1 = CStr(row("cal1"))
            c2 = CStr(row("cal2"))
            c3 = CStr(row("cal3"))
            c4 = CStr(row("cal4"))
            c5 = CStr(row("cal5"))
            c6 = CStr(row("cal6"))
            c7 = CStr(row("cal7"))
            c8 = CStr(row("cal8"))
            c9 = CStr(row("cal9"))
            c10 = CStr(row("cal10"))
            c11 = CStr(row("cal11"))
            c12 = CStr(row("cal12"))
            c13 = CStr(row("cal13"))

        Catch ex2 As Exception

        End Try
        Try
            DataGridView1.Rows.Insert(0, New String() {"ES FÁCIL ACCEDER A LA INFORMACION DE LA EMPRESA", c1})
            DataGridView1.Rows.Insert(1, New String() {"PROPORCIONAN PERSONAL PARA CAPACITAR AL PERSONAL AL COMPRAR UN EQUIPO Y/O PRODUCTO NUEVO", c2})
            DataGridView1.Rows.Insert(2, New String() {"REALIZAN ATENCIÓN POST-VENTA DEL PRODUCTO Y/O EQUIPO", c3})
            DataGridView1.Rows.Insert(2, New String() {"CUENTAN CON UN SISTEMA DE CALIDAD", c4})
            DataGridView1.Rows.Insert(2, New String() {"CALIDAD DEL PRODUCTO (Equipo, Reactivo y/o Insumo)", c5})
            DataGridView1.Rows.Insert(2, New String() {"LOS PRECIOS VARÍAN SIN PREVIO AVISO", c6})
            DataGridView1.Rows.Insert(2, New String() {"OFRECEN DESCUENTOS EN LAS COMPRAS", c7})
            DataGridView1.Rows.Insert(2, New String() {"CUENTAN CON POLITICAS DE PAGO AL CRÉDITO", c8})
            DataGridView1.Rows.Insert(2, New String() {"ACEPTAN TODAS LAS FORMAS DE PAGO", c9})
            DataGridView1.Rows.Insert(2, New String() {"PUNTUALIDAD EN LAS ENTREGAS", c10})
            DataGridView1.Rows.Insert(2, New String() {"ENTREGAN PEDIDOS EN SU TOTALIDAD", c11})
            DataGridView1.Rows.Insert(2, New String() {"HAY GARANTIA EN LOS PRODUCTOS Y/O EQUIPO QUE OFRECEN", c12})
            DataGridView1.Rows.Insert(2, New String() {"OFRECEN VARIEDAD DE PRODUCTOS Y/O EQUIPOS EN SU OFERTA COMERCIAL", c13})
            sumarData2()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cls As New clsCalificicacionProveedores
            With cls
                .Id_proveedor1 = Integer.Parse(TextBox7.Text)
            End With


            If cls.EliminarCalificacionProveedor = "1" Then

                MsgBox("Eliminado Exitosamente")
                TextBox6.Clear()
                TextBox7.Clear()
                DataGridView1.Rows.Clear()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim clsOCOB As New clsCalificicacionProveedores
            Dim dvOC As DataView = clsOCOB.ListarProveedoresCalificados.DefaultView
            DataGridView2.DataSource = dvOC
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        importarExcel(DataGridView2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        importarExcel(DataGridView1)
    End Sub
End Class