Public Class E_ListarSubAreasXArea
    Dim objSubA As New ClsSubArea
    Private Sub E_ListarSubAreasXArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            seleccionarSubArea()
            Me.dgbtabla.Columns("Formulario").Visible = False
            Me.dgbtabla.Columns("secImpresion").Visible = False
            Me.dgbtabla.Columns("noSolicitarSucursal").Visible = False
            Me.dgbtabla.Columns("formularioConsolidado").Visible = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub seleccionarSubArea()
        Try
            objSubA.codigoArea_ = Convert.ToInt64(lblcodeArea.Text)
            Dim dv As DataView = objSubA.BuscarSubAreaXArea.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblform.Text = "E_DetalleExamenes" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la subárea seleccionada?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    E_DetalleExamenes.txtCodigoSubArea.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    E_DetalleExamenes.lblcodeSubGrupo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class