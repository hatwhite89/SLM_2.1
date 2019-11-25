Public Class A_ListarObjetos

    Dim objeto As New ClsObjeto
    Private Sub A_ListarObjetos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtObjetos.DataSource = objeto.listarNombreObjeto

    End Sub

    Private Sub dtObjetos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtObjetos.CellClick

        Dim obj As String

        obj = dtObjetos.Rows(e.RowIndex).Cells(0).Value
        A_FacturaCompras.dtDetalleFactura.Rows(e.RowIndex).Cells(1).Value = obj

    End Sub
End Class