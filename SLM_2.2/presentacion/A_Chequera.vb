Public Class A_Chequera

    Dim Chequera As New ClsChequera
    Dim Cheques As New ClsCheques

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Creacion de nueva chequera y cheques


        If txtCtaDestino.Text <> "" And txtCantidad.Text <> "" And txtBanco.Text <> "" And mtxtNumInicio.Text <> "" Then

            Dim banco As New ClsBancos
            Dim cuenta As New ClsCuenta
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
                        .Estad_o = "Habilitado"
                        .Cantida_d = Convert.ToInt64(txtCantidad.Text)
                        .registrarNuevosCheques()

                        MessageBox.Show("Se crearon " + txtCantidad.Text + "  registros de cheques.")
                    End With

                    'Limpiar Campos
                    Limpiar()

                Catch ex As Exception

                    MsgBox("Hubo un error al crear la chequera. Detalle: " + ex.Message)

                End Try

            End If

        Else
            MsgBox("Faltan campos que llenar.")
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        Dim banco As New ClsBancos
        Dim cuenta As New ClsCuenta
        Dim dt1, dt2 As New DataTable

        banco.cod_breve = txtBanco.Text
        cuenta.Cuent_a = Convert.ToInt64(txtCtaDestino.Text)

        dt1 = banco.buscarBancoCod
        dt2 = cuenta.BuscarCuenta


        If dt1.Rows.Count > 0 And dt2.Rows.Count > 0 Then

            Try

                With Chequera

                    'Capturar Variables
                    .Cod_Chequera = txtCodChequera.Text
                    .Cuenta_Destino = txtCtaDestino.Text
                    .Numero_Inicio = mtxtNumInicio.Text
                    .Cuenta_Destino = txtCtaDestino.Text
                    .Cantida_d = txtCantidad.Text
                    .Banc_o = txtBanco.Text

                    'Modificar datos de chequera
                    .modificarChequera()
                    dtChequeras.DataSource = Chequera.listarChequeras

                End With

            Catch ex As Exception
                MsgBox("Se ha modificado el registro.")
            End Try

        End If

        'Habilitar Botones
        btnGuardar.Visible = True
        btnCrear.Visible = False
        btnModificar.Visible = False

    End Sub

    Private Sub A_Chequera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar contactos
        dtChequeras.DataSource = Chequera.listarChequeras

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True

    End Sub

    'Limpiar campos
    Sub Limpiar()
        txtCodChequera.Text = ""
        txtCtaDestino.Text = ""
        txtBanco.Text = ""
        txtCantidad.Text = ""
        mtxtNumInicio.Text = ""
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
End Class