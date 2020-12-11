
Imports System.Data.SqlClient
Public Class ClsConserje


    'Variables
    Dim codConserje, codEmpleado As Integer
    Dim rutaOrigen, rutaDestino, Observaciones, estado As String
    Dim fechaSalida, fechaEntrega As Date
    Dim horaSalida, horaEntrega As Date

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo 
    Public Property Cod_Conserje As Integer
        Get
            Return codConserje
        End Get
        Set(value As Integer)
            codConserje = value
        End Set
    End Property

    'Codigo  empleado
    Public Property Cod_Empleado As Integer
        Get
            Return codEmpleado
        End Get
        Set(value As Integer)
            codEmpleado = value
        End Set
    End Property

    'Ruta Origen 
    Public Property ruta_Origen As String
        Get
            Return rutaOrigen
        End Get
        Set(value As String)
            rutaOrigen = value
        End Set
    End Property

    'Ruta Destino
    Public Property ruta_Destino As String
        Get
            Return rutaDestino
        End Get
        Set(value As String)
            rutaDestino = value
        End Set
    End Property

    'Observaciones 
    Public Property Observaciones_ As String
        Get
            Return Observaciones
        End Get
        Set(value As String)
            Observaciones = value
        End Set
    End Property

    'Estado
    Public Property Estado_ As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    'Fecha Salida
    Public Property fecha_Salida As Date
        Get
            Return fechaSalida
        End Get
        Set(value As Date)
            fechaSalida = value
        End Set
    End Property

    'Fecha Entrada
    Public Property fecha_Entrega As Date
        Get
            Return fechaEntrega
        End Get
        Set(value As Date)
            fechaEntrega = value
        End Set
    End Property


    'Hora Salida
    Public Property hora_Salida As Date
        Get
            Return horaSalida
        End Get
        Set(value As Date)
            horaSalida = value
        End Set
    End Property

    'Hora Entrega
    Public Property hora_Entrega As Date
        Get
            Return horaEntrega
        End Get
        Set(value As Date)
            horaEntrega = value
        End Set
    End Property



    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo conserje en base de datos
    Public Function registrarNuevoConserje() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarConserje"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codEmpleado"
        sqlpar.Value = Cod_Empleado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rutaOrigen"
        sqlpar.Value = ruta_Origen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rutaDestino"
        sqlpar.Value = ruta_Destino
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaSalida"
        sqlpar.Value = fecha_Salida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "horaSalida"
        sqlpar.Value = hora_Salida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaEntrega"
        sqlpar.Value = fecha_Entrega
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "horaEntrega"
        sqlpar.Value = hora_Entrega
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones"
        sqlpar.Value = Observaciones_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estado_
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

    'Modifcar registro de conserje
    Public Function modificarConserje() As String

        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarConserje"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codConserje"
        sqlpar.Value = Cod_Conserje
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codEmpleado"
        sqlpar.Value = Cod_Empleado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rutaOrigen"
        sqlpar.Value = ruta_Origen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "rutaDestino"
        sqlpar.Value = ruta_Destino
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaSalida"
        sqlpar.Value = fecha_Salida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "horaSalida"
        sqlpar.Value = hora_Salida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaEntrega"
        sqlpar.Value = fecha_Entrega
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "horaEntrega"
        sqlpar.Value = hora_Entrega
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones"
        sqlpar.Value = Observaciones_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estado_
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

    'Listar codBreve y nombre de banco
    Public Function listarConserjes() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarConserje", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Buscar Conserje
    Public Function buscarConserje(nombreCompleto As String) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarConserjeEmpleadoNombre"
            cmd.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = nombreCompleto
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
