Public Class M_ClienteVentana
    Dim objPromo As New ClsPromociones
    Dim dt As New DataTable
    Dim cont As Integer = 9
    Dim row As DataRow
    Private Sub M_ClienteVentana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000
        Timer1.Start()

        Try
            dt = objPromo.ListarPromociones
            row = dt.Rows(cont)
            If IsDBNull(row("img")) = False Then
                pbxImagenes.Image = BytesToImagen(row("img"))
                cont += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If (cont < dt.Rows.Count) Then
                row = dt.Rows(cont)
                If IsDBNull(row("img")) = False Then
                    pbxImagenes.Image = BytesToImagen(row("img"))
                    cont += 1
                End If
            Else
                cont = 0
                row = dt.Rows(cont)
                If IsDBNull(row("img")) = False Then
                    pbxImagenes.Image = BytesToImagen(row("img"))
                    cont += 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class