Public Class E_frmProducto
    Private Sub E_frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llenar combobox
        Dim clsD As New ClsUnidadMedidaAlmacen
        Dim ds As New DataTable

        ds.Load(clsD.RecuperarUnidadMedida())


        cmbUnidadMedida.DataSource = ds
        cmbUnidadMedida.DisplayMember = "nombre_unidad_medida"
        cmbUnidadMedida.ValueMember = "id_unidad_medida"

        txtCantidadMinima.Text = "0"

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsP As New ClsProducto
        With clsP
            .NombreProducto = txtNombre.Text
            .MarcaProducto = txtMarca.Text
            .ModeloProducto = txtModelo.Text
            .DescripcionProducto = txtDescripcion.Text
            .CantidadMinimaProducto = Integer.Parse(txtCantidadMinima.Text)
            .UnidadMedida = cmbUnidadMedida.SelectedValue
            .CategoriaProducto = cmbCategoria.SelectedValue
        End With

        If clsP.RegistrarProducto() = "1" Then
            MsgBox("Registrado exitosamente")
        End If
    End Sub
End Class