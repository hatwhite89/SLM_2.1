Public Class A_ListarFacCompraPagos

    Dim FactCompra As New ClsFacturaCompra
    Private Sub A_ListarFacCompraPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Cargar Facturas de Compra
            dtFacturasCompra.DataSource = FactCompra.listarFacturaCompra

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtFacturasCompra_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFacturasCompra.CellDoubleClick
        Try
            Dim a As String = frmPagos.lblFila.Text
            Dim moneda, proveedor, nroFact, monto As String

            nroFact = dtFacturasCompra.Rows(e.RowIndex).Cells(0).Value
            proveedor = dtFacturasCompra.Rows(e.RowIndex).Cells(2).Value
            moneda = dtFacturasCompra.Rows(e.RowIndex).Cells(4).Value
            monto = dtFacturasCompra.Rows(e.RowIndex).Cells(3).Value



            Dim i, rows As Integer
            rows = dtFacturasCompra.Rows.Count - 2

            'Comprobar que la factura no este duplicada.

            If (frmPagos.validarFacturaPago(nroFact) = 0) Then

                frmPagos.dtDetallePagos.Rows.Add(New String() {nroFact, proveedor, moneda, monto, " ", " "})
                Me.Close()
            Else
                MsgBox("La factura ya ha sido agregado.")
            End If


            Dim Total As Double
            Dim Col As Integer = 3
            For Each row As DataGridViewRow In frmPagos.dtDetallePagos.Rows
                Total += Convert.ToDouble(row.Cells(Col).Value)
            Next
            frmPagos.lblTotalSuma.Text = Total.ToString

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try



    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        With FactCompra
            .Nro_Factura = txtBusqueda.Text

            dtFacturasCompra.DataSource = .BuscarFacturaXNro

        End With


    End Sub
End Class