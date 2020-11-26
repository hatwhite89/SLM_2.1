Public Class M_BuscarCapacitaciones
    Dim objCap As New ClsCapacitaciones
    Dim dv As DataView = objCap.SeleccionarCapacitaciones.DefaultView
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        M_Capacitaciones.limpiar()
        M_Capacitaciones.ShowDialog()
    End Sub
    Public Sub SeleccionarCapacitaciones()
        dv = objCap.SeleccionarCapacitaciones.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count

    End Sub

    Private Sub M_BuscarCapacitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarCapacitaciones()
        alternarColoFilasDatagridview(dgbtabla)
        'CAMBIO DE NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("fecha").HeaderText = "Fecha Capacitación"
        dgbtabla.Columns("nombre").HeaderText = "Nombre"
        dgbtabla.Columns("cantidadHoras").HeaderText = "Cantidad de Horas"
        dgbtabla.Columns("proveedor").HeaderText = "Proveedor"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        objCap.desde_ = dtpDesde.Value
        objCap.hasta_ = dtpHasta.Value
        dv = objCap.BuscarCapacitacionPorFechas.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count

    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        dv.RowFilter = String.Format("nombre Like '%{0}%'", txtnombreB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la capacitación.", MsgBoxStyle.Exclamation)
            txtnombreB.Text = ""
            SeleccionarCapacitaciones()
        End If
    End Sub

    Private Sub txtProveedorB_TextChanged(sender As Object, e As EventArgs) Handles txtProveedorB.TextChanged
        dv.RowFilter = String.Format("proveedor Like '%{0}%'", txtProveedorB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la capacitación.", MsgBoxStyle.Exclamation)
            txtProveedorB.Text = ""
            SeleccionarCapacitaciones()
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim dt As New DataTable
            Dim row As DataRow
            If lblform.Text = "M_BuscarCapacitaciones" Then
                Dim n As String = ""
                'Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea actualizar la capacitación que a seleccionado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'Llenado campos de capacitacion
                    M_Capacitaciones.txtCodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Capacitaciones.dtpFecha.Value = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    M_Capacitaciones.txtNombre.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    M_Capacitaciones.txtCantidadHoras.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                    M_Capacitaciones.txtProveedor.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                    Dim objDetFact As New ClsDetalleCapacitaciones
                    objDetFact.codigoCapacitacion_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dt = objDetFact.BuscarDetalleCapacitacion()
                    For index As Integer = 0 To dt.Rows.Count - 1
                        'Llenado beneficiarios
                        row = dt.Rows(index)
                        M_Capacitaciones.dgvBeneficiarios.Rows.Add(New String() {CStr(row("codigo")), CStr(row("codigoEmpleado")), CStr(row("nombreCompleto")), CStr(row("puestoTrabajo")), CStr(row("Departamento"))})
                    Next
                End If
                M_Capacitaciones.btnguardar.Enabled = False
                M_Capacitaciones.btnmodificar.Enabled = True
                M_Capacitaciones.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Function GridAExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add 'crea el libro de excel 
            exHoja = exLibro.Worksheets.Add() 'cuenta filas y columnas
            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1 'titulo en negritas
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            'alineacion al centro
            exHoja.Columns.AutoFit() 'autoajuste de la columna
            exHoja.Columns.HorizontalAlignment = 2
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(dgbtabla)
    End Sub
End Class