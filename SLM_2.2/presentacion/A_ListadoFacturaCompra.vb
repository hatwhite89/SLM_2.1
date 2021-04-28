Public Class A_ListadoFacturaCompra

    Dim FacCompra As New ClsFacturaCompra
    Public Sub A_ListadoFacturaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Cargar Facturas de Compra
            dtFacturasCompra.DataSource = FacCompra.listarFacturaCompra
            alternarColoFilasDatagridview(dtFacturasCompra)





            If dtFacturasCompra.Columns.Contains("codFactura") = True Then

                dtFacturasCompra.Columns("codProveedor").Visible = False
                dtFacturasCompra.Columns("moneda").Visible = False
                dtFacturasCompra.Columns("codTerminoPago").Visible = False
                dtFacturasCompra.Columns("fechaTransaccion").Visible = False

                dtFacturasCompra.Columns("fechaFactura").HeaderText = "Fecha de Factura"
                dtFacturasCompra.Columns("fechaVencimiento").HeaderText = "Fecha de Venci."
                dtFacturasCompra.Columns("descripcion").HeaderText = "Descripción"


            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub dtFacturasCompra_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFacturasCompra.CellDoubleClick

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

            'consulta centro de costo
            Dim ccosto As New ClsCentroCostos
            Dim dtcc As New DataTable
            Dim rowcc As DataRow

            Dim sucursal As New ClsSucursal
            Dim dtsu As New DataTable
            Dim rowsu As DataRow

            DetalleFac.Cod_Factura = row("codFactura")
            'MsgBox("codigo " + row("codFactura").ToString)
            dtFac = DetalleFac.listarDetallesFacturaCompra()

            For index As Integer = 0 To dtFac.Rows.Count - 1
                row = dtFac.Rows(index)

                ccosto.ID = Integer.Parse(row("area"))
                dtcc = ccosto.BuscarCentroCostoCodigo
                rowcc = dtcc.Rows(0)

                sucursal.codigo_ = Integer.Parse(row("sede"))
                dtsu = sucursal.BuscarSucursalNumero
                rowsu = dtsu.Rows(0)

                A_FacturaCompras.dtDetalleFactura.Rows.Add(New String() {(row("codDetalle")), (row("cuenta")), rowcc("codBreve"), rowsu("codigoSucursal"), CStr(row("descripcion")), CStr(row("monto")), CStr(rowcc("id_centrocosto")), CStr(rowsu("codigo"))})

            Next

            Me.Hide()
            A_FacturaCompras.btnGuardar.Enabled = False
            A_FacturaCompras.btnModificar.Enabled = True
            A_FacturaCompras.btnCrear.Enabled = True
            A_FacturaCompras.Show()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        alternarColoFilasDatagridview(dtFacturasCompra)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCrearNueva.Click
        Me.Hide()
        A_FacturaCompras.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim estado, estado2, estado3 As String
            Dim fechaDesde, fechaHasta As Date
            Dim factu As New ClsFacturaCompra

            fechaDesde = dtpDesde.Value
            fechaHasta = dtpHasta.Value

            If chkIngresada.Checked = True Then
                estado = "Ingresada"
            Else
                estado = ""
            End If

            If chkPendientes.Checked = True Then
                estado2 = "Pendiente"
            Else
                estado2 = ""
            End If

            If chkPagadas.Checked = True Then
                estado3 = "Pagada"
            Else
                estado3 = ""
            End If

            dtFacturasCompra.DataSource = factu.ReporteFacturasCompraEstado(estado, estado2, estado3, fechaDesde, fechaHasta)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            E_frmInventario.GridAExcel(dtFacturasCompra)
        Catch ex As Exception

        End Try
    End Sub
End Class