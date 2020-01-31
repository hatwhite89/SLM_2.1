Public Class A_ListarPagos

    Dim pagos As New ClsPago

    Private Sub A_ListarPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_ListarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar listado de pagos
        Try
            dtPagos.DataSource = pagos.listarPagos

        Catch ex As Exception
            MsgBox("Error al cargar listado de Pagos. Error: " + ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmPagos.Show()
        Me.Close()

    End Sub

    Private Sub dtPagos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPagos.CellDoubleClick
        'Cargar datos de fila seleccionada en formulario Pagos


        Try
            Dim dt As New DataTable
            dt = dtPagos.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)

            frmPagos.txtNro.Text = row("codPago")
            frmPagos.txtFormaP.Text = row("formapago")
            frmPagos.txtReferencia.Text = row("referencia")
            frmPagos.txtComentario.Text = row("comentario")
            frmPagos.dtpFechaP.Value = row("fechaPago")
            frmPagos.txtCtaBanco.Text = row("ctaBanco")
            frmPagos.dtpFechaT.Value = row("fechaTransferencia")
            frmPagos.chkPagado.Checked = row("pagado")
            frmPagos.txtCodOrden.Text = row("codOrden")
            frmPagos.lblTotalSuma.Text = row("sumaTotal")

            'Listar detalle de pago
            frmPagos.dtDetallePagos.Enabled = True
            'mostrar detalle de factura
            Dim dpago As New ClsDetallePago
            Dim dtpago As New DataTable

            dpago.Cod_Pago = row("codPago")

            dtpago = dpago.listarDetallePago

            For Index As Integer = 0 To dtpago.Rows.Count - 1
                Dim row2 As DataRow = dtpago.Rows(Index)
                frmPagos.dtDetallePagos.Rows.Add(New String() {(row2("codproveedor")), CStr(row2("nombreproveedor")), CStr(row2("moneda")), CStr(row2("monto")), CStr(row2("formapago")), CStr(row2("nrocheque"))})
            Next

            frmPagos.Show()

        Catch ex As Exception
            MsgBox("Hubo un error al cargar la información del pago seleccionado. Detalle: " + ex.Message)
        End Try

        Me.Close()

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try

            If txtBusqueda.Text <> "" Then

                pagos.Cod_Pago = Convert.ToInt32(txtBusqueda.Text)
                dtPagos.DataSource = pagos.buscarPago

            ElseIf txtBusqueda.Text = "" Then

                dtPagos.DataSource = pagos.listarPagos

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelarBusqueda_Click(sender As Object, e As EventArgs) Handles btnCancelarBusqueda.Click
        dtPagos.DataSource = pagos.listarPagos
    End Sub


End Class