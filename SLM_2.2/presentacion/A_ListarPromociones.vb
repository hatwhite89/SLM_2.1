Public Class A_ListarPromociones

    Dim promo As New ClsPromociones
    Private Sub A_ListarPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtPromos.DataSource = promo.ListarPromociones
    End Sub

    Private Sub dtPromos_DoubleClick(sender As Object, e As EventArgs) Handles dtPromos.DoubleClick





    End Sub
End Class