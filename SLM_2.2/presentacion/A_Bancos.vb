Public Class A_Bancos

    'Objeto Banco de la clase Cls Bancos
    Dim Banco As New ClsBancos
    '::::::::::::::::: Limpiar Campos ::::::::::::::::::
    Sub Limpiar()
        txtCodBreve.Text = ""
        txtNombreBanco.Text = ""
        txtCodigo.Text = ""
        chkEstado.Checked = False
        txtBusquedaBanco.Text = ""
    End Sub
    ':::::::::::::::::::::::::::::::::::::::::::::::::::
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim n As String = MsgBox("¿Desea guardar el nuevo banco?", MsgBoxStyle.YesNo, "Validación")
        If n = vbYes Then


            If txtCodBreve.Text <> "" And txtNombreBanco.Text <> "" Then

                Try
                    'Captura de variables
                    With Banco
                        .cod_breve = txtCodBreve.Text
                        .Nombre_Banco = txtNombreBanco.Text
                        .Estad_o = chkEstado.Checked
                    End With

                    'Registro de Banco
                    If Banco.registrarNuevoBanco() = 1 Then
                        dtBancos.DataSource = Banco.listarBancos()
                        MsgBox("El registro se guardo exitosamente")
                        Limpiar()

                    End If

                Catch ex As Exception
                    MsgBox("Error al guardar el registro. Detalle: " + ex.Message)
                End Try
            Else

                MsgBox("Existen campos vacíos.")

                If txtCodBreve.Text = "" Then
                    txtCodBreve.BackColor = Color.Red
                ElseIf txtNombreBanco.Text = "" Then
                    txtNombreBanco.BackColor = Color.Red
                End If

            End If
        End If

    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim n As String = MsgBox("¿Desea modificar el registro de banco?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                'Captura de variables
                With Banco
                    .Cod = Convert.ToInt32(txtCodigo.Text)
                    .cod_breve = txtCodBreve.Text
                    .Nombre_Banco = txtNombreBanco.Text
                    .Estad_o = chkEstado.Checked

                    'Modificación de Banco
                    .modificarBanco()
                    Limpiar()
                    dtBancos.DataSource = Banco.listarBancos()
                    btnCrear.Enabled = False
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = True
                End With
            End If
        Catch ex As Exception



        End Try
    End Sub

    Private Sub dtBancos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtBancos.CellClick
        Try
            'Capturar variables de banco seleccionado

            txtCodigo.Text = dtBancos.Rows(e.RowIndex).Cells(0).Value
            txtCodBreve.Text = dtBancos.Rows(e.RowIndex).Cells(1).Value
            txtNombreBanco.Text = dtBancos.Rows(e.RowIndex).Cells(2).Value
            chkEstado.Checked = dtBancos.Rows(e.RowIndex).Cells(3).Value

            'Habilitar botones de edicion
            btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        'Cambio de color estado de cuenta.
        If chkEstado.Checked = True Then
            lblEstado.Text = "Activa"
            lblEstado.ForeColor = Color.Green
        Else


            lblEstado.Text = "Inactiva"
            lblEstado.ForeColor = Color.Red

        End If
    End Sub

    Private Sub A_Bancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar Bancos registrados

        Try
            dtBancos.DataSource = Banco.listarBancos

            dtBancos.Columns("nombreBanco").Width = 170

            'botones
            btnCrear.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = True

        Catch ex As Exception
            MsgBox("Hubo un error al consultar los bancos. " + ex.Message)
        End Try

    End Sub

    Private Sub txtBusquedaBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaBanco.TextChanged

        Dim Dato As New DataView

        Try
            'Actualizar datos en datagrid con textbox
            With Banco

                .Nombre_Banco = txtBusquedaBanco.Text
                Dato = Banco.buscarBanco.DefaultView
                dtBancos.DataSource = Dato

            End With

            If txtBusquedaBanco.Text = "" Then
                dtBancos.DataSource = Banco.listarBancos
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnCrear.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        txtBusquedaBanco.Text = ""
        dtBancos.DataSource = Banco.listarBancos
    End Sub

    Private Sub A_Bancos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            'frmMenuConta.Show()
        End If
    End Sub

    Private Sub txtNombreBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreBanco.KeyPress
        'Solo letras para el campo nombre
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBusquedaBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusquedaBanco.KeyPress
        'Solo letras para el campo nombre
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub A_Bancos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'frmMenuConta.Show()
    End Sub

    Private Sub txtCodBreve_TextChanged(sender As Object, e As EventArgs) Handles txtCodBreve.TextChanged
        If txtCodBreve.BackColor = Color.Red Then
            txtCodBreve.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNombreBanco_TextChanged(sender As Object, e As EventArgs) Handles txtNombreBanco.TextChanged
        If txtNombreBanco.BackColor = Color.Red Then
            txtNombreBanco.BackColor = Color.White
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class