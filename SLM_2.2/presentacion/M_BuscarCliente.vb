Public Class M_BuscarCliente
    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        If (mtxtidentidadClienteB.MaskCompleted = True) Then
            Try
                Dim genero As String = ""
                Dim objClient As New ClsCliente
                With objClient
                    .Identidad1 = mtxtidentidadClienteB.Text
                End With

                Dim dt As New DataTable
                dt = objClient.BuscarCliente()
                Dim row As DataRow = dt.Rows(0)

                txtcodigo.Text = CStr(row("codigo"))
                txtscanId.Text = CStr(row("scanId"))
                mtxtidentidad.Text = CStr(row("identidad"))
                txtrtn.Text = CStr(row("rtn"))
                txtnombre1.Text = CStr(row("nombre1"))
                txtnombre2.Text = CStr(row("nombre2"))
                txtapellido1.Text = CStr(row("apellido1"))
                txtapellido2.Text = CStr(row("apellido2"))
                txtnombreCompleto.Text = CStr(row("nombreCompleto"))
                dtpfechaNacimiento.Text = CStr(row("fechaNacimiento"))
                genero = CStr(row("genero"))
                If (genero = "Masculino") Then
                    rbtnmasculino.Checked = True
                Else
                    rbtnfemenino.Checked = True
                End If
                rtxtdireccion.Text = CStr(row("direccion"))
                txttelefonoCasa.Text = CStr(row("telCasa"))
                txttelefonoTrabajo.Text = CStr(row("telTrabajo"))
                txtcelular.Text = CStr(row("celular"))
                txtcorreo.Text = CStr(row("correo1"))
                txtcorreo2.Text = CStr(row("correo2"))
                txtcodigoClasificacion.Text = CStr(row("codigoClasificacion"))

                gbxinfoCliente.Visible = True
                btnactualizarCliente.Enabled = True
                btnguardarCliente.Enabled = False

            Catch ex As Exception
                MsgBox("No existe el código del cliente.", MsgBoxStyle.Critical, "Validación")
                gbxinfoCliente.Visible = True
                mtxtidentidad.Text = mtxtidentidadClienteB.Text
                btnactualizarCliente.Enabled = False
                btnguardarCliente.Enabled = True
            End Try
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

    Private Sub btncrearCliente_Click(sender As Object, e As EventArgs)
        If (mtxtidentidad.MaskCompleted = True And txtnombreCompleto.Text <> "" And txttelefonoCasa.Text <> "" And txtcorreo.Text <> "" And rtxtdireccion.Text <> "") Then
            mtxtidentidadClienteB.Text = ""
            'gbxinformacion.Visible = False
            Me.Close()
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub

    Private Sub btnclasificacion_Click(sender As Object, e As EventArgs) Handles btnclasificacion.Click
        M_BuscarClasificacion.ShowDialog()
    End Sub

    Private Sub btnactualizarCliente_Click(sender As Object, e As EventArgs) Handles btnactualizarCliente.Click

    End Sub

    Private Sub txtnombre1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtnombre1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre1.KeyPress
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
        txtnombre1.Select(txtnombre1.Text.Length, 0)
    End Sub

    Private Sub txtnombre2_TextChanged(sender As Object, e As EventArgs) Handles txtnombre2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtnombre2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre2.KeyPress
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
        txtnombre2.Select(txtnombre2.Text.Length, 0)
    End Sub

    Private Sub txtapellido1_TextChanged(sender As Object, e As EventArgs) Handles txtapellido1.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtapellido1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido1.KeyPress
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
        txtapellido1.Select(txtapellido1.Text.Length, 0)
    End Sub

    Private Sub txtapellido2_TextChanged(sender As Object, e As EventArgs) Handles txtapellido2.TextChanged
        txtnombreCompleto.Text = txtnombre1.Text + " " + txtnombre2.Text + " " + txtapellido1.Text + " " + txtapellido2.Text
    End Sub

    Private Sub txtapellido2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido2.KeyPress
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
        txtapellido2.Select(txtapellido2.Text.Length, 0)
    End Sub

End Class