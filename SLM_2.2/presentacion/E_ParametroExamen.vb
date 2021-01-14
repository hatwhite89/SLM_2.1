Public Class E_ParametroExamen
    Private Sub eg_frmParametroExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()

        If dgbtabla.Columns.Contains("cbx") = False Then
            Dim cmb As New DataGridViewComboBoxColumn()
            dgbtabla.Columns.Add(cmb)
            cmb.HeaderText = "Val. Por Defecto"
            cmb.Items.Add("No")
            cmb.Items.Add("Si")
            cmb.Name = "cbx"
        End If

        If dgbtabla.Columns.Contains("btnEliminar") = False Then
            Dim btn As New DataGridViewButtonColumn()
            dgbtabla.Columns.Add(btn)
            btn.HeaderText = "Eliminar"
            btn.Text = "Eliminar"
            btn.Name = "btnEliminar"
            btn.UseColumnTextForButtonValue = True
        End If
        alternarColoFilasDatagridview(dgbtabla)

    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
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
        E_Unidad.Show()
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
                txtcodigoUnidad.BackColor = Color.White
            Catch ex As Exception
                txtcodigoUnidad.BackColor = Color.Red
                txtcomentarioUnidad.Text = ""
            End Try
        Else
            txtcodigoUnidad.Text = ""
            txtcomentarioUnidad.Text = ""
            lblcodeUnidad.Text = ""
            txtcodigoUnidad.BackColor = Color.White
        End If
    End Sub
    Private Sub deshabilitar()
        txtcodigo.ReadOnly = True
        rtxtdescripcion.ReadOnly = True
        txtcodigoUnidad.ReadOnly = True
        txtBreve.ReadOnly = True
        cbxRequiereDet.Enabled = False
        cbxNoCalc.Enabled = False

        dgbtabla.ReadOnly = True

        btnbuscarUnidad.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub limpiar()
        Try

            txtcodigo.Text() = ""
            rtxtdescripcion.Text() = ""
            txtcodigoUnidad.Text() = ""
            txtBreve.Text() = ""
            cbxNoCalc.Checked = False
            cbxRequiereDet.Checked = False

            lblcode.Text = ""
            lblcodeUnidad.Text = ""

            txtcodigo.ReadOnly = False
            rtxtdescripcion.ReadOnly = False
            txtcodigoUnidad.ReadOnly = False
            txtBreve.ReadOnly = False
            cbxNoCalc.Enabled = True
            cbxRequiereDet.Enabled = True

            dgbtabla.Rows.Clear()

            btnbuscarUnidad.Enabled = True
            btnmodificar.Enabled = False
            btnguardar.Enabled = True
            btnnuevo.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        btnguardar.Enabled = True
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
            rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtcodigo.Text) <> "") Then

                Dim objParamExam As New ClsParametroExamen
                If (lblcodeUnidad.Text <> "") Then
                    objParamExam.codigoUnidad_ = lblcodeUnidad.Text
                End If
                'Convert.ToInt32(lblcodeUnidad.Text)
                With objParamExam
                    .codigoParametroExam_ = txtcodigo.Text
                    .Descripcion_ = rtxtdescripcion.Text
                    .requiereDet_ = cbxRequiereDet.Checked
                    .breve_ = txtBreve.Text
                    .noCalc_ = cbxNoCalc.Checked
                End With

                If objParamExam.RegistrarNuevoParametroExamen() = 1 Then
                    deshabilitar()
                    Dim dt As New DataTable
                    dt = objParamExam.BuscarParametroExamen()
                    Dim row As DataRow = dt.Rows(0)

                    lblcode.Text = CStr(row("codigo"))
                    Dim objParExamDet As New ClsParametroExamenDetalle
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        With objParExamDet
                            .codigoParametroExam_ = Convert.ToInt32(lblcode.Text)
                            .posibleResultado_ = dgbtabla.Rows(index).Cells(0).Value()
                            .valPorDefecto_ = dgbtabla.Rows(index).Cells(1).Value()
                        End With
                        If objParExamDet.RegistrarNuevoParametroExamenDetalle() = 0 Then
                            MsgBox("Error al querer insertar el posible resultado.")
                        End If
                    Next
                    MsgBox("Registrado el parámetro correctamente.")
                Else
                    MsgBox("Error al querer ingresar el parámetro de examen.", MsgBoxStyle.Critical)
                End If


            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub
End Class