Public Class frmMovimientoAlmacen
    Dim id_entrada_almacen, cantidad_actual As String
    Dim id_entradas, nueva_existencia, nuevo_alma, alma_viejo, id_traslado As Integer

    Private Sub frmMovimientoAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAlmacen()
        ComboAlmacen2()
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView3)
        alternarColoFilasDatagridview(DataGridView4)
        alternarColoFilasDatagridview(DataGridView5)
        cargarData5()
    End Sub

    Public Sub cargarData5()
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New clsEntradaAlmacen
            TableUM.Load(clsP.ListarTrasladosEnTransito)
            BindingSource1.DataSource = TableUM

            DataGridView5.DataSource = BindingSource1
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.MovimientoInventarioAlmacen(ComboBox1.SelectedValue.ToString).DefaultView

            DataGridView1.DataSource = dvOC

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim clsA As New clsInventario
        Try

            Dim dvOC As DataView = clsA.MovimientoInventarioAlmacen(ComboBox2.SelectedValue.ToString).DefaultView

            DataGridView2.DataSource = dvOC

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim cantidad, producto, id_producto, lote, entrada, existencia As String
        Try
            entrada = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            id_producto = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            producto = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            lote = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            cantidad_actual = DataGridView1.Rows(e.RowIndex).Cells(4).Value

            txtCodProducto.Text = id_producto
            txtLote.Text = lote
            txtProducto.Text = producto

            id_entrada_almacen = entrada
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Dim clsI As New clsEntradaAlmacen

            With clsI
                .Id_entrada1 = id_entrada_almacen
                .CantidadProducto = txtTraslado.Text
                .IdAlmacen = ComboBox2.SelectedValue()
                .Id_almacen_viejo1 = ComboBox1.SelectedValue
            End With

            If Integer.Parse(txtTraslado.Text) <= Integer.Parse(cantidad_actual) Then
                If clsI.TrasladarEntradaAlmacen() = "1" Then
                    MsgBox("Tralado de inventarios completado")
                    cargarData()
                    cargarData2()
                    txtCodProducto.Text = ""
                    txtProducto.Text = ""
                    txtTraslado.Text = ""
                    txtLote.Text = ""
                End If
            Else
                MsgBox("La cantidad solicitada excede la existencia")

            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un producto del almacen de origen")
        End Try
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub cargarData()
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New clsInventario
            TableUM.Load(clsP.MovimientoInventarioAlmacen2(ComboBox1.SelectedValue().ToString))
            BindingSource1.DataSource = TableUM

            DataGridView1.DataSource = BindingSource1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim objOrd As New clsInventario


        Dim dv As DataView = objOrd.MovimientoInventarioAlmacen(ComboBox2.SelectedValue.ToString).DefaultView
        dv.RowFilter = String.Format("CONVERT(nombre_producto+lote, System.String) LIKE '%{0}%'", TextBox2.Text)
        DataGridView2.DataSource = dv
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim objOrd As New clsInventario


        Dim dv As DataView = objOrd.MovimientoInventarioAlmacen(ComboBox1.SelectedValue.ToString).DefaultView
        dv.RowFilter = String.Format("CONVERT(nombre_producto+lote, System.String) LIKE '%{0}%'", TextBox1.Text)
        DataGridView1.DataSource = dv
    End Sub

    Private Sub excel_Click(sender As Object, e As EventArgs) Handles excel.Click
        GridAExcel(DataGridView3)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New clsEntradaAlmacen
            TableUM.Load(clsP.ListarTrasladosFecha(DateTimePicker3.Value, DateTimePicker4.Value))
            BindingSource1.DataSource = TableUM

            DataGridView3.DataSource = BindingSource1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargarData2()
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New clsInventario
            TableUM.Load(clsP.MovimientoInventarioAlmacen2(ComboBox2.SelectedValue().ToString))
            BindingSource2.DataSource = TableUM

            DataGridView2.DataSource = BindingSource2
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New clsEntradaAlmacen
            TableUM.Load(clsP.ListarTrasladosFecha2(DateTimePicker1.Value, DateTimePicker2.Value))
            BindingSource1.DataSource = TableUM

            DataGridView4.DataSource = BindingSource1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        Try
            TextBox3.Text = DataGridView5.Rows(e.RowIndex).Cells(0).Value
            id_traslado = Integer.Parse(DataGridView5.Rows(e.RowIndex).Cells(0).Value)
            id_entradas = Integer.Parse(DataGridView5.Rows(e.RowIndex).Cells(9).Value)
            nueva_existencia = Integer.Parse(DataGridView5.Rows(e.RowIndex).Cells(5).Value)
            nuevo_alma = Integer.Parse(DataGridView5.Rows(e.RowIndex).Cells(11).Value)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim clsI As New clsEntradaAlmacen
        With clsI
            .Id_entrada1 = id_entradas
            .CantidadProducto = nueva_existencia
            .IdAlmacen = nuevo_alma
            .Id_traslado1 = id_traslado
        End With

        If clsI.AceptarTraslado() = "1" Then
            MsgBox("Aceptado")
            cargarData5()
        End If
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
End Class