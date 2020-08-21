Public Class E_ListarSubAreas

    'Objeto SubAreas
    Dim SubA As New ClsSubArea

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        E_SubArea.ShowDialog()
    End Sub

    Private Sub eg_frmListarSubAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar listado de Subareas
        dgbSubAreas.DataSource = SubA.listarSubAreas

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Cerrar formulario
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbSubAreas.CellMouseDoubleClick
        'Seleccionar subárea para ser utilizada en otro formulario
        Try
            If lblform.Text = "E_DetalleExamenes" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la subárea seleccionada?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    E_DetalleExamenes.txtCodigoSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(0).Value()
                    E_DetalleExamenes.lblcodeSubGrupo.Text = dgbSubAreas.Rows(e.RowIndex).Cells(0).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "E_EspecificarHojaTrabajo" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la subárea seleccionada?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    E_EspecificarHojaTrabajo.txtDescripcionSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(3).Value()
                    E_EspecificarHojaTrabajo.txtSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(1).Value()
                    E_EspecificarHojaTrabajo.lblCodeSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(0).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "informe" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la subárea seleccionada?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then

                    A_Informes.lblCodSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(0).Value()
                    A_Informes.txtSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(1).Value()
                    A_Informes.txtNombreSubArea.Text = dgbSubAreas.Rows(e.RowIndex).Cells(3).Value()

                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class