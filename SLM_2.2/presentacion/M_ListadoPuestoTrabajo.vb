Public Class M_ListadoPuestoTrabajo

    Dim objPuesto As New ClsPuestoTrabajo
    Private Sub M_ListadoPuestoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarPuestoTrabajo()
        Me.dgbtabla.Columns("codigoDepto").Visible = False
    End Sub
    Private Sub seleccionarPuestoTrabajo()
        objPuesto.codigoDepto_ = Convert.ToInt64(lblcodeDepto.Text)
        Dim dv As DataView = objPuesto.BuscarPuestoTrabajoDepto.DefaultView
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
            If lblform.Text = "M_Empleados" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo seleccionado?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    M_Empleados.lblcodePuesto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Empleados.txtPuestoTrabajo.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class