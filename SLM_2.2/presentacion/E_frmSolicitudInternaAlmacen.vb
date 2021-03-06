Public Class E_frmSolicitudInternaAlmacen
    Dim objOrd As New clsEntradaAlmacen
    Dim dv1 As New DataView
    Dim cod_oi As String
    Dim codigo_producto, id_entrada As Integer

    Private Sub txtBuscarIventario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarIventario.TextChanged

        dv1 = objOrd.ListarEntradaInventario.DefaultView
        dv1.RowFilter = String.Format("CONVERT(nombre_producto, System.String) LIKE '%{0}%'", txtBuscarIventario.Text)
        DataGridView1.DataSource = dv1
    End Sub

    Private Sub E_frmSolicitudInternaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCantidadRequerida.Text = "0"
        CargarDatosGlobales()
        CargarComboSedes()
        CargarAreas()
        txtSolicitante.Text = nombre_usurio
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView3)
        alternarColoFilasDatagridview(DataGridView4)
        cmbDepartamento.Text = departamento_global
    End Sub

    Private Sub CargarComboSedes()
        'llenar combobox
        Dim clsD As New ClsSede
        Dim ds As New DataTable

        ds.Load(clsD.RecuperarSedeOrdenIntera)

    End Sub

    Private Sub CargarAreas()
        'llenar combobox areas
        Dim clsD As New ClsArea
        Dim ds As New DataTable

        ds.Load(clsD.RecuperarAreaOrdenInterna)


    End Sub

    Private Sub CargarDGOC()

        Dim clsOCOB As New clsEntradaAlmacen
        Dim dv2 As DataView = objOrd.ListarEntradaInventario.DefaultView
        DataGridView1.DataSource = dv2
    End Sub
    Private Sub CargarDGOI()

        Dim clsOI As New clsDetalleOI
        Dim dv4 As New DataView
        dv4 = clsOI.listarOrdenesInternasConParametro(txtCodSolicitud.Text).DefaultView
        DataGridView2.DataSource = dv4

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            codigo_producto = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception

        End Try


    End Sub



    Private Sub CrearOI()

        Dim clsOC As New clsOrdenInterna

        txtCodSolicitud.Text = clsOC.CrearrOrdenInterna

        'limpiar data

        txtProducto.Clear()

        txtCantidadRequerida.Clear()



    End Sub


    Private Sub txtAgregarInventario_Click(sender As Object, e As EventArgs) Handles txtAgregarInventario.Click

        agregarInventario()






    End Sub

    Private Sub agregarInventario()
        Dim clsD As New clsDetalleOI
        Try
            With clsD
                .Id_producto1 = Integer.Parse(codigo_producto)
                .Producto1 = txtProducto.Text
                .Lote1 = ""
                .Cantidad_solicitada1 = Double.Parse(txtCantidadRequerida.Text)
                .Cantidad_entregada1 = 0
                .Id_oi1 = Integer.Parse(txtCodSolicitud.Text)
                .Id_entrada1 = "0"

            End With
            If clsD.RegistrarOrdenInterna = "1" Then

                Dim clsOI As New clsOrdenInterna

                With clsOI
                    .Fecha_entrega1 = DateTimePicker1.Value
                    .Id_departamento1 = id_departamento_global
                    .Id_entrega1 = "0"
                    .Id_oi1 = Integer.Parse(txtCodSolicitud.Text)
                    .Id_solicitante1 = Integer.Parse(codigo_usuario)
                    .Estado1 = "creado"

                End With

                If clsOI.ActualizarOrdenInterna = "1" Then



                    Dim dv4 As New DataView
                    dv4 = clsD.listarOrdenesInternasConParametro(txtCodSolicitud.Text).DefaultView
                    DataGridView2.DataSource = dv4
                    txtCantidadRequerida.Text = "1"
                    MsgBox(mensaje_registro)
                End If

            End If
        Catch ex As Exception

        End Try



    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click



        CrearOI()
        CargarDGOC()
        txtCantidadRequerida.Text = "1"
        txtProducto.Text = ""
        Button4.Enabled = True
        txtAgregarInventario.Enabled = True
        Dim clsD As New clsDetalleOI
        Dim dv4 As New DataView
        dv4 = clsD.listarOrdenesInternasConParametro(txtCodSolicitud.Text).DefaultView
        DataGridView2.DataSource = dv4
        txtCantidadRequerida.Text = "1"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CargarMisSolicitudes()
    End Sub

    Private Sub CargarMisSolicitudes()
        Try
            Dim clsOCOB As New clsOrdenInterna
            Dim dvOC As DataView = clsOCOB.MisSolicitudesFecha(DateTimePicker2.Value.Date, DateTimePicker3.Value.Date, codigo_usuario).DefaultView
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cargarDetalleSolicitudes(ByVal id As String)
        Try
            Dim clsOI As New clsOrdenInterna
            Dim dvOC As DataView = clsOI.listarDetallesMisSolicitudes(id).DefaultView

            DataGridView4.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'eliminar fila de la solicitud
        Try
            Dim clsD As New clsDetalleOI
            With clsD
                .Id_oi1 = cod_oi
            End With
            If clsD.EliminarOrdenInterna() = "1" Then
                MsgBox("Fila eliminada")
                CargarDGOI()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'variables de codigo de oi
        Try
            cod_oi = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GridAExcel(DataGridView3)
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
        Dim cls As New clsOrdenInterna

        If validarGuardar("Enviar solicitud") = "1" Then


            With cls
                .Id_oi1 = txtCodSolicitud.Text
            End With
            If cls.ActualizarEstadoOrdenInterna() = "1" Then
                MsgBox("Se ha enviado la solicitud al almacen")
            End If
            Button4.Enabled = False
            txtAgregarInventario.Enabled = False

        End If
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            cargarDetalleSolicitudes(DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString)
        Catch ex As Exception

        End Try
    End Sub



End Class