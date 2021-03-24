Public Class reporteMayorCuentas
    Private Sub rbtCuenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCuenta.CheckedChanged
        If rbtCuenta.Checked = True Then
            txtCuenta.Enabled = True
            txtCuenta.Clear()

        Else
            txtCuenta.Enabled = False
            txtCuenta.Clear()

        End If
    End Sub

    Private Sub rbtRango_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRango.CheckedChanged
        If rbtRango.Checked = True Then
            txtRango1.Enabled = True
            txtRango2.Enabled = True
            txtRango1.Clear()
            txtRango2.Clear()
        Else
            txtRango1.Enabled = False
            txtRango2.Enabled = False
            txtRango1.Clear()
            txtRango2.Clear()
        End If
    End Sub

    Private Sub rbtCuentas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCuentas.CheckedChanged
        If rbtCuentas.Checked = True Then

            txtCuentas.Enabled = True
            txtCuentas.Clear()
        Else

            txtCuentas.Enabled = False
            txtCuentas.Clear()
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try


            If rbtCuenta.Checked = True Then


                Dim objReporte As New rpt_MayorCuentas


                objReporte.SetParameterValue("@fechaDesde", dtpDesde.Value)
                objReporte.SetParameterValue("@fechaHasta", dtpHasta.Value)
                objReporte.SetParameterValue("@cuenta", Integer.Parse(txtCuenta.Text))

                objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                crvMayor.ReportSource = objReporte

            ElseIf rbtRango.Checked = True Then

                Dim objReporte2 As New rpt_MayorCuentasRango


                objReporte2.SetParameterValue("@fechaDesde", dtpDesde.Value)
                objReporte2.SetParameterValue("@fechaHasta", dtpHasta.Value)
                objReporte2.SetParameterValue("@cuenta1", Integer.Parse(txtRango1.Text))
                objReporte2.SetParameterValue("@cuenta2", Integer.Parse(txtRango2.Text))

                objReporte2.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                crvMayor.ReportSource = objReporte2

            ElseIf rbtCuentas.Checked = True Then

            Else
                MsgBox("Debe seleccionar una opción para generar el informe.")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class