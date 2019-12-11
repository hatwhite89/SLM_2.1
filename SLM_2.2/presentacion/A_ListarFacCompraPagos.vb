Public Class A_ListarFacCompraPagos

    Dim FactCompra As New ClsFacturaCompra
    Private Sub A_ListarFacCompraPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Facturas de Compra
        dtFacturasCompra.DataSource = FactCompra.listarFacturaCompra

    End Sub
End Class