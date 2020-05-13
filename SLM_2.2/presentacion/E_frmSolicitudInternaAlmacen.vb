Public Class E_frmSolicitudInternaAlmacen
    Dim objOrd As New clsEntradaAlmacen
    Dim dv As DataView = objOrd.ListarEntradaInventario.DefaultView
    Dim codigo_producto As Integer

    Private Sub txtBuscarIventario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarIventario.TextChanged


        dv.RowFilter = String.Format("CONVERT(nombre_producto, System.String) LIKE '%{0}%'", txtBuscarIventario.Text)
        DataGridView1.DataSource = dv
    End Sub

    Private Sub E_frmSolicitudInternaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDGOC()
        CargarComboSedes()
        CargarAreas()
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
        Dim clsOCOB As New clsEntradaAlmacen
        Dim dv As DataView = objOrd.ListarEntradaInventario.DefaultView
        DataGridView1.DataSource = dv
    End Sub
    Private Sub CargarDGOI()
        Dim clsOI As New clsDetalleOI
        Dim dv As DataView = clsOI.listarOrdenesInternasConParametro(txtCodSolicitud.Text).DefaultView
        DataGridView2.DataSource = dv
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtLote.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        codigo_producto = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CrearOI()
    End Sub

    Private Sub CrearOI()

        Dim clsOC As New clsOrdenInterna

        txtCodSolicitud.Text = clsOC.CrearrOrdenInterna

        'limpiar data
        txtSolicitante.Clear()
        txtProducto.Clear()
        txtLote.Clear()
        txtCantidadRequerida.Clear()

        DataGridView2.Columns.Clear()

    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub txtAgregarInventario_Click(sender As Object, e As EventArgs) Handles txtAgregarInventario.Click
        Dim clsD As New clsDetalleOI

        With clsD
            .Id_producto1 = codigo_producto
            .Producto1 = txtProducto.Text
            .Lote1 = txtLote.Text
            .Cantidad_solicitada1 = txtCantidadRequerida.Text
            .Cantidad_entregada1 = 0
            .Id_oi1 = Integer.Parse(txtCodSolicitud.Text)
        End With

        If clsD.RegistrarOrdenInterna = "1" Then
            CargarDGOI()
        End If

    End Sub
End Class