﻿Public Class MM_Conserje
    Dim conserje As New ClsConserje


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub MM_Conserje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dgvData.DataSource = conserje.listarConserjes


            If dgvData.Columns.Contains("codConserje") Then

                alternarColoFilasDatagridview(dgvData)
                dgvData.Columns("codEmpleado").Visible = False

                dgvData.Columns("codConserje").HeaderText = "N# de Seguimiento"
                dgvData.Columns("nombre").HeaderText = "Nombre de Empleado"
                dgvData.Columns("rutaOrigen").HeaderText = "Origen"
                dgvData.Columns("rutaDestino").HeaderText = "Destino"
                dgvData.Columns("fechaSalida").HeaderText = "F. Salida"
                dgvData.Columns("fechaEntrega").HeaderText = "F. Entrega"
                dgvData.Columns("horaEntrega").HeaderText = "H. Entrega"
                dgvData.Columns("horaSalida").HeaderText = "H. Salida"
                dgvData.Columns("Observaciones").HeaderText = "Observa."
                dgvData.Columns("estado").HeaderText = "Estado"

            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim n As String = MsgBox("¿Desea guardar la tarea de conserje?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then

                'registro de conserjes

                With conserje

                    .Cod_Empleado = Integer.Parse(txtCodEmpleado.Text)
                    .ruta_Origen = txtrutaOrigen.Text
                    .ruta_Destino = txtrutaDestino.Text
                    .Observaciones_ = txtObservaciones.Text
                    .Estado_ = "En Proceso"

                    .fecha_Salida = dtpFechaSalida.Value
                    .hora_Salida = dtpHoraSalida.Value

                    .fecha_Entrega = dtpFechaEntrega.Value
                    .hora_Entrega = dtpHoraEntrega.Value

                    If .registrarNuevoConserje = 1 Then
                        MsgBox("Se registró exitosamente.")
                        limpiar()
                        dgvData.DataSource = .listarConserjes

                    End If

                End With
            End If
        Catch ex As Exception

            MsgBox("Hubo un error al registrar. " + ex.Message)

        End Try
    End Sub


    Sub limpiar()

        txtCod.Clear()
        txtCodEmpleado.Clear()
        txtNombreEmpleado.Clear()
        txtrutaOrigen.Clear()
        txtrutaDestino.Clear()
        txtObservaciones.Clear()
        lblEstado.Text = "---"
        dtpFechaEntrega.Value = Date.Now
        dtpFechaSalida.Value = Date.Now
        dtpHoraSalida.ResetText()
        dtpHoraEntrega.ResetText()
        txtNotas.Clear()


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim n As String = MsgBox("¿Desea modificar la tarea de conserje?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then


                With conserje
                    .Cod_Conserje = Integer.Parse(txtCod.Text)
                    .Cod_Empleado = Integer.Parse(txtCodEmpleado.Text)
                    .ruta_Origen = txtrutaOrigen.Text
                    .ruta_Destino = txtrutaDestino.Text
                    .Observaciones_ = txtObservaciones.Text
                    .Estado_ = "Entregado"

                    .fecha_Salida = dtpFechaSalida.Value
                    .hora_Salida = dtpHoraSalida.Value

                    .fecha_Entrega = dtpFechaEntrega.Value
                    .hora_Entrega = dtpHoraEntrega.Value

                    If .modificarConserje = 1 Then
                        MsgBox("Se modificó exitosamente.")
                        limpiar()
                        dgvData.DataSource = .listarConserjes

                    End If

                End With
            End If
        Catch ex As Exception

            MsgBox("Hubo un error al modificar. " + ex.Message)

        End Try

    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick


        Try

            txtCod.Text = dgvData.Rows(e.RowIndex).Cells(1).Value
            txtCodEmpleado.Text = dgvData.Rows(e.RowIndex).Cells(2).Value
            txtrutaOrigen.Text = dgvData.Rows(e.RowIndex).Cells(3).Value
            txtrutaDestino.Text = dgvData.Rows(e.RowIndex).Cells(4).Value
            dtpFechaSalida.Value = dgvData.Rows(e.RowIndex).Cells(5).Value
            dtpHoraSalida.Text = dgvData.Rows(e.RowIndex).Cells(6).Value.ToString

            dtpFechaEntrega.Value = dgvData.Rows(e.RowIndex).Cells(7).Value
            dtpHoraEntrega.Text = dgvData.Rows(e.RowIndex).Cells(8).Value.ToString

            txtObservaciones.Text = dgvData.Rows(e.RowIndex).Cells(9).Value
            lblEstado.Text = dgvData.Rows(e.RowIndex).Cells(10).Value
            txtNotas.Text = dgvData.Rows(e.RowIndex).Cells(11).Value

            'btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try

            limpiar()
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            ' btnCrear.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles txtCodEmpleado.DoubleClick
        Try
            M_ListadoEmpleados.lblform.Text = "MM_Conserje"
            M_ListadoEmpleados.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtCodEmpleado.TextChanged
        Try

            Dim emp As New ClsEmpleados
                Dim dt As New DataTable
                Dim row As DataRow

                emp.codigo_ = Integer.Parse(txtCodEmpleado.Text)

                dt = emp.BuscarEmpleadosPorCodigo()
                row = dt.Rows(0)

                txtNombreEmpleado.Text = row("nombreCompleto")



        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try

            With conserje

                Dim dv As DataView = .buscarConserje(txtBuscar.Text).DefaultView
                dgvData.DataSource = dv

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            E_frmInventario.GridAExcel(dgvData)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblEstado_TextChanged(sender As Object, e As EventArgs) Handles lblEstado.TextChanged

        Try

            If lblEstado.Text = "Entregado" Then

                lblEstado.ForeColor = Color.Green


            ElseIf lblEstado.Text = "En Proceso" Then

                lblEstado.ForeColor = Color.DodgerBlue

            Else

                lblEstado.ForeColor = Color.Black


            End If



        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnBuscarBanco_Click(sender As Object, e As EventArgs) Handles btnBuscarBanco.Click
        Try
            M_ListadoEmpleados.lblform.Text = "MM_Conserje"
            M_ListadoEmpleados.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        reporteConserjes.Show()
        reporteConserjes.BringToFront()
        reporteConserjes.WindowState = WindowState.Normal


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try

            dgvData.DataSource = conserje.listarConserjes


            If dgvData.Columns.Contains("codConserje") Then

                alternarColoFilasDatagridview(dgvData)
                dgvData.Columns("codEmpleado").Visible = False

                dgvData.Columns("codConserje").HeaderText = "N# de Seguimiento"
                dgvData.Columns("nombre").HeaderText = "Nombre de Empleado"
                dgvData.Columns("rutaOrigen").HeaderText = "Origen"
                dgvData.Columns("rutaDestino").HeaderText = "Destino"
                dgvData.Columns("fechaSalida").HeaderText = "F. Salida"
                dgvData.Columns("fechaEntrega").HeaderText = "F. Entrega"
                dgvData.Columns("horaEntrega").HeaderText = "H. Entrega"
                dgvData.Columns("horaSalida").HeaderText = "H. Salida"
                dgvData.Columns("Observaciones").HeaderText = "Observa."
                dgvData.Columns("estado").HeaderText = "Estado"

            End If




        Catch ex As Exception

        End Try
    End Sub
End Class