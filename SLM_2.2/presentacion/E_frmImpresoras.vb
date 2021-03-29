Imports System.Data.SqlClient

Public Class E_frmImpresoras
    Private Sub E_frmImpresoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        Dim clsP As New clsImpresora
        cargarData()
        ComboAlmacen()
        Me.Refresh()
    End Sub
    Private Sub ComboAlmacen()


        Dim ds As New DataTable
        Dim clsi As New clsImpresora



        ComboBox1.DataSource = clsi.RecuperarSucursal().DefaultView
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "codigo"

    End Sub
    Private Sub cargarData()
        Dim clsp As New clsImpresora
        Try
            'datagridview

            DataGridView1.DataSource = clsp.RecuperarImpresoras().DefaultView

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If TextBox1.Text = "" Then
            Dim cls As New clsImpresora
            With cls
                .Aliasprint1 = txtAlias.Text
                .Nombre1 = txtNombre.Text
                .Sucursal1 = ComboBox1.SelectedValue
            End With

            If cls.RegistrarImpresora() = "1" Then
                MsgBox(mensaje_registro)
                cargarData()
                txtAlias.Clear()
                txtNombre.Clear()
                TextBox1.Clear()
            End If
        Else
            MsgBox("Debe crear un nuevo registro")
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
        txtAlias.Text = ""
        txtNombre.Text = ""
        TextBox1.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            btnGuardar.Enabled = True
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtAlias.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtNombre.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim clsp As New clsImpresora
        With clsp
            .Id1 = TextBox1.Text
        End With
        If clsp.EliminarImpresora() = "1" Then
            MsgBox(mensaje_dar_baja)
        End If
        cargarData()
    End Sub
End Class