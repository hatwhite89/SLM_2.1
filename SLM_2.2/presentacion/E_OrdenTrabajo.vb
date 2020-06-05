Public Class E_OrdenTrabajo

    Public Sub cargarOrdenTrabajo(ByVal cod_orden_trabajo As Integer)
        Try

            'Limpiar campos de fecha y hora
            'dtpPmFecha.Format = DateTimePickerFormat.Custom
            'dtpPmFecha.CustomFormat = " "

            'dtpPmHora.Format = DateTimePickerFormat.Custom
            'dtpPmHora.CustomFormat = " "

            'dtpNpFecha.Format = DateTimePickerFormat.Custom
            'dtpNpFecha.CustomFormat = " "

            'dtpNpHora.Format = DateTimePickerFormat.Custom
            'dtpNpHora.CustomFormat = " "

            dtpEpFecha.Format = DateTimePickerFormat.Custom
            dtpEpFecha.CustomFormat = " "

            dtpEpHora.Format = DateTimePickerFormat.Custom
            dtpEpHora.CustomFormat = " "

            dtpPrHora.Format = DateTimePickerFormat.Custom
            dtpPrHora.CustomFormat = " "

            dtpPrFecha.Format = DateTimePickerFormat.Custom
            dtpPrFecha.CustomFormat = " "

            dtpCoFecha.Format = DateTimePickerFormat.Custom
            dtpCoFecha.CustomFormat = " "

            dtpCoHora.Format = DateTimePickerFormat.Custom
            dtpCoHora.CustomFormat = " "

            dtpEnFecha.Format = DateTimePickerFormat.Custom
            dtpEnFecha.CustomFormat = " "

            dtpEnHora.Format = DateTimePickerFormat.Custom
            dtpEnHora.CustomFormat = " "

            dtpInFecha.Format = DateTimePickerFormat.Custom
            dtpInFecha.CustomFormat = " "

            dtpInHora.Format = DateTimePickerFormat.Custom
            dtpInHora.CustomFormat = " "


            Dim objOrd As New ClsOrdenDeTrabajo
            With objOrd
                .cod_orden_trabajo_ = cod_orden_trabajo
            End With
            Dim dt As New DataTable
            dt = objOrd.BuscarOrdenDeTrabajo()
            Dim row As DataRow = dt.Rows(0)
            txtnumero.Text = CStr(row("cod_orden_trabajo"))
            txtnumeroFactura.Text = CStr(row("cod_factura"))
            txtcodigoPaciente.Text = CStr(row("codigoCliente"))
            dtpFechaFactura.Value = CStr(row("fechaFactura"))
            dtpHoraFactura.Value = CStr(row("fechaFactura"))
            txtcodigoCajero.Text = CStr(row("codigoCaja"))
            txtcodigoSucursal.Text = CStr(row("codigoSucursal"))

            dtpPmFecha.Value = CStr(row("pmFecha"))
            dtpPmHora.Value = CStr(row("pmFecha"))
            txtpmUsuario.Text = CStr(row("pmUsuario"))

            dtpNpFecha.Value = CStr(row("npFecha"))
            dtpNpHora.Value = CStr(row("npFecha"))
            txtnpUsuario.Text = CStr(row("npUsuario"))

            'dtpEpFecha.Value = CStr(row("epFecha"))
            'dtpEpHora.Value = CStr(row("epFecha"))
            'txtepUsuario.Text = CStr(row("epUsuario"))

            'dtpPrFecha.Value = CStr(row("prFecha"))
            'dtpPrHora.Value = CStr(row("prFecha"))
            'txtprUsuario.Text = CStr(row("prUsuario"))

            'dtpCoFecha.Value = CStr(row("coFecha"))
            'dtpCoHora.Value = CStr(row("coFecha"))
            'txtcoUsuario.Text = CStr(row("coUsuario"))

            'dtpEnFecha.Value = CStr(row("enFecha"))
            'dtpEnHora.Value = CStr(row("enFecha"))
            'txtenUsuario.Text = CStr(row("enUsuario"))

            'dtpInFecha.Value = CStr(row("inFecha"))
            'dtpInHora.Value = CStr(row("inFecha"))
            'txtinUsuario.Text = CStr(row("inUsuario"))

            lblEstadoOrden.Text = CStr(row("estado"))

            'txtcurva.Text = CStr(row("curva"))
            'txtsede.Text = CStr(row("cod_sede"))
            'txtcodigoTecnico.Text = CStr(row("cod_tecnico"))
            'txtcodigoValidador.Text = CStr(row("cod_validador"))
            'txtcodigoObjeto.Text = CStr(row("cod_objeto"))
            'txtfacturaTomaMuestra.Text = CStr(row("facturaTomaMuestra"))
            'txttecnicoLab.Text = CStr(row("tecnicoLab"))
            cbxWs.Checked = row("enviadaWS")
            cbxEmail.Checked = row("enviadaEmail")
            'dtpFechaEntrega.Text = Convert.ToDateTime(row("fechaEntrega"))
            cbxcortesia.Checked = row("cortesia")
            cbxurgente.Checked = row("urgente")
            cbxentregaMedico.Checked = row("entregarMedico")
            cbxentregaPaciente.Checked = row("entregarPaciente")
            txtcodigoArea.Text = CStr(row("cod_grupo"))
            txtcodigoSubArea.Text = CStr(row("codigoSubArea"))


            Dim objOrdDet As New ClsOrdenTrabajoDetalle
            objOrdDet.cod_orden_trabajo_ = CStr(row("cod_orden_trabajo"))
            dt = objOrdDet.BuscarOrdenTrabajoDetalle()
            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                If row("resultado") = "0" Then
                    dgvResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), "*", CStr(row("codigoUnidad")), "NO INGRESADO"})
                Else
                    dgvResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("resultado")), CStr(row("codigoUnidad")), "VALIDADO"})
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub RadioButtonX_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEnProceso.CheckedChanged, rbtnEntregado.CheckedChanged,
    '                                            rbtnInvalidado.CheckedChanged, rbtnNoProcesado.CheckedChanged, rbtnpendienteMuestra.CheckedChanged,
    '                                            rbtnProcesado.CheckedChanged, rbtnValidado.CheckedChanged
    '    Select Case sender.name
    '        Case "Pendiente Muestra"
    '            lblEstadoOrden.Text = sender.name
    '        Case "No Procesado"
    '            lblEstadoOrden.Text = sender.name
    '        Case "En Proceso"
    '            lblEstadoOrden.Text = sender.name
    '        Case "Procesado"
    '            lblEstadoOrden.Text = sender.name
    '        Case "Validado"
    '            lblEstadoOrden.Text = sender.name
    '        Case "Entregado"
    '            lblEstadoOrden.Text = sender.name
    '        Case "Invalidado"
    '            lblEstadoOrden.Text = sender.name
    '    End Select
    'End Sub

    Private Sub lblEstadoOrden_TextChanged(sender As Object, e As EventArgs) Handles lblEstadoOrden.TextChanged
        Select Case lblEstadoOrden.Text
            Case "Pendiente Muestra"
                rbtnpendienteMuestra.Checked = True
            Case "No Procesado"
                rbtnNoProcesado.Checked = True
            Case "En Proceso"
                rbtnEnProceso.Checked = True
            Case "Procesado"
                rbtnProcesado.Checked = True
            Case "Validado"
                rbtnValidado.Checked = True
            Case "Entregado"
                rbtnEntregado.Checked = True
            Case "Invalidado"
                rbtnInvalidado.Checked = True
        End Select
    End Sub
    Private Sub txtcodigoPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoPaciente.TextChanged
        Try
            Dim objClient As New ClsCliente
            With objClient
                .Codigo1 = txtcodigoPaciente.Text
            End With
            Dim dt As New DataTable
            dt = objClient.BuscarClienteCode()
            Dim row As DataRow = dt.Rows(0)
            txtnombrePaciente.Text = CStr(row("nombreCompleto"))
            txttelefono.Text = CStr(row("telCasa"))
            calcularEdad(Convert.ToDateTime(row("fechaNacimiento")))
            txtgenero.Text = CStr(row("genero"))
            txtemail.Text = CStr(row("correo1"))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub calcularEdad(ByVal fecha As Date)
        Dim yr As Integer = DateDiff(DateInterval.Year, fecha, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, fecha, Now)
        Dim day As Integer = DateDiff(DateInterval.Day, fecha, Now)

        If (Now.Month < fecha.Month) Then
            yr -= 1
        ElseIf (Now.Month = fecha.Month And Now.Day < fecha.Day) Then
            yr -= 1
        End If

        If (yr = 0 And month = 1 And Now.Day < fecha.Day) Then
            month -= 1
        End If

        If (yr >= 1) Then
            txtedad.Text = yr & "a"
        ElseIf (yr = 0 And month > 0) Then
            txtedad.Text = month & "m"
        Else
            txtedad.Text = day & "d"
        End If
    End Sub

End Class