Public Class frmDeposito

    Dim Deposito As New ClsDeposito
    Dim buscarCodigo As New ClsFormaPago
    Dim asiento As New ClsAsientoContable
    Dim detalleAsiento As New ClsDetalleAsiento
    Dim periodo As New ClsPeriodoContable

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click

        Me.Close()

    End Sub

    Private Sub ListarDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDepositosToolStripMenuItem.Click

        If txtNro.Text = "" Then

            MsgBox("Debe seleccionar una transacción para ver un asiento contable.")

        Else

            Try
                With asiento

                    .Campo_Llave = Convert.ToInt32(txtNro.Text)

                    Dim dtA As DataTable
                    Dim rows As DataRow

                    dtA = .VerAsiento
                    rows = dtA.Rows(0)

                    'Asignando valores a forma Asiento

                    With frmAsientos

                        .txtNro.Text = rows("campoLlave")
                        .txtTexto.Text = rows("descripcion")
                        .dtpFecha.Value = rows("fecha")
                        .lblCodAsiento.Text = rows("cod_asiento")

                        .Show()
                    End With

                End With
            Catch ex As Exception
                MsgBox("No se registro asiento de la transaccion o ocurrio un error. Detalle: " + ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim n As String = MsgBox("¿Desea guardar el depósito?", MsgBoxStyle.YesNo, "Validación")
        If n = vbYes Then


            If txtBanco.Text <> "" And txtContado.Text <> "" And txtTipoConta.Text <> "" And txtCajero.Text <> "" And txtBanco.Text <> txtTipoConta.Text Then


                'Guardar deposito en la base de datos

                Try

                    If lblTipoDeposito.Text = "Tarjeta" Then

                        'Campos para tipo de deposito : Tarjeta
                        With Deposito
                            .Fech_a = dtpFecha.Value
                            .CodFP_Banco = Convert.ToInt32(lblCodFPBanco.Text)
                            .conta_do = Convert.ToDouble(txtContado.Text)
                            .CodFP_Contado = Convert.ToInt32(lblCodFPContado.Text)
                            .total_Depositado = Convert.ToDouble(txtTotalDep.Text)
                            .Mone_da = txtMoneda.Text
                            .mon_base = Convert.ToInt32(txtMonBase.Text)
                            .comisi_on = Convert.ToDouble(txtComision.Text)
                            .Comenta_rio = txtComentario.Text
                            .Tipo_Deposito = lblTipoDeposito.Text
                            .cod_Cajero = txtCajero.Text
                            .Estado_ = chkAnular.Checked
                            .registrarDepositos()

                        End With

                        '::::::::::::::::::::::::::::::::  Partida Contable  ::::::::::::::::::::::::::::::::

                        Try

                            With asiento

                                .Cod_Periodo = 1
                                .Descrip = txtComentario.Text
                                .Fecha_ = dtpFecha.Value

                                Dim ultimo As DataTable
                                Dim nro As DataRow

                                ultimo = Deposito.listarUltimoDeposito
                                nro = ultimo.Rows(0)

                                .Campo_Llave = Convert.ToInt32(nro("codDeposito"))

                                If .registrarAsiento = 1 Then

                                    Try
                                        Dim codasi As DataTable
                                        Dim cod As DataRow
                                        With detalleAsiento

                                            codasi = asiento.capturarCodAsiento
                                            cod = codasi.Rows(0)

                                            .Cod_Asiento = Convert.ToInt32(cod("cod_asiento"))
                                            .Debe_ = Convert.ToDouble(txtTotalDep.Text)
                                            .Haber_ = 0.0

                                            Dim dt As DataTable
                                            Dim row As DataRow
                                            buscarCodigo.Cod = txtBanco.Text
                                            dt = buscarCodigo.infoFormaPago
                                            row = dt.Rows(0)

                                            .Cuenta_ = Convert.ToInt32(row("cuenta"))

                                            .registrarDetalleAsiento()

                                        End With

                                        'Segunda Partida
                                        Dim detalleAsiento2 As New ClsDetalleAsiento

                                        With detalleAsiento2

                                            .Cod_Asiento = Convert.ToInt32(cod("cod_asiento"))
                                            .Debe_ = 0.0
                                            .Haber_ = Convert.ToDouble(txtContado.Text)

                                            Dim dt As DataTable
                                            Dim row As DataRow
                                            buscarCodigo.Cod = txtTipoConta.Text
                                            dt = buscarCodigo.infoFormaPago
                                            row = dt.Rows(0)

                                            .Cuenta_ = Convert.ToInt32(row("cuenta"))

                                            .registrarDetalleAsiento()

                                        End With

                                        'Partida de Comisión
                                        Dim comision As New ClsDetalleAsiento

                                        With comision

                                            .Cod_Asiento = Convert.ToInt32(cod("cod_asiento"))
                                            .Debe_ = Convert.ToDouble(txtComision.Text)
                                            .Haber_ = 0.0
                                            .Cuenta_ = 660005
                                            .registrarDetalleAsiento()

                                        End With

                                    Catch ex As Exception
                                        MsgBox("Error en detalle de asiento" + ex.Message)
                                    End Try

                                End If

                            End With

                        Catch ex As Exception
                            MsgBox("Aqui hay error: " + ex.Message)
                        End Try 'Partida Contable

                        Limpiar()

                    Else
                        'Campos para tipo de deposito: Deposito Bancario
                        With Deposito
                            .Fech_a = dtpFecha.Value
                            .CodFP_Banco = Convert.ToInt32(lblCodFPBanco.Text)
                            .conta_do = Convert.ToDouble(txtContado.Text)
                            .CodFP_Contado = Convert.ToInt32(lblCodFPContado.Text)
                            .total_Depositado = Convert.ToDouble(txtContado.Text)
                            .Mone_da = txtMoneda.Text
                            .mon_base = Convert.ToInt32(txtMonBase.Text)
                            .comisi_on = 0.0
                            .Comenta_rio = txtComentario.Text
                            .Tipo_Deposito = lblTipoDeposito.Text
                            .cod_Cajero = txtCajero.Text
                            .registrarDepositos()


                        End With

                        '::::::::::::::::::::::::::::::::  Partida Contable  ::::::::::::::::::::::::::::::::

                        Try

                            With asiento

                                .Cod_Periodo = 1
                                .Descrip = txtComentario.Text
                                .Fecha_ = dtpFecha.Value

                                Dim ultimo As DataTable
                                Dim nro As DataRow

                                ultimo = Deposito.listarUltimoDeposito
                                nro = ultimo.Rows(0)

                                .Campo_Llave = Convert.ToInt32(nro("codDeposito"))

                                If .registrarAsiento = 1 Then
                                    Dim codasi As DataTable
                                    Dim cod As DataRow
                                    Try

                                        With detalleAsiento

                                            codasi = asiento.capturarCodAsiento
                                            cod = codasi.Rows(0)

                                            .Cod_Asiento = Convert.ToInt32(cod("cod_asiento"))
                                            .Debe_ = Convert.ToDouble(txtContado.Text)
                                            .Haber_ = 0.0

                                            Dim dt As DataTable
                                            Dim row As DataRow
                                            buscarCodigo.Cod = txtBanco.Text
                                            dt = buscarCodigo.infoFormaPago
                                            row = dt.Rows(0)

                                            .Cuenta_ = Convert.ToInt32(row("cuenta"))

                                            .registrarDetalleAsiento()

                                        End With

                                        'Segunda Partida
                                        Dim detalleAsiento2 As New ClsDetalleAsiento

                                        With detalleAsiento2

                                            .Cod_Asiento = Convert.ToInt32(cod("cod_asiento"))
                                            .Debe_ = 0.0
                                            .Haber_ = Convert.ToDouble(txtContado.Text)

                                            Dim dt As DataTable
                                            Dim row As DataRow
                                            buscarCodigo.Cod = txtTipoConta.Text
                                            dt = buscarCodigo.infoFormaPago
                                            row = dt.Rows(0)

                                            .Cuenta_ = Convert.ToInt32(row("cuenta"))

                                            .registrarDetalleAsiento()

                                        End With

                                    Catch ex As Exception
                                        MsgBox("Error en detalle de asiento" + ex.Message)
                                    End Try

                                End If

                            End With

                        Catch ex As Exception
                            MsgBox("Aqui hay error: " + ex.Message)
                        End Try 'Partida Contable

                        Limpiar()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                MsgBox("Se registro un nuevo deposito.")
                dtDepositos.DataSource = Deposito.listarDepositos

            Else

                If txtBanco.Text = "" Then
                    MsgBox("Falta información en el formulario.")
                    txtBanco.BackColor = Color.Red
                ElseIf txtContado.Text = "" Then
                    MsgBox("Falta información en el formulario.")
                    txtContado.BackColor = Color.Red
                ElseIf txtTipoConta.Text = "" Then
                    MsgBox("Falta información en el formulario.")
                    txtTipoConta.BackColor = Color.Red
                ElseIf txtCajero.Text = "" Then
                    MsgBox("Falta información en el formulario.")
                    txtCajero.BackColor = Color.Red
                ElseIf txtBanco.Text = txtTipoConta.Text Then
                    MsgBox("Las cuentas seleccionadas no pueden ser iguales.")
                    txtBanco.BackColor = Color.Red
                    txtTipoConta.BackColor = Color.Red
                End If

            End If 'campos vacios
        End If 'validacion

    End Sub
    Private Sub btnBuscarBanco_Click(sender As Object, e As EventArgs) Handles btnBuscarBanco.Click
        'Asignar valor a label para diferenciar campo a llenar.
        A_BuscarFormaPago.lblJC.Text = 1
        A_BuscarFormaPago.Show()
    End Sub
    Private Sub btnBuscarTipoConta_Click(sender As Object, e As EventArgs) Handles btnBuscarTipoConta.Click
        'Asignar valor a label para diferenciar campo a llenar.
        A_BuscarFormaPago.lblJC.Text = 2
        A_BuscarFormaPago.Show()
    End Sub
    Private Sub frmDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dtDepositos)
            txtMonBase.Text = "1"
            Dim Deposito As New ClsDeposito
            'Mostrar todos los depositos registrados
            dtDepositos.DataSource = Deposito.listarDepositos

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtDepositos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDepositos.CellClick

        'Mostrar datos seleccionados del datagrid
        Try

            Dim dt, dt2 As New DataTable
            dt = dtDepositos.DataSource
            Dim row, row2 As DataRow
            row = dt.Rows(e.RowIndex)


            btnCrearNuevo.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False

            txtNro.Text = row("codDeposito")
            dtpFecha.Value = row("fecha")

            lblCodFPBanco.Text = row("codFPBanco")
            buscarCodigo.Codigo_FormaPago = Convert.ToInt32(lblCodFPBanco.Text)
            dt2 = buscarCodigo.buscarFormaPago()
            row2 = dt2.Rows(0)
            txtBanco.Text = row2("codigo")

            txtContado.Text = row("contado")

            lblCodFPContado.Text = row("codFPContado")
            buscarCodigo.Codigo_FormaPago = Convert.ToInt32(lblCodFPContado.Text)
            dt2 = buscarCodigo.buscarFormaPago()
            row2 = dt2.Rows(0)
            txtTipoConta.Text = row2("codigo")

            txtTotalDep.Text = row("totalDeposito")
            txtMoneda.Text = row("moneda")
            txtMonBase.Text = row("monBase")
            txtComision.Text = row("comision")
            txtComentario.Text = row("comentario")
            lblTipoDeposito.Text = row("tipoDeposito")
            txtCajero.Text = row("codCajero")
            chkAnular.Checked = row("estado")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnCrearNuevo.Click
        Try
            frmTipoDeposito.Show()
            btnGuardar.Enabled = True
            Me.Close()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim n As String = MsgBox("¿Desea modificar el depósito?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                'Enviar datos para modificar depositos

                With Deposito
                    .Cod = Convert.ToInt32(txtNro.Text)
                    .Fech_a = dtpFecha.Value
                    .CodFP_Banco = Convert.ToInt32(lblCodFPBanco.Text)
                    .conta_do = Convert.ToDouble(txtContado.Text)
                    .CodFP_Contado = Convert.ToInt32(lblCodFPContado.Text)
                    .total_Depositado = Convert.ToDouble(txtTotalDep.Text)
                    .Mone_da = txtMoneda.Text
                    .mon_base = Convert.ToInt32(txtMonBase.Text)
                    .comisi_on = Convert.ToDouble(txtComision.Text)
                    .Comenta_rio = txtComentario.Text
                    .Tipo_Deposito = lblTipoDeposito.Text
                    .cod_Cajero = txtCajero.Text
                    .Estado_ = chkAnular.Checked
                    If .modificarDepositos() = 1 Then
                        MsgBox("Se modifico el registro.")
                        Limpiar()
                        dtDepositos.DataSource = Deposito.listarDepositos
                    End If

                End With
            End If 'validacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub txtContado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContado.KeyPress
        'Solo acepta numeros.
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = False
        End If
    End Sub

    Private Sub frmDeposito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            'frmMenuConta.Show()
        End If
    End Sub

    Private Sub txtComision_TextChanged(sender As Object, e As EventArgs) Handles txtComision.TextChanged
        Try
            txtTotalDep.Text = Convert.ToDouble(txtContado.Text) - Convert.ToDouble(txtComision.Text)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtComision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComision.KeyPress
        'Solo acepta numeros.
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = False
        End If
    End Sub

    Sub Limpiar()
        txtNro.Text = ""
        dtpFecha.ResetText()
        txtBanco.Text = ""
        txtContado.Text = ""
        txtTipoConta.Text = ""
        txtTotalDep.Text = ""
        txtMoneda.Text = ""
        txtMonBase.Text = ""
        txtComision.Text = ""
        txtCajero.Text = ""
        txtComentario.Text = ""
        chkAnular.Checked = False


        'Color TextBox
        txtBanco.BackColor = Color.White
        txtContado.BackColor = Color.White
        txtTipoConta.BackColor = Color.White
        txtCajero.BackColor = Color.White


    End Sub

    Private Sub txtContado_TextChanged(sender As Object, e As EventArgs)
        txtTotalDep.Text = txtContado.Text
    End Sub

    Private Sub txtBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBanco.TextChanged
        If txtBanco.BackColor = Color.Red Then
            txtBanco.BackColor = Color.White

        End If

        If txtTipoConta.BackColor = Color.Red Then
            txtTipoConta.BackColor = Color.White
        End If

    End Sub

    Private Sub txtTipoConta_TextChanged(sender As Object, e As EventArgs) Handles txtTipoConta.TextChanged
        If txtTipoConta.BackColor = Color.Red Then
            txtTipoConta.BackColor = Color.White
        End If

        If txtBanco.BackColor = Color.Red Then
            txtBanco.BackColor = Color.White
        End If
    End Sub

    Private Sub txtContado_TextChanged_1(sender As Object, e As EventArgs) Handles txtContado.TextChanged
        If txtContado.BackColor = Color.Red Then
            txtContado.BackColor = Color.White
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtCajero_TextChanged(sender As Object, e As EventArgs) Handles txtCajero.TextChanged
        If txtCajero.BackColor = Color.Red Then
            txtCajero.BackColor = Color.White
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try
            Dim data As New DataTable
            With Deposito

                .Comenta_rio = txtBusqueda.Text
                .cod_Cajero = txtBusqueda.Text
                .Cod = Convert.ToInt32(txtBusqueda.Text)
                data = .buscarDepo
                dtDepositos.DataSource = data

            End With

        Catch ex As Exception
        End Try


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim n As String = MsgBox("¿Desea cerrar la ventana?", MsgBoxStyle.YesNo, "Validación")
        If n = vbYes Then

            Me.Close()
        End If

    End Sub

    Private Sub dtpFechaBuscar_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaBuscar.TextChanged

        Dim depoFecha As New ClsDeposito

        Try
            Dim dataF As New DataTable
            With depoFecha
                .Fech_a = dtpFechaBuscar.Value
                dataF = .buscarDepoFecha()
                dtDepositos.DataSource = dataF
            End With


        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try

            'Mostrar todos los depositos registrados
            dtDepositos.DataSource = Deposito.listarDepositos

        Catch ex As Exception

        End Try
    End Sub
End Class