Public Class eg_frmPaciente
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    Private Sub eg_frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Paciente = New ClsPaciente

        Dim tbPaciente2 As DataTable
        tbPaciente2 = New DataTable
        tbPaciente2.Load(Paciente.RecuperaPacientes())
        tbPaciente.DataSource = tbPaciente2
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbPaciente.CellContentClick

    End Sub
End Class