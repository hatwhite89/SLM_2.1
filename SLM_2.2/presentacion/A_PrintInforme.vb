Public Class A_PrintInforme

    Private Sub A_PrintInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblform.Text = "Informe" Then

            A_Informes.ImprimirInformePeriodo()

        ElseIf lblform.Text = "InformePro" Then

            A_Candidatos.Informe()

        End If

    End Sub
End Class