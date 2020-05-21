Imports System.Data.SqlClient

Public Class E_frmSalida
    Private id_almacen, id_departamento_recibe, id_producto, id_detalle_oi As Integer

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub E_frmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Salida orden interna")
    End Sub

    Private Sub CargarDataOI(ByVal cod)
        DataGridView1.Columns.Clear()

        Dim clsDeOC As New clsDetalleOI
        Dim dvOC As DataView = clsDeOC.listarOrdenesInternasConParametro(cod).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCodOI.TextChanged
        CargarDataOI(txtCodOI.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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
        id_detalle_oi = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        txtLote.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtCantidad.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtAlmacenRecibe.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txtAreaSolicitante.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txtPersonaRecibe.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim clsS As New ClsSalidaAlmacen

        With clsS
            .CantidadProducto = txtCantidad.Text
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
            .Tipo_movimiento1 = ComboBox1.SelectedItem.ToString
            .Id_detalle_oi1 = id_detalle_oi

        End With

        If clsS.RegistrarSalidaAlmacen() = "1" Then
            MsgBox("salida registrada exitosamente")
        End If

        CargarDataOI(txtCodOI.Text)
    End Sub
End Class