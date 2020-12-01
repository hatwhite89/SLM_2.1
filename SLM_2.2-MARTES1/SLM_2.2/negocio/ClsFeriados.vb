

Imports System.Data.SqlClient
Public Class ClsFeriados

    'Variables
    Dim codFeriado As Integer
    Dim codbreve, descripcion As String
    Dim fecha As Date

    'Constructor
    Public Sub New()


    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo Feriado
    Public Property Cod As Integer
        Get
            Return codFeriado
        End Get
        Set(value As Integer)
            codFeriado = value
        End Set
    End Property

    'Codigo Breve
    Public Property CodBreve_ As String
        Get
            Return codbreve
        End Get
        Set(value As String)
            codbreve = value
        End Set
    End Property

    'Descripcion
    Public Property Descrip_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Fecha
    Public Property Fecha_ As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo feriado en base de datos
    Public Function registrarNuevoFeriado() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarFeriado"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codbreve"
        sqlpar.Value = CodBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descrip"
        sqlpar.Value = Descrip_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha"
        sqlpar.Value = Fecha_
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

    'Modifcar registro de feriado
    Public Function modificarFeriado() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarFeriado"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFeriado"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codbreve"
        sqlpar.Value = CodBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descrip"
        sqlpar.Value = Descrip_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha"
        sqlpar.Value = Fecha_
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

    'Listar feriados
    Public Function listarFeriados() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarFeriados", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    'Buscar feriados por rango de fechas
    Public Function BuscarFeriadosRangoFecha(ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarFeriadosRangoFecha"
            cmd.Parameters.Add("@fechaInicial", SqlDbType.Date).Value = fechaInicial
            cmd.Parameters.Add("@fechaFinal", SqlDbType.Date).Value = fechaFinal

            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using

    End Function
End Class
