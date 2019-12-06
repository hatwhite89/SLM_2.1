Public Class A_ListarChequesHabilitados
    Dim cheque As New ClsCheques
    Private Sub A_ListarChequesHabilitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar cheques habilitados

        Dim fila As String = frmPagos.lblFila.Text
        cheque.Cod_BreveBanco = frmPagos.dtDetallePagos.Rows(fila).Cells(4).Value

        dtCheques.DataSource = cheque.listarChequesDisponibles



    End Sub
End Class