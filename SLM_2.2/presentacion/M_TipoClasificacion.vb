Public Class M_TipoClasificacion
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text() = ""
        txtcomentarioB.Text() = ""
        rtxtcomentario.Text() = ""

        txtcomentarioB.ReadOnly = False
        rtxtcomentario.ReadOnly = False
        txtcodigo.ReadOnly = True

        btnbuscar.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (rtxtcomentario.Text <> "") Then
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

                Dim objTipoCla As New ClsTipoClasificacion
                With objTipoCla
                    .Comentario1 = texto
                End With

                If objTipoCla.RegistrarNuevoTipoClasificacion() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtcomentario.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el tipo de clasificación.", MsgBoxStyle.Critical)
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

            If (rtxtcomentario.Text <> "" And txtcodigo.Text <> "") Then
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

                Dim objTipoCla As New ClsTipoClasificacion
                With objTipoCla
                    .Comentario1 = texto
                    .Codigo1 = txtcodigo.Text
                End With

                If objTipoCla.ModificarTipoClasificacion() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtcomentario.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el tipo de clasificación.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim objTipoCla As New ClsTipoClasificacion
        With objTipoCla
            .Comentario1 = txtcomentarioB.Text
        End With
        Dim dv As DataView = objTipoCla.BuscarTipoClasificacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_TipoClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objTipoCla As New ClsTipoClasificacion
        Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        rtxtcomentario.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtcomentario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()

            If (lbltipo.Text = "Categoria") Then
                M_Categoria.txtcodigoTipo.Text = txtcodigo.Text
                M_Categoria.txtdescripcionTipo.Text = rtxtcomentario.Text
            ElseIf (lbltipo.Text = "ClasificacionContacto") Then
                M_ClasificacionContacto.txtcodigoTipo.Text = txtcodigo.Text
                M_ClasificacionContacto.txtcomentarioTipo.Text = rtxtcomentario.Text
            End If

            btnmodificar.Enabled = True

            rtxtcomentario.ReadOnly = False
            txtcodigo.ReadOnly = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class