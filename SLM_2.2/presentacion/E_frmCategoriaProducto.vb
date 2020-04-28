Public Class E_frmCategoriaProducto
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim clsCP As New ClsCategoriaroducto
        With clsCP
            .NombreCategoriaProducto = txtNombre.Text
            .DescripcionCategoriaProducto = txtDescripcion.Text
        End With

        If clsCP.RegistrarCategoriaProducto() = "1" Then
            MsgBox("Registrado exitosamente")
        End If
    End Sub

    Private Sub E_frmCategoriaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class