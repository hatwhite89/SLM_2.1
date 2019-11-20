Public Class A_Chequera

    Dim Chequera As New ClsChequera
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            With Chequera

                'Capturar Variables
                .Cuenta_Destino = txtCtaDestino.Text
                .Numero_Inicio = mtxtNumInicio.Text
                .Cuenta_Destino = txtCtaDestino.Text
                .Cantida_d = txtCantidad.Text
                .Banc_o = txtBanco.Text

                'Registrar Datos
                .registrarNuevaChequera()
                dtChequeras.DataSource = Chequera.listarCuentas

            End With

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
                dtChequeras.DataSource = Chequera.listarCuentas

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
        dtChequeras.DataSource = Chequera.listarCuentas

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
End Class