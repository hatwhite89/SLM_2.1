Module Module1
    Public nombre_proveedorOC As String
    Public nombre_usurio As String
    Public codigo_usuario As String
    Public codigo_requisicion As String
    Public codigo_orden_interna As String
    Public nombre_completo As String
    Public departamento_global As String
    Public id_departamento_global As String
    Public cod_proveedor As String
    Public codigo_oc As String

    Public Sub CargarDatosGlobales()
        Try
            Dim objP As New ClsUsuario

            Dim dt As New DataTable
            dt = objP.RecuperarUsuariosGlobales
            Dim row As DataRow = dt.Rows(0)
            nombre_completo = CStr(row("nombreCompleto"))
            departamento_global = CStr(row("nombre"))
            id_departamento_global = CStr(row("codigo"))

        Catch ex As Exception

        End Try
    End Sub

    Function GridAExcel_global(ByVal miDataGridView As DataGridView) As Boolean
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
End Module
