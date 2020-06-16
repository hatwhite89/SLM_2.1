Public Class E_HojaTrabajo
    Private Sub E_HojaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgvHojaTrab)
        txtHora.Text = Date.Now.ToLongTimeString
        txtFecha.Text = Date.Today
    End Sub

End Class