Public Class A_ListadoFacturaCompra

    Dim FacCompra As New ClsFacturaCompra
    Private Sub A_ListadoFacturaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Facturas de Compra
        dtFacturasCompra.DataSource = FacCompra.listarFacturaCompra

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCrearFactura.Click
        A_FacturaCompras.ShowDialog()
        Me.Close()
    End Sub

    Private Sub dtFacturasCompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFacturasCompra.CellClick

        Try

            Dim dt As New DataTable

            dt = dtFacturasCompra.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)

            A_FacturaCompras.txtCodFactura.Text = row("codFactura")
            A_FacturaCompras.txtCodProveedor.Text = row("codProveedor")
            'A_FacturaCompras.txtNombreProveedor.Text = row("codFactura")
            A_FacturaCompras.txtTotal.Text = row("total")
            A_FacturaCompras.txtMoneda.Text = row("moneda")
            A_FacturaCompras.dtpFechaFactura.Value = row("fechaFactura")
            A_FacturaCompras.txtTerminoPago.Text = row("terminosPago")
            A_FacturaCompras.dtpTransaccion.Value = row("fechaTransaccion")
            A_FacturaCompras.dtpVencimiento.Value = row("fechaVencimiento")
            A_FacturaCompras.txtNroFactura.Text = row("nroFactura")


            'Mostrar detalle de factura
            Dim DetalleFac As New ClsDetalleFacturaCompra
            Dim dtFac As New DataTable

            DetalleFac.Cod_Factura = row("codFactura")

            dtFac = DetalleFac.listarDetallesFacturaCompra()

            For index As Integer = 0 To dtFac.Rows.Count - 1
                row = dtFac.Rows(index)
                A_FacturaCompras.dtDetalleFactura.Rows.Add(New String() {(row("cuenta")), CStr(row("area")), CStr(row("sede")), CStr(row("descripcion")), CStr(row("monto")), CStr(row("tipoStock"))})
            Next

            A_FacturaCompras.btnCrear.Visible = True
            A_FacturaCompras.btnModificar.Visible = True
            A_FacturaCompras.btnGuardar.Visible = False

            Me.Close()
            A_FacturaCompras.Show()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        'Busqueda de facturas por nombre de proveedor
        FacCompra.Nombre_Proveedor = txtBusqueda.Text

        dtFacturasCompra.DataSource = FacCompra.buscarFacturaProveedor()

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