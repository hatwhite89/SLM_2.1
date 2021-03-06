﻿Imports System.Data.SqlClient

Public Class E_frmUbicacion
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub E_frmUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Almacen()
        alternarColoFilasDatagridview(DataGridView1)
        autoCompletarTexbox(TextBox1)
    End Sub
    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select  p.nombreCompleto,u.usuario from usuario u, empleados p
where u.codigo =p.codigo", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombreCompleto"))


            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Almacen()
        Dim clsAC As New ClsAlmacen
        Dim dvOC As DataView = clsAC.ListarAlmacenEntrada().DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim clsA As New ClsAlmacen

        If validarGuardar("Almacen") = "1" Then



            If txtCodAlmacen.Text <> "" Then
                With clsA
                    .IdAlmacen = Integer.Parse(txtCodAlmacen.Text)
                    .NombreAlmacen = txtNombreAlmacen.Text
                    .DescripcionAlmacen = txtDescripcion.Text
                    .Nombre_encargado1 = TextBox1.Text
                    .Usuario1 = TextBox2.Text

                End With
                If clsA.ActualizarAlmacen = "1" Then
                    MsgBox(mensaje_actualizacion)
                    Almacen()
                    Exit Sub
                End If
            ElseIf txtCodAlmacen.Text = "" Then
                With clsA

                    .NombreAlmacen = txtNombreAlmacen.Text
                    .DescripcionAlmacen = txtDescripcion.Text
                    .Nombre_encargado1 = TextBox1.Text
                    .Usuario1 = TextBox2.Text
                End With
                If clsA.RegistrarAlmacen() = "1" Then
                    MsgBox(mensaje_registro)
                    Almacen()
                    Exit Sub
                End If

            End If
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtCodAlmacen.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtNombreAlmacen.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtDescripcion.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

            txtDescripcion.ReadOnly = False
            txtNombreAlmacen.ReadOnly = False
            TextBox1.ReadOnly = False
            Button5.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim clsAC As New ClsAlmacen
        Dim dvOC As DataView = clsAC.ListarAlmacenEntrada().DefaultView
        dvOC.RowFilter = String.Format("CONVERT(nombre_almacen, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Limpiar()
        txtCodAlmacen.Clear()
        txtNombreAlmacen.Clear()
        txtDescripcion.Clear()
        txtDescripcion.ReadOnly = False
        txtNombreAlmacen.ReadOnly = False
        TextBox1.ReadOnly = False
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar()
        Button5.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcel(DataGridView1)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtCodAlmacen.Text = ""
        txtDescripcion.Text = ""
        txtNombreAlmacen.Text = ""
        txtCodAlmacen.ReadOnly = True
        txtDescripcion.ReadOnly = True
        txtNombreAlmacen.ReadOnly = True
        Button5.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select u.usuario from usuario u, empleados p
where u.codigo =p.codigo and p.nombreCompleto like '%" + TextBox1.Text + "%'", clsC.getConexion)
            'respuesta = enunciado.ExecuteScalar
            TextBox2.Text = enunciado.ExecuteScalar
            respuesta.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If validarGuardar("Almacen") = "1" Then

            Try
                Dim clsU As New ClsAlmacen
                With clsU
                    .IdAlmacen = txtCodAlmacen.Text
                End With
                If clsU.BajarAlmacen = "1" Then
                    MsgBox(mensaje_dar_baja)
                    Almacen()
                End If
            Catch ex As Exception
                MsgBox("No ha seleccionado ninguna fila")
            End Try

        End If
    End Sub
End Class