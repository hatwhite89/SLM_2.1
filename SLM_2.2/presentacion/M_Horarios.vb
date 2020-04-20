﻿Public Class M_Horarios

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtcodigoBreve.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""
        dtpEntrada.Value() = Date.Now()
        dtpSalida.Value() = Date.Now()
        cbxLunes.Checked = False
        cbxMartes.Checked = False
        cbxMiercoles.Checked = False
        cbxJueves.Checked = False
        cbxViernes.Checked = False
        cbxSabado.Checked = False
        cbxDomingo.Checked = False
        rtxtObservacion.Text() = ""

        txtcodigoBreve.ReadOnly = False
        txtnombre.ReadOnly = False
        dtpEntrada.Enabled = True
        dtpSalida.Enabled = True
        rtxtObservacion.ReadOnly = False
        cbxLunes.Enabled = True
        cbxMartes.Enabled = True
        cbxMiercoles.Enabled = True
        cbxJueves.Enabled = True
        cbxViernes.Enabled = True
        cbxSabado.Enabled = True
        cbxDomingo.Enabled = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub deshabilitar()

        txtcodigoBreve.ReadOnly = True
        txtnombre.ReadOnly = True
        dtpEntrada.Enabled = False
        dtpSalida.Enabled = False
        rtxtObservacion.ReadOnly = True
        cbxLunes.Enabled = False
        cbxMartes.Enabled = False
        cbxMiercoles.Enabled = False
        cbxJueves.Enabled = False
        cbxViernes.Enabled = False
        cbxSabado.Enabled = False
        cbxDomingo.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
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
            If txtcodigoBreve.TextLength = 0 Then
                txtcodigoBreve.BackColor = Color.Red
            Else
                txtcodigoBreve.BackColor = Color.White
            End If
            If txtnombre.TextLength = 0 Then
                txtnombre.BackColor = Color.Red
            Else
                txtnombre.BackColor = Color.White
            End If

            If (txtcodigoBreve.BackColor = Color.White And txtnombre.BackColor = Color.White) Then
                Dim objHorario As New ClsHorarios
                With objHorario
                    .codigoBreve_ = txtcodigoBreve.Text
                    .Nombre_ = txtnombre.Text
                    .entrada_ = dtpEntrada.Value
                    .salida_ = dtpSalida.Value
                    .lunes_ = cbxLunes.Checked
                    .martes_ = cbxMartes.Checked
                    .miercoles_ = cbxMiercoles.Checked
                    .jueves_ = cbxJueves.Checked
                    .viernes_ = cbxViernes.Checked
                    .sabado_ = cbxSabado.Checked
                    .domingo_ = cbxDomingo.Checked
                    .observacion_ = rtxtObservacion.Text
                End With

                If objHorario.RegistrarNuevoHorario() = 1 Then
                    MsgBox("Registrado el horario de trabajo correctamente.")

                    seleccionarHorarios()

                    deshabilitar()
                Else
                    MsgBox("Error al querer ingresar el horario de trabajo.", MsgBoxStyle.Critical)
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
            If (txtcodigoBreve.BackColor = Color.White And txtnombre.BackColor = Color.White And txtcodigo.Text <> "") Then
                Dim objHorario As New ClsHorarios
                With objHorario
                    .Codigo_ = txtcodigo.Text
                    .codigoBreve_ = txtcodigoBreve.Text
                    .Nombre_ = txtnombre.Text
                    .entrada_ = dtpEntrada.Value
                    .salida_ = dtpSalida.Value
                    .lunes_ = cbxLunes.Checked
                    .martes_ = cbxMartes.Checked
                    .miercoles_ = cbxMiercoles.Checked
                    .jueves_ = cbxJueves.Checked
                    .viernes_ = cbxViernes.Checked
                    .sabado_ = cbxSabado.Checked
                    .domingo_ = cbxDomingo.Checked
                    .observacion_ = rtxtObservacion.Text
                End With

                If objHorario.ModificarHorario() = 1 Then
                    MsgBox("Modificado el horario de trabajo correctamente.")

                    seleccionarHorarios()
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el horario de trabajo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            limpiar()

            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigoBreve.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            dtpEntrada.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value().ToString
            dtpSalida.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value().ToString
            cbxLunes.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            cbxMartes.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
            cbxMiercoles.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
            cbxJueves.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value()
            cbxViernes.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value()
            cbxSabado.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(10).Value()
            cbxDomingo.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(11).Value()
            rtxtObservacion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(12).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_Empleados") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el horario de trabajo en el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Empleados.txtcodigoHorario.Text = txtcodigo.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_Sede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarHorarios()
        Me.dgbtabla.Columns("lunes").Visible = False
        Me.dgbtabla.Columns("martes").Visible = False
        Me.dgbtabla.Columns("miercoles").Visible = False
        Me.dgbtabla.Columns("jueves").Visible = False
        Me.dgbtabla.Columns("viernes").Visible = False
        Me.dgbtabla.Columns("sabado").Visible = False
        Me.dgbtabla.Columns("domingo").Visible = False
        Me.dgbtabla.Columns("observacion").Visible = False
    End Sub
    Private Sub seleccionarHorarios()
        Try
            Dim objHorario As New ClsHorarios
            Dim dv As DataView = objHorario.SeleccionarHorario.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            deshabilitar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objHorario As New ClsHorarios
            With objHorario
                .Nombre_ = txtnombreB.Text
            End With
            Dim dv As DataView = objHorario.BuscarHorarioNombre.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcodigoBreve_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoBreve.TextChanged
        If txtcodigoBreve.TextLength = 0 Then
            txtcodigoBreve.BackColor = Color.Red
        Else
            txtcodigoBreve.BackColor = Color.White
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If txtnombre.TextLength = 0 Then
            txtnombre.BackColor = Color.Red
        Else
            txtnombre.BackColor = Color.White
        End If
    End Sub
End Class