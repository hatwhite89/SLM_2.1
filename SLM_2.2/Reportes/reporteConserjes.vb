Public Class reporteConserjes
    Private Sub btnBuscarBanco_Click(sender As Object, e As EventArgs) Handles btnBuscarEmp.Click
        Try
            M_ListadoEmpleados.lblform.Text = "reporteConserje"
            M_ListadoEmpleados.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtCodEmpleado.TextChanged
        Try
            If txtCodEmpleado.Text = "" Then
                txtNombreEmpleado.Clear()
            End If
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Try

            If RadioButton1.Checked = True Then


                txtCodEmpleado.Enabled = True
                btnBuscarEmp.Enabled = True
            Else

                txtCodEmpleado.Enabled = False
                btnBuscarEmp.Enabled = False
                Limpiar()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Try

            If RadioButton2.Checked = True Then

                DateTimePicker1.Enabled = True
                DateTimePicker2.Enabled = True

            Else
                DateTimePicker1.Enabled = False
                DateTimePicker2.Enabled = False
                Limpiar()

            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then

            txtCodEmpleado.Enabled = True
            btnBuscarEmp.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

        Else

            txtCodEmpleado.Enabled = False
            btnBuscarEmp.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            Limpiar()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            If RadioButton1.Checked = True Then

                Try

                    Dim objReporte As New rpt_reporteConserjes


                    objReporte.SetParameterValue("@codEmpleado", Integer.Parse(txtCodEmpleado.Text))
                    objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                    CrystalReportViewer1.ReportSource = objReporte

                Catch ex As Exception

                End Try


            ElseIf RadioButton2.Checked = True Then


                Try

                    Dim objReporte As New rpt_RangoConserjes

                    objReporte.SetParameterValue("@desde", DateTimePicker1.Value)
                    objReporte.SetParameterValue("@hasta", DateTimePicker2.Value)
                    objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                    CrystalReportViewer1.ReportSource = objReporte

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



            ElseIf RadioButton3.Checked = True Then
                Try

                    Dim objReporte As New rpt_AsigancionesDeConserje

                    objReporte.SetParameterValue("@codEmpleado", Integer.Parse(txtCodEmpleado.Text))
                    objReporte.SetParameterValue("@desde", DateTimePicker1.Value)
                    objReporte.SetParameterValue("@hasta", DateTimePicker2.Value)
                    objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
                    CrystalReportViewer1.ReportSource = objReporte

                Catch ex As Exception

                End Try

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub




    Sub Limpiar()


        txtCodEmpleado.Clear()
        txtNombreEmpleado.Clear()
        DateTimePicker1.Value = Date.Now
        DateTimePicker2.Value = Date.Now

    End Sub

End Class