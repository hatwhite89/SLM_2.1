Public Class E_ListarOrdenesDeTrabajo
    Dim objOrd As New ClsOrdenDeTrabajo
    Dim dv As DataView = objOrd.SeleccionarOrdenDeTrabajo.DefaultView
    Private Sub E_ListarOrdenesDeTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarOrdenesTrabajo()
        txtCodigoB.Text = ""
        txtDescripcionB.Text = ""
    End Sub

    Private Sub seleccionarOrdenesTrabajo()
        dv = objOrd.SeleccionarOrdenDeTrabajo.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub txtCodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        If Trim(txtCodigoB.Text) <> "" Then
            'dv.RowFilter = String.Format("cod_orden_trabajo Like '%{" & txtCodigoB.Text & "}%'")
            dv.RowFilter = String.Format("CONVERT(cod_orden_trabajo, System.String) LIKE '%{0}%'", txtCodigoB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

            If lblcantidad.Text = "0" Then
                MsgBox("No existe la orden de trabajo.", MsgBoxStyle.Exclamation)
                txtCodigoB.Text = ""
                seleccionarOrdenesTrabajo()
            End If
        Else
            seleccionarOrdenesTrabajo()
        End If

    End Sub

    Private Sub txtDescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionB.TextChanged
        If Trim(txtDescripcionB.Text) <> "" Then
            dv.RowFilter = String.Format("nombreCompleto Like '%{0}%'", txtDescripcionB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

            If lblcantidad.Text = "0" Then
                MsgBox("No existe la orden de trabajo.", MsgBoxStyle.Exclamation)
                txtDescripcionB.Text = ""
                seleccionarOrdenesTrabajo()
            End If
        Else
            seleccionarOrdenesTrabajo()
        End If
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
                n = MsgBox("¿Desea ver la orden de trabajo seleccionada?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                E_OrdenTrabajo.cargarOrdenTrabajo(Convert.ToInt64(dgbtabla.Rows(e.RowIndex).Cells(0).Value()))
                E_OrdenTrabajo.ShowDialog()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class