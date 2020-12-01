Public Class A_Chequera

    Dim Chequera As New ClsChequera
    Dim Cheques As New ClsCheques
    Dim banco As New ClsBancos
    Dim cuenta As New ClsCuenta

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Creacion de nueva chequera y cheques
        Try
            If txtCtaDestino.Text <> "" And txtCantidad.Text <> "" And txtBanco.Text <> "" And mtxtNumInicio.Text <> "" Then 'if Campos Vacios

                Dim n As String = MsgBox("¿Desea crear la nueva chequera?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then

                    Dim chequera As New ClsChequera
                    Dim codigoChequera As String

                    'Crear Chequera
                    With chequera
                        .cod_Cuenta = Convert.ToInt32(lblCodCuenta.Text)
                        .Numero_Inicio = mtxtNumInicio.Text
                        .Cantida_d = Convert.ToInt32(txtCantidad.Text)
                        .cod_Banco = Convert.ToInt32(lblCodBanco.Text)
                        codigoChequera = .registrarNuevaChequera
                    End With

                    'Insertar cantidad de cheques de la chequera
                    Dim cheque As New ClsCheques

                    With cheque
                        .Cod_Chequera = Convert.ToInt32(codigoChequera)
                        .Numero_Cheque = mtxtNumInicio.Text
                        .Cantida_d = Convert.ToInt32(txtCantidad.Text)
                        .Estad_o = "Habilitado"
                        .Moned_a = "Lps"
                        .registrarNuevosCheques()
                    End With

                    Limpiar()
                    dtChequeras.DataSource = chequera.listarChequera
                End If ' if Validacion de creación


            Else ' else campos vacios

                MsgBox("Faltan campos que llenar.")

                If txtCtaDestino.Text = "" Then
                    txtCtaDestino.BackColor = Color.Red

                ElseIf txtCantidad.Text = "" Then
                    txtCantidad.BackColor = Color.Red

                ElseIf txtBanco.Text = "" Then
                    txtBanco.BackColor = Color.Red

                ElseIf mtxtNumInicio.Text = "" Then
                    mtxtNumInicio.BackColor = Color.Red

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub A_Chequera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Listar contactos
            dtChequeras.DataSource = Chequera.listarChequera
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs)

        Limpiar()
        btnGuardar.Visible = True

    End Sub

    'Limpiar campos
    Sub Limpiar()
        txtCodChequera.Text = ""
        txtCtaDestino.Text = ""
        txtBanco.Text = ""
        txtCantidad.Text = ""
        mtxtNumInicio.Text = "00000000"
        lblCodBanco.Text = ""
        lblCodCuenta.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        A_ListadoBancos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A_ListarCuentas_Chequera.Show()
    End Sub

    Private Sub A_Chequera_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            'frmMenuConta.Show()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
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

    Private Sub mtxtNumInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtNumInicio.KeyPress
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

    Private Sub txtBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBanco.KeyPress
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

    Private Sub txtCtaDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaDestino.KeyPress

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


    Private Sub txtCtaDestino_TextChanged(sender As Object, e As EventArgs) Handles txtCtaDestino.TextChanged

        If txtCtaDestino.BackColor = Color.Red Then
            txtCtaDestino.BackColor = Color.White
        End If

    End Sub

    Private Sub mtxtNumInicio_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtNumInicio.MaskInputRejected

        If mtxtNumInicio.BackColor = Color.Red Then
            mtxtNumInicio.BackColor = Color.White
        End If

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

        If txtCantidad.BackColor = Color.Red Then
            txtCantidad.BackColor = Color.White
        End If

    End Sub

    Private Sub txtBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBanco.TextChanged

        If txtBanco.BackColor = Color.Red Then
            txtBanco.BackColor = Color.White
        End If

    End Sub
End Class