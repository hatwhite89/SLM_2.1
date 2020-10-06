Public Class A_ListadoCheques

    Dim cheque As New ClsCheques
    Private Sub A_ListadoCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtCheques.DataSource = cheque.listarCheques

        Catch ex As Exception
            MsgBox("Hubo un error al intentar listar los cheques. Detalle: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Try
            txtBusqueda.Text = ""
            dtCheques.DataSource = cheque.listarCheques
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try
            Dim Dato As New DataTable
            'Actualizar datos en datagrid con textbox
            With cheque

                .Numero_Cheque = txtBusqueda.Text
                .Nombre_Proveedor = txtBusqueda.Text

                Dato = cheque.buscarCheques
                dtCheques.DataSource = Dato

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub A_ListadoCheques_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As Object, e As EventArgs) Handles txtBusqueda.MouseHover
        ttBusqueda.SetToolTip(txtBusqueda, "Ingrese el Nro.Cheque o Nombre de Proveedor")
        ttBusqueda.ToolTipTitle = "Búsqueda"
        ttBusqueda.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub dtCheques_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCheques.CellDoubleClick

        Try

            Dim dt, dt2 As DataTable
            Dim row, row2 As DataRow
            Dim formap As New ClsFormaPago

            dt = dtCheques.DataSource
            row = dt.Rows(e.RowIndex)

            formap.Ban_co = row("nombreBanco")
            dt2 = formap.ctaBancoXBanco()
            row2 = dt2.Rows(0)



            With A_Cheques

                .txtNro.Text = row("codCheque")
                .txtNroCheq.Text = row("nroCheque")
                .txtMonto.Text = row("monto")
                .dtpFechaReg.Value = row("fechaReg")
                .dtpFechaVto.Value = row("fechaVto")
                .txtMoneda.Text = row("moneda")
                .lblEstado.Text = row("estado")
                .txtcodProvee.Text = row("codBreveProveedor")
                .txtNombreProvee.Text = row("nombreProveedor")
                .txtBanco.Text = row("codBreveBanco")
                .txtNroCtaBanco.Text = row2("nroCtaBanco")
                .txtnombreBanco.Text = row("nombreBanco")
                .dtpAcredita.Value = row("fechaacreditacion")
                .dtpRechazo.Value = row("fechaRechazo")
                .dtpEmision.Value = row("fechaEmision")
                .dtpCancelado.Value = row("fechaCancelado")
                .txtCtaOrigen.Text = row("ctaOrigen")
                .txtCtaDestino.Text = row("ctaDestino")
                .txtCtaTemporal.Text = row("ctaTemporal")
                .lblForm.Text = "ChequeSeleccionado"
                .Show()

            End With

        Catch ex As Exception
            MsgBox("Error al seleccionar. Detalle: " + ex.Message)
        End Try

    End Sub

End Class