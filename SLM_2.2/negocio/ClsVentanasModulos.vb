
Imports System.Data.SqlClient

Public Class ClsVentanasModulos

    'Variables
    Dim codVentana, codModulo As Integer
    Dim descripcion As String
    Dim estado As Boolean

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo Modulo
    Public Property Cod_Ventana As Integer
        Get
            Return codVentana
        End Get
        Set(value As Integer)
            codVentana = value
        End Set
    End Property

    'Codigo Perfil
    Public Property Cod_Modulo As Integer
        Get
            Return codModulo
        End Get
        Set(value As Integer)
            codModulo = value
        End Set
    End Property


    'Descripcion
    Public Property Descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Estado
    Public Property Estado_ As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo perfil en base de datos
    Public Function registrarVentana() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarItem_Modulo"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codModulo"
        sqlpar.Value = Cod_Modulo
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






End Class
