Public Class E_frmInventario
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacen(ComboBox1.SelectedValue.ToString).DefaultView

            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try
    End Sub

    Private Sub E_frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAlmacen()
        ComboAlmacen2()
        ComboAlmacen3()
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

            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            For Each fila In DataGridView2.Rows
                total += Double.Parse(fila.Cells("Column3").Value)
            Next
            Label7.Text = total
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.ListarInventarioAlmacenSinExistencia(ComboBox3.SelectedValue.ToString).DefaultView

            DataGridView3.DataSource = dvOC
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
End Class