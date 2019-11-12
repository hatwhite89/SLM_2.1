Public Class frmDeposito

    Private Sub CerrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ListarDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDepositosToolStripMenuItem.Click
        frmAsientos.Show()
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarDepositos.Show()
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
            .conta_do = Convert.ToInt32(txtContado.Text)
            .Tipo_Contado = txtTipoConta.Text
            .total_Depositado = Convert.ToInt32(txtTotalDep.Text)
            .Mone_da = txtMoneda.Text
            .mon_base = Convert.ToInt32(txtMonBase.Text)
            .comisi_on = Convert.ToDecimal(txtComision.Text)
            .Comenta_rio = txtComentario.Text
            .Tipo_Deposito = lblTipoDeposito.Text
            .cod_Cajero = txtCajero.Text
            .Cod_FormaPago = Convert.ToInt32(lblCodFormaPago.Text)
            .registrarNuevoDeposito()
        End With

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
    Private Sub txtContado_TextChanged(sender As Object, e As EventArgs) Handles txtContado.TextChanged

        Dim Comision As New ClsFormaPago
        Dim dt As New DataTable
        Dim comi As New Double

        Comision.Cod = txtBanco.Text

        'Capturando la comision del banco seleccionado
        dt = Comision.capturarComision
        Dim row As DataRow = dt.Rows(0)
        comi = CStr(row("comision"))

        'Calculo de comision
        txtComision.Text = Convert.ToDouble(txtContado.Text) * comi
        'Calculo del total de deposito menos comision
        txtTotalDep.Text = Convert.ToDouble(txtContado.Text) - Convert.ToDouble(txtComision.Text)
    End Sub

    Private Sub frmDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ocultar campo comision para deposito bancario
        If lblTipoDeposito.Text = "Tarjeta" Then
            lblComision.Visible = True
            txtComision.Visible = True
        Else
            lblComision.Visible = False
            txtComision.Visible = False
        End If
    End Sub
End Class