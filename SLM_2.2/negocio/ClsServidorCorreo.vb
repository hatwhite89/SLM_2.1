
Imports System.Data.SqlClient

Public Class ClsServidorCorreo

    'Variables de Función
    Dim correoSalida, pass, host, correoEntrada As String
    Dim puerto, codigo As Integer
    Dim sslOK As Boolean

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo correo
    Public Property Cod As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property

    'Puerto
    Public Property Port As Integer
        Get
            Return puerto
        End Get
        Set(value As Integer)
            puerto = value
        End Set
    End Property

    'Correo Salida
    Public Property correo_Salida As String
        Get
            Return correoSalida
        End Get
        Set(value As String)
            correoSalida = value
        End Set
    End Property

    'Password
    Public Property Password As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property

    'Host
    Public Property Hos_t As String
        Get
            Return host
        End Get
        Set(value As String)
            host = value
        End Set
    End Property

    'Correo Entrada
    Public Property correo_Entrada As String
        Get
            Return correoEntrada
        End Get
        Set(value As String)
            correoEntrada = value
        End Set
    End Property

    'Estado
    Public Property ssl_ok As Boolean
        Get
            Return sslOK
        End Get
        Set(value As Boolean)
            sslOK = value
        End Set
    End Property

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar servidor en base de datos
    Public Function registrarServidorCorreo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarServidorCorreo"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correoSalida"
        sqlpar.Value = correo_Salida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pass"
        sqlpar.Value = Password
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "puerto"
        sqlpar.Value = Port
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "host"
        sqlpar.Value = Hos_t
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sslOK"
        sqlpar.Value = ssl_ok
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correoEntrada"
        sqlpar.Value = correo_Entrada
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion
        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    'Ver Correo configurado
    Public Function verServidor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmVerServidorCorreo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Modificar servidor en base de datos
    Public Function modificarServidorCorreo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarServidorCorreo"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_Correo"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correoSalida"
        sqlpar.Value = correo_Salida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pass"
        sqlpar.Value = Password
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "puerto"
        sqlpar.Value = Port
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "host"
        sqlpar.Value = Hos_t
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sslOK"
        sqlpar.Value = ssl_ok
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correoEntrada"
        sqlpar.Value = correo_Entrada
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion
        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function


End Class
