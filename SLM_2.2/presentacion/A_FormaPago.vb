
Public Class frmFormaPago
    Dim FormaPago As New ClsFormaPago
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If txtCodigo.Text <> "" And txtCuenta.Text <> "" And txtCtaBanco.Text <> "" And txtNombreBanco.Text <> "" And txtBanco.Text <> "" Then

                'Comprobar que la cuenta existe
                Dim dtC As New DataTable
                Dim cuenta As New ClsCuenta
                cuenta.Cuent_a = txtCuenta.Text

                dtC = cuenta.Comprobar

                If dtC.Rows.Count > 0 Then

                    'Guardar nuevo registro de forma de pago.

                    'Limpiar espacios de textbox
                    Dim codi, comenta, namebanc, formu, tip, banco As String

                    codi = txtCodigo.Text.Trim
                    comenta = txtComentario.Text.Trim
                    namebanc = txtNombreBanco.Text.Trim
                    formu = txtFormulario.Text.Trim
                    tip = txtTipo.Text.Trim
                    banco = txtBanco.Text.Trim

                    Try

                        With FormaPago
                            .Cod = codi
                            .Cuen_ta = txtCuenta.Text
                            .Comenta_rio = comenta
                            .Cuenta_Banco = txtCtaBanco.Text
                            .Nombre_Banco = namebanc
                            .Formu_lario = formu
                            .Ti_po = tip
                            .Ban_co = banco
                            'Funcion de registro de forma de pago
                            .RegistrarNuevaFormaPago()
                            MessageBox.Show("El registro ha sido guardado exitosamente.")
                            Limpiar()
                            'Actualizar tabla de registro
                            dtFormasPago.DataSource = .informacionFormasPago

                        End With

                    Catch ex As Exception

                        MessageBox.Show("El registro no se guardo. Detalle: " + ex.Message)


                    End Try

                Else

                    MsgBox("Hubo un error o la cuenta no existe.")

                End If

            ElseIf txtCodigo.Text = "" Then

                MsgBox("Existen campos vacíos.")
                txtCodigo.BackColor = color.Red

            ElseIf txtCuenta.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtCuenta.BackColor = color.red
            ElseIf txtCtaBanco.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtCtaBanco.BackColor = color.Red
            ElseIf txtNombreBanco.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtNombreBanco.BackColor = color.red
            ElseIf txtBanco.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtBanco.BackColor = color.Red
            End If

        Catch ex As Exception

            MsgBox("Error. " + ex.Message)

        End Try

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCtaBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaBanco.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombreBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreBanco.KeyPress
        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
        txtNombreBanco.Select(txtNombreBanco.Text.Length, 0)

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            If txtCodigo.Text <> "" And txtCuenta.Text <> "" And txtCtaBanco.Text <> "" And txtNombreBanco.Text <> "" And txtBanco.Text <> "" Then

                'Comprobar que la cuenta existe
                Dim dtC As New DataTable
                Dim cuenta As New ClsCuenta
                cuenta.Cuent_a = txtCuenta.Text

                dtC = cuenta.Comprobar

                If dtC.Rows.Count > 0 Then

                    'Guardar nuevo registro de forma de pago.

                    'Limpiar espacios de textbox
                    Dim codi, comenta, namebanc, formu, tip, banco As String

                    codi = txtCodigo.Text.Trim
                    comenta = txtComentario.Text.Trim
                    namebanc = txtNombreBanco.Text.Trim
                    formu = txtFormulario.Text.Trim
                    tip = txtTipo.Text.Trim
                    banco = txtBanco.Text.Trim

                    Try

                        With FormaPago
                            .Codigo_FormaPago = Convert.ToInt32(lblCodFormaPago.Text)
                            .Cod = codi
                            .Cuen_ta = txtCuenta.Text
                            .Comenta_rio = comenta
                            .Cuenta_Banco = txtCtaBanco.Text
                            .Nombre_Banco = namebanc
                            .Formu_lario = formu
                            .Ti_po = tip
                            .Ban_co = banco

                            'Funcion modificar forma de pago seleccionada
                            FormaPago.modificarFormaPago()
                            'Actualizar informacion de formas de pago
                            MessageBox.Show("El registro se ha modificado exitosamente.")

                            Limpiar()
                            'Actualizar tabla de registro
                            dtFormasPago.DataSource = .informacionFormasPago

                        End With

                    Catch ex As Exception

                        MessageBox.Show("El registro no se modifico. Detalle: " + ex.Message)


                    End Try

                Else

                    MsgBox("Hubo un error o la cuenta no existe.")

                End If

            ElseIf txtCodigo.Text = "" Then

                MsgBox("Existen campos vacíos.")
                txtCodigo.BackColor = Color.Red

            ElseIf txtCuenta.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtCuenta.BackColor = Color.Red
            ElseIf txtCtaBanco.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtCtaBanco.BackColor = Color.Red
            ElseIf txtNombreBanco.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtNombreBanco.BackColor = Color.Red
            ElseIf txtBanco.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtBanco.BackColor = Color.Red
            End If

            Limpiar()
            btnGuardar.Visible = True
            btnModificar.Visible = False
            btnCrear.Visible = False
            dtFormasPago.DataSource = FormaPago.informacionFormasPago()

        Catch ex As Exception

            MsgBox("Error. " + ex.Message)

        End Try
    End Sub

    Private Sub dtFormasPago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFormasPago.CellClick

        btnCrear.Visible = True
        btnModificar.Visible = True
        btnGuardar.Visible = False

        Try
            lblCodFormaPago.Text = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
            txtCodigo.Text = dtFormasPago.Rows(e.RowIndex).Cells(1).Value
            txtCuenta.Text = dtFormasPago.Rows(e.RowIndex).Cells(2).Value
            txtComentario.Text = dtFormasPago.Rows(e.RowIndex).Cells(3).Value
            txtCtaBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(4).Value
            txtNombreBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(5).Value
            txtFormulario.Text = dtFormasPago.Rows(e.RowIndex).Cells(6).Value
            txtTipo.Text = dtFormasPago.Rows(e.RowIndex).Cells(7).Value
            txtBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(8).Value

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim formasPago As New ClsFormaPago
        'Cargar listado de formas de pago
        dtFormasPago.DataSource = formasPago.mostrarFormasPago

        Try

            dtFormasPago.Columns("codFormaPago").Visible = False
            dtFormasPago.Columns("comentario").Visible = False
            dtFormasPago.Columns("formulario").Visible = False
            dtFormasPago.Columns("banco").Visible = False


            dtFormasPago.Columns("codigo").HeaderText = "Cód. Breve"
            dtFormasPago.Columns("codigo").Width = 53

            dtFormasPago.Columns("cuenta").HeaderText = "Cuenta"
            dtFormasPago.Columns("cuenta").Width = 50

            dtFormasPago.Columns("nroCtaBanco").HeaderText = "Cuenta Banco"
            dtFormasPago.Columns("nroCtaBanco").Width = 120

            dtFormasPago.Columns("nombreBanco").HeaderText = "Nombre de Banco"
            dtFormasPago.Columns("nombreBanco").Width = 250

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
            ' frmMenuConta.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A_ListarCuentas.ShowDialog()
    End Sub

    Sub Limpiar()
        txtCodigo.Text = ""
        txtCuenta.Text = ""
        txtCtaBanco.Text = ""
        txtNombreBanco.Text = ""
        txtFormulario.Text = ""
        txtBanco.Text = ""
        txtTipo.Text = ""
        txtComentario.Text = ""
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Limpiar campos y activar opcion de guardar
        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscarBanco.Click
        A_ListadoBancos.lblFormBanco.Text = "1"
        A_ListadoBancos.ShowDialog()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.BackColor = Color.Red Then
            txtCodigo.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged
        If txtCuenta.BackColor = Color.Red Then
            txtCuenta.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCtaBanco_TextChanged(sender As Object, e As EventArgs) Handles txtCtaBanco.TextChanged
        If txtCtaBanco.BackColor = Color.Red Then
            txtCtaBanco.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNombreBanco_TextChanged(sender As Object, e As EventArgs) Handles txtNombreBanco.TextChanged
        If txtNombreBanco.BackColor = Color.Red Then
            txtNombreBanco.BackColor = Color.White
        End If
    End Sub

    Private Sub txtBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBanco.TextChanged
        If txtBanco.BackColor = Color.Red Then
            txtBanco.BackColor = Color.White
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        With FormaPago

            If txtBusqueda.Text = "" Then

                .mostrarFormasPago()

            Else

                .Cod = txtBusqueda.Text
                dtFormasPago.DataSource = .infoFormaPago
                dtFormasPago.Columns("codFormaPago").Visible = False
                dtFormasPago.Columns("comentario").Visible = False
                dtFormasPago.Columns("formulario").Visible = False
                dtFormasPago.Columns("banco").Visible = False


                dtFormasPago.Columns("codigo").HeaderText = "Cód. Breve"
                dtFormasPago.Columns("codigo").Width = 53

                dtFormasPago.Columns("cuenta").HeaderText = "Cuenta"
                dtFormasPago.Columns("cuenta").Width = 50

                dtFormasPago.Columns("nroCtaBanco").HeaderText = "Cuenta Banco"
                dtFormasPago.Columns("nroCtaBanco").Width = 120

                dtFormasPago.Columns("nombreBanco").HeaderText = "Nombre de Banco"
                dtFormasPago.Columns("nombreBanco").Width = 250


            End If


        End With

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnCrear.Visible = False
        btnModificar.Visible = False
        btnGuardar.Visible = True
        dtFormasPago.DataSource = FormaPago.mostrarFormasPago
    End Sub
End Class