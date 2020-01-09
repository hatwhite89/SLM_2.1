Public Class E_SubArea
    'Objeto SubArea
    Dim SubA As New ClsSubArea

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            'Capturar Variables
            With SubA
                .Cod_SubArea = txtSubArea.Text
                .Nombr_e = txtNombre.Text
                .Are_a = txtArea.Text
                .Formulari_o = txtFormulario.Text
                .sec_Impresion = Convert.ToInt32(txtSecImpre.Text)
                .noSolicitar_Sucursal = chkNoSolitar.Checked
                .formulario_Consolidado = chkConsolidado.Checked

                'Procedimiento Ingreso
                .registrarNuevaSubArea()

            End With


        Catch ex As Exception
            MessageBox.Show("Error al registrar. Detalle: " + ex.Message)
        End Try



    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub
End Class