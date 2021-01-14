Public Class A_CategoriaProveedor

    Dim Categoria As New ClsCategoriaProveedor
    Private Sub A_CategoriaProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_CategoriaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Listar categorias de proveedor
            dtCategorias.DataSource = Categoria.listarCategoriasProveedor


            'BOTONES
            btnCrear.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If txtCodBreve.Text <> "" And txtDescrip.Text <> "" And txtClasifica.Text <> "" Then

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
                        If .registrarNuevaCategoria() = 1 Then
                            MsgBox("Se registro una nueva categoria para proveedores.")
                            Limpiar()

                        End If
                    End With
                Else
                    MsgBox("El Tipo de Clasificación no existe o hubo un error al seleccionarla.")

                End If

                dtCategorias.DataSource = Categoria.listarCategoriasProveedor

            ElseIf txtCodBreve.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtCodBreve.BackColor = Color.Red

            ElseIf txtDescrip.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtDescrip.BackColor = Color.Red

            ElseIf txtClasifica.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtClasifica.BackColor = Color.Red

            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub dtCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCategorias.CellClick
        Try
            'Listar informacion

            Dim dt As New DataTable
            dt = dtCategorias.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)

            lblCodCat.Text = row("codCat") 'oculto
            txtCodBreve.Text = row("codBreve")
            txtDescrip.Text = row("descripcion")
            txtAcreedores.Text = row("ctaAcreedores")
            txtAnticipos.Text = row("ctaAnticipos")
            txtClasifica.Text = row("clasificacion")

            'Habilitar edicion
            btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnCrear.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
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

                btnCrear.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Enabled = True

            Else
                MsgBox("El Tipo de Clasificación no existe o hubo un error al seleccionarla.")

            End If
        Catch ex As Exception

        End Try


    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Sub Limpiar()
        txtCodBreve.Text = ""
        txtDescrip.Text = ""
        txtAcreedores.Text = ""
        txtAnticipos.Text = ""
        txtClasifica.Text = ""

        txtCodBreve.BackColor = Color.White
        txtDescrip.BackColor = Color.White
        txtClasifica.BackColor = Color.White

    End Sub

    Private Sub btnBuscarClas_Click(sender As Object, e As EventArgs) Handles btnBuscarClas.Click
        A_ListarTipoClasificacion.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Limpiar()
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        dtCategorias.DataSource = Categoria.listarCategoriasProveedor

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try

            If txtBusqueda.Text <> "" Then

                Categoria.Descripcio_n = txtBusqueda.Text

                dtCategorias.DataSource = Categoria.buscar()
            Else

                dtCategorias.DataSource = Categoria.listarCategoriasProveedor

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCodBreve_TextChanged(sender As Object, e As EventArgs) Handles txtCodBreve.TextChanged
        If txtCodBreve.BackColor = Color.Red Then
            txtCodBreve.BackColor = Color.White
        End If
    End Sub

    Private Sub txtDescrip_TextChanged(sender As Object, e As EventArgs) Handles txtDescrip.TextChanged
        If txtDescrip.BackColor = Color.Red Then
            txtDescrip.BackColor = Color.White
        End If
    End Sub

    Private Sub txtClasifica_TextChanged(sender As Object, e As EventArgs) Handles txtClasifica.TextChanged
        If txtClasifica.BackColor = Color.Red Then
            txtClasifica.BackColor = Color.White
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class