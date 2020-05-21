Public Class A_PerfilUsuario

    Dim perfil As New ClsPerfilesUsuario




    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        Try
            'Modificacion de perfil de usuario/ perfil/ permisos





        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCodBreve_TextChanged(sender As Object, e As EventArgs) Handles txtCodBreve.TextChanged
        If txtCodBreve.BackColor = Color.Red Then
            txtCodBreve.BackColor = Color.White
        End If
    End Sub

    Private Sub btnCrearPerfil_Click(sender As Object, e As EventArgs) Handles btnCrearPerfil.Click

        Try
            'Validacion campos vacios

            If txtCodBreve.Text <> "" And txtDescripcion.Text <> "" Then

                With perfil
                    .Cod_Breve = txtCodBreve.Text
                    .Descripcion_ = txtDescripcion.Text

                    If .registrarPerfil = 1 Then ' Se valida guardado de datos del perfil 
                        Dim dt As New DataTable
                        dt = .listarUltimoUsuario

                        Dim row As DataRow
                        row = dt.Rows(0)

                        txtCodigo.Text = row("cod")
                        .listarPerfiles()
                        MsgBox("Seleccione los permisos para el perfil: " + txtCodBreve.Text)

                        btnGuardar.Enabled = True
                        btnCrearPerfil.Enabled = False
                        gbxModulos.Enabled = True
                        llenarDataGrid()

                    End If
                End With

            ElseIf txtCodBreve.Text = "" Then
                txtCodBreve.BackColor = Color.Red
            ElseIf txtDescripcion.Text = "" Then
                txtDescripcion.BackColor = Color.Red
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub A_PerfilUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alternarColoFilasDatagridview(dtPerfiles)

            dtPerfiles.DataSource = perfil.listarPerfiles

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            'Registro de permisos en cada modulo
            Dim form As New ClsFormularios
            Dim ventanas As New ClsVentanasModulos
            Dim dtF As New DataTable
            Dim roww As DataRow
            With form


                'facturacion
                .Descripcion_ = "Modulo Facturacion"
                .Estado_ = chkFacturacion.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()
                dtF = .listarUltimoFormulario()
                roww = dtF.Rows(0)

                'Ventanas de modulo facturacion
                For i = 0 To dtFacturacion.Rows.Count - 1
                    With ventanas

                        .Descripcion_ = dtFacturacion.Rows(i).Cells(1).Value
                        .Estado_ = dtFacturacion.Rows(i).Cells(2).Value
                        .Cod_Modulo = roww("codModulos")
                        .registrarVentana()

                    End With
                Next
                pbarCarga.Value += 20

                'contabilidad
                .Descripcion_ = "Modulo Contabilidad"
                .Estado_ = chkContabilidad.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()
                dtF = .listarUltimoFormulario()
                roww = dtF.Rows(0)
                'Ventanas de modulo contabilidad
                For i = 0 To dtContabilidad.Rows.Count - 1
                    With ventanas

                        .Descripcion_ = dtContabilidad.Rows(i).Cells(1).Value
                        .Estado_ = dtContabilidad.Rows(i).Cells(2).Value
                        .Cod_Modulo = roww("codModulos")
                        .registrarVentana()


                    End With
                Next
                pbarCarga.Value += 27

                'laboratorio
                .Descripcion_ = "Modulo Laboratorio"
                .Estado_ = chkLaboratorio.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()
                dtF = .listarUltimoFormulario()
                roww = dtF.Rows(0)
                'Ventanas de modulo laboratorio
                For i = 0 To dtLaboratorio.Rows.Count - 1
                    With ventanas

                        .Descripcion_ = dtLaboratorio.Rows(i).Cells(1).Value
                        .Estado_ = dtLaboratorio.Rows(i).Cells(2).Value
                        .Cod_Modulo = roww("codModulos")
                        .registrarVentana()
                    End With
                Next
                pbarCarga.Value += 20

                'talento humano
                .Descripcion_ = "Modulo Talento Humano"
                .Estado_ = chkTalentoHumano.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()
                dtF = .listarUltimoFormulario()
                roww = dtF.Rows(0)
                'Ventanas de modulo talento humano
                For i = 0 To dtTalentoHumano.Rows.Count - 1
                    With ventanas

                        .Descripcion_ = dtTalentoHumano.Rows(i).Cells(1).Value
                        .Estado_ = dtTalentoHumano.Rows(i).Cells(2).Value
                        .Cod_Modulo = roww("codModulos")
                        .registrarVentana()


                    End With
                Next
                pbarCarga.Value += 20

                'sistema
                .Descripcion_ = "Modulo Sistema"
                .Estado_ = chkSistema.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()
                dtF = .listarUltimoFormulario()
                roww = dtF.Rows(0)
                'Ventanas de modulo sistema
                For i = 0 To dtSistema.Rows.Count - 1
                    With ventanas

                        .Descripcion_ = dtSistema.Rows(i).Cells(1).Value
                        .Estado_ = dtSistema.Rows(i).Cells(2).Value
                        .Cod_Modulo = roww("codModulos")
                        .registrarVentana()


                    End With
                Next
                pbarCarga.Value += 3

                'Almacen
                .Descripcion_ = "Modulo Almacen"
                .Estado_ = chkAlmacen.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()
                dtF = .listarUltimoFormulario()
                roww = dtF.Rows(0)
                'Ventanas de modulo almacen
                For i = 0 To dtAlmacen.Rows.Count - 1
                    With ventanas

                        .Descripcion_ = dtAlmacen.Rows(i).Cells(1).Value
                        .Estado_ = dtAlmacen.Rows(i).Cells(2).Value
                        .Cod_Modulo = roww("codModulos")
                        .registrarVentana()
                    End With
                Next
                pbarCarga.Value += 10
                MsgBox("Se guardo el perfil de usuario.")

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtPerfiles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPerfiles.CellDoubleClick
        Try

            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtPerfiles.DataSource
            row = dt.Rows(e.RowIndex)

            txtCodigo.Text = row("cod")
            txtCodBreve.Text = row("codBreve")
            txtDescripcion.Text = row("descripcion")
            chkHabilitar.Checked = row("estado")

            btnNuevoPerfil.Enabled = True
            btnCrearPerfil.Enabled = False
            btnGuardar.Enabled = False
            btnModificar.Enabled = True

            gbxRegistros.Enabled = False
            gbxModulos.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub dtContabilidad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtContabilidad.CellContentClick



        If e.ColumnIndex = 2 Then
            If dtContabilidad.Rows(e.RowIndex).Cells(2).Value = False Then
                dtContabilidad.Rows(e.RowIndex).Cells(2).Value = True
            Else
                dtContabilidad.Rows(e.RowIndex).Cells(2).Value = False
            End If
        End If
    End Sub

    'Llenar Datagrid con Items de Modulos para habilitar funciones

    Sub limpiarDataGrids()
        dtFacturacion.DataSource = ""
        dtLaboratorio.DataSource = ""
        dtContabilidad.DataSource = ""
        dtSistema.DataSource = ""
        dtTalentoHumano.DataSource = ""
        dtAlmacen.DataSource = ""
    End Sub

    Sub llenarDataGrid()

        'Procesos de Laboratorio
        dtLaboratorio.Rows.Add("", "Exámenes", False, "")
        dtLaboratorio.Rows.Add("", "Orden de Trabajo", False, "")
        dtLaboratorio.Rows.Add("", "Hoja de Trabajo", False, "")
        dtLaboratorio.Rows.Add("", "Entrega de Resultados", False, "")
        dtLaboratorio.Rows.Add("", "Sede", False, "")
        dtLaboratorio.Rows.Add("", "Sucursal", False, "")
        dtLaboratorio.Rows.Add("", "Medicos", False, "")
        dtLaboratorio.Rows.Add("", "Pacientes", False, "")
        dtLaboratorio.Rows.Add("", "Convenios", False, "")


        'Procesos de Facturacion
        dtFacturacion.Rows.Add("", "Facturacion", False, "")
        dtFacturacion.Rows.Add("", "Cotización", False, "")
        dtFacturacion.Rows.Add("", "Recibos", False, "")
        dtFacturacion.Rows.Add("", "Contactos", False, "")
        dtFacturacion.Rows.Add("", "Items", False, "")
        dtFacturacion.Rows.Add("", "Grupo Items", False, "")
        dtFacturacion.Rows.Add("", "Term. Pagos", False, "")
        dtFacturacion.Rows.Add("", "Pacientes", False, "")


        'Procesos de Contabilidad
        dtContabilidad.Rows.Add("", "Precio", False, "")
        dtContabilidad.Rows.Add("", "Lista de Precio", False, "")
        dtContabilidad.Rows.Add("", "Descuentos", False, "")
        dtContabilidad.Rows.Add("", "Promociones", False, "")
        dtContabilidad.Rows.Add("", "Consolidación", False, "")
        dtContabilidad.Rows.Add("", "Depreciacion", False, "")
        dtContabilidad.Rows.Add("", "Planilla", False, "")
        dtContabilidad.Rows.Add("", "Cuentas", False, "")
        dtContabilidad.Rows.Add("", "Asientos", False, "")
        dtContabilidad.Rows.Add("", "Cat. Proveedores", False, "")
        dtContabilidad.Rows.Add("", "Proveedores", False, "")
        dtContabilidad.Rows.Add("", "Bancos", False, "")
        dtContabilidad.Rows.Add("", "Periodo Contable", False, "")
        dtContabilidad.Rows.Add("", "Formas de Pago", False, "")
        dtContabilidad.Rows.Add("", "CAI", False, "")
        dtContabilidad.Rows.Add("", "Chequera", False, "")
        dtContabilidad.Rows.Add("", "Cheques", False, "")
        dtContabilidad.Rows.Add("", "Depositos", False, "")
        dtContabilidad.Rows.Add("", "Factura Compras", False, "")
        dtContabilidad.Rows.Add("", "Pagos", False, "")

        'Procesos de Sistema
        dtSistema.Rows.Add("", "Usuarios", False, "")
        dtSistema.Rows.Add("", "Permisos de usuario", False, "")
        dtSistema.Rows.Add("", "Servidor de Correo", False, "")

        'Procesos de Talento Humano
        dtTalentoHumano.Rows.Add("", "Puestos de Trabajo", False, "")
        dtTalentoHumano.Rows.Add("", "Horarios", False, "")
        dtTalentoHumano.Rows.Add("", "Contratos", False, "")
        dtTalentoHumano.Rows.Add("", "Sucursales", False, "")
        dtTalentoHumano.Rows.Add("", "Permisos", False, "")
        dtTalentoHumano.Rows.Add("", "Vacaciones", False, "")
        dtTalentoHumano.Rows.Add("", "Empleados", False, "")

        'Procesos de Almacen
        dtAlmacen.Rows.Add("", "Almacenes", False, "")
        dtAlmacen.Rows.Add("", "Salidas", False, "")
        dtAlmacen.Rows.Add("", "Orden de Compra", False, "")
        dtAlmacen.Rows.Add("", "Orden Interna", False, "")
        dtAlmacen.Rows.Add("", "Entradas", False, "")
        dtAlmacen.Rows.Add("", "Productos", False, "")
        dtAlmacen.Rows.Add("", "Categorias", False, "")
        dtAlmacen.Rows.Add("", "Unidad de Medida", False, "")

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Show()

    End Sub
End Class