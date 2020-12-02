
Imports System.Data.SqlClient
Public Class ClsChequera

    'Variables
    Dim codChequera, codCuenta, cantidad, codBanco As Integer
    Dim nroInicio As String


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
    Public Property cod_Cuenta As Integer
        Get
            Return codCuenta
        End Get
        Set(value As Integer)
            codCuenta = value
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
    Public Property cod_Banco As Integer
        Get
            Return codBanco
        End Get
        Set(value As Integer)
            codBanco = value
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
        sqlpar.ParameterName = "codCuenta"
        sqlpar.Value = cod_Cuenta
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
        sqlpar.ParameterName = "codBanco"
        sqlpar.Value = cod_Banco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ID"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("ID").Value

        Return par_sal

    End Function

    Public Function listarChequera() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarChequera", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function


End Class
