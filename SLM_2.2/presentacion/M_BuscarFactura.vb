Imports System.ComponentModel
Public Class M_BuscarFactura
    Private Sub M_BuscarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarFacturas()
        txtnombreB.Text = ""
        txtnumeroB.Text = ""
        Me.dgbtabla.Columns("codigo").Visible = False
        Dim dv As DataView = dgbtabla.DataSource
        dv.Sort = "FechaFactura Desc"
        'dgbtabla.DataSource = dv
        'dgbtabla.Sort(dgbtabla.Columns(3), ListSortDirection.Ascending)
        Me.dgbtabla.Columns("Subtotal").Visible = False
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Public Sub seleccionarFacturas()
        alternarColoFilasDatagridview(dgbtabla)
        Dim objFact As New ClsFactura
        Dim dv As DataView = objFact.SeleccionarFactura.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '   CAMBIAR EL COLOR DE UN DATA GRID VIEW POR FILA O POR DEFECTO
        'dgbtabla.Rows(0).DefaultCellStyle.BackColor = Color.Green
        'dgbtabla.Rows(1).DefaultCellStyle.BackColor = Color.Green
        'dgbtabla.Rows(2).DefaultCellStyle.BackColor = Color.Green
        '   
        'dgbtabla.RowsDefaultCellStyle.BackColor = Color.Red
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver la factura?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                M_Factura.limpiar()
                M_Factura.banderaTipo = True

                Dim objFact As New ClsFactura
                objFact.numero_ = dgbtabla.Rows(e.RowIndex).Cells(1).Value()

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
                'M_Factura.txtcodigoConvenio.Text = CStr(row("codigoConvenio"))

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
                objDetFact.numeroFactura_ = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
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
                txtnombreB.Text = ""
                txtnumeroB.Text = ""
                'Me.Hide()

                M_Factura.Show()
                Me.Close()
                Form1.WindowState = FormWindowState.Minimized

            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
    '    Try
    '        Dim n As String = ""
    '        If e.RowIndex >= 0 Then
    '            n = MsgBox("¿Desea ver la factura?", MsgBoxStyle.YesNo, "Validación")
    '        End If
    '        If n = vbYes Then
    '            M_Factura.limpiar()
    '            Dim objFact As New ClsFactura
    '            objFact.numero_ = dgbtabla.Rows(e.RowIndex).Cells(1).Value()

    '            Dim dt As New DataTable
    '            dt = objFact.BuscarFacturaNumero()
    '            Dim row As DataRow = dt.Rows(0)

    '            M_Factura.txtnumeroFactura.Text = CStr(row("numero"))
    '            M_Factura.txtnumeroOficial.Text = CStr(row("numeroOficial"))
    '            M_Factura.dtpfechaFactura.Value = CStr(row("fechaFactura"))
    '            M_Factura.txtcodigoCliente.Text = CStr(row("codigoCliente"))
    '            M_Factura.txtcodigoRecepecionista.Text = CStr(row("codigoRecepcionista"))
    '            M_Factura.txtcodigoMedico.Text = CStr(row("codigoMedico"))
    '            M_Factura.txtcodigoCajero.Text = CStr(row("codigoCajero"))
    '            M_Factura.lblcodeTerminoPago.Text = CStr(row("codigoTerminoPago"))
    '            M_Factura.txtcodigoSede.Text = CStr(row("codigoSede"))
    '            M_Factura.dtpfechaVto.Value = CStr(row("fechaVto"))
    '            M_Factura.lblcodeSucursal.Text = CStr(row("codigoSucursal"))

    '            'M_Factura.lblcodePriceList.Text = CStr(row("codigoConvenio"))
    '            M_Factura.txtcodigoConvenio.Text = CStr(row("codigoConvenio"))

    '            M_Factura.txtnumeroPoliza.Text = CStr(row("numeroPoliza"))
    '            M_Factura.txtcodigoTerminal.Text = CStr(row("codigoTerminal"))
    '            M_Factura.lblcodeSucursal.Text = CStr(row("codigoSucursal"))
    '            M_Factura.cbxentregarMedico.Checked = CStr(row("entregaMedico"))
    '            M_Factura.cbxentregarPaciente.Checked = CStr(row("entregaPaciente"))
    '            M_Factura.cbxenviarCorreo.Checked = CStr(row("enviarEmail"))
    '            M_Factura.txtpagoPaciente.Text = CStr(row("pagoPaciente"))
    '            M_Factura.txtEfectivo.Text = CStr(row("ingresoEfectivo"))
    '            M_Factura.txtTarjeta.Text = CStr(row("ingresoTarjeta"))
    '            M_Factura.txtvuelto.Text = CStr(row("vuelto"))
    '            M_Factura.txttotal.Text = CStr(row("total"))
    '            M_Factura.cbxok.Checked = CStr(row("ok"))
    '            M_Factura.cbxAnular.Checked = CStr(row("estado"))

    '            Dim objDetFact As New ClsDetalleFactura
    '            objDetFact.numeroFactura_ = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
    '            dt = objDetFact.BuscarDetalleFactura()
    '            For index As Integer = 0 To dt.Rows.Count - 1
    '                row = dt.Rows(index)
    '                M_Factura.dgblistadoExamenes.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("cantidad")), CStr(row("precio")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal")), CStr(row("grupo")), CStr(row("numero"))})
    '                M_ClienteVentana.dgvtabla.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("cantidad")), CStr(row("precio")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal"))})

    '                'OBSERVACIONES
    '                M_Factura.dgbObservaciones.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("observaciones"))})
    '            Next

    '            M_Factura.deshabilitar()
    '            If (M_Factura.cbxok.Checked = "0") Then
    '                M_Factura.HabilitarActualizarFactura()
    '            Else
    '                M_Factura.btnActualizar.Enabled = True
    '            End If
    '            'Me.Close()
    '            txtnombreB.Text = ""
    '            txtnumeroB.Text = ""
    '            Me.Hide()

    '            M_Factura.show()
    '        End If
    '    Catch ex As Exception
    '        'MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroB.TextChanged
        If (txtnumeroB.Text <> "") Then
            Try
                Dim objFact As New ClsFactura
                objFact.numero_ = txtnumeroB.Text
                Dim dv As DataView = objFact.BuscarFacturaNumeroF.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarFacturas()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        If (txtnombreB.Text <> "") Then
            Try
                Dim objFact As New ClsFactura
                objFact.nombreCliente_ = txtnombreB.Text
                Dim dv As DataView = objFact.BuscarFacturaCliente.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarFacturas()
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        'Me.Close()
        txtnombreB.Text = ""
        txtnumeroB.Text = ""
        'Me.Hide()
        M_Factura.limpiar()
        M_Factura.banderaTipo = True
        M_Factura.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        M_DiarioFacturacion.lblForm.Text = "M_DiarioFacturacion"
        M_DiarioFacturacion.Show()
        'A_BuscarPlanilla.lblform.Text = "A_BuscarPlanilla"
        'A_BuscarPlanilla.show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Cierre de caja
        Try
            'MsgBox(Form1.lblMiUser.Text)
            Dim objReporte As New CierreCaja
            objReporte.SetParameterValue("Cajero", Form1.lblMiUser.Text)
            objReporte.SetParameterValue("@codigoCajero", Convert.ToInt64(Form1.lblUserCod.Text))
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            M_ImprimirCotizacionForm.CrystalReportViewer1.ReportSource = objReporte
            M_ImprimirCotizacionForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Arqueo
        Try
            'Busca la maquina local
            Dim objMaq As New ClsMaquinasLocales
            With objMaq
                .descripcion_ = System.Environment.MachineName
            End With
            Dim dt As New DataTable
            dt = objMaq.BuscarMaquinasLocalesDesc()
            Dim row As DataRow = dt.Rows(0)
            'MsgBox(CStr(row("codigoMaquinasLocales")))
            'Genera el reporte
            Dim objReporte As New Cry_Arqueo
            objReporte.SetParameterValue("@codigoMaquinaLocal", CStr(row("codigo")))
            objReporte.SetParameterValue("Sucursal", CStr(row("Sucursal")))
            objReporte.SetParameterValue("MaquinaLocal", CStr(row("codigoMaquinasLocales")))
            objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            M_ImprimirCotizacionForm.CrystalReportViewer1.ReportSource = objReporte
            M_ImprimirCotizacionForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        A_MuestraPantallaCliente.Show()
    End Sub
End Class