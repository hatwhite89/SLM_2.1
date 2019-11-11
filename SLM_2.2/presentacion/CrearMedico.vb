Public Class CrearMedico
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnbuscarEspecialidad.Click
        BuscarEspecialidad.ShowDialog()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
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
            MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
            Dim objMedico As New ClsMedico
            objMedico.Nombre_completo1 = texto
            objMedico.Correo1 = txtcorreo.Text
            objMedico.Correo21 = txtcorreo2.Text
            objMedico.Telefono1 = txttelefono.Text
            objMedico.Celular1 = txtcelular.Text
            objMedico.Codigo_especialidad1 = txtcodigoEspecialidad.Text
            Dim respuesta As String = ""
            respuesta = objMedico.RegistrarNuevoMedico()
            txtcorreo.Text() = ""
            txtcorreo2.Text() = ""
            txttelefono.Text() = ""
            txtcelular.Text() = ""
            txtcodigoEspecialidad.Text() = ""
            txtcodigo.Text() = ""
            'txtnombreCompleto.Text() = ""
            'gbxinformacion.Visible = False
            Me.Close()
        Else
            MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
        End If
    End Sub
End Class