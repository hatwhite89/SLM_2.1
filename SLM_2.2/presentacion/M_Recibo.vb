Public Class M_Recibo
    Private Sub btnbuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnbuscarFormaPago.Click
        A_ListarFormasPagoPF.lblForm.Text = "M_Recibo"
        A_ListarFormasPagoPF.ShowDialog()
    End Sub

    Private Sub txtcodigoFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.TextChanged
        If (txtcodigoFormaPago.Text <> "") Then
            Try
                Dim objFrmPgo As New ClsFormaPago
                With objFrmPgo
                    .Cod = txtcodigoFormaPago.Text
                End With
                Dim dt As New DataTable
                dt = objFrmPgo.buscarCodigoFormaPago()
                Dim row As DataRow = dt.Rows(0)
                txtnombreFormaPago.Text = CStr(row("nombreBanco"))
                lblcodeFormaPago.Text = CStr(row("codFormaPago"))
                txtcodigoFormaPago.BackColor = Color.White
            Catch ex As Exception
                txtcodigoFormaPago.BackColor = Color.Red
                txtnombreFormaPago.Text = ""
                lblcodeFormaPago.Text = ""
            End Try
        Else
            txtcodigoFormaPago.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            txtcodigoFormaPago.BackColor = Color.White
        End If
    End Sub
    Private Sub limpiar()
        Try

            txtnumero.Text = ""
            dtpFechaTrans.Value = Date.Now
            rtxtReferencia.Text = ""
            txtcodigoFormaPago.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            cbxInfoClte.Checked = False
            cbxOk.Checked = False
            dgbtabla.Rows.Clear()

            dtpFechaTrans.Enabled = True
            rtxtReferencia.ReadOnly = False
            txtcodigoFormaPago.ReadOnly = False
            cbxInfoClte.Enabled = True
            cbxOk.Enabled = True
            dgbtabla.ReadOnly = False

            btnmodificar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub deshabilitar()

        dtpFechaTrans.Enabled = False
        rtxtReferencia.ReadOnly = True
        txtcodigoFormaPago.ReadOnly = True
        cbxInfoClte.Enabled = False
        cbxOk.Enabled = False
        dgbtabla.ReadOnly = True

        btnmodificar.Enabled = True
        btnguardar.Enabled = False
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
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
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            rtxtReferencia.Text = sinDobleEspacio(rtxtReferencia.Text)
            If (Trim(rtxtReferencia.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "" And dgbtabla.Rows.Count > 0) Then

                Dim objRbo As New ClsRecibo

                With objRbo
                    .fechaTrans_ = dtpFechaTrans.Value
                    .referencia_ = rtxtReferencia.Text
                    .codigoFormaPago_ = lblcodeFormaPago.Text
                    .infoClte_ = cbxInfoClte.Checked
                    .ok_ = cbxOk.Checked
                End With

                If objRbo.referencia_() = 1 Then
                    deshabilitar()
                    Dim dt As New DataTable
                    'dt = objRbo.BuscarParametroExamen()
                    Dim row As DataRow = dt.Rows(0)

                    '   lblcode.Text = CStr(row("codigo"))
                    Dim objParExamDet As New ClsParametroExamenDetalle
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        With objParExamDet
                            '.codigoParametroExam_ = Convert.ToInt32(lblcode.Text)
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