
Imports System.Data.SqlClient
Public Class ClsChequera

    'Variables
    Dim codChequera, cantidad As Integer
    Dim ctaDestino, nroInicio, banco As String


    'Constructor
    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::::::::::
    'Codigo de Chequera
    Public Property Cod_Chequera As Integer
        Get
            Return codChequera
        End Get
        Set(value As Integer)
            codChequera = value
        End Set
    End Property

    'Cantidad
    Public Property Cantida_d As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property

    'Cuenta Destino
    Public Property Cuenta_Destino As String
        Get
            Return ctaDestino
        End Get
        Set(value As String)
            ctaDestino = value
        End Set
    End Property

    'Numero de Inicio
    Public Property Numero_Inicio As String
        Get
            Return nroInicio
        End Get
        Set(value As String)
            nroInicio = value
        End Set
    End Property

    'Banco
    Public Property Banc_o As String
        Get
            Return banco
        End Get
        Set(value As String)
            banco = value
        End Set
    End Property


    '::::::::::::::::::::::::::::::::::: Funciones de Mantenimiento :::::::::::::::::::::::::::::::::::

    'Registrar nueva Chequera
    Public Function registrarNuevaChequera() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarChequera"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaDestino"
        sqlpar.Value = Cuenta_Destino
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroInicio"
        sqlpar.Value = Numero_Inicio
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad"
        sqlpar.Value = Cantida_d
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco"
        sqlpar.Value = Banc_o
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

    'Modificar chequera
    Public Function modificarChequera() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarChequera"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codChequera"
        sqlpar.Value = Cod_Chequera
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaDestino"
        sqlpar.Value = Cuenta_Destino
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaInicio"
        sqlpar.Value = Numero_Inicio
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad"
        sqlpar.Value = Cantida_d
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco"
        sqlpar.Value = Banc_o
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

    'Listar las chequeras Ingresadas
    Public Function listarChequeras() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarChequera", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Listar Ultima Chequera
    Public Function listarUltimaChequera() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarUltimaChequera", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function







End Class
