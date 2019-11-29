
Imports System.Data.SqlClient
Public Class ClsSubArea

    Dim SubArea, area, nombre, Formulario As String
    Dim codSubArea, secImpresion As Integer
    Dim noSolicitarSucursal, formularioConsolidado As Boolean

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::

    'Codigo SubArea
    Public Property Cod As Integer
        Get
            Return codSubArea
        End Get
        Set(value As Integer)
            codSubArea = value
        End Set
    End Property
    'SubArea
    Public Property Cod_SubArea As String
        Get
            Return SubArea
        End Get
        Set(value As String)
            SubArea = value
        End Set
    End Property
    'Area
    Public Property Are_a As String
        Get
            Return area
        End Get
        Set(value As String)
            area = value
        End Set
    End Property
    'Nombre
    Public Property Nombr_e As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    'Formulario
    Public Property Formulari_o As String
        Get
            Return Formulario
        End Get
        Set(value As String)
            Formulario = value
        End Set
    End Property
    'Impresion
    Public Property sec_Impresion As Integer
        Get
            Return secImpresion
        End Get
        Set(value As Integer)
            secImpresion = value
        End Set
    End Property
    'Formulario Consolidado
    Public Property formulario_Consolidado As Boolean
        Get
            Return formularioConsolidado
        End Get
        Set(value As Boolean)
            formularioConsolidado = value
        End Set
    End Property
    'No solicitar Sucursal
    Public Property noSolicitar_Sucursal As Boolean
        Get
            Return noSolicitarSucursal
        End Get
        Set(value As Boolean)
            noSolicitarSucursal = value
        End Set
    End Property


    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo banco en base de datos
    Public Function registrarNuevaSubArea() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarSubArea"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "SubArea"
        sqlpar.Value = Cod_SubArea
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "area"
        sqlpar.Value = Are_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre"
        sqlpar.Value = Nombr_e
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "Formulario"
        sqlpar.Value = Formulari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "secImpresion"
        sqlpar.Value = sec_Impresion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "noSolicitarSucursal"
        sqlpar.Value = noSolicitar_Sucursal
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "formularioConsolidado"
        sqlpar.Value = formulario_Consolidado
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

    'Modificar SubArea
    Public Function modificarSubArea() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarSubArea"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codSubArea"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "SubArea"
        sqlpar.Value = Cod_SubArea
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "area"
        sqlpar.Value = Are_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre"
        sqlpar.Value = Nombr_e
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "Formulario"
        sqlpar.Value = Formulari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "secImpresion"
        sqlpar.Value = sec_Impresion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "noSolicitarSucursal"
        sqlpar.Value = noSolicitar_Sucursal
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "formularioConsolidado"
        sqlpar.Value = formulario_Consolidado
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


    'Listar SubAreas
    Public Function listarSubAreas() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmListarSubAreas", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function




End Class
