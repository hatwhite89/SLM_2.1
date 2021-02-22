Imports CrystalDecisions.Shared

Public Class reporteOrdenCompra
    Private Sub reporteOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptDocument As New rpt_ordenCompra


        RptDocument.SetParameterValue("@id_oc", codigo_oc)
        RptDocument.SetDatabaseLogon("sa", "Lbm2019", "10.172.3.10", "slm_test")

        CrystalReportViewer1.ReportSource = RptDocument

        configureCrystalReports()

    End Sub
    Private Sub configureCrystalReports()

        Try

            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()

            myConnectionInfo.ServerName = "10.172.3.10"

            myConnectionInfo.DatabaseName = "slm_test"
            myConnectionInfo.AllowCustomConnection = True

            myConnectionInfo.UserID = "sa"

            myConnectionInfo.Password = "Lbm2019"

            myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 

            myConnectionInfo.IntegratedSecurity = False

            setDBLOGONforREPORT(myConnectionInfo)

        Catch ex As Exception



        End Try

    End Sub



    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)

        Dim mytableloginfos As New TableLogOnInfos()

        mytableloginfos = CrystalReportViewer1.LogOnInfo

        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos

            myTableLogOnInfo.ConnectionInfo = myconnectioninfo

        Next

    End Sub
    Private Sub rpt_ordenCompra1_InitReport(sender As Object, e As EventArgs) Handles rpt_ordenCompra1.InitReport

    End Sub
End Class