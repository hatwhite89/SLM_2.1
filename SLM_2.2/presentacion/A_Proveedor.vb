Public Class A_Proveedor
    Dim Proveedor As New ClsProveedor

    Private Sub A_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtProveedores.DataSource = Proveedor.listarProveedores
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        If txtCategoria.Text <> "" Then 'Comprobar si el campo categoria esta vacio.

            Dim cate As New ClsCategoriaProveedor
            Dim dt As New DataTable

            'Comprobar que la categoria de proveedor existe
            cate.Cod = Convert.ToInt32(lblCodCategoria.Text)
            dt = cate.buscarCategoria

            If dt.Rows.Count > 0 Then
                Try
                    With Proveedor
                        ' Capturar variables
                        .Cod_Breve = txtCodBreve.Text
                        .Cod_BreveCate = txtCategoria.Text
                        .Id_Tributario = txtIdTribu.Text
                        .Nombre_Proveedor = txtNombreProvee.Text
                        .Telefo_no = txtTelefono.Text
                        .Contacto_Principal = txtContactoPrincipal.Text
                        .Telefono_ContactoPrincipal = txtTelContacto.Text
                        .Emai_l = txtEmail.Text
                        .Direcci_on = txtDireccion.Text
                        .Sitio_Web = txtSitioWeb.Text
                        .Cod_Cate = Convert.ToInt32(lblCodCategoria.Text)
                        ' Registrar proveedor en base de datos
                        .registrarNuevoProveedor()
                        MsgBox("El registro se ha guardado exitosamente.")
                        Limpiar()
                        'Actualizar listado de proveedores
                        dtProveedores.DataSource = Proveedor.listarProveedores

                    End With
                Catch ex As Exception
                    MessageBox.Show("Error al guardar. Detalle: " + ex.Message)
                End Try

            Else

                MsgBox("La Categoria de Proveedor no existe.")

            End If
        Else
            MsgBox("El campo Categoria esta vacio.")

        End If



    End Sub

    Private Sub dtProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtProveedores.CellClick

        Try
            lblCodProveedor.Text = dtProveedores.Rows(e.RowIndex).Cells(0).Value
            txtCodBreve.Text = dtProveedores.Rows(e.RowIndex).Cells(1).Value
            txtCategoria.Text = dtProveedores.Rows(e.RowIndex).Cells(2).Value
            txtIdTribu.Text = dtProveedores.Rows(e.RowIndex).Cells(3).Value
            txtNombreProvee.Text = dtProveedores.Rows(e.RowIndex).Cells(4).Value
            txtTelefono.Text = dtProveedores.Rows(e.RowIndex).Cells(5).Value
            txtContactoPrincipal.Text = dtProveedores.Rows(e.RowIndex).Cells(6).Value
            txtTelContacto.Text = dtProveedores.Rows(e.RowIndex).Cells(7).Value
            txtEmail.Text = dtProveedores.Rows(e.RowIndex).Cells(8).Value
            txtDireccion.Text = dtProveedores.Rows(e.RowIndex).Cells(9).Value
            txtSitioWeb.Text = dtProveedores.Rows(e.RowIndex).Cells(10).Value
            lblCodCategoria.Text = dtProveedores.Rows(e.RowIndex).Cells(11).Value

            'Habilitar botones
            btnGuardar.Visible = False
            btnModificar.Visible = True
            btnCrear.Visible = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        If txtCategoria.Text <> "" Then ' Comprobar que el campo categoria no este vacio.

            Dim cate As New ClsCategoriaProveedor
            Dim dt As New DataTable

            'Comprobar que la categoria de proveedor existe
            cate.Cod = Convert.ToInt32(lblCodCategoria.Text)
            dt = cate.buscarCategoria

            If dt.Rows.Count > 0 Then

                With Proveedor
                    ' Capturar variables
                    .Cod_Proveedor = lblCodProveedor.Text
                    .Cod_Breve = txtCodBreve.Text
                    .Cod_BreveCate = txtCategoria.Text
                    .Id_Tributario = txtIdTribu.Text
                    .Nombre_Proveedor = txtNombreProvee.Text
                    .Telefo_no = txtTelefono.Text
                    .Contacto_Principal = txtContactoPrincipal.Text
                    .Telefono_ContactoPrincipal = txtTelContacto.Text
                    .Emai_l = txtEmail.Text
                    .Direcci_on = txtDireccion.Text
                    .Sitio_Web = txtSitioWeb.Text
                    .Cod_Cate = Convert.ToInt32(lblCodCategoria.Text)
                    ' Registrar proveedor en base de datos
                    .ModificarProveedor()
                    Limpiar()
                    'Actualizar listado de proveedores
                    dtProveedores.DataSource = Proveedor.listarProveedores

                End With

            Else

                MsgBox("La Categoria de Proveedor no existe.")

            End If

        Else
            MsgBox("El campo Categoria esta vacio.")
        End If

    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub A_Proveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtNombreBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtNombreBusqueda.TextChanged

        'Busqueda de Proveedor

        Dim Dato As New DataView

        'Actualizar datos en datagrid con textbox
        Proveedor.Nombre_Proveedor = txtNombreBusqueda.Text
        Dato = Proveedor.buscarProveedor.DefaultView
        dtProveedores.DataSource = Dato

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtProveedores.DataSource = Proveedor.listarProveedores
        txtNombreBusqueda.Text = ""
    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub Limpiar()

        txtCodBreve.Text = ""
        txtNombreProvee.Text = ""
        txtTelefono.Text = ""
        txtContactoPrincipal.Text = ""
        txtTelContacto.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""
        txtSitioWeb.Text = ""
        txtCategoria.Text = ""

    End Sub

    Private Sub btnBuscarCate_Click(sender As Object, e As EventArgs) Handles btnBuscarCate.Click
        A_ListarCategoriasProveedor.ShowDialog()
    End Sub
End Class