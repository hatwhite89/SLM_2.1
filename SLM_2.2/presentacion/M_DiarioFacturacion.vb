Public Class M_DiarioFacturacion
    Dim objFact As New ClsFactura
    Dim dv As DataView = objFact.SeleccionarDiarioFacturacion.DefaultView
    Private Sub limpiar()
        txtnumeroB.Clear()
        txtnombreB.Clear()
        txtNombreMedico.Clear()
        txtDescripcionTermino.Clear()
        cmbEstado.SelectedItem = ""
        txtUsuario.Clear()
        txtExamen.Clear()
        txtGrupo.Clear()

        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = " "

        dtpFechaDesde.Format = DateTimePickerFormat.Custom
        dtpFechaDesde.CustomFormat = " "

        dtpFechaHasta.Format = DateTimePickerFormat.Custom
        dtpFechaHasta.CustomFormat = " "
    End Sub

    Private Sub dtpFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFecha.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFecha.Format = DateTimePickerFormat.Short
                dtpFecha.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFecha.Format = DateTimePickerFormat.Custom
                dtpFecha.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpFechaDesde_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaDesde.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFechaDesde.Format = DateTimePickerFormat.Short
                dtpFechaDesde.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFechaDesde.Format = DateTimePickerFormat.Custom
                dtpFechaDesde.CustomFormat = " "
        End Select

    End Sub
    Private Sub dtpFechaHasta_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFechaHasta.MouseDown

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                dtpFechaHasta.Format = DateTimePickerFormat.Short
                dtpFechaHasta.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                dtpFechaHasta.Format = DateTimePickerFormat.Custom
                dtpFechaHasta.CustomFormat = " "
        End Select

    End Sub
    Private Sub M_DiarioFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Llenado de la tabla
            SeleccionarFacturas()

            'CAMBIO DE NOMBRE COLUMNAS
            dgbtabla.Columns("numero").HeaderText = "Número de Factura"
            dgbtabla.Columns("nombreCompleto").HeaderText = "Cliente o Paciente"
            dgbtabla.Columns("descripcion").HeaderText = "Término de Pago"
            dgbtabla.Columns("total").HeaderText = "Total Factura"
            dgbtabla.Columns("usuario").HeaderText = "Usuario"
            dgbtabla.Columns("nombre").HeaderText = "Sucursal"
            dgbtabla.Columns("fechaFactura").HeaderText = "Fecha Facturación"

            'OCULTAR COLUMNAS
            'Me.dgbtabla.Columns("codigoCliente").Visible = False
            'Me.dgbtabla.Columns("codigoTerminoPago").Visible = False
            'Me.dgbtabla.Columns("codigoMedico").Visible = False
            'Me.dgbtabla.Columns("codigoCajero").Visible = False


            ''llenar el combobox medico
            'Dim objMed As New ClsMedico
            'Dim dt As New DataTable
            'dt = objMed.SeleccionarMedico()
            'cbxMedico.DataSource = dt
            'cbxMedico.DisplayMember = "nombre_completo"
            'cbxMedico.ValueMember = "codigo"


            ''llenar el combobox terminoPago
            'Dim objTerm As New ClsTerminoPago
            'Dim dt2 As New DataTable
            'dt2 = objTerm.SeleccionarTerminoPago()
            'cbxTerminoPago.DataSource = dt2
            'cbxTerminoPago.DisplayMember = "descripcion"
            'cbxTerminoPago.ValueMember = "codigo"
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub SeleccionarFacturas()

        'LLENADO DATAGRIDVIEW 
        dv = objFact.SeleccionarDiarioFacturacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        CalcularTotal()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            'LIMPIAR Y CERRAR FORMULARIO
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub txtnumeroB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroB.KeyPress
        'SOLO ACEPTA NUMEROS
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            'MOSTRAR DATOS DE LA FACTURA
            Dim n As String = ""
            If lblForm.Text = "M_DiarioFacturacion" Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea ver la factura?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    M_Factura.limpiar()
                    'Dim objFact As New ClsFactura
                    objFact.numero_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()

                    Dim dt As New DataTable
                    dt = objFact.BuscarFacturaNumero()
                    Dim row As DataRow = dt.Rows(0)

                    M_Factura.txtnumeroFactura.Text = CStr(row("numero"))
                    M_Factura.txtnumeroOficial.Text = CStr(row("numeroOficial"))
                    M_Factura.dtpfechaFactura.Value = CStr(row("fechaFactura"))
                    M_Factura.txtcodigoCliente.Text = CStr(row("codigoCliente"))
                    M_Factura.txtcodigoRecepecionista.Text = CStr(row("codigoRecepcionista"))
                    M_Factura.txtcodigoMedico.Text = CStr(row("codigoMedico"))
                    M_Factura.txtcodigoCajero.Text = CStr(row("codigoCajero"))
                    M_Factura.lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))
                    M_Factura.txtcodigoSede.Text = CStr(row("codigoSede"))
                    M_Factura.dtpfechaVto.Value = CStr(row("fechaVto"))
                    M_Factura.lblcodeSucursal.Text = CStr(row("codigoSucursal"))

                    'M_Factura.lblcodePriceList.Text = CStr(row("codigoConvenio"))
                    M_Factura.txtcodigoConvenio.Text = CStr(row("codigoConvenio"))

                    M_Factura.txtnumeroPoliza.Text = CStr(row("numeroPoliza"))
                    M_Factura.txtcodigoTerminal.Text = CStr(row("codigoTerminal"))
                    M_Factura.lblcodeSucursal.Text = CStr(row("codigoSucursal"))
                    M_Factura.cbxentregarMedico.Checked = CStr(row("entregaMedico"))
                    M_Factura.cbxentregarPaciente.Checked = CStr(row("entregaPaciente"))
                    M_Factura.cbxenviarCorreo.Checked = CStr(row("enviarEmail"))
                    M_Factura.txtpagoPaciente.Text = CStr(row("pagoPaciente"))
                    M_Factura.txtEfectivo.Text = CStr(row("ingresoEfectivo"))
                    M_Factura.txtTarjeta.Text = CStr(row("ingresoTarjeta"))
                    M_Factura.txtvuelto.Text = CStr(row("vuelto"))
                    M_Factura.txttotal.Text = CStr(row("total"))
                    M_Factura.cbxok.Checked = CStr(row("ok"))
                    M_Factura.cbxAnular.Checked = CStr(row("estado"))

                    Dim objDetFact As New ClsDetalleFactura
                    objDetFact.numeroFactura_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dt = objDetFact.BuscarDetalleFacturaIngresada()
                    For index As Integer = 0 To dt.Rows.Count - 1
                        row = dt.Rows(index)
                        M_Factura.dgblistadoExamenes.Rows.Add(New String() {CStr(row("codInterno")), CStr(row("cantidad")), CStr(row("subtotal")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal")), CStr(row("subArea")), CStr(row("numero")), CStr(row("codigoExamen"))})
                        M_ClienteVentana.dgvtabla.Rows.Add(New String() {CStr(row("codInterno")), CStr(row("cantidad")), CStr(row("subtotal")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal"))})

                        'OBSERVACIONES
                        M_Factura.dgbObservaciones.Rows.Add(New String() {CStr(row("codInterno")), CStr(row("observaciones"))})
                    Next

                    M_Factura.deshabilitar()
                    If (M_Factura.cbxok.Checked = "0") Then
                        M_Factura.HabilitarActualizarFactura()
                    Else
                        M_Factura.btnActualizar.Enabled = True
                    End If
                    'Me.Close()
                    'txtnombreB.Text = ""
                    'txtnumeroB.Text = ""
                    'Me.Hide()

                    M_Factura.Show()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroB.TextChanged
    '    'dv.RowFilter = String.Format("numero Like '%{0}%'", txtnumeroB.Text)
    '    dv.RowFilter = "Convert(" & "numero" & ", 'System.String') LIKE '%" & txtnumeroB.Text & "%'"
    '    lblcantidad.Text = dv.Count

    '    If lblcantidad.Text = "0" Then
    '        MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
    '        txtnumeroB.Text = ""
    '        SeleccionarFacturas()
    '    End If
    'End Sub

    'Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
    '    dv.RowFilter = String.Format("nombreCompleto Like '%{0}%'", txtnombreB.Text)
    '    lblcantidad.Text = dv.Count

    '    If lblcantidad.Text = "0" Then
    '        MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
    '        txtnombreB.Text = ""
    '        SeleccionarFacturas()
    '    End If
    'End Sub

    'Private Sub cbxMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMedico.SelectedIndexChanged
    '    Try
    '        dv.RowFilter = "Convert(" & "codigoMedico" & ", 'System.String') LIKE '%" & cbxMedico.SelectedValue & "%'"
    '        lblcantidad.Text = dv.Count

    '        If lblcantidad.Text = "0" Then
    '            MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
    '            txtnombreB.Text = ""
    '            SeleccionarFacturas()
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
    '    Try
    '        Dim fecha As Date = dtpFecha.Value
    '        MsgBox(fecha & " entra " & dtpFecha.Value)
    '        'dv.RowFilter = "([fecha] = '" & dtpFecha.Value & "')"
    '        dv.RowFilter = "Convert(" & "fechaFactura" & ", 'System.String') LIKE '%" & fecha & "%'"
    '        lblcantidad.Text = dv.Count

    '        If lblcantidad.Text = "0" Then
    '            MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
    '            txtnombreB.Text = ""
    '            SeleccionarFacturas()
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub cbxTerminoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTerminoPago.SelectedIndexChanged
    '    Try
    '        dv.RowFilter = "Convert(" & "codigoTerminoPago" & ", 'System.String') LIKE '%" & cbxTerminoPago.SelectedValue & "%'"
    '        lblcantidad.Text = dv.Count

    '        If lblcantidad.Text = "0" Then
    '            MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
    '            txtnombreB.Text = ""
    '            SeleccionarFacturas()
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
    '    Try
    '        Dim bandera As Boolean = False
    '        If cmbEstado.SelectedItem = "Activa" Then
    '            MsgBox("activo")
    '            bandera = False
    '        ElseIf cmbEstado.SelectedItem = "Anulada" Then
    '            bandera = True
    '        End If
    '        dv.RowFilter = "Convert(" & "estado" & ", 'System.String') LIKE '%" & bandera & "%'"
    '        lblcantidad.Text = dv.Count

    '        If lblcantidad.Text = "0" Then
    '            MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
    '            txtnombreB.Text = ""
    '            SeleccionarFacturas()
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombreCompleto = Nothing, nombreMedico = Nothing, descripcionTermino = Nothing, usuarioCajero = Nothing, descripcionExamen = Nothing, descripcionGrupo As String = Nothing
            Dim numero As System.Nullable(Of Integer) = Nothing
            Dim codigoTipoClas As System.Nullable(Of Integer) = Nothing
            Dim fechaFactura = Nothing, fechaDesde = Nothing, fechaHasta As System.Nullable(Of Date) = Nothing
            Dim estado As System.Nullable(Of Boolean) = Nothing

            If Trim(txtnumeroB.Text) <> "" Then
                numero = Integer.Parse(txtnumeroB.Text)
            Else
                numero = Nothing
            End If
            If Trim(txtnombreB.Text) <> "" Then
                nombreCompleto = txtnombreB.Text
            Else
                nombreCompleto = Nothing
            End If
            If Trim(dtpFecha.Text) <> "" Then
                fechaFactura = dtpFecha.Value
            Else
                fechaFactura = Nothing
            End If
            If Trim(txtNombreMedico.Text) <> "" Then
                nombreMedico = txtNombreMedico.Text
            Else
                nombreMedico = Nothing
            End If
            If Trim(txtDescripcionTermino.Text) <> "" Then
                descripcionTermino = txtDescripcionTermino.Text
            Else
                descripcionTermino = Nothing
            End If
            If cmbEstado.SelectedItem = "Activa" Then
                estado = False
            ElseIf cmbEstado.SelectedItem = "Anulada" Then
                estado = True
            Else
                estado = Nothing
            End If
            If Trim(txtUsuario.Text) <> "" Then
                usuarioCajero = txtUsuario.Text
            Else
                usuarioCajero = Nothing
            End If
            If Trim(dtpFechaDesde.Text) <> "" Then
                fechaDesde = dtpFechaDesde.Value
            Else
                fechaDesde = Nothing
            End If
            If Trim(dtpFechaHasta.Text) <> "" Then
                fechaHasta = dtpFechaHasta.Value
            Else
                fechaHasta = Nothing
            End If
            If Trim(txtExamen.Text) <> "" Then
                descripcionExamen = txtExamen.Text
            Else
                descripcionExamen = Nothing
            End If
            If Trim(txtGrupo.Text) <> "" Then
                descripcionGrupo = txtGrupo.Text
            Else
                descripcionGrupo = Nothing
            End If
            If Trim(txtnombreClasificacion.Text) <> "" Then
                codigoTipoClas = lblcodigoTipoClasif.Text
            Else
                codigoTipoClas = Nothing
            End If

            'MsgBox(numero & nombreCompleto & fechaFactura & nombreMedico & descripcionTermino & estado & usuarioCajero & "desde" & fechaDesde & "fhasta" & fechaHasta & descripcionExamen & descripcionGrupo)
            'Llenado de la tabla al llamar al procedimiento almacenado
            dv = objFact.BuscarDiarioFacturacion(numero, nombreCompleto, fechaFactura, nombreMedico, descripcionTermino, estado, usuarioCajero, fechaDesde, fechaHasta, descripcionExamen, descripcionGrupo, codigoTipoClas).DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            CalcularTotal()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CalcularTotal()
        'CALCULAR SUMA
        Dim sum As Double = 0
        For i As Integer = 0 To dgbtabla.Rows.Count() - 1
            sum = sum + dgbtabla.Rows(i).Cells(3).Value
        Next
        lblTotal.Text = sum.ToString()
    End Sub

    Private Sub lblTotal_TextChange(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        'Mostrar el numero con 2 decimales N2 = 1,000.00   y F2 = 1000.00
        Try
            If Trim(lblTotal.Text) <> "" Then
                lblTotal.Text = Convert.ToDecimal(lblTotal.Text).ToString("N2")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMedico_Click(sender As Object, e As EventArgs) Handles btnMedico.Click
        M_Medico.lblForm.Text = "M_DiarioFacturacion"
        M_Medico.Show()
    End Sub

    Private Sub btnTerminoPago_Click(sender As Object, e As EventArgs) Handles btnTerminoPago.Click
        M_TerminosPago.lblform.Text = "M_DiarioFacturacion"
        M_TerminosPago.Show()
    End Sub

    Private Sub btnGrupoExamen_Click(sender As Object, e As EventArgs) Handles btnGrupoExamen.Click
        E_GrupoExamen.lblform.Text = "M_DiarioFacturacion"
        E_GrupoExamen.Show()
    End Sub

    Private Sub btnExamen_Click(sender As Object, e As EventArgs) Handles btnExamen.Click
        E_DetalleExamenes.lblform.Text = "M_DiarioFacturacion"
        E_DetalleExamenes.Show()
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click

        E_Usuarios.lblForm.Text = "M_DiarioFacturacion"
        E_Usuarios.Show()
    End Sub

    Private Sub btnTipoClasificacion_Click(sender As Object, e As EventArgs) Handles btnTipoClasificacion.Click
        M_TipoClasificacion.lbltipo.Text = "M_DiarioFacturacion"
        M_TipoClasificacion.Show()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        M_Contratos.GridAExcel(dgbtabla)
    End Sub
End Class