
Imports System.Data.SqlClient
Public Class ClsDetalleValorRefTxt

    Inherits ClsValoresReferenciaTXT
    'Variables
    Dim cod_DetalleValorReftxt As Integer
    Dim texto As String


    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo valor referencia
    Public Property Cod_Detalle As Integer
        Get
            Return cod_DetalleValorReftxt
        End Get
        Set(value As Integer)
            cod_DetalleValorReftxt = value
        End Set
    End Property

    'Codigo valor referencia
    Public Property Texto_ As String
        Get
            Return texto
        End Get
        Set(value As String)
            texto = value
        End Set
    End Property



    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo valor de referencia en base de datos
    Public Function registrarDetalleValorReferenciaTXT() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDetalleValorReferenciatxt"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "texto"
        sqlpar.Value = Texto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_ValorReferenciaTxt"
        sqlpar.Value = Cod_TXT
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



    'Modificar valor de referencia en base de datos
    Public Function modificarDetalleValorReferenciaTXT() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDetalleValorReferenciaTXT"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_DetalleValorReftxt"
        sqlpar.Value = Cod_Detalle
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "texto"
        sqlpar.Value = Texto_
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
    Public Function eliminarDetalleValorReferenciaTxt() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmEliminarDetalleValorReferenciaTxt"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_DetalleValorReftxt"
        sqlpar.Value = Cod_Detalle
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

    Public Function listarDetallesValorestxt() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmListarDetalleValoresTXT"
            cmd.Parameters.Add("@cod_ValorReferenciatxt", SqlDbType.Int).Value = Cod_TXT
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
