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
        Try
            'Captura de variables
            With Banco
                .cod_breve = txtCodBreve.Text
                .Nombre_Banco = txtNombreBanco.Text
                .Estad_o = chkEstado.Checked

                'Registro de Banco
                .registrarNuevoBanco()
                dtBancos.DataSource = Banco.listarBancos()
            End With

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
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
                btnCrear.Visible = False
                btnModificar.Visible = False
                btnGuardar.Visible = True
            End With

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
            btnCrear.Visible = True
            btnModificar.Visible = True
            btnGuardar.Visible = False

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
        dtBancos.DataSource = Banco.listarBancos
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

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True
        txtBusquedaBanco.Text = ""
        dtBancos.DataSource = Banco.listarBancos
    End Sub

    Private Sub A_Bancos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            frmMenuConta.Show()
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
        frmMenuConta.Show()
    End Sub
End Class