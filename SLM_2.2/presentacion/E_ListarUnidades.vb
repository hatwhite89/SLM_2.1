Public Class E_ListarUnidades
    Private Sub E_ListarUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarUnidades()
        txtCodigoB.Text = ""
        txtDescripcionB.Text = ""
        Me.dgbtabla.Columns("codigo").Visible = False
        Me.dgbtabla.Columns("factorCantidad").Visible = False
    End Sub
    Public Sub seleccionarUnidades()
        Dim objUnit As New ClsUnidad
        Dim dv As DataView = objUnit.SeleccionarUnidad.DefaultView
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
                n = MsgBox("¿Desea utilizar la unidad seleccionada?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes And lblbandera.Text = 1 Then
                E_DetalleExamenes.dtResultados.Rows.Remove(E_DetalleExamenes.dtResultados.Rows(Convert.ToInt64(lblFila.Text)))
                E_DetalleExamenes.dtResultados.Rows.Insert(Convert.ToInt64(lblFila.Text), New String() {"", lblNombre.Text, dgbtabla.Rows(e.RowIndex).Cells(0).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value()})
                Me.Close()
            ElseIf n = vbYes And lblbandera.Text = 0 Then
                E_DetalleExamenes.dtResultados.Rows.Remove(E_DetalleExamenes.dtResultados.Rows(Convert.ToInt64(lblFila.Text)))
                E_DetalleExamenes.dtResultados.Rows.Insert(Convert.ToInt64(lblFila.Text), New String() {lblcodeItemExamenDet.Text, lblNombre.Text, dgbtabla.Rows(e.RowIndex).Cells(0).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value()})
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionB.TextChanged
        If (txtDescripcionB.Text <> "") Then
            Try
                Dim objUnit As New ClsUnidad
                objUnit.comentario_ = txtDescripcionB.Text
                Dim dv As DataView = objUnit.BuscarUnidadComment.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarUnidades()
        End If
    End Sub

    Private Sub txtCodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        If (txtCodigoB.Text <> "") Then
            Try
                Dim objUnit As New ClsUnidad
                objUnit.codigoUnidad_ = txtCodigoB.Text
                Dim dv As DataView = objUnit.BuscarUnidad.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarUnidades()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcel_global(dgbtabla)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        E_Unidad.Show()
    End Sub
End Class