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
        txtcodigoSucursal.Text() = ""
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

    Private Sub txtcodigoSucursal_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoSucursal.TextChanged
        If (txtcodigoSucursal.Text <> "") Then
            Try
                Dim objSuc As New ClsSucursal
                With objSuc
                    .Codigo1 = txtcodigoSucursal.Text
                End With
                Dim dt As New DataTable
                dt = objSuc.BuscarSucursalCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreSucursal.Text = CStr(row("nombre"))
            Catch ex As Exception
                MsgBox("No existe el código de la sucursal.", MsgBoxStyle.Critical, "Validación")
            End Try

        Else
            txtcodigoSucursal.Text = ""
            txtnombreSucursal.Text = ""
        End If
    End Sub

    Private Sub btnbuscarSucursal_Click(sender As Object, e As EventArgs) Handles btnbuscarSucursal.Click
        M_Sucursal.ShowDialog()
    End Sub

    Private Sub txtcodigoTerminosPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTerminosPago.TextChanged
        If (txtcodigoTerminosPago.Text <> "") Then
            Try
                Dim objTerm As New ClsTerminoPago

                With objTerm
                    .Codigo1 = txtcodigoTerminosPago.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarTerminoPagoCode()
                Dim row As DataRow = dt.Rows(0)
                'txtdescripcionTermino.Text = CStr(row("descripcion"))
            Catch ex As Exception
                MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
            End Try

        Else
            txtcodigoTerminosPago.Text = ""
        End If
    End Sub

    Private Sub btnterminosPago_Click(sender As Object, e As EventArgs) Handles btnterminosPago.Click
        M_TerminosPago.ShowDialog()
    End Sub
End Class