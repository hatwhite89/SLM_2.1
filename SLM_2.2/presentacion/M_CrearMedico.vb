Public Class M_CrearMedico
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnbuscarEspecialidad.Click
        M_CrearEspecialidad.ShowDialog()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (txtnombreCompleto.Text <> "" And txtcorreo.Text <> "" And txtcorreo2.Text <> "" And txttelefono.Text <> "" And txtcelular.Text <> "" And txtcodigoEspecialidad.Text <> "") Then
                Dim testString As String = txtnombreCompleto.Text()
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
                txtnombreCompleto.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = texto
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                End With

                If objMedico.RegistrarNuevoMedico() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim objMed As New ClsMedico
                    Dim dv As DataView = objMed.SeleccionarMedico.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcorreo.ReadOnly = True
                    txtcorreo2.ReadOnly = True
                    txttelefono.ReadOnly = True
                    txtcelular.ReadOnly = True
                    txtcodigoEspecialidad.ReadOnly = True
                    txtcodigo.ReadOnly = True
                    txtnombreCompleto.ReadOnly = True
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el médico.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcorreo.Text() = ""
        txtcorreo2.Text() = ""
        txttelefono.Text() = ""
        txtcelular.Text() = ""
        txtcodigoEspecialidad.Text() = ""
        txtcodigo.Text() = ""
        txtnombreCompleto.Text() = ""

        txtcorreo.ReadOnly = False
        txtcorreo2.ReadOnly = False
        txttelefono.ReadOnly = False
        txtcelular.ReadOnly = False
        txtcodigoEspecialidad.ReadOnly = False
        txtcodigo.ReadOnly = True
        txtnombreCompleto.ReadOnly = False

        btnbuscarEspecialidad.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
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

        txtnombreCompleto.Select(txtnombreCompleto.Text.Length, 0)
    End Sub

    Private Sub txtcodigoEspecialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoEspecialidad.KeyPress

        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If

    End Sub


    Private Sub M_CrearMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objMed As New ClsMedico
        Dim dv As DataView = objMed.SeleccionarMedico.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        txtcorreo.ReadOnly = True
        txtcorreo2.ReadOnly = True
        txttelefono.ReadOnly = True
        txtcelular.ReadOnly = True
        txtcodigoEspecialidad.ReadOnly = True
        txtcodigo.ReadOnly = True
        txtnombreCompleto.ReadOnly = True

        btnbuscarEspecialidad.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim objMed As New ClsMedico
        With objMed
            .Nombre_completo1 = txtnombreB.Text
        End With
        Dim dv As DataView = objMed.BuscarMedico.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigoEspecialidad.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombreCompleto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtcorreo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            txtcorreo2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            txttelefono.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            txtcelular.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()

            M_Factura2.txtcodigoMedico.Text = txtcodigo.Text
            M_Factura2.txtnombreMedico.Text = txtnombreCompleto.Text

            btnmodificar.Enabled = True
            btnbuscarEspecialidad.Enabled = True

            txtcorreo.ReadOnly = False
            txtcorreo2.ReadOnly = False
            txttelefono.ReadOnly = False
            txtcelular.ReadOnly = False
            txtcodigoEspecialidad.ReadOnly = False
            txtcodigo.ReadOnly = True
            txtnombreCompleto.ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (txtcodigo.Text <> "" And txtnombreCompleto.Text <> "" And txtcorreo.Text <> "" And txtcorreo2.Text <> "" And txttelefono.Text <> "" And txtcelular.Text <> "" And txtcodigoEspecialidad.Text <> "") Then
                Dim testString As String = txtnombreCompleto.Text()
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
                txtnombreCompleto.Text() = texto
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = texto
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                    .Codigo1 = txtcodigo.Text
                End With

                If objMedico.ModificarMedico() = 1 Then
                    MsgBox("Modificado correctamente.")
                    Dim objMed As New ClsMedico
                    Dim dv As DataView = objMed.SeleccionarMedico.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcorreo.ReadOnly = True
                    txtcorreo2.ReadOnly = True
                    txttelefono.ReadOnly = True
                    txtcelular.ReadOnly = True
                    txtcodigoEspecialidad.ReadOnly = True
                    txtcodigo.ReadOnly = True
                    txtnombreCompleto.ReadOnly = True

                    btnbuscarEspecialidad.Enabled = False
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el médico.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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
            Catch ex As Exception
                MsgBox("No existe ese código de especialidad.", MsgBoxStyle.Critical, "Validación")
            End Try
        End If
    End Sub


End Class