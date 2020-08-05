Public Class A_Informes
    Private Sub btnBuscarSubArea_Click(sender As Object, e As EventArgs) Handles btnBuscarSubArea.Click
        Try
            E_ListarSubAreas.lblform.Text = "informe"
            E_ListarSubAreas.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSubArea_TextChanged(sender As Object, e As EventArgs) Handles txtSubArea.TextChanged

        Try
            If txtSubArea.Text = "" Then

                txtNombreSubArea.Text = ""
                lblCodSubArea.Text = ""
            Else
                Dim subarea As New ClsSubArea
                Dim dt As New DataTable
                Dim row As DataRow

                subarea.Cod_SubArea = txtSubArea.Text

                dt = subarea.BuscarSubAreaCodigoBreve
                row = dt.Rows(0)

                lblCodSubArea.Text = row("codSubArea")
                'txtSubArea.Text = row("SubArea")
                txtNombreSubArea.Text = row("nombre")


            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscarExamen_Click(sender As Object, e As EventArgs) Handles btnBuscarExamen.Click
        Try
            A_ListadoExamenes.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub




    'Función para imprimir informe
    Sub ImprimirInformePeriodo()
        Try

            Dim codSubArea As Integer
            Dim fechadesde, fechahasta As Date
            Dim informe As New ClsOrdenDeTrabajo
            'objVistaCheque.SetDatabaseLogon("sa", "Lbm2019")

            'codCheque = Convert.ToInt32(txtNro.Text)

            'codFactura = Convert.ToInt32(frmPagos.dtDetallePagos.Rows(0).Cells(0).Value)

            'objVistaCheque.SetParameterValue("@codCheque", codCheque)
            'objVistaCheque.SetParameterValue("@codFactura", codFactura)
            'objVistaCheque.SetParameterValue("numalet", letras)
            'objVistaCheque.SetParameterValue("Cheque", txtNroCheq.Text)

            'objVistaCheque.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
            'A_PrintCheque.crvImprimirCheque.ReportSource = objVistaCheque

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub A_Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class