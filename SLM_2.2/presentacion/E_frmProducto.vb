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
        txtExistencia.Text = 0

        'datagridview
        Dim TableUM As New DataTable
        Dim clsP As New ClsProducto
        TableUM.Load(clsP.RecuperarProductoOC())

        DataGridView1.DataSource = TableUM
        'campos 
        txtNombre.ReadOnly = True
        txtModelo.ReadOnly = True
        txtMarca.ReadOnly = True
        txtExistencia.ReadOnly = True
        txtDescripcion.ReadOnly = True
        txtCantidadMinima.ReadOnly = True
        'botones
        Button1.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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
        txtExistencia.ReadOnly = False
        txtDescripcion.ReadOnly = False
        txtCantidadMinima.ReadOnly = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsP As New ClsProducto
        With clsP
            .IdProducto = Integer.Parse(txtCodigo.Text)
            .NombreProducto = txtNombre.Text
            .MarcaProducto = txtMarca.Text
            .ModeloProducto = txtModelo.Text
            .DescripcionProducto = txtDescripcion.Text
            .ExistenciaProducto = Integer.Parse(txtExistencia.Text)
            .CantidadMinimaProducto = Integer.Parse(txtCantidadMinima.Text)
            .UnidadMedida = Integer.Parse(cmbUnidadMedida.SelectedValue)
            .CategoriaProducto = Integer.Parse(cmbCategoria.SelectedValue)
        End With
        If txtCodigo.Text = "" Then
            If clsP.RegistrarProducto() = "1" Then
                'campos 
                txtNombre.ReadOnly = True
                txtModelo.ReadOnly = True
                txtMarca.ReadOnly = True
                txtExistencia.ReadOnly = True
                txtDescripcion.ReadOnly = True
                txtCantidadMinima.ReadOnly = True
                'botones
                Button1.Enabled = False
                MsgBox("Registrado exitosamente")
            End If

        ElseIf txtCodigo.Text <> "" Then

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'botones
        Button1.Enabled = True
        'campos 
        txtNombre.ReadOnly = False
        txtModelo.ReadOnly = False
        txtMarca.ReadOnly = False
        txtExistencia.ReadOnly = False
        txtDescripcion.ReadOnly = False
        txtCantidadMinima.ReadOnly = False

        'limpiar
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""
        txtExistencia.Text = ""
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
        txtExistencia.ReadOnly = True
        txtDescripcion.ReadOnly = True
        txtCantidadMinima.ReadOnly = True

        'limpiar
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""
        txtExistencia.Text = ""
        txtDescripcion.Text = ""
        txtCantidadMinima.Text = ""
    End Sub

End Class