Public Class A_Cuenta
    'Objeto Cuenta
    Dim Cuenta As New ClsCuenta

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            'Variables de Cuenta
            Cuenta.Cuent_a = Convert.ToInt32(txtCuenta.Text)
            Cuenta.Nombr_e = txtNombre.Text
            Cuenta.Tipo_Cuenta = cbxTipoCuenta.Text
            Cuenta.Esta_do = chkEstado.Checked

            'Registro de Cuenta
            Cuenta.registrarNuevaCuenta()
            MessageBox.Show("El registro se ha guardado exitosamente")
            Limpiar()

            'Actualiza lista de cuentas
            dtCuentas.DataSource = Cuenta.listarCuentas

        Catch ex As Exception

        End Try

    End Sub


    Private Sub A_Cuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar ESC para cerrar
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar cuentas al cargar formulario
        dtCuentas.DataSource = Cuenta.listarCuentas

    End Sub

    Private Sub cbxEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged

        'Cambio de color estado de cuenta.
        If chkEstado.Checked = True Then
            lblEstadoColor.Text = "Inactiva"
            lblEstadoColor.ForeColor = Color.Red
        Else
            lblEstadoColor.Text = "Activa"
            lblEstadoColor.ForeColor = Color.Green
        End If
    End Sub

    Private Sub dtCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellClick

        'Cargar campos de cuenta en formulario
        Try
            lblCodCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(0).Value
            txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(1).Value
            txtNombre.Text = dtCuentas.Rows(e.RowIndex).Cells(2).Value
            lblTipoDetalle.Text = dtCuentas.Rows(e.RowIndex).Cells(3).Value
            chkEstado.Checked = dtCuentas.Rows(e.RowIndex).Cells(4).Value
        Catch ex As Exception

        End Try

        If lblTipoDetalle.Text = "Activo" Then

            cbxTipoCuenta.SelectedIndex = 0

        End If

        'Habilitar edicion
        btnModificar.Visible = True
        btnNuevo.Visible = True
        btnGuardar.Visible = False

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        btnGuardar.Visible = True
        btnModificar.Visible = False
        btnNuevo.Visible = False
    End Sub


    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub Limpiar() 'Limpia los campos de la ventana.

        txtCuenta.Text = ""
        txtNombre.Text = ""
        lblEstadoColor.Text = "---"
        chkEstado.Checked = False
        cbxTipoCuenta.Text = ""

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'Modificacion de Cuenta

        With Cuenta

            'Captura de Variables
            .Cod_Cuenta = lblCodCuenta.Text
            .Cuent_a = txtCuenta.Text
            .Nombr_e = txtNombre.Text
            .Esta_do = chkEstado.Checked
            .Tipo_Cuenta = cbxTipoCuenta.Text

            'Modificar
            .modificarCuenta()

            'Limpiar Campos
            Limpiar()



        End With

    End Sub


End Class