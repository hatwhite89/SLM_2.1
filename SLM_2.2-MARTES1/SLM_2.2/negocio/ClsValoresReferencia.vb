
Imports System.Data.SqlClient
Public Class ClsValoresReferencia


    'Variables
    Dim cod_ValorReferencia, codParametro As Integer
    Dim descripcion, genero As String


    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo valor referencia
    Public Property Cod_ As Integer
        Get
            Return cod_ValorReferencia
        End Get
        Set(value As Integer)
            cod_ValorReferencia = value
        End Set
    End Property

    'Codigo parametro
    Public Property Cod_Parametro As Integer
        Get
            Return codParametro
        End Get
        Set(value As Integer)
            codParametro = value
        End Set
    End Property

    'Codigo descripcion
    Public Property Descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Codigo genero
    Public Property Genero_ As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property


    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo valor de referencia en base de datos
    Public Function registrarNuevoValorReferencia() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarValorReferencia"

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

    'Modificar nuevo valor de referencia en base de datos
    Public Function modificarValorReferencia() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarValorReferencia"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_ValorReferencia"
        sqlpar.Value = Cod_
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


    'eliminar detalle valor de referencia en base de datos
    Public Function eliminarDetalleValorReferencia() As String
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


    'Capturar Ultimo Valor referencia
    Public Function capturarValorRef() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmCapturarValorRef", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using


    End Function

    'Listar registros de valores referencia
    Public Function listarValores() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarValoresReferencia", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Buscar valor de referencia
    Public Function buscarValorReferencia() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarValorReferencia"
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

    'Buscar valor de referencia
    Public Function buscarValorReferencia2() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarValorReferencia2"
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
    'Buscar valor de referencia DEL PARAMETROS
    Public Function buscarValorReferenciaParametro(ByVal nombreParametro_ As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarValoresReferenciaParametro"
            cmd.Parameters.Add("@nombreParametro", SqlDbType.VarChar).Value = nombreParametro_
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
