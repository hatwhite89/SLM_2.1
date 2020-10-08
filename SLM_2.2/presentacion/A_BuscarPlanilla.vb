Public Class A_BuscarPlanilla
    Dim objPlan As New ClsPlanilla
    Dim objDetPlan As New ClsDetallePlanilla
    Dim dv As DataView = objPlan.SeleccionarPlanilla.DefaultView
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        A_Planilla.limpiar()
        A_Planilla.ShowDialog()
    End Sub
    Public Sub seleccionarPlanilla()
        dv = objPlan.SeleccionarPlanilla.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub M_BuscarCapacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarPlanilla()

        'CAMBIO DE NOMBRE COLUMNAS
        dgbtabla.Columns("codPlanilla").HeaderText = "Código"
        dgbtabla.Columns("codigoBreve").HeaderText = "Código Breve"
        dgbtabla.Columns("descripcion").HeaderText = "Descripción"
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionB.TextChanged
        dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtDescripcionB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la planilla.", MsgBoxStyle.Exclamation)
            txtDescripcionB.Text = ""
            seleccionarPlanilla()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            If lblform.Text = "A_BuscarPlanilla" Then
                Dim n As String = ""
                'Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea actualizar la capacitación que a seleccionado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'Llenado campos de capacitacion
                    A_Planilla.txtCodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    A_Planilla.txtCodigoBreve.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    A_Planilla.txtDescripcion.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()

                    objDetPlan.codPlanilla_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dt = objDetPlan.BuscarDetallePlanilla()
                    For index As Integer = 0 To dt.Rows.Count - 1
                        'Llenado beneficiarios
                        row = dt.Rows(index)
                        A_Planilla.dgvEmpleados.Rows.Add(New String() {CStr(row("codDetPlanilla")), CStr(row("codEmpleado")), CStr(row("nombreCompleto")), CStr(row("puestoTrabajo")), CStr(row("Departamento"))})
                    Next
                End If
                A_Planilla.btnGuardar.Enabled = False
                A_Planilla.btnModificar.Enabled = True
                A_Planilla.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class