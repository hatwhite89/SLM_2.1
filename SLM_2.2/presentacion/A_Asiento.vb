Public Class frmAsientos
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Cerrar Ventana de Asientos
        Me.Close()

    End Sub

    Private Sub frmAsientos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim Detalle As New ClsDetalleAsiento

            With Detalle


                .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)

                Dim dt As DataTable
                Dim row As DataRow

                dt = .VerDetalleAsiento
                row = dt.Rows(0)

                dtDetalleAsiento.Rows(0).Cells(0).Value = row("cuenta")
                dtDetalleAsiento.Rows(0).Cells(2).Value = row("debe")
                dtDetalleAsiento.Rows(0).Cells(3).Value = row("haber")

            End With

        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
        End Try





    End Sub
End Class