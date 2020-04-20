Public Class M_InicioSesion
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click

        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub M_InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinEngine1.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Sports\SportsBlue.ssk"

    End Sub
End Class