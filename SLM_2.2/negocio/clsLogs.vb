Imports System.Data.SqlClient

Public Class clsLogs
    Public id, _usuario, fecha, _accion, _equipo As String

    Public Sub New()

    End Sub

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Accion As String
        Get
            Return _accion
        End Get
        Set(value As String)
            _accion = value
        End Set
    End Property

    Public Property Equipo As String
        Get
            Return _equipo
        End Get
        Set(value As String)
            _equipo = value
        End Set
    End Property

    Public Sub RegistrarInicioSesion()



        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "exec Logs_InicioSesion @usuario ='" + Usuario + "',@accion='" + Accion + "' , @computadora='" + My.Computer.Name + "',@ip ='" + ObtenerIP() + "' "
        sqlcom.Connection = New ClsConnection().getConexion

        sqlcom.ExecuteReader()
        sqlcom.Connection.Close()

    End Sub

    Private Function ObtenerIP() As String
        Dim nombreHost As String = System.Net.Dns.GetHostName
        Dim hostInfo As System.Net.IPHostEntry = Net.Dns.GetHostByName(nombreHost)
        Dim ip_ As String = ""

        For Each ip As System.Net.IPAddress In hostInfo.AddressList
            ip_ = ip.ToString
        Next
        Return ip_
    End Function

    Public Function CargarLogs(fecha1 As DateTime, fecha2 As DateTime) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from LogsInicioSesion where fecha between '" + fecha1.ToString("yyyyMMdd") + "'  and '" + fecha2.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function CargarLogsExcepciones(fecha1 As DateTime, fecha2 As DateTime) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select u.usuario,l.ventana,l.error,l.fecha from LogsExcepcion l , Usuario u
where u.cod_usuario = l.usuario and fecha between '" + fecha1.ToString("yyyyMMdd") + "'  and '" + fecha2.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
