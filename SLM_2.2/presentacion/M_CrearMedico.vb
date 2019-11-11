Public Class M_CrearMedico
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnbuscarEspecialidad.Click
        M_BuscarEspecialidad.ShowDialog()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (txtnombreCompleto.Text <> "" And txtcorreo.Text <> "" And txtcorreo2.Text <> "" And txttelefono.Text <> "" And txtcelular.Text <> "" And txtcodigoEspecialidad.Text <> "") Then
                Dim testString As String = txtnombreCompleto.Text()
                Dim texto As String = ""
                Dim testArray() As String = Split(testString)
                Dim lastNonEmpty As Integer = -1
                For i As Integer = 0 To testArray.Length - 1
                    If testArray(i) <> "" Then
                        lastNonEmpty += 1
                        testArray(lastNonEmpty) = testArray(i)
                        texto += testArray(i) + " "
                    End If
                Next
                ReDim Preserve testArray(lastNonEmpty)
                txtnombreCompleto.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = texto
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                End With

                If objMedico.RegistrarNuevoMedico() = 1 Then
                    MsgBox("Registrado correctamente.")
                    txtcorreo.ReadOnly = True
                    txtcorreo2.ReadOnly = True
                    txttelefono.ReadOnly = True
                    txtcelular.ReadOnly = True
                    txtcodigoEspecialidad.ReadOnly = True
                    txtcodigo.ReadOnly = True
                    txtnombreCompleto.ReadOnly = True
                Else
                    MsgBox("Error al querer ingresar el médico.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcorreo.Text() = ""
        txtcorreo2.Text() = ""
        txttelefono.Text() = ""
        txtcelular.Text() = ""
        txtcodigoEspecialidad.Text() = ""
        txtcodigo.Text() = ""
        txtnombreCompleto.Text() = ""

        txtcorreo.ReadOnly = False
        txtcorreo2.ReadOnly = False
        txttelefono.ReadOnly = False
        txtcelular.ReadOnly = False
        txtcodigoEspecialidad.ReadOnly = False
        txtcodigo.ReadOnly = True
        txtnombreCompleto.ReadOnly = False
    End Sub

    Private Sub txtnombreCompleto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreCompleto.KeyPress

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

        txtnombreCompleto.Select(txtnombreCompleto.Text.Length, 0)
    End Sub

    Private Sub M_CrearMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class