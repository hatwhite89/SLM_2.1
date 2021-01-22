Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine

Public Class A_PrintInforme

    Private Sub A_PrintInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            If lblform.Text = "Informe" Then

                A_Informes.ImprimirInformePeriodo()
                ' configureCrystalReports()
            ElseIf lblform.Text = "InformePro" Then

                A_Candidatos.Informe()
                ' configureCrystalReports()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub configureCrystalReports()
        Try
            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
            myConnectionInfo.ServerName = "10.172.3.10"
            myConnectionInfo.DatabaseName = "slm_test"
            myConnectionInfo.UserID = "sa"
            myConnectionInfo.Password = "Lbm2019"
            myConnectionInfo.Type = ConnectionInfoType.Query  'Importante agregar este Type
            myConnectionInfo.IntegratedSecurity = True
            setDBLOGONforREPORT(myConnectionInfo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)

        Dim mytableloginfos As New TableLogOnInfos()

        mytableloginfos = crvInformeOrdenesTrabajo.LogOnInfo

        For Each myTableLogOnInfot As TableLogOnInfo In mytableloginfos

            myTableLogOnInfot.ConnectionInfo = myconnectioninfo

        Next



    End Sub

End Class