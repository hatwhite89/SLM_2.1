
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
            'FormaPago.Comi_sion = Convert.ToDouble(txtComision.Text)
            FormaPago.Retenci_on = Convert.ToDouble(txtRetencion.Text)
            FormaPago.RegistrarNuevaFormaPago()
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



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

        Me.Height = 287
        If Me.Height = 287 Then
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

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
            'FormaPago.Comi_sion = Convert.ToDouble(txtComision.Text)
            FormaPago.Retenci_on = Convert.ToDouble(txtRetencion.Text)

            FormaPago.modificarFormaPago()
            MessageBox.Show("El registro se ha modificado exitosamente.")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dtFormasPago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFormasPago.CellClick
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
            'txtComision.Text = dtFormasPago.Rows(e.RowIndex).Cells(9).Value
            txtRetencion.Text = dtFormasPago.Rows(e.RowIndex).Cells(10).Value

        Catch ex As Exception
            'MessageBox.Show("Error al hacer la selección.")
        End Try


    End Sub

    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim formasPago As New ClsFormaPago
        'Cargar listado de formas de pago
        dtFormasPago.DataSource = formasPago.mostrarFormasPago



    End Sub
End Class