Public Class A_ListarPagos

    Dim pagos As New ClsPago

    Private Sub A_ListarPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_ListarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar listado de pagos

        Dim dt As New DataTable
        dtPagos.DataSource = pagos.listarPagos

    End Sub

    Private Sub dtPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPagos.CellClick







    End Sub
End Class