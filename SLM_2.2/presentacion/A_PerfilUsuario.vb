Public Class A_PerfilUsuario

    Dim perfil As New ClsPerfilesUsuario
    Dim form As New ClsFormularios
    Dim ventanas As New ClsVentanasModulos

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            'Modificacion de perfil de usuario/ modulos/ permisos
            btnModificar.Enabled = False
            'Información de perfil de usuario
            With perfil
                .Cod = Integer.Parse(txtCodigo.Text)
                .Cod_Breve = txtCodBreve.Text
                .Descripcion_ = txtDescripcion.Text
                .Estado_ = chkHabilitar.Checked
                .modificarPerfil()
            End With
            pbarCarga.Value += 20
            'Informacion de modulos
            With form

                For m As Integer = 0 To 5 'inicio for modulos:::::::::

                    If m = 0 Then
                        .Cod_Modulo = Integer.Parse(lblCod_MFact.Text)
                        .Estado_ = chkFacturacion.Checked
                        .modificarEstado()

                    ElseIf m = 1 Then
                        .Cod_Modulo = Integer.Parse(lblCod_MCont.Text)
                        .Estado_ = chkContabilidad.Checked
                        .modificarEstado()

                    ElseIf m = 2 Then
                        .Cod_Modulo = Integer.Parse(lblCod_MLab.Text)
                        .Estado_ = chkLaboratorio.Checked
                        .modificarEstado()
                        pbarCarga.Value += 20
                    ElseIf m = 3 Then
                        .Cod_Modulo = Integer.Parse(lblCod_MTalento.Text)
                        .Estado_ = chkTalentoHumano.Checked
                        .modificarEstado()

                    ElseIf m = 4 Then
                        .Cod_Modulo = Integer.Parse(lblCod_MSist.Text)
                        .Estado_ = chkSistema.Checked
                        .modificarEstado()

                    ElseIf m = 5 Then
                        .Cod_Modulo = Integer.Parse(lblCod_MAlma.Text)
                        .Estado_ = chkAlmacen.Checked
                        .modificarEstado()

                    End If

                Next 'fin for modulos::::::::::::::::::::::::::::::::::
                pbarCarga.Value += 10
            End With

            'Informacion de ventanas por modulo
            With ventanas

                For index = 0 To dtFacturacion.Rows.Count - 1

                    .Cod_Ventana = Convert.ToInt32(dtFacturacion.Rows(index).Cells(0).Value)
                    .Estado_ = Convert.ToBoolean(dtFacturacion.Rows(index).Cells(2).Value)
                    .modificarEstadoV()

                Next

                'Datagrid Contabilidad

                For index As Integer = 0 To dtContabilidad.Rows.Count - 1

                    .Cod_Ventana = Convert.ToInt32(dtContabilidad.Rows(index).Cells(0).Value)
                    .Estado_ = Convert.ToBoolean(dtContabilidad.Rows(index).Cells(2).Value)
                    .modificarEstadoV()

                Next
                pbarCarga.Value += 20
                'Datagrid Laboratorio

                For index As Integer = 0 To dtLaboratorio.Rows.Count - 1

                    .Cod_Ventana = Convert.ToInt32(dtLaboratorio.Rows(index).Cells(0).Value)
                    .Estado_ = Convert.ToBoolean(dtLaboratorio.Rows(index).Cells(2).Value)
                    .modificarEstadoV()

                Next

                'Datagrid Talento Humano

                For index As Integer = 0 To dtTalentoHumano.Rows.Count - 1

                    .Cod_Ventana = Convert.ToInt32(dtTalentoHumano.Rows(index).Cells(0).Value)
                    .Estado_ = Convert.ToBoolean(dtTalentoHumano.Rows(index).Cells(2).Value)
                    .modificarEstadoV()

                Next
                pbarCarga.Value += 20
                'Datagrid Sistema

                For index As Integer = 0 To dtSistema.Rows.Count - 1

                    .Cod_Ventana = Convert.ToInt32(dtSistema.Rows(index).Cells(0).Value)
                    .Estado_ = Convert.ToBoolean(dtSistema.Rows(index).Cells(2).Value)
                    .modificarEstadoV()

                Next

                'Datagrid Almacen

                For index As Integer = 0 To dtAlmacen.Rows.Count - 1

                    .Cod_Ventana = Convert.ToInt32(dtAlmacen.Rows(index).Cells(0).Value)
                    .Estado_ = Convert.ToBoolean(dtAlmacen.Rows(index).Cells(2).Value)
                    .modificarEstadoV()

                Next

            End With

            pbarCarga.Value += 10
            MsgBox("Se modifico el regsitro.")
            limpiar()
            CargarData()
            pbarCarga.Value = 0

        Catch ex As Exception
            MsgBox(ex.Message)
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
                    .Estado_ = chkHabilitar.Checked

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
            btnGuardar.Enabled = False
            'Registro de permisos en cada modulo

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
                MsgBox("Se registro un nuevo perfil.")
                btnGuardar.Enabled = False

            End With

            pbarCarga.Value = 0
            limpiar()
            CargarData()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtPerfiles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPerfiles.CellDoubleClick
        Try
            limpiarDataGrids()
            gbxRegistros.Enabled = False
            'Capturar data de perfil
            Dim dt, dtVentanas As New DataTable
            Dim row As DataRow

            dt = dtPerfiles.DataSource
            row = dt.Rows(e.RowIndex)

            txtCodigo.Text = row("cod")
            txtCodBreve.Text = row("codBreve")
            txtDescripcion.Text = row("descripcion")
            chkHabilitar.Checked = row("estado")
            gbxModulos.Enabled = True

            'Capturar data de modulos habilitados por perfil
            With form
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                dt = .formulariosDePerfil

                'capturar estado de check de cada modulo

                chkFacturacion.Checked = dt.Rows(0).Item(2).ToString
                lblCod_MFact.Text = dt.Rows(0).Item(0).ToString

                chkContabilidad.Checked = dt.Rows(1).Item(2).ToString
                lblCod_MCont.Text = dt.Rows(1).Item(0).ToString

                chkLaboratorio.Checked = dt.Rows(2).Item(2).ToString
                lblCod_MLab.Text = dt.Rows(2).Item(0).ToString

                chkTalentoHumano.Checked = dt.Rows(3).Item(2).ToString
                lblCod_MTalento.Text = dt.Rows(3).Item(0).ToString

                chkSistema.Checked = dt.Rows(4).Item(2).ToString
                lblCod_MSist.Text = dt.Rows(4).Item(0).ToString

                chkAlmacen.Checked = dt.Rows(5).Item(2).ToString
                lblCod_MAlma.Text = dt.Rows(5).Item(0).ToString

                'Listar permisos de cada modulo en datagrid

                'Facturacion
                ventanas.Cod_Modulo = Convert.ToInt32(dt.Rows(0).Item(0).ToString)
                dtVentanas = ventanas.listarPermisos

                For index As Integer = 0 To dtVentanas.Rows.Count - 1
                    row = dtVentanas.Rows(index)
                    dtFacturacion.Rows.Add(New String() {(row("cod")), CStr(row("descripcion")), row("estado"), row("codModulo")})
                Next
                pbarCarga.Value += 20
                'Contabilidad
                ventanas.Cod_Modulo = Convert.ToInt32(dt.Rows(1).Item(0).ToString)
                dtVentanas = ventanas.listarPermisos
                For index As Integer = 0 To dtVentanas.Rows.Count - 1
                    row = dtVentanas.Rows(index)
                    dtContabilidad.Rows.Add(New String() {(row("cod")), CStr(row("descripcion")), row("estado"), row("codModulo")})
                Next
                pbarCarga.Value += 30
                'Laboratorio
                ventanas.Cod_Modulo = Convert.ToInt32(dt.Rows(2).Item(0).ToString)
                dtVentanas = ventanas.listarPermisos
                For index As Integer = 0 To dtVentanas.Rows.Count - 1
                    row = dtVentanas.Rows(index)
                    dtLaboratorio.Rows.Add(New String() {(row("cod")), CStr(row("descripcion")), row("estado"), row("codModulo")})
                Next
                pbarCarga.Value += 20
                'Talento Humano
                ventanas.Cod_Modulo = Convert.ToInt32(dt.Rows(3).Item(0).ToString)
                dtVentanas = ventanas.listarPermisos
                For index As Integer = 0 To dtVentanas.Rows.Count - 1
                    row = dtVentanas.Rows(index)
                    dtTalentoHumano.Rows.Add(New String() {(row("cod")), CStr(row("descripcion")), row("estado"), row("codModulo")})
                Next
                pbarCarga.Value += 20
                'Sistema
                ventanas.Cod_Modulo = Convert.ToInt32(dt.Rows(4).Item(0).ToString)
                dtVentanas = ventanas.listarPermisos
                For index As Integer = 0 To dtVentanas.Rows.Count - 1
                    row = dtVentanas.Rows(index)
                    dtSistema.Rows.Add(New String() {(row("cod")), CStr(row("descripcion")), row("estado"), row("codModulo")})
                Next
                pbarCarga.Value += 5
                'Almacen
                ventanas.Cod_Modulo = Convert.ToInt32(dt.Rows(5).Item(0).ToString)
                dtVentanas = ventanas.listarPermisos
                For index As Integer = 0 To dtVentanas.Rows.Count - 1
                    row = dtVentanas.Rows(index)
                    dtAlmacen.Rows.Add(New String() {(row("cod")), CStr(row("descripcion")), row("estado"), row("codModulo")})
                Next
                pbarCarga.Value += 5
            End With

            btnNuevoPerfil.Enabled = True
            btnCrearPerfil.Enabled = False
            btnGuardar.Enabled = False
            btnModificar.Enabled = True

            gbxModulos.Enabled = True
            gbxRegistros.Enabled = True
            pbarCarga.Value = 0
        Catch ex As Exception
            MsgBox(ex.Message)
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

    'Limpiar filas datagrids
    Sub limpiarDataGrids()
        dtFacturacion.Rows.Clear()
        dtContabilidad.Rows.Clear()
        dtLaboratorio.Rows.Clear()
        dtTalentoHumano.Rows.Clear()
        dtSistema.Rows.Clear()
        dtAlmacen.Rows.Clear()

    End Sub

    'Llenar Datagrid con Items de Modulos para habilitar funciones

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
        dtLaboratorio.Rows.Add("", "Subareas", False, "")
        dtLaboratorio.Rows.Add("", "Valores de Referencia", False, "")
        dtLaboratorio.Rows.Add("", "Informes", False, "")
        dtLaboratorio.Rows.Add("", "Grupo Exámenes", False, "")

        'Procesos de Facturacion
        dtFacturacion.Rows.Add("", "Facturacion", False, "")
        dtFacturacion.Rows.Add("", "Cotización", False, "")
        dtFacturacion.Rows.Add("", "Recibos", False, "")
        dtFacturacion.Rows.Add("", "Contactos", False, "")
        dtFacturacion.Rows.Add("", "Items", False, "")
        dtFacturacion.Rows.Add("", "Grupo Items", False, "")
        dtFacturacion.Rows.Add("", "Term. Pagos", False, "")
        dtFacturacion.Rows.Add("", "Pacientes", False, "")
        dtFacturacion.Rows.Add("", "Apertura", False, "")
        dtFacturacion.Rows.Add("", "Cierre de Caja", False, "")
        dtFacturacion.Rows.Add("", "Arqueos", False, "")
        dtFacturacion.Rows.Add("", "Diario Facturación", False, "")
        dtFacturacion.Rows.Add("", "Habilitar OK", False, "")

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
        dtTalentoHumano.Rows.Add("", "Profesión", False, "")
        dtTalentoHumano.Rows.Add("", "Tipo de Deducción", False, "")
        dtTalentoHumano.Rows.Add("", "Area", False, "")
        dtTalentoHumano.Rows.Add("", "Departamento", False, "")
        dtTalentoHumano.Rows.Add("", "Candidatos", False, "")
        dtTalentoHumano.Rows.Add("", "Capacitaciones", False, "")
        dtTalentoHumano.Rows.Add("", "Reportería", False, "")
        dtTalentoHumano.Rows.Add("", "Constancias y Plantillas", False, "")
        dtTalentoHumano.Rows.Add("", "Tipo Permiso", False, "")


        'Procesos de Almacen
        dtAlmacen.Rows.Add("", "Almacenes", False, "")
        dtAlmacen.Rows.Add("", "Salidas", False, "")
        dtAlmacen.Rows.Add("", "Orden de Compra", False, "")
        dtAlmacen.Rows.Add("", "Factura de Compra", False, "")
        dtAlmacen.Rows.Add("", "Orden Interna", False, "")
        dtAlmacen.Rows.Add("", "Entradas", False, "")
        dtAlmacen.Rows.Add("", "Productos", False, "")
        dtAlmacen.Rows.Add("", "Proveedores", False, "")
        dtAlmacen.Rows.Add("", "Autorizaciones", False, "")
        dtAlmacen.Rows.Add("", "BI", False, "")
        dtAlmacen.Rows.Add("", "Inventario", False, "")
        dtAlmacen.Rows.Add("", "Categorias", False, "")
        dtAlmacen.Rows.Add("", "Unidad de Medida", False, "")
        dtAlmacen.Rows.Add("", "Solicitudes", False, "")
        dtAlmacen.Rows.Add("", "Evaluación", False, "")

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnNuevoPerfil_Click(sender As Object, e As EventArgs) Handles btnNuevoPerfil.Click

        Try
            limpiar()
        Catch ex As Exception

        End Try

    End Sub

    Sub limpiar()
        'Componentes perfil
        txtCodigo.Clear()
        txtCodBreve.Clear()
        txtDescripcion.Clear()
        chkHabilitar.Checked = False

        'Componentes modulos
        chkFacturacion.Checked = False
        chkContabilidad.Checked = False
        chkLaboratorio.Checked = False
        chkTalentoHumano.Checked = False
        chkSistema.Checked = False
        chkAlmacen.Checked = False

        limpiarDataGrids()
        gbxModulos.Enabled = False
        btnCrearPerfil.Enabled = True
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnNuevoPerfil.Enabled = False
    End Sub

    Private Sub dtFacturacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFacturacion.CellContentClick
        Try
            If e.ColumnIndex = 2 Then
                If dtFacturacion.Rows(e.RowIndex).Cells(2).Value = False Then
                    dtFacturacion.Rows(e.RowIndex).Cells(2).Value = True
                Else
                    dtFacturacion.Rows(e.RowIndex).Cells(2).Value = False
                End If
            End If
        Catch ex As Exception

        End Try





    End Sub

    Private Sub dtLaboratorio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtLaboratorio.CellContentClick

        Try
            If e.ColumnIndex = 2 Then
                If dtLaboratorio.Rows(e.RowIndex).Cells(2).Value = False Then
                    dtLaboratorio.Rows(e.RowIndex).Cells(2).Value = True
                Else
                    dtLaboratorio.Rows(e.RowIndex).Cells(2).Value = False
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtTalentoHumano_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtTalentoHumano.CellContentClick

        Try
            If e.ColumnIndex = 2 Then
                If dtTalentoHumano.Rows(e.RowIndex).Cells(2).Value = False Then
                    dtTalentoHumano.Rows(e.RowIndex).Cells(2).Value = True
                Else
                    dtTalentoHumano.Rows(e.RowIndex).Cells(2).Value = False
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtSistema_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtSistema.CellContentClick
        Try
            If e.ColumnIndex = 2 Then
                If dtSistema.Rows(e.RowIndex).Cells(2).Value = False Then
                    dtSistema.Rows(e.RowIndex).Cells(2).Value = True
                Else
                    dtSistema.Rows(e.RowIndex).Cells(2).Value = False
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtAlmacen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtAlmacen.CellContentClick

        Try
            If e.ColumnIndex = 2 Then
                If dtAlmacen.Rows(e.RowIndex).Cells(2).Value = False Then
                    dtAlmacen.Rows(e.RowIndex).Cells(2).Value = True
                Else
                    dtAlmacen.Rows(e.RowIndex).Cells(2).Value = False
                End If
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub A_PerfilUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar ESC para cerrar
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Sub CargarData()
        dtPerfiles.DataSource = perfil.listarPerfiles
    End Sub
End Class