Public Class A_ListarChequesHabilitados
    Dim cheque As New ClsCheques
    Private Sub A_ListarChequesHabilitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar cheques habilitados
        Dim fila As String = frmPagos.lblFila.Text
        Dim dato As String
        dato = frmPagos.txtFormaP.Text


        If (dato <> "") Then

            cheque.Cod_BreveBanco = frmPagos.txtFormaP.Text
            dtCheques.DataSource = cheque.listarChequesDisponibles

        Else

            MsgBox("Debe seleccionar la forma de pago de cheque.")

        End If

    End Sub

    Private Sub dtCheques_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCheques.CellDoubleClick


        Try
            A_Cheques.Show()

            Dim dt As New DataTable
            dt = dtCheques.DataSource

            Dim row As DataRow = dt.Rows(0)



            A_Cheques.txtNro.Text = row("codCheque")
            A_Cheques.txtNroCheq.Text = row("nroCheque")
            A_Cheques.txtMoneda.Text = row("moneda")
            A_Cheques.txtBanco.Text = row("codBreveBanco")
            A_Cheques.txtnombreBanco.Text = row("nombreBanco")
            A_Cheques.lblEstado.Text = row("estado")
            A_Cheques.txtNroCtaBanco.Text = frmPagos.txtCtaBanco.Text
            Me.Close()

        Catch ex As Exception

            MsgBox("Error al seleccionar el cheque. Form: A_ListarChequesHabilitados. " + ex.Message)

        End Try


    End Sub


End Class