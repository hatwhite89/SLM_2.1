Public Class A_Cuenta
    'Objeto Cuenta
    Dim Cuenta As New ClsCuenta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        If txtCuenta.Text <> "" And txtNombre.Text <> "" And cbxTipoCuenta.Text <> "" Then

            Try
                'Variables de Cuenta
                Cuenta.Cuent_a = Convert.ToInt32(txtCuenta.Text)
                Cuenta.Nombr_e = txtNombre.Text
                Cuenta.Tipo_Cuenta = cbxTipoCuenta.Text
                Cuenta.Esta_do = chkEstado.Checked

                'Registro de Cuenta
                Cuenta.registrarNuevaCuenta()
                dtCuentas.DataSource = Cuenta.listarCuentas

                MessageBox.Show("El registro se ha guardado exitosamente.")
                Me.Close()
                Dim fcuentas As A_Cuenta
                fcuentas = New A_Cuenta
                fcuentas.Show()

                Limpiar()

                'Actualiza lista de cuentas

                dtCuentas.DataSource = Cuenta.listarCuentas

            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try

        ElseIf txtCuenta.Text = "" Then
            MsgBox("Existen campos vacíos.")
            txtCuenta.BackColor = Color.Red

        ElseIf txtNombre.Text = "" Then
            MsgBox("Existen campos vacíos.")
            txtNombre.BackColor = Color.Red

        ElseIf cbxTipoCuenta.Text = "" Then
            MsgBox("Existen campos vacíos.")
            cbxTipoCuenta.BackColor = Color.Red

        End If




    End Sub
    Private Sub A_Cuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar ESC para cerrar
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            'frmMenuConta.Show()
        End If
    End Sub
    Private Sub A_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            alternarColoFilasDatagridview(dtCuentas)
            'Listar cuentas al cargar formulario
            dtCuentas.DataSource = Cuenta.listarCuentas

            dtCuentas.Columns("codCuenta").Width = 30
            dtCuentas.Columns("codCuenta").HeaderText = "Cód"


            dtCuentas.Columns("cuenta").Width = 50
            dtCuentas.Columns("cuenta").HeaderText = "Cuenta"


            dtCuentas.Columns("nombre").Width = 300
            dtCuentas.Columns("nombre").HeaderText = "Nombre de Cuenta"


            dtCuentas.Columns("tipoCuenta").Width = 50
            dtCuentas.Columns("tipoCuenta").HeaderText = "Tipo"

            dtCuentas.Columns("estado").Width = 70
            dtCuentas.Columns("estado").HeaderText = "Habilitado"

            'botones
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = True

        Catch ex As Exception
            MsgBox("Error al cargar las cuentas." + ex.Message)
        End Try

    End Sub
    Private Sub cbxEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged

        'Cambio de color estado de cuenta.
        If chkEstado.Checked = True Then
            lblEstadoColor.Text = "Activa"
            lblEstadoColor.ForeColor = Color.Green
        Else
            lblEstadoColor.Text = "Inactiva"
            lblEstadoColor.ForeColor = Color.Red
        End If
    End Sub
    Private Sub dtCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellClick

        'Cargar campos de cuenta en formulario
        Try

            lblCodCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(0).Value
            txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(1).Value
            txtNombre.Text = dtCuentas.Rows(e.RowIndex).Cells(2).Value
            txtNombre.Text = txtNombre.Text.Trim
            lblTipoDetalle.Text = dtCuentas.Rows(e.RowIndex).Cells(3).Value
            chkEstado.Checked = dtCuentas.Rows(e.RowIndex).Cells(4).Value

        Catch ex As Exception

        End Try
        'Eliminar espacios 
        Tipo()
        'Habilitar edicion
        btnModificar.Enabled = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        Limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnNuevo.Enabled = False

        Me.Close()
        Dim nuevo As New A_Cuenta
        nuevo.Show()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'Modificacion de Cuenta

        Try
            'Variables de Cuenta
            Cuenta.Cod_Cuenta = lblCodCuenta.Text
            Cuenta.Cuent_a = Convert.ToInt32(txtCuenta.Text)
            Cuenta.Nombr_e = txtNombre.Text
            Cuenta.Tipo_Cuenta = cbxTipoCuenta.Text
            Cuenta.Esta_do = chkEstado.Checked

            'Registro de Cuenta
            Cuenta.modificarCuenta()
            dtCuentas.DataSource = Cuenta.listarCuentas
            Me.Close()
            MessageBox.Show("El registro se ha modificado exitosamente.")

            Dim mcuentas As A_Cuenta
            mcuentas = New A_Cuenta
            mcuentas.Show()
            Limpiar()

            'Actualiza lista de cuentas

            dtCuentas.DataSource = Cuenta.listarCuentas

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try

    End Sub


    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub Limpiar() 'Limpia los campos de la ventana.

        txtCuenta.Text = ""
        txtNombre.Text = ""
        lblEstadoColor.Text = "---"
        chkEstado.Checked = False
        cbxTipoCuenta.Text = ""

    End Sub

    Sub Tipo() 'Limpia los espacios de campo lblTipoDetalle
        Dim Tipo As String
        Tipo = lblTipoDetalle.Text
        Tipo = Trim(Tipo)

        If (Tipo = "Activo") Then
            cbxTipoCuenta.SelectedItem = "Activo"
        ElseIf Tipo = "Pasivo" Then
            cbxTipoCuenta.SelectedItem = "Pasivo"
        ElseIf Tipo = "Patrimonio" Then
            cbxTipoCuenta.SelectedItem = "Patrimonio"
        ElseIf Tipo = "Ingresos" Then
            cbxTipoCuenta.SelectedItem = "Ingresos"
        ElseIf Tipo = "Gastos" Then
            cbxTipoCuenta.SelectedItem = "Gastos"
        End If
    End Sub


    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnNuevo.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

        If txtCuenta.BackColor = Color.Red Then
            txtCuenta.BackColor = Color.White
        End If

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.BackColor = Color.Red Then
            txtNombre.BackColor = Color.White
        End If
    End Sub

    Private Sub cbxTipoCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoCuenta.SelectedIndexChanged
        If cbxTipoCuenta.BackColor = Color.Red Then
            cbxTipoCuenta.BackColor = Color.White
        End If
    End Sub

    Private Sub cbxTipoCuenta_Click(sender As Object, e As EventArgs) Handles cbxTipoCuenta.Click
        If cbxTipoCuenta.BackColor = Color.Red Then
            cbxTipoCuenta.BackColor = Color.White
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try

            If txtBusqueda.Text <> "" Then

                With Cuenta

                    .Nombr_e = txtBusqueda.Text

                    dtCuentas.DataSource = .busqueda

                End With
            Else

                dtCuentas.DataSource = Cuenta.listarCuentas

            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class