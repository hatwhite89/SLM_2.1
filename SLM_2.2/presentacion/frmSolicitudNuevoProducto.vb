Public Class frmSolicitudNuevoProducto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clsR As New ClsRequisicion
        Dim tipo_compra As String = ""
        If RadioButton1.Checked = True Then
            tipo_compra = "Urgente"
        End If
        If RadioButton2.Checked = True Then
            tipo_compra = "Normal"
        End If
        With clsR
            .Descripcion1 = txtDescripcion.Text
            .Cod_usuario1 = codigo_usuario
            .Tipo_compra1 = tipo_compra
        End With

        If clsR.RegistrarRequisicion() = "1" Then
            MsgBox("Se ha enviado la solicitud de requisicion")
            Button2.Enabled = False
            txtDescripcion.Text = ""
            RadioButton2.Checked = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim clsOCOB As New ClsRequisicion
            Dim dvOC As DataView = clsOCOB.RecuperarRequisicionFechas(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date).DefaultView
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtDescripcion.Text = ""
        Button2.Enabled = True
    End Sub

    Private Sub frmSolicitudNuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        txtCodUsuario.Text = nombre_usurio
        Label13.Text = ""
        Label12.Text = ""
        Label14.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            codigo_requisicion = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim objP As New ClsRequisicion

            Dim dt As New DataTable
            dt = objP.RecuperarRequisicionCodigo(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Dim row As DataRow = dt.Rows(0)
            Label14.Text = CStr(row("estado"))
            Label12.Text = CStr(row("usuario_aprobo"))
            RichTextBox1.Text = CStr(row("comentario_rechazo"))
            RichTextBox2.Text = CStr(row("descripcion"))
            Label13.Text = CStr(row("fecha_autorizacion"))

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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        reporteRequisicion.Show()
    End Sub
End Class