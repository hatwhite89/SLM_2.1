Public Class M_ListarMedicos
    Dim objMed As New ClsMedico
    Private Sub M_ListarMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarMedicos()
        txtNombreB.Text = ""
        Me.dgbtabla.Columns("codigo_especialidad").Visible = False
        Me.dgbtabla.Columns("correo").Visible = False
        Me.dgbtabla.Columns("correo2").Visible = False
        Me.dgbtabla.Columns("telefono").Visible = False
        Me.dgbtabla.Columns("celular").Visible = False
    End Sub
    Private Sub seleccionarMedicos()
        Dim dv As DataView = objMed.SeleccionarMedico.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea utilizar el médico en la factura?", MsgBoxStyle.YesNo)
            End If
            If n = vbYes Then
                M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        If (txtNombreB.Text <> "") Then
            Try
                objMed.Nombre_completo1 = txtNombreB.Text
                Dim dv As DataView = objMed.BuscarMedico.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarMedicos()
        End If
    End Sub

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        Me.Hide()
        M_Medico.ShowDialog()
        Me.Close()
    End Sub
End Class