Public Class A_CategoriaProveedor

    Dim Categoria As New ClsCategoriaProveedor
    Private Sub A_CategoriaProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub


End Class