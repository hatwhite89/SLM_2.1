Imports System.Net.Mail
Imports System
Imports System.Text
Imports System.Globalization
Imports System.ComponentModel
Public Class M_Factura

    Public letras As String
    Dim subtotalF, descuentoF, abonoF, saldoF As Double
    Dim codigoDetalleFactura As New ArrayList
    Public banderaTipo As Boolean
    Dim objFeriado As New ClsFeriados
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        M_ClienteVentana.Close()
        Me.Close()
        M_BuscarFactura.Visible = True
    End Sub
    Private Sub btnbuscarMedico_Click(sender As Object, e As EventArgs) Handles btnbuscarMedico.Click
        M_ListarMedicos.Show()
    End Sub
    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        M_Cliente.limpiar()
        M_Cliente.Show()
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
                lblcodePriceList.Text = CStr(row("codigoListaPrecios"))
                'MsgBox(CStr(row("codigoListaPrecios")) & "   ------    " & lblcodePriceList.Text)
                lblFechaNacimiento.Text = CStr(row("fechaNacimiento"))
                'MsgBox(CStr(row("tipoConvenio")))
                M_ClienteVentana.txttelefonoCasa.Text = CStr(row("telCasa"))
                M_ClienteVentana.txttelefonoTrabajo.Text = CStr(row("telTrabajo"))
                M_ClienteVentana.txtcelular.Text = CStr(row("celular"))
                M_ClienteVentana.txtcorreo1.Text = CStr(row("correo1"))
                M_ClienteVentana.txtcorreo2.Text = CStr(row("correo2"))
                If (row("tipoConvenio")) Then
                    txtcodigoConvenio.Text = CStr(row("descripcionLp"))
                    lblcodeTerminoPago.Text = CStr(row("terminoListaPrecio"))
                    lblRTN.Text = CStr(row("rtnConvenio"))

                    'convenio con pago
                    If (row("solicitaPago")) Then
                        'ES TIPO CONVENIO Y SOLICITA PAGO
                        lblvuelto.Visible = False
                        txtvuelto.Visible = False
                        lblVuelto2.Visible = True
                        txtvuelto2.Visible = True
                        txtsubtotal.Visible = True
                        lblSubtotal.Visible = True
                        txtPorcentaje.Text = CStr(row("porcentaje"))
                        txtPorcentaje.Visible = True
                        lblPorcentaje.Visible = True
                        txtEfectivo.ReadOnly = False
                        txtTarjeta.ReadOnly = False
                        txtDeposito.ReadOnly() = False
                        txtCheque.ReadOnly() = False
                        txtTransferencia.ReadOnly() = False
                    Else
                        'ES TIPO CONVENIO SIN PAGO
                        lblvuelto.Visible = False
                        txtvuelto.Visible = False
                        lblVuelto2.Visible = False
                        txtvuelto2.Visible = False
                        txtPorcentaje.Clear()
                        txtPorcentaje.Visible = False
                        lblPorcentaje.Visible = False
                        txtsubtotal.Clear()
                        txtsubtotal.Visible = False
                        lblSubtotal.Visible = False
                        txtEfectivo.ReadOnly = True
                        txtTarjeta.ReadOnly = True
                        txtDeposito.ReadOnly() = True
                        txtCheque.ReadOnly() = True
                        txtTransferencia.ReadOnly() = True
                    End If

                Else
                    'NO ES DE TIPO CONVENIO
                    lblRTN.Text = CStr(row("rtn"))
                    txtvuelto.Visible = True
                    lblvuelto.Visible = True
                    lblVuelto2.Visible = False
                    txtvuelto2.Visible = False
                    txtvuelto2.Text() = "0"
                    txtPorcentaje.Text() = "0"
                    txtsubtotal.Text() = "0"
                    txtsubtotal.Visible = False
                    lblSubtotal.Visible = False
                    txtPorcentaje.Visible = False
                    lblPorcentaje.Visible = False
                    txtEfectivo.ReadOnly = False
                    txtTarjeta.ReadOnly = False
                    txtDeposito.ReadOnly() = False
                    txtCheque.ReadOnly() = False
                    txtTransferencia.ReadOnly() = False
                    txtcodigoConvenio.Text = ""
                    lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))
                End If
                M_Cliente.lblcodeCategoria.Text = CStr(row("codigoCategoria"))
                M_ClienteVentana.txtnombreCategoria.Text = M_Cliente.txtnombreCategoria.Text
                txtcodigoCliente.BackColor = Color.White

            Catch ex As Exception
                txtcodigoCliente.BackColor = Color.Red
                'txtcodigoCliente.Text = ""
                txtnombreCliente.Text = ""
            End Try
        Else
            lblcodePriceList.Text = "0"
            txtcodigoConvenio.Text = ""
            'txtcodigoCliente.Text = ""
            txtnombreCliente.Text = ""
            txtcodigoCliente.BackColor = Color.White
            M_ClienteVentana.txttelefonoCasa.Text = ""
            M_ClienteVentana.txttelefonoTrabajo.Text = ""
            M_ClienteVentana.txtcelular.Text = ""
            M_ClienteVentana.txtcorreo1.Text = ""
            M_ClienteVentana.txtcorreo2.Text = ""
        End If
    End Sub
    Public Sub actualizarDatosCliente()
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
                lblcodePriceList.Text = CStr(row("codigoListaPrecios"))
                'MsgBox(CStr(row("codigoListaPrecios")) & "   ------    " & lblcodePriceList.Text)
                lblFechaNacimiento.Text = CStr(row("fechaNacimiento"))
                'MsgBox(CStr(row("tipoConvenio")))
                M_ClienteVentana.txttelefonoCasa.Text = CStr(row("telCasa"))
                M_ClienteVentana.txttelefonoTrabajo.Text = CStr(row("telTrabajo"))
                M_ClienteVentana.txtcelular.Text = CStr(row("celular"))
                M_ClienteVentana.txtcorreo1.Text = CStr(row("correo1"))
                M_ClienteVentana.txtcorreo2.Text = CStr(row("correo2"))
                If (row("tipoConvenio")) Then
                    txtcodigoConvenio.Text = CStr(row("descripcionLp"))
                    lblcodeTerminoPago.Text = CStr(row("terminoListaPrecio"))
                    lblRTN.Text = CStr(row("rtnConvenio"))
                Else
                    lblRTN.Text = CStr(row("rtn"))
                    'lblcodePriceList.Text = "0"
                    txtcodigoConvenio.Text = ""
                End If
                M_Cliente.lblcodeCategoria.Text = CStr(row("codigoCategoria"))
                M_ClienteVentana.txtnombreCategoria.Text = M_Cliente.txtnombreCategoria.Text
                txtcodigoCliente.BackColor = Color.White
            Catch ex As Exception
                txtcodigoCliente.BackColor = Color.Red
                'txtcodigoCliente.Text = ""
                txtnombreCliente.Text = ""
            End Try
        Else
            lblcodePriceList.Text = "0"
            txtcodigoConvenio.Text = ""
            'txtcodigoCliente.Text = ""
            txtnombreCliente.Text = ""
            txtcodigoCliente.BackColor = Color.White
            M_ClienteVentana.txttelefonoCasa.Text = ""
            M_ClienteVentana.txttelefonoTrabajo.Text = ""
            M_ClienteVentana.txtcelular.Text = ""
            M_ClienteVentana.txtcorreo1.Text = ""
            M_ClienteVentana.txtcorreo2.Text = ""
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        limpiar()
        banderaTipo = True
        'dgblistadoExamenes.Columns(1).ReadOnly = True
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

        dgbObservaciones.Rows.Clear()
        dgbObservaciones2.Rows.Clear()
        dgblistadoExamenes.Rows.Clear()
        M_ClienteVentana.dgvtabla.Rows.Clear()

        lblPromocion.Text = "0"
        lblcodePriceList.Text = ""
        lblFechaNacimiento.Text = ""

        cbxAnular.Checked = False
        cbxok.Checked = False
        txtpagoPaciente.Text() = "0"
        txtvuelto.Text() = "0"
        txttotal.Text() = "0"

        txtTarjeta.Text() = "0"
        txtEfectivo.Text() = "0"
        'Habilitar los campos
        txtcodigoCliente.ReadOnly = False
        txtcodigoMedico.ReadOnly = False
        txtcodigoTerminosPago.ReadOnly = False
        dtpfechaVto.Enabled = True
        txtcodigoConvenio.ReadOnly = True
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
        'txtcodigoCajero.ReadOnly = False

        cbxentregarMedico.Enabled = True
        cbxentregarPaciente.Enabled = True
        cbxenviarCorreo.Enabled = True

        dgblistadoExamenes.ReadOnly = False

        'cbxok.Enabled = True
        If Form1.lblCajero.Text = "Cajero" And Trim(txtnumeroOficial.Text) = "" Then
            cbxok.Enabled = True
        Else
            cbxok.Enabled = False
        End If

        btnActualizar.Enabled = False
        'btncotizacion.Enabled = True
        btnguardar.Enabled = True

        btnbusquedaExamen.Enabled = True

        btnPromocion.Enabled = True
        btnQuitarPromocion.Enabled = True

        'obtener maquina local
        buscarMaquinaLocal()

        'recepcionista
        txtcodigoRecepecionista.Text = Form1.lblUserCod.Text
        txtNombreRecepcionista.Text = Form1.lblMiUser.Text

        'cajero
        txtcodigoCajero.Text = Form1.lblUserCod.Text
        txtNombreCajero.Text = Form1.lblMiUser.Text


        'campos nuevos
        txtDeposito.Text() = "0"
        txtCheque.Text() = "0"
        txtTransferencia.Text() = "0"

        'NO ES DE TIPO CONVENIO
        lblvuelto.Visible = True
        txtvuelto.Visible = True
        lblVuelto2.Visible = False
        txtvuelto2.Visible = False
        txtvuelto2.Text() = "0"
        txtPorcentaje.Text() = "0"
        txtsubtotal.Text() = "0"
        txtsubtotal.Visible = False
        lblSubtotal.Visible = False
        txtPorcentaje.Visible = False
        lblPorcentaje.Visible = False
        txtEfectivo.ReadOnly = False
        txtTarjeta.ReadOnly = False
        txtDeposito.ReadOnly() = False
        txtCheque.ReadOnly() = False
        txtTransferencia.ReadOnly() = False

    End Sub
    Private Sub buscarMaquinaLocal()
        Try
            Dim objMaq As New ClsMaquinasLocales
            With objMaq
                .descripcion_ = System.Environment.MachineName
            End With
            Dim dt As New DataTable
            dt = objMaq.BuscarMaquinasLocalesDesc()
            Dim row As DataRow = dt.Rows(0)
            txtcodigoTerminal.Text = CStr(row("codigo"))
            txtCodigoBreveMaquina.Text = CStr(row("codigoMaquinasLocales"))
            lblcodeSucursal.Text = CStr(row("codigoSucursal"))
        Catch ex As Exception
            txtcodigoSucursal.Text = ""
            txtcodigoTerminal.Text = ""
            MsgBox("No existe la máquina local.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub deshabilitar()
        txtcodigoMedico.ReadOnly = True
        txtcodigoTerminosPago.ReadOnly = True
        dtpfechaVto.Enabled = False
        txtcodigoConvenio.ReadOnly = True
        txtnumeroPoliza.ReadOnly = True

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


        cbxok.Enabled = False

        btnActualizar.Enabled = True
        'btncotizacion.Enabled = False
        btnguardar.Enabled = False

        txtcodigoCliente.ReadOnly = True
        btnbuscarCliente.Enabled = False
        dgblistadoExamenes.ReadOnly = True
        btnbusquedaExamen.Enabled = False

        btnPromocion.Enabled = False
        btnQuitarPromocion.Enabled = False

        txtEfectivo.ReadOnly = True
        txtTarjeta.ReadOnly = True

        '
        txtDeposito.ReadOnly = True
        txtCheque.ReadOnly = True
        txtTransferencia.ReadOnly = True
    End Sub
    Public Sub HabilitarActualizarFactura()
        cbxentregarMedico.Enabled = True
        cbxentregarPaciente.Enabled = True
        cbxenviarCorreo.Enabled = True

        dgblistadoExamenes.ReadOnly = False
        'cbxok.Enabled = True
        If Form1.lblCajero.Text = "Cajero" And Trim(txtnumeroOficial.Text) = "" Then
            cbxok.Enabled = True
        Else
            cbxok.Enabled = False
        End If
        btnbusquedaExamen.Enabled = True

        txtEfectivo.ReadOnly = False
        txtTarjeta.ReadOnly = False


        txtDeposito.ReadOnly = False
        txtCheque.ReadOnly = False
        txtTransferencia.ReadOnly = False
    End Sub
    Public Sub HabilitarCotizacionFactura()
        txtcodigoCliente.ReadOnly = False
        txtcodigoMedico.ReadOnly = True
        dtpfechaFactura.Enabled = True
        txtcodigoTerminosPago.ReadOnly = False
        txtcodigoRecepecionista.ReadOnly = False
        txtcodigoSucursal.ReadOnly = False
        btnbusquedaExamen.Enabled = True
        dgblistadoExamenes.ReadOnly = False
        btnActualizar.Enabled = False
        'btncotizacion.Enabled = True
        btnbuscarSucursal.Enabled = True
        btnbuscarMedico.Enabled = False

        btnguardar.Enabled = True
        btnbuscarCliente.Enabled = True
        btnbuscarTerminosPago.Enabled = True
    End Sub
    Private Sub txtcodigoTerminal_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTerminal.TextChanged
        If (txtcodigoTerminal.Text <> "") Then
            Try
                Dim objMaq As New ClsMaquinasLocales
                With objMaq
                    .codigo_ = txtcodigoTerminal.Text
                End With
                Dim dt As New DataTable
                dt = objMaq.BuscarMaquinasLocalesCode()
                Dim row As DataRow = dt.Rows(0)
                txtcodigoTerminal.Text = CStr(row("codigo"))
                txtCodigoBreveMaquina.Text = CStr(row("codigoMaquinasLocales"))
                lblcodeSucursal.Text = CStr(row("codigoSucursal"))
            Catch ex As Exception
                txtcodigoSucursal.Text = ""
                txtcodigoTerminal.Text = ""
                txtCodigoBreveMaquina.Text = ""
            End Try
        Else
            txtcodigoSucursal.Text = ""
            txtcodigoTerminal.Text = ""
            txtCodigoBreveMaquina.Text = ""
        End If
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
                txtcodigoMedico.BackColor = Color.White
            Catch ex As Exception
                txtcodigoMedico.BackColor = Color.Red
                txtnombreMedico.Text = ""
                'MsgBox("No existe el código del médico.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoMedico.Text = ""
            txtnombreMedico.Text = ""
            txtcodigoMedico.BackColor = Color.White
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
                txtcodigoSede.BackColor = Color.White
            Catch ex As Exception
                txtcodigoSede.BackColor = Color.Red
                txtnombreSede.Text = ""
                ' MsgBox("No existe el código de la sede.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoSede.Text = ""
            txtnombreSede.Text = ""
            txtcodigoSede.BackColor = Color.White
        End If
    End Sub
    Private Sub btnbuscarSede_Click(sender As Object, e As EventArgs) Handles btnbuscarSede.Click
        M_Sede.lblform.Text = "factura"
        M_Sede.Show()
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
                txtcodigoSucursal.BackColor = Color.White
            Catch ex As Exception
                txtcodigoSucursal.BackColor = Color.Red
                txtnombreSucursal.Text = ""
                lblcodeSucursal.Text = ""
            End Try
        Else
            txtcodigoSucursal.Text = ""
            txtnombreSucursal.Text = ""
            lblcodeSucursal.Text = ""
            txtcodigoSucursal.BackColor = Color.White
        End If
    End Sub
    Private Sub btnbuscarSucursal_Click(sender As Object, e As EventArgs) Handles btnbuscarSucursal.Click
        M_Sucursal.lblform.Text = "factura"
        M_Sucursal.Show()
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
                txtcodigoTerminosPago.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTerminosPago.BackColor = Color.Red
                txtdescripcionTermino.Text = ""
                lblcodeTerminoPago.Text = ""
            End Try
        Else
            txtcodigoTerminosPago.Text = ""
            txtdescripcionTermino.Text = ""
            lblcodeTerminoPago.Text = ""
            txtcodigoTerminosPago.BackColor = Color.White
        End If
    End Sub
    Private Sub btnterminosPago_Click(sender As Object, e As EventArgs) Handles btnbuscarTerminosPago.Click
        M_TerminosPago.lblform.Text = "factura"
        M_TerminosPago.Show()
    End Sub
    Private Sub M_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CON TIMER
        'Timer1.Interval = 3000
        'Timer1.Start()
        'MsgBox(My.Computer.Name.ToString)
        Try
            alternarColoFilasDatagridview(dgblistadoExamenes)
            alternarColoFilasDatagridview(dgbObservaciones)
            If (Trim(txtnumeroOficial.Text) <> "") Then
                cbxAnular.Enabled = True
            Else
                cbxAnular.Enabled = False
            End If

            'SIN TIMER
            SegundaPantalla()

            If dgblistadoExamenes.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dgblistadoExamenes.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SegundaPantalla()
        Try
            Dim MiposicionX, MiposicionY As Single

            Dim posicion As Point
            Dim display As New M_ClienteVentana

            For Each scrn As Screen In Screen.AllScreens

                If scrn.Primary = False Then
                    display.Location = posicion
                    display.Width = scrn.WorkingArea.Width
                    display.Height = scrn.WorkingArea.Height

                Else
                    posicion = New Point(scrn.WorkingArea.Width, scrn.Bounds.Y)

                End If

            Next

            MiposicionX = posicion.X
            MiposicionY = posicion.Y
            M_ClienteVentana.Show()
            M_ClienteVentana.Location = New Point(MiposicionX, MiposicionY)
            M_ClienteVentana.WindowState = FormWindowState.Maximized
            M_BuscarFactura.Close()
            Form1.WindowState = FormWindowState.Minimized

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MsgBox("Entra despues de 3 seg")
        M_ClienteVentana.Show()
        If dgblistadoExamenes.Columns.Contains("btnEliminar") = False Then
            Dim btn As New DataGridViewButtonColumn()
            dgblistadoExamenes.Columns.Add(btn)
            btn.HeaderText = "Eliminar"
            btn.Text = "Eliminar"
            btn.Name = "btnEliminar"
            btn.UseColumnTextForButtonValue = True
        End If
        Timer1.Stop()
    End Sub
    Private Sub txtconvenio_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoConvenio.TextChanged
        M_ClienteVentana.txtnombreConvenio.Text = txtcodigoConvenio.Text
        'If Trim(txtcodigoConvenio.Text) = "" Or Trim(txtcodigoConvenio.Text) = "0" Then
        '    'NO ES DE TIPO CONVENIO
        '    txtsubtotal.Visible = False
        '    lblSubtotal.Visible = False
        '    txtPorcentaje.Visible = False
        '    lblPorcentaje.Visible = False
        '    txtPorcentaje.Clear()
        '    txtsubtotal.Clear()
        '    txtEfectivo.Enabled = True
        '    txtTransferencia.Enabled = True
        '    txtTarjeta.Enabled = True
        '    txtCheque.Enabled = True
        '    txtDeposito.Enabled = True
        'Else
        '    'ES TIPO CONVENIO Y SOLICITA PAGO
        '    txtsubtotal.Visible = True
        '    lblSubtotal.Visible = True
        '    txtPorcentaje.Text = ""
        '    txtPorcentaje.Visible = True
        '    lblPorcentaje.Visible = True
        '    txtEfectivo.Enabled = True
        '    txtTransferencia.Enabled = True
        '    txtTarjeta.Enabled = True
        '    txtCheque.Enabled = True
        '    txtDeposito.Enabled = True

        '    'ES TIPO CONVENIO SIN PAGO
        '    txtPorcentaje.Clear()
        '    txtPorcentaje.Visible = False
        '    lblPorcentaje.Visible = False
        '    txtsubtotal.Clear()
        '    txtsubtotal.Visible = False
        '    lblSubtotal.Visible = False
        '    txtEfectivo.Enabled = False
        '    txtTransferencia.Enabled = False
        '    txtTarjeta.Enabled = False
        '    txtCheque.Enabled = False
        '    txtDeposito.Enabled = False
        'End If
    End Sub
    Private Sub txtpagoPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtpagoPaciente.TextChanged
        Try
            M_ClienteVentana.txtpagoPaciente.Text = txtpagoPaciente.Text
            txtvuelto2.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txtsubtotal.Text)
            'txtvuelto.Text = Convert.ToInt64(txtpagoPaciente.Text) - Convert.ToInt64(txttotal.Text)
            'M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtnombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtnombreCliente.TextChanged
        M_ClienteVentana.txtnombreCompleto.Text = txtnombreCliente.Text
    End Sub
    Private Sub txtvuelto_TextChanged(sender As Object, e As EventArgs) Handles txtvuelto.TextChanged
        'If (Convert.ToDouble(txtvuelto.Text) >= 0) Then
        '    txtvuelto.ForeColor = Color.Black
        '    M_ClienteVentana.txtvuelto.ForeColor = Color.Black
        'Else
        '    txtvuelto.ForeColor = Color.Red
        '    M_ClienteVentana.txtvuelto.ForeColor = Color.Red
        'End If
        If Convert.ToDouble(txtvuelto.Text) >= 0 Then
            M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
        Else
            'txtvuelto.Text = "0"
            M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
        End If
    End Sub
    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Try
            M_ClienteVentana.txttotal.Text = txttotal.Text
            Dim subtotal As Double = 0
            txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)

            'ES TIPO CONVENIO
            If Trim(txtcodigoConvenio.Text) <> "" And Trim(txtcodigoConvenio.Text) <> "0" Then
                subtotal = Convert.ToDouble(txttotal.Text) * (Integer.Parse(txtPorcentaje.Text) / 100)
                txtsubtotal.Text = Math.Ceiling(subtotal)
                txtvuelto2.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txtsubtotal.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgblistadoExamenes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgblistadoExamenes.CellClick
        If e.ColumnIndex = 11 And Trim(txtnumeroOficial.Text) = "" Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar el examen de la factura?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    If dgblistadoExamenes.Rows(e.RowIndex).Cells(8).Value() <> "0" Then
                        codigoDetalleFactura.Add(Me.dgblistadoExamenes.Rows(e.RowIndex).Cells(8).Value())
                    End If
                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                    dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
                    dgbObservaciones2.Rows.Remove(dgbObservaciones2.Rows(e.RowIndex.ToString))
                    M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(e.RowIndex.ToString))
                    totalFactura()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Function validarFactura(ByVal codigoExamen As Integer)
        Dim cont As Integer = 0
        For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
            If (dgblistadoExamenes.Rows(index).Cells(0).Value().ToString = codigoExamen) Then
                cont += 1
            End If
            If (cont >= 2) Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Public Function validarFactura2(ByVal codigoExamen As Integer)
        For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
            If (dgblistadoExamenes.Rows(index).Cells(0).Value().ToString = codigoExamen) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    Private Sub dgblistadoExamenes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgblistadoExamenes.CellEndEdit
        If e.ColumnIndex = 0 Then
            'MsgBox("cambia los datos")
            Try
                If (Trim(dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value()) <> "") Then
                    Dim objExam As New ClsPrecio
                    With objExam
                        .codeIntExam_ = dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value()
                        .codigoListaPrecios_ = lblcodePriceList.Text
                    End With

                    Dim dt As New DataTable
                    dt = objExam.BuscarPrecioItemExam()

                    'valido que no haya agregado el examen anteriormente
                    If (validarFactura(objExam.codeIntExam_) = 0) Then
                        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
                        dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                        Dim subtotal As Double = Convert.ToDouble(CStr(row("precio")))
                        Dim descuento As Double = Convert.ToDouble(CStr(row("porcentaje")))
                        descuento = subtotal * (descuento / 100)
                        subtotal -= descuento

                        'buscar feriados
                        Dim dtFeriados As New DataTable
                        Dim cantDias As Integer = 0
                        dtFeriados = objFeriado.BuscarFeriadosRangoFecha(Date.Parse(dtpfechaFactura.Value), Date.Parse(dtpfechaFactura.Value.Date.AddDays(7)))
                        cantDias = dtFeriados.Rows.Count + 7
                        dgblistadoExamenes.Rows.Insert(e.RowIndex.ToString, New String() {objExam.codeIntExam_, "1", CStr(row("precio")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(cantDias), CStr(row("porcentaje")), (subtotal), CStr(row("codigoSubArea")), 0, CStr(row("codigoItem")), CStr(row("id_centrocosto"))})
                        totalFactura()

                        'observaciones
                        dgbObservaciones.Rows.Insert(e.RowIndex.ToString, New String() {objExam.codeIntExam_, ""})
                        dgbObservaciones2.Rows.Insert(e.RowIndex.ToString, New String() {objExam.codeIntExam_, ""})


                        M_ClienteVentana.dgvtabla.Rows.Insert(e.RowIndex.ToString, New String() {objExam.codeIntExam_, "1", CStr(row("precio")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(cantDias), CStr(row("porcentaje")), (subtotal)})
                    Else 'muestro el mensaje de error
                        MsgBox("El examen ya a sido agregado.", MsgBoxStyle.Information)
                        dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))

                        'observaciones
                        'dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
                    End If

                Else
                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))

                    'observaciones
                    dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
                    dgbObservaciones2.Rows.Remove(dgbObservaciones2.Rows(e.RowIndex.ToString))
                End If
            Catch ex As Exception
                MsgBox("No existe el código del examen", MsgBoxStyle.Critical)
                Try
                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))

                    M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(e.RowIndex.ToString))
                    'observaciones
                    dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
                    dgbObservaciones2.Rows.Remove(dgbObservaciones2.Rows(e.RowIndex.ToString))
                Catch ex2 As Exception

                End Try
            End Try
        ElseIf e.ColumnIndex = 1 Then
            Try
                Dim code, cant, codeExam, subArea, detFact, id_centrocosto As Integer
                Dim precio, subtotal, descuento, porcDesc As Double
                Dim descrip As String
                code = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value())
                'datos anteriores
                codeExam = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(9).Value())
                subArea = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(7).Value())
                detFact = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(8).Value())

                cant = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(1).Value())
                precio = Convert.ToDouble(dgblistadoExamenes.Rows(e.RowIndex).Cells(2).Value())
                descrip = dgblistadoExamenes.Rows(e.RowIndex).Cells(3).Value()
                porcDesc = Convert.ToDouble(dgblistadoExamenes.Rows(e.RowIndex).Cells(5).Value())
                id_centrocosto = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(10).Value())
                subtotal = precio * cant
                descuento = subtotal * (porcDesc / 100)
                subtotal -= descuento
                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
                dgblistadoExamenes.Rows.Insert(e.RowIndex.ToString, New String() {code, cant, precio, descrip, Me.dtpfechaFactura.Value.Date.AddDays(7), porcDesc, subtotal, subArea, detFact, codeExam, id_centrocosto})

                M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(e.RowIndex.ToString))
                M_ClienteVentana.dgvtabla.Rows.Insert(e.RowIndex.ToString, New String() {code, cant, precio, descrip, Me.dtpfechaFactura.Value.Date.AddDays(7), porcDesc, subtotal})
                totalFactura()
            Catch ex As Exception
                MsgBox("Debe ingresar la cantidad correcta de examenes.", MsgBoxStyle.Critical)
                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))


                'observaciones
                dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
                dgbObservaciones2.Rows.Remove(dgbObservaciones2.Rows(e.RowIndex.ToString))
            End Try
        End If
    End Sub
    'Private Sub dgblistadoExamenes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgblistadoExamenes.CellEndEdit
    '    If e.ColumnIndex = 0 Then
    '        'MsgBox("cambia los datos")
    '        Try
    '            If (Trim(dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value()) <> "") Then
    '                Dim objExam As New ClsPrecio
    '                With objExam
    '                    .codigoItem_ = dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value()
    '                    .codigoListaPrecios_ = lblcodePriceList.Text
    '                End With

    '                Dim dt As New DataTable
    '                dt = objExam.BuscarPrecio()

    '                'valido que no haya agregado el examen anteriormente
    '                If (validarFactura(objExam.codigoItem_) = 0) Then
    '                    Dim row As DataRow = dt.Rows(0)
    '                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
    '                    Dim subtotal As Double = Convert.ToDouble(CStr(row("precio")))
    '                    Dim descuento As Double = Convert.ToDouble(CStr(row("porcentaje")))
    '                    descuento = subtotal * (descuento / 100)
    '                    subtotal -= descuento
    '                    dgblistadoExamenes.Rows.Insert(e.RowIndex.ToString, New String() {objExam.codigoItem_, "1", CStr(row("precio")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(7), CStr(row("porcentaje")), (subtotal), CStr(row("codigoSubArea")), 0})
    '                    totalFactura()

    '                    'observaciones
    '                    dgbObservaciones.Rows.Insert(e.RowIndex.ToString, New String() {objExam.codigoItem_, ""})


    '                    M_ClienteVentana.dgvtabla.Rows.Add(New String() {objExam.codigoItem_, "1", CStr(row("precio")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(7), CStr(row("porcentaje")), (subtotal)})
    '                Else 'muestro el mensaje de error
    '                    MsgBox("El examen ya a sido agregado.", MsgBoxStyle.Information)
    '                    dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))

    '                    'observaciones
    '                    'dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
    '                End If

    '            Else
    '                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))

    '                'observaciones
    '                dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
    '            End If
    '        Catch ex As Exception
    '            MsgBox("No existe el código del examen", MsgBoxStyle.Critical)
    '            Try
    '                dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))

    '                'observaciones
    '                dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
    '            Catch ex2 As Exception

    '            End Try
    '        End Try
    '    ElseIf e.ColumnIndex = 1 Then
    '        Try
    '            Dim code, cant As Integer
    '            Dim precio, subtotal, descuento, porcDesc As Double
    '            Dim descrip As String
    '            code = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(0).Value())
    '            cant = Convert.ToInt64(dgblistadoExamenes.Rows(e.RowIndex).Cells(1).Value())
    '            precio = Convert.ToDouble(dgblistadoExamenes.Rows(e.RowIndex).Cells(2).Value())
    '            descrip = dgblistadoExamenes.Rows(e.RowIndex).Cells(3).Value()
    '            porcDesc = Convert.ToDouble(dgblistadoExamenes.Rows(e.RowIndex).Cells(5).Value())
    '            subtotal = precio * cant
    '            descuento = subtotal * (porcDesc / 100)
    '            subtotal -= descuento
    '            dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))
    '            dgblistadoExamenes.Rows.Insert(e.RowIndex.ToString, New String() {code, cant, precio, descrip, Me.dtpfechaFactura.Value.Date.AddDays(7), porcDesc, subtotal})

    '            M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(e.RowIndex.ToString))
    '            M_ClienteVentana.dgvtabla.Rows.Add(New String() {code, cant, precio, descrip, Me.dtpfechaFactura.Value.Date.AddDays(7), porcDesc, subtotal})
    '            totalFactura()
    '        Catch ex As Exception
    '            MsgBox("Debe ingresar la cantidad correcta de examenes.", MsgBoxStyle.Critical)
    '            dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(e.RowIndex.ToString))


    '            'observaciones
    '            dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(e.RowIndex.ToString))
    '        End Try
    '    End If
    'End Sub
    Public Sub AgregarExamen(ByVal codigoItem As Integer)
        Try
            Dim objExam As New ClsPrecio
            With objExam
                .codeIntExam_ = codigoItem
                .codigoListaPrecios_ = lblcodePriceList.Text
            End With

            Dim dt As New DataTable
            dt = objExam.BuscarPrecioItemExam()
            Dim row As DataRow = dt.Rows(0)
            Dim subtotal As Double = Convert.ToDouble(CStr(row("precio")))
            Dim descuento As Double = Convert.ToDouble(CStr(row("porcentaje")))

            'calcular descuento
            descuento = subtotal * (descuento / 100)
            subtotal -= descuento

            'buscar feriados
            Dim dtFeriados As New DataTable
            Dim cantDias As Integer = 0
            dtFeriados = objFeriado.BuscarFeriadosRangoFecha(Date.Parse(dtpfechaFactura.Value), Date.Parse(dtpfechaFactura.Value.Date.AddDays(7)))
            cantDias = dtFeriados.Rows.Count + 7


            dgblistadoExamenes.Rows.Add(New String() {objExam.codeIntExam_, "1", CStr(row("precio")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(cantDias), CStr(row("porcentaje")), (subtotal), CStr(row("codigoSubArea")), 0, CStr(row("codigoItem")), CStr(row("id_centrocosto"))})
            dgbObservaciones.Rows.Add(New String() {objExam.codeIntExam_, ""})
            dgbObservaciones2.Rows.Add(New String() {objExam.codeIntExam_, ""})
            totalFactura()
            M_ClienteVentana.dgvtabla.Rows.Add(New String() {objExam.codeIntExam_, "1", CStr(row("precio")), CStr(row("descripcion")), Me.dtpfechaFactura.Value.Date.AddDays(cantDias), CStr(row("porcentaje")), (subtotal)})

        Catch ex As Exception

        End Try
    End Sub
    Public Sub totalFactura()
        Dim total As Double = 0
        For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 1
            total += Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
        Next
        txttotal.Text = Math.Ceiling(total)
    End Sub
    Private Sub btnbusquedaExamen_Click(sender As Object, e As EventArgs) Handles btnbusquedaExamen.Click
        If btnbusquedaExamen.Enabled Then
            M_BuscarExamen.Show()
        End If
    End Sub

    Private Sub calcularSaldoPendiente()
        Try
            If Convert.ToDouble(txtpagoPaciente.Text) > Convert.ToDouble(txttotal.Text) Then
                abonoF = Convert.ToDouble(txttotal.Text)
                saldoF = 0
            ElseIf txtvuelto.Visible = False Then
                abonoF = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txtvuelto2.Text)
                saldoF = Convert.ToDouble(txttotal.Text) - abonoF
            Else
                abonoF = Convert.ToDouble(txtpagoPaciente.Text)
                saldoF = Convert.ToDouble(txttotal.Text) - abonoF
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            If banderaTipo Then

                If Trim(txtcodigoRecepecionista.Text) = "" Then
                    'recepcionista
                    txtcodigoRecepecionista.Text = Form1.lblUserCod.Text
                    txtNombreRecepcionista.Text = Form1.lblMiUser.Text
                End If

                'cajero
                txtcodigoCajero.Text = Form1.lblUserCod.Text
                txtNombreCajero.Text = Form1.lblMiUser.Text

                'maquina local
                buscarMaquinaLocal()

                If Trim(txtnumeroPoliza.Text) = "" Then
                    txtnumeroPoliza.Text = "1"
                End If
                If Trim(txtpagoPaciente.Text) = "" Then
                    txtpagoPaciente.Text = "0"
                End If

                If Trim(txtcodigoTerminal.Text) = "" Then
                    MsgBox("No existe la máquina local.", MsgBoxStyle.Critical, "Validación.")
                    Exit Sub
                End If

                Dim dt As New DataTable
                Dim row As DataRow

                If (txtcodigoCliente.Text <> "" And txtcodigoMedico.Text <> "" And txtcodigoTerminosPago.Text <> "" And
                    txtcodigoSede.Text <> "" And txtcodigoSucursal.Text <> "" And
                    txttotal.Text <> "" And dgblistadoExamenes.Rows.Count > 1) Then

                    If (cbxok.Checked) Then
                        'Si el vuelto es menor a 0 y el cliente no pertenese a un convenio
                        If (Convert.ToDouble(txtvuelto.Text) < 0 And Trim(txtcodigoConvenio.Text) = "0" And txtvuelto.Visible And Trim(txtcodigoTerminosPago.Text) = "CO") Then
                            MsgBox("Debe registrar el pago de los examenes antes de guardar la factura.", MsgBoxStyle.Information)
                            Exit Sub
                        ElseIf (Convert.ToDouble(txtvuelto.Text) < 0 And Trim(txtcodigoConvenio.Text) = "" And txtvuelto.Visible And Trim(txtcodigoTerminosPago.Text) = "CO") Then
                            MsgBox("Debe registrar el pago de los examenes antes de guardar la factura.", MsgBoxStyle.Information)
                            Exit Sub
                        ElseIf (Convert.ToDouble(txtvuelto2.Text) < 0 And Trim(txtcodigoConvenio.Text) <> "" And txtvuelto2.Visible) Then
                            'Si el vuelto es menor a 0  y el cliente pertenese a un convenio con pago
                            MsgBox("Debe registrar el subtotal de la factura antes de guardar la factura.", MsgBoxStyle.Information)
                            Exit Sub
                        End If
                        Dim objCAI As New ClsCAI
                        objCAI.codigoMaquinaLocal_ = txtcodigoTerminal.Text
                        dt = objCAI.BuscarCAI()
                        If dt.Rows.Count >= 1 Then
                            row = dt.Rows(0)
                            txtnumeroOficial.Text = CStr(row("numeroOficial"))

                            Dim objDetCAI As New ClsDetalleCAI
                            objDetCAI.Codigo_ = Convert.ToInt64(CStr(row("codigoDetCAI")))
                            If objDetCAI.ModificarDetalleCAI() <> 1 Then
                                MsgBox("Error en la actualización del detalle del CAI.", MsgBoxStyle.Critical, "Validación.")
                                Exit Sub
                            End If
                        Else
                            MsgBox("No existe un CAI activo.", MsgBoxStyle.Critical, "Validación.")
                            Exit Sub
                        End If

                    End If
                    calcularSaldoPendiente()
                    Dim objFact As New ClsFactura
                    With objFact
                        .numeroOficial_ = txtnumeroOficial.Text
                        .codigoCliente_ = Convert.ToInt64(txtcodigoCliente.Text)
                        .codigoRecepcionista_ = Convert.ToInt64(txtcodigoRecepecionista.Text)
                        .codigoMedico_ = Convert.ToInt64(txtcodigoMedico.Text)
                        .codigoCajero_ = Convert.ToInt64(txtcodigoCajero.Text)
                        .codigoTerminoPago1 = Convert.ToInt64(lblcodeTerminoPago.Text)
                        .codigoSede_ = Convert.ToInt64(txtcodigoSede.Text)
                        .fechaVto_ = dtpfechaVto.Value
                        .codigoSucursal_ = Convert.ToInt64(lblcodeSucursal.Text)

                        If Trim(txtcodigoConvenio.Text) = "" Or Trim(txtcodigoConvenio.Text) = "0" Then
                            .codigoConvenio_ = 0
                        Else
                            .codigoConvenio_ = Convert.ToInt64(lblcodePriceList.Text)
                        End If

                        .numeroPoliza_ = txtnumeroPoliza.Text
                        .codigoTerminal_ = Convert.ToInt64(txtcodigoTerminal.Text)
                        .entregaMedico_ = cbxentregarMedico.Checked
                        .entregaPaciente_ = cbxentregarPaciente.Checked
                        .enviarEmail_ = cbxenviarCorreo.Checked
                        .pagoPaciente_ = Convert.ToDouble(txtpagoPaciente.Text)
                        If txtvuelto.Visible And Convert.ToDouble(txtvuelto.Text) >= 0 Then
                            .vuelto_ = Convert.ToDouble(txtvuelto.Text)
                        ElseIf txtvuelto2.Visible And Convert.ToDouble(txtvuelto2.Text) >= 0 Then
                            .vuelto_ = Convert.ToDouble(txtvuelto2.Text)
                        ElseIf txtvuelto.Visible = False And txtvuelto2.Visible = False Then
                            .vuelto_ = 0
                        ElseIf Convert.ToDouble(txtpagoPaciente.Text) <= Convert.ToDouble(txttotal.Text) Then
                            .vuelto_ = 0
                        End If
                        .total_ = Convert.ToDouble(txttotal.Text)
                        .ok_ = cbxok.Checked
                        .ingresoEfectivo_ = Convert.ToDouble(txtEfectivo.Text)
                        .ingresoTarjeta_ = Convert.ToDouble(txtTarjeta.Text)
                        .estado_ = cbxAnular.Checked
                        .deposito_ = Convert.ToDouble(txtDeposito.Text)
                        .transferencia_ = Convert.ToDouble(txtTransferencia.Text)
                        .cheque_ = Convert.ToDouble(txtCheque.Text)
                        .saldoPendiente_ = saldoF
                    End With

                    If objFact.RegistrarNuevaFactura() = 1 Then
                        deshabilitar()
                        'cbxok.Enabled = True

                        dt = objFact.BuscarFacturaCode()
                        row = dt.Rows(0)

                        txtnumeroFactura.Text = CStr(row("numero"))
                        Dim objDetalleFact As New ClsDetalleFactura
                        For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                            With objDetalleFact
                                .numeroFactura_ = Convert.ToInt64(txtnumeroFactura.Text)
                                .codigoExamen_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(9).Value())
                                .cantidad_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(1).Value())
                                .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                                .descuento_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(5).Value())
                                .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                                .observaciones_ = dgbObservaciones.Rows(index).Cells(1).Value()
                                .observaciones2_ = dgbObservaciones2.Rows(index).Cells(1).Value()
                            End With
                            If objDetalleFact.RegistrarNuevoDetalleFactura() = 0 Then
                                MsgBox("Error al querer insertar el detalle de factura.", MsgBoxStyle.Critical)
                            End If
                        Next
                        MsgBox("Registrada la factura correctamente.", MsgBoxStyle.Information, "Validación.")
                        calcularDescuento2(objDetalleFact)

                        If (cbxAnular.Checked = False And Trim(txtnumeroOficial.Text) <> "") Then
                            MsgBox("Imprimiendo la factura.", MsgBoxStyle.Information, "Validación.")
                            letras = M_Factura.Numalet.ToCardinal(txttotal.Text)
                            Imprimir_Factura()
                            OrdenDeTrabajo()

                            'INSERTAR ASIENTO DE INGRESO
                            InsertarAsiento()
                            ':::::::::::::::::::::::::::

                            colaPacientes()
                        Else
                            HabilitarActualizarFactura()
                        End If


                        'temporal
                        'Dim objDetFact As New ClsDetalleFactura
                        'objDetFact.numeroFactura_ = txtnumeroFactura.Text
                        'dt = objDetFact.BuscarDetalleFactura()
                        'For index As Integer = 0 To dt.Rows.Count - 1
                        '    row = dt.Rows(index)
                        '    dgblistadoExamenes.Rows(index).Cells(8).Value() = CStr(row("numero"))
                        'Next
                    Else
                        MsgBox("Error al querer registrar la factura.", MsgBoxStyle.Critical, "Validación.")
                    End If
                Else
                    MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
                End If
                M_BuscarFactura.seleccionarFacturas()

                '::::::::::::::::::::::::::::::::::::::::::::: INSERTAR BITACORA ::::::::::::::::::::::
                'Dim Bitacora As New ClsBitacora

                'With Bitacora
                '    .usuario_ = txtcodigoCajero.Text
                '    .accion_ = "Creación de Factura."
                '    .fecha_ = dtpfechaFactura.Value()
                '    .registrarBitacora()
                'End With
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

                'PARTIDA CONTABLE





                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


            Else
                AGREGAR_COTIZACION()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub colaPacientes()
        Try
            Dim fechaNacimiento As Date = Date.Parse(lblFechaNacimiento.Text)
            Dim prioridad As Boolean = False

            Dim yr As Integer = DateDiff(DateInterval.Year, fechaNacimiento, Now)

            If (Now.Month < fechaNacimiento.Month) Then
                yr -= 1
            ElseIf (Now.Month = fechaNacimiento.Month And Now.Day < fechaNacimiento.Day) Then
                yr -= 1
            End If
            'si es mayor que 60 años
            If yr >= 60 Then
                prioridad = True
            End If

            Dim colaP As New ClsColaPacientes

            With colaP
                .numeroFactura_ = Integer.Parse(txtnumeroFactura.Text)
                .prioridad_ = prioridad
                .estadoEnCola_ = 0

                If .RegistrarNuevaColaPacientes() Then
                    MsgBox("Ingresado a la cola correctamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("Error al ingresar.", MsgBoxStyle.Critical)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error. Cola: ", ex.Message)
        End Try
    End Sub
    Private Sub txtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTransferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransferencia.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCheque.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTarjeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarjeta.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDeposito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeposito.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
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

    Private Sub AGREGAR_COTIZACION()
        Try

            'cajero
            txtcodigoCajero.Text = Form1.lblUserCod.Text
            txtNombreCajero.Text = Form1.lblMiUser.Text

            If (Trim(txtcodigoCliente.Text) <> "" And Trim(txtcodigoTerminosPago.Text) <> "" And
                Trim(txtcodigoSucursal.Text) <> "" And txttotal.Text <> "" And dgblistadoExamenes.Rows.Count > 1) Then

                Dim objCotiz As New ClsCotizacion
                With objCotiz
                    .codigoCliente_ = Convert.ToInt64(txtcodigoCliente.Text)
                    .codigoRecepcionista_ = Convert.ToInt64(txtcodigoRecepecionista.Text)
                    .codigoCajero_ = Convert.ToInt64(txtcodigoCajero.Text)
                    .codigoTerminoPago_ = Convert.ToInt64(lblcodeTerminoPago.Text)
                    .codigoSucursal_ = Convert.ToInt64(lblcodeSucursal.Text)
                    .total_ = Convert.ToDouble(txttotal.Text)
                End With

                If objCotiz.RegistrarNuevaCotizacion() = 1 Then
                    deshabilitar()
                    btnActualizar.Enabled = False
                    Dim dt As New DataTable
                    dt = objCotiz.BuscarCotizacionCode()
                    Dim row As DataRow = dt.Rows(0)

                    txtnumeroFactura.Text = CStr(row("numero"))
                    btnguardar.Enabled = False
                    'btncotizacion.Enabled = False
                    Dim objCotFact As New ClsCotizacionFactura
                    For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                        With objCotFact
                            .numeroCotizacion_ = Convert.ToInt64(txtnumeroFactura.Text)
                            .codigoExamen_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(9).Value())
                            .cantidad_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(1).Value())
                            .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                            .descuento_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(5).Value())
                            .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                        End With
                        If objCotFact.RegistrarNuevaCotizacionFactura() = 0 Then
                            MsgBox("Error al querer insertar el detalle de la cotización.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrada la cotización correctamente.", MsgBoxStyle.Information)
                    letras = M_Factura.Numalet.ToCardinal(txttotal.Text)

                Else
                    MsgBox("Error al querer registrar la cotización.", MsgBoxStyle.Critical)
                End If
                M_BuscarCotizacion.actualizarCotizacion()
                btnActualizar.Enabled = True
                btnguardar.Enabled = False
                Imprimir_Cotizacion()
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub ACTUALIZAR_COTIZACION()
        Try

            'cajero
            txtcodigoCajero.Text = Form1.lblUserCod.Text
            txtNombreCajero.Text = Form1.lblMiUser.Text

            If (Trim(txtcodigoCliente.Text) <> "" And Trim(txtcodigoTerminosPago.Text) <> "" And
                Trim(txtcodigoSucursal.Text) <> "" And txttotal.Text <> "" And dgblistadoExamenes.Rows.Count > 1) Then
                If Trim(txtcodigoRecepecionista.Text) = "" Then
                    txtcodigoRecepecionista.Text = "1"
                End If
                Dim objCotiz As New ClsCotizacion
                With objCotiz
                    .numero_ = Integer.Parse(txtnumeroFactura.Text)
                    .codigoCliente_ = Convert.ToInt64(txtcodigoCliente.Text)
                    .codigoRecepcionista_ = Convert.ToInt64(txtcodigoRecepecionista.Text)
                    .codigoTerminoPago_ = Convert.ToInt64(lblcodeTerminoPago.Text)
                    .codigoSucursal_ = Convert.ToInt64(lblcodeSucursal.Text)
                    .total_ = Convert.ToDouble(txttotal.Text)
                    .codigoCajero_ = Convert.ToInt64(txtcodigoCajero.Text)
                End With

                If objCotiz.ModificarCotizacion() = 1 Then
                    deshabilitar()
                    btnActualizar.Enabled = True
                    btnguardar.Enabled = False
                    Dim objCotFact As New ClsCotizacionFactura
                    For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                        If dgblistadoExamenes.Rows(index).Cells(8).Value() = 0 Then
                            'agrega
                            With objCotFact
                                .numeroCotizacion_ = Convert.ToInt64(txtnumeroFactura.Text)
                                .codigoExamen_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(9).Value())
                                .cantidad_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(1).Value())
                                .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                                .descuento_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(5).Value())
                                .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                            End With
                            If objCotFact.RegistrarNuevaCotizacionFactura() = 0 Then
                                MsgBox("Error al querer insertar el detalle de la cotización.", MsgBoxStyle.Critical)
                            End If
                        Else
                            'actualiza los detalles de cotizacion
                            With objCotFact
                                .numero_ = Integer.Parse(dgblistadoExamenes.Rows(index).Cells(8).Value())
                                .numeroCotizacion_ = Convert.ToInt64(txtnumeroFactura.Text)
                                .codigoExamen_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(9).Value())
                                .cantidad_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(1).Value())
                                .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                                .descuento_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(5).Value())
                                .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                            End With
                            If objCotFact.ModificarCotizacionFactura() = 0 Then
                                MsgBox("Error al querer actualizar el detalle de la cotización.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next

                    'eliminar detalle cotizacion
                    For index As Integer = 0 To codigoDetalleFactura.Count - 1
                        objCotFact.numero_ = Convert.ToInt64(codigoDetalleFactura(index))
                        If objCotFact.EliminarDetalleCotizacion() <> 1 Then
                            MsgBox("Error al querer modificar el detalle de cotización.", MsgBoxStyle.Critical)
                        End If
                    Next
                    codigoDetalleFactura.Clear()

                    MsgBox("Actualizada la cotización correctamente.", MsgBoxStyle.Information)
                    letras = M_Factura.Numalet.ToCardinal(txttotal.Text)

                Else
                    MsgBox("Error al querer registrar la cotización.", MsgBoxStyle.Critical)
                End If
                M_BuscarCotizacion.actualizarCotizacion()
                Imprimir_Cotizacion()
            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            'BANDERA
            If banderaTipo Then

                'cajero
                txtcodigoCajero.Text = Form1.lblUserCod.Text
                txtNombreCajero.Text = Form1.lblMiUser.Text

                'maquina local
                buscarMaquinaLocal()

                If Trim(txtcodigoTerminal.Text) = "" Then
                    MsgBox("No existe la máquina local.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                Dim dt As New DataTable
                Dim bandera As Integer = 0
                Dim row As DataRow
                Dim objDetFac As New ClsDetalleFactura

                If Trim(txtnumeroOficial.Text) = "" And cbxAnular.Checked = False Then
                    bandera = 1
                Else
                    bandera = 0
                End If

                'si la factura YA existe 
                If (txtpagoPaciente.Text <> "" And Trim(txtnumeroFactura.Text) <> "") Then
                    'si la factura a sido aprobada (OK) y quiere obtener el numero del CAI y no a sido anulada la factura (ANULADA)
                    If (cbxok.Checked And Trim(txtnumeroOficial.Text) = "" And cbxAnular.Checked = False) Then
                        'VALIDACION DE DINERO
                        'Si el vuelto es menor a 0 y el cliente no pertenese a un convenio
                        If (Convert.ToDouble(txtvuelto.Text) < 0 And Trim(txtcodigoConvenio.Text) = "0" And txtvuelto.Visible And Trim(txtcodigoTerminosPago.Text) = "CO") Then
                            MsgBox("Debe registrar el pago de los examenes antes de guardar la factura.", MsgBoxStyle.Information)
                            Exit Sub
                        ElseIf (Convert.ToDouble(txtvuelto.Text) < 0 And Trim(txtcodigoConvenio.Text) = "" And txtvuelto.Visible And Trim(txtcodigoTerminosPago.Text) = "CO") Then
                            MsgBox("Debe registrar el pago de los examenes antes de guardar la factura.", MsgBoxStyle.Information)
                            Exit Sub
                        ElseIf (Convert.ToDouble(txtvuelto2.Text) < 0 And Trim(txtcodigoConvenio.Text) <> "" And txtvuelto2.Visible) Then
                            'Si el vuelto es menor a 0  y el cliente pertenese a un convenio con pago
                            MsgBox("Debe registrar el subtotal de la factura antes de guardar la factura.", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        Dim objCAI As New ClsCAI
                        objCAI.codigoMaquinaLocal_ = txtcodigoTerminal.Text
                        dt = objCAI.BuscarCAI()

                        If dt.Rows.Count >= 1 Then
                            row = dt.Rows(0)
                            txtnumeroOficial.Text = CStr(row("numeroOficial"))

                            Dim objDetCAI As New ClsDetalleCAI
                            objDetCAI.Codigo_ = Convert.ToInt64(CStr(row("codigoDetCAI")))
                            If objDetCAI.ModificarDetalleCAI() <> 1 Then
                                MsgBox("Error en la actualización del detalle del CAI.", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        Else
                            MsgBox("No existe un CAI activo.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If
                    calcularSaldoPendiente()

                    If bandera = 1 Then
                        Dim objFact As New ClsFactura
                        With objFact
                            .numero_ = Convert.ToInt64(txtnumeroFactura.Text)
                            .numeroOficial_ = txtnumeroOficial.Text
                            .entregaMedico_ = cbxentregarMedico.Checked
                            .entregaPaciente_ = cbxentregarPaciente.Checked
                            .enviarEmail_ = cbxenviarCorreo.Checked
                            .ok_ = cbxok.Checked
                            .pagoPaciente_ = Convert.ToDouble(txtpagoPaciente.Text)
                            If txtvuelto.Visible And Convert.ToDouble(txtvuelto.Text) >= 0 Then
                                .vuelto_ = Convert.ToDouble(txtvuelto.Text)
                            ElseIf txtvuelto2.Visible And Convert.ToDouble(txtvuelto2.Text) >= 0 Then
                                .vuelto_ = Convert.ToDouble(txtvuelto2.Text)
                            ElseIf txtvuelto.Visible = False And txtvuelto2.Visible = False Then
                                .vuelto_ = 0
                            ElseIf Convert.ToDouble(txtpagoPaciente.Text) <= Convert.ToDouble(txttotal.Text) Then
                                .vuelto_ = 0
                            End If
                            .ingresoEfectivo_ = Convert.ToDouble(txtEfectivo.Text)
                            .ingresoTarjeta_ = Convert.ToDouble(txtTarjeta.Text)
                            .estado_ = cbxAnular.Checked
                            .total_ = Convert.ToDouble(txttotal.Text)
                            .deposito_ = Convert.ToDouble(txtDeposito.Text)
                            .transferencia_ = Convert.ToDouble(txtTransferencia.Text)
                            .cheque_ = Convert.ToDouble(txtCheque.Text)
                            .codigoCajero_ = Convert.ToInt64(txtcodigoCajero.Text)
                            .codigoTerminal_ = Convert.ToInt64(txtcodigoTerminal.Text)
                            .saldoPendiente_ = saldoF
                        End With
                        'MODIFICO LOS DATOS DE LA FACTURA
                        If objFact.ModificarFactura() = 1 Then

                            'SI LA FACTURA YA TIENE EL (OK) Y NO ESTA ANULADA LA FACTURA (ANULAR)
                            If (cbxAnular.Checked = False) Then
                                For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                                    If dgblistadoExamenes.Rows(index).Cells(8).Value() = 0 Then
                                        'agrega
                                        With objDetFac
                                            .numeroFactura_ = Convert.ToInt64(txtnumeroFactura.Text)
                                            .codigoExamen_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(9).Value())
                                            .cantidad_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(1).Value())
                                            .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                                            .descuento_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(5).Value())
                                            .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                                            .observaciones_ = dgbObservaciones.Rows(index).Cells(1).Value()
                                            .observaciones2_ = dgbObservaciones2.Rows(index).Cells(1).Value()
                                        End With
                                        If objDetFac.RegistrarNuevoDetalleFactura() = 0 Then
                                            MsgBox("Error al querer insertar el detalle de factura.", MsgBoxStyle.Critical)
                                        End If
                                    Else
                                        'actualiza los detalles de factura
                                        With objDetFac
                                            .numero_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(8).Value())
                                            .numeroFactura_ = Convert.ToInt64(txtnumeroFactura.Text)
                                            .codigoExamen_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(9).Value())
                                            .cantidad_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(1).Value())
                                            .fechaEntrega_ = dgblistadoExamenes.Rows(index).Cells(4).Value()
                                            .descuento_ = Convert.ToInt64(dgblistadoExamenes.Rows(index).Cells(5).Value())
                                            .subtotal_ = Convert.ToDouble(dgblistadoExamenes.Rows(index).Cells(6).Value())
                                            .observaciones_ = dgbObservaciones.Rows(index).Cells(1).Value()
                                            .observaciones2_ = dgbObservaciones2.Rows(index).Cells(1).Value()
                                        End With
                                        If objDetFac.ModificarDetalleFactura() = 0 Then
                                            MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                                        End If
                                    End If
                                Next

                                For index As Integer = 0 To codigoDetalleFactura.Count - 1
                                    objDetFac.numero_ = Convert.ToInt64(codigoDetalleFactura(index))
                                    If objDetFac.EliminarDetalleFactura() <> 1 Then
                                        MsgBox("Error al querer modificar el detalle de factura.", MsgBoxStyle.Critical)
                                    End If
                                Next
                                codigoDetalleFactura.Clear()
                            End If
                            deshabilitar()
                            btnActualizar.Enabled = True

                            MsgBox("Actualizada la factura correctamente.", MsgBoxStyle.Information)
                            calcularDescuento2(objDetFac)


                            If (Trim(txtnumeroOficial.Text) <> "" And cbxAnular.Checked = False) Then
                                MsgBox("Imprimiendo la factura.", MsgBoxStyle.Information)
                                letras = M_Factura.Numalet.ToCardinal(txttotal.Text)
                                'calcularDescuento()
                                'Imprimir_Factura()
                                Imprimir_Factura()
                                OrdenDeTrabajo()
                                'INSERTAR ASIENTO DE INGRESO
                                InsertarAsiento()
                                ':::::::::::::::::::::::::::
                                colaPacientes()
                            Else
                                HabilitarActualizarFactura()
                            End If


                        Else
                            MsgBox("Error al querer actualizar la factura.", MsgBoxStyle.Critical)
                        End If

                    Else
                        calcularSaldoPendiente()
                        Dim objFact As New ClsFactura
                        With objFact
                            .numero_ = Convert.ToInt64(txtnumeroFactura.Text)
                            .numeroOficial_ = txtnumeroOficial.Text
                            .entregaMedico_ = cbxentregarMedico.Checked
                            .entregaPaciente_ = cbxentregarPaciente.Checked
                            .enviarEmail_ = cbxenviarCorreo.Checked
                            .ok_ = cbxok.Checked
                            .pagoPaciente_ = Convert.ToDouble(txtpagoPaciente.Text)
                            'If txtvuelto.Visible Then
                            '    .vuelto_ = Convert.ToDouble(txtvuelto.Text)
                            'Else
                            '    .vuelto_ = Convert.ToDouble(txtvuelto2.Text)
                            'End If
                            If txtvuelto.Visible And Convert.ToDouble(txtvuelto.Text) >= 0 Then
                                .vuelto_ = Convert.ToDouble(txtvuelto.Text)
                            ElseIf txtvuelto2.Visible And Convert.ToDouble(txtvuelto2.Text) >= 0 Then
                                .vuelto_ = Convert.ToDouble(txtvuelto2.Text)
                            ElseIf txtvuelto.Visible = False And txtvuelto2.Visible = False Then
                                .vuelto_ = 0
                            ElseIf Convert.ToDouble(txtpagoPaciente.Text) <= Convert.ToDouble(txttotal.Text) Then
                                .vuelto_ = 0
                            End If
                            .ingresoEfectivo_ = Convert.ToDouble(txtEfectivo.Text)
                            .ingresoTarjeta_ = Convert.ToDouble(txtTarjeta.Text)
                            .estado_ = cbxAnular.Checked
                            .total_ = Convert.ToDouble(txttotal.Text)
                            .deposito_ = Convert.ToDouble(txtDeposito.Text)
                            .transferencia_ = Convert.ToDouble(txtTransferencia.Text)
                            .cheque_ = Convert.ToDouble(txtCheque.Text)
                            .codigoCajero_ = Convert.ToInt64(txtcodigoCajero.Text)
                            .codigoTerminal_ = Convert.ToInt64(txtcodigoTerminal.Text)
                            .saldoPendiente_ = saldoF
                        End With
                        'MODIFICO LOS DATOS DE LA FACTURA
                        If objFact.ModificarFactura() = 1 Then
                            deshabilitar()
                            btnActualizar.Enabled = True

                            MsgBox("Actualizada la factura correctamente.", MsgBoxStyle.Information)
                            If (Trim(txtnumeroOficial.Text) <> "" And cbxAnular.Checked = False) Then
                                MsgBox("Imprimiendo la factura.", MsgBoxStyle.Information)
                                letras = M_Factura.Numalet.ToCardinal(txttotal.Text)
                                calcularDescuento()
                                Imprimir_Factura()
                            Else
                                HabilitarActualizarFactura()
                            End If
                        Else
                            MsgBox("Error en la actualización de la factura.", MsgBoxStyle.Critical)
                        End If
                    End If

                Else
                    MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Information, "Validación")
                End If
                M_BuscarFactura.seleccionarFacturas()

            Else
                ACTUALIZAR_COTIZACION()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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
            txtdescripcionTermino.Text = CStr(row("descripcion"))
            M_ClienteVentana.txtnombreTerminos.Text = CStr(row("descripcion"))
            txtcodigoTerminosPago.Text = CStr(row("codigoTerminoPago"))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub lblcodeSucursal_TextChanged(sender As Object, e As EventArgs) Handles lblcodeSucursal.TextChanged
        Try
            Dim objSuc As New ClsSucursal
            With objSuc
                .codigo_ = lblcodeSucursal.Text
            End With
            Dim dt As New DataTable
            dt = objSuc.BuscarSucursalNumero()
            Dim row As DataRow = dt.Rows(0)
            txtnombreSucursal.Text = CStr(row("nombre"))
            txtcodigoSucursal.Text = UCase(CStr(row("codigoSucursal")))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub enviarCorreo()
        'in the shadows of the moon
        If cbxenviarCorreo.Checked Then
            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("username@gmail.com", "password")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                e_mail = New MailMessage()
                'txtfrom.text
                e_mail.From = New MailAddress("ejemplo@hotmail.com")
                'txtto.text
                e_mail.To.Add("para@hotmail.com")
                e_mail.Subject = "Email Sending"
                e_mail.IsBodyHtml = False
                'txtMessage.text
                e_mail.Body = "Funciona el envio por correo."
                Smtp_Server.Send(e_mail)
                MsgBox("Mail Sent")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Imprimir_Factura()
        Try
            If (Trim(txtnumeroOficial.Text) <> "" And cbxAnular.Checked = False) Then
                'le asigno un valor a los parametros del procedimiento almacenado
                Dim objReporte As New M_ImprimirFactura

                objReporte.SetParameterValue("@numero", Convert.ToInt64(txtnumeroFactura.Text))
                objReporte.SetParameterValue("@numeroFactura", Convert.ToInt64(txtnumeroFactura.Text))
                objReporte.SetParameterValue("@fechaNacimiento", Convert.ToDateTime(lblFechaNacimiento.Text))
                objReporte.SetParameterValue("numalet", letras)
                objReporte.SetParameterValue("subtotal", subtotalF)
                objReporte.SetParameterValue("descuento", descuentoF)
                objReporte.SetParameterValue("saldo", saldoF)
                objReporte.SetParameterValue("abono", abonoF)
                objReporte.SetParameterValue("Cajero", txtNombreCajero.Text)
                objReporte.SetParameterValue("Recepcionista", txtNombreRecepcionista.Text)
                If Trim(txtcodigoConvenio.Text) = "" Or Trim(txtcodigoConvenio.Text) = "0" Then
                    'No es convenio
                    objReporte.SetParameterValue("Cliente", txtnombreCliente.Text)
                    objReporte.SetParameterValue("RTN", lblRTN.Text)
                Else
                    'Es convenio
                    objReporte.SetParameterValue("Cliente", txtcodigoConvenio.Text)
                    objReporte.SetParameterValue("RTN", lblRTN.Text)
                End If
                objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                M_ImprimirFacturaReport.CrystalReportViewer1.ReportSource = objReporte
                'M_ImprimirFacturaReport.CrystalReportViewer1.Refresh()
                M_ImprimirFacturaReport.Show()
            Else
                MsgBox("Debe estar creada o guardada la factura para poder imprimirla.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnimprimirComprobante_Click(sender As Object, e As EventArgs) Handles btnimprimirComprobante.Click
        Try
            If (Trim(txtnumeroFactura.Text) <> "" And cbxok.Checked) Then
                'le asigno un valor a los parametros del procedimiento almacenado
                Dim objReporte As New M_CryComprobanteEntrega

                objReporte.SetParameterValue("@numero", Convert.ToInt64(txtnumeroFactura.Text))
                objReporte.SetParameterValue("@numeroFactura", Convert.ToInt64(txtnumeroFactura.Text))
                objReporte.SetParameterValue("@fechaNacimiento", Convert.ToDateTime(lblFechaNacimiento.Text))
                If txtcodigoConvenio.Text <> "0" Then
                    objReporte.SetParameterValue("convenio", txtcodigoConvenio.Text)
                Else
                    objReporte.SetParameterValue("convenio", "")
                End If
                objReporte.SetParameterValue("recepcionista", txtNombreRecepcionista.Text)
                objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                M_ComprobanteEntrega.CrystalReportViewer1.ReportSource = objReporte
                M_ComprobanteEntrega.Show()
            Else
                MsgBox("Debe estar creada o guardada la factura para poder imprimir el comprobante de entrega.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Imprimir_Cotizacion()
        Try
            If (Trim(txtnumeroFactura.Text) <> "") Then
                'le asigno un valor a los parametros del procedimiento almacenado
                Dim objReporte As New M_ImprimirCotizacion
                objReporte.SetParameterValue("@numero", Convert.ToInt64(txtnumeroFactura.Text))
                objReporte.SetParameterValue("@numeroCotizacion", Convert.ToInt64(txtnumeroFactura.Text))
                objReporte.SetParameterValue("@fechaNacimiento", Convert.ToDateTime(lblFechaNacimiento.Text))
                objReporte.SetParameterValue("numalet", letras)
                objReporte.SetParameterValue("cajero", txtNombreCajero.Text)
                objReporte.SetParameterValue("recepcionista", txtNombreRecepcionista.Text)
                objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                M_ImprimirCotizacionForm.CrystalReportViewer1.ReportSource = objReporte
                M_ImprimirCotizacionForm.Show()
            Else
                MsgBox("Debe estar creada o guardada la cotización para poder imprimirla.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Imprimir_TipoDePacientes()
        Try
            'le asigno un valor a los parametros del procedimiento almacenado
            Dim objReporte As New M_CryTiposDePacientes
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            M_ReportTipoDePacientes.CrystalReportViewer1.ReportSource = objReporte
            M_ReportTipoDePacientes.Show()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnPromocion_Click(sender As Object, e As EventArgs) Handles btnPromocion.Click
        M_ListadoPromociones.Show()
    End Sub
    Private Sub btnQuitarPromocion_Click(sender As Object, e As EventArgs) Handles btnQuitarPromocion.Click
        Try
            If (lblPromocion.Text <> "0") Then
                For index As Integer = 0 To dgblistadoExamenes.Rows.Count - 2
                    If dgblistadoExamenes.Rows(index).Cells(6).Value() = "0" Then
                        dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(index))
                        M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(index))
                        'observaciones
                        dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(index))
                        dgbObservaciones2.Rows.Remove(dgbObservaciones2.Rows(index))
                        index -= 1
                    ElseIf dgblistadoExamenes.Rows(index).Cells(0).Value() = lblPromocion.Text Then
                        dgblistadoExamenes.Rows.Remove(dgblistadoExamenes.Rows(index))
                        M_ClienteVentana.dgvtabla.Rows.Remove(M_ClienteVentana.dgvtabla.Rows(index))
                        'observaciones
                        dgbObservaciones.Rows.Remove(dgbObservaciones.Rows(index))
                        dgbObservaciones2.Rows.Remove(dgbObservaciones2.Rows(index))
                        index -= 1
                    ElseIf index >= dgblistadoExamenes.Rows.Count - 2 Then
                        Exit For
                    End If
                Next
                lblPromocion.Text = "0"
                totalFactura()
            Else
                MsgBox("Debe agregar la promoción primero.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtEfectivo_TextChanged(sender As Object, e As EventArgs) Handles txtEfectivo.TextChanged
        Try
            txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text) + Convert.ToDouble(txtDeposito.Text) + Convert.ToDouble(txtCheque.Text) + Convert.ToDouble(txtTransferencia.Text)

            'txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text)
            txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)
            'M_ClienteVentana.txtvuelto.Text = txtvuelto.Text
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub OrdenDeTrabajo()
    '    Dim ds As New DataSet 'Orden de los examenes por grupo o laboratorio
    '    Try
    '        ' Add Table
    '        ds.Tables.Add("ListaExamenes")
    '        ' Add Columns
    '        Dim col As DataColumn
    '        For Each dgvCol As DataGridViewColumn In dgblistadoExamenes.Columns
    '            col = New DataColumn(dgvCol.Name)
    '            ds.Tables("ListaExamenes").Columns.Add(col)
    '        Next
    '        'Add Rows from the datagridview
    '        Dim row As DataRow
    '        Dim colcount As Integer = dgblistadoExamenes.Columns.Count - 1
    '        For i As Integer = 0 To dgblistadoExamenes.Rows.Count - 1
    '            row = ds.Tables("ListaExamenes").Rows.Add
    '            For Each column As DataGridViewColumn In dgblistadoExamenes.Columns
    '                row.Item(column.Index) = dgblistadoExamenes.Rows.Item(i).Cells(column.Index).Value
    '            Next
    '        Next
    '        'Ordenar el data table por grupo
    '        Dim dt As New DataTable 'tabla de los items ordenador por grupo o laboratorio
    '        dt = ds.Tables(0)
    '        dt.DefaultView.Sort = "grupo DESC"
    '        'Dim dv As New DataView
    '        'dv = dt.DefaultView
    '        'dv.Sort = "grupo Desc"


    '        Dim rowC As DataRow 'fila a comparar
    '        Dim rowI As DataRow 'fila item detalle
    '        Dim rowO As DataRow 'fila orden de trabajo

    '        Dim dt2 As New DataTable 'lista el detalle de los items
    '        Dim dtO As New DataTable 'obtiene el codigo de la orden de trabajo

    '        Dim objItemD As New ClsItemExamenDetalle
    '        Dim objOrd As New ClsOrdenDeTrabajo
    '        For i As Integer = 0 To dt.Rows.Count - 2
    '            row = dt.Rows(i)
    '            If CStr(row("grupo")) <> "0" Then

    '                With objOrd
    '                    .cod_factura_ = Convert.ToInt64(txtnumeroFactura.Text)
    '                    .pmFecha_ = dtpfechaFactura.Value
    '                    .pmUsuario_ = txtcodigoCajero.Text
    '                    .npFecha_ = dtpfechaFactura.Value
    '                    .npUsuario_ = txtcodigoCajero.Text
    '                    .cod_grupo_ = Convert.ToInt64(row("grupo"))
    '                    .estado_ = "No Procesado"
    '                    If .RegistrarOrdenDeTrabajo() = 0 Then
    '                        MsgBox("Error al querer insertar la orden de trabajo.", MsgBoxStyle.Critical)
    '                        Exit Sub
    '                    End If
    '                    dtO = .CapturarOrdenDeTrabajo()
    '                End With
    '                rowO = dtO.Rows(0)
    '                For j As Integer = i To dt.Rows.Count - 2
    '                    rowC = dt.Rows(j)
    '                    If row("grupo") = rowC("grupo") Then
    '                        objItemD.codigoItemExamen_ = Convert.ToInt64(rowC("codigo"))
    '                        dt2 = objItemD.BuscarItemExamenDetalle
    '                        For x As Integer = 0 To dt2.Rows.Count - 1
    '                            rowI = dt2.Rows(x)
    '                            Dim objDetOrd As New ClsOrdenTrabajoDetalle
    '                            With objDetOrd
    '                                .cod_orden_trabajo_ = Convert.ToInt64(rowO("cod_orden_trabajo"))
    '                                .cod_item_examen_detalle_ = rowI("codigo")
    '                            End With
    '                            If objDetOrd.RegistrarNuevoDetalleOrdenTrabajo = 0 Then
    '                                MsgBox("Error en la insercion del detalle orden de trabajo.", MsgBoxStyle.Critical)
    '                                Exit Sub
    '                            End If
    '                        Next
    '                    ElseIf dt.Rows.Count = i + 1 Then
    '                        Exit Sub
    '                    Else
    '                        i = j - 1
    '                        Exit For
    '                    End If
    '                Next

    '            End If
    '        Next

    '        'DataGridView1.DataSource = dt
    '        MsgBox("Orden de trabajo registrada con exito.", MsgBoxStyle.Information)
    '    Catch ex As Exception
    '        MsgBox("CRITICAL ERROR : " & ex.Message)
    '    End Try
    'End Sub
    Private Sub OrdenDeTrabajo()
        Dim ds As New DataSet 'Orden de los examenes por grupo o laboratorio
        Try
            ' Add Table
            ds.Tables.Add("ListaExamenes")
            ' Add Columns

            Dim col As DataColumn
            For Each dgvCol As DataGridViewColumn In dgblistadoExamenes.Columns
                col = New DataColumn(dgvCol.Name)
                ds.Tables("ListaExamenes").Columns.Add(col)
            Next

            'Add Rows from the datagridview
            Dim row As DataRow
            Dim colcount As Integer = dgblistadoExamenes.Columns.Count - 1
            For i As Integer = 0 To dgblistadoExamenes.Rows.Count - 1
                row = ds.Tables("ListaExamenes").Rows.Add
                For Each column As DataGridViewColumn In dgblistadoExamenes.Columns
                    row.Item(column.Index) = dgblistadoExamenes.Rows.Item(i).Cells(column.Index).Value
                Next
            Next
            'Ordenar el data table por grupo
            Dim dt As New DataTable 'tabla de los items ordenador por subarea
            dt = ds.Tables(0)
            dt.DefaultView.Sort = "subArea DESC"
            'Dim dv As New DataView
            'dv = dt.DefaultView
            'dv.Sort = "grupo Desc"



            Dim rowC As DataRow 'fila a comparar
            Dim rowI As DataRow 'fila item detalle
            Dim rowO As DataRow 'fila orden de trabajo

            Dim dt2 As New DataTable 'lista el detalle de los items
            Dim dtO As New DataTable 'obtiene el codigo de la orden de trabajo

            Dim objItemD As New ClsItemExamenDetalle
            Dim objOrd As New ClsOrdenDeTrabajo
            For i As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(i)
                'MsgBox(i & " i(ES DISTINTO A 0) row(subArea)=" & CStr(row("subArea")))
                If CStr(row("subArea")) <> "0" Then

                    With objOrd
                        .cod_factura_ = Convert.ToInt64(txtnumeroFactura.Text)
                        .pmFecha_ = dtpfechaFactura.Value
                        .pmUsuario_ = txtcodigoCajero.Text
                        .npFecha_ = dtpfechaFactura.Value
                        .npUsuario_ = txtcodigoCajero.Text
                        .codigoSubArea_ = Convert.ToInt64(row("subArea"))
                        .estado_ = "No Procesado"
                        .entregarPaciente_ = cbxentregarPaciente.Checked
                        .entregarMedico_ = cbxentregarMedico.Checked
                        .enviadaEmail_ = cbxenviarCorreo.Checked
                        .cod_sede_ = Integer.Parse(txtcodigoSede.Text)
                        If .RegistrarOrdenDeTrabajo() = 0 Then
                            MsgBox("Error al querer insertar la orden de trabajo.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                        dtO = .CapturarOrdenDeTrabajo()
                    End With
                    rowO = dtO.Rows(0)
                    For j As Integer = i To dt.Rows.Count - 1
                        rowC = dt.Rows(j)
                        'MsgBox("i=" & i & "  ,dt.Rows.Count=" & dt.Rows.Count & "  ,j=" & j)
                        'MsgBox("row(subArea)=" & CStr(row("subArea")) & "(son iguales) = rowC(subArea)=" & CStr(rowC("subArea")))
                        If row("subArea") = rowC("subArea") Then
                            'MsgBox(Convert.ToInt64(rowC("codeItemExam")))
                            objItemD.codigoItemExamen_ = Convert.ToInt64(rowC("codeItemExam"))
                            dt2 = objItemD.BuscarItemExamenDetalle
                            For x As Integer = 0 To dt2.Rows.Count - 1
                                rowI = dt2.Rows(x)
                                Dim objDetOrd As New ClsOrdenTrabajoDetalle
                                With objDetOrd
                                    .cod_orden_trabajo_ = Convert.ToInt64(rowO("cod_orden_trabajo"))
                                    .cod_item_examen_detalle_ = rowI("codigo")
                                    .estado_ = "No Ingresado"
                                End With
                                If objDetOrd.RegistrarNuevoDetalleOrdenTrabajo = 0 Then
                                    MsgBox("Error en la insercion del detalle orden de trabajo.", MsgBoxStyle.Critical)
                                    Exit Sub
                                End If
                            Next
                            'Si la cantidad es mayor que 1
                            If (Convert.ToInt64(rowC("Cantidad")) > 1) Then
                                CantidadMayorQueUno(Convert.ToInt64(rowC("Cantidad")), Convert.ToInt64(rowC("subArea")), Convert.ToInt64(rowC("codeItemExam")))
                            End If
                            'si inserto el ultimo item 
                            If j = dt.Rows.Count - 2 Then
                                MsgBox("Orden de trabajo registrada con éxito.", MsgBoxStyle.Information)
                                Exit Sub
                            End If

                        Else
                            i = j - 1
                            Exit For
                        End If
                    Next

                End If
            Next

            'DataGridView1.DataSource = dt
            'MsgBox("Orden de trabajo registrada con éxito.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("CRITICAL ERROR : " & ex.Message)
        End Try
    End Sub

    Private Sub CantidadMayorQueUno(ByVal cantidad As Integer, ByVal codigoSubArea As Integer, ByVal codItemExa As Integer)

        Try

            Dim rowI As DataRow 'fila item detalle
            Dim rowO As DataRow 'fila orden de trabajo

            Dim dt2 As New DataTable 'lista el detalle de los items
            Dim dtO As New DataTable 'obtiene el codigo de la orden de trabajo

            Dim objItemD As New ClsItemExamenDetalle
            Dim objOrd As New ClsOrdenDeTrabajo

            'Dim codOrdenTrabajo As Integer = 0

            For index = 1 To cantidad - 1

                With objOrd
                    .cod_factura_ = Convert.ToInt64(txtnumeroFactura.Text)
                    .pmFecha_ = dtpfechaFactura.Value
                    .pmUsuario_ = txtcodigoCajero.Text
                    .npFecha_ = dtpfechaFactura.Value
                    .npUsuario_ = txtcodigoCajero.Text
                    .codigoSubArea_ = codigoSubArea
                    .estado_ = "No Procesado"
                    .entregarPaciente_ = cbxentregarPaciente.Checked
                    .entregarMedico_ = cbxentregarMedico.Checked
                    .enviadaEmail_ = cbxenviarCorreo.Checked
                    .cod_sede_ = Integer.Parse(txtcodigoSede.Text)
                    If .RegistrarOrdenDeTrabajo() = 0 Then
                        MsgBox("Error al querer insertar la orden de trabajo.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    'codOrdenTrabajo = .RegistrarOrdenDeTrabajo2()
                    dtO = .CapturarOrdenDeTrabajo()
                End With
                rowO = dtO.Rows(0)
                objItemD.codigoItemExamen_ = codItemExa
                dt2 = objItemD.BuscarItemExamenDetalle
                For x As Integer = 0 To dt2.Rows.Count - 1
                    rowI = dt2.Rows(x)
                    Dim objDetOrd As New ClsOrdenTrabajoDetalle
                    With objDetOrd
                        .cod_orden_trabajo_ = Convert.ToInt64(rowO("cod_orden_trabajo"))
                        .cod_item_examen_detalle_ = rowI("codigo")
                        .estado_ = "No Ingresado"
                    End With
                    If objDetOrd.RegistrarNuevoDetalleOrdenTrabajo = 0 Then
                        MsgBox("Error en la insercion del detalle orden de trabajo.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ejemplo()
        'Creating DataTable.
        Dim dt As New DataTable()
        MsgBox("Empieza el ejemplo")
        'Adding the Columns.
        For Each column As DataGridViewColumn In dgblistadoExamenes.Columns
            dt.Columns.Add(column.HeaderText, column.ValueType)
        Next
        MsgBox("agrego las columnas y luego empieza el for de las filas.")
        'Adding the Rows.

        For Each row As DataGridViewRow In dgblistadoExamenes.Rows
            dt.Rows.Add()
            For Each cell As DataGridViewCell In row.Cells
                dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
            Next
        Next
        dt.DefaultView.Sort = "grupo Desc"
        MsgBox("\\\\\\\\FINALIZA EL EJEMPLO\\\\\\\\\\\")
        dgblistadoExamenes.DataSource = dt
    End Sub

    Private Sub txtnumeroOficial_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroOficial.TextChanged
        'Habilitar la opcion de anular la factura
        If (Trim(txtnumeroOficial.Text) <> "") Then
            cbxAnular.Enabled = True
        Else
            cbxAnular.Enabled = False
        End If

        'Habilitar el check box ok
        'If lblOKAY.Text = "Cajero" And Trim(txtnumeroOficial.Text) = "" Then
        '    cbxok.Enabled = True
        'Else
        '    cbxok.Enabled = False
        'End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If banderaTipo Then
                If Trim(txtnumeroOficial.Text) <> "" And cbxAnular.Checked = False Then
                    MsgBox("Imprimiendo la factura.", MsgBoxStyle.Information)
                    letras = M_Factura.Numalet.ToCardinal(txttotal.Text)
                    calcularDescuento()
                    Imprimir_Factura()
                Else
                    MsgBox("Debe tener el número oficial de la factura y no ser anulada o cancelada.", MsgBoxStyle.Information)
                End If
            Else
                If Trim(txtnumeroFactura.Text) <> "" Then
                    letras = M_Factura.Numalet.ToCardinal(txttotal.Text)
                    Imprimir_Cotizacion()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTarjeta_TextChanged(sender As Object, e As EventArgs) Handles txtTarjeta.TextChanged
        Try
            txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text) + Convert.ToDouble(txtDeposito.Text) + Convert.ToDouble(txtCheque.Text) + Convert.ToDouble(txtTransferencia.Text)
            txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)
            'txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text)
            'txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BuscarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If btnbusquedaExamen.Enabled Then
            M_BuscarExamen.Show()
        End If
    End Sub

    Private Sub txtDeposito_TextChanged(sender As Object, e As EventArgs) Handles txtDeposito.TextChanged
        Try
            txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text) + Convert.ToDouble(txtDeposito.Text) + Convert.ToDouble(txtCheque.Text) + Convert.ToDouble(txtTransferencia.Text)
            txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtTransferencia_TextChanged(sender As Object, e As EventArgs) Handles txtTransferencia.TextChanged
        Try
            txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text) + Convert.ToDouble(txtDeposito.Text) + Convert.ToDouble(txtCheque.Text) + Convert.ToDouble(txtTransferencia.Text)
            txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCheque_TextChanged(sender As Object, e As EventArgs) Handles txtCheque.TextChanged
        Try
            txtpagoPaciente.Text = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text) + Convert.ToDouble(txtDeposito.Text) + Convert.ToDouble(txtCheque.Text) + Convert.ToDouble(txtTransferencia.Text)
            txtvuelto.Text = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txttotal.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtcodigoRecepecionista_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoRecepecionista.TextChanged
        If (txtcodigoRecepecionista.Text <> "") Then
            Try
                Dim objUser As New ClsUsuario
                With objUser
                    .Cod = Integer.Parse(txtcodigoRecepecionista.Text)
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtNombreRecepcionista.Text = CStr(row("usuario"))
            Catch ex As Exception
                'MsgBox("No existe el código del médico.", MsgBoxStyle.Critical, "Validación")
            End Try
        End If
    End Sub

    Private Sub txtcodigoCajero_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCajero.TextChanged
        If (txtcodigoCajero.Text <> "") Then
            Try
                Dim objUser As New ClsUsuario
                With objUser
                    .Cod = Integer.Parse(txtcodigoCajero.Text)
                End With
                Dim dt As New DataTable
                dt = objUser.BuscarPorCod_Usuario()
                Dim row As DataRow = dt.Rows(0)
                txtNombreCajero.Text = CStr(row("usuario"))
            Catch ex As Exception
                'MsgBox("No existe el código del médico.", MsgBoxStyle.Critical, "Validación")
            End Try
        End If
    End Sub

    Private Sub btnNuevaCotizacion_Click(sender As Object, e As EventArgs) Handles btnNuevaCotizacion.Click
        limpiar()
        deshabilitar()
        btnPromocion.Enabled = False
        txtnumeroPoliza.ReadOnly = True
        btnbuscarMedico.Enabled = False
        txtcodigoMedico.ReadOnly = True
        btnbuscarSede.Enabled = False
        txtcodigoSede.ReadOnly = True
        btnQuitarPromocion.Enabled = False
        banderaTipo = False

        btnguardar.Enabled = True

        txtcodigoCliente.ReadOnly = False
        btnbuscarCliente.Enabled = True
        dgblistadoExamenes.ReadOnly = False
        btnbusquedaExamen.Enabled = True

        dgblistadoExamenes.Columns(1).ReadOnly = False
    End Sub

    Private Sub cbxenviarCorreo_CheckedChanged(sender As Object, e As EventArgs) Handles cbxenviarCorreo.CheckedChanged
        If Trim(M_ClienteVentana.txtcorreo1.Text) = "" And Trim(M_ClienteVentana.txtcorreo2.Text) = "" And cbxenviarCorreo.Checked Then
            MsgBox("Debe ingresar el correo del cliente o paciente para entregar los resultado por correo electrónico.", MsgBoxStyle.Information, "Validación.")
            cbxenviarCorreo.Checked = False
        End If
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If btnbusquedaExamen.Enabled Then
            M_BuscarExamen.Show()
        End If
    End Sub



    Private Sub calcularDescuento()
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            Dim objDetFact As New ClsDetalleFactura
            objDetFact.numeroFactura_ = txtnumeroFactura.Text
            dt = objDetFact.BuscarDetalleFactura()

            subtotalF = 0
            descuentoF = 0
            abonoF = 0
            saldoF = 0

            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                subtotalF += Convert.ToDouble(row("precio"))
            Next

            subtotalF = Math.Ceiling(subtotalF)
            descuentoF = Math.Ceiling(subtotalF - Convert.ToDouble(txttotal.Text))

            If Convert.ToDouble(txtpagoPaciente.Text) > Convert.ToDouble(txttotal.Text) Then
                abonoF = Convert.ToDouble(txttotal.Text)
                saldoF = 0
            ElseIf txtvuelto.Visible = False Then
                abonoF = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txtvuelto2.Text)
                saldoF = Math.Ceiling(Convert.ToDouble(txttotal.Text) - abonoF)
            Else
                abonoF = Convert.ToDouble(txtpagoPaciente.Text)
                saldoF = Math.Ceiling(Convert.ToDouble(txttotal.Text) - abonoF)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub calcularDescuento2(ByRef objDetFact As ClsDetalleFactura)
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            'Dim objDetFact As New ClsDetalleFactura
            objDetFact.numeroFactura_ = txtnumeroFactura.Text
            dt = objDetFact.BuscarDetalleFactura()

            subtotalF = 0
            descuentoF = 0
            abonoF = 0
            saldoF = 0

            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                subtotalF += Convert.ToDouble(row("precio"))
                dgblistadoExamenes.Rows(index).Cells(8).Value() = CStr(row("numero"))
            Next

            subtotalF = Math.Ceiling(subtotalF)
            descuentoF = Math.Ceiling(subtotalF - Convert.ToDouble(txttotal.Text))

            If Convert.ToDouble(txtpagoPaciente.Text) > Convert.ToDouble(txttotal.Text) Then
                abonoF = Convert.ToDouble(txttotal.Text)
                saldoF = 0
            ElseIf txtvuelto.Visible = False Then
                abonoF = Convert.ToDouble(txtpagoPaciente.Text) - Convert.ToDouble(txtvuelto2.Text)
                saldoF = Math.Ceiling(Convert.ToDouble(txttotal.Text) - abonoF)
            Else
                abonoF = Convert.ToDouble(txtpagoPaciente.Text)
                saldoF = Math.Ceiling(Convert.ToDouble(txttotal.Text) - abonoF)
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Convertir numeros a letras para impresión de cheque
    Public NotInheritable Class Numalet

#Region "Miembros estáticos"

        Private Const UNI As Integer = 0, DIECI As Integer = 1, DECENA As Integer = 2, CENTENA As Integer = 3
        Private Shared _matriz As String(,) = New String(CENTENA, 9) {
            {Nothing, " UNO", " DOS", " TRES", " CUATRO", " CINCO", " SEIS", " SIETE", " OCHO", " NUEVE"},
            {" DIEZ", " ONCE", " DOCE", " TRECE", " CATORCE", " QUINCE", " DIECISEIS", " DIECISIETE", " DIECIOCHO", " DIECINUEVE"},
            {Nothing, Nothing, Nothing, " TREINTA", " CUARENTA", " CONCUENTA", " SESENTA", " SETENTA", " OCHENTA", " NOVENTA"},
            {Nothing, Nothing, Nothing, Nothing, Nothing, " QUINIENTOS", Nothing, " SETECIENTOS", Nothing, " NOVECIENTOS"}}
        Private Const [sub] As Char = CChar(ChrW(26))
        'Cambiar acá si se quiere otro comportamiento en los métodos de clase
        Public Const SeparadorDecimalSalidaDefault As String = "LEMPIRAS CON "
        Public Const MascaraSalidaDecimalDefault As String = "00' CENTAVOS.'"
        Public Const DecimalesDefault As Int32 = 2
        Public Const LetraCapitalDefault As Boolean = False
        Public Const ConvertirDecimalesDefault As Boolean = False
        Public Const ApocoparUnoParteEnteraDefault As Boolean = False
        Public Const ApocoparUnoParteDecimalDefault As Boolean = False

#End Region

#Region "Propiedades"

        Private _decimales As Int32 = DecimalesDefault
        Private _cultureInfo As CultureInfo = Globalization.CultureInfo.CurrentCulture
        Private _separadorDecimalSalida As String = SeparadorDecimalSalidaDefault
        Private _posiciones As Int32 = DecimalesDefault
        Private _mascaraSalidaDecimal As String, _mascaraSalidaDecimalInterna As String = MascaraSalidaDecimalDefault
        Private _esMascaraNumerica As Boolean = True
        Private _letraCapital As Boolean = LetraCapitalDefault
        Private _convertirDecimales As Boolean = ConvertirDecimalesDefault
        Private _apocoparUnoParteEntera As Boolean = False
        Private _apocoparUnoParteDecimal As Boolean

        ''' <summary>
        ''' Indica la cantidad de decimales que se pasarán a entero para la conversión
        ''' </summary>
        ''' <remarks>Esta propiedad cambia al cambiar MascaraDecimal por un valor que empieze con '0'</remarks>
        Public Property Decimales() As Int32
            Get
                Return _decimales
            End Get
            Set(ByVal value As Int32)
                If value > 10 Then
                    Throw New ArgumentException(value.ToString() + " excede el número máximo de decimales admitidos, solo se admiten hasta 10.")
                End If
                _decimales = value
            End Set
        End Property

        ''' <summary>
        ''' Objeto CultureInfo utilizado para convertir las cadenas de entrada en números
        ''' </summary>
        Public Property CultureInfo() As CultureInfo
            Get
                Return _cultureInfo
            End Get
            Set(ByVal value As CultureInfo)
                _cultureInfo = value
            End Set
        End Property

        ''' <summary>
        ''' Indica la cadena a intercalar entre la parte entera y la decimal del número
        ''' </summary>
        Public Property SeparadorDecimalSalida() As String
            Get
                Return _separadorDecimalSalida
            End Get
            Set(ByVal value As String)
                _separadorDecimalSalida = value
                'Si el separador decimal es compuesto, infiero que estoy cuantificando algo,
                'por lo que apocopo el "uno" convirtiéndolo en "un"
                If value.Trim().IndexOf(" ") > 0 Then
                    _apocoparUnoParteEntera = True
                Else
                    _apocoparUnoParteEntera = False
                End If
            End Set
        End Property

        ''' <summary>
        ''' Indica el formato que se le dara a la parte decimal del número
        ''' </summary>
        Public Property MascaraSalidaDecimal() As String
            Get
                If Not [String].IsNullOrEmpty(_mascaraSalidaDecimal) Then
                    Return _mascaraSalidaDecimal
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                'determino la cantidad de cifras a redondear a partir de la cantidad de '0' o ''
                'que haya al principio de la cadena, y también si es una máscara numérica
                Dim i As Integer = 0
                While i < value.Length AndAlso (value(i) = "0"c OrElse value(i) = "#")
                    i += 1
                End While
                _posiciones = i
                If i > 0 Then
                    _decimales = i
                    _esMascaraNumerica = True
                Else
                    _esMascaraNumerica = False
                End If
                _mascaraSalidaDecimal = value
                If _esMascaraNumerica Then
                    _mascaraSalidaDecimalInterna = value.Substring(0, _posiciones) + "'" + value.Substring(_posiciones).Replace("''", [sub].ToString()).Replace("'", [String].Empty).Replace([sub].ToString(), "'") + "'"
                Else
                    _mascaraSalidaDecimalInterna = value.Replace("''", [sub].ToString()).Replace("'", [String].Empty).Replace([sub].ToString(), "'")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Indica si la primera letra del resultado debe estár en mayúscula
        ''' </summary>
        Public Property LetraCapital() As Boolean
            Get
                Return _letraCapital
            End Get
            Set(ByVal value As Boolean)
                _letraCapital = value
            End Set
        End Property

        ''' <summary>
        ''' Indica si se deben convertir los decimales a su expresión nominal
        ''' </summary>
        Public Property ConvertirDecimales() As Boolean
            Get
                Return _convertirDecimales
            End Get
            Set(ByVal value As Boolean)
                _convertirDecimales = value
                _apocoparUnoParteDecimal = value
                If value Then
                    ' Si la máscara es la default, la borro
                    If _mascaraSalidaDecimal = MascaraSalidaDecimalDefault Then
                        MascaraSalidaDecimal = ""
                    End If
                ElseIf [String].IsNullOrEmpty(_mascaraSalidaDecimal) Then
                    MascaraSalidaDecimal = MascaraSalidaDecimalDefault
                    'Si no hay máscara dejo la default
                End If
            End Set
        End Property

        ''' <summary>
        ''' Indica si de debe cambiar "uno" por "un" en las unidades.
        ''' </summary>
        Public Property ApocoparUnoParteEntera() As Boolean
            Get
                Return _apocoparUnoParteEntera
            End Get
            Set(ByVal value As Boolean)
                _apocoparUnoParteEntera = value
            End Set
        End Property

        ''' <summary>
        ''' Determina si se debe apococopar el "uno" en la parte decimal
        ''' </summary>
        ''' <remarks>El valor de esta propiedad cambia al setear ConvertirDecimales</remarks>
        Public Property ApocoparUnoParteDecimal() As Boolean
            Get
                Return _apocoparUnoParteDecimal
            End Get
            Set(ByVal value As Boolean)
                _apocoparUnoParteDecimal = value
            End Set
        End Property

#End Region

#Region "Constructores"

        Public Sub New()
            MascaraSalidaDecimal = MascaraSalidaDecimalDefault
            SeparadorDecimalSalida = SeparadorDecimalSalidaDefault
            LetraCapital = LetraCapitalDefault
            ConvertirDecimales = _convertirDecimales
        End Sub

        Public Sub New(ByVal ConvertirDecimales As Boolean, ByVal MascaraSalidaDecimal As String, ByVal SeparadorDecimalSalida As String, ByVal LetraCapital As Boolean)
            If Not [String].IsNullOrEmpty(MascaraSalidaDecimal) Then
                Me.MascaraSalidaDecimal = MascaraSalidaDecimal
            End If
            If Not [String].IsNullOrEmpty(SeparadorDecimalSalida) Then
                _separadorDecimalSalida = SeparadorDecimalSalida
            End If
            _letraCapital = LetraCapital
            _convertirDecimales = ConvertirDecimales
        End Sub

#End Region

#Region "Conversores de instancia"

        Public Function ToCustomCardinal(ByVal Numero As Double) As String
            Return Convertir(Convert.ToDecimal(Numero), _decimales, _separadorDecimalSalida, _mascaraSalidaDecimalInterna, _esMascaraNumerica, _letraCapital,
            _convertirDecimales, _apocoparUnoParteEntera, _apocoparUnoParteDecimal)
        End Function

        Public Function ToCustomCardinal(ByVal Numero As String) As String
            Dim dNumero As Double
            If [Double].TryParse(Numero, NumberStyles.Float, _cultureInfo, dNumero) Then
                Return ToCustomCardinal(dNumero)
            Else
                Throw New ArgumentException("'" + Numero + "' no es un número válido.")
            End If
        End Function

        Public Function ToCustomCardinal(ByVal Numero As Decimal) As String
            Return ToCardinal(Numero)
        End Function

        Public Function ToCustomCardinal(ByVal Numero As Int32) As String
            Return Convertir(Convert.ToDecimal(Numero), 0, _separadorDecimalSalida, _mascaraSalidaDecimalInterna, _esMascaraNumerica, _letraCapital,
            _convertirDecimales, _apocoparUnoParteEntera, False)
        End Function

#End Region

#Region "Conversores estáticos"

        Public Shared Function ToCardinal(ByVal Numero As Int32) As String
            Return Convertir(Convert.ToDecimal(Numero), 0, Nothing, Nothing, True, LetraCapitalDefault,
            ConvertirDecimalesDefault, ApocoparUnoParteEnteraDefault, ApocoparUnoParteDecimalDefault)
        End Function

        Public Shared Function ToCardinal(ByVal Numero As Double) As String
            Return Convertir(Convert.ToDecimal(Numero), DecimalesDefault, SeparadorDecimalSalidaDefault, MascaraSalidaDecimalDefault, True, LetraCapitalDefault,
            ConvertirDecimalesDefault, ApocoparUnoParteEnteraDefault, ApocoparUnoParteDecimalDefault)
        End Function

        Public Shared Function ToCardinal(ByVal Numero As String, ByVal ReferenciaCultural As CultureInfo) As String
            Dim dNumero As Double
            If [Double].TryParse(Numero, NumberStyles.Float, ReferenciaCultural, dNumero) Then
                Return ToCardinal(dNumero)
            Else
                Throw New ArgumentException("'" + Numero + "' no es un número válido.")
            End If
        End Function

        Public Shared Function ToCardinal(ByVal Numero As String) As String
            Return Numalet.ToCardinal(Numero, CultureInfo.CurrentCulture)
        End Function

        Public Shared Function ToCardinal(ByVal Numero As Decimal) As String
            Return ToCardinal(Convert.ToDouble(Numero))
        End Function

#End Region

        Private Shared Function Convertir(ByVal Numero As Decimal, ByVal Decimales As Int32, ByVal SeparadorDecimalSalida As String, ByVal MascaraSalidaDecimal As String, ByVal EsMascaraNumerica As Boolean, ByVal LetraCapital As Boolean,
        ByVal ConvertirDecimales As Boolean, ByVal ApocoparUnoParteEntera As Boolean, ByVal ApocoparUnoParteDecimal As Boolean) As String
            Dim Num As Int64
            Dim terna As Int32, centenaTerna As Int32, decenaTerna As Int32, unidadTerna As Int32, iTerna As Int32
            Dim cadTerna As String
            Dim Resultado As New StringBuilder()

            Num = Math.Floor(Math.Abs(Numero))

            If Num >= 1000000000001 OrElse Num < 0 Then
                Throw New ArgumentException("El número '" + Numero.ToString() + "' excedió los límites del conversor: [0;1.000.000.000.001]")
            End If
            If Num = 0 Then
                Resultado.Append(" CERO")
            Else
                iTerna = 0

                Do Until Num = 0

                    iTerna += 1
                    cadTerna = String.Empty
                    terna = Num Mod 1000

                    centenaTerna = Int(terna / 100)
                    decenaTerna = terna - centenaTerna * 100 'Decena junto con la unidad
                    unidadTerna = (decenaTerna - Math.Floor(decenaTerna / 10) * 10)

                    Select Case decenaTerna
                        Case 1 To 9
                            cadTerna = _matriz(UNI, unidadTerna) + cadTerna
                        Case 10 To 19
                            cadTerna = cadTerna + _matriz(DIECI, unidadTerna)
                        Case 20
                            cadTerna = cadTerna + " VEINTE"
                        Case 21 To 29
                            cadTerna = " VEINTI" + _matriz(UNI, unidadTerna).Substring(1)
                        Case 30 To 99
                            If unidadTerna <> 0 Then
                                cadTerna = _matriz(DECENA, Int(decenaTerna / 10)) + " Y" + _matriz(UNI, unidadTerna) + cadTerna
                            Else
                                cadTerna += _matriz(DECENA, Int(decenaTerna / 10))
                            End If
                    End Select

                    Select Case centenaTerna
                        Case 1
                            If decenaTerna > 0 Then
                                cadTerna = " CIENTO" + cadTerna
                            Else
                                cadTerna = " CIEN" + cadTerna
                            End If
                            Exit Select
                        Case 5, 7, 9
                            cadTerna = _matriz(CENTENA, Int(terna / 100)) + cadTerna
                            Exit Select
                        Case Else
                            If Int(terna / 100) > 1 Then
                                cadTerna = _matriz(UNI, Int(terna / 100)) + "CIENTOS" + cadTerna
                            End If
                            Exit Select
                    End Select
                    'Reemplazo el 'uno' por 'un' si no es en las únidades o si se solicító apocopar
                    If (iTerna > 1 OrElse ApocoparUnoParteEntera) AndAlso decenaTerna = 21 Then
                        cadTerna = cadTerna.Replace("VEINTIUNO", "VEINTIUN")
                    ElseIf (iTerna > 1 OrElse ApocoparUnoParteEntera) AndAlso unidadTerna = 1 AndAlso decenaTerna <> 11 Then
                        cadTerna = cadTerna.Substring(0, cadTerna.Length - 1)
                        'Acentúo 'veintidós', 'veintitrés' y 'veintiséis'
                    ElseIf decenaTerna = 22 Then
                        cadTerna = cadTerna.Replace("VEINTIDOS", "VEINTIDOS")
                    ElseIf decenaTerna = 23 Then
                        cadTerna = cadTerna.Replace("VEINTITRES", "VEINTITRES")
                    ElseIf decenaTerna = 26 Then
                        cadTerna = cadTerna.Replace("VEINTISEIS", "VEINTISEIS")
                    End If

                    'Completo miles y millones
                    Select Case iTerna
                        Case 3
                            If Numero < 2000000 Then
                                cadTerna += " MILLON"
                            Else
                                cadTerna += " MILLONES"
                            End If
                        Case 2, 4
                            If terna > 0 Then cadTerna += " MIL"
                    End Select
                    Resultado.Insert(0, cadTerna)
                    Num = Int(Num / 1000)
                Loop
            End If

            'Se agregan los decimales si corresponde
            If Decimales > 0 Then
                Resultado.Append(" " + SeparadorDecimalSalida + " ")
                Dim EnteroDecimal As Int32 = Int(Math.Round((Numero - Int(Numero)) * Math.Pow(10, Decimales)))
                If ConvertirDecimales Then
                    Dim esMascaraDecimalDefault As Boolean = MascaraSalidaDecimal = MascaraSalidaDecimalDefault
                    Resultado.Append(Convertir(Convert.ToDecimal(EnteroDecimal), 0, Nothing, Nothing, EsMascaraNumerica, False,
                    False, (ApocoparUnoParteDecimal AndAlso Not EsMascaraNumerica), False) + " " + (IIf(EsMascaraNumerica, "", MascaraSalidaDecimal)))
                ElseIf EsMascaraNumerica Then
                    Resultado.Append(EnteroDecimal.ToString(MascaraSalidaDecimal))
                Else
                    Resultado.Append(EnteroDecimal.ToString() + " " + MascaraSalidaDecimal)
                End If
            End If
            'Se pone la primer letra en mayúscula si corresponde y se retorna el resultado
            If LetraCapital Then
                Return Resultado(1).ToString().ToUpper() + Resultado.ToString(2, Resultado.Length - 2)
            Else
                Return Resultado.ToString().Substring(1)
            End If
        End Function

    End Class 'Numeros a letras


    Private Sub InsertarAsiento()

        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::ASIENTO CONTABLE DE FACTURA DE COMPRA
        Dim sumaPrecio As Double = 0
        Dim asiento As New ClsAsientoContable
        Dim detalleasiento As New ClsDetalleAsiento
        Dim periodocontable As New ClsPeriodoContable
        Dim objCentroCosto As New ClsCentroCostos
        Dim codigoAsiento As String
        Dim codigodetalle As Integer
        Dim cuentaCentroCosto As New DataTable

        'Capturando periodo contable
        Dim codPeriodo As String

        Dim dtp As New DataTable
        Dim rowp As DataRow
        dtp = periodocontable.periodoContableActivo()
        rowp = dtp.Rows(0)
        codPeriodo = rowp("codPeriodo").ToString

        With asiento

            .Cod_Periodo = Convert.ToInt32(codPeriodo)
            .Descrip = txtnumeroFactura.Text + " " + txtnombreCliente.Text
            .Fecha_ = dtpfechaFactura.Value
            .Campo_Llave = txtnumeroFactura.Text
            .Estado_ = 0
            .Origen_ = "Ingresos-Facturacion"
            codigoAsiento = .registrarAsiento

        End With


        'DETALLE DE ASIENTO/ INGRESO POR EXAMEN

        Try
            Dim ds As New DataSet
            ' Add Table
            ds.Tables.Add("ListaExamenes")
            ' Add Columns

            Dim col As DataColumn
            For Each dgvCol As DataGridViewColumn In dgblistadoExamenes.Columns
                col = New DataColumn(dgvCol.Name)
                ds.Tables("ListaExamenes").Columns.Add(col)
            Next

            'Add Rows from the datagridview
            Dim row As DataRow
            Dim colcount As Integer = dgblistadoExamenes.Columns.Count - 1
            For i As Integer = 0 To dgblistadoExamenes.Rows.Count - 1
                row = ds.Tables("ListaExamenes").Rows.Add
                For Each column As DataGridViewColumn In dgblistadoExamenes.Columns
                    row.Item(column.Index) = dgblistadoExamenes.Rows.Item(i).Cells(column.Index).Value
                Next
            Next
            'Ordenar el data table por grupo
            Dim dt As New DataTable 'tabla de los items ordenador por subarea
            dt = ds.Tables(0)
            dt.DefaultView.Sort = "id_centrocosto DESC"

            For i As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(i)
                sumaPrecio = 0
                If CStr(row("subArea")) <> "0" Then

                    For j As Integer = i To dt.Rows.Count - 1
                        Dim rowC As DataRow
                        rowC = dt.Rows(j)
                        If row("id_centrocosto") = rowC("id_centrocosto") Then

                            sumaPrecio = sumaPrecio + rowC("Subtotal")


                            If j = dt.Rows.Count - 2 Then

                                'INSERTAR DETALLE DE ASIENTO

                                With objCentroCosto

                                    .ID = Integer.Parse(dgblistadoExamenes.Rows(i).Cells(10).Value)
                                    cuentaCentroCosto = .BuscarCentroCostoCodigo

                                End With

                                Dim rowCuenta2 As DataRow
                                rowCuenta2 = cuentaCentroCosto.Rows(0)

                                With detalleasiento
                                    .Cod_Asiento = Convert.ToInt32(codigoAsiento)
                                    .Cuenta_ = Integer.Parse(rowCuenta2("codCuenta"))
                                    .Debe_ = 0
                                    .Haber_ = sumaPrecio
                                    .Origen_ = "Ingresos-Facturacion"

                                    codigodetalle = .registrarDetalleAsiento()

                                End With
                                Dim objasiento_cc2 As New ClsCentoCostos_Asientos
                                'CENTRO DE COSTO
                                With objasiento_cc2

                                    .id_asientos_ = Integer.Parse(codigoAsiento)
                                    .id_detalleasiento_ = Integer.Parse(codigodetalle)
                                    .idcentrocostos_ = Integer.Parse(dgblistadoExamenes.Rows(i).Cells(10).Value)
                                    .codSucursal_ = Integer.Parse(lblcodeSucursal.Text)
                                    .REGISTRO_ASIENTO_CC()

                                End With

                                MsgBox("finalizo conteo para asiento.", MsgBoxStyle.Information)

                                'Caja general
                                With detalleasiento
                                    .Cod_Asiento = Convert.ToInt32(codigoAsiento)
                                    .Cuenta_ = 111011
                                    .Debe_ = txttotal.Text
                                    .Haber_ = 0
                                    .Origen_ = "Ingresos-Facturacion"

                                    codigodetalle = .registrarDetalleAsiento()

                                End With
                                Exit Sub
                            End If
                        Else
                            i = j - 1
                            Exit For
                        End If
                    Next

                    'INSERTAR DETALLE DE ASIENTO

                    With objCentroCosto

                        .ID = Integer.Parse(dgblistadoExamenes.Rows(i).Cells(10).Value)
                        cuentaCentroCosto = .BuscarCentroCostoCodigo

                    End With

                    Dim rowCuenta As DataRow
                    rowCuenta = cuentaCentroCosto.Rows(0)

                    With detalleasiento
                        .Cod_Asiento = Convert.ToInt32(codigoAsiento)
                        .Cuenta_ = Integer.Parse(rowCuenta("codCuenta"))
                        .Debe_ = 0
                        .Haber_ = sumaPrecio
                        .Origen_ = "Ingresos-Facturacion"

                        codigodetalle = .registrarDetalleAsiento()

                    End With
                    Dim objasiento_cc As New ClsCentoCostos_Asientos
                    'CENTRO DE COSTO
                    With objasiento_cc

                        .id_asientos_ = Integer.Parse(codigoAsiento)
                        .id_detalleasiento_ = Integer.Parse(codigodetalle)
                        .idcentrocostos_ = Integer.Parse(dgblistadoExamenes.Rows(i).Cells(10).Value)
                        .codSucursal_ = Integer.Parse(lblcodeSucursal.Text)
                        .REGISTRO_ASIENTO_CC()

                    End With

                End If
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Class 'final facturacion