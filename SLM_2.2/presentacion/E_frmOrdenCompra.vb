Imports System.Data.SqlClient

Public Class E_frmOrdenCompra
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public id_forma_pago As Integer
    Dim TableUM As New DataTable
    Dim objOrd As New ClsProducto
    Dim clsProve As New ClsProveedor
    Dim codigo_globas As String
    Dim dv As DataView = objOrd.RecuperarProducto3.DefaultView
    Dim dvProveedor As DataView = clsProve.listarProveedoresOC.DefaultView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Msg, Style, Title, Help, Ctxt, Response, MyString
        Msg = "Esta a punto de modificar la orden, ¿Está seguro de que desea continuar"    ' Define message.
        Style = vbYesNo + vbCritical + vbDefaultButton2    ' Define buttons.
        Title = "Agregar nuevo producto"    ' Define title.


        If txtEstadoOC.Text = "Abierta" Then


            ' Display message.
            Response = MsgBox(Msg, Style, Title)
            If Response = vbYes Then    ' User chose Yes.
                MyString = "Si"    ' Perform some action.
                If txtCodOC.Text <> "" Then
                    Dim clsDOC As New clsDetalleOC
                    Try
                        With clsDOC
                            .ProductoOC = txtProducto.Text
                            .CodigoProducto = Integer.Parse(txtCodigProducto.Text)
                            .Numerolote = ""
                            .FechaVencimiento = Date.Today
                            .ISVDetalle = "0"
                            .CantidadDetalle = Double.Parse(txtCantidadProductos.Text)
                            .PrecioUnitario = Double.Parse(txtPrecioUnitarioProductos.Text)
                            .CostoTotal = Double.Parse(txtCostoTotal.Text)
                            .EstadoOC = False
                            .IdOC = Integer.Parse(txtCodOC.Text)
                            .Cantidad_recibida1 = Integer.Parse(txtCantidadProductos.Text)

                        End With

                        If clsDOC.RegistrarDetalleOC() = "1" Then
                            MsgBox("Registrado Exitosamente ")
                            txtCantidadProductos.Text = "0"
                            txtPrecioUnitarioProductos.Text = "0"
                            txtISVProductos.Text = "0"
                            txtCostoTotal.Text = "0"
                            CargarDetalleOC(txtCodOC.Text)
                            sumarData()
                            sumarData2()
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Debe llenar todos los campos obligatorios *")
                        Exit Sub
                    End Try
                    Exit Sub
                ElseIf txtCodOC.Text = "" Then
                    MsgBox("Debe asignar una orden de compra")
                    Exit Sub
                End If
                CargarDetalleOC(txtCodOC.Text)
                sumarData()
                sumarData2()
                Exit Sub
            Else    ' User chose No.
                MyString = "No"    ' Perform some action.
                Exit Sub
            End If
        End If

        If txtCodOC.Text <> "" Then
            Dim clsDOC As New clsDetalleOC
            Try
                With clsDOC
                    .ProductoOC = txtProducto.Text
                    .CodigoProducto = Integer.Parse(txtCodigProducto.Text)
                    .Numerolote = ""
                    .FechaVencimiento = Date.Today
                    .ISVDetalle = "0"
                    .CantidadDetalle = Double.Parse(txtCantidadProductos.Text)
                    .PrecioUnitario = Double.Parse(txtPrecioUnitarioProductos.Text)
                    .CostoTotal = Double.Parse(txtCostoTotal.Text)
                    .EstadoOC = False
                    .IdOC = Integer.Parse(txtCodOC.Text)
                    .Cantidad_recibida1 = Integer.Parse(txtCantidadProductos.Text)

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
        Try
            Dim Total As Single

            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Total += Val(row.Cells(6).Value)
            Next
            Label44.Text = Total.ToString
        Catch ex As Exception

        End Try

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
        txtNumFactura.Text = "0"
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView9)
        alternarColoFilasDatagridview(DataGridView4)
        alternarColoFilasDatagridview(DataGridView5)

        txtDiasCredito.Text = "0"

        Label38.Text = ""
        Label38.Text = ""
        Dim TableUM As New DataTable
        Dim TableUM2 As New DataTable

        Dim clsOC As New ClsOrdenDeCompra



        'detalle orden
        txtISVProductos.Text = "0"
        txtCantidadProductos.Text = "1"
        txtPrecioUnitarioProductos.Text = "0"

        txtNombreProveedor.Text = nombre_proveedorOC

        CargarDGOC()
        autoCompletarTexbox(txtNombreProveedor)

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

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs)
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
        txtNombreProveedor.Enabled = True

        txtCodOC.Clear()
        txtConsignado.Clear()
        txtAutorizado.Clear()
        txtCodProveedor.Clear()
        txtRTNProveedor.Clear()
        txtNombreProveedor.Clear()
        txtDiasCredito.Clear()
        txtNumFactura.Text = "0"

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

        Button2.Enabled = True

        txtConsignado.Text = nombre_usurio
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim clsOC As New ClsOrdenDeCompra
        Dim estado As Boolean = False

        Try
            With clsOC
                .IdOrdenCompra = Integer.Parse(txtCodOC.Text)
                .IdFormaPago = id_forma_pago
                .FechaElaboracion = Date.Now
                .Condiciones = txtCondicionEntrega.Text
                .UsuarioConsignado = txtConsignado.Text
                .UsuarioSolicito = ""
                .UsuarioAutorizo = ""
                .DepartamentSolicita = Integer.Parse("1")
                .DepartamentoAutoriza = Integer.Parse("1")
                .ObservacionesOC = txtObservaciones.Text
                .EstadoOC = estado
                .IdProveedor = Integer.Parse(txtCodProveedor.Text)
                .Id_factura_compra1 = Integer.Parse(txtNumFactura.Text)

            End With

            If clsOC.ActualizarOC() = "1" Then
                MsgBox("Agregado Exitosamente")

            End If

            CargarDGOC()
        Catch ex As Exception
            MsgBox("Debe llenar todos los campos obligatorios *")
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOC.DefaultView
        dvOC.RowFilter = String.Format("CONVERT(id_oc, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView2.DataSource = dvOC
    End Sub




    Private Sub btnProveedor_Click(sender As Object, e As EventArgs)
        E_frmProveedorOC.Show()
    End Sub

    Private Sub txtCodProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodProveedor.TextChanged

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Button3.Enabled = True
        Button5.Enabled = True
        Button1.Enabled = True

        Button2.Enabled = True

        Try
            codigo_oc = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            txtCodOC.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            LlenarTextbox(DataGridView2.Rows(e.RowIndex).Cells(0).Value)
            txtEstadoOC.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
            txtNombreProveedor.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            txtNumFactura.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value


            'txtCondicionEntrega.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value
            'txtObservaciones.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value


            'txt_estado_autorizacion.Text = DataGridView2.Rows(e.RowIndex).Cells(12).Value
            'RichTextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(14).Value
            'CargarDetalleOC(txtCodOC.Text)
            'Label38.Text = DataGridView2.Rows(e.RowIndex).Cells(13).Value
            'Label37.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value


            txtConsignado.ReadOnly = False

            txtCodProveedor.ReadOnly = False

            txtDiasCredito.ReadOnly = False
            txtNumFactura.ReadOnly = False

            txtCondicionEntrega.ReadOnly = False
            txtObservaciones.ReadOnly = False

            Dim clsP As New ClsProducto
            TableUM.Load(clsP.RecuperarProductoOC2())

            DataGridView9.DataSource = TableUM

            CargarDetalleOC(txtCodOC.Text)

            sumarData()
            sumarData2()

        Catch ex As Exception

        End Try

        If txtEstadoOC.Text = "Cerrado" Then
            Button1.Enabled = False
            Button3.Enabled = False

        End If

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
            .IdDetalleOC = codigo_globas
        End With

        If clsD.EliminarDetalleOCEntrada() = "1" Then
            MsgBox("Se elimino fila")
            CargarDetalleOC(txtCodOC.Text)
        End If
        sumarData()
        sumarData2()
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

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Public Sub LlenarTextbox(ByVal codigo As String)
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOCConParametro(codigo).DefaultView



        DataGridView3.DataSource = dvOC


        txtCodProveedor.Text = DataGridView3.Rows.Item(0).Cells(2).Value
        txtCondicionEntrega.Text = DataGridView3.Rows.Item(0).Cells(4).Value
        txtConsignado.Text = DataGridView3.Rows.Item(0).Cells(5).Value
        txtAutorizado.Text = DataGridView3.Rows.Item(0).Cells(7).Value
        txtObservaciones.Text = DataGridView3.Rows.Item(0).Cells(10).Value
        txt_estado_autorizacion.Text = DataGridView3.Rows.Item(0).Cells(12).Value
        RichTextBox1.Text = DataGridView3.Rows.Item(0).Cells(14).Value
        DateTimePicker1.Value = DataGridView3.Rows.Item(0).Cells(3).Value





    End Sub

    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select * from Proveedor", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombreProveedor"))


            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtNombreProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProveedor.TextChanged
        Try
            Dim objP As New ClsProveedor

            Dim dt As New DataTable
            dt = objP.listarProveedoresOC2(txtNombreProveedor.Text)
            Dim row As DataRow = dt.Rows(0)
            txtCodProveedor.Text = CStr(row("codProveedor"))
            txtRTNProveedor.Text = CStr(row("idTributario"))
            txtDiasCredito.Text = CStr(row("diasNeto"))
            cmbFormaDePago.Text = CStr(row("descripcion"))
            id_forma_pago = CStr(row("codTermPago"))

        Catch ex As Exception

            txtNombreProveedor.Text = ""
            txtRTNProveedor.Text = ""

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        reporteOrdenCompra.Show()
    End Sub

    Private Sub txtCodOC_TextChanged(sender As Object, e As EventArgs) Handles txtCodOC.TextChanged
        CargarDetalleOC(txtCodOC.Text)

        If txtEstadoOC.Text = "Cerrado" Or txtEstadoOC.Text = "Pendiente" Then
            Button1.Enabled = False
            Button3.Enabled = False

        End If

        If txtEstadoOC.Text = "Pendiente" Then
            Button1.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btnLimpiarBusqueda.Click
        txtNombreProveedor.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        reporteOrdenCompra.Show()
    End Sub

    Private Sub txtEstadoOC_TextChanged(sender As Object, e As EventArgs) Handles txtEstadoOC.TextChanged
        If txtEstadoOC.Text = "Cerrado" Or txtEstadoOC.Text = "Pendiente" Then
            Button1.Enabled = False
            Button3.Enabled = False

        End If

        If txtEstadoOC.Text = "Pendiente" Then
            Button1.Enabled = False
            Button3.Enabled = False
        End If

        If txtEstadoOC.Text = "Rechazada" Then
            Button1.Enabled = False
            Button3.Enabled = False
        End If
    End Sub
End Class