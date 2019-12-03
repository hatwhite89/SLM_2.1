Public Class frmPagos

    Dim formaPago As New ClsFormaPago
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Cerrar Ventana Pagos
        Me.Close()
    End Sub



    Private Sub frmPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarFormaPago.Click
        'Mostrar formas de pago
        A_ListarFormasPagoPF.ShowDialog()

    End Sub

    Private Sub dtDetallePagos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellEndEdit

        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        dtDetallePagos.Columns(3).ReadOnly = True





    End Sub

    Private Sub dtDetallePagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDetallePagos.CellClick
        dtDetallePagos.Columns(1).ReadOnly = True
        dtDetallePagos.Columns(2).ReadOnly = True
        dtDetallePagos.Columns(3).ReadOnly = True
    End Sub
End Class