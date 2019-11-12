Public Class M_ClasificacionContacto
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_BuscarTipoClasificacion.ShowDialog()
    End Sub

    Private Sub M_ClasificacionContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objClas As New ClsClasificacionContacto
        Dim dv As DataView = objClas.SeleccionarClasificacionContacto.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        rtxtcomentario.ReadOnly = True
        txtcodigoTipo.ReadOnly = True
        txtcodigo.ReadOnly = True

        'btnbuscarEspecialidad.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellContentClick

    End Sub



    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text() = ""
        txtcodigoTipo.Text() = ""
        txtcomentarioB.Text() = ""
        txtcomentarioTipo.Text() = ""
        rtxtcomentario.Text() = ""

        txtcodigoTipo.ReadOnly = False
        txtcomentarioB.ReadOnly = False
        rtxtcomentario.ReadOnly = False
        txtcodigo.ReadOnly = True

        btnbuscar.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub


    Private Sub txtcodigoTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoTipo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (rtxtcomentario.Text <> "" And txtcodigoTipo.Text <> "") Then
                Dim testString As String = rtxtcomentario.Text()
                Dim texto As String = ""
                Dim testArray() As String = Split(testString)
                Dim lastNonEmpty As Integer = -1
                For i As Integer = 0 To testArray.Length - 1
                    If testArray(i) <> "" Then
                        lastNonEmpty += 1
                        testArray(lastNonEmpty) = testArray(i)
                        texto += testArray(i) + " "
                    End If
                Next
                ReDim Preserve testArray(lastNonEmpty)
                rtxtcomentario.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objClasif As New ClsClasificacionContacto
                With objClasif
                    .Comentario1 = texto
                    .CodigoTipo1 = txtcodigoTipo.Text
                End With

                If objClasif.RegistrarNuevaClasificacionContacto() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim objClas As New ClsClasificacionContacto
                    Dim dv As DataView = objClas.SeleccionarClasificacionContacto.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtcomentario.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar la clasificación del contacto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (rtxtcomentario.Text <> "" And txtcodigoTipo.Text <> "" And txtcodigo.Text <> "") Then
                Dim testString As String = rtxtcomentario.Text()
                Dim texto As String = ""
                Dim testArray() As String = Split(testString)
                Dim lastNonEmpty As Integer = -1
                For i As Integer = 0 To testArray.Length - 1
                    If testArray(i) <> "" Then
                        lastNonEmpty += 1
                        testArray(lastNonEmpty) = testArray(i)
                        texto += testArray(i) + " "
                    End If
                Next
                ReDim Preserve testArray(lastNonEmpty)
                rtxtcomentario.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objClasif As New ClsClasificacionContacto
                With objClasif
                    .Comentario1 = texto
                    .Codigo1 = txtcodigo.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                End With

                If objClasif.ModificarClasificacionContacto() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim objClas As New ClsClasificacionContacto
                    Dim dv As DataView = objClas.SeleccionarClasificacionContacto.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtcomentario.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar la clasificación del contacto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim objClas As New ClsClasificacionContacto
        With objClas
            .Comentario1 = txtcomentarioB.Text
        End With
        Dim dv As DataView = objClas.BuscarClasificacionContacto.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtcomentario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtcodigoTipo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            M_BuscarCliente.txtcodigoClasificacion.Text = txtcodigo.Text
            M_BuscarCliente.txtnombreClasificacion.Text = rtxtcomentario.Text

            btnmodificar.Enabled = True
            'btnbuscarEspecialidad.Enabled = True

            rtxtcomentario.ReadOnly = False
            txtcodigoTipo.ReadOnly = False
            txtcodigo.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtcodigoTipo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTipo.TextChanged
        If (txtcodigoTipo.Text <> "") Then
            Try
                Dim objClas As New ClsClasificacionContacto
                With objClas
                    .Codigo1 = txtcodigoTipo.Text
                End With
                Dim dt As New DataTable
                dt = objClas.BuscarClasificacionContactoCode()
                Dim row As DataRow = dt.Rows(0)
                txtcomentarioTipo.Text = CStr(row("comentario"))
            Catch ex As Exception
                MsgBox("No existe el código de clasificación de contacto.", MsgBoxStyle.Critical, "Validación")
            End Try
        End If
    End Sub
End Class