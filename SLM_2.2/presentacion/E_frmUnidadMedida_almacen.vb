Public Class E_frmUnidadMedida_almacen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsUM As New ClsUnidadMedidaAlmacen

        With clsUM
            .NombreUnidadMedida = txtNombre.Text
            .DescripcionUnidadMedida = txtDescripcion.Text
        End With

        If clsUM.RegistrarUnidadMedida() = "1" Then
            MsgBox("Registrado exitosamente")
        End If
    End Sub

    Private Sub E_frmUnidadMedida_almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TableUM As New DataTable
        Dim clsUM As New ClsUnidadMedidaAlmacen
        TableUM.Load(clsUM.RecuperarUnidadMedida())

        DataGridView1.DataSource = TableUM

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtNombre.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString()
        txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
        txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString()
    End Sub
End Class