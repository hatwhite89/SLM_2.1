Imports System.Data.SqlClient

Public Class ClsCentoCostos_Asientos

    'Variables

    Dim codigo, id_centrocostos, id_asientos, id_detalleasiento As Integer
    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::::::::::::::::::: METODOS SET Y GET
    Public Property codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property

    Public Property idcentrocostos_ As Integer
        Get
            Return id_centrocostos
        End Get
        Set(value As Integer)
            id_centrocostos = value
        End Set
    End Property

    Public Property id_asientos_ As Integer
        Get
            Return id_asientos
        End Get
        Set(value As Integer)
            id_asientos = value
        End Set
    End Property

    Public Property id_detalleasiento_ As Integer
        Get
            Return id_detalleasiento
        End Get
        Set(value As Integer)
            id_detalleasiento = value
        End Set
    End Property



    ':::::::::::::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO

    Public Function REGISTRO_ASIENTO_CC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "CONTA_CENTROCOSTO"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_centrocosto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = idcentrocostos_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_asiento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_asientos_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_detalleasiento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = id_detalleasiento_
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
