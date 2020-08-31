Public Class M_DiarioFacturacion
    Dim objFact As New ClsFactura
    Dim dv As DataView = objFact.SeleccionarDiarioFacturacion.DefaultView
    Private Sub limpiar()
        txtnumeroB.ResetText()
        txtnombreB.ResetText()
        txtNombreMedico.ResetText()
        txtDescripcionTermino.ResetText()
        cmbEstado.ResetText()
        txtUsuario.ResetText()
        txtExamen.ResetText()
        txtGrupo.ResetText()

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
            'dgbtabla.Columns("numero").HeaderText = "Número de Factura"
            'dgbtabla.Columns("nombreCompleto").HeaderText = "Cliente o Paciente"
            'dgbtabla.Columns("descripcion").HeaderText = "Término de Pago"
            'dgbtabla.Columns("total").HeaderText = "Total Factura"
            'dgbtabla.Columns("usuario").HeaderText = "Usuario"
            'dgbtabla.Columns("nombre").HeaderText = "Sucursal"
            'dgbtabla.Columns("fechaFactura").HeaderText = "Fecha Facturación"
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
        dv = objFact.SeleccionarDiarioFacturacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        'CalcularTotal()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub txtnumeroB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroB.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblForm.Text = "M_ListaPrecios" Then
                'Dim n As String = ""
                'Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
                'If e.RowIndex >= 0 Then
                '    n = MsgBox("¿Desea utilizar el examen que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
                'End If
                'If n = vbYes Then
                '    If Convert.ToInt64(lblFila.Text) >= 0 And temp <> "" Then
                '        M_ListaPrecios.dgbtabla.Rows.Remove(M_ListaPrecios.dgbtabla.Rows(lblFila.Text))
                '    End If
                '    M_ListaPrecios.dgbtabla.Rows.Insert(lblFila.Text, New String() {"", "", temp, dgbtabla.Rows(e.RowIndex).Cells(0).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value()})
                '    Me.Close()
                'End If
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
            Dim numero As Integer = Nothing
            Dim fechaFactura = Nothing, fechaDesde = Nothing, fechaHasta As Date = Nothing
            Dim estado As Boolean = Nothing

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

            'Dim objFact As New ClsFactura
            MsgBox(numero & nombreCompleto & fechaFactura & nombreMedico & descripcionTermino & estado & usuarioCajero & "desde" & fechaDesde & "fhasta" & fechaHasta & descripcionExamen & descripcionGrupo)
            'Dim dv As DataView = objFact.BuscarDiarioFacturacion(numero, nombreCompleto, fechaFactura, nombreMedico, descripcionTermino, estado, usuarioCajero, fechaDesde, fechaHasta, descripcionExamen, descripcionGrupo).DefaultView
            dv = objFact.BuscarDiarioFacturacion(numero, nombreCompleto, fechaFactura, nombreMedico, descripcionTermino, estado, usuarioCajero, fechaDesde, fechaHasta, descripcionExamen, descripcionGrupo).DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            'CalcularTotal()

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
End Class