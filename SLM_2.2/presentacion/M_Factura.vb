Public Class M_Factura
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarMedico_Click(sender As Object, e As EventArgs) Handles btnbuscarMedico.Click
        M_Medico.ShowDialog()
    End Sub

    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        M_Cliente.ShowDialog()
    End Sub

    Private Sub txtcodigoCliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCliente.TextChanged
        If (txtcodigoCliente.Text <> "") Then
            Try
                Dim objClient As New ClsCliente
                With objClient
                    .Codigo1 = txtcodigoCliente.Text
                End With
                Dim dt As New DataTable
                dt = objClient.BuscarClienteCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCliente.Text = CStr(row("nombreCompleto"))
            Catch ex As Exception
                MsgBox("No existe el código del cliente.", MsgBoxStyle.Critical, "Validación")
            End Try

        Else
            txtcodigoCliente.Text = ""
            txtnombreCliente.Text = ""
        End If
    End Sub

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        limpiar()
    End Sub

    Private Sub limpiar()

        txtcodigoFactura.Text() = ""
        txtcodigoCliente.Text() = ""
        txtcodigoMedico.Text() = ""
        txtconvenio.Text() = ""
        txtpoliza.Text() = ""

        txtcodigoOficial.Text() = ""
        txtnombreCliente.Text() = ""
        txtnombreMedico.Text() = ""
        txtcodigoSede.Text() = ""
        txtsucursal.Text() = ""
        txtcodigoDocumento.Text() = ""
        txtterminal.Text() = ""
        txtnombreSede.Text() = ""

        cbxentregarMedico.Checked = False
        cbxentregarPaciente.Checked = False
        cbxenviarCorreo.Checked = False
        cbxok.Checked = False

        txtpagoPaciente.Text() = ""
        txtvuelto.Text() = ""
        txttotal.Text() = ""

    End Sub

    Private Sub txtcodigoMedico_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoMedico.TextChanged
        If (txtcodigoMedico.Text <> "") Then
            Try
                Dim objMed As New ClsMedico
                With objMed
                    .Codigo1 = txtcodigoMedico.Text
                End With
                Dim dt As New DataTable
                dt = objMed.BuscarMedicoCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreMedico.Text = "Dr. " + CStr(row("nombre_completo"))
            Catch ex As Exception
                MsgBox("No existe el código del médico.", MsgBoxStyle.Critical, "Validación")
            End Try

        Else
            txtcodigoMedico.Text = ""
            txtnombreMedico.Text = ""
        End If
    End Sub

    Private Sub txtcodigoSede_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoSede.TextChanged
        If (txtcodigoSede.Text <> "") Then
            Try
                Dim objSede As New ClsSede
                With objSede
                    .Codigo1 = txtcodigoSede.Text
                End With
                Dim dt As New DataTable
                dt = objSede.BuscarSedeCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreSede.Text = CStr(row("nombre"))
            Catch ex As Exception
                MsgBox("No existe el código de la sede.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoSede.Text = ""
            txtnombreSede.Text = ""
        End If
    End Sub

    Private Sub btnbuscarSede_Click(sender As Object, e As EventArgs) Handles btnbuscarSede.Click
        M_Sede.ShowDialog()
    End Sub
End Class