Public Class A_ListadoCentroCosto

    Dim objcc As New ClsCentroCostos


    Private Sub A_ListadoCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dgvListado)
            Dim dt As New DataTable
            Dim row As DataRow

            dt = objcc.ListarCentrodeCosto

            For i = 0 To dt.Rows.Count - 1

                row = dt.Rows(i)

                dgvListado.Rows.Add(CStr(row("id_centrocosto")), row("codBreve"), row("nombre"))

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick

        Try
            Dim codigo, nombre As String
            codigo = dgvListado.Rows(e.RowIndex).Cells(0).Value
            nombre = dgvListado.Rows(e.RowIndex).Cells(1).Value
            If lblform.Text = "FacturaCompra" Then
                With A_FacturaCompras

                    .dtDetalleFactura.Rows(Convert.ToInt32(.lblFila.Text)).Cells(6).Value = codigo

                    .dtDetalleFactura.Rows(Convert.ToInt32(.lblFila.Text)).Cells(2).Value = nombre
                    Me.Close()

                End With

            ElseIf lblform.Text = "Asiento" Then

                With frmAsientos

                    .dtDetalleAsiento.Rows(Convert.ToInt32(.lblfila.Text)).Cells(5).Value = codigo

                    .dtDetalleAsiento.Rows(Convert.ToInt32(.lblfila.Text)).Cells(6).Value = nombre
                    Me.Close()

                End With


            End If

        Catch ex As Exception

        End Try




    End Sub

    Private Sub A_ListadoCentroCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar ESC para cerrar ventana
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class