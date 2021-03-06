Public Class Citologia

    Dim objcitologia As New ClsCitologia


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            M_BuscarFactura.Show()
            M_BuscarFactura.BringToFront()
            M_BuscarFactura.WindowState = WindowState.Normal

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        With objcitologia



        End With







    End Sub
End Class