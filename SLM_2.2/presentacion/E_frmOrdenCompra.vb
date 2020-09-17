﻿Imports System.Data.SqlClient

Public Class E_frmOrdenCompra
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Dim TableUM As New DataTable
    Dim objOrd As New ClsProducto
    Dim clsProve As New ClsProveedor
    Dim codigo_globas As String
    Dim dv As DataView = objOrd.RecuperarProducto3.DefaultView
    Dim dvProveedor As DataView = clsProve.listarProveedoresOC.DefaultView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCodOC.Text <> "" Then
            Dim clsDOC As New clsDetalleOC
            Try
                With clsDOC
                    .ProductoOC = txtProducto.Text
                    .CodigoProducto = Integer.Parse(txtCodigProducto.Text)
                    .Numerolote = ""
                    .FechaVencimiento = Date.Today
                    .ISVDetalle = Double.Parse(txtISVProductos.Text)
                    .CantidadDetalle = Double.Parse(txtCantidadProductos.Text)
                    .PrecioUnitario = Double.Parse(txtPrecioUnitarioProductos.Text)
                    .CostoTotal = Double.Parse(txtCostoTotal.Text)
                    .EstadoOC = False
                    .IdOC = Integer.Parse(txtCodOC.Text)

                End With

                If clsDOC.RegistrarDetalleOC() = "1" Then
                    MsgBox("Registrado Exitosamente ")
                    txtCantidadProductos.Text = "0"
                    txtPrecioUnitarioProductos.Text = "0"
                    txtISVProductos.Text = "0"
                    txtCostoTotal.Text = "0"
                End If
            Catch ex As Exception
                MsgBox("Debe llenar todos los campos obligatorios *")
            End Try

        ElseIf txtCodOC.Text = "" Then
            MsgBox("Debe asignar una orden de compra")
        End If
        CargarDetalleOC(txtCodOC.Text)
        sumarData()
        sumarData2()
    End Sub

    Public Sub sumarData()
        Dim Total As Single

        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            Total += Val(row.Cells(3).Value)
        Next
        Label44.Text = Total.ToString
    End Sub
    Public Sub sumarData2()
        Dim Total As Single

        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            Total += Val(row.Cells(4).Value)
        Next
        Label46.Text = Total.ToString
    End Sub
    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

        'datagridview



        dv.RowFilter = String.Format("CONVERT(nombre_producto, System.String) LIKE '%{0}%'", TextBox10.Text)
        DataGridView9.DataSource = dv
    End Sub

    Public Sub E_frmOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton2.Checked = False
        RadioButton1.Checked = False
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView9)
        alternarColoFilasDatagridview(DataGridView4)
        alternarColoFilasDatagridview(DataGridView5)
        alternarColoFilasDatagridview(DataGridView6)
        alternarColoFilasDatagridview(DataGridView7)
        alternarColoFilasDatagridview(DataGridView8)
        txtDiasCredito.Text = "0"

        Label38.Text = ""
        Label38.Text = ""
        Dim TableUM As New DataTable
        Dim TableUM2 As New DataTable

        Dim clsOC As New ClsOrdenDeCompra



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
    Private Sub DataGridView3_Click(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub CargarDetalleOC(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOC(cod).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
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
        RadioButton1.Checked = True
        Button3.Enabled = True
        Button5.Enabled = True
        txtCodOC.Clear()
        txtConsignado.Clear()
        txtAutorizado.Clear()
        txtCodProveedor.Clear()
        txtRTNProveedor.Clear()
        txtNombreProveedor.Clear()
        txtDiasCredito.Clear()
        txtNumFactura.Clear()
        txtLugarEntrega.Clear()
        txtCondicionEntrega.Clear()
        txtObservaciones.Clear()
        txtProducto.Clear()
        txtCodigProducto.Clear()

        txtISVProductos.Clear()
        txtCantidadProductos.Clear()
        txtPrecioUnitarioProductos.Clear()
        txtCostoTotal.Clear()


        txtConsignado.ReadOnly = False
        txtAutorizado.ReadOnly = False
        txtCodProveedor.ReadOnly = False

        txtDiasCredito.ReadOnly = False
        txtNumFactura.ReadOnly = False
        txtLugarEntrega.ReadOnly = False
        txtCondicionEntrega.ReadOnly = False
        txtObservaciones.ReadOnly = False
        Dim clsP As New ClsProducto
        TableUM.Load(clsP.RecuperarProductoOC2())

        DataGridView9.DataSource = TableUM



        Dim clsOC As New ClsOrdenDeCompra

        txtCodOC.Text = clsOC.CrearrOrdenDeCompra()
        CargarDetalleOC(txtCodOC.Text)

        'detalle orden
        txtISVProductos.Text = "0"
        txtCantidadProductos.Text = "0"
        txtPrecioUnitarioProductos.Text = "0"
        txtCantidadProductos.Text = "0"
        txtNombreProveedor.Text = nombre_proveedorOC

        Button3.Enabled = True
        Button5.Enabled = True
        Button1.Enabled = True
        btnProveedor.Enabled = True
        Button2.Enabled = True
    End Sub
    Private Sub ActualizarOC()
        Dim clsOC As New ClsOrdenDeCompra
        Dim estado As Boolean = False
        If RadioButton1.Checked = True Then
            estado = False
        ElseIf RadioButton1.Checked = False Then
            estado = True
        End If
        Try
            With clsOC
                .IdOrdenCompra = Integer.Parse(txtCodOC.Text)
                .IdFormaPago = cmbFormaDePago.SelectedValue()
                .FechaElaboracion = ""
                .Condiciones = txtCondicionEntrega.Text
                .UsuarioConsignado = txtConsignado.Text
                .UsuarioSolicito = txtAutorizado.Text
                .UsuarioAutorizo = ""
                .DepartamentSolicita = Integer.Parse("1")
                .DepartamentoAutoriza = Integer.Parse("1")
                .ObservacionesOC = txtObservaciones.Text
                .EstadoOC = estado
                .IdProveedor = Integer.Parse(txtCodProveedor.Text)
            End With

            If clsOC.ActualizarOC() = "1" Then
                MsgBox("Agregado Exitosamente")

            End If

            CargarDGOC()
        Catch ex As Exception
            MsgBox("Debe llenar todos los campos obligatorios *")
        End Try

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
            txtRTNProveedor.Text = CStr(row("idTributario"))
            txtNombreProveedor.BackColor = Color.White
        Catch ex As Exception
            txtNombreProveedor.BackColor = Color.Red
            txtNombreProveedor.Text = ""
            txtRTNProveedor.Text = ""

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


        Try
            cmbFormaDePago.SelectedValue = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            txtCodOC.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            txtCodProveedor.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            txtCondicionEntrega.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
            txtObservaciones.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value

            txtAutorizado.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value
            txt_estado_autorizacion.Text = DataGridView2.Rows(e.RowIndex).Cells(12).Value
            RichTextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(14).Value
            CargarDetalleOC(txtCodOC.Text)
            Label38.Text = DataGridView2.Rows(e.RowIndex).Cells(13).Value
            Label37.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value
            txtConsignado.ReadOnly = False
            txtAutorizado.ReadOnly = False
            txtCodProveedor.ReadOnly = False

            txtDiasCredito.ReadOnly = False
            txtNumFactura.ReadOnly = False
            txtLugarEntrega.ReadOnly = False
            txtCondicionEntrega.ReadOnly = False
            txtObservaciones.ReadOnly = False
        Catch ex As Exception

        End Try


    End Sub

    Private Sub CargarDGOCFecha()
        Try
            Dim clsOCOB As New ClsOrdenDeCompra
            Dim dvOC As DataView = clsOCOB.RecuperarOCPrFechas(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date).DefaultView
            DataGridView4.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Try
            Dim codigo_oc As String
            codigo_oc = DataGridView4.Rows(e.RowIndex).Cells(0).Value
            CargarDetalleOC2(codigo_oc)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDetalleOC2(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOC(cod).DefaultView
        DataGridView5.DataSource = dvOC
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CargarDGOCFecha()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOCPrFechas(DateTimePicker3.Value.Date, DateTimePicker4.Value.Date).DefaultView
        dvOC.RowFilter = String.Format("CONVERT(id_oc, System.String) LIKE '%{0}%'", TextBox2.Text)
        DataGridView4.DataSource = dvOC


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        MsgBox(RichTextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clsD As New clsDetalleOC

        With clsD
            .IdDetalleOC = txtCodOC.Text
        End With

        If clsD.EliminarDetalleOCEntrada() = "1" Then
            MsgBox("Se elimino fila")
            CargarDetalleOC(txtCodOC.Text)
        End If
        sumarData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            codigo_globas = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView9_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView9.CellClick
        Try
            txtCodigProducto.Text = DataGridView9.Rows(e.RowIndex).Cells(0).Value
            txtProducto.Text = DataGridView9.Rows(e.RowIndex).Cells(1).Value
            txtPrecioUnitarioProductos.Text = DataGridView9.Rows(e.RowIndex).Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub

End Class