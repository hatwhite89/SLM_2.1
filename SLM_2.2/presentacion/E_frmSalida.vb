Imports System.Data.SqlClient

Public Class E_frmSalida
    Private id_almacen, id_departamento_recibe, id_producto, id_detalle_oi, id_entrada As Integer

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub E_frmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEntrega.Text = nombre_usurio

        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView3)


    End Sub
    Private Sub CargarDGOCFecha()
        Try
            Dim clsOCOB As New ClsSalidaAlmacen
            Dim dvOC As DataView = clsOCOB.ListarSalidaInventarioFecha(DateTimePicker1.Value.Date, DateTimePicker3.Value.Date).DefaultView
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CargarDataOI(ByVal cod)


        Dim clsDeOC As New clsDetalleOI
        Dim dvOC As DataView = clsDeOC.listarOrdenesInternasConParametro(cod).DefaultView
        DataGridView1.DataSource = dvOC

        Try
            Dim objP As New ClsSalidaAlmacen

            Dim dt As New DataTable
            dt = objP.RecuperarDatosOrdenInterna(txtCodOI.Text)
            Dim row As DataRow = dt.Rows(0)
            txtAreaSolicitante.Text = CStr(row("nombre"))
            txtPersonaRecibe.Text = CStr(row("nombreCompleto"))
            txtAlmacenRecibe.Text = CStr(row("usuario"))


        Catch ex As Exception


        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCodOI.TextChanged
        CargarDataOI(txtCodOI.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargarDGOCFecha()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Dim clsOCOB As New ClsSalidaAlmacen
            Dim dvOC As DataView = clsOCOB.ListarSalidaInventarioFecha(DateTimePicker1.Value.Date, DateTimePicker3.Value.Date).DefaultView


            dvOC.RowFilter = String.Format("CONVERT(producto, System.String) LIKE '%{0}%'", TextBox2.Text)
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs)
        Try
            Dim clsOCOB As New ClsSalidaAlmacen
            Dim dvOC As DataView = clsOCOB.ListarSalidaInventarioFecha(DateTimePicker1.Value.Date, DateTimePicker3.Value.Date).DefaultView


            dvOC.RowFilter = String.Format("CONVERT(producto, System.String) LIKE '%{0}%'", TextBox2.Text)
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            TextBox4.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value
            TextBox6.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value
            TextBox7.Text = DataGridView3.Rows(e.RowIndex).Cells(5).Value
            TextBox8.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value
            TextBox1.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
            TextBox5.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel(DataGridView3)
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            txtLote.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            txtidDetalleEntrada.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub cargarVariables()
        Dim clsC As New ClsConnection
        Dim enunciado As SqlCommand
        Dim respuesta As SqlDataReader

        Try
            enunciado = New SqlCommand("select  d.nombre,u.usuario from OrdenInterna o, Area d, Usuario u
where o.id_departamento=d.codigo and o.id_usuario = u.cod_usuario and o.id_oi='11'", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read

                txtAreaSolicitante.Text = respuesta.Item("usuario")
                txtAlmacenRecibe.Text = respuesta.Item("nombre")


            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim clsE As New ClsSalidaAlmacen
        Try
            id_detalle_oi = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtCantidad.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            txtAlmacenRecibe.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            txtAreaSolicitante.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            txtPersonaRecibe.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            'txtExistenciaEntrada.Text = clsE.ExistenciasDeEntrada(DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString)
            id_entrada = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(7).Value)


        Catch ex As Exception

        End Try
        Try
            Dim clsOCOB As New clsDetalleOI
            Dim dvOC As DataView = clsOCOB.listarInventarioExistencias(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString).DefaultView
            DataGridView2.DataSource = dvOC
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCantidadEntregada.Text = "" Then
            MsgBox("Debe ingresar la cantidad a entregar")
            Exit Sub
        End If

        'If Integer.Parse(txtCantidadEntregada.Text) > Integer.Parse(txtexistenciaentrada.text) Then
        '    MsgBox("la cantidad a entregar no puede ser mayor al inventario")
        '    Exit Sub
        'End If

        Dim clss As New ClsSalidaAlmacen
        Try


            With clsS
                .CantidadProducto = txtCantidadEntregada.Text
                .Descripcion = RichTextBox1.Text
                .FechaVencimiento = DateTimePicker2.Value
                .IdAlmacen = id_almacen
                .IdProducto = id_producto
                .Id_departamento1 = id_departamento_recibe
                .Id_oi1 = txtCodOI.Text
                .LoteProducto = txtLote.Text
                .Persona_entrega1 = txtEntrega.Text
                .Persona_recibe1 = txtPersonaRecibe.Text
                .Producto1 = txtProducto.Text
                .Tipo_movimiento1 = "Solicitud Interna"
                .Id_detalle_oi1 = id_detalle_oi
                .Id_entrada1 = txtidDetalleEntrada.Text
            End With

            If clsS.RegistrarSalidaAlmacen() = "1" Then
                MsgBox("salida registrada exitosamente")
                txtCantidadEntregada.Text = ""
            End If

            CargarDataOI(txtCodOI.Text)
            Dim clsOCOB As New clsDetalleOI
            Dim dvOC As DataView = clsOCOB.listarInventarioExistencias(-1).DefaultView
            DataGridView2.DataSource = dvOC
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

End Class