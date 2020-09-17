Public Class frmMovimientoAlmacen
    Dim id_entrada_almacen, cantidad_actual As String
    Private Sub frmMovimientoAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAlmacen()
        ComboAlmacen2()
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
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
        Dim clsI As New clsEntradaAlmacen

        With clsI
            .Id_entrada1 = id_entrada_almacen
            .CantidadProducto = txtTraslado.Text
            .IdAlmacen = ComboBox2.SelectedValue()
        End With

        If Integer.Parse(txtTraslado.Text) < Integer.Parse(cantidad_actual) Then
            If clsI.TrasladarEntradaAlmacen() = "1" Then
                MsgBox("Tralado de inventarios completado")
                cargarData()
                cargarData2()
            End If
        Else
            MsgBox("La cantidad solicitada excede la existencia")

        End If

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
End Class