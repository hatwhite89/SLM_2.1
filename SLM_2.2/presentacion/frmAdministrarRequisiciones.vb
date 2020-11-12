Public Class frmAdministrarRequisiciones
    Private Sub frmAdministrarRequisiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim clsOCOB As New ClsRequisicion
            Dim dvOC As DataView = clsOCOB.RecuperarRequisicion().DefaultView
            DataGridView2.DataSource = dvOC
        Catch ex As Exception

        End Try
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)

        Label12.Text = ""
        Label13.Text = ""

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            txtCodRequi.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            Dim objP As New ClsRequisicion

            Dim dt As New DataTable
            dt = objP.RecuperarRequisicionCodigo(DataGridView2.Rows(e.RowIndex).Cells(0).Value)
            Dim row As DataRow = dt.Rows(0)

            txtPuesto.Text = CStr(row("puesto_usuario"))
            txtDepartamento.Text = CStr(row("departamento_usuario"))
            descripcion1.Text = CStr(row("descripcion"))
            txtFecha.Text = CStr(row("fecha_solicitud"))
            txtCodUsuario.Text = CStr(row("nombre_usuario"))

        Catch ex As Exception


        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged

    End Sub

    Public Sub limpiarData()
        txtCodRequi.Text = ""
        txtPuesto.Text = ""
        txtDepartamento.Text = ""
        descripcion1.Text = ""
        txtFecha.Text = ""
        txtCodUsuario.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsR As New ClsRequisicion
        If comentario1.Text = "" Then
            MsgBox("Debe asignar un comentario para poder aprobar o rechazar")
            Exit Sub
        End If
        With clsR
            .Cod_requi1 = txtCodRequi.Text
            .Comentario_rechazo1 = comentario1.Text
            .Usuario_aprobo1 = codigo_usuario
        End With

        If clsR.AprobarRequisicion() = "1" Then
            MsgBox("Usted acaba de aprobar la requisicion " + txtCodRequi.Text)
            Try
                Dim clsOCOB As New ClsRequisicion
                Dim dvOC As DataView = clsOCOB.RecuperarRequisicion().DefaultView
                DataGridView2.DataSource = dvOC
                limpiarData()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If comentario1.Text = "" Then
            MsgBox("Debe asignar un comentario para poder aprobar o rechazar")
            Exit Sub
        End If
        Dim clsR As New ClsRequisicion
        With clsR
            .Cod_requi1 = txtCodRequi.Text
            .Comentario_rechazo1 = comentario1.Text
            .Usuario_aprobo1 = codigo_usuario
        End With

        If clsR.RechazarRequisicion() = "1" Then
            MsgBox("Usted acaba de rechazar la requisicion " + txtCodRequi.Text)
            Try
                Dim clsOCOB As New ClsRequisicion
                Dim dvOC As DataView = clsOCOB.RecuperarRequisicion().DefaultView
                DataGridView2.DataSource = dvOC
                limpiarData()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim clsOCOB As New ClsRequisicion
            Dim dvOC As DataView = clsOCOB.RecuperarRequisicionFechasAutorizaciones(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date).DefaultView
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(DataGridView1)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reporteRequisicion.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            codigo_requisicion = DataGridView1.Rows(e.RowIndex).Cells(0).Value

        Catch ex As Exception


        End Try
    End Sub
End Class