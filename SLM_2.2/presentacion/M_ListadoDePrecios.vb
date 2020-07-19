Public Class M_ListadoDePrecios
    Dim objListPrice As New ClsListaPrecios
    Private Sub M_ListadoDePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarListaPrecios()
        txtCodigoBreve.Text = ""
        txtDescripcion.Text = ""
        Me.dgbtabla.Columns("codigo").Visible = False
    End Sub
    Private Sub seleccionarListaPrecios()
        Dim dv As DataView = objListPrice.SeleccionarListaPrecios.DefaultView
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
                n = MsgBox("¿Desea utilizar la lista de precio que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes And lblForm.Text = "Precio" Then
                M_Precio.lblCode.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            ElseIf n = vbYes And lblForm.Text = "Categoria" Then
                M_Categoria.lblCodePriceList.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        If (Trim(txtDescripcion.Text) <> "") Then
            Try
                objListPrice.descripcion_ = txtDescripcion.Text
                Dim dv As DataView = objListPrice.BuscarListaPrecios.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarListaPrecios()
        End If
    End Sub

    Private Sub txtCodigoBreve_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoBreve.TextChanged
        If (Trim(txtCodigoBreve.Text) <> "") Then
            Try
                objListPrice.codigoBreve_ = txtCodigoBreve.Text
                Dim dv As DataView = objListPrice.BuscarListaPreciosCode.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarListaPrecios()
        End If
    End Sub

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        M_ListaPrecios.limpiar()
        M_ListaPrecios.ShowDialog()
    End Sub
End Class