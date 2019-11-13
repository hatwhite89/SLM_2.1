
Public Class frmFormaPago
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Guardar nuevo registro de forma de pago.

        Try
            Dim FormaPago As New ClsFormaPago

            FormaPago.Cod = txtCodigo.Text
            FormaPago.Cuen_ta = Convert.ToInt32(txtCuenta.Text)
            FormaPago.Comenta_rio = txtComentario.Text
            FormaPago.Cuenta_Banco = Convert.ToInt32(txtCtaBanco.Text)
            FormaPago.Nombre_Banco = txtNombreBanco.Text
            FormaPago.Formu_lario = txtFormulario.Text
            FormaPago.Ti_po = txtTipo.Text
            FormaPago.Ban_co = txtBanco.Text
            FormaPago.Comi_sion = Convert.ToDouble(txtComision.Text)

            FormaPago.RegistrarNuevoPaciente()
            MessageBox.Show("El registro ha sido guardado exitosamente.")

        Catch ex As Exception

            MsgBox(ex.Message)

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

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click

        'Mostrar Listado de Formas de Pago
        Me.Height = 493

        'Mostrar informacion en DataGrid
        Dim FormasPago As New ClsFormaPago

        dtFormasPago.DataSource = FormasPago.informacionFormasPago





    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Height = 287

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click



        Try
            Dim FormaPago As New ClsFormaPago

            FormaPago.Cod = txtCodigo.Text
            FormaPago.Cuen_ta = Convert.ToInt32(txtCuenta.Text)
            FormaPago.Comenta_rio = txtComentario.Text
            FormaPago.Cuenta_Banco = Convert.ToInt32(txtCtaBanco.Text)
            FormaPago.Nombre_Banco = txtNombreBanco.Text
            FormaPago.Formu_lario = txtFormulario.Text
            FormaPago.Ti_po = txtTipo.Text
            FormaPago.Ban_co = txtBanco.Text
            FormaPago.Comi_sion = Convert.ToDouble(txtComision.Text)

            FormaPago.modificarFormaPago()
            MessageBox.Show("El registro se ha modificado exitosamente.")
            dtFormasPago.Refresh()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
End Class