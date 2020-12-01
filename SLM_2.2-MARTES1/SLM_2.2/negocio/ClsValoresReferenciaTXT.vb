
Imports System.Data.SqlClient

Public Class ClsValoresReferenciaTXT

    'Herencia de campos
    Inherits ClsValoresReferencia
    'Variables
    Dim cod_ValorReferenciaTxt As Integer
    Dim edadde, edadhasta, edaden As String


    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo valor referencia
    Public Property Cod_TXT As Integer
        Get
            Return cod_ValorReferenciaTxt
        End Get
        Set(value As Integer)
            cod_ValorReferenciaTxt = value
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

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo valor de referencia en base de datos
    Public Function registrarNuevoValorReferenciaTXT() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarValorReferenciaTxt"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codParametro"
        sqlpar.Value = Cod_Parametro
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion_
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
        sqlpar.ParameterName = "genero"
        sqlpar.Value = Genero_
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
    Public Function modificarValorReferenciaTXT() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarValorReferenciaTXT"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_ValorReferenciatxt"
        sqlpar.Value = Cod_TXT
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codParametro"
        sqlpar.Value = Cod_Parametro
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion_
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
        sqlpar.ParameterName = "genero"
        sqlpar.Value = Genero_
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

    'Capturar Ultimo Valor referencia TXT
    Public Function capturarValorRefTXT() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmCapturarValorTXT", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using

    End Function

    'Listar registros de valores referencia txt
    Public Function listarValoresTXT() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarValoresRefTXT", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function


    'Buscar valor de referencia
    Public Function buscarValorReferenciaTXT() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarValorReferenciaTXT"
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Descripcion_
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
