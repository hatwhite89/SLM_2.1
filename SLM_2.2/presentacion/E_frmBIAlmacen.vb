Public Class E_frmBIAlmacen
    Private Sub E_frmBIAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clsA As New clsInventario

        Chart1.DataSource = clsA.BIAlmacen
        Chart1.Series("Series1").XValueMember = "cantidad"
        Chart1.Series("Series1").YValueMembers = "nombre_almacen"

        Chart1.DataBind()

    End Sub
End Class