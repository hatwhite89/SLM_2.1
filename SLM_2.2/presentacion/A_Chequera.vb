Public Class A_Chequera

    Dim Chequera As New ClsChequera
    Dim Cheques As New ClsCheques
    Dim banco As New ClsBancos
    Dim cuenta As New ClsCuenta

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Creacion de nueva chequera y cheques
        Try
            If txtCtaDestino.Text <> "" And txtCantidad.Text <> "" And txtBanco.Text <> "" And mtxtNumInicio.Text <> "" Then 'if Campos Vacios

                Dim dt1, dt2 As New DataTable

                banco.cod_breve = txtBanco.Text
                cuenta.Cuent_a = Convert.ToInt64(txtCtaDestino.Text)

                dt1 = banco.buscarBancoCod
                dt2 = cuenta.Comprobar

                If dt1.Rows.Count > 0 And dt2.Rows.Count > 0 Then

                    Try

                        With Chequera

                            'Capturar Variables
                            .Cuenta_Destino = txtCtaDestino.Text
                            .Numero_Inicio = mtxtNumInicio.Text
                            .Cuenta_Destino = txtCtaDestino.Text
                            .Cantida_d = Convert.ToInt32(txtCantidad.Text)
                            .Banc_o = txtBanco.Text

                            'Registrar Datos
                            .registrarNuevaChequera()

                            dtChequeras.DataSource = Chequera.listarUltimaChequera
                            lblCodChequera.Text = dtChequeras.Rows(0).Cells(0).Value
                            dtChequeras.DataSource = Chequera.listarChequeras
                        End With

                        'Nuevos Cheques
                        With Cheques
                            .Cod_Chequera = Convert.ToInt64(lblCodChequera.Text)
                            .Numero_Cheque = mtxtNumInicio.Text
                            .Cod_BreveBanco = txtBanco.Text
                            .Nombre_Banco = lblNombreBanc.Text
                            .Estad_o = "Habilitado"
                            .Moned_a = "Lps"
                            .Cantida_d = Convert.ToInt64(txtCantidad.Text)
                            .registrarNuevosCheques()

                            MessageBox.Show("Se crearon " + txtCantidad.Text + "  registros de cheques.")
                        End With

                        'Limpiar Campos
                        Limpiar()

                    Catch ex As Exception

                        MsgBox("Hubo un error al generar la chequera. Detalle: " + ex.Message)

                    End Try

                End If

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

            End If ' if campos vacios

        Catch ex As Exception

        End Try

    End Sub

    Private Sub A_Chequera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Listar contactos
            dtChequeras.DataSource = Chequera.listarChequeras
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Limpiar()
        btnCrear.Visible = False
        btnGuardar.Visible = True

    End Sub

    'Limpiar campos
    Sub Limpiar()
        txtCodChequera.Text = ""
        txtCtaDestino.Text = ""
        txtBanco.Text = ""
        txtCantidad.Text = ""
        mtxtNumInicio.Text = "00000000"
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

    Private Sub dtChequeras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtChequeras.CellClick
        'Muestra información de chequera en los textbox
        Try

            Dim dt As DataTable
            Dim rows As DataRow

            dt = dtChequeras.DataSource
            rows = dt.Rows(e.RowIndex)

            txtCodChequera.Text = rows("codChequera")
            txtCtaDestino.Text = rows("ctaDestino")
            mtxtNumInicio.Text = rows("nroInicio")
            txtCantidad.Text = rows("cantidad")
            txtBanco.Text = rows("banco")

            'Ocultar botones
            btnGuardar.Visible = False
            btnCrear.Visible = True

        Catch ex As Exception
            MsgBox("No se selecciono una fila o hubo un error al seleccionar.")
        End Try

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