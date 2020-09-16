Public Class E_frmUbicacion
    Private Sub E_frmUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Almacen()
        alternarColoFilasDatagridview(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Almacen()
        Dim clsAC As New ClsAlmacen
        Dim dvOC As DataView = clsAC.ListarAlmacenEntrada().DefaultView
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim clsA As New ClsAlmacen


        If txtCodAlmacen.Text <> "" Then
            With clsA
                .IdAlmacen = Integer.Parse(txtCodAlmacen.Text)
                .NombreAlmacen = txtNombreAlmacen.Text
                .DescripcionAlmacen = txtDescripcion.Text

            End With
            If clsA.ActualizarAlmacen = "1" Then
                MsgBox("Actualizado exitosamente")
                Almacen()
                Exit Sub
            End If
        ElseIf txtCodAlmacen.Text = "" Then
            With clsA

                .NombreAlmacen = txtNombreAlmacen.Text
                .DescripcionAlmacen = txtDescripcion.Text

            End With
            If clsA.RegistrarAlmacen() = "1" Then
                MsgBox("Registrado Exitosamente")
                Almacen()
                Exit Sub
            End If

        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtCodAlmacen.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtNombreAlmacen.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtDescripcion.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

            txtDescripcion.ReadOnly = False
            txtNombreAlmacen.ReadOnly = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim clsAC As New ClsAlmacen
        Dim dvOC As DataView = clsAC.ListarAlmacenEntrada().DefaultView
        dvOC.RowFilter = String.Format("CONVERT(nombre_almacen, System.String) LIKE '%{0}%'", txtBuscar.Text)
        DataGridView1.DataSource = dvOC
    End Sub

    Private Sub Limpiar()
        txtCodAlmacen.Clear()
        txtNombreAlmacen.Clear()
        txtDescripcion.Clear()
        txtDescripcion.ReadOnly = False
        txtNombreAlmacen.ReadOnly = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Limpiar()
    End Sub
End Class