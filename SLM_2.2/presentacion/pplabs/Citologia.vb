Public Class Citologia

    Dim objcitologia As New ClsCitologia


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            M_BuscarFactura.Show()
            M_BuscarFactura.BringToFront()
            M_BuscarFactura.WindowState = WindowState.Normal

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        With objcitologia

            .NUM_FACTURA = Integer.Parse(txtNumeroFactura.Text)
            .OTROSA_ = txtOtrosA.Text
            .DETECCION_CANCER_ = chkCancer.Checked
            .INDICE_MADURACION_ = chkIndice.Checked
            .DIAGNOSTICO_ = txtDiagnostico.Text
            .FUR_ = dtpFUR.Value
            .FUP_ = dtpFUP.Value
            .GRAVIDAD = txtGravidad.Text
            .PARA_ = txtGravidad.Text
            .ABORTO_ = txtAborto.Text
            .IDIDENTIFICADORCITO = Integer.Parse(lblididentifica.Text)
            .IDFIRMA1 = Integer.Parse(lblfirma1.Text)
            .IDFIRMA2 = Integer.Parse(lblfirma2.Text)
            .FECHAMUESTRA1 = dtpFechaMuestra.Value
            .FECHAMUESTRA2 = dtpFechaMuestra2.Value
            .SIN_NOTA = chkSinNota.Checked
            .OTROS2_ = txtOtros2.Text

            'registrar 
            .NUEVOREGISTRO()

        End With

    End Sub

    Private Sub Citologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class