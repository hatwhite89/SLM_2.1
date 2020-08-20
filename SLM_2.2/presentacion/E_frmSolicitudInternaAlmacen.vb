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
        CargarComboSedes()
        CargarAreas()
        txtSolicitante.Text = nombre_usurio
    End Sub

    Private Sub CargarComboSedes()
        'llenar combobox
        Dim clsD As New ClsSede
        Dim ds As New DataTable

        ds.Load(clsD.RecuperarSedeOrdenIntera)

        cmbSede.DataSource = ds
        cmbSede.DisplayMember = "nombre"
        cmbSede.ValueMember = "codigo"
    End Sub

    Private Sub CargarAreas()
        'llenar combobox areas
        Dim clsD As New ClsArea
        Dim ds As New DataTable

        ds.Load(clsD.RecuperarAreaOrdenInterna)

        cmbDepartamento.DataSource = ds
        cmbDepartamento.DisplayMember = "nombre"
        cmbDepartamento.ValueMember = "codigo"
    End Sub

    Private Sub CargarDGOC()
        DataGridView1.Columns.Clear()
        Dim clsOCOB As New clsEntradaAlmacen
        Dim dv2 As DataView = objOrd.ListarEntradaInventario.DefaultView
        DataGridView1.DataSource = dv2
    End Sub
    Private Sub CargarDGOI()
        DataGridView2.Columns.Clear()
        Dim clsOI As New clsDetalleOI
        Dim dv2 As New DataView
        dv2 = clsOI.listarOrdenesInternasConParametro(txtCodSolicitud.Text).DefaultView
        DataGridView2.DataSource = dv2
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtLote.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        codigo_producto = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        id_entrada = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(6).Value)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CrearOI()

        Dim clsOC As New clsOrdenInterna

        txtCodSolicitud.Text = clsOC.CrearrOrdenInterna

        'limpiar data

        txtProducto.Clear()
        txtLote.Clear()
        txtCantidadRequerida.Clear()

        DataGridView2.Columns.Clear()

    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub txtAgregarInventario_Click(sender As Object, e As EventArgs) Handles txtAgregarInventario.Click
        Try
            agregarInventario()
            Threading.Thread.Sleep(1000)
            ActualizarOrdenInterna()
            CargarDGOI()
            txtCantidadRequerida.Text = "0"
        Catch ex As Exception
            MsgBox("Debe seleccionar un producto y asignar una cantidad")
        End Try

    End Sub

    Private Sub agregarInventario()
        Dim clsD As New clsDetalleOI

        With clsD
            .Id_producto1 = Integer.Parse(codigo_producto)
            .Producto1 = txtProducto.Text
            .Lote1 = txtLote.Text
            .Cantidad_solicitada1 = Double.Parse(txtCantidadRequerida.Text)
            .Cantidad_entregada1 = 0
            .Id_oi1 = Integer.Parse(txtCodSolicitud.Text)
            .Id_entrada1 = id_entrada

        End With

        If clsD.RegistrarOrdenInterna = "1" Then
            DataGridView2.Columns.Clear()
        End If
    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CrearOI()
        CargarDGOC()
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

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            cargarDetalleSolicitudes(DataGridView3.Rows(e.RowIndex).Cells(0).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UI_Card1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UI_Calendar1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub ActualizarOrdenInterna()
        Dim clsOI As New clsOrdenInterna

        With clsOI
            .Fecha_entrega1 = DateTimePicker1.Value
            .Id_departamento1 = Integer.Parse(cmbDepartamento.SelectedValue)
            .Id_entrega1 = Integer.Parse(cmbSede.SelectedValue)
            .Id_oi1 = Integer.Parse(txtCodSolicitud.Text)
            .Id_solicitante1 = Integer.Parse(codigo_usuario)
            .Estado1 = "creado"

        End With

        If clsOI.ActualizarOrdenInterna = "1" Then

        End If

    End Sub
End Class