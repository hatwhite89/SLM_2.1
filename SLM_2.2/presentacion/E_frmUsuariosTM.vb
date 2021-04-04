Imports System.Data.SqlClient

Public Class E_frmUsuariosTM
    Private Sub E_frmUsuariosTM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboAlmacen()
        alternarColoFilasDatagridview(DataGridView1)
        cargarData()
        ComboImpresora()
    End Sub
    Private Sub cargarData()
        Dim clsp As New clsTomaDeMuestra
        Try
            'datagridview

            DataGridView1.DataSource = clsp.ListarUsuarios.DefaultView

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ComboAlmacen()


        Dim ds As New DataTable


        ds.Load(listarSucursal())

        ComboBox2.DataSource = ds
        ComboBox2.DisplayMember = "nombre"
        ComboBox2.ValueMember = "codigo"
    End Sub

    Private Sub ComboImpresora()


        Dim ds As New DataTable


        ds.Load(listarImpresoras())

        ComboBox3.DataSource = ds
        ComboBox3.DisplayMember = "alias"
        ComboBox3.ValueMember = "id"
    End Sub
    Public Function listarSucursal() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select * from Sucursal"
        sqlcom.Connection = New ClsConnection().getConexion

        Return sqlcom.ExecuteReader
        sqlcom.Connection.Close()

    End Function

    Public Function listarImpresoras() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select * from impresoras"
        sqlcom.Connection = New ClsConnection().getConexion

        Return sqlcom.ExecuteReader
        sqlcom.Connection.Close()

    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtUsuario.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim clst As New clsTomaDeMuestra
        With clst
            .Usuario1 = txtUsuario.Text
            .Pass1 = txtpass.Text
            .Estacion1 = ComboBox1.SelectedText
            .Id_sucursal1 = ComboBox2.SelectedValue
            .Sucursal1 = ComboBox2.SelectedText
            .Id_impresora1 = ComboBox3.SelectedValue
        End With

        If clst.RegistrarUsuario = "1" Then
            MsgBox(mensaje_registro)
            cargarData()
        End If
        If clst.RegistrarUsuario = "2" Then
            MsgBox("Este usuario ya existe en la base de datos")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim clst As New clsTomaDeMuestra
        With clst
            .Usuario1 = txtUsuario.Text
        End With
        If validarGuardar("Eliminar Usuario") = 1 Then


            If clst.EliminarUsuario() = "1" Then
                MsgBox("Se eliminio al usuario del sistema")
                cargarData()
            End If
        End If
    End Sub
End Class