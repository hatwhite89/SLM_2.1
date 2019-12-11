Public Class M_BuscarExamen
    Private Sub M_BuscarExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objExam As New ClsExamen
        Dim dv As DataView = objExam.SeleccionarExamen.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        If (txtnombreB.Text <> "") Then
            Dim objExam As New ClsExamen
            objExam.descripcion_ = txtnombreB.Text
            Dim dv As DataView = objExam.BuscarExamenDescripcion.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            Dim code As Integer
            Dim precio As Double
            Dim descrip As String
            Dim fechaHoy As Date = Date.Now

            code = Convert.ToInt32(dgbtabla.Rows(e.RowIndex).Cells(0).Value())
            descrip = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            precio = Convert.ToDouble(dgbtabla.Rows(e.RowIndex).Cells(2).Value())

            Dim n As String = MsgBox("¿Desea agregar el examen a la factura?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes And M_Factura.validarFactura2(code) = 0 Then
                M_Factura.dgblistadoExamenes.Rows.Add(New String() {code, "1", precio, descrip, fechaHoy.Date.AddDays(7), "0", precio})
                M_ClienteVentana.dgvtabla.Rows.Add(New String() {code, "1", precio, descrip, fechaHoy.Date.AddDays(7), "0", precio})
                M_Factura.totalFactura()
                Me.Close()
            Else
                MsgBox("El examen ya a sido registrado en la factura.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class