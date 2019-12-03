﻿Public Class M_Medico
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub btnbuscarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnbuscarEspecialidad.Click
        M_Especialidad.ShowDialog()
    End Sub
    Private Function sinEspacios(ByVal cadena As String) As String
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
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim numero As Integer = 0
            Dim val, val2, val3, val4, val5 As String
            val = sinEspacios(txtcorreo.Text)
            val2 = sinEspacios(txtcorreo2.Text)
            val3 = sinEspacios(txttelefono.Text)
            val4 = sinEspacios(txtcelular.Text)
            val5 = sinEspacios(txtnombreCompleto.Text)

            txtcorreo.Text = val
            txtcorreo2.Text = val2
            txttelefono.Text = val3
            txtcelular.Text = val4
            txtnombreCompleto.Text = val5

            If (Trim(val) <> "") Then
                numero += 1
            ElseIf (Trim(val2) <> "") Then
                numero += 1
            ElseIf (Trim(val3) <> "") Then
                numero += 1
            ElseIf (Trim(val4) <> "") Then
                numero += 1
            Else
                numero = 0
            End If
            If (Trim(val5) <> "" And txtcodigoEspecialidad.Text <> "") Then
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = txtnombreCompleto.Text
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                End With

                If objMedico.RegistrarNuevoMedico() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objMedico.SeleccionarMedico.DefaultView
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
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcorreo.Text() = ""
        txtcorreo2.Text() = ""
        txttelefono.Text() = ""
        txtcelular.Text() = ""
        txtcodigoEspecialidad.Text() = ""
        txtcodigo.Text() = ""
        txtnombreCompleto.Text() = ""
        txtnombreEspecialidad.Text() = ""

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
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
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

            M_Factura.txtcodigoMedico.Text = txtcodigo.Text
            M_Factura.txtnombreMedico.Text = txtnombreCompleto.Text

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
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            Dim numero As Integer = 0
            Dim val, val2, val3, val4, val5, val6 As String
            val = sinEspacios(txtcorreo.Text)
            val2 = sinEspacios(txtcorreo2.Text)
            val3 = sinEspacios(txttelefono.Text)
            val4 = sinEspacios(txtcelular.Text)
            val5 = sinEspacios(txtnombreCompleto.Text)
            val6 = sinEspacios(txtcodigo.Text)

            txtcorreo.Text = val
            txtcorreo2.Text = val2
            txttelefono.Text = val3
            txtcelular.Text = val4
            txtnombreCompleto.Text = val5
            txtcodigo.Text = val6

            If (Trim(val) <> "") Then
                numero += 1
            ElseIf (Trim(val2) <> "") Then
                numero += 1
            ElseIf (Trim(val3) <> "") Then
                numero += 1
            ElseIf (Trim(val4) <> "") Then
                numero += 1
            Else
                numero = 0
            End If
            If (Trim(val5) <> "" And numero > 0 And txtcodigoEspecialidad.Text <> "" And Trim(val6) <> "") Then
                'If (txtcodigo.Text <> "" And txtnombreCompleto.Text <> "" And txtcorreo.Text <> "" And txtcorreo2.Text <> "" And txttelefono.Text <> "" And txtcelular.Text <> "" And txtcodigoEspecialidad.Text <> "") Then
                Dim objMedico As New ClsMedico
                With objMedico
                    .Nombre_completo1 = txtnombreCompleto.Text
                    .Correo1 = txtcorreo.Text
                    .Correo21 = txtcorreo2.Text
                    .Telefono1 = txttelefono.Text
                    .Celular1 = txtcelular.Text
                    .Codigo_especialidad1 = txtcodigoEspecialidad.Text
                    .Codigo1 = txtcodigo.Text
                End With

                If objMedico.ModificarMedico() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objMedico.SeleccionarMedico.DefaultView
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
End Class