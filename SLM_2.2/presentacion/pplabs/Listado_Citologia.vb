Public Class Listado_Citologia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Citologia.Show()
            Citologia.BringToFront()
            Citologia.WindowState = WindowState.Normal
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Listado_Citologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarData()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub llenarData()

        Dim cito As New ClsCitologia
        Dim dt As New DataTable
        Dim row As DataRow

        With cito

            dt = .LISTARREGISTROS

        End With

        For i = 0 To dt.Rows.Count - 1

            row = dt.Rows(i)

            dgvCitologia.Rows.Add(CStr(row("id_citologia")), CStr(row("numero_factura")), row("nombreCompleto"), row("nombreIdentificador"), row("nombre_completo"))

        Next

    End Sub
End Class