Public Class A_ListarChequesHabilitados
    Dim cheque As New ClsCheques
    Private Sub A_ListarChequesHabilitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar cheques habilitados
        Dim fila As String = frmPagos.lblFila.Text
        Dim dato As String
        dato = frmPagos.dtDetallePagos.Rows(fila).Cells(4).Value


        If (dato <> "") Then

            cheque.Cod_BreveBanco = frmPagos.dtDetallePagos.Rows(fila).Cells(4).Value
            dtCheques.DataSource = cheque.listarChequesDisponibles

        Else

            MsgBox("Debe seleccionar la forma de pago de cheque.")

        End If

    End Sub

    Private Sub dtCheques_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCheques.CellDoubleClick


        Try
            A_Cheques.Show()

            A_Cheques.txtNro.Text = dtCheques.Rows(e.RowIndex).Cells(0).Value
            A_Cheques.txtNroCheq.Text = dtCheques.Rows(e.RowIndex).Cells(2).Value
            A_Cheques.txtMoneda.Text = dtCheques.Rows(e.RowIndex).Cells(6).Value
            A_Cheques.txtBanco.Text = dtCheques.Rows(e.RowIndex).Cells(9).Value
            A_Cheques.txtnombreBanco.Text = dtCheques.Rows(e.RowIndex).Cells(10).Value
            A_Cheques.lblEstado.Text = dtCheques.Rows(e.RowIndex).Cells(11).Value
        Catch ex As Exception
            MsgBox("Error al seleccionar el cheque. Form: A_ListarChequesHabilitados. " + ex.Message)
        End Try


    End Sub


End Class