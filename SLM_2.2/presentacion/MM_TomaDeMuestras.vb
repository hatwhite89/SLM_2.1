Public Class MM_TomaDeMuestras
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

            Dim tomaMuestra As New ClsTomaDeMuestras
            Dim codigoTomaMuestra As String

            With tomaMuestra

                .codExamen_ = Integer.Parse(lblcodexamen.Text)
                .Descripcion_ = txtDescripcion.Text


                'Insertar toma de muestra
                codigoTomaMuestra = .registrarNuevo
                MsgBox(codigoTomaMuestra)

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class