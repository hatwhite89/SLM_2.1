Imports System.Data.SqlClient

Public Class E_frmOrdenCompra
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Dim TableUM As New DataTable
    Dim objOrd As New ClsProducto
    Dim clsProve As New ClsProveedor

    Dim dv As DataView = objOrd.RecuperarProducto2.DefaultView
    Dim dvProveedor As DataView = clsProve.listarProveedoresOC.DefaultView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCodOC.Text <> "" Then
            Dim clsDOC As New clsDetalleOC
            With clsDOC
                .ProductoOC = txtProducto.Text
                .CodigoProducto = Integer.Parse(txtCodigProducto.Text)
                .Numerolote = txtLoteProducto.Text
                .FechaVencimiento = DateTimePicker1.Value
                .ISVDetalle = Double.Parse(txtISVProductos.Text)
                .CantidadDetalle = Double.Parse(txtCantidadProductos.Text)
                .PrecioUnitario = Double.Parse(txtPrecioUnitarioProductos.Text)
                .CostoTotal = Double.Parse(txtCostoTotal.Text)
                .EstadoOC = False
                .IdOC = Integer.Parse(txtCodOC.Text)

            End With

            If clsDOC.RegistrarDetalleOC() = "1" Then
                MsgBox("Registrado Exitosamente ")
            End If
        ElseIf txtCodOC.Text = "" Then
            MsgBox("Debe asignar una orden de compra")
        End If
        CargarDetalleOC(txtCodOC.Text)
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

        'datagridview



        dv.RowFilter = String.Format("CONVERT(nombre_producto, System.String) LIKE '%{0}%'", TextBox10.Text)
        DataGridView3.DataSource = dv
    End Sub

    Public Sub E_frmOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDiasCredito.Text = "0"


        Dim TableUM As New DataTable
        Dim TableUM2 As New DataTable
        Dim clsP As New ClsProducto
        Dim clsOC As New ClsOrdenDeCompra

        TableUM.Load(clsP.RecuperarProductoOC())

        DataGridView3.DataSource = TableUM

        'detalle orden
        txtISVProductos.Text = "0"
        txtCantidadProductos.Text = "0"
        txtPrecioUnitarioProductos.Text = "0"
        txtCantidadProductos.Text = "0"
        txtNombreProveedor.Text = nombre_proveedorOC

        CargarDGOC()


    End Sub
    Private Sub CargarDGOC()
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOC.DefaultView
        DataGridView2.DataSource = dvOC
    End Sub
    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        txtCodigProducto.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
        txtProducto.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub CargarDetalleOC(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOC(cod).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitarioProductos.TextChanged
        Try
            Dim resultado As Double
            resultado = Double.Parse(txtCantidadProductos.Text) * Double.Parse(txtPrecioUnitarioProductos.Text)
            txtCostoTotal.Text = resultado
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCantidadProductos_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadProductos.TextChanged
        Try
            Dim resultado As Double
            resultado = Double.Parse(txtCantidadProductos.Text) * Double.Parse(txtPrecioUnitarioProductos.Text)
            txtCostoTotal.Text = resultado
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCodOC.Clear()

        Dim clsOC As New ClsOrdenDeCompra

        txtCodOC.Text = clsOC.CrearrOrdenDeCompra()
        CargarDetalleOC(txtCodOC.Text)

    End Sub
    Private Sub ActualizarOC()
        Dim clsOC As New ClsOrdenDeCompra

        With clsOC
            .IdOrdenCompra = Integer.Parse(txtCodOC.Text)
            .IdFormaPago = cmbFormaDePago.SelectedValue()
            .FechaElaboracion = DateTimePicker1.Value
            .Condiciones = txtCondicionEntrega.Text
            .UsuarioConsignado = txtConsignado.Text
            .UsuarioSolicito = txtAutorizado.Text
            .UsuarioAutorizo = ""
            .DepartamentSolicita = Integer.Parse("1")
            .DepartamentoAutoriza = Integer.Parse("1")
            .ObservacionesOC = txtObservaciones.Text
            .EstadoOC = False
            .IdProveedor = Integer.Parse(txtCodProveedor.Text)
        End With

        If clsOC.ActualizarOC() = "1" Then
            MsgBox("Agregado Exitosamente")

        End If

        CargarDGOC()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ActualizarOC()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOC.DefaultView
        dvOC.RowFilter = String.Format("CONVERT(id_oc, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView2.DataSource = dvOC
    End Sub




    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        E_frmProveedorOC.Show()
    End Sub

    Private Sub txtCodProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodProveedor.TextChanged
        Try
            Dim objP As New ClsProveedor
            With objP
                .Cod_Proveedor = txtCodProveedor.Text
            End With
            Dim dt As New DataTable
            dt = objP.listarProveedoresOC2(txtCodProveedor.Text)
            Dim row As DataRow = dt.Rows(0)
            txtNombreProveedor.Text = CStr(row("nombreProveedor"))
            txtNombreProveedor.BackColor = Color.White
        Catch ex As Exception
            txtNombreProveedor.BackColor = Color.Red
            txtNombreProveedor.Text = ""

        End Try
    End Sub

    Private Sub cmbFormaDePago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaDePago.SelectedIndexChanged
        If cmbFormaDePago.SelectedItem() = "Credito" Then
            txtDiasCredito.ReadOnly = False
        ElseIf cmbFormaDePago.SelectedItem() = "Contado" Then
            txtDiasCredito.ReadOnly = True
            txtDiasCredito.Text = "0"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CargarDGOC()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick


        txtCodOC.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        txtCodProveedor.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        txtCondicionEntrega.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
        txtObservaciones.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value
        CargarDetalleOC(txtCodOC.Text)

    End Sub




End Class