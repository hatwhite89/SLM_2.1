Public Class HT_DescripcionResultado
    Dim DescripcionResultado As New ClsDescripcionResultado
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            With DescripcionResultado

                .Codigo_OTrabajo = Integer.Parse(txtOrdenTrabajo.Text)
                .Detalle_Resultado = rtxtPlantillas.Text
                .Descripcion_Resultado = rtxtDescripcion.Text

                If .registrarNuevaDescripcionResultado() = 1 Then
                    MsgBox("Se guardo la descripcion para el resultado.")
                End If

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub HT_DescripcionResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If txtCodigo.Text <> "" Then

                btnModificar.Enabled = True
                btnGuardar.Enabled = False

            Else

                btnModificar.Enabled = False
                btnGuardar.Enabled = True



            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


        Try

            With DescripcionResultado

                .Codigo = Integer.Parse(txtCodigo.Text)
                .Codigo_OTrabajo = Integer.Parse(txtOrdenTrabajo.Text)
                .Detalle_Resultado = rtxtPlantillas.Text
                .Descripcion_Resultado = rtxtDescripcion.Text

                If .modificarDescripcionResultado() = 1 Then
                    MsgBox("Se modificó la descripcion para el resultado.")
                End If

            End With

        Catch ex As Exception

        End Try



    End Sub
End Class