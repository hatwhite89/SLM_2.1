Public Class E_ParametroExamen
    Private Sub eg_frmParametroExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmb As New DataGridViewComboBoxColumn()
        dgbtabla.Columns.Add(cmb)
        cmb.HeaderText = "Val. Por Defecto"
        cmb.Items.Add("No")
        cmb.Items.Add("Si")
        cmb.Name = "cbx"

        Dim btn As New DataGridViewButtonColumn()
        dgbtabla.Columns.Add(btn)
        btn.HeaderText = "Eliminar"
        btn.Text = "Eliminar"
        btn.Name = "btnEliminar"
        btn.UseColumnTextForButtonValue = True
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub dgbtabla_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        If e.ColumnIndex = 2 Then
            Try
                Dim n As String = MsgBox("¿Desea eliminar el posible resultado?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub dgbtabla_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbtabla.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                If (Trim(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) <> "") Then
                    Dim posibleRes As String = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                    dgbtabla.Rows.Insert(e.RowIndex.ToString, New String() {posibleRes, "No"})
                Else
                    MsgBox("Debe ingresar un posible resultado.", MsgBoxStyle.Critical)
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                End If
            ElseIf e.ColumnIndex = 1 Then
                If (Trim(dgbtabla.Rows(e.RowIndex).Cells(0).Value()) = "") Then
                    MsgBox("Debe ingresar un posible resultado.", MsgBoxStyle.Critical)
                    dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnbuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnbuscarUnidad.Click
        E_Unidad.ShowDialog()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub txtcodigoUnidad_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoUnidad.TextChanged
        If (txtcodigoUnidad.Text <> "") Then
            Try
                Dim objUnidad As New ClsUnidad
                With objUnidad
                    .codigoUnidad_ = txtcodigoUnidad.Text
                End With
                Dim dt As New DataTable
                dt = objUnidad.BuscarUnidad()
                Dim row As DataRow = dt.Rows(0)
                txtcomentarioUnidad.Text = CStr(row("comentario"))
                lblcodeUnidad.Text = CStr(row("codigo"))
                txtcodigoUnidad.Text = UCase(txtcodigoUnidad.Text)
            Catch ex As Exception
                'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoUnidad.Text = ""
            txtcomentarioUnidad.Text = ""
        End If
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        rtxtdescripcion.Text() = ""
        txtcodigoUnidad.Text() = ""
        txtBreve.Text() = ""
        cbxNoCalc.Checked = False
        cbxRequiereDet.Checked = False

        txtcodigo.ReadOnly = False
        rtxtdescripcion.ReadOnly = False
        txtcodigoUnidad.ReadOnly = False
        txtBreve.ReadOnly = False
        cbxNoCalc.Enabled = False
        cbxRequiereDet.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
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
        Return texto
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtcodigo.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                txtcodigo.Text = RTrim(sinDobleEspacio(txtcodigo.Text))

                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigoTerminoPago_ = txtcodigo.Text
                    .Descripcion1 = rtxtdescripcion.Text
                End With

                If objTerm.RegistrarNuevaTerminoPago() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
                    dgbtabla.DataSource = dv
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True
                    txtcodigoUnidad.ReadOnly = True
                    txtBreve.ReadOnly = True
                    cbxRequiereDet.Enabled = False
                    cbxNoCalc.Enabled = False

                    btnbuscarUnidad.Enabled = False
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el término de pago.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class