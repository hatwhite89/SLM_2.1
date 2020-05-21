Public Class E_frmEntrada
    Private codigo_detalleoc As String
    Private fecha_vencimiento As Date



    Private Sub E_frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboAlmacen()
        ComboAlmacen2()

    End Sub
    Private Sub cargarInventario()
        Dim clsE As New clsEntradaAlmacen
        Dim dvOC As DataView = clsE.ListarEntradaInventario.DefaultView

        'dvOC.RowFilter = String.Format("CONVERT(lote, System.String) LIKE '%{0}%'", TextBox5.Text)
        'DataGridView2.DataSource = dvOC
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

        'ComboBox2.DataSource = ds
        'ComboBox2.DisplayMember = "nombre_almacen"
        'ComboBox2.ValueMember = "id_almacen"
    End Sub

    Private Sub DetalleOC(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOCEntrada(cod).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub
    Private Sub CargarAlmacenes()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DetalleOC(TextBox1.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            codigo_detalleoc = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtPrecioUnitario.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            txtLote.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            txtCantidad.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            txtCodProc.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            fecha_vencimiento = Date.Parse(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsD As New clsDetalleOC
        Dim clsE As New clsEntradaAlmacen
        With clsD
            .IdDetalleOC = Integer.Parse(codigo_detalleoc)
        End With

        With clsE
            .IdProducto = Integer.Parse(txtCodProc.Text)
            .CantidadProducto = Double.Parse(txtCantidad.Text)
            .PrecioUnitario = Double.Parse(txtPrecioUnitario.Text)
            .LoteProducto = txtLote.Text
            .Descripcion = RichTextBox1.Text
            .IdAlmacen = cmbEntrada.SelectedValue
            .FechaVencimiento = fecha_vencimiento
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

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        cargarInventario()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)
        cargarInventario()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargarDGOCFecha()
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

        dv.RowFilter = String.Format("CONVERT(lote, System.String) LIKE '%{0}%'", TextBox2.Text)
        DataGridView3.DataSource = dv

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim clsOCOB As New clsEntradaAlmacen
        Dim dv As DataView = clsOCOB.ListarEntradaInventarioFecha(DateTimePicker2.Value.Date, DateTimePicker1.Value.Date).DefaultView

        dv.RowFilter = String.Format("CONVERT(nombre_producto, System.String) LIKE '%{0}%'", TextBox3.Text)
        DataGridView3.DataSource = dv
    End Sub
End Class