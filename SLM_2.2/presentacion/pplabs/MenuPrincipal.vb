Public Class MenuPrincipal
    Private Sub UI_ButtonMaterial1_Click(sender As Object, e As EventArgs) Handles UI_ButtonMaterial1.Click
        Try

            Listado_Citologia.Show()
            Listado_Citologia.BringToFront()
            Listado_Citologia.WindowState = WindowState.Normal

        Catch ex As Exception

        End Try
    End Sub
End Class