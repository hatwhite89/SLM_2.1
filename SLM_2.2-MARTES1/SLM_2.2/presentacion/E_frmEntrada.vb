Public Class E_frmEntrada
    Private codigo_detalleoc As String
    Private fecha_vencimiento As Date



    Private Sub E_frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView3)
        ComboAlmacen()
        ComboAlmacen2()
        Label22.Text = ""

    End Sub
    Public Sub sumarData()
        Dim Total As Integer = 0

        Try
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Total += Integer.Parse(row.Cells(6).Value)

            Next
        Catch ex As Exception

        End Try

        If Total > 0 Then
            Label22.Text = "*Tiene productos pendientes de ser recibidos en esta orden"
        Else
            Label22.Text = "*No tiene productos pendientes en esta orden de compra"
        End If

    End Sub
    Private Sub cargarInventario()
        Dim clsE As New clsEntradaAlmacen
        Dim dvOC As DataView = clsE.ListarEntradaInventario.DefaultView


    End Sub
    Private Sub ComboAlmacen()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())

        cmbEntrada.DataSource = ds
        cmbEntrada.DisplayMember = "nombre_almacen"
        cmbEntrada.ValueMember = "id_almacen"
    End Sub
    Private Sub ComboAlmacen2()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())

    End Sub

    Private Sub DetalleOC(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOCEntrada(cod).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DetalleOC(TextBox1.Text)
        sumarData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            codigo_detalleoc = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtCodProc.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtLote.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

            txtPrecioUnitario.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value

            txtCantidad.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Dim clsD As New clsDetalleOC
            Dim clsE As New clsEntradaAlmacen
            With clsD
                .IdDetalleOC = Integer.Parse(codigo_detalleoc)
                .Cantidad_recibida1 = Integer.Parse(txtCantidad.Text)
            End With

            With clsE
                .IdProducto = Integer.Parse(txtCodProc.Text)
                .Id_oc1 = Integer.Parse(TextBox1.Text)
                .PrecioUnitario = Double.Parse(txtPrecioUnitario.Text)
                .LoteProducto = txtLote.Text
                .Descripcion = RichTextBox1.Text
                .IdAlmacen = cmbEntrada.SelectedValue
                .FechaVencimiento = DateTimePicker1.Value
                .CantidadProducto = Integer.Parse(txtCantidad.Text)
            End With
            If clsD.ActualizarDetalleOCEntrada() = "1" Then

                If clsE.RegistrarEntradaAlmacen() = "1" Then
                    MsgBox("Se registro una nueva entrada en el almacen ")
                    txtCodProc.Clear()
                    txtPrecioUnitario.Clear()
                    txtProducto.Clear()
                    txtCantidad.Clear()
                    txtLote.Clear()
                    RichTextBox1.Clear()

                End If

                DetalleOC(TextBox1.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        cargarInventario()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)
        cargarInventario()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim clsOCOB As New clsEntradaAlmacen
            Dim dvOC As DataView = clsOCOB.ListarEntradaInventarioFecha(DateTimePicker2.Value.Date, DateTimePicker1.Value.Date).DefaultView
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarDGOCFecha()
        Try
            Dim clsOCOB As New clsEntradaAlmacen
            Dim dvOC As DataView = clsOCOB.ListarEntradaInventarioFecha(DateTimePicker2.Value.Date, DateTimePicker1.Value.Date).DefaultView
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim clsOCOB As New clsEntradaAlmacen
        Dim dv As DataView = clsOCOB.ListarEntradaInventarioFecha(DateTimePicker2.Value.Date, DateTimePicker1.Value.Date).DefaultView

        dv.RowFilter = String.Format("CONVERT(lote+nombre_producto+id_producto, System.String) LIKE '%{0}%'", TextBox2.Text)
        DataGridView3.DataSource = dv

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
        Dim clsOCOB As New clsEntradaAlmacen
        Dim dv As DataView = clsOCOB.ListarEntradaInventarioFecha(DateTimePicker2.Value.Date, DateTimePicker1.Value.Date).DefaultView


        DataGridView3.DataSource = dv
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'modificar entradas 
        Dim clsE As New clsEntradaAlmacen

        With clsE
            .CantidadProducto = TextBox8.Text
            .LoteProducto = TextBox7.Text
            .Id_entrada1 = TextBox5.Text
            .FechaVencimiento = DateTimePicker4.Value.Date
        End With
        If clsE.ActualizarEntradaAlmacen() = "1" Then
            MsgBox("Actualizado exitosamente")
            CargarDGOCFecha()
        End If
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            TextBox4.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value
            TextBox5.Text = DataGridView3.Rows(e.RowIndex).Cells(6).Value
            TextBox6.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value
            TextBox7.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
            TextBox8.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value
            DateTimePicker4.Value = Date.Parse(DataGridView3.Rows(e.RowIndex).Cells(5).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel(DataGridView3)
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