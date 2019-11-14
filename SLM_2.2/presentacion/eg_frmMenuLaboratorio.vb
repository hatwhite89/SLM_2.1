Public Class eg_frmMenuLaboratorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eg_frmPaciente.MdiParent = Me

        eg_frmPaciente.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListarDepositos.MdiParent = Me
        ListarDepositos.Show()
    End Sub
End Class