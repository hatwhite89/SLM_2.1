Imports System.Data.SqlClient

Public Class ClsMensajes
    Dim id, id_usuario As Integer
    Dim cuerpo, titulo, emisor As String
    Dim fecha As Date

    Public Sub New()

    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Id_usuario1 As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            id_usuario = value
        End Set
    End Property

    Public Property Cuerpo1 As String
        Get
            Return cuerpo
        End Get
        Set(value As String)
            cuerpo = value
        End Set
    End Property

    Public Property Titulo1 As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property

    Public Property Emisor1 As String
        Get
            Return emisor
        End Get
        Set(value As String)
            emisor = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Function CrearMensaje() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmCrearMensaje"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_usuario"
        sqlpar.Value = Id_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuerpo"
        sqlpar.Value = Cuerpo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "titulo"
        sqlpar.Value = Titulo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "emisor"
        sqlpar.Value = Emisor1
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

    Public Function RecuperarMensajes() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select cuerpo,fecha, titulo, emisor from  mensajes where id_usuario= '" + codigo_usuario + "'  "
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function
End Class
