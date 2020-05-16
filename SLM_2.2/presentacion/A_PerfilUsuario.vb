Public Class A_PerfilUsuario

    Dim perfil As New ClsPerfilesUsuario




    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        Try

            If txtCodigo.Text <> "" And txtCodBreve.Text <> "" Then

                'Registro de permisos en cada modulo
                Dim form As New ClsFormularios

                With form

                    'facturacion
                    .Descripcion_ = "Modulo Facturacion"
                    .Estado_ = chkFacturacion.Checked
                    .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                    .registrarFormulario()

                    'contabilidad
                    .Descripcion_ = "Modulo Contabilidad"
                    .Estado_ = chkContabilidad.Checked
                    .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                    .registrarFormulario()

                    'laboratorio
                    .Descripcion_ = "Modulo Laboratorio"
                    .Estado_ = chkLaboratorio.Checked
                    .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                    .registrarFormulario()

                    'talento humano
                    .Descripcion_ = "Modulo Talento Humano"
                    .Estado_ = chkTalentoHumano.Checked
                    .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                    .registrarFormulario()

                    'sistema
                    .Descripcion_ = "Modulo Sistema"
                    .Estado_ = chkSistema.Checked
                    .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                    .registrarFormulario()

                    'almacen
                    .Descripcion_ = "Modulo Almacen"
                    .Estado_ = chkAlmacen.Checked
                    .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                    .registrarFormulario()

                End With







            ElseIf txtCodigo.Text = "" Then
                txtCodigo.BackColor = Color.Red

            ElseIf txtCodBreve.Text = "" Then
                txtCodBreve.BackColor = Color.Red

            End If


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
            'validacion campos vacios

            If txtCodBreve.Text <> "" And txtDescripcion.Text <> "" Then

                With perfil
                    .Cod_Breve = txtCodBreve.Text
                    .Descripcion_ = txtDescripcion.Text
                    If .registrarPerfil = 1 Then
                        .listarPerfiles()
                        MsgBox("Seleccione los permisos para el perfil: " + txtCodBreve.Text)

                        btnGuardar.Enabled = True
                        btnCrearPerfil.Enabled = False
                        gbxModulos.Enabled = True
                        Dim dt As New DataTable
                        dt = .listarUltimoUsuario

                        Dim row As DataRow
                        row = dt.Rows(0)

                        txtCodigo.Text = row("cod")


                    End If
                End With

            ElseIf txtCodBreve.Text = "" Then
                txtCodBreve.BackColor = Color.Red
            ElseIf txtDescripcion.Text = "" Then
                txtDescripcion.BackColor = Color.Red
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub A_PerfilUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alternarColoFilasDatagridview(dtPerfiles)
            llenarDataGrid()
            dtPerfiles.DataSource = perfil.listarPerfiles

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            'Registro de permisos en cada modulo
            Dim form As New ClsFormularios

            With form

                'facturacion
                .Descripcion_ = "Modulo Facturacion"
                .Estado_ = chkFacturacion.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()

                'contabilidad
                .Descripcion_ = "Modulo Contabilidad"
                .Estado_ = chkContabilidad.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()

                'laboratorio
                .Descripcion_ = "Modulo Laboratorio"
                .Estado_ = chkLaboratorio.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()

                'talento humano
                .Descripcion_ = "Modulo Talento Humano"
                .Estado_ = chkTalentoHumano.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()

                'sistema
                .Descripcion_ = "Modulo Sistema"
                .Estado_ = chkSistema.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()

                'almacen
                .Descripcion_ = "Modulo Almacen"
                .Estado_ = chkAlmacen.Checked
                .Cod_Perfil = Convert.ToInt32(txtCodigo.Text)
                .registrarFormulario()

            End With








        Catch ex As Exception

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

            btnCrearPerfil.Enabled = False
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            gbxRegistros.Enabled = False
            gbxModulos.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    'Llenar Datagrid con item vacios

    Sub llenarDataGrid()

        'Facturacion

        'Contabilidad
        dtContabilidad.Rows.Add("", "Depositos", False, "")





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
End Class