

Imports System.Data.SqlClient
Public Class ClsDetalleValorReferencia

    'Variables
    Dim cod_DetalleValorRef, cod_ValorReferencia As Integer
    Dim edadde, edadhasta, edaden, valornormal, hasta As String

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo detalle valor referencia
    Public Property Cod_ As Integer
        Get
            Return cod_DetalleValorRef
        End Get
        Set(value As Integer)
            cod_DetalleValorRef = value
        End Set
    End Property

    'Codigo  valor referencia
    Public Property Cod_ValorRef As Integer
        Get
            Return cod_ValorReferencia
        End Get
        Set(value As Integer)
            cod_ValorReferencia = value
        End Set
    End Property

    'Codigo  edad de
    Public Property Edad_de As String
        Get
            Return edadde
        End Get
        Set(value As String)
            edadde = value
        End Set
    End Property

    'Codigo  edad hasta
    Public Property Edad_hasta As String
        Get
            Return edadhasta
        End Get
        Set(value As String)
            edadhasta = value
        End Set
    End Property

    'Codigo  edad en
    Public Property Edad_en As String
        Get
            Return edaden
        End Get
        Set(value As String)
            edaden = value
        End Set
    End Property

    'Codigo  valor normal
    Public Property valor_normal As String
        Get
            Return valornormal
        End Get
        Set(value As String)
            valornormal = value
        End Set
    End Property

    'Codigo  hasta
    Public Property hasta_ As String
        Get
            Return hasta
        End Get
        Set(value As String)
            hasta = value
        End Set
    End Property

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo detalle de valor de referencia en base de datos
    Public Function registrarNuevoDetalleValorReferencia() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmeInsertarDetallValorReferencia"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_ValorReferencia"
        sqlpar.Value = Cod_ValorRef
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "edadde"
        sqlpar.Value = Edad_de
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "edadhasta"
        sqlpar.Value = Edad_hasta
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "edaden"
        sqlpar.Value = Edad_en
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "valornormal"
        sqlpar.Value = valor_normal
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "hasta"
        sqlpar.Value = hasta_
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


    'modificar detalle de valor de referencia en base de datos
    Public Function modificarDetalleValorReferencia() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDetalleValorReferencia"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_DetalleValorRef"
        sqlpar.Value = Cod_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "edadde"
        sqlpar.Value = Edad_de
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "edadhasta"
        sqlpar.Value = Edad_hasta
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "edaden"
        sqlpar.Value = Edad_en
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "valornormal"
        sqlpar.Value = valor_normal
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "hasta"
        sqlpar.Value = hasta_
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



    'eliminar detalle valor de referencia en base de datos
    Public Function eliminarDetalleValorReferencia() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmEliminarDetalleValorReferencia"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_DetalleValorRef"
        sqlpar.Value = Cod_
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


    'Listar detalle por codigo de referencia

    Public Function listarDetallesValores() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmListarDetalleValores"
            cmd.Parameters.Add("@cod_ValorReferencia", SqlDbType.Int).Value = Cod_ValorRef
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

End Class
