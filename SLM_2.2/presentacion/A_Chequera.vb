Public Class A_Chequera

    Dim Chequera As New ClsChequera
    Dim Cheques As New ClsCheques
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Creacion de nueva chequera y cheques
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

            Dim cantidad, contador As Integer
            cantidad = Convert.ToInt32(txtCantidad.Text)

                With Cheques
                    .Cod_Chequera = lblCodChequera.Text
                    .Cod_BreveBanco = txtBanco.Text
                    .Estad_o = "Disponible"
                End With

                For contador = 1 To cantidad
                    'Insertar nuevos cheques
                    Try
                        With Cheques

                            .Numero_Cheque = Convert.ToInt32(mtxtNumInicio.Text)
                            .registrarNuevosCheques()

                        End With
                        mtxtNumInicio.Text = Convert.ToInt32(mtxtNumInicio.Text) + 1
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Next

            MessageBox.Show("Se crearon " + txtCantidad.Text + "  registros de cheques.")

            'Limpiar Campos
            Limpiar()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
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

        End Try

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
End Class