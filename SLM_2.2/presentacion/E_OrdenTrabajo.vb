﻿Public Class E_OrdenTrabajo
    Dim objUser As New ClsUsuario

    Public Sub cargarOrdenTrabajo(ByVal cod_orden_trabajo As Integer)
        Try
            dgvResultados.Rows.Clear()
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

            'pendiente muestra
            dtpPmFecha.Value = CStr(row("pmFecha"))
            dtpPmHora.Value = CStr(row("pmFecha"))
            lblpmUsuario.Text = CStr(row("pmUsuario"))

            'no procesado
            dtpNpFecha.Value = CStr(row("npFecha"))
            dtpNpHora.Value = CStr(row("npFecha"))
            lblnpUsuario.Text = CStr(row("npUsuario"))

            'En Proceso
            If IsDBNull((row("epUsuario"))) = False Then
                dtpEpFecha.Format = DateTimePickerFormat.Short
                dtpEpHora.Format = DateTimePickerFormat.Time
                dtpEpFecha.Value = CStr(row("epFecha"))
                dtpEpHora.Value = CStr(row("epFecha"))
                lblepUsuario.Text = CStr(row("epUsuario"))
            End If

            'procesado
            If IsDBNull((row("prUsuario"))) = False Then
                dtpPrFecha.Format = DateTimePickerFormat.Short
                dtpPrHora.Format = DateTimePickerFormat.Time
                dtpPrFecha.Value = CStr(row("prFecha"))
                dtpPrHora.Value = CStr(row("prFecha"))
                lblprUsuario.Text = CStr(row("prUsuario"))
            End If

            'validado                       
            If IsDBNull((row("coUsuario"))) = False Then
                dtpCoFecha.Format = DateTimePickerFormat.Short
                dtpCoHora.Format = DateTimePickerFormat.Time
                dtpCoFecha.Value = CStr(row("coFecha"))
                dtpCoHora.Value = CStr(row("coFecha"))
                lblcoUsuario.Text = CStr(row("coUsuario"))
            End If

            'entregado
            If IsDBNull((row("enUsuario"))) = False Then
                dtpEnFecha.Format = DateTimePickerFormat.Short
                dtpEnHora.Format = DateTimePickerFormat.Time
                dtpEnFecha.Value = CStr(row("enFecha"))
                dtpEnHora.Value = CStr(row("enFecha"))
                lblenUsuario.Text = CStr(row("enUsuario"))
            End If

            'invalidado
            If IsDBNull((row("inUsuario"))) = False Then
                dtpInFecha.Format = DateTimePickerFormat.Short
                dtpInHora.Format = DateTimePickerFormat.Time
                dtpInFecha.Value = CStr(row("inFecha"))
                dtpInHora.Value = CStr(row("inFecha"))
                lblinUsuario.Text = CStr(row("inUsuario"))
            End If

            'estado
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

                If IsDBNull(row("resultado")) = True Then
                    dgvResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), "*", CStr(row("codigoUnidad")), CStr(row("estado"))})
                ElseIf row("resultado") = "0" Then
                    dgvResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), "*", CStr(row("codigoUnidad")), CStr(row("estado"))})
                Else
                    dgvResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("resultado")), CStr(row("codigoUnidad")), CStr(row("estado"))})
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

    Private Sub lblpmUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblpmUsuario.TextChanged
        If Trim(lblpmUsuario.Text) <> "Label1" Then
            Try

                With objUser
                    .Cod = lblpmUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtpmUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtpmUsuario.Text = ""
            End Try
        Else
            txtpmUsuario.Text = ""
        End If
    End Sub
    Private Sub lblnpUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblnpUsuario.TextChanged
        If Trim(lblnpUsuario.Text) <> "Label1" Then
            Try

                With objUser
                    .Cod = lblnpUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtnpUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtnpUsuario.Text = ""
            End Try
        Else
            txtnpUsuario.Text = ""
        End If
    End Sub
    Private Sub lblepUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblepUsuario.TextChanged
        If Trim(lblepUsuario.Text) <> "Label1" Then
            Try

                With objUser
                    .Cod = lblepUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtepUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtepUsuario.Text = ""
            End Try
        Else
            txtepUsuario.Text = ""
        End If
    End Sub
    Private Sub lblprUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblprUsuario.TextChanged
        If Trim(lblprUsuario.Text) <> "Label1" Then
            Try

                With objUser
                    .Cod = lblprUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtprUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtprUsuario.Text = ""
            End Try
        Else
            txtprUsuario.Text = ""
        End If
    End Sub
    Private Sub lblcoUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblcoUsuario.TextChanged
        If Trim(lblcoUsuario.Text) <> "Label1" Then
            Try

                With objUser
                    .Cod = lblcoUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtcoUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtcoUsuario.Text = ""
            End Try
        Else
            txtcoUsuario.Text = ""
        End If
    End Sub
    Private Sub lblenUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblenUsuario.TextChanged
        If Trim(lblenUsuario.Text) <> "Label1" Then
            Try
                With objUser
                    .Cod = lblenUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtenUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtenUsuario.Text = ""
            End Try
        Else
            txtenUsuario.Text = ""
        End If
    End Sub
    Private Sub lblinUsuario_TextChanged(sender As Object, e As EventArgs) Handles lblinUsuario.TextChanged
        If Trim(lblinUsuario.Text) <> "Label1" Then
            Try
                With objUser
                    .Cod = lblinUsuario.Text
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtinUsuario.Text = CStr(row("usuario"))
            Catch ex As Exception
                txtinUsuario.Text = ""
            End Try
        Else
            txtinUsuario.Text = ""
        End If
    End Sub

    Private Sub E_OrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class