﻿Public Class A_Proveedor
    Dim Proveedor As New ClsProveedor
    Dim codigoDetalleContacto As ArrayList = New ArrayList()

    Private Sub A_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'lista los proveedores
            dgvProveedores.DataSource = Proveedor.listarProveedores

            'estado del formulario
            lblEstado.Text = "Nuevo"

            'oculta el campo codigo
            Me.dgvDetalleContactos.Columns("codigo").Visible = False

            'agrega el boton para eliminar contactos
            If dgvDetalleContactos.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dgvDetalleContactos.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If

            'llena el combo box con las categorias de proveedores existentes
            Dim objCatProv As New ClsCategoriaProveedor
            Dim dt As New DataTable
            dt = objCatProv.listarCategoriasProveedor()
            Dim row As DataRow
            cbxCategoria.Items.Clear()
            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                cbxCategoria.Items.Add(CStr(row("descripcion")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub dgvDetalleContactos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleContactos.CellClick
        Try

            If e.ColumnIndex = 4 And dgvDetalleContactos.Rows(e.RowIndex).Cells(1).Value <> "" Then
                Dim n As String = MsgBox("¿Desea eliminar el contacto?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    dgvDetalleContactos.Rows.Remove(dgvDetalleContactos.Rows(e.RowIndex.ToString))
                End If

            ElseIf e.ColumnIndex = 4 And lblEstado.Text = "Modificar" And Me.dgvDetalleContactos.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                Dim n As String = MsgBox("¿Desea eliminar la factura del recibo?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    codigoDetalleContacto.Add(Me.dgvDetalleContactos.Rows(e.RowIndex).Cells(0).Value())
                    dgvDetalleContactos.Rows.Remove(dgvDetalleContactos.Rows(e.RowIndex.ToString))
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Comprobar si los campos no estan vacios.
        If txtNombreProvee.Text <> "" And txtCodBreve.Text <> "" And txtCodigoTerminoPago.Text <> "" Then
            Try

                With Proveedor
                    ' Capturar variables
                    .Cod_Breve = txtCodBreve.Text
                    .Id_Tributario = txtIdTribu.Text
                    .Nombre_Proveedor = txtNombreProvee.Text
                    .Telefo_no = txtTelefono.Text
                    .Emai_l = txtEmail.Text
                    .Direcci_on = txtDireccion.Text
                    .Sitio_Web = txtSitioWeb.Text
                    .Cod_Cate = Convert.ToInt32(cbxCategoria.SelectedIndex.ToString) + 1
                    .cod_TermPago = Convert.ToInt32(lblCodeTerminoPago.Text)

                    Limpiar()
                    'Actualizar listado de proveedores
                    dgvProveedores.DataSource = Proveedor.listarProveedores

                End With
                ' Registrar proveedor en base de datos
                If Proveedor.registrarNuevoProveedor() = 1 Then
                    'deshabilitar()
                    btnGuardar.Enabled = False
                    Dim dt As New DataTable
                    dt = Proveedor.obtenerProveedor()
                    Dim row As DataRow = dt.Rows(0)

                    txtCodProveedor.Text = CStr(row("codProveedor"))
                    Dim objDetCont As New ClsDetalleContactos
                    For index As Integer = 0 To dgvDetalleContactos.Rows.Count - 2
                        With objDetCont
                            .codProveedor_ = txtCodProveedor.Text
                            .nombre_ = dgvDetalleContactos.Rows(index).Cells(1).Value()
                            .telefono_ = dgvDetalleContactos.Rows(index).Cells(2).Value()
                            .correo_ = dgvDetalleContactos.Rows(index).Cells(3).Value()
                        End With
                        If objDetCont.RegistrarNuevoDetalleContactos() = 0 Then
                            MsgBox("Error al querer insertar el contacto.")
                        End If
                    Next
                    MsgBox("El registro se ha guardado exitosamente.")
                Else
                    MsgBox("Error al querer ingresar el proveedor.", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al guardar. Detalle: " + ex.Message)
            End Try

        End If
    End Sub

    Private Sub dtProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick

        Try
            txtCodProveedor.Text = dgvProveedores.Rows(e.RowIndex).Cells(0).Value
            txtCodBreve.Text = dgvProveedores.Rows(e.RowIndex).Cells(1).Value
            txtIdTribu.Text = dgvProveedores.Rows(e.RowIndex).Cells(2).Value
            txtNombreProvee.Text = dgvProveedores.Rows(e.RowIndex).Cells(3).Value
            txtTelefono.Text = dgvProveedores.Rows(e.RowIndex).Cells(4).Value
            txtEmail.Text = dgvProveedores.Rows(e.RowIndex).Cells(5).Value
            txtDireccion.Text = dgvProveedores.Rows(e.RowIndex).Cells(6).Value
            txtSitioWeb.Text = dgvProveedores.Rows(e.RowIndex).Cells(7).Value
            Dim temp As Integer = Me.dgvProveedores.Rows(e.RowIndex).Cells(8).Value().ToString
            cbxCategoria.SelectedIndex = temp - 1
            lblCodeTerminoPago.Text = dgvProveedores.Rows(e.RowIndex).Cells(9).Value
            'cambio del estado del formulario
            lblEstado.Text = "Modificar"

            'Búsqueda y llenado del detalle contacto
            Dim objDetCont As New ClsDetalleContactos
            objDetCont.codProveedor_ = txtCodProveedor.Text
            Dim dt As New DataTable
            dt = objDetCont.BuscarDetalleContactos()
            Dim row As DataRow
            dgvDetalleContactos.Rows.Clear()
            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                dgvDetalleContactos.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("telefono")), CStr(row("correo"))})
            Next

            'Habilitar botones
            btnGuardar.Visible = False
            btnModificar.Visible = True
            btnNuevo.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            'Comprobar si los campos no estan vacios.
            If txtNombreProvee.Text <> "" And txtCodBreve.Text <> "" And txtCodigoTerminoPago.Text <> "" Then
                With Proveedor
                    ' Capturar variables
                    .Cod_Proveedor = txtCodProveedor.Text
                    .Cod_Breve = txtCodBreve.Text
                    .Id_Tributario = txtIdTribu.Text
                    .Nombre_Proveedor = txtNombreProvee.Text
                    .Telefo_no = txtTelefono.Text
                    .Emai_l = txtEmail.Text
                    .Direcci_on = txtDireccion.Text
                    .Sitio_Web = txtSitioWeb.Text
                    .Cod_Cate = Convert.ToInt32(cbxCategoria.SelectedIndex.ToString) + 1
                    .cod_TermPago = Convert.ToInt32(lblCodeTerminoPago.Text)
                End With
                'Actualizar listado de proveedores
                dgvProveedores.DataSource = Proveedor.listarProveedores
                'Modifica el proveedor
                If Proveedor.ModificarProveedor() = 1 Then
                    btnGuardar.Enabled = False

                    Dim objDetCont As New ClsDetalleContactos
                    For index As Integer = 0 To codigoDetalleContacto.Count - 1
                        objDetCont.codigo_ = Convert.ToInt64(codigoDetalleContacto(index))
                        If objDetCont.EliminarDetalleContactos() <> 1 Then
                            MsgBox("Error al querer modificar el recibo")
                        End If
                    Next
                    'limpiar el arraylist
                    codigoDetalleContacto.Clear()
                    'modificar y agregar nuevos contactos a la base de datos
                    For index As Integer = 0 To dgvDetalleContactos.Rows.Count - 2
                        If (dgvDetalleContactos.Rows(index).Cells(0).Value() = "") Then
                            'nuevos
                            With objDetCont
                                .codProveedor_ = txtCodProveedor.Text
                                .nombre_ = dgvDetalleContactos.Rows(index).Cells(1).Value()
                                .telefono_ = dgvDetalleContactos.Rows(index).Cells(2).Value()
                                .correo_ = dgvDetalleContactos.Rows(index).Cells(3).Value()
                            End With
                            If objDetCont.RegistrarNuevoDetalleContactos() = 0 Then
                                MsgBox("Error al querer modificar el contacto.")
                            End If
                        Else
                            'actualiza los contactos
                            With objDetCont
                                .codigo_ = dgvDetalleContactos.Rows(index).Cells(0).Value()
                                .codProveedor_ = txtCodProveedor.Text
                                .nombre_ = dgvDetalleContactos.Rows(index).Cells(1).Value()
                                .telefono_ = dgvDetalleContactos.Rows(index).Cells(2).Value()
                                .correo_ = dgvDetalleContactos.Rows(index).Cells(3).Value()
                            End With
                            If objDetCont.ModificarDetalleContactos() = 0 Then
                                MsgBox("Error al querer modificar el contacto.")
                            End If
                        End If
                    Next
                    'limpia lo ingresado 
                    Limpiar()
                    'muestra el mensaje 
                    MsgBox("El registro se ha modificado exitosamente.")
                Else
                    MsgBox("Error al querer modificar el proveedor.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        lblEstado.Text = "Nuevo"
        btnNuevo.Visible = False
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
        dgvProveedores.DataSource = Dato

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiarBusqueda.Click
        dgvProveedores.DataSource = Proveedor.listarProveedores
        txtNombreBusqueda.Text = ""
    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Private Sub Limpiar()

        Try

            txtCodProveedor.Text = ""
            txtCodBreve.Text = ""
            txtNombreProvee.Text = ""
            txtTelefono.Text = ""
            txtCodigoTerminoPago.Text = ""
            txtEmail.Text = ""
            txtDireccion.Text = ""
            txtSitioWeb.Text = ""
            txtCodigoTerminoPago.Text = "CO"
            dgvDetalleContactos.Rows.Clear()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscarCate_Click(sender As Object, e As EventArgs)
        A_ListarCategoriasProveedor.ShowDialog()
    End Sub

    Private Sub txtCodigoTerminoPago_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoTerminoPago.TextChanged
        If (txtCodigoTerminoPago.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigoTerminoPago_ = txtCodigoTerminoPago.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarTerminoPagoCode()
                Dim row As DataRow = dt.Rows(0)
                'txtdescripcionTermino.Text = CStr(row("descripcion"))
                lblCodeTerminoPago.Text = CStr(row("codigo"))
                txtCodigoTerminoPago.BackColor = Color.White
            Catch ex As Exception
                txtCodigoTerminoPago.BackColor = Color.Red
                'txtdescripcionTermino.Text = ""
            End Try
        Else
            txtCodigoTerminoPago.Text = ""
            'txtdescripcionTermino.Text = ""
            lblCodeTerminoPago.Text = ""
            txtCodigoTerminoPago.BackColor = Color.White
        End If
    End Sub
    Private Sub lblcodeTerminoPago_TextChanged(sender As Object, e As EventArgs) Handles lblCodeTerminoPago.TextChanged
        Try
            Dim objTerm As New ClsTerminoPago
            With objTerm
                .codigo_ = lblCodeTerminoPago.Text
            End With
            Dim dt As New DataTable
            dt = objTerm.BuscarTerminoPagoNumero()
            Dim row As DataRow = dt.Rows(0)
            'txtdescripcionTermino.Text = CStr(row("descripcion"))
            txtCodigoTerminoPago.Text = CStr(row("codigoTerminoPago"))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnBuscarTerminoPago_Click(sender As Object, e As EventArgs) Handles btnBuscarTerminoPago.Click
        M_ListarTerminoPago.ShowDialog()
    End Sub

End Class