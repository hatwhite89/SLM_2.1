Public Class E_MenuLaboratorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        E_Paciente.MdiParent = Me

        E_Paciente.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ListarDepositos.MdiParent = Me
        'ListarDepositos.Show()
    End Sub
End Class