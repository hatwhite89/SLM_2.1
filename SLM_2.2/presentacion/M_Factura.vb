Public Class M_Factura
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        M_ClienteVentana.Close()
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
                M_Cliente.txtcodigoCategoria.Text = CStr(row("codigoCategoria"))
                M_ClienteVentana.txtnombreCategoria.Text = M_Cliente.txtnombreCategoria.Text
            Catch ex As Exception
                'MsgBox("No existe el código del cliente.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoCliente.Text = ""
            txtnombreCliente.Text = ""
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        'limpiar los campos
        txtnumeroFactura.Text() = ""
        txtcodigoCliente.Text() = ""
        txtcodigoMedico.Text() = ""
        txtcodigoTerminosPago.Text() = "CO"
        dtpfechaVto.Value = Date.Now()
        txtcodigoConvenio.Text() = ""
        txtnumeroPoliza.Text() = ""

        txtnumeroOficial.Text() = ""
        txtnombreCliente.Text() = ""
        txtnombreMedico.Text() = ""
        txtcodigoSede.Text() = ""
        txtcodigoSucursal.Text() = ""
        txtcodigoTerminal.Text() = ""
        txtnombreSede.Text() = ""

        txtcodigoRecepecionista.Text() = ""
        txtcodigoCajero.Text() = ""
        dtpfechaFactura.Value = Date.Now()

        cbxentregarMedico.Checked = False
        cbxentregarPaciente.Checked = False
        cbxenviarCorreo.Checked = False

        dgblistadoExamenes.Rows.Clear()
        M_ClienteVentana.dgvtabla.Rows.Clear()

        cbxok.Checked = False
        txtpagoPaciente.Text() = ""
        txtvuelto.Text() = ""
        txttotal.Text() = ""
        'Habilitar los campos
        txtcodigoCliente.ReadOnly = False
        txtcodigoMedico.ReadOnly = False
        txtcodigoTerminosPago.ReadOnly = False
        dtpfechaVto.Enabled = True
        txtcodigoConvenio.ReadOnly = False
        txtnumeroPoliza.ReadOnly = False

        btnbuscarCliente.Enabled = True
        btnbuscarMedico.Enabled = True
        btnbuscarTerminosPago.Enabled = True

        txtcodigoSede.ReadOnly = False
        txtcodigoSucursal.ReadOnly = False
        txtcodigoTerminal.ReadOnly = False

        btnbuscarSede.Enabled = True
        btnbuscarSucursal.Enabled = True

        dtpfechaFactura.Enabled = True
        txtcodigoRecepecionista.ReadOnly = False
        txtcodigoCajero.ReadOnly = False

        cbxentregarMedico.Enabled = True
        cbxentregarPaciente.Enabled = True
        cbxenviarCorreo.Enabled = True

        dgblistadoExamenes.ReadOnly = False

        cbxok.Enabled = True
        txtpagoPaciente.ReadOnly = False

        btnActualizar.Enabled = False
        btncotizacion.Enabled = True
        btnguardar.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txtcodigoCliente.ReadOnly = True
        txtcodigoMedico.ReadOnly = True
        txtcodigoTerminosPago.ReadOnly = True
        dtpfechaVto.Enabled = False
        txtcodigoConvenio.ReadOnly = True
        txtnumeroPoliza.ReadOnly = True

        btnbuscarCliente.Enabled = False
        btnbuscarMedico.Enabled = False
        btnbuscarTerminosPago.Enabled = False

        txtcodigoSede.ReadOnly = True
        txtcodigoSucursal.ReadOnly = True
        txtcodigoTerminal.ReadOnly = True

        btnbuscarSede.Enabled = False
        btnbuscarSucursal.Enabled = False

        dtpfechaFactura.Enabled = False
        txtcodigoRecepecionista.ReadOnly = True
        txtcodigoCajero.ReadOnly = True

        cbxentregarMedico.Enabled = False
        cbxentregarPaciente.Enabled = False
        cbxenviarCorreo.Enabled = False

        dgblistadoExamenes.ReadOnly = True

        cbxok.Enabled = False
        txtpagoPaciente.ReadOnly = True

        btnActualizar.Enabled = True
        btncotizacion.Enabled = False
        btnguardar.Enabled = False
    End Sub
    Public Sub HabilitarActualizarFactura()
        cbxentregarMedico.Enabled = True
        cbxentregarPaciente.Enabled = True
        cbxenviarCorreo.Enabled = True

        cbxok.Enabled = True
        txtpagoPaciente.ReadOnly = False
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
                'MsgBox("No existe el código del médico.", MsgBoxStyle.Critical, "Validación")
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
                ' MsgBox("No existe el código de la sede.", MsgBoxStyle.Critical, "Validación")
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
                    .codigoSucursal_ = txtcodigoSucursal.Text
                End With
                Dim dt As New DataTable
                dt = objSuc.BuscarSucursalCode()
                Dim row As DataRow = dt.Rows(0)
                lblcodeSucursal.Text = CStr(row("codigo"))
                txtnombreSucursal.Text = CStr(row("nombre"))
                txtcodigoSucursal.Text = UCase(txtcodigoSucursal.Text)
            Catch ex As Exception
                'MsgBox("No existe el código de la sucursal.", MsgBoxStyle.Critical, "Validación")
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
                    .codigoTerminoPago_ = txtcodigoTerminosPago.Text
                End With
                Dim dt As New DataTable
                dt = objTerm.BuscarTerminoPagoCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionTermino.Text = CStr(row("descripcion"))
                M_ClienteVentana.txtnombreTerminos.Text = CStr(row("descripcion"))
                lblcodeTerminoPago.Text = CStr(row("codigo"))
            Catch ex As Exception
                'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoTerminosPago.Text = ""
            txtdescripcionTermino.Text = ""
        End If
    End Sub
    Private Sub btnterminosPago_Click(sender As Object, e As EventArgs) Handles btnbuscarTerminosPago.Click
        M_TerminosPago.lblform.Text = "factura"
        M_TerminosPago.ShowDialog()
    End Sub
    Private Sub M_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        M_ClienteVentana.Show()
        Dim btn As New DataGridViewButtonColumn()
        dgblistadoExamenes.Columns.Add(btn)
        btn.HeaderText = "Eliminar"
        btn.Text = "Eliminar"
        btn.Name = "btnEliminar"
        btn.UseColumnTextForButtonValue = True
        totalFactura()
    End Sub
    Private Sub txtconvenio_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoConvenio.TextChanged
        M_ClienteVentana.txtnombreConvenio.Text = txtcodigoConvenio.Text
    End Sub
    Private Sub txtpagoPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtpagoPaciente.TextChanged
        Try
            M_ClienteVentana.txtpagoPaciente.Text = txtpagoPaciente.Text
            txtvuelto.Text = Convert.ToInt32(txtpagoPaciente.Text) - Convert.ToInt32(txttotal.Text)
            M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtnombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtnombreCliente.TextChanged
        M_ClienteVentana.txtnombreCompleto.Text = txtnombreCliente.Text
    End Sub
    Private Sub txtvuelto_TextChanged(sender As Object, e As EventArgs) Handles txtvuelto.TextChanged
        M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
    End Sub
    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        M_ClienteVentana.txttotal.Text = txttotal.Text
        Try
            M_ClienteVentana.txtpagoPaciente.Text = txtpagoPaciente.Text
            txtvuelto.Text = Convert.ToInt32(txtpagoPaciente.Text) - Convert.ToInt32(txttotal.Text)
            M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgblistadoExamenes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgblistadoExamenes.CellClick
        If e.ColumnIndex = 7 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar el examen de la factura?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                    M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(e.RowIndex.ToString))
                    totalFactura()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub dgblistadoExamenes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgblistadoExamenes.CellEndEdit

        If e.ColumnIndex = 0 Then
            Try
                If (Trim(dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value()) <> "") Then
                    Dim objExam As New ClsExamen
                    With objExam
                        .Codigo1 = dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value()
                    End With

                    Dim dt As New DataTable
                    dt = objExam.BuscarExamen()

                    Dim row As DataRow = dt.Rows(0)
                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                    Dim subtotal As Double = Convert.ToDouble(CStr(row("total")))
                    Dim descuento As Double
                    descuento = subtotal * (0 / 100)
                    subtotal -= descuento
                    dgblistadoExamenes.Rows.Insert(e.RowIndex.ToString, New String() {objExam.Codigo1, "1", CStr(row("total")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(7), "0", subtotal})
                    totalFactura()

                    M_ClienteVentana.dgvtabla.Rows.Add(New String() {objExam.Codigo1, "1", CStr(row("total")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(7), "0", subtotal})
                Else
                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                End If
            Catch ex As Exception
                MsgBox("No existe el código del examen", MsgBoxStyle.Critical)
                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
            End Try
        ElseIf e.ColumnIndex = 1 Then
            Try
                Dim code, cant As Integer
                Dim precio, subtotal, descuento, porcDesc As Double
                Dim descrip As String
                code = Convert.ToInt32(dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value())
                cant = Convert.ToInt32(dgblistadoExamenes.Rows(e.RowIndex).Cells(1).Value())
                precio = Convert.ToDouble(dgblistadoExamenes.Rows(e.RowIndex).Cells(2).Value())
                descrip = dgblistadoExamenes.Rows(e.RowIndex).Cells(3).Value()
                porcDesc = Convert.ToDouble(dgblistadoExamenes.Rows(e.RowIndex).Cells(5).Value())
                subtotal = precio * cant
                descuento = subtotal * (porcDesc / 100)
                subtotal -= descuento
                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                dgblistadoExamenes.Rows.Insert(e.RowIndex.ToString, New String() {code, cant, precio, descrip, Me.dtpfechaFactura.Value.Date.AddDays(7), porcDesc, subtotal})

                M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(e.RowIndex.ToString))
                M_ClienteVentana.dgvtabla.Rows.Add(New String() {code, cant, precio, descrip, Me.dtpfechaFactura.Value.Date.AddDays(7), porcDesc, subtotal})
                totalFactura()
            Catch ex As Exception
                MsgBox("Debe ingresar la cantidad correcta de examenes.", MsgBoxStyle.Critical)
                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
            End Try
        End If
    End Sub
    Public Sub totalFactura()
        Dim total As Double
        For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 1
            total += Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
        Next
        txttotal.Text = total
    End Sub
    Private Sub btnbusquedaExamen_Click(sender As Object, e As EventArgs) Handles btnbusquedaExamen.Click
        M_BuscarExamen.ShowDialog()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If (txtcodigoCliente.Text <> "" And txtcodigoMedico.Text <> "" And txtcodigoTerminosPago.Text <> "" And
                txtcodigoSede.Text <> "" And txtcodigoSucursal.Text <> "" And
                txttotal.Text <> "" And dgblistadoExamenes.Rows.Count > 0) Then

                Dim objFact As New ClsFactura
                With objFact
                    .numeroOficial_ = txtnumeroOficial.Text
                    .codigoCliente_ = txtcodigoCliente.Text
                    .codigoRecepcionista_ = txtcodigoRecepecionista.Text
                    .codigoMedico_ = txtcodigoMedico.Text
                    .codigoCajero_ = txtcodigoCajero.Text
                    .codigoTerminoPago1 = lblcodeTerminoPago.Text
                    .codigoSede_ = txtcodigoSede.Text
                    .fechaVto_ = dtpfechaVto.Value
                    .codigoSucursal_ = lblcodeSucursal.Text
                    .codigoConvenio_ = txtcodigoConvenio.Text
                    .numeroPoliza_ = txtnumeroPoliza.Text
                    .codigoTerminal_ = txtcodigoTerminal.Text
                    .entregaMedico_ = cbxentregarMedico.Checked
                    .entregaPaciente_ = cbxentregarPaciente.Checked
                    .enviarEmail_ = cbxenviarCorreo.Checked
                    .pagoPaciente_ = txtpagoPaciente.Text
                    .vuelto_ = txtvuelto.Text
                    .total_ = txttotal.Text
                    .ok_ = cbxok.Checked
                End With

                If objFact.RegistrarNuevaFactura() = 1 Then
                    deshabilitar()
                    cbxok.Enabled = True
                    txtpagoPaciente.ReadOnly = False
                    Dim dt As New DataTable
                    dt = objFact.BuscarFacturaCode()
                    Dim row As DataRow = dt.Rows(0)

                    txtnumeroFactura.Text = CStr(row("numero"))
                    Dim objDetalleFact As New ClsDetalleFactura
                    For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                        With objDetalleFact
                            .numeroFactura_ = Convert.ToInt32(txtnumeroFactura.Text)
                            .codigoExamen_ = Convert.ToInt32(dgblistadoExamenes.Rows(index).Cells(0).Value())
                            .cantidad_ = Convert.ToInt32(dgblistadoExamenes.Rows(index).Cells(1).Value())
                            .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                            .descuento_ = Convert.ToInt32(dgblistadoExamenes.Rows(index).Cells(5).Value())
                            .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                        End With
                        If objDetalleFact.RegistrarNuevoDetalleFactura() = 0 Then
                            MsgBox("Error al querer insertar el detalle de factura.")
                        End If
                    Next
                    MsgBox("Registrada la factura correctamente.")
                Else
                    MsgBox("Error al querer registrar la factura.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoCliente.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodigoMedico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoMedico.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodigoSede_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoSede.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub btncotizacion_Click(sender As Object, e As EventArgs) Handles btncotizacion.Click
        Try
            If (txtcodigoCliente.Text <> "" And txtcodigoTerminosPago.Text <> "" And
                txtcodigoSucursal.Text <> "" And txttotal.Text <> "" And dgblistadoExamenes.Rows.Count > 0) Then

                Dim objCotiz As New ClsCotizacion
                With objCotiz
                    .codigoCliente_ = txtcodigoCliente.Text
                    .codigoRecepcionista_ = txtcodigoRecepecionista.Text
                    .codigoTerminoPago_ = txtcodigoTerminosPago.Text
                    .codigoSucursal_ = txtcodigoSucursal.Text
                    .total_ = txttotal.Text
                End With

                If objCotiz.RegistrarNuevaCotizacion() = 1 Then
                    deshabilitar()
                    btnActualizar.Enabled = False
                    Dim dt As New DataTable
                    dt = objCotiz.BuscarCotizacionCode()
                    Dim row As DataRow = dt.Rows(0)

                    txtnumeroFactura.Text = CStr(row("numero"))
                    btnguardar.Enabled = False
                    btncotizacion.Enabled = False
                    Dim objCotFact As New ClsCotizacionFactura
                    For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                        With objCotFact
                            .numeroCotizacion_ = Convert.ToInt32(txtnumeroFactura.Text)
                            .codigoExamen_ = Convert.ToInt32(dgblistadoExamenes.Rows(index).Cells(0).Value())
                            .cantidad_ = Convert.ToInt32(dgblistadoExamenes.Rows(index).Cells(1).Value())
                            .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                            .descuento_ = Convert.ToInt32(dgblistadoExamenes.Rows(index).Cells(5).Value())
                            .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                        End With
                        If objCotFact.RegistrarNuevaCotizacionFactura() = 0 Then
                            MsgBox("Error al querer insertar el detalle de la cotización.")
                        End If
                    Next
                    MsgBox("Registrada la cotización correctamente.")
                Else
                    MsgBox("Error al querer registrar la cotización.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If (txtpagoPaciente.Text <> "") Then
                Dim objFact As New ClsFactura
                With objFact
                    .numero_ = txtcodigoCliente.Text
                    .entregaMedico_ = txtcodigoRecepecionista.Text
                    .entregaPaciente_ = txtcodigoTerminosPago.Text
                    .enviarEmail_ = txtcodigoSucursal.Text
                    .ok_ = txttotal.Text
                    .pagoPaciente_ = txtpagoPaciente.Text
                    .vuelto_ = txtvuelto.Text
                End With

                If objFact.ModificarFactura() = 1 Then
                    deshabilitar()
                    MsgBox("Actualizada la factura correctamente.")
                Else
                    MsgBox("Error al querer actualizar la factura.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class