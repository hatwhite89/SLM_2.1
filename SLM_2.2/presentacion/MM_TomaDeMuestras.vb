Public Class MM_TomaDeMuestras

    Dim tomaMuestra As New ClsTomaDeMuestras
    Dim objPreguntas As New ClsPreguntasMuestra
    Private Sub txtCodExamen_TextChanged(sender As Object, e As EventArgs) Handles txtCodExamen.TextChanged

        Try


            Dim examen As New ClsItemExamen

            Dim codigoInterno As Integer
            codigoInterno = Integer.Parse(txtCodExamen.Text)

            With examen


                Dim dt As New DataTable
                Dim row As DataRow


                .Cod_Interno = codigoInterno
                dt = .BuscarItemExamInterno
                row = dt.Rows(0)

                txtCodExamen.Text = row("codInterno")
                txtExamen.Text = row("descripcion")
                lblcodexamen.Text = row("codItemExa")

            End With

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim codigoTomaMuestra As String

            With tomaMuestra

                .codExamen_ = Integer.Parse(lblcodexamen.Text)
                .Descripcion_ = txtDescripcion.Text


                'Insertar toma de muestra
                codigoTomaMuestra = .registrarNuevo

                MsgBox(codigoTomaMuestra)

            End With

            'Preguntas Muestra
            For index As Integer = 0 To dgvPreguntas.Rows.Count - 2
                With objPreguntas
                    .codMuestra_ = Integer.Parse(codigoTomaMuestra)
                    .enunciado_ = dgvPreguntas.Rows(index).Cells(1).Value()
                    If dgvPreguntas.Rows(index).Cells(2).Value().ToString = "Si" Then
                        .estado_ = True
                    Else
                        .estado_ = False
                    End If
                    .nota_ = dgvPreguntas.Rows(index).Cells(3).Value()
                End With
                If objPreguntas.RegistrarNuevaPreguntaMuestra() = 0 Then
                    MsgBox("Error al querer insertar las preguntas de la muestra.", MsgBoxStyle.Critical)
                End If
            Next
            MsgBox("Registrada la toma de muestra correctamente.", MsgBoxStyle.Information, "Validación.")
            'M_BuscarRecibo.seleccionarRecibo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class