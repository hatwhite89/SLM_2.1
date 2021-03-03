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
        alternarColoFilasDatagridview(DataGridView1)
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
            txtMarca.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            txtModelo.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            txtDescripcion.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            txtCantidadMinima.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            txtPrecioProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value


            'botones
            Button1.Enabled = True


            'campos 
            txtNombre.ReadOnly = False
            txtModelo.ReadOnly = False
            txtMarca.ReadOnly = False
            txtPrecioProducto.ReadOnly = False
            txtDescripcion.ReadOnly = False
            txtCantidadMinima.ReadOnly = False
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsP As New ClsProducto
        'validar campos vacios
        If Campo_requerido(txtNombre, Label2) = 1 Then
            Exit Sub
        End If
        If validarGuardar("Producto") = 1 Then
            'registar producto
            If txtCodigo.Text = "" Then
                Try
                    With clsP

                        .NombreProducto = txtNombre.Text
                        .MarcaProducto = txtMarca.Text
                        .ModeloProducto = txtModelo.Text
                        .DescripcionProducto = txtDescripcion.Text
                        .ExistenciaProducto = "0"
                        .CantidadMinimaProducto = Integer.Parse(txtCantidadMinima.Text)
                        .UnidadMedida = Integer.Parse(cmbUnidadMedida.SelectedValue)
                        .CategoriaProducto = Integer.Parse(cmbCategoria.SelectedValue)
                        .Precio_base1 = txtPrecioProducto.Text
                    End With
                Catch ex As Exception
                    MsgBox(mensaje_error_actualizacion)
                    Exit Sub
                End Try
                'actualizar producto
                Try
                    If clsP.RegistrarProducto() = "1" Then
                        'campos 
                        txtNombre.ReadOnly = True
                        txtModelo.ReadOnly = True
                        txtMarca.ReadOnly = True
                        txtPrecioProducto.ReadOnly = True
                        txtDescripcion.ReadOnly = True
                        txtCantidadMinima.ReadOnly = True
                        'botones
                        Button1.Enabled = False
                        MsgBox(mensaje_registro)
                        cargarData()

                    End If
                Catch ex As Exception
                    MsgBox(mensaje_error_registro)
                End Try


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
                    .Precio_base1 = txtPrecioProducto.Text
                End With
                If clsP.ActualizarProducto() = "1" Then
                    MsgBox(mensaje_actualizacion)
                    cargarData()
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'limpiar despues de registar
        'botones
        Button1.Enabled = True
        'campos 
        txtNombre.ReadOnly = False
        txtModelo.ReadOnly = False
        txtMarca.ReadOnly = False

        txtDescripcion.ReadOnly = False
        txtCantidadMinima.ReadOnly = False
        txtPrecioProducto.ReadOnly = False
        'limpiar
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""
        txtPrecioProducto.Text = ""
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
        txtPrecioProducto.ReadOnly = True
        'limpiar
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtModelo.Text = ""
        txtMarca.Text = ""
        txtPrecioProducto.Text = ""
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

        dv.RowFilter = String.Format("CONVERT(nombre_producto+marca+modelo, System.String) LIKE '%{0}%'", txtBuscar.Text)

        DataGridView1.DataSource = dv


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim clsP As New ClsProducto
        With clsP
            .IdProducto = txtCodigo.Text
        End With
        If validarGuardar("Producto") = 1 Then
            Try
                If clsP.BajarProducto = "1" Then
                    MsgBox(mensaje_dar_baja)
                    cargarData()
                End If
            Catch ex As Exception
                MsgBox("No ha seleccionado ninguna fila")
            End Try

        End If
    End Sub
End Class