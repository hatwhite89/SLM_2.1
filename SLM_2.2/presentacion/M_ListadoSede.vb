Public Class M_ListadoSede
    Dim objSede As New ClsSede
    Private Sub M_ListadoSede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarSede()
        txtCodigoB.Text = ""
        txtNombreB.Text = ""
        Me.dgbtabla.Columns("direccion1").Visible = False
        Me.dgbtabla.Columns("direccion2").Visible = False
        Me.dgbtabla.Columns("direccion3").Visible = False
        Me.dgbtabla.Columns("direccion4").Visible = False
        Me.dgbtabla.Columns("contacto").Visible = False
        Me.dgbtabla.Columns("correo").Visible = False
        Me.dgbtabla.Columns("telefono").Visible = False
    End Sub
    Private Sub seleccionarSede()
        Dim dv As DataView = objSede.SeleccionarSede.DefaultView
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
                n = MsgBox("¿Desea utilizar la Sede que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                M_Factura.txtcodigoSede.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        If (txtNombreB.Text <> "") Then
            Try
                objSede.Nombre1 = txtNombreB.Text
                Dim dv As DataView = objSede.BuscarSede.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarSede()
        End If
    End Sub

    Private Sub txtCodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        If (txtCodigoB.Text <> "") Then
            Try
                objSede.Codigo1 = txtCodigoB.Text
                Dim dv As DataView = objSede.BuscarSedeCode.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarSede()
        End If
    End Sub

End Class