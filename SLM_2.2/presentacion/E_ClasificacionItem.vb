Public Class E_ClasificacionItem
    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_TipoClasificacion.lbltipo.Text = "ClasificacionItem"
        M_TipoClasificacion.Show()
    End Sub
    Private Sub M_ClasificacionItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objClasItem As New ClsClasificacionItem
        Dim dv As DataView = objClasItem.SeleccionarClasificacionItem.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        dgbtabla.Columns("codigo").Visible = False
        limpiar()
        deshabilitar()

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub limpiar()

        lblcode.Text = ""
        txtcodigo.Text() = ""
        txtcodigoTipo.Text() = ""
        txtNombreB.Text() = ""
        txtcomentarioTipo.Text() = ""
        rtxtNombre.Text() = ""

        txtcodigoTipo.ReadOnly = False
        txtNombreB.ReadOnly = False
        rtxtNombre.ReadOnly = False
        txtcodigo.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True

    End Sub
    Private Sub deshabilitar()

        rtxtNombre.ReadOnly = True
        txtcodigoTipo.ReadOnly = True
        txtcodigo.ReadOnly = True
        btnbuscarTipo.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = False

    End Sub
    Private Sub habilitar()

        rtxtNombre.ReadOnly = False
        txtcodigoTipo.ReadOnly = False
        txtcodigo.ReadOnly = False
        btnbuscarTipo.Enabled = True

    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub txtcodigoTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoTipo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(rtxtNombre.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And Trim(txtcodigo.Text) <> "") Then
                Dim testString As String = rtxtNombre.Text()
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
                rtxtNombre.Text() = RTrim(texto)

                Dim objClasItemif As New ClsClasificacionItem
                With objClasItemif
                    .nombre_ = rtxtNombre.Text
                    .CodigoTipo_ = txtcodigoTipo.Text
                    .codigoClasificacionItem_ = txtcodigo.Text
                End With

                If objClasItemif.RegistrarNuevaClasificacionItem() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objClasItemif.SeleccionarClasificacionItem.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    deshabilitar()

                Else
                    MsgBox("Error al querer ingresar la clasificación del item.", MsgBoxStyle.Critical)
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

            If (Trim(rtxtNombre.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And Trim(txtcodigo.Text) <> "") Then
                Dim testString As String = rtxtNombre.Text()
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
                rtxtNombre.Text() = RTrim(texto)

                Dim objClasItemif As New ClsClasificacionItem
                With objClasItemif
                    .nombre_ = rtxtNombre.Text
                    .CodigoTipo_ = txtcodigoTipo.Text
                    .codigoClasificacionItem_ = txtcodigo.Text
                    .Codigo_ = lblcode.Text
                End With

                If objClasItemif.ModificarClasificacionItem() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objClasItemif.SeleccionarClasificacionItem.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    deshabilitar()
                Else
                    MsgBox("Error al querer modificar la clasificación del item.", MsgBoxStyle.Critical)
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
            rtxtNombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtcodigoTipo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            habilitar()
            btnmodificar.Enabled = True
            btnguardar.Enabled = False
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

    Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Dim objClasItem As New ClsClasificacionItem
        With objClasItem
            .nombre_ = txtNombreB.Text
        End With
        Dim dv As DataView = objClasItem.BuscarClasificacionItemName.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
End Class