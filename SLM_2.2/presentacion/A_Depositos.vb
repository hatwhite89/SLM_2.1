Public Class frmDeposito

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ListarDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDepositosToolStripMenuItem.Click
        frmAsientos.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nuevoDeposito As New ClsDeposito
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

        'Guardar deposito en la base de datos
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

        dtDepositos.Refresh()

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

        Dim Deposito As New ClsDeposito
        'Mostrar todos los depositos registrados
        dtDepositos.DataSource = Deposito.listarDepositos

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
    Private Sub linklblCalcular_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblCalcular.LinkClicked

        Try
            'Calculo de comision
            '  txtComision.Text = Convert.ToDouble(txtContado.Text) * comi
            'Calculo del total de deposito menos comision
            txtTotalDep.Text = Convert.ToDouble(txtContado.Text) - Convert.ToDouble(txtComision.Text)
        Catch ex As Exception
            MessageBox.Show("Error al calcular la comisión.")
        End Try

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
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmDeposito_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

End Class