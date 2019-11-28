Public Class E_ParametroExamen
    Private Sub eg_frmParametroExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmb As New DataGridViewComboBoxColumn()
        dgbtabla.Columns.Add(cmb)
        cmb.HeaderText = "Val. Por Defecto"
        cmb.Items.Add("No")
        cmb.Items.Add("Si")
        cmb.Name = "cbx"

        Dim btn As New DataGridViewButtonColumn()
        dgbtabla.Columns.Add(btn)
        btn.HeaderText = "Eliminar"
        btn.Text = "Eliminar"
        btn.Name = "btnEliminar"
        btn.UseColumnTextForButtonValue = True
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub dgbtabla_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        If e.ColumnIndex = 2 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar el posible resultado?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub dgbtabla_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbtabla.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                If (Trim(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) <> "") Then
                    Dim posibleRes As String = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                    dgbtabla.Rows.Insert(e.RowIndex.ToString, New String() {posibleRes, "No"})
                Else
                    MsgBox("Debe ingresar un posible resultado.", MsgBoxStyle.Critical)
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                End If
            ElseIf e.ColumnIndex = 1 Then
                If (Trim(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) = "") Then
                    MsgBox("Debe ingresar un posible resultado.", MsgBoxStyle.Critical)
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class