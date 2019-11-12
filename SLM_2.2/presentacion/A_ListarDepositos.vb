Public Class A_ListarDepositos
    Private Sub rbtnID_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnID.CheckedChanged

        lblBuscar.Visible = True
        txtID.Visible = True

        lblTipoDep.Visible = False
        cbxTipo.Visible = False

        lblForma.Visible = False
        txtForma.Visible = False


    End Sub

    Private Sub rbtnTipo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTipo.CheckedChanged
        lblBuscar.Visible = False
        txtID.Visible = False

        lblTipoDep.Visible = True
        cbxTipo.Visible = True

        lblForma.Visible = False
        txtForma.Visible = False
    End Sub

    Private Sub rbtnFormaP_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFormaP.CheckedChanged
        lblBuscar.Visible = False
        txtID.Visible = False

        lblTipoDep.Visible = False
        cbxTipo.Visible = False

        lblForma.Visible = True
        txtForma.Visible = True
    End Sub

    Private Sub ListarDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class