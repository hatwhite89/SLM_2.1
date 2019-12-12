﻿Public Class A_ListarPagos

    Dim pagos As New ClsPago

    Private Sub A_ListarPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_ListarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar listado de pagos


        dtPagos.DataSource = pagos.listarPagos

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

            frmPagos.Show()

        Catch ex As Exception
            MsgBox("Hubo un error al cargar la información. Detalle: " + ex.Message)
        End Try

        Me.Close()
    End Sub
End Class