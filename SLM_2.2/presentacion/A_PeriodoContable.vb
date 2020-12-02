Public Class A_PeriodoContable

    Dim periodo As New ClsPeriodoContable

    Sub Limpiar()
        txtCod.Clear()
        txtDescripcion.Clear()
        dtpFinal.ResetText()
        dtpInicio.ResetText()
        chkEstado.Checked = False

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If dtpInicio.Value = dtpFinal.Value Or dtpFinal.Value < dtpInicio.Value Or dtpInicio.Value > dtpFinal.Value Then

                MsgBox("El rango de fecha es incorrecto.")

            Else

                With periodo
                    .Descripcion_ = txtDescripcion.Text
                    .Fecha_Inicio = dtpInicio.Value
                    .Fecha_Final = dtpFinal.Value
                    .Estad_o = chkEstado.Checked

                    If .registrarPeriodoContable = 1 Then
                        MsgBox("Se ha hecho un nuevo registro de periodo contable.")
                        dtPeriodos.DataSource = .listarPeriodos()
                        Limpiar()
                    End If

                End With

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub A_PeriodoContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dtPeriodos.DataSource = periodo.listarPeriodos
            alternarColoFilasDatagridview(dtPeriodos)

            'Botones
            btnCrear.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If dtpInicio.Value = dtpFinal.Value Or dtpFinal.Value < dtpInicio.Value Or dtpInicio.Value > dtpFinal.Value Then

                MsgBox("El rango de fecha es incorrecto.")

            Else

                With periodo

                    .Cod_ = Convert.ToInt32(txtCod.Text)
                    .Descripcion_ = txtDescripcion.Text
                    .Fecha_Inicio = dtpInicio.Value
                    .Fecha_Final = dtpFinal.Value
                    .Estad_o = chkEstado.Checked

                    If .modificarPeriodoContable = 1 Then
                        MsgBox("Se ha modificado el registro.")
                        dtPeriodos.DataSource = .listarPeriodos()
                        Limpiar()

                    End If

                    'Botones
                    btnCrear.Enabled = False
                    btnModificar.Enabled = False
                    btnGuardar.Enabled = True
                End With

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtPeriodos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPeriodos.CellDoubleClick
        Try

            Dim dt As New DataTable
            dt = dtPeriodos.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)



            txtCod.Text = row("codPeriodo")
            txtDescripcion.Text = row("descripcion")
            dtpInicio.Value = row("fecha_i")
            dtpFinal.Value = row("fecha_f")
            chkEstado.Checked = row("estado")

            'Botones
            btnCrear.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnCrear.Enabled = False
        Limpiar()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class