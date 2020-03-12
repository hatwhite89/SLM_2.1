Public Class A_Bitacora

    Dim Bitacora As New ClsBitacora
    Private Sub A_Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            dtBitacora.DataSource = Bitacora.listarBitacora

        Catch ex As Exception

        End Try


    End Sub
End Class