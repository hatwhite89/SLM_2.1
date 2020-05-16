Imports System.Data.SqlClient

Public Class E_frmSalida
    Private id_almacen, id_departamento_recibe, id_producto As Integer

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub E_frmSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargarDataOI(ByVal cod)
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
            enunciado = New SqlCommand("select Identificacion from Empleados", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read

                txtAreaSolicitante.Text = respuesta.Item("Identificacion")
                txtAlmacenRecibe.Text = respuesta.Item("Identificacion")


            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtProducto.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtLote.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtCantidad.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

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
            .Tipo_movimiento1 = ComboBox1.SelectedValue

        End With
    End Sub
End Class