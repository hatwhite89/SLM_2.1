Public Class E_frmAutorizarOC

    Dim codigo_oc As String
    Private Sub E_frmAutorizarOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDGOC()
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)
        alternarColoFilasDatagridview(DataGridView3)
        alternarColoFilasDatagridview(DataGridView4)
        alternarColoFilasDatagridview(DataGridView5)
        alternarColoFilasDatagridview(DataGridView6)
    End Sub

    Private Sub CargarDGOC()
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOCParaAutorizar.DefaultView
        DataGridView2.DataSource = dvOC
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try

            codigo_oc = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            txtCodOC.Text = codigo_oc
            CargarDetalleOC(txtCodOC.Text)
            sumarData()
            sumarData2()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'autorizar orden de compra
        Dim clsOC As New ClsOrdenDeCompra
        With clsOC
            .IdOrdenCompra = txtCodOC.Text
            .Obser_autorizacion1 = RichTextBox1.Text
            .UsuarioAutorizo = nombre_usurio

        End With

        If clsOC.AutorizarOC() = "1" Then
            MsgBox("Usted ha autorizado la orden de compra No " + txtCodOC.Text)
            CargarDGOC()
            DataGridView5.Columns.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'rechazar orden de compra
        Dim clsOC As New ClsOrdenDeCompra
        With clsOC
            .IdOrdenCompra = txtCodOC.Text
            .Obser_autorizacion1 = RichTextBox1.Text
            .UsuarioAutorizo = nombre_usurio

        End With

        If clsOC.REchazarOC() = "1" Then
            MsgBox("Usted ha rechazado la orden de compra No " + txtCodOC.Text)
            CargarDGOC()
            DataGridView5.Columns.Clear()
        End If
    End Sub

    Private Sub CargarDetalleOC(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOC(cod).DefaultView
        DataGridView5.DataSource = dvOC
    End Sub
    Private Sub CargarDetalleOCREchazada(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOC(cod).DefaultView
        DataGridView4.DataSource = dvOC
    End Sub

    Private Sub CargarDetalleOCAutorizadasPorUser(ByVal cod As String)
        Dim clsDeOC As New clsDetalleOC
        Dim dvOC As DataView = clsDeOC.ListarDetalleOC(cod).DefaultView
        DataGridView3.DataSource = dvOC
    End Sub
    Private Sub CargarOCRechazadas()
        Dim clsDeOC As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsDeOC.RecuperarOCRechazadas(nombre_usurio, DateTimePicker1.Value, DateTimePicker2.Value).DefaultView
        DataGridView6.DataSource = dvOC
    End Sub

    Private Sub CargarOCAutorizadasPorUser()
        Dim clsDeOC As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsDeOC.RecuperarOCAutorizadasUsuario(nombre_usurio, DateTimePicker4.Value, DateTimePicker3.Value).DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            CargarOCRechazadas()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellClick
        Try
            CargarDetalleOCREchazada(DataGridView6.Rows(e.RowIndex).Cells(0).Value)
            txtCodOCRechazada.Text = DataGridView6.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CargarOCAutorizadasPorUser()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            CargarDetalleOCAutorizadasPorUser(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOCParaAutorizar.DefaultView
        dvOC.RowFilter = String.Format("CONVERT(id_oc, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView2.DataSource = dvOC
    End Sub

    Private Sub txtBuscar2_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar2.TextChanged
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOCRechazadas(nombre_usurio, DateTimePicker1.Value, DateTimePicker2.Value).DefaultView
        dvOC.RowFilter = String.Format("CONVERT(id_oc, System.String) LIKE '%{0}%'", txtBuscar2.Text)
        DataGridView6.DataSource = dvOC
    End Sub

    Private Sub txtBuscar3_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar3.TextChanged
        Dim clsOCOB As New ClsOrdenDeCompra
        Dim dvOC As DataView = clsOCOB.RecuperarOCAutorizadasUsuario(nombre_usurio, DateTimePicker4.Value, DateTimePicker3.Value).DefaultView
        dvOC.RowFilter = String.Format("CONVERT(id_oc, System.String) LIKE '%{0}%'", txtBuscar3.Text)
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'anular orden de compra
        Dim clsOC As New ClsOrdenDeCompra
        With clsOC
            .IdOrdenCompra = txtCodOC.Text
            .Obser_autorizacion1 = RichTextBox1.Text
            .UsuarioAutorizo = nombre_usurio

        End With

        If clsOC.AnularOC() = "1" Then
            MsgBox("Usted ha anulado la orden de compra No " + txtCodOC.Text)
            CargarDGOC()
            DataGridView5.Columns.Clear()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'cerrar orden de compra
        Dim clsOC As New ClsOrdenDeCompra
        With clsOC
            .IdOrdenCompra = txtCodOC.Text
            .Obser_autorizacion1 = RichTextBox1.Text
            .UsuarioAutorizo = nombre_usurio

        End With

        If clsOC.CerrarOC() = "1" Then
            MsgBox("Usted ha cerrado la orden de compra No " + txtCodOC.Text)
            CargarDGOC()
            DataGridView5.Columns.Clear()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Public Sub sumarData()
        Dim Total As Single

        For Each row As DataGridViewRow In Me.DataGridView5.Rows
            Total += Val(row.Cells(4).Value)
        Next
        Label44.Text = Total.ToString
    End Sub
    Public Sub sumarData2()
        Dim Total As Single

        For Each row As DataGridViewRow In Me.DataGridView5.Rows
            Total += Val(row.Cells(5).Value)
        Next
        Label46.Text = Total.ToString
    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick

    End Sub
End Class