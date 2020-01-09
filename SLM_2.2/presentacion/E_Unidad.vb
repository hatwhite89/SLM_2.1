Public Class E_Unidad
    Private Sub M_Unidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objUnidad As New ClsUnidad
        Dim dv As DataView = objUnidad.SeleccionarUnidad.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        dgbtabla.Columns("codigo").Visible = False

        txtFactorCantidad.ReadOnly = True
        rtxtcomentario.ReadOnly = True
        txtcodigo.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub txtFactorCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFactorCantidad.KeyPress
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

            rtxtcomentario.Text = sinDobleEspacio(rtxtcomentario.Text)
            If (txtcodigo.Text <> "" And rtxtcomentario.Text <> "" And txtFactorCantidad.Text <> "") Then
                Dim objUnidad As New ClsUnidad
                With objUnidad
                    .codigoUnidad_ = txtcodigo.Text
                    .comentario_ = rtxtcomentario.Text
                    .factorCantidad_ = txtFactorCantidad.Text
                End With

                If objUnidad.RegistrarNuevaUnidad() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objUnidad.SeleccionarUnidad.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtcomentario.ReadOnly = True
                    txtFactorCantidad.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                Else
                    MsgBox("Error al querer ingresar la unidad.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Error al querer ingregar la unidad.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            rtxtcomentario.Text = sinDobleEspacio(rtxtcomentario.Text)
            If (Trim(rtxtcomentario.Text) <> "" And Trim(txtcodigo.Text) <> "" And txtFactorCantidad.Text <> "") Then
                Dim objUnidad As New ClsUnidad
                With objUnidad
                    .Codigo_ = lblcode.Text
                    .codigoUnidad_ = txtcodigo.Text
                    .comentario_ = rtxtcomentario.Text
                    .factorCantidad_ = txtFactorCantidad.Text
                End With

                If objUnidad.ModificarUnidad() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objUnidad.SeleccionarUnidad.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtcomentario.ReadOnly = True
                    txtFactorCantidad.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                Else
                    MsgBox("Error al querer modificar la unidad.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Error al querer ingregar la unidad.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text = ""
        rtxtcomentario.Text = ""
        txtFactorCantidad.Text = ""

        txtFactorCantidad.ReadOnly = False
        rtxtcomentario.ReadOnly = False
        txtcodigo.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtcomentario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtFactorCantidad.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            E_ParametroExamen.lblcodeUnidad.Text = lblcode.Text

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtFactorCantidad.ReadOnly = False
            rtxtcomentario.ReadOnly = False
            txtcodigo.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcomentarioB_TextChanged(sender As Object, e As EventArgs) Handles txtcomentarioB.TextChanged
        Try
            Dim objUnidad As New ClsUnidad
            With objUnidad
                .comentario_ = txtcomentarioB.Text
            End With
            If (Trim(txtcomentarioB.Text) <> "") Then
                Dim dv As DataView = objUnidad.BuscarUnidadComment.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objUnidad.SeleccionarUnidad.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class