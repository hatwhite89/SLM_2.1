
Imports Microsoft.Office.Interop
Public Class E_frmInventario
    Dim clsA As New clsInventario


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacen(ComboBox1.SelectedValue.ToString).DefaultView

            DataGridView1.DataSource = dvOC
            sumarData1()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub sumarData1()

        Dim existencia, Total, precio As Double
        Dim cantidad As Integer
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            precio = Val(row.Cells(3).Value)
            existencia = Val(row.Cells(2).Value)
            Total += precio * existencia
        Next

        For Each row As DataGridViewRow In Me.DataGridView1.Rows

            cantidad += Val(row.Cells(2).Value)
        Next
        Label18.Text = Total.ToString

        Label19.Text = cantidad.ToString
    End Sub

    Public Sub sumarData2()

        Dim existencia, Total, precio As Double
        Dim cantidad As Integer
        For Each row As DataGridViewRow In Me.DataGridView2.Rows
            precio = Val(row.Cells(3).Value)
            existencia = Val(row.Cells(2).Value)
            Total += precio * existencia
        Next

        For Each row As DataGridViewRow In Me.DataGridView2.Rows

            cantidad += Val(row.Cells(2).Value)
        Next
        Label7.Text = Total.ToString

        Label6.Text = cantidad.ToString
    End Sub

    Public Sub sumarData3()

        Dim existencia, Total, precio As Double
        Dim cantidad As Integer
        For Each row As DataGridViewRow In Me.DataGridView3.Rows
            precio = Val(row.Cells(3).Value)
            existencia = Val(row.Cells(2).Value)
            Total += precio * existencia
        Next

        For Each row As DataGridViewRow In Me.DataGridView3.Rows

            cantidad += Val(row.Cells(2).Value)
        Next
        Label16.Text = Total.ToString

        Label14.Text = cantidad.ToString
    End Sub
    Private Sub E_frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAlmacen()
        ComboAlmacen2()
        ComboAlmacen3()
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView3)
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacenProductoVencido(ComboBox2.SelectedValue.ToString).DefaultView

            DataGridView2.DataSource = dvOC




            sumarData2()
        Catch ex As Exception

        End Try


        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacenProductoVencido(ComboBox3.SelectedValue.ToString).DefaultView

            DataGridView3.DataSource = dvOC




            sumarData3()
        Catch ex As Exception

        End Try

        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacen(ComboBox1.SelectedValue.ToString).DefaultView

            DataGridView1.DataSource = dvOC
            sumarData1()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ComboAlmacen()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "nombre_almacen"
        ComboBox1.ValueMember = "id_almacen"


    End Sub
    Private Sub ComboAlmacen2()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())


        ComboBox2.DataSource = ds
        ComboBox2.DisplayMember = "nombre_almacen"
        ComboBox2.ValueMember = "id_almacen"


    End Sub
    Private Sub ComboAlmacen3()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())

        ComboBox3.DataSource = ds
        ComboBox3.DisplayMember = "nombre_almacen"
        ComboBox3.ValueMember = "id_almacen"


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacenProductoVencido(ComboBox2.SelectedValue.ToString).DefaultView

            DataGridView2.DataSource = dvOC




            sumarData2()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacenSinExistencia(ComboBox3.SelectedValue.ToString).DefaultView

            DataGridView3.DataSource = dvOC

            sumarData3()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub excel_Click(sender As Object, e As EventArgs) Handles excel.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GridAExcel(DataGridView2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel(DataGridView3)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnCargarInventario_Click(sender As Object, e As EventArgs) Handles btnCargarInventario.Click
        'llenar data con inventario completo
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.TotalInventarioAlmacen.DefaultView

            DataGridView1.DataSource = dvOC
            sumarData1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.TotalInventarioAlmacenProductoVencido.DefaultView

            DataGridView2.DataSource = dvOC
            sumarData2()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.TotalInventarioAlmacenSinExistencia.DefaultView

            DataGridView3.DataSource = dvOC
            sumarData3()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Try


            Dim dvProveedor As DataView = clsA.ListarInventarioAlmacenSinExistencia(ComboBox3.SelectedValue.ToString).DefaultView

            dvProveedor.RowFilter = String.Format("CONVERT(nombre_producto+lote, System.String) LIKE '%{0}%'", TextBox6.Text)
            DataGridView3.DataSource = dvProveedor
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try


            Dim dvProveedo2 As DataView = clsA.ListarInventarioAlmacenProductoVencido(ComboBox2.SelectedValue.ToString).DefaultView

            dvProveedo2.RowFilter = String.Format("CONVERT(nombre_producto+lote, System.String) LIKE '%{0}%'", TextBox1.Text)
            DataGridView2.DataSource = dvProveedo2
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try



            Dim dvProveedo3 As DataView = clsA.ListarInventarioAlmacen(ComboBox1.SelectedValue.ToString).DefaultView


            dvProveedo3.RowFilter = String.Format("CONVERT(nombre_producto+lote, System.String) LIKE '%{0}%'", TextBox4.Text)
            DataGridView1.DataSource = dvProveedo3
        Catch ex As Exception

        End Try
    End Sub
End Class