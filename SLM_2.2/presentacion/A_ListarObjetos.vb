Public Class A_ListarObjetos

    Dim objeto As New ClsObjeto
    Private Sub A_ListarObjetos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtObjetos)
        dtObjetos.DataSource = objeto.listarNombreObjeto

    End Sub


    Private Sub dtObjetos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtObjetos.CellClick

        Dim obj As String


        If lblForm.Text = "area" Then
            obj = dtObjetos.Rows(e.RowIndex).Cells(0).Value
            A_FacturaCompras.dtDetalleFactura.Rows(Convert.ToInt32(A_FacturaCompras.lblFila.Text)).Cells(2).Value = obj
            Me.Close()
        ElseIf lblForm.Text = "sede" Then
            obj = dtObjetos.Rows(e.RowIndex).Cells(0).Value
            A_FacturaCompras.dtDetalleFactura.Rows(Convert.ToInt32(A_FacturaCompras.lblFila.Text)).Cells(3).Value = obj
            Me.Close()

        End If



    End Sub
End Class