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

        'Capturar informacion de DataTable en Label
        Try
            Dim dt As New DataTable
            nuevoDeposito.Banc_o = txtBanco.Text
            dt = nuevoDeposito.buscarCodigoFormaPago()
            Dim row As DataRow = dt.Rows(0)
            lblCodFormaPago.Text = CStr(row("codFormaPago"))

        Catch ex As Exception
            MessageBox.Show("El código de banco es incorrecto o no existe.")
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
End Class