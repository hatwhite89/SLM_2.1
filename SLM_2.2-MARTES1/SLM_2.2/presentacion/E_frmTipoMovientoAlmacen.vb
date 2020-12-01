Public Class E_frmTipoMovientoAlmacen
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNombre.ReadOnly = False
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtNombre.ReadOnly = True
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If txtCodigo.Text = "" Then
            Dim cls As New clsTipoMovimiento

            With cls
                .Nombre1 = txtNombre.Text
                .Descripcion1 = txtDescripcion.Text

            End With

            If cls.RegistrarTipoMovimiento() = "1" Then
                MsgBox("Registrado exitosamente")
                txtNombre.ReadOnly = True
                Button1.Enabled = True

                Try
                    Dim clsOCOB As New clsTipoMovimiento
                    Dim dvOC As DataView = clsOCOB.ListarMovimientos().DefaultView
                    DataGridView1.DataSource = dvOC
                Catch ex As Exception

                End Try
            End If
        End If
        If txtCodigo.Text <> "" Then
            Dim cls As New clsTipoMovimiento

            With cls
                .Id_tipo1 = Integer.Parse(txtCodigo.Text)
                .Nombre1 = txtNombre.Text
                .Descripcion1 = txtDescripcion.Text

            End With

            If cls.ActualizarTipoMovimiento = "1" Then
                MsgBox("Mofidicado exitosamente")

                Try
                    Dim clsOCOB As New clsTipoMovimiento
                    Dim dvOC As DataView = clsOCOB.ListarMovimientos().DefaultView
                    DataGridView1.DataSource = dvOC
                Catch ex As Exception

                End Try
            End If

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtCodigo.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtNombre.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtDescripcion.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Button1.Enabled = True
        txtNombre.ReadOnly = False
    End Sub

    Private Sub E_frmTipoMovientoAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)

        Try
            Dim clsOCOB As New clsTipoMovimiento
            Dim dvOC As DataView = clsOCOB.ListarMovimientos().DefaultView
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim clsOCOB As New clsTipoMovimiento
            Dim dvOC As DataView = clsOCOB.ListarMovimientos().DefaultView


            dvOC.RowFilter = String.Format("CONVERT(nombre, System.String) LIKE '%{0}%'", txtBuscar.Text)
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(DataGridView1)
    End Sub
End Class