Imports CrystalDecisions.Shared

Public Class A_PrintInforme

    Private Sub A_PrintInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If lblform.Text = "Informe" Then

            A_Informes.ImprimirInformePeriodo()

        ElseIf lblform.Text = "InformePro" Then

            A_Candidatos.Informe()

        End If

        configureCrystalReports()

    End Sub


    Private Sub configureCrystalReports()
        Try
            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
            myConnectionInfo.ServerName = "10.172.3.10"
            myConnectionInfo.DatabaseName = "slm_test"
            myConnectionInfo.UserID = "sa"
            myConnectionInfo.Password = "Lbm2019"
            myConnectionInfo.Type = ConnectionInfoType.Unknown  'Importante agregar este Type
            myConnectionInfo.IntegratedSecurity = False
            setDBLOGONforREPORT(myConnectionInfo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        Dim mytableloginfos As New TableLogOnInfos()

        mytableloginfos = crvInformeOrdenesTrabajo.LogOnInfo
        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
            myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        Next

    End Sub

End Class