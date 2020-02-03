Public Class M_ClienteVentana
    Dim objPromo As New ClsPromociones
    Dim dt As New DataTable
    Dim cont As Integer = 0
    Dim row As DataRow
    Private Sub M_ClienteVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Start()

        Try
            dt = objPromo.ListarPromociones
            row = dt.Rows(cont)
            If IsDBNull(row("imagen")) = False Then
                pbxImagenes.Load(row("imagen"))
                cont += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "Cliente")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If (cont < dt.Rows.Count - 1) Then
                row = dt.Rows(cont)
                cont += 1
                'MsgBox(cont & "     " & dt.Rows.Count)
                If IsDBNull(row("imagen")) = False Then
                    pbxImagenes.Load(row("imagen"))
                End If
            Else
                cont = 0
                row = dt.Rows(cont)
                cont += 1
                'MsgBox(cont & "     " & dt.Rows.Count)
                If IsDBNull(row("imagen")) = False Then
                    pbxImagenes.Load(row("imagen"))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class