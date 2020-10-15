Public Class A_ListadoFacturaCompra

    Dim FacCompra As New ClsFacturaCompra
    Private Sub A_ListadoFacturaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Facturas de Compra
        dtFacturasCompra.DataSource = FacCompra.listarFacturaCompra

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCrearFactura.Click
        Me.Close()
        A_FacturaCompras.Show()
    End Sub

    Private Sub dtFacturasCompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFacturasCompra.CellClick

        Try

            Dim dt As New DataTable

            dt = dtFacturasCompra.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)

            A_FacturaCompras.txtCodFactura.Text = row("codFactura")
            A_FacturaCompras.txtCodProveedor.Text = row("codProveedor")
            'A_FacturaCompras.txtNombreProveedor.Text = row("codFactura")
            A_FacturaCompras.txtDescripcion.Text = row("descripcion")
            A_FacturaCompras.txtTotal.Text = row("total")
            A_FacturaCompras.txtMoneda.Text = row("moneda")
            A_FacturaCompras.dtpFechaFactura.Value = row("fechaFactura")
            A_FacturaCompras.lblCodTerminoPago.Text = row("CodTerminoPago")
            A_FacturaCompras.dtpTransaccion.Value = row("fechaTransaccion")
            A_FacturaCompras.dtpVencimiento.Value = row("fechaVencimiento")
            A_FacturaCompras.txtNroFactura.Text = row("nroFactura")
            A_FacturaCompras.lblTotal.Text = row("total")
            A_FacturaCompras.lblEstado.Text = row("estado")
            A_FacturaCompras.lblSaldoPend.Text = row("pendiente")


            'Mostrar detalle de factura
            Dim DetalleFac As New ClsDetalleFacturaCompra
            Dim dtFac As New DataTable

            DetalleFac.Cod_Factura = row("codFactura")

            dtFac = DetalleFac.listarDetallesFacturaCompra()

            For index As Integer = 0 To dtFac.Rows.Count - 1
                row = dtFac.Rows(index)
                A_FacturaCompras.dtDetalleFactura.Rows.Add(New String() {(row("cuenta")), CStr(row("area")), CStr(row("sede")), CStr(row("descripcion")), CStr(row("monto")), CStr(row("tipoStock"))})
            Next

            Me.Close()
            A_FacturaCompras.Show()
            A_FacturaCompras.btnGuardar.Enabled = False
            A_FacturaCompras.btnModificar.Enabled = True
            A_FacturaCompras.btnCrear.Enabled = True

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        'Busqueda de facturas por nombre de proveedor

        Try

            FacCompra.Nombre_Proveedor = txtBusqueda.Text
            dtFacturasCompra.DataSource = FacCompra.buscarFacturaProveedor()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub A_ListadoFacturaCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class