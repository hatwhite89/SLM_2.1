Public Class E_frmCuentaAlmacen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsC As New ClsCuentasAlmacen

        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar un nombre de cuenta")
            Exit Sub
        End If
        If txtCuenta.Text = "" Then
            MsgBox("Debe ingresar un número de cuenta")
            Exit Sub
        End If
        Try
            With clsC
                .Nombre1 = txtNombre.Text
                .Cuenta1 = txtCuenta.Text
            End With
            If clsC.RegistrarCuentaPrincipal() = "1" Then
                MsgBox(mensaje_registro)
                cargarCuentasD()
                limpiar()
                cargarData()
            ElseIf clsC.RegistrarCuentaPrincipal() = "2" Then
                MsgBox("Esta cuenta ya existe,registre otra cuenta.")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim clsC As New ClsCuentasAlmacen
        If txtNombre2.Text = "" Then
            MsgBox("Debe ingresar un nombre de cuenta")
            Exit Sub
        End If
        If txtCuenta2.Text = "" Then
            MsgBox("Debe ingresar un número de cuenta")
            Exit Sub
        End If
        Try

        Catch ex As Exception
            With clsC
                .Nombre1 = txtNombre2.Text
                .Cuenta1 = txtCuenta2.Text
                .Cuenta_id1 = ComboBox1.SelectedValue
            End With
            If clsC.RegistrarCuentaSecundaria() = "1" Then
                MsgBox(mensaje_registro)
                cargarCuentasD()
                limpiar()
            ElseIf clsC.RegistrarCuentaSecundaria() = "2" Then
                MsgBox("Esta cuenta ya existe,registre otra cuenta.")
            End If
        End Try

    End Sub

    Private Sub E_frmCuentaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarData()
        cargarCuentasD()
        alternarColoFilasDatagridview(DataGridView1)
        alternarColoFilasDatagridview(DataGridView2)

    End Sub
    Public Sub cargarCuentasD()

        Try
            Dim clsC As New ClsCuentasAlmacen
            DataGridView1.DataSource = clsC.cargarCuentaP.DefaultView
            DataGridView2.DataSource = clsC.cargarCuentaS.DefaultView
        Catch ex As Exception
            RegistrarExcepciones(codigo_usuario, Me.Name, ex.ToString)
        End Try
    End Sub
    Public Sub cargarData()
        Try
            Dim clsC As New ClsCuentasAlmacen
            Dim ds As New DataTable

            ds.Load(clsC.RecuperarCP)


            ComboBox1.DataSource = ds
            ComboBox1.DisplayMember = "nombre"
            ComboBox1.ValueMember = "cuenta"
        Catch ex As Exception
            RegistrarExcepciones(codigo_usuario, Me.Name, ex.ToString)
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        txtNombre.Clear()
        txtCuenta.Clear()
        txtCuenta2.Clear()
        txtNombre2.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        limpiar()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtCuenta.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtNombre.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            RegistrarExcepciones(codigo_usuario, Me.Name, ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            txtCuenta2.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            txtNombre2.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            RegistrarExcepciones(codigo_usuario, Me.Name, ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim clsC As New ClsCuentasAlmacen
            With clsC
                .Cuenta1 = txtCuenta.Text
            End With
            If clsC.DeleteCuentaPrincipal() = "1" Then
                MsgBox(mensaje_dar_baja)
                cargarCuentasD()
                limpiar()
            End If
        Catch ex As Exception
            RegistrarExcepciones(codigo_usuario, Me.Name, ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim clsC As New ClsCuentasAlmacen
            With clsC
                .Cuenta1 = txtCuenta2.Text
            End With
            If clsC.DeleteCuentaSecundaria() = "1" Then
                MsgBox(mensaje_dar_baja)
                cargarCuentasD()
                limpiar()
            End If
        Catch ex As Exception
            RegistrarExcepciones(codigo_usuario, Me.Name, ex.ToString)
        End Try
    End Sub
End Class