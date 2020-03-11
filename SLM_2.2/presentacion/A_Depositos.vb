Public Class frmDeposito

    Dim nuevoDeposito As New ClsDeposito
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

        If txtBanco.Text <> "" And txtContado.Text <> "" And txtTipoConta.Text <> "" And txtCajero.Text <> "" And txtBanco.Text <> txtTipoConta.Text Then

            'Capturar informacion de DataTable en Label
            'Validación de codigo de banco.
            Try
                Dim dt As New DataTable
                buscarCodigo.Cod = txtBanco.Text
                dt = buscarCodigo.buscarCodigoFormaPago()
                Dim row As DataRow = dt.Rows(0)
                lblCodFormaPago.Text = CStr(row("codFormaPago"))

            Catch ex As Exception
                MessageBox.Show("El código de banco no existe.")
            End Try

            'Guardar deposito en la base de datos

            Try

                If lblTipoDeposito.Text = "Tarjeta" Then
                    'Campos para tipo de deposito : Tarjeta
                    With nuevoDeposito
                        .Fech_a = dtpFecha.Value
                        .Banc_o = txtBanco.Text
                        .conta_do = Convert.ToDouble(txtContado.Text)
                        .Tipo_Contado = txtTipoConta.Text
                        .total_Depositado = Convert.ToDouble(txtTotalDep.Text)
                        .Mone_da = txtMoneda.Text
                        .mon_base = Convert.ToDouble(txtMonBase.Text)
                        .comisi_on = Convert.ToDouble(txtComision.Text)
                        .Comenta_rio = txtComentario.Text
                        .Tipo_Deposito = lblTipoDeposito.Text
                        .cod_Cajero = txtCajero.Text
                        .Cod_FormaPago = Convert.ToInt32(lblCodFormaPago.Text)
                        .registrarNuevoDeposito()

                    End With

                    '::::::::::::::::::::::::::::::::  Partida Contable  ::::::::::::::::::::::::::::::::

                    Try

                        With asiento

                            .Cod_Periodo = 1
                            .Descrip = txtComentario.Text
                            .Fecha_ = dtpFecha.Value

                            Dim ultimo As DataTable
                            Dim nro As DataRow

                            ultimo = nuevoDeposito.listarUltimoDeposito
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
                    With nuevoDeposito
                        .Fech_a = dtpFecha.Value
                        .Banc_o = txtBanco.Text
                        .conta_do = Convert.ToDouble(txtContado.Text)
                        .Tipo_Contado = txtTipoConta.Text
                        .total_Depositado = Convert.ToDouble(txtContado.Text)
                        .Mone_da = txtMoneda.Text
                        .mon_base = Convert.ToDouble(txtMonBase.Text)
                        .comisi_on = "0"
                        .Comenta_rio = txtComentario.Text
                        .Tipo_Deposito = lblTipoDeposito.Text
                        .cod_Cajero = txtCajero.Text
                        .Cod_FormaPago = Convert.ToInt32(lblCodFormaPago.Text)
                        .registrarNuevoDeposito()

                    End With

                    '::::::::::::::::::::::::::::::::  Partida Contable  ::::::::::::::::::::::::::::::::

                    Try

                        With asiento

                            .Cod_Periodo = 1
                            .Descrip = txtComentario.Text
                            .Fecha_ = dtpFecha.Value

                            Dim ultimo As DataTable
                            Dim nro As DataRow

                            ultimo = nuevoDeposito.listarUltimoDeposito
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
            dtDepositos.DataSource = nuevoDeposito.listarDepositos

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

        End If

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

            txtMonBase.Text = "1"
            Dim Deposito As New ClsDeposito
            'Mostrar todos los depositos registrados
            dtDepositos.DataSource = Deposito.listarDepositos

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Dim Deposito As New ClsDeposito
        Dim Dato As New DataView

        Try
            'Actualizar datos en datagrid con textbox
            Deposito.Cod = txtID.Text
            Dato = Deposito.buscarDepositoXCod.DefaultView
            dtDepositos.DataSource = Dato
        Catch ex As Exception
            MessageBox.Show("El código es incorrecto o el campo está vacio.")
        End Try
    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        Dim Deposito As New ClsDeposito
        Dim Dato As New DataView

        Try
            'Actualizar datos en datagrid con textbox
            Deposito.Tipo_Deposito = cbxTipo.Text
            Dato = Deposito.buscarDepositoXTipoDepo.DefaultView
            dtDepositos.DataSource = Dato
        Catch ex As Exception
            MessageBox.Show("Seleccione un tipo de deposito.")
        End Try

    End Sub

    Private Sub rbtnID_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnID.CheckedChanged

        txtID.Visible = True
        cbxTipo.Visible = False
        txtForma.Visible = False
    End Sub

    Private Sub rbtnTipo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTipo.CheckedChanged

        txtID.Visible = False
        cbxTipo.Visible = True
        txtForma.Visible = False
    End Sub

    Private Sub rbtnFormaP_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFormaP.CheckedChanged

        txtID.Visible = False
        cbxTipo.Visible = False
        txtForma.Visible = True
    End Sub

    Private Sub txtForma_TextChanged(sender As Object, e As EventArgs) Handles txtForma.TextChanged

        Dim Deposito As New ClsDeposito
        Dim Dato As New DataView

        Try
            'Actualizar datos en datagrid con textbox
            Deposito.Banc_o = txtForma.Text
            Dato = Deposito.buscarDepositoXBanco.DefaultView
            dtDepositos.DataSource = Dato
        Catch ex As Exception
            MessageBox.Show("El código es incorrecto o el campo está vacio.")
        End Try

    End Sub

    Private Sub dtDepositos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDepositos.CellClick

        'Mostrar datos seleccionados del datagrid
        Try
            btnCrearNuevo.Visible = True
            btnModificar.Visible = True
            btnGuardar.Visible = False
            txtNro.Text = dtDepositos.Rows(e.RowIndex).Cells(0).Value
            dtpFecha.Value = dtDepositos.Rows(e.RowIndex).Cells(1).Value
            txtBanco.Text = dtDepositos.Rows(e.RowIndex).Cells(2).Value
            txtContado.Text = dtDepositos.Rows(e.RowIndex).Cells(3).Value
            txtTipoConta.Text = dtDepositos.Rows(e.RowIndex).Cells(4).Value
            txtTotalDep.Text = dtDepositos.Rows(e.RowIndex).Cells(5).Value
            txtMoneda.Text = dtDepositos.Rows(e.RowIndex).Cells(6).Value
            txtMonBase.Text = dtDepositos.Rows(e.RowIndex).Cells(7).Value
            txtComision.Text = dtDepositos.Rows(e.RowIndex).Cells(8).Value
            txtComentario.Text = dtDepositos.Rows(e.RowIndex).Cells(9).Value
            lblTipoDeposito.Text = dtDepositos.Rows(e.RowIndex).Cells(10).Value
            txtCajero.Text = dtDepositos.Rows(e.RowIndex).Cells(11).Value
        Catch ex As Exception
            'MessageBox.Show("Error al hacer la selección.")
        End Try

    End Sub

    Private Sub btnCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnCrearNuevo.Click

        frmTipoDeposito.Show()
        btnGuardar.Visible = True
        Me.Close()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim modificarDeposito As New ClsDeposito
        Dim buscarCodigo As New ClsFormaPago

        'Capturar informacion de DataTable en Label
        'Validación de codigo de banco.
        Try
            Dim dt As New DataTable
            buscarCodigo.Cod = txtBanco.Text
            dt = buscarCodigo.buscarCodigoFormaPago()
            Dim row As DataRow = dt.Rows(0)
            lblCodFormaPago.Text = CStr(row("codFormaPago"))

        Catch ex As Exception
            MessageBox.Show("El código de banco no existe.")
        End Try

        'Enviar datos para modificar depositos

        With modificarDeposito
            .Cod = Convert.ToInt32(txtNro.Text)
            .Fech_a = dtpFecha.Value
            .Banc_o = txtBanco.Text
            .conta_do = Convert.ToDouble(txtContado.Text)
            .Tipo_Contado = txtTipoConta.Text
            .total_Depositado = Convert.ToDouble(txtTotalDep.Text)
            .Mone_da = txtMoneda.Text
            .mon_base = Convert.ToDouble(txtMonBase.Text)
            .comisi_on = Convert.ToDouble(txtComision.Text)
            .Comenta_rio = txtComentario.Text
            .Tipo_Deposito = lblTipoDeposito.Text
            .cod_Cajero = txtCajero.Text
            .Cod_FormaPago = Convert.ToInt32(lblCodFormaPago.Text)
            .modificarDeposito()
        End With
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Try
            'Listar todos los depositos y cancelar busqueda
            dtDepositos.DataSource = nuevoDeposito.listarDepositos


            txtID.Visible = False
            cbxTipo.Visible = False
            txtForma.Visible = False
            Limpiar()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCajero_TextChanged(sender As Object, e As EventArgs) Handles txtCajero.TextChanged
        If txtCajero.BackColor = Color.Red Then
            txtCajero.BackColor = Color.White
        End If
    End Sub
End Class