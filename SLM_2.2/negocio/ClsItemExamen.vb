
Imports System.Data.SqlClient
Public Class ClsItemExamen

    'Variables
    Dim codItemExa, codigoSubArea, codInterno As Integer
    Dim codBreve, descripcion, grupo, clasificacion, abreviatura, comentario As String
    Dim precioBase As Double
    Dim estado As Boolean

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::: Metodos SET y GET ::::::::::::::::::::::::::::::::::::::::::::

    'Codigo Item Exa
    Public Property Cod_ItemExa As Integer
        Get
            Return codItemExa
        End Get
        Set(value As Integer)
            codItemExa = value
        End Set
    End Property

    'Codigo Interno
    Public Property Cod_Interno As Integer
        Get
            Return codInterno
        End Get
        Set(value As Integer)
            codInterno = value
        End Set
    End Property


    'Codigo Breve
    Public Property Cod_Breve As String
        Get
            Return codBreve
        End Get
        Set(value As String)
            codBreve = value
        End Set
    End Property

    'Descripcion
    Public Property Descripcio_n As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Grupo
    Public Property Grup_o As String
        Get
            Return grupo
        End Get
        Set(value As String)
            grupo = value
        End Set
    End Property

    'Clasificacion
    Public Property Clasificacio_n As String
        Get
            Return clasificacion
        End Get
        Set(value As String)
            clasificacion = value
        End Set
    End Property

    'Abreviatura
    Public Property Abreviatur_a As String
        Get
            Return abreviatura
        End Get
        Set(value As String)
            abreviatura = value
        End Set
    End Property

    'Comentario
    Public Property Comentari_o As String
        Get
            Return comentario
        End Get
        Set(value As String)
            comentario = value
        End Set
    End Property

    'Precio Base
    Public Property Precio_Base As Double
        Get
            Return precioBase
        End Get
        Set(value As Double)
            precioBase = value
        End Set
    End Property

    'Estado de Item
    Public Property Estad_o As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    'codigoSubArea
    Public Property codigoSubArea_ As Integer
        Get
            Return codigoSubArea
        End Get
        Set(value As Integer)
            codigoSubArea = value
        End Set
    End Property


    ':::::::::::::::::::::::::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::::::::::::::::::::::::::::::

    'Registrar nuevo Item Examen
    Public Function registrarNuevoItemExamen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarItemExamen"

        'VARIABLES
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codInterno"
        sqlpar.Value = Cod_Interno
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Cod_Breve
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "grupo"
        sqlpar.Value = Grup_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precioBase"
        sqlpar.Value = Precio_Base
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "clasificacion"
        sqlpar.Value = Clasificacio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "abreviatura"
        sqlpar.Value = Abreviatur_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estad_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSubArea"
        sqlpar.Value = codigoSubArea_
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

    'Modificar Item Examen
    Public Function modificarItemExamen() As String

        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarItemExamen"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codItemExa"
        sqlpar.Value = Cod_ItemExa
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codInterno"
        sqlpar.Value = Cod_Interno
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Cod_Breve
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "grupo"
        sqlpar.Value = Grup_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precioBase"
        sqlpar.Value = Precio_Base
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "clasificacion"
        sqlpar.Value = Clasificacio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "abreviatura"
        sqlpar.Value = Abreviatur_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estad_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSubArea"
        sqlpar.Value = codigoSubArea_
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

    'Listar Item Examen Ingresados
    Public Function listarItemExamen() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmListarItemExamenes", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Capturar Item
    Public Function CapturarItem() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmCapturarItem_Examenes", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Búsqueda Item
    Public Function BuscarItemExam() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarItemExamen"
            cmd.Parameters.Add("@codeItemExa", SqlDbType.Int).Value = Cod_ItemExa
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
