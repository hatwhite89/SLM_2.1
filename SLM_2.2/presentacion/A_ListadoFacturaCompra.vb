Public Class A_ListadoFacturaCompra

    Dim FacCompra As New ClsFacturaCompra
    Private Sub A_ListadoFacturaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Facturas de Compra
        dtFacturasCompra.DataSource = FacCompra.listarFacturaCompra

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A_FacturaCompras.Show()
        Me.Close()
    End Sub
End Class