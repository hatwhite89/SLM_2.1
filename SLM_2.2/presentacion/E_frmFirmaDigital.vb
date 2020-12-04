Imports System.Data.SqlClient
Imports System.IO

Public Class E_frmFirmaDigital
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim clsF As New ClsFirmaDigital
        If btnGuardar.Text = "Modificar" Then
            Try
                Dim ms As New System.IO.MemoryStream()
                PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                With clsF
                    .Abreviatura1 = txtAbre.Text
                    .Cod_usuario1 = Integer.Parse(txtCodUsuario.Text)
                    .Nombre_completo1 = txtNombre.Text
                    .Nombre_usuario1 = txtNombreUsuario.Text
                    .Puesto1 = txtPuesto.Text
                    .Imagen1 = ms.GetBuffer()
                End With
                If clsF.ActualizarFirma = "1" Then
                    MsgBox("Firma actualizada")
                    cargarData()
                    Exit Sub
                End If
            Catch ex As Exception

            End Try


        End If
        If txtAbre.Text = "" Then
            MsgBox("Debe agregar una abreviatura")
            cargarData()
            Exit Sub
        End If


        If btnGuardar.Text = "Guardar" Then


            Try
                Try
                    Dim ms As New System.IO.MemoryStream()
                    PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

                    With clsF
                        .Abreviatura1 = txtAbre.Text
                        .Cod_usuario1 = Integer.Parse(txtCodUsuario.Text)
                        .Nombre_completo1 = txtNombre.Text
                        .Nombre_usuario1 = txtNombreUsuario.Text
                        .Puesto1 = txtPuesto.Text
                        .Imagen1 = ms.GetBuffer()
                    End With
                Catch ex As Exception
                    MsgBox("Debe agregar una imagen")
                End Try

                If clsF.RegistrarFirma() = "1" Then
                    MsgBox("Firma Digital Registrada")
                    cargarData()
                    txtNombreUsuario.Clear()
                    txtAbre.Clear()
                    txtCodUsuario.Clear()
                    txtPuesto.Clear()
                    txtNombre.Clear()
                    btnGuardar.Enabled = False
                ElseIf clsF.RegistrarFirma() = "2" Then
                    MsgBox("Firma Digital Ya Se Encuentra Registrada")
                    cargarData()
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim openFileDialog1 As New OpenFileDialog()

        Dim result As New DialogResult
        openFileDialog1.InitialDirectory = “C:\”
        openFileDialog1.Filter = “archivos de imagen (*.jpg)|*.png|All files (*.*)|*.*”
        openFileDialog1.FilterIndex = 3
        openFileDialog1.RestoreDirectory = True
        result = openFileDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub E_frmFirmaDigital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        autoCompletarTexbox(txtNombreUsuario)

        cargarData()
    End Sub
    Public Sub cargarData()
        Try
            'datagridview
            Dim TableUM As New DataTable
            Dim clsP As New ClsFirmaDigital
            TableUM.Load(clsP.RecuperarFirmasDigitales())
            BindingSource1.DataSource = TableUM

            DataGridView1.DataSource = BindingSource1
        Catch ex As Exception

        End Try
    End Sub
    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select * from usuario", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("usuario"))


            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUsuario.TextChanged
        Try
            Dim clsU As New ClsUsuario
            Dim dt As New DataTable
            dt = clsU.RecuperarUsuariosFirmaDigital(txtNombreUsuario.Text)


            Dim row As DataRow = dt.Rows(0)
            txtNombre.Text = CStr(row("nombreCompleto"))
            txtPuesto.Text = CStr(row("descripcion"))
            txtCodUsuario.Text = CStr(row("cod_usuario"))

            '  cod_proveedor = CStr(row("id_proveedor"))
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtCodUsuario.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            txtAbre.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            txtNombre.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            txtNombreUsuario.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            txtPuesto.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

            Dim datos As Byte() = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            Dim ms = New MemoryStream(datos)

            PictureBox1.Image = Image.FromStream(ms)
            btnGuardar.Text = "Modificar"
            btnGuardar.Enabled = True
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtNombreUsuario.Clear()
        txtAbre.Clear()
        txtCodUsuario.Clear()
        txtPuesto.Clear()
        txtNombre.Clear()
        btnGuardar.Text = "Guardar"
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            Dim clsF As New ClsFirmaDigital
            With clsF
                .Cod_usuario1 = Integer.Parse(txtCodUsuario.Text)
            End With
            If clsF.EliminarFirma() = "1" Then
                MsgBox("Firma Digital eliminada")
                cargarData()
                btnGuardar.Enabled = False
                txtNombreUsuario.Clear()
                txtAbre.Clear()
                txtCodUsuario.Clear()
                txtPuesto.Clear()
                txtNombre.Clear()
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class