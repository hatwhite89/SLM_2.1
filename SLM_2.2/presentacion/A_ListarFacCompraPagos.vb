Public Class A_ListarFacCompraPagos

    Dim FactCompra As New ClsFacturaCompra
    Private Sub A_ListarFacCompraPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Facturas de Compra
        dtFacturasCompra.DataSource = FactCompra.listarFacturaCompra

    End Sub

    Private Sub dtFacturasCompra_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFacturasCompra.CellDoubleClick

        Dim a As String = frmPagos.lblFila.Text
        Dim moneda, proveedor, nroFact, monto As String

        nroFact = dtFacturasCompra.Rows(e.RowIndex).Cells(0).Value
        proveedor = dtFacturasCompra.Rows(e.RowIndex).Cells(2).Value
        moneda = dtFacturasCompra.Rows(e.RowIndex).Cells(4).Value
        monto = dtFacturasCompra.Rows(e.RowIndex).Cells(3).Value

        frmPagos.dtDetallePagos.Rows.Add(New String() {nroFact, proveedor, moneda, monto, " ", " "})

        Try
            Dim Total As Single
            Dim Col As Integer = 3
            For Each row As DataGridViewRow In frmPagos.dtDetallePagos.Rows
                Total += Val(row.Cells(Col).Value)
            Next
            frmPagos.lblTotalSuma.Text = Total.ToString

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

        Me.Close()

    End Sub


End Class