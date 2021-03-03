Public Class E_frmUnidadMedida_almacen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsUM As New ClsUnidadMedidaAlmacen
        If Campo_requerido(txtNombre, Label2) = 1 Then
            Exit Sub
        End If

        If validarGuardar("Unidad Producto") = 1 Then


            If txtCodigo.Text = "" Then
                With clsUM

                    .NombreUnidadMedida = txtNombre.Text
                    .DescripcionUnidadMedida = txtDescripcion.Text
                End With
                If clsUM.RegistrarUnidadMedida() = "1" Then
                    MsgBox("Registrado exitosamente")
                    cargarData()
                    Button1.Enabled = False
                    txtDescripcion.ReadOnly = True
                    txtNombre.ReadOnly = True

                End If
            ElseIf txtCodigo.Text <> "" Then
                With clsUM
                    .IdUnidadMedida = Integer.Parse(txtCodigo.Text)
                    .NombreUnidadMedida = txtNombre.Text
                    .DescripcionUnidadMedida = txtDescripcion.Text
                End With
                If clsUM.ActualizarUnidadMedida() = "1" Then

                    MsgBox("Actualizado exitosamente")
                    cargarData()
                End If
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cargarData()
        Try
            Dim TableUM As New DataTable
            Dim clsUM As New ClsUnidadMedidaAlmacen
            TableUM.Load(clsUM.RecuperarUnidadMedida())

            DataGridView1.DataSource = TableUM
        Catch ex As Exception

        End Try

    End Sub

    Private Sub E_frmUnidadMedida_almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarData()

        'campos
        txtDescripcion.ReadOnly = True
        txtNombre.ReadOnly = True
        'boton
        Button1.Enabled = False
        alternarColoFilasDatagridview(DataGridView1)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtNombre.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString()
        txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
        txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString()
        Button1.Enabled = True
        txtDescripcion.ReadOnly = False
        txtNombre.ReadOnly = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'campos
        txtDescripcion.ReadOnly = False
        txtNombre.ReadOnly = False

        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtCodigo.Text = ""
        Button1.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'campos
        txtDescripcion.ReadOnly = True
        txtNombre.ReadOnly = True

        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtCodigo.Text = ""
        Button1.Enabled = False

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim objOrd As New ClsUnidadMedidaAlmacen


        Dim dv As DataView = objOrd.RecuperarUM.DefaultView
        dv.RowFilter = String.Format("CONVERT(nombre_unidad_medida, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView1.DataSource = dv

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If validarGuardar("Unidad de medida") = "1" Then
            Try
                Dim clsU As New ClsUnidadMedidaAlmacen
                With clsU
                    .IdUnidadMedida = txtCodigo.Text
                End With

                If clsU.BajarUnidadMedida = "1" Then
                    MsgBox(mensaje_dar_baja)
                    cargarData()
                End If
            Catch ex As Exception
                MsgBox("No ha seleccionado ninguna fila")
            End Try
        End If
    End Sub
End Class