Public Class E_frmProducto
    Private Sub E_frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenar combobox unidad medida
        Dim clsD As New ClsUnidadMedidaAlmacen
        Dim clsCP As New ClsCategoriaroducto

        Dim ds As New DataTable
        Dim ds2 As New DataTable

        ds.Load(clsD.RecuperarUnidadMedida())
        ds2.Load(clsCP.RecuperarCategoriaProducto())



        cmbUnidadMedida.DataSource = ds
        cmbUnidadMedida.DisplayMember = "nombre_unidad_medida"
        cmbUnidadMedida.ValueMember = "id_unidad_medida"

        'llenar combobox categoria producto
        cmbCategoria.DataSource = ds2
        cmbCategoria.DisplayMember = "nombre_categoria"
        cmbCategoria.ValueMember = "id_categoria_producto"

        txtCantidadMinima.Text = "0"

        cargarData()
        ' DataGridView1.DataSource = TableUM
        'campos 
        txtNombre.ReadOnly = True
        txtModelo.ReadOnly = True
        txtMarca.ReadOnly = True

        txtDescripcion.ReadOnly = True
        txtCantidadMinima.ReadOnly = True
        'botones
        Button1.Enabled = False
    End Sub
    Private Sub cargarData()
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New ClsProducto
            TableUM.Load(clsP.RecuperarProductoOC())
            BindingSource1.DataSource = TableUM

            DataGridView1.DataSource = BindingSource1
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            'seleccionar datos gridview 
            txtCodigo.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtNombre.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtMarca.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtModelo.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            txtDescripcion.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            txtCantidadMinima.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value


            'botones
            Button1.Enabled = True


            'campos 
            txtNombre.ReadOnly = False
            txtModelo.ReadOnly = False
            txtMarca.ReadOnly = False

            txtDescripcion.ReadOnly = False
            txtCantidadMinima.ReadOnly = False
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsP As New ClsProducto

        If txtCodigo.Text = "" Then
            With clsP

                .NombreProducto = txtNombre.Text
                .MarcaProducto = txtMarca.Text
                .ModeloProducto = txtModelo.Text
                .DescripcionProducto = txtDescripcion.Text
                .ExistenciaProducto = "0"
                .CantidadMinimaProducto = Integer.Parse(txtCantidadMinima.Text)
                .UnidadMedida = Integer.Parse(cmbUnidadMedida.SelectedValue)
                .CategoriaProducto = Integer.Parse(cmbCategoria.SelectedValue)
            End With
            If clsP.RegistrarProducto() = "1" Then
                'campos 
                txtNombre.ReadOnly = True
                txtModelo.ReadOnly = True
                txtMarca.ReadOnly = True

                txtDescripcion.ReadOnly = True
                txtCantidadMinima.ReadOnly = True
                'botones
                Button1.Enabled = False
                MsgBox("Registrado exitosamente")
                cargarData()

            End If

        ElseIf txtCodigo.Text <> "" Then
            With clsP
                .IdProducto = Integer.Parse(txtCodigo.Text)
                .NombreProducto = txtNombre.Text
                .MarcaProducto = txtMarca.Text
                .ModeloProducto = txtModelo.Text
                .DescripcionProducto = txtDescripcion.Text
                .ExistenciaProducto = "0"
                .CantidadMinimaProducto = Integer.Parse(txtCantidadMinima.Text)
                .UnidadMedida = Integer.Parse(cmbUnidadMedida.SelectedValue)
                .CategoriaProducto = Integer.Parse(cmbCategoria.SelectedValue)
            End With
            If clsP.ActualizarProducto() = "1" Then
                MsgBox("Actualizado exitosamente")
                cargarData()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'botones
        Button1.Enabled = True
        'campos 
        txtNombre.ReadOnly = False
        txtModelo.ReadOnly = False
        txtMarca.ReadOnly = False

        txtDescripcion.ReadOnly = False
        txtCantidadMinima.ReadOnly = False

        'limpiar
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""

        txtDescripcion.Text = ""
        txtCantidadMinima.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'botones
        Button1.Enabled = False
        'campos 
        txtNombre.ReadOnly = True
        txtModelo.ReadOnly = True
        txtMarca.ReadOnly = True

        txtDescripcion.ReadOnly = True
        txtCantidadMinima.ReadOnly = True

        'limpiar
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""

        txtDescripcion.Text = ""
        txtCantidadMinima.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim objOrd As New ClsProducto


        Dim dv As DataView = objOrd.RecuperarProducto2.DefaultView

        dv.RowFilter = String.Format("CONVERT(nombre_producto, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView1.DataSource = dv


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class