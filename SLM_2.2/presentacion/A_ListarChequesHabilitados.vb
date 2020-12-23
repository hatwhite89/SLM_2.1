Public Class A_ListarChequesHabilitados
    Dim cheque As New ClsCheques

    Private Sub A_ListarChequesHabilitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Cargar cheques habilitados
            'Dim fila As String = frmPagos.lblFila.Text
            Dim dato As String
            dato = frmPagos.txtFormaP.Text

            If (dato <> "") Then

                dtCheques.DataSource = cheque.listarChequesDisponibles(frmPagos.lblNombreBanco.Text)
                dtCheques.Columns("codCheque").Visible = False
                dtCheques.Columns("codChequera").Visible = False
                dtCheques.Columns("monto").Visible = False
                dtCheques.Columns("moneda").Visible = False
                dtCheques.Columns("fechaReg").Visible = False
                dtCheques.Columns("fechaVto").Visible = False
                dtCheques.Columns("fechaAcreditacion").Visible = False
                dtCheques.Columns("fechaRechazo").Visible = False
                dtCheques.Columns("fechaCancelado").Visible = False
                dtCheques.Columns("tipo").Visible = False
                dtCheques.Columns("ctaOrigen").Visible = False
                dtCheques.Columns("ctaTemporal").Visible = False
                dtCheques.Columns("ctaDestino").Visible = False
                dtCheques.Columns("codProveedor").Visible = False

            Else

                MsgBox("Debe seleccionar la forma de pago de cheque.")

            End If
        Catch ex As Exception

        End Try


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
            A_Cheques.txtBanco.Text = frmPagos.lblNombreBanco.Text
            A_Cheques.lblEstado.Text = row("estado")
            A_Cheques.txtNroCtaBanco.Text = frmPagos.txtCtaBanco.Text
            Me.Close()

            Dim prov As New ClsProveedor
            Dim dtpro As New DataTable
            Dim rowpro As DataRow

            dtpro = prov.listarProveedoresJC(frmPagos.lblCodigoProveedor.Text)

            rowpro = dtpro.Rows(0)
            A_Cheques.txtcodProvee.Text = rowpro("codBreve")
            A_Cheques.txtNombreProvee.Text = rowpro("nombreProveedor")
            A_Cheques.lblCodProveedor.Text = frmPagos.lblCodigoProveedor.Text



        Catch ex As Exception

            MsgBox("Error al seleccionar el cheque. Form: A_ListarChequesHabilitados. " + ex.Message)

        End Try


    End Sub


End Class