

Imports System.Data.SqlClient
Public Class ClsBitacora

    Dim codigo As Integer
    Dim usuario As String
    Dim accion As String
    Dim fecha As Date

    'Constructor
    Public Sub New()

    End Sub



    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::

    'Codigo Bitacora
    Public Property codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property

    'Usuario
    Public Property usuario_ As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property

    'Accion
    Public Property accion_ As String
        Get
            Return accion
        End Get
        Set(value As String)
            accion = value
        End Set
    End Property

    'Fecha

    Public Property fecha_ As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property


    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registro de Bitacora
    Public Function registrarBitacora() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarBitacora"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario"
        sqlpar.Value = usuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion"
        sqlpar.Value = accion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha"
        sqlpar.Value = fecha
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

    'Listar Bitacora
    Public Function listarBitacora() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmVerBitacora", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
