Public Class A_CategoriaProveedor

    Dim Categoria As New ClsCategoriaProveedor
    Private Sub A_CategoriaProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_CategoriaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar categorias de proveedor
        dtCategorias.DataSource = Categoria.listarCategoriasProveedor

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Comprobar existencia de Clasificacion
        Dim dt As New DataTable
        Dim Cate As New ClsTipoClasificacion

        Cate.Codigo1 = Convert.ToInt32(txtClasifica.Text)

        dt = Cate.BuscarTipoClasificacionCode

        If dt.Rows.Count > 0 Then
            'Ingresar nueva categoria en base de datos
            With Categoria
                .Codig_o = txtCodBreve.Text
                .Descripcio_n = txtDescrip.Text
                .Cta_Acreedor = txtAcreedores.Text
                .Cta_Anticipos = txtAnticipos.Text
                .Cod_Clasi = Convert.ToInt32(txtClasifica.Text)
                .registrarNuevaCategoria()
            End With
        Else
            MsgBox("El Tipo de Clasificación no existe o hubo un error al seleccionarla.")

        End If

        dtCategorias.DataSource = Categoria.listarCategoriasProveedor

    End Sub

    Private Sub dtCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCategorias.CellClick

        'Listar informacion
        lblCodCat.Text = dtCategorias.Rows(e.RowIndex).Cells(0).Value 'oculto
        txtCodBreve.Text = dtCategorias.Rows(e.RowIndex).Cells(1).Value
        txtDescrip.Text = dtCategorias.Rows(e.RowIndex).Cells(2).Value
        txtAcreedores.Text = dtCategorias.Rows(e.RowIndex).Cells(3).Value
        txtAnticipos.Text = dtCategorias.Rows(e.RowIndex).Cells(4).Value
        txtClasifica.Text = dtCategorias.Rows(e.RowIndex).Cells(5).Value

        'Habilitar edicion
        btnCrear.Visible = True
        btnModificar.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnModificar.Visible = False
        btnGuardar.Visible = True
        btnCrear.Visible = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Comprobar existencia de clasificacion
        Dim dt As New DataTable
        Dim Cate As New ClsTipoClasificacion

        Cate.Codigo1 = Convert.ToInt32(txtClasifica.Text)

        dt = Cate.BuscarTipoClasificacionCode

        If dt.Rows.Count > 0 Then
            'Modificacion de categoria en base de datos
            With Categoria
                'Capturar variables editadas
                .Cod = Convert.ToInt32(lblCodCat.Text) 'campo oculto
                .Codig_o = txtCodBreve.Text
                .Descripcio_n = txtDescrip.Text
                .Cta_Acreedor = txtAcreedores.Text
                .Cta_Anticipos = txtAnticipos.Text
                .Cod_Clasi = Convert.ToInt32(txtClasifica.Text)

                .modificarCategoria()
            End With

            'Actualizar listado
            dtCategorias.DataSource = Categoria.listarCategoriasProveedor
            'Limpiar campos
            Limpiar()

            btnCrear.Visible = False
            btnModificar.Visible = False
            btnGuardar.Visible = True

        Else
            MsgBox("El Tipo de Clasificación no existe o hubo un error al seleccionarla.")

        End If


    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Sub Limpiar()
        txtCodBreve.Text = ""
        txtDescrip.Text = ""
        txtAcreedores.Text = ""
        txtAnticipos.Text = ""
        txtClasifica.Text = ""

    End Sub

    Private Sub btnBuscarClas_Click(sender As Object, e As EventArgs) Handles btnBuscarClas.Click
        A_ListarTipoClasificacion.ShowDialog()
    End Sub
End Class