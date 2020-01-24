
Public Class frmFormaPago
    Dim FormaPago As New ClsFormaPago
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

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

            FormaPago.Codigo_FormaPago = Convert.ToInt32(lblCodFormaPago.Text)
            FormaPago.Cod = txtCodigo.Text
            FormaPago.Cuen_ta = txtCuenta.Text
            FormaPago.Comenta_rio = txtComentario.Text
            FormaPago.Cuenta_Banco = txtCtaBanco.Text
            FormaPago.Nombre_Banco = txtNombreBanco.Text
            FormaPago.Formu_lario = txtFormulario.Text
            FormaPago.Ti_po = txtTipo.Text
            FormaPago.Ban_co = txtBanco.Text

            'Funcion modificar forma de pago seleccionada
            FormaPago.modificarFormaPago()
            'Actualizar informacion de formas de pago

            MessageBox.Show("El registro se ha modificado exitosamente.")

        Catch ex As Exception

            MsgBox("Error al modificar el registro. Detalle: " + ex.Message)

        End Try

        'Limpiar campos, habilitar para guardar nuevo registro y actulizar tabla de datos
        Limpiar()
        btnGuardar.Visible = True
        btnModificar.Visible = False
        btnCrear.Visible = False
        dtFormasPago.DataSource = FormaPago.informacionFormasPago()

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

    Private Sub frmFormaPago_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' frmMenuConta.Show()
    End Sub
End Class