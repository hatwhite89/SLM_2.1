Public Class AA_Guardado
    Private Sub AA_Guardado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            timerAparecer.Start()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerAparecer_Tick(sender As Object, e As EventArgs) Handles timerAparecer.Tick
        While Me.Opacity > 0

            For i = 0 To 1
                timerAparecer.Stop()
                i += 1
            Next

            timerAparecer.Start()

            Me.Opacity -= 0.0003




        End While

        Me.Close()
    End Sub
End Class