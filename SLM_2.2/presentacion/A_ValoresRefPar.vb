Public Class A_ValoresRefPar

    Dim tab As String = 0
    Dim codigoValRef As New ArrayList
    Dim codigoValRefTxt As New ArrayList

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        Try

            If TabControl1.SelectedIndex = 1 Then
                tab = 1
                ' MessageBox.Show("Me seleccionaron " + tab)
                limpiarcampostab0()
                btnCrear.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Enabled = True
            ElseIf TabControl1.SelectedIndex = 0 Then
                tab = 0
                ' MessageBox.Show("Me seleccionaron " + tab)
                limpiarcampostab1()
                btnCrear.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("error en seleccion de tab")
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim dt As New DataTable
            Dim row As DataRow

            If tab = 0 Then 'tab valor referencia

                If txtParametro.Text <> "" And txtDescripcion.Text <> "" And cbxGenero.Text <> "" Then

                    Dim valorref As New ClsValoresReferencia
                    Dim detallevalorref As New ClsDetalleValorReferencia
                    'Dim dt As New DataTable
                    'Dim row As DataRow

                    'ingreso de informacion de valores ref.
                    With valorref

                        .Cod_Parametro = Convert.ToInt32(lblCodParametro.Text)
                        .Descripcion_ = txtDescripcion.Text
                        .Genero_ = cbxGenero.Text
                        .registrarNuevoValorReferencia()
                        dt = .capturarValorRef
                        row = dt.Rows(0)
                        lblCodValorRef.Text = row("cod_ValorReferencia")
                    End With

                    'ingreso de detalle de valor ref insertado
                    With detallevalorref

                        For i = 0 To dtValoresRef.Rows.Count - 2

                            .Cod_ValorRef = Convert.ToInt32(lblCodValorRef.Text)
                            .Edad_de = dtValoresRef.Rows(i).Cells(1).Value
                            .Edad_hasta = dtValoresRef.Rows(i).Cells(2).Value
                            '.Edad_en = dtValoresRef.Rows(i).Cells(3).Value
                            .valor_normal = dtValoresRef.Rows(i).Cells(4).Value
                            .hasta_ = dtValoresRef.Rows(i).Cells(5).Value
                            .registrarNuevoDetalleValorReferencia()
                        Next

                    End With

                    MsgBox("se guardo valor de referencia.")
                    limpiarcampostab0()
                    Cargardatavalorref()

                ElseIf txtParametro.Text = "" Then
                    txtParametro.BackColor = Color.Red
                    txtUnidad.BackColor = Color.Red
                ElseIf txtDescripcion.Text = "" Then
                    txtDescripcion.BackColor = Color.Red
                ElseIf cbxGenero.Text = "" Then
                    cbxGenero.BackColor = Color.Red
                End If

            ElseIf tab = 1 Then 'tab valor referencia texto

                If txtParametro2.Text <> "" And txtDescripcion2.Text <> "" And txtEdadde.Text <> "" And txtEdaden.Text <> "" And txtEdadhasta.Text <> "" And cbxGenero2.Text <> "" Then

                    Dim valortxt As New ClsValoresReferenciaTXT
                    Dim dvalortxt As New ClsDetalleValorRefTxt
                    'Ingreso de informacion de valor de referencia texto
                    With valortxt

                        .Cod_Parametro = Convert.ToInt32(lblCodParametro.Text)
                        .Descripcion_ = txtDescripcion2.Text
                        .Edad_de = txtEdadde.Text
                        .Edad_hasta = txtEdadhasta.Text
                        .Edad_en = txtEdaden.Text
                        .Genero_ = cbxGenero2.Text
                        .registrarNuevoValorReferenciaTXT()
                        dt = .capturarValorRefTXT()
                        row = dt.Rows(0)
                        lblCodValorRef.Text = row("cod_ValorReferenciaTxt")

                    End With

                    With dvalortxt

                        For i = 0 To dtDetalleTexto.Rows.Count - 2
                            .Cod_TXT = Convert.ToInt32(lblCodValorRef.Text)
                            .Texto_ = dtDetalleTexto.Rows(i).Cells(1).Value
                            .registrarDetalleValorReferenciaTXT()
                        Next

                    End With

                    MsgBox("se guardo valor ref txt.")
                    limpiarcampostab1()
                    Cargardatavalorreftxt()
                ElseIf txtParametro2.Text = "" Then
                    txtParametro2.BackColor = color.Red
                    txtunidad2.BackColor = Color.Red
                ElseIf txtDescripcion2.Text = "" Then
                    txtDescripcion2.BackColor = color.Red
                ElseIf txtEdadde.Text = "" Then
                    txtEdadde.BackColor = color.red
                ElseIf txtEdadhasta.Text = "" Then
                    txtEdadhasta.BackColor = color.Red
                ElseIf txtEdaden.text = "" Then
                    txtEdaden.BackColor = Color.Red
                ElseIf cbxGenero2.Text = "" Then
                    cbxGenero2.BackColor = color.Red
                End If ' fin if campos vacios

            End If ' fin if tab seleccionado

        Catch ex As Exception
            MsgBox("guardar:" + ex.Message)
        End Try

    End Sub

    Private Sub A_ValoresRefPar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dtDataValoresRef)
            alternarColoFilasDatagridview(dtValoresRef)

            alternarColoFilasDatagridview(dtDetalleTexto)
            alternarColoFilasDatagridview(dtDataValorRefTexto)

            Cargardatavalorref()
            Cargardatavalorreftxt()

            'Limpiar campos al cargar
            limpiarcampostab0()
            limpiarcampostab1()

            If dtDataValoresRef.Columns.Contains("cod_ValorReferencia") = True And dtDataValorRefTexto.Columns.Contains("cod_ValorReferenciatxt") = True Then

                'columnas valor de referencia
                dtDataValoresRef.Columns("cod_ValorReferencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("cod_ValorReferencia").HeaderText = "Código"

                dtDataValoresRef.Columns("codParametro").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("codParametro").HeaderText = "Parámetro"

                dtDataValoresRef.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("descripcion").HeaderText = "Descripcion"

                dtDataValoresRef.Columns("genero").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("genero").HeaderText = "Genero"

                'columnas valor de referencia texto
                dtDataValorRefTexto.Columns("cod_ValorReferenciaTxt").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("cod_ValorReferenciaTxt").HeaderText = "Código"

                dtDataValorRefTexto.Columns("cod_parametro").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("cod_parametro").HeaderText = "Parámetro"

                dtDataValorRefTexto.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("descripcion").HeaderText = "Descripción"

                dtDataValorRefTexto.Columns("edadde").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("edadde").HeaderText = "Edad de"

                dtDataValorRefTexto.Columns("edadhasta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("edadhasta").HeaderText = "Edad Hasta"

                dtDataValorRefTexto.Columns("edaden").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("edaden").HeaderText = "Edad en"

                dtDataValorRefTexto.Columns("genero").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("genero").HeaderText = "Genero"

            End If

            Me.dtDataValorRefTexto.Columns("edaden").Visible = False

            If dtValoresRef.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtValoresRef.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If


            If dtDetalleTexto.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dtDetalleTexto.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If

            btnCrear.Enabled = False
            btnModificar.Enabled = False

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscarParametro_Click(sender As Object, e As EventArgs) Handles btnBuscarParametro.Click
        A_ListadoParametros.lblFormulario.Text = "valorRef"
        A_ListadoParametros.Show()
        'Modificar txt del llamado al formulario

        If txtParametro.BackColor = Color.Red Then
            txtParametro.BackColor = Color.White
            txtUnidad.BackColor = Color.White
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            If tab = 0 Then ' moidificacion tab2

                If txtParametro.Text <> "" And txtDescripcion.Text <> "" And cbxGenero.Text <> "" Then

                    Dim valorref As New ClsValoresReferencia
                    Dim detallevalorref As New ClsDetalleValorReferencia

                    'modificacion de informacion de valores ref.
                    With valorref

                        .Cod_ = Convert.ToInt32(lblCodValorRef.Text)
                        .Cod_Parametro = Convert.ToInt32(lblCodParametro.Text)
                        .Descripcion_ = txtDescripcion.Text
                        .Genero_ = cbxGenero.Text
                        .modificarValorReferencia()

                    End With
                    'modificacion de detalle de valor ref insertado
                    With detallevalorref
                        For i = 0 To dtValoresRef.Rows.Count - 2
                            If dtValoresRef.Rows(i).Cells(0).Value = "" Then

                                .Cod_ValorRef = Convert.ToInt32(lblCodValorRef.Text)
                                .Edad_de = dtValoresRef.Rows(i).Cells(1).Value
                                .Edad_hasta = dtValoresRef.Rows(i).Cells(2).Value
                                '.Edad_en = dtValoresRef.Rows(i).Cells(3).Value
                                .valor_normal = dtValoresRef.Rows(i).Cells(4).Value
                                .hasta_ = dtValoresRef.Rows(i).Cells(5).Value
                                .registrarNuevoDetalleValorReferencia()

                            Else
                                .Cod_ = Convert.ToInt32(dtValoresRef.Rows(i).Cells(0).Value)
                                .Edad_de = dtValoresRef.Rows(i).Cells(1).Value
                                .Edad_hasta = dtValoresRef.Rows(i).Cells(2).Value
                                '.Edad_en = dtValoresRef.Rows(i).Cells(3).Value
                                .valor_normal = dtValoresRef.Rows(i).Cells(4).Value
                                .hasta_ = dtValoresRef.Rows(i).Cells(5).Value
                                .modificarDetalleValorReferencia()
                            End If

                        Next


                        For index As Integer = 0 To codigoValRef.Count - 1
                            .Cod_ = Convert.ToInt64(codigoValRef(index))
                            If .eliminarDetalleValorReferencia() <> 1 Then
                                MsgBox("Error al querer modificar el detalle valor de referencia.", MsgBoxStyle.Critical)
                            End If
                        Next
                        codigoValRef.Clear()
                    End With

                    MsgBox("se modifico valor de referencia.")
                    limpiarcampostab0()
                    Cargardatavalorref()

                ElseIf txtParametro.Text = "" Then
                    txtParametro.BackColor = Color.Red
                    txtUnidad.BackColor = Color.Red
                ElseIf txtDescripcion.Text = "" Then
                    txtDescripcion.BackColor = Color.Red
                ElseIf cbxGenero.Text = "" Then
                    cbxGenero.BackColor = Color.Red
                End If

            ElseIf tab = 1 Then 'modificacion tab1


                If txtParametro2.Text <> "" And txtDescripcion2.Text <> "" And txtEdadde.Text <> "" And txtEdaden.Text <> "" And txtEdadhasta.Text <> "" And cbxGenero2.Text <> "" Then

                    Dim valortxt As New ClsValoresReferenciaTXT
                    Dim dvalortxt As New ClsDetalleValorRefTxt
                    'modificación de informacion de valor de referencia texto
                    With valortxt

                        .Cod_TXT = Convert.ToInt32(txtCod.Text)
                        .Cod_Parametro = Convert.ToInt32(lblCodParametro.Text)
                        .Descripcion_ = txtDescripcion2.Text
                        .Edad_de = txtEdadde.Text
                        .Edad_hasta = txtEdadhasta.Text
                        .Edad_en = txtEdaden.Text
                        .Genero_ = cbxGenero2.Text
                        .modificarValorReferenciaTXT()

                    End With


                    With dvalortxt
                        For v = 0 To dtDetalleTexto.Rows.Count - 2

                            If dtDetalleTexto.Rows(v).Cells(0).Value = "" Then
                                .Cod_TXT = Convert.ToInt32(txtCod.Text)
                                .Texto_ = dtDetalleTexto.Rows(v).Cells(1).Value
                                .registrarDetalleValorReferenciaTXT()
                            Else
                                .Cod_Detalle = Convert.ToInt32(dtDetalleTexto.Rows(v).Cells(0).Value)
                                .Texto_ = dtDetalleTexto.Rows(v).Cells(1).Value
                                .modificarDetalleValorReferenciaTXT()
                            End If

                        Next


                        For index As Integer = 0 To codigoValRefTxt.Count - 1
                            .Cod_Detalle = Convert.ToInt64(codigoValRefTxt(index))
                            If .eliminarDetalleValorReferenciaTxt() <> 1 Then
                                MsgBox("Error al querer modificar el detalle valor de referencia de texto.", MsgBoxStyle.Critical)
                            End If
                        Next
                        codigoValRefTxt.Clear()
                    End With


                    MsgBox("se modifico valor ref txt.")
                    limpiarcampostab1()
                    Cargardatavalorreftxt()
                ElseIf txtParametro2.Text = "" Then
                    txtParametro2.BackColor = Color.Red
                    txtunidad2.BackColor = Color.Red
                ElseIf txtDescripcion2.Text = "" Then
                    txtDescripcion2.BackColor = Color.Red
                ElseIf txtEdadde.Text = "" Then
                    txtEdadde.BackColor = Color.Red
                ElseIf txtEdadhasta.Text = "" Then
                    txtEdadhasta.BackColor = Color.Red
                ElseIf txtEdaden.Text = "" Then
                    txtEdaden.BackColor = Color.Red
                ElseIf cbxGenero2.Text = "" Then
                    cbxGenero2.BackColor = Color.Red
                End If ' fin if campos vacios

            End If

        Catch ex As Exception
            MsgBox("modificar:" + ex.Message)
        End Try


    End Sub

    Private Sub dtDataValoresRef_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDataValoresRef.CellDoubleClick

        Try
            limpiarcampostab0()
            Dim dtseleccion, dtDetalle As New DataTable
            Dim fila, dfila As DataRow
            Dim vDetalle As New ClsDetalleValorReferencia
            Dim parametro As New ClsItemExamenDetalle
            Dim unidad As New ClsUnidad

            dtseleccion = dtDataValoresRef.DataSource
            fila = dtseleccion.Rows(e.RowIndex)

            'cargar informacion de valores
            lblCodValorRef.Text = fila("cod_ValorReferencia")
            lblCodParametro.Text = fila("codParametro")
            txtDescripcion.Text = fila("descripcion")
            cbxGenero.SelectedText = fila("genero")

            'cargar detalle en datagrid
            With vDetalle

                .Cod_ValorRef = Convert.ToInt32(lblCodValorRef.Text)
                dtDetalle = .listarDetallesValores

                For index As Integer = 0 To dtDetalle.Rows.Count - 1
                    dfila = dtDetalle.Rows(index)
                    'dtValoresRef.Rows.Add(New String() {CStr((dfila("cod_DetalleValorRef"))), (dfila("edaden")), dfila("edadhasta"), dfila("edaden"), dfila("valornormal"), dfila("hasta")})
                    'dtValoresRef.Rows.Add(New String() {CStr((dfila("cod_DetalleValorRef"))), (dfila("edadde")), dfila("edadhasta"), dfila("edaden"), dfila("valornormal"), dfila("hasta")})
                    dtValoresRef.Rows.Add(New String() {CStr((dfila("cod_DetalleValorRef"))), (dfila("edadde")), dfila("edadhasta"), 0, dfila("valornormal"), dfila("hasta")})
                Next

            End With

            'cargar información de parámetro
            parametro.codigo_ = Convert.ToInt64(lblCodParametro.Text)
            dtseleccion = parametro.BuscarDetalleExamen
            fila = dtseleccion.Rows(0)

            txtParametro.Text = fila("nombre")
            lblCodUnidad.Text = fila("codigoUnidad")
            txtUnidad.Text = fila("unidad_codigo_breve")

            btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception
            MsgBox("Hubo un error al cargar la información. Uno de los campos no existe.")
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Sub Cargardatavalorref()
        Dim valorrefe As New ClsValoresReferencia
        dtDataValoresRef.DataSource = valorrefe.listarValores
        dtDataValoresRef.Columns("codParametro").Visible = False
    End Sub

    Sub Cargardatavalorreftxt()
        Dim valorrefetxt As New ClsValoresReferenciaTXT
        dtDataValorRefTexto.DataSource = valorrefetxt.listarValoresTXT
        dtDataValorRefTexto.Columns("cod_Parametro").Visible = False
    End Sub

    Sub limpiarcampostab0()

        Try

            codigoValRef.Clear()
            codigoValRefTxt.Clear()
            txtParametro.Clear()
            txtUnidad.Clear()
            txtDescripcion.Clear()
            cbxGenero.Text = ""
            dtValoresRef.Rows.Clear()

        Catch ex As Exception

        End Try

    End Sub

    Sub limpiarcampostab1()

        txtCod.Clear()
        txtParametro2.Clear()
        txtunidad2.Clear()
        txtDescripcion2.Clear()
        txtEdadde.Clear()
        txtEdaden.Clear()
        txtEdadhasta.Clear()
        cbxGenero2.Text = ""
        dtDetalleTexto.Rows.Clear()

    End Sub


    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try

            Dim valor As New ClsValoresReferencia

            If txtBusqueda.Text = "" Then

                dtDataValoresRef.DataSource = valor.listarValores
            Else
                With valor
                    .Descripcion_ = txtBusqueda.Text
                    dtDataValoresRef.DataSource = .buscarValorReferencia

                End With

            End If

            If dtDataValoresRef.Columns.Contains("cod_ValorReferencia") = True Then

                dtDataValoresRef.Columns("cod_ValorReferencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("cod_ValorReferencia").HeaderText = "Código"

                dtDataValoresRef.Columns("codParametro").Visible = False

                dtDataValoresRef.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("descripcion").HeaderText = "Descripcion"

                dtDataValoresRef.Columns("genero").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValoresRef.Columns("genero").HeaderText = "Genero"

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        If txtDescripcion.BackColor = Color.Red Then
            txtDescripcion.BackColor = Color.White
        End If
    End Sub

    Private Sub cbxGenero_Click(sender As Object, e As EventArgs) Handles cbxGenero.Click
        If cbxGenero.BackColor = Color.Red Then
            cbxGenero.BackColor = Color.White
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        limpiarcampostab0()
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnBuscarParametro2_Click(sender As Object, e As EventArgs) Handles btnBuscarParametro2.Click
        A_ListadoParametros.lblFormulario.Text = "valortxt"
        A_ListadoParametros.Show()

        If txtParametro2.BackColor = Color.Red Then
            txtParametro2.BackColor = Color.White
            txtunidad2.BackColor = Color.White
        End If

    End Sub

    Private Sub dtDataValorRefTexto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDataValorRefTexto.CellDoubleClick

        Try
            limpiarcampostab1()
            Dim dtseleccion, dtDetalle As New DataTable
            Dim fila, dfila As DataRow
            Dim vDetalle As New ClsDetalleValorRefTxt
            Dim parametro As New ClsItemExamenDetalle
            Dim unidad As New ClsUnidad

            dtseleccion = dtDataValorRefTexto.DataSource
            fila = dtseleccion.Rows(e.RowIndex)

            'cargar informacion de valor de referencia txt
            txtCod.Text = fila("cod_ValorReferenciaTxt")
            lblCodParametro.Text = fila("cod_Parametro")
            txtDescripcion2.Text = fila("descripcion")
            txtEdadde.Text = fila("edadde")
            txtEdaden.Text = fila("edaden")
            txtEdadhasta.Text = fila("edadhasta")
            cbxGenero2.SelectedText = fila("genero")

            'cargar detalle en datagrid de valor de referencia txt
            With vDetalle

                .Cod_TXT = Convert.ToInt32(txtCod.Text)
                dtDetalle = .listarDetallesValorestxt

                For index As Integer = 0 To dtDetalle.Rows.Count - 1
                    dfila = dtDetalle.Rows(index)
                    dtDetalleTexto.Rows.Add(New String() {CStr(dfila("cod_DetalleValorReftxt")), (dfila("texto"))})
                Next

            End With

            'cargar información de parámetro
            parametro.codigo_ = Convert.ToInt32(lblCodParametro.Text)
            dtseleccion = parametro.BuscarDetalleExamen
            fila = dtseleccion.Rows(0)

            txtParametro2.Text = fila("nombre")
            lblCodUnidad.Text = fila("codigoUnidad")

            'cargar unidad
            'unidad.Codigo_ = Convert.ToInt32(lblCodUnidad.Text)

            'dtseleccion = unidad.BuscarUnidadCode

            'fila = dtseleccion.Rows(0)

            txtunidad2.Text = fila("unidad_codigo_breve")

            btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception
            MsgBox("Hubo un error al cargar la información. Uno de los campos no existe.")
        End Try

    End Sub

    Private Sub cbxGenero2_TextChanged(sender As Object, e As EventArgs) Handles cbxGenero2.TextChanged
        If cbxGenero2.BackColor = Color.Red Then
            cbxGenero2.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarTXT.TextChanged
        Try

            Dim valortxt As New ClsValoresReferenciaTXT

            If txtBuscarTXT.Text = "" Then

                dtDataValorRefTexto.DataSource = valortxt.listarValoresTXT
            Else
                With valortxt

                    .Descripcion_ = txtBuscarTXT.Text
                    dtDataValorRefTexto.DataSource = .buscarValorReferenciaTXT

                End With

            End If

            If dtDataValoresRef.Columns.Contains("cod_ValorReferenciaTxt") = True Then

                dtDataValorRefTexto.Columns("cod_ValorReferenciaTxt").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("cod_ValorReferenciaTxt").HeaderText = "Código"

                dtDataValorRefTexto.Columns("cod_Parametro").Visible = False

                dtDataValorRefTexto.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("descripcion").HeaderText = "Descripción"

                dtDataValorRefTexto.Columns("edadde").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("edadde").HeaderText = "Edad de"

                dtDataValorRefTexto.Columns("edadhasta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("edadhasta").HeaderText = "Edad Hasta"

                dtDataValorRefTexto.Columns("edaden").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("edaden").HeaderText = "Edad en"

                dtDataValorRefTexto.Columns("genero").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dtDataValorRefTexto.Columns("genero").HeaderText = "Genero"

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtValoresRef_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtValoresRef.CellClick
        If e.ColumnIndex = 6 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar el detalle valor de referencia?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    If dtValoresRef.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                        codigoValRef.Add(Me.dtValoresRef.Rows(e.RowIndex).Cells(0).Value())
                    End If
                    dtValoresRef.Rows.Remove(dtValoresRef.Rows(e.RowIndex.ToString))
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub


    Private Sub dtDetalleTexto_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtDetalleTexto.CellClick
        If e.ColumnIndex = 2 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar el detalle valor de referencia de texto?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    If dtDetalleTexto.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                        codigoValRefTxt.Add(Me.dtDetalleTexto.Rows(e.RowIndex).Cells(0).Value())
                    End If
                    dtDetalleTexto.Rows.Remove(dtDetalleTexto.Rows(e.RowIndex.ToString))
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

End Class