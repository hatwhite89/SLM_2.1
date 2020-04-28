Public Class E_frmUnidadMedida_almacen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsUM As New ClsUnidadMedidaAlmacen

        With clsUM
            .IdUnidadMedida = Integer.Parse(txtCodigo.Text)
            .NombreUnidadMedida = txtNombre.Text
            .DescripcionUnidadMedida = txtDescripcion.Text
        End With
        If txtCodigo.Text = "" Then
            If clsUM.RegistrarUnidadMedida() = "1" Then
                MsgBox("Registrado exitosamente")
                Button1.Enabled = False
                txtDescripcion.ReadOnly = True
                txtNombre.ReadOnly = True

            End If
        ElseIf txtCodigo.Text <> "" Then

            If clsUM.ActualizarUnidadMedida() = "1" Then

                MsgBox("Actualizado exitosamente")

            End If
            Exit Sub
        End If

    End Sub

    Private Sub E_frmUnidadMedida_almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TableUM As New DataTable
        Dim clsUM As New ClsUnidadMedidaAlmacen
        TableUM.Load(clsUM.RecuperarUnidadMedida())

        DataGridView1.DataSource = TableUM

        'campos
        txtDescripcion.ReadOnly = True
        txtNombre.ReadOnly = True
        'boton
        Button1.Enabled = False


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtNombre.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString()
        txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
        txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString()
        Button1.Enabled = True
        txtDescripcion.ReadOnly = False
        txtNombre.ReadOnly = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'campos
        txtDescripcion.ReadOnly = False
        txtNombre.ReadOnly = False

        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtCodigo.Text = ""
        Button1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'campos
        txtDescripcion.ReadOnly = True
        txtNombre.ReadOnly = True

        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtCodigo.Text = ""
        Button1.Enabled = False

    End Sub
End Class