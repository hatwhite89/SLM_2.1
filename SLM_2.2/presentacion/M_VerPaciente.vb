Public Class M_VerPaciente

    Public Sub limpiar()
        txtcorreo.ReadOnly = False
        txtcorreo2.ReadOnly = False
        txtscanId.ReadOnly = False
        txtcelular.ReadOnly = False
        txtrtn.ReadOnly = False
        txtnombre1.ReadOnly = False
        txtnombre2.ReadOnly = False
        txtapellido1.ReadOnly = False
        txtapellido2.ReadOnly = False
        rtxtdireccion.ReadOnly = False
        txttelefonoCasa.ReadOnly = False
        txttelefonoTrabajo.ReadOnly = False
        txtcodigoClasificacion.ReadOnly = False
        txtscanId.ReadOnly = False
        txtrtn.ReadOnly = False

        txtcorreo.Text = ""
        txtcorreo2.Text = ""
        txtscanId.Text = ""
        txtcelular.Text = ""
        txtrtn.Text = ""
        txtnombre1.Text = ""
        txtnombre2.Text = ""
        txtapellido1.Text = ""
        txtapellido2.Text = ""
        rtxtdireccion.Text = ""
        txttelefonoCasa.Text = ""
        txttelefonoTrabajo.Text = ""
        txtcodigoClasificacion.Text = ""
        txtnombreCompleto.Text = ""
        mtxtidentidad.Text = ""
        txtcodigo.Text = ""
        txtnombreClasificacion.Text = ""
        txtcodigoTermino.Text = "CO"
        txtcodigoCategoria.Text = ""

        rbtnfemenino.Checked = False
        rbtnmasculino.Checked = False
        gbxinfoCliente.Visible = False

    End Sub

    Private Sub lblcodeTerminoPago_TextChanged(sender As Object, e As EventArgs) Handles lblcodeTerminoPago.TextChanged
        Try
            Dim objTerm As New ClsTerminoPago
            With objTerm
                .codigo_ = lblcodeTerminoPago.Text
            End With
            Dim dt As New DataTable
            dt = objTerm.BuscarTerminoPagoNumero()
            Dim row As DataRow = dt.Rows(0)
            txtnombreTerminos.Text = CStr(row("descripcion"))
            txtcodigoTermino.Text = CStr(row("codigoTerminoPago"))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub lblcodeCategoria_TextChanged(sender As Object, e As EventArgs) Handles lblcodeCategoria.TextChanged
        Try
            Dim objCat As New ClsCategoria
            With objCat
                .codigo_ = lblcodeCategoria.Text
            End With
            Dim dt As New DataTable
            dt = objCat.BuscarCategoriaNumero()
            Dim row As DataRow = dt.Rows(0)
            txtnombreCategoria.Text = CStr(row("descripcion"))
            txtcodigoCategoria.Text = CStr(row("codigoCategoriaCliente"))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub dtpfechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechaNacimiento.ValueChanged
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpfechaNacimiento.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, dtpfechaNacimiento.Value, Now)
        Dim day As Integer = DateDiff(DateInterval.Day, dtpfechaNacimiento.Value, Now)

        If (Now.Month < dtpfechaNacimiento.Value.Month) Then
            yr -= 1
        ElseIf (Now.Month = dtpfechaNacimiento.Value.Month And Now.Day < dtpfechaNacimiento.Value.Day) Then
            yr -= 1
        End If

        If (yr = 0 And month = 1 And Now.Day < dtpfechaNacimiento.Value.Day) Then
            month -= 1
        End If

        If (yr >= 1) Then
            txtEdad.Text = yr & "a"
        ElseIf (yr = 0 And month > 0) Then
            txtEdad.Text = month & "m"
        Else
            txtEdad.Text = day & "d"
        End If
    End Sub
End Class