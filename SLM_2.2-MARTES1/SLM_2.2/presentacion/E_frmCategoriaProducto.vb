Public Class E_frmCategoriaProducto

    Dim objOrd As New ClsCategoriaroducto

    Dim dv As DataView = objOrd.RecuperarCategoriaProducto2.DefaultView


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim clsCP As New ClsCategoriaroducto


        If txtCodigo.Text = "" Then
            With clsCP

                .NombreCategoriaProducto = txtNombre.Text
                .DescripcionCategoriaProducto = txtDescripcion.Text
            End With

            If clsCP.RegistrarCategoriaProducto() = "1" Then
                Button4.Enabled = False
                txtDescripcion.ReadOnly = True
                txtNombre.ReadOnly = True
                MsgBox("Registrado exitosamente")
                cargarData()

            End If
        ElseIf txtCodigo.Text <> "" Then
            With clsCP
                .IdCategoriaProducto = Integer.Parse(txtCodigo.Text)
                .NombreCategoriaProducto = txtNombre.Text
                .DescripcionCategoriaProducto = txtDescripcion.Text
            End With

            If clsCP.ActualizarCategoriaProducto() = "1" Then
                Button4.Enabled = False
                txtDescripcion.ReadOnly = True
                txtNombre.ReadOnly = True
                MsgBox("Registrado exitosamente")
                cargarData()

                Exit Sub
            End If
        End If

    End Sub
    Private Sub cargarData()
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New ClsCategoriaroducto
            TableUM.Load(clsP.RecuperarCategoriaProducto())

            DataGridView1.DataSource = TableUM
        Catch ex As Exception

        End Try
    End Sub
    Private Sub E_frmCategoriaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.Enabled = False
        txtDescripcion.ReadOnly = True
        txtNombre.ReadOnly = True

        cargarData()
        alternarColoFilasDatagridview(DataGridView1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtDescripcion.Text = ""
        txtNombre.Text = ""
        txtCodigo.Text = ""
        txtDescripcion.ReadOnly = True
        txtNombre.ReadOnly = True
        Button4.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtDescripcion.Text = ""
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtDescripcion.ReadOnly = False
        txtNombre.ReadOnly = False
        Button4.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            txtCodigo.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtNombre.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtDescripcion.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtDescripcion.ReadOnly = False
            txtNombre.ReadOnly = False
            Button4.Enabled = True
        Catch ex As Exception

        End Try




    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        dv.RowFilter = String.Format("CONVERT(nombre_categoria, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView1.DataSource = dv

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcel(DataGridView1)
    End Sub
End Class