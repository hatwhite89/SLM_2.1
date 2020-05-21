Public Class M_CAI
    Private Sub limpiar()
        mtxtCAI.Text = ""
        dtpDesdeFecha.Value = Date.Now
        dtpHastaFecha.Value = Date.Now
        mtxtserie.Text = ""
        mtxtdesde.Text = ""
        mtxthasta.Text = ""
        txtcodigoMaquina.Text = ""

        mtxtCAI.ReadOnly = False
        dtpDesdeFecha.Enabled = True
        dtpHastaFecha.Enabled = True
        mtxtserie.ReadOnly = False
        mtxtdesde.ReadOnly = False
        mtxthasta.ReadOnly = False

        btnbuscarMaquinaLocal.Enabled = True
        btnguardar.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub mtxtserie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtserie.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub mtxthasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxthasta.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub mtxtdesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtdesde.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If (mtxtCAI.MaskCompleted = True And dtpDesdeFecha.Value <= dtpHastaFecha.Value And Trim(txtcodigoMaquina.Text) <> "" And
                mtxtserie.MaskCompleted = True And mtxtdesde.MaskCompleted = True And mtxthasta.MaskCompleted = True And txtcodigoMaquina.BackColor = Color.White) Then

                Dim objCAI As New ClsCAI
                With objCAI
                    .CAI_ = mtxtCAI.Text
                    .desdeFecha_ = dtpDesdeFecha.Text
                    .hastaFecha_ = dtpHastaFecha.Text
                    .serie_ = mtxtserie.Text
                    .desde_ = mtxtdesde.Text
                    .hasta_ = mtxthasta.Text
                    .codigoMaquinaLocal_ = lblCodeMaquinaLocal.Text
                End With

                If objCAI.RegistrarNuevoCAI() = 1 Then
                    'limpiar()
                    btnguardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objCAI.CapturarCAI()
                    Dim row As DataRow = dt.Rows(0)

                    Dim objDetCAI As New ClsDetalleCAI
                    objDetCAI.codigoCAI_ = Convert.ToInt64(CStr(row("codigo")))

                    Dim cant As Integer = Convert.ToInt64(mtxthasta.Text) - Convert.ToInt64(mtxtdesde.Text)

                    If objDetCAI.RegistrarNuevoDetalleCAI(mtxtserie.Text, mtxtdesde.Text.ToString, cant) = 1 Then
                        MsgBox("Registrado correctamente.")
                    Else
                        MsgBox("Error al querer ingresar el detalle del CAI.", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Error al querer ingresar el CAI.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtcodigoMaquina_TextChanged_1(sender As Object, e As EventArgs) Handles txtcodigoMaquina.TextChanged

        If (Trim(txtcodigoMaquina.Text) <> "") Then
            Try
                Dim objMaq As New ClsMaquinasLocales
                With objMaq
                    .codigoMaquinasLocales_ = txtcodigoMaquina.Text
                End With
                Dim dt As New DataTable
                dt = objMaq.BuscarMaquinasLocales()
                Dim row As DataRow = dt.Rows(0)
                lblCodeMaquinaLocal.Text = CStr(row("codigo"))
                txtcodigoMaquina.BackColor = Color.White
                txtdescripcionMaquina.Text = CStr(row("descripcion"))
            Catch ex As Exception
                lblCodeMaquinaLocal.Text = ""
                txtcodigoMaquina.BackColor = Color.Red
                txtdescripcionMaquina.Text = ""
            End Try
        Else
            lblCodeMaquinaLocal.Text = ""
            txtdescripcionMaquina.Text = ""
            txtcodigoMaquina.BackColor = Color.White
        End If
    End Sub
    Private Sub lblCodeMaquinaLocal_TextChanged(sender As Object, e As EventArgs) Handles lblCodeMaquinaLocal.TextChanged
        If (lblCodeMaquinaLocal.Text <> "") Then
            Try
                Dim objMaq As New ClsMaquinasLocales
                With objMaq
                    .codigo_ = lblCodeMaquinaLocal.Text
                End With
                Dim dt As New DataTable
                dt = objMaq.BuscarMaquinasLocalesCode()
                Dim row As DataRow = dt.Rows(0)
                txtcodigoMaquina.Text = CStr(row("codigoMaquinasLocales"))
                txtcodigoMaquina.BackColor = Color.White
                txtdescripcionMaquina.Text = CStr(row("descripcion"))
            Catch ex As Exception
                lblCodeMaquinaLocal.Text = ""
                txtcodigoMaquina.Text = ""
                txtcodigoMaquina.BackColor = Color.Red
                txtdescripcionMaquina.Text = ""
            End Try
        Else
            lblCodeMaquinaLocal.Text = ""
            txtcodigoMaquina.Text = ""
            txtcodigoMaquina.BackColor = Color.Red
            txtdescripcionMaquina.Text = ""
        End If
    End Sub
    Private Sub btnbuscarMaquinaLocal_Click(sender As Object, e As EventArgs) Handles btnbuscarMaquinaLocal.Click
        M_MaquinasLocales.lblform.Text = "M_CAI"
        M_MaquinasLocales.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            If lblCodigo.Text <> "" Then

                Dim CAI As New ClsCAI

                With CAI

                    .Codigo_ = Convert.ToInt32(lblCodigo.Text)
                    .estado_ = chkEstado.Checked

                    'Habilitar CAI
                    If .HabilitarCAI = 1 Then
                        MsgBox("Se habilito el registro de CAI.")
                        limpiar()

                    End If

                End With

            End If

        Catch ex As Exception
            MsgBox("No se seleccionó un registro o ocurrio un error." + ex.Message)
        End Try

    End Sub

    Private Sub M_CAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblCodigo.Text <> "" Then
            btnModificar.Enabled = True

            Dim maquina As New ClsMaquinasLocales
            With maquina
                .codigo_ = Convert.ToInt32(lblCodeMaquinaLocal.Text)

            End With

            Dim dt As New DataTable
            dt = maquina.BuscarMaquinasLocalesCode()

            Dim row As DataRow
            row = dt.Rows(0)

            txtcodigoMaquina.Text = row("codigoMaquinasLocales")
            txtdescripcionMaquina.Text = row("descripcion")

        Else
            btnModificar.Enabled = False
        End If

    End Sub
End Class