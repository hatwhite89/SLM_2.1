Public Class M_BuscarFactura
    Private Sub M_BuscarCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objFact As New ClsFactura
        Dim dv As DataView = objFact.SeleccionarFactura.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub seleccionarFacturas()
        Dim objFact As New ClsFactura
        Dim dv As DataView = objFact.SeleccionarFactura.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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
                Dim objFact As New ClsFactura
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
                M_Factura.txtcodigoConvenio.Text = CStr(row("codigoConvenio"))
                M_Factura.txtnumeroPoliza.Text = CStr(row("numeroPoliza"))
                M_Factura.txtcodigoTerminal.Text = CStr(row("codigoTerminal"))
                M_Factura.cbxentregarMedico.Checked = CStr(row("entregaMedico"))
                M_Factura.cbxentregarPaciente.Checked = CStr(row("entregaPaciente"))
                M_Factura.cbxenviarCorreo.Checked = CStr(row("enviarEmail"))
                M_Factura.txtpagoPaciente.Text = CStr(row("pagoPaciente"))
                M_Factura.txtvuelto.Text = CStr(row("vuelto"))
                M_Factura.txttotal.Text = CStr(row("total"))
                M_Factura.cbxok.Checked = CStr(row("ok"))

                Dim objDetFact As New ClsDetalleFactura
                objDetFact.numeroFactura_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                dt = objDetFact.BuscarDetalleFactura()
                For index As Integer = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    M_Factura.dgblistadoExamenes.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("cantidad")), CStr(row("precio")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal"))})
                    M_ClienteVentana.dgvtabla.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("cantidad")), CStr(row("precio")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal"))})
                Next
                M_Factura.deshabilitar()
                If (M_Factura.cbxok.Checked = "0") Then
                    M_Factura.HabilitarActualizarFactura()
                Else
                    M_Factura.btnActualizar.Enabled = False
                End If
                'Me.Close()
                M_Factura.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroB.TextChanged
        If (txtnumeroB.Text <> "") Then
            Try
                Dim objFact As New ClsFactura
                objFact.numero_ = txtnumeroB.Text
                Dim dv As DataView = objFact.BuscarFactura.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarFacturas()
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        'Me.Close
        M_Factura.limpiar()
        M_Factura.ShowDialog()
    End Sub

End Class