Public Class M_Categoria
    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs)
        M_TipoClasificacion.ShowDialog()
    End Sub
    Private Sub M_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCategoria As New ClsCategoria
        Dim dv As DataView = objCategoria.SeleccionarCategoria.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        dgbtabla.Columns("codigo").Visible = False

        rtxtdescripcion.ReadOnly = True
        txtcodigoTipo.ReadOnly = True
        txtcodigo.ReadOnly = True

        'btnbuscarEspecialidad.Enabled = False
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
        txtdescripcionB.Text() = ""
        txtdescripcionTipo.Text() = ""
        rtxtdescripcion.Text() = ""

        txtcodigoTipo.ReadOnly = False
        txtdescripcionB.ReadOnly = False
        rtxtdescripcion.ReadOnly = False
        txtcodigo.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub txtcodigoTipo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And Trim(txtcodigo.Text) <> "") Then

                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objCategoriaif As New ClsCategoria
                With objCategoriaif
                    .descripcion1 = rtxtdescripcion.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                    .codigoCategoria_ = txtcodigo.Text
                End With

                If objCategoriaif.RegistrarNuevaCategoria() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objCategoriaif.SeleccionarCategoria.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtdescripcion.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True
                    txtcodigo.ReadOnly = True

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
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim testString As String = cadena
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
        Return RTrim(texto)
    End Function
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And Trim(txtcodigo.Text) <> "") Then

                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objCategoriaif As New ClsCategoria
                With objCategoriaif
                    .descripcion1 = rtxtdescripcion.Text
                    .codigoCategoria_ = txtcodigo.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                    .codigo_ = lblcode.Text
                End With

                If objCategoriaif.ModificarCategoria() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objCategoriaif.SeleccionarCategoria.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtdescripcion.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True
                    txtcodigo.ReadOnly = True

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
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtcodigoTipo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            M_Cliente.lblcodeCategoria.Text = lblcode.Text
            M_Cliente.txtcodigoCategoria.Text = txtcodigo.Text
            M_Cliente.txtnombreCategoria.Text = rtxtdescripcion.Text

            btnmodificar.Enabled = True

            rtxtdescripcion.ReadOnly = False
            txtcodigoTipo.ReadOnly = False
            txtcodigo.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub txtcodigoTipo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTipo.TextChanged
        txtdescripcionTipo.Text = ""
        If (Trim(txtcodigoTipo.Text) <> "") Then
            Try
                Dim objTipoClas As New ClsTipoClasificacion
                With objTipoClas
                    .Codigo1 = txtcodigoTipo.Text
                End With
                Dim dt As New DataTable
                dt = objTipoClas.BuscarTipoClasificacionCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionTipo.Text = CStr(row("comentario"))
                txtcodigoTipo.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTipo.BackColor = Color.Red
                txtdescripcionTipo.Text = ""
            End Try
        Else
            txtcodigoTipo.Text = ""
            txtdescripcionTipo.Text = ""
            txtcodigoTipo.BackColor = Color.White
        End If
    End Sub
    Private Sub btnbuscarTipo_Click_1(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_TipoClasificacion.lbltipo.Text = "Categoria"
        M_TipoClasificacion.ShowDialog()
    End Sub

    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        Try

            Dim objCategoria As New ClsCategoria
            With objCategoria
                .descripcion1 = txtdescripcionB.Text
            End With
            If (Trim(txtdescripcionB.Text) <> "") Then
                Dim dv As DataView = objCategoria.BuscarCategoria.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objCategoria.SeleccionarCategoria.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class