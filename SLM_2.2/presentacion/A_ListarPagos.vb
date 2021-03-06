﻿Public Class A_ListarPagos

    Dim pagos As New ClsPago

    Private Sub A_ListarPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_ListarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar listado de pagos
        alternarColoFilasDatagridview(dtPagos)
        Try
            dtPagos.DataSource = pagos.LISTARPAGOS

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


            If dt.Columns.Contains("codPago") = True Then

                frmPagos.txtNro.Text = dtPagos.Rows(e.RowIndex).Cells(0).Value
                frmPagos.lblCodFormaPago.Text = dtPagos.Rows(e.RowIndex).Cells(1).Value
                frmPagos.txtReferencia.Text = dtPagos.Rows(e.RowIndex).Cells(2).Value
                frmPagos.txtComentario.Text = dtPagos.Rows(e.RowIndex).Cells(3).Value
                frmPagos.dtpFechaP.Value = dtPagos.Rows(e.RowIndex).Cells(4).Value
                frmPagos.dtpFechaT.Value = dtPagos.Rows(e.RowIndex).Cells(5).Value
                frmPagos.chkPagado.Checked = dtPagos.Rows(e.RowIndex).Cells(6).Value
                frmPagos.lblTotalSuma.Text = dtPagos.Rows(e.RowIndex).Cells(7).Value
                'frmPagos.txtNro.Text = row("codPago")
                'frmPagos.lblCodFormaPago.Text = row("codformapago")
                'frmPagos.txtReferencia.Text = row("referencia")
                'frmPagos.txtComentario.Text = row("comentario")
                'frmPagos.dtpFechaP.Value = row("fechaPago")
                'frmPagos.dtpFechaT.Value = row("fechaTransferencia")
                'frmPagos.chkPagado.Checked = row("pagado")
                'frmPagos.lblTotalSuma.Text = row("sumaTotal")

                ''data formapago
                Dim dtfp As New DataTable
                Dim rowfp As DataRow
                Dim formapago As New ClsFormaPago

                formapago.Codigo_FormaPago = Integer.Parse(row("codformapago"))
                dtfp = formapago.BusquedaFormaPago
                rowfp = dtfp.Rows(0)
                frmPagos.txtFormaP.Text = rowfp("codigo")
                frmPagos.txtCtaBanco.Text = rowfp("nroCtaBanco")
                frmPagos.lblNombreBanco.Text = rowfp("banco")

                'Listar detalle de pago
                frmPagos.dtDetallePagos.Enabled = True
                ''mostrar detalle de factura
                Dim dpago As New ClsDetallePago
                Dim dtpago As New DataTable

                dpago.Cod_Pago = row("codPago")

                dtpago = dpago.listarDetallePago

                'informacion de proveedor de factura
                Dim rowprove As DataRow = dtpago.Rows(0)
                Dim facturacompra As New ClsFacturaCompra

                facturacompra.Cod_Factura = Integer.Parse(rowprove("codFactura"))

                Dim dtfact As New DataTable
                dtfact = facturacompra.comprobarFactura()
                rowprove = dtfact.Rows(0)

                frmPagos.lblCodigoProveedor.Text = rowprove("codProveedor").ToString

                For Index As Integer = 0 To dtpago.Rows.Count - 1
                    Dim row2 As DataRow = dtpago.Rows(Index)
                    frmPagos.dtDetallePagos.Rows.Add(New String() {(row2("codFactura")), CStr(row2("nombreproveedor")), CStr(row2("moneda")), CStr(row2("monto")), CStr(row2("formapago")), CStr(row2("nrocheque")), CStr(row2("codDetalle"))})
                Next

                frmPagos.Show()
            End If
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

                dtPagos.DataSource = pagos.listarSinPago

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelarBusqueda_Click(sender As Object, e As EventArgs) Handles btnCancelarBusqueda.Click
        dtPagos.DataSource = pagos.listarSinPago
    End Sub


    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged

        Try
            If ComboBox1.Text = "Sin pago" Then

                dtPagos.DataSource = pagos.listarSinPago

            ElseIf ComboBox1.Text = "Pagados" Then

                dtPagos.DataSource = pagos.listarPagosOk

            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class