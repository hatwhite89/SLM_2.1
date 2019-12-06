﻿Public Class M_BuscarCotizacion
    Private Sub M_BuscarCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCot As New ClsCotizacion
        Dim dv As DataView = objCot.SeleccionarCotizacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea crear la factura de la cotización?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                M_Factura.limpiar()
                M_Factura.txtcodigoCliente.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()

                Dim objCotFact As New ClsCotizacionFactura
                Dim dt As New DataTable
                objCotFact.numeroCotizacion_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                dt = objCotFact.BuscarCotizacionFactura()
                Dim row As DataRow
                'dgblistadoExamenes.Rows(Index).Cells(0).Value()
                For index As Integer = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    M_Factura.dgblistadoExamenes.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("cantidad")), CStr(row("precio")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal"))})
                    M_ClienteVentana.dgvtabla.Rows.Add(New String() {CStr(row("codigoExamen")), CStr(row("cantidad")), CStr(row("precio")), CStr(row("descripcion")), CStr(row("fechaEntrega")), CStr(row("descuento")), CStr(row("subtotal"))})
                Next
                Me.Close()
                M_Factura.ShowDialog()

            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroB.TextChanged
        If (txtnumeroB.Text <> "") Then
            Try
                Dim objCot As New ClsCotizacion
                objCot.numero_ = txtnumeroB.Text
                Dim dv As DataView = objCot.BuscarCotizacion.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la cotización.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtnumeroB.Text = ""
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        M_Factura.limpiar()
        M_Factura.deshabilitar()
        M_Factura.HabilitarCotizacionFactura()
        M_Factura.ShowDialog()
    End Sub
End Class