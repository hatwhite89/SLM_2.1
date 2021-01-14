Public Class M_ClasificacionContacto
    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_TipoClasificacion.lbltipo.Text = "ClasificacionContacto"
        M_TipoClasificacion.Show()
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

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
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

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
    End Sub
    Private Sub txtcodigoTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoTipo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(rtxtcomentario.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And txtcodigoTipo.BackColor = Color.White) Then

                rtxtcomentario.Text = sinDobleEspacio(rtxtcomentario.Text)

                Dim objClasif As New ClsClasificacionContacto
                With objClasif
                    .Comentario1 = rtxtcomentario.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                End With

                If objClasif.RegistrarNuevaClasificacionContacto() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objClasif.SeleccionarClasificacionContacto.DefaultView
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
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (Trim(rtxtcomentario.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And txtcodigoTipo.BackColor = Color.White) Then

                rtxtcomentario.Text = sinDobleEspacio(rtxtcomentario.Text)

                Dim objClasif As New ClsClasificacionContacto
                With objClasif
                    .Comentario1 = rtxtcomentario.Text
                    .Codigo1 = txtcodigo.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                End With

                If objClasif.ModificarClasificacionContacto() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objClasif.SeleccionarClasificacionContacto.DefaultView
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
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_Cliente") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la clasificación en el cliente?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Cliente.txtcodigoClasificacion.Text = txtcodigo.Text
                    M_Cliente.txtnombreClasificacion.Text = rtxtcomentario.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtcomentario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtcodigoTipo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            rtxtcomentario.ReadOnly = False
            txtcodigoTipo.ReadOnly = False
            txtcodigo.ReadOnly = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoTipo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTipo.TextChanged
        If (txtcodigoTipo.Text <> "") Then
            Try
                Dim objTipoClas As New ClsTipoClasificacion
                With objTipoClas
                    .Codigo1 = txtcodigoTipo.Text
                End With
                Dim dt As New DataTable
                dt = objTipoClas.BuscarTipoClasificacionCode()
                Dim row As DataRow = dt.Rows(0)
                txtcomentarioTipo.Text = CStr(row("comentario"))
                txtcodigoTipo.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTipo.BackColor = Color.Red
                txtcomentarioTipo.Text = ""
            End Try
        Else
            txtcodigoTipo.Text = ""
            txtcomentarioTipo.Text = ""
            txtcodigoTipo.BackColor = Color.White
        End If
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtcomentarioB_TextChanged(sender As Object, e As EventArgs) Handles txtcomentarioB.TextChanged
        Dim objClas As New ClsClasificacionContacto
        With objClas
            .Comentario1 = txtcomentarioB.Text
        End With
        Dim dv As DataView = objClas.BuscarClasificacionContacto.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
End Class