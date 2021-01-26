
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine

Public Class A_Informes
    Dim seleccion As Integer
    Private Sub btnBuscarSubArea_Click(sender As Object, e As EventArgs) Handles btnBuscarSubArea.Click
        Try
            E_ListarSubAreas.lblform.Text = "informe"
            E_ListarSubAreas.Show()

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
            A_ListadoExamenes.Show()
        Catch ex As Exception

        End Try
    End Sub

    'Función para imprimir informe
    Sub ImprimirInformePeriodo()
        If seleccion = 0 Then

            Try
                Dim codExamen As Integer
                Dim fecha As DateTime
                Dim objInformeDiarioExamen As New InformeOrdenesDeTrabajoExamen
                objInformeDiarioExamen.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")
                codExamen = Convert.ToInt32(lblCodExamen.Text)
                fecha = dtpFecha.Value

                objInformeDiarioExamen.SetParameterValue("@codExamen", codExamen)
                objInformeDiarioExamen.SetParameterValue("@fecha", fecha)


                A_PrintInforme.crvInformeOrdenesTrabajo.ReportSource = objInformeDiarioExamen

            Catch ex As Exception
                MsgBox("Error Informe: " + ex.Message)
            End Try

        ElseIf seleccion = 1 Then

            Try
                Dim codSubArea As Integer
                Dim fechadesde, fechahasta As DateTime
                Dim objInformeDiario As New InformeOrdenesdeTrabajoPeriodo

                objInformeDiario.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")

                codSubArea = Convert.ToInt32(lblCodSubArea.Text)
                fechadesde = dtpDesde.Value
                fechahasta = dtpHasta.Value

                objInformeDiario.SetParameterValue("@codigoSubArea", codSubArea)
                objInformeDiario.SetParameterValue("@desde", fechadesde)
                objInformeDiario.SetParameterValue("@hasta", fechahasta)

                A_PrintInforme.crvInformeOrdenesTrabajo.ReportSource = objInformeDiario

            Catch ex As Exception
                MsgBox("Error Informe: " + ex.Message)
            End Try
        End If



    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click


        Try

            Dim n As String = MsgBox("¿Desea ejecutar la consulta?", MsgBoxStyle.YesNo, "Validación")
            If n = vbYes Then
                If chkExamenes.Checked = True Then

                    seleccion = 0

                    If lblCodExamen.Text = "CodExamen" Then
                        MsgBox("Se debe completar la información para generar el informe.")
                    Else
                        A_PrintInforme.lblform.Text = "Informe"
                        A_PrintInforme.Show()
                    End If
                ElseIf chkPeriodoTiempo.Checked = True Then
                    seleccion = 1
                    If lblCodSubArea.Text = "CodSubArea" Then
                        MsgBox("Se debe completar la información para generar el informe.")
                    Else
                        A_PrintInforme.lblform.Text = "Informe"
                        A_PrintInforme.Show()
                    End If

                End If


            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub chkExamenes_CheckedChanged(sender As Object, e As EventArgs) Handles chkExamenes.CheckedChanged
        If chkExamenes.Checked = True Then

            btnBuscarExamen.Enabled = True
            txtCodExamen.Enabled = True
            dtpFecha.Enabled = True
            chkPeriodoTiempo.Checked = False
            Limpiar()

        Else
            btnBuscarExamen.Enabled = False
            txtCodExamen.Enabled = False
            dtpFecha.Enabled = False
            Limpiar()
        End If
    End Sub

    Private Sub chkPeriodoTiempo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPeriodoTiempo.CheckedChanged
        If chkPeriodoTiempo.Checked = True Then

            btnBuscarSubArea.Enabled = True
            txtSubArea.Enabled = True
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
            chkExamenes.Checked = False
            Limpiar()

        Else
            btnBuscarSubArea.Enabled = False
            txtSubArea.Enabled = False
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False
            Limpiar()
        End If
    End Sub

    Sub Limpiar()

        txtSubArea.Clear()
        txtNombreSubArea.Clear()
        txtCodExamen.Clear()
        txtNombreExamen.Clear()
        dtpFecha.Value = DateTime.Now
        dtpDesde.Value = DateTime.Now
        dtpHasta.Value = DateTime.Now

    End Sub

    Private Sub A_Informes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub




End Class