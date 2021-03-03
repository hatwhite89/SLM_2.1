Imports System.Data.SqlClient

Public Class E_frmSalida
    Private id_almacen, id_departamento_recibe, id_producto, id_detalle_oi, id_entrada, existenciaentrada As Integer
    Private almacen_nombres As String
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub E_frmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEntrega.Text = nombre_usurio
        Label33.Text = ""
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView3)
        alternarColoFilasDatagridview(DataGridView4)
        Try
            Dim clsDeOC As New clsDetalleOI
            Dim dvOC As DataView = clsDeOC.CargarInventario().DefaultView
            DataGridView4.DataSource = dvOC
        Catch ex As Exception

        End Try

        'CARGAR EL COMBO DE TIPO DE MOVIMIENTO
        Dim clsD As New clsTipoMovimiento

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarMovimientos())

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id_tipo_movimiento"


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

        Try
            Dim clsDeOC As New clsDetalleOI
            Dim dvOC As DataView = clsDeOC.listarOrdenesInternasConParametro(cod).DefaultView
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try




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
        sumarDataExistencia()
    End Sub
    Public Sub sumarDataExistencia()
        Dim Total, Total_recibido As Single
        Try
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Total += Val(row.Cells(4).Value)
                Total_recibido += Val(row.Cells(3).Value)

            Next
            If Total <> Total_recibido Then

                Label33.Text = "Esta orden interna tiene items por entregar"

            End If
        Catch ex As Exception

        End Try


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
            txtProducto.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            existenciaentrada = DataGridView2.Rows(e.RowIndex).Cells(3).Value
            almacen_nombres = DataGridView2.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim clsDeOC As New clsDetalleOI
            Dim dvOC As DataView = clsDeOC.CargarInventario().DefaultView


            dvOC.RowFilter = String.Format("CONVERT(nombre_producto+lote+nombre_almacen, System.String) LIKE '%{0}%'", txtBuscar.Text)
            DataGridView4.DataSource = dvOC
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Try
            TextBox11.Text = DataGridView4.Rows(e.RowIndex).Cells(0).Value
            TextBox3.Text = DataGridView4.Rows(e.RowIndex).Cells(1).Value
            TextBox9.Text = DataGridView4.Rows(e.RowIndex).Cells(5).Value
            TextBox13.Text = DataGridView4.Rows(e.RowIndex).Cells(3).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Registras otras salidas del almacen

        If validarGuardar("Registrar Salida") = "1" Then


            Dim cls As New ClsSalidaAlmacen
            If Integer.Parse(TextBox13.Text) < Integer.Parse(TextBox12.Text) Then
                MsgBox("La cantidad que esta ingresando es mayor que la cantidad que se encuentra en existencia")
                Exit Sub
            End If
            With cls
                .Id_entrada_almacen1 = TextBox11.Text
                .CantidadProducto = TextBox12.Text
                .Persona_recibe1 = nombre_usurio
                .Descripcion = RichTextBox2.Text
                .Tipo_movimiento1 = ComboBox1.SelectedValue
            End With
            If cls.RegistrarSalidaAlmacen2() = "1" Then
                MsgBox(mensaje_registro)
                Try
                    Dim clsDeOC As New clsDetalleOI
                    Dim dvOC As DataView = clsDeOC.CargarInventario().DefaultView
                    DataGridView4.DataSource = dvOC
                Catch ex As Exception

                End Try
            End If

            Try
                TextBox11.Text = ""
                TextBox3.Text = ""
                TextBox9.Text = ""
                TextBox12.Text = ""

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If validarGuardar("Anular Salida") = "1" Then
            Dim clsS As New ClsSalidaAlmacen
            Try
                With clsS
                    .Id_salida1 = TextBox1.Text
                End With

                If clsS.RegistrarDevolucionEntrada() = "1" Then
                    MsgBox(mensaje_registro)
                    CargarDGOCFecha()
                End If
            Catch ex As Exception
                MsgBox("No se ha seleccionado ninguna salida")
            End Try

        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

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

            id_producto = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtCantidad.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            'txtAlmacenRecibe.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value


            If DataGridView1.Rows(e.RowIndex).Cells(3).Value <= DataGridView1.Rows(e.RowIndex).Cells(4).Value Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If

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
        If validarGuardar("Registrar Salida") = "1" Then


            If txtCantidadEntregada.Text = "" Then
                MsgBox("Debe ingresar la cantidad a entregar")
                Exit Sub
            End If

            If Integer.Parse(txtCantidadEntregada.Text) > Integer.Parse(txtCantidad.Text) Then
                MsgBox("La cantidad a entregar no puede ser mayor que la cantidad solicitada")
                Exit Sub
            End If

            If Integer.Parse(txtCantidadEntregada.Text) > Integer.Parse(existenciaentrada) Then
                MsgBox("la cantidad a entregar no puede ser mayor al inventario")
                Exit Sub
            End If

            Dim clss As New ClsSalidaAlmacen
            Try


                With clss
                    .CantidadProducto = txtCantidadEntregada.Text
                    .Descripcion = RichTextBox1.Text
                    .FechaVencimiento = DateTimePicker2.Value
                    .IdAlmacen = almacen_nombres
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

                If clss.RegistrarSalidaAlmacen() = "1" Then
                    MsgBox(mensaje_registro)
                    txtCantidadEntregada.Text = ""
                End If

                CargarDataOI(txtCodOI.Text)
                Dim clsOCOB As New clsDetalleOI
                Dim dvOC As DataView = clsOCOB.listarInventarioExistencias(-1).DefaultView
                DataGridView2.DataSource = dvOC
            Catch ex As Exception
                MsgBox("No hay productos en el inventario")
            End Try
        End If

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