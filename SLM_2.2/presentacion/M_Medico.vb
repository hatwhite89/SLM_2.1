Public Class M_Medico

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub btnbuscarEspecialidad2_Click(sender As Object, e As EventArgs) Handles btnbuscarEspecialidad2.Click
        M_Especialidad2.Show()
    End Sub
    Private Sub btnbuscarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnbuscarEspecialidad.Click
        M_Especialidad.Show()
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
            Dim numero As Integer = 0

            txtcorreo.Text = sinDobleEspacio(txtcorreo.Text)
            txtcorreo2.Text = sinDobleEspacio(txtcorreo2.Text)
            txttelefono.Text = sinDobleEspacio(txttelefono.Text)
            txtcelular.Text = sinDobleEspacio(txtcelular.Text)
            txtnombreCompleto.Text = sinDobleEspacio(txtnombreCompleto.Text)

            If (Trim(txtcorreo.Text) <> "") Then
                numero += 1
            ElseIf (Trim(txtcorreo2.Text) <> "") Then
                numero += 1
            ElseIf (Trim(txttelefono.Text) <> "") Then
                numero += 1
            ElseIf (Trim(txtcelular.Text) <> "") Then
                numero += 1
            Else
                numero = 0
            End If
            If (Trim(txtnombreCompleto.Text) <> "" And numero > 0) Then
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = txtnombreCompleto.Text
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    If Trim(txtcodigoEspecialidad.Text) <> "" And txtcodigoEspecialidad.BackColor = Color.White Then
                        .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                    End If
                    If Trim(txtcodigoEspecialidad2.Text) <> "" And txtcodigoEspecialidad2.BackColor = Color.White Then
                        .codigo_especialidad2_ = txtcodigoEspecialidad2.Text
                    End If
                End With

                If objMedico.RegistrarNuevoMedico() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information)

                    Dim dv As DataView = objMedico.SeleccionarMedico.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcorreo.ReadOnly = True
                    txtcorreo2.ReadOnly = True
                    txttelefono.ReadOnly = True
                    txtcelular.ReadOnly = True
                    txtcodigoEspecialidad.ReadOnly = True
                    txtcodigoEspecialidad2.ReadOnly = True
                    txtcodigo.ReadOnly = True
                    txtnombreCompleto.ReadOnly = True
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el médico.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcorreo.Text() = ""
        txtcorreo2.Text() = ""
        txttelefono.Text() = ""
        txtcelular.Text() = ""
        txtcodigoEspecialidad.Text() = ""
        txtcodigoEspecialidad2.Text() = ""
        txtcodigo.Text() = ""
        txtnombreCompleto.Text() = ""
        txtnombreEspecialidad.Text() = ""
        txtnombreEspecialidad2.Text() = ""

        txtcorreo.ReadOnly = False
        txtcorreo2.ReadOnly = False
        txttelefono.ReadOnly = False
        txtcelular.ReadOnly = False
        txtcodigoEspecialidad.ReadOnly = False
        txtcodigoEspecialidad2.ReadOnly = False
        txtcodigo.ReadOnly = True
        txtnombreCompleto.ReadOnly = False

        btnbuscarEspecialidad.Enabled = True
        btnbuscarEspecialidad2.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub txtnombreCompleto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreCompleto.KeyPress

        If Char.IsPunctuation(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        'txtnombreCompleto.Select(txtnombreCompleto.Text.Length, 0)
    End Sub
    Private Sub txtcodigoEspecialidad2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoEspecialidad2.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodigoEspecialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoEspecialidad.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub M_CrearMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objMed As New ClsMedico
        Dim dv As DataView = objMed.SeleccionarMedico.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        'OCULTAR COLUMNAS
        Me.dgbtabla.Columns("codigo_especialidad").Visible = False
        Me.dgbtabla.Columns("codigo_especialidad2").Visible = False
        'Me.dgbtabla.Columns("observacion").Visible = False

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("nombre_completo").HeaderText = "Nombre Completo"
        dgbtabla.Columns("correo").HeaderText = "Correo"
        dgbtabla.Columns("correo2").HeaderText = "Correo 2"
        dgbtabla.Columns("telefono").HeaderText = "Teléfono"
        dgbtabla.Columns("celular").HeaderText = "Celular"

        txtcorreo.ReadOnly = True
        txtcorreo2.ReadOnly = True
        txttelefono.ReadOnly = True
        txtcelular.ReadOnly = True
        txtcodigoEspecialidad.ReadOnly = True
        txtcodigoEspecialidad2.ReadOnly = True
        txtcodigo.ReadOnly = True
        txtnombreCompleto.ReadOnly = True

        btnbuscarEspecialidad.Enabled = False
        btnbuscarEspecialidad2.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            limpiar()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value().ToString) <> "0" Then
                txtcodigoEspecialidad.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            Else
                txtcodigoEspecialidad.Text = ""
            End If
            txtnombreCompleto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtcorreo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            txtcorreo2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            txttelefono.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            txtcelular.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
            If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value().ToString) <> "0" Then
                txtcodigoEspecialidad2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
            Else
                txtcodigoEspecialidad2.Text = ""
            End If

            btnmodificar.Enabled = True
            btnguardar.Enabled = False
            btnbuscarEspecialidad.Enabled = True
            btnbuscarEspecialidad2.Enabled = True

            txtcorreo.ReadOnly = False
            txtcorreo2.ReadOnly = False
            txttelefono.ReadOnly = False
            txtcelular.ReadOnly = False
            txtcodigoEspecialidad.ReadOnly = False
            txtcodigoEspecialidad2.ReadOnly = False
            txtcodigo.ReadOnly = True
            txtnombreCompleto.ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblForm.Text = "M_Factura") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el médico en la factura?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Factura.txtcodigoMedico.Text = txtcodigo.Text
                    M_Factura.txtnombreMedico.Text = txtnombreCompleto.Text
                    Me.Close()
                End If
            ElseIf (lblForm.Text = "M_DiarioFacturacion") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el médico en el diario de facturación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_ListaPrecios.lblcodeT.Text = lblcode.Text
                    M_DiarioFacturacion.txtNombreMedico.Text = txtnombreCompleto.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            Dim numero As Integer = 0

            txtcorreo.Text = sinDobleEspacio(txtcorreo.Text)
            txtcorreo2.Text = sinDobleEspacio(txtcorreo2.Text)
            txttelefono.Text = sinDobleEspacio(txttelefono.Text)
            txtcelular.Text = sinDobleEspacio(txtcelular.Text)
            txtnombreCompleto.Text = sinDobleEspacio(txtnombreCompleto.Text)

            If (Trim(txtcorreo.Text) <> "") Then
                numero += 1
            ElseIf (Trim(txtcorreo2.Text) <> "") Then
                numero += 1
            ElseIf (Trim(txttelefono.Text) <> "") Then
                numero += 1
            ElseIf (Trim(txtcelular.Text) <> "") Then
                numero += 1
            Else
                numero = 0
            End If
            If (Trim(txtnombreCompleto.Text) <> "" And Trim(txtcodigo.Text) <> "") Then
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = txtnombreCompleto.Text
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    If Trim(txtcodigoEspecialidad.Text) <> "" And txtcodigoEspecialidad.BackColor = Color.White Then
                        .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                    End If
                    If Trim(txtcodigoEspecialidad2.Text) <> "" And txtcodigoEspecialidad2.BackColor = Color.White Then
                        .codigo_especialidad2_ = txtcodigoEspecialidad2.Text
                        MsgBox("entra y pone el valor necesario")
                    End If
                    .Codigo1 = txtcodigo.Text
                End With

                If objMedico.ModificarMedico() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)

                    Dim dv As DataView = objMedico.SeleccionarMedico.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcorreo.ReadOnly = True
                    txtcorreo2.ReadOnly = True
                    txttelefono.ReadOnly = True
                    txtcelular.ReadOnly = True
                    txtcodigoEspecialidad.ReadOnly = True
                    txtcodigoEspecialidad2.ReadOnly = True
                    txtcodigo.ReadOnly = True
                    txtnombreCompleto.ReadOnly = True

                    btnbuscarEspecialidad.Enabled = False
                    btnbuscarEspecialidad2.Enabled = False
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el médico.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoEspecialidad2_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoEspecialidad2.TextChanged
        If (txtcodigoEspecialidad2.Text <> "") Then
            Try
                Dim objEsp As New ClsEspecialidad2
                With objEsp
                    .Codigo1 = txtcodigoEspecialidad2.Text
                End With
                Dim dt As New DataTable
                dt = objEsp.BuscarEspecialidad2Code()
                Dim row As DataRow = dt.Rows(0)
                txtnombreEspecialidad2.Text = CStr(row("nombre"))
                txtcodigoEspecialidad2.BackColor = Color.White
            Catch ex As Exception
                txtcodigoEspecialidad2.BackColor = Color.Red
                txtnombreEspecialidad2.Text = ""
                'MsgBox("No existe ese código de especialidad.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoEspecialidad2.Text = ""
            txtnombreEspecialidad2.Text = ""
            txtcodigoEspecialidad2.BackColor = Color.White
        End If
    End Sub
    Private Sub txtcodigoEspecialidad_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoEspecialidad.TextChanged
        If (txtcodigoEspecialidad.Text <> "") Then
            Try
                Dim objEsp As New ClsEspecialidad
                With objEsp
                    .Codigo1 = txtcodigoEspecialidad.Text
                End With
                Dim dt As New DataTable
                dt = objEsp.BuscarEspecialidadCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreEspecialidad.Text = CStr(row("nombre"))
                txtcodigoEspecialidad.BackColor = Color.White
            Catch ex As Exception
                txtcodigoEspecialidad.BackColor = Color.Red
                txtnombreEspecialidad.Text = ""
                'MsgBox("No existe ese código de especialidad.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoEspecialidad.Text = ""
            txtnombreEspecialidad.Text = ""
            txtcodigoEspecialidad.BackColor = Color.White
        End If
    End Sub

    Private Sub txtNombreEspecialidadB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreEspecialidadB.TextChanged
        Dim objMed As New ClsMedico
        With objMed
            .Nombre_completo1 = txtNombreEspecialidadB.Text
        End With
        Dim dv As DataView = objMed.BuscarMedicoEspecialidad.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Dim objMed As New ClsMedico
        With objMed
            .Nombre_completo1 = txtnombreB.Text
        End With
        Dim dv As DataView = objMed.BuscarMedico.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
End Class