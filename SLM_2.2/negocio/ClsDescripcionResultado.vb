
Imports System.Data.SqlClient
Public Class ClsDescripcionResultado


    'Variables
    Dim codDescripcionResultado, cod_orden_trabajo As Integer
    Dim detalleResultado, descripcionResultado As String


    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo de Descripcion
    Public Property Codigo As Integer
        Get
            Return codDescripcionResultado
        End Get
        Set(value As Integer)
            codDescripcionResultado = value
        End Set
    End Property

    Public Property Codigo_OTrabajo As Integer
        Get
            Return cod_orden_trabajo
        End Get
        Set(value As Integer)
            cod_orden_trabajo = value
        End Set
    End Property


    Public Property Detalle_Resultado As String
        Get
            Return detalleResultado
        End Get
        Set(value As String)
            detalleResultado = value
        End Set
    End Property

    Public Property Descripcion_Resultado As String
        Get
            Return descripcionResultado
        End Get
        Set(value As String)
            descripcionResultado = value
        End Set
    End Property

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo banco en base de datos
    Public Function registrarNuevaDescripcionResultado() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDescripcionResultado"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_orden_trabajo"
        sqlpar.Value = Codigo_OTrabajo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "detalleResultado"
        sqlpar.Value = Detalle_Resultado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcionResultado"
        sqlpar.Value = Descripcion_Resultado
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

    'Modifcar registro de banco
    Public Function modificarDescripcionResultado() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDescripcionResultado"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codDescripcionResultado"
        sqlpar.Value = Codigo
        sqlcom.Parameters.Add(sqlpar)

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_orden_trabajo"
        sqlpar.Value = Codigo_OTrabajo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "detalleResultado"
        sqlpar.Value = Detalle_Resultado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcionResultado"
        sqlpar.Value = Descripcion_Resultado
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
