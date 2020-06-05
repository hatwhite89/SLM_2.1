
Imports System.Data.SqlClient
Public Class ClsSubArea

    Dim SubArea, nombre, Formulario, secImpresion As String
    Dim codSubArea, codigoArea As Integer
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
    Public Property codigoArea_ As Integer
        Get
            Return codigoArea
        End Get
        Set(value As Integer)
            codigoArea = value
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
    Public Property sec_Impresion As String
        Get
            Return secImpresion
        End Get
        Set(value As String)
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
        sqlpar.ParameterName = "codigoArea"
        sqlpar.Value = codigoArea_
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
        sqlpar.ParameterName = "codigoArea"
        sqlpar.Value = codigoArea_
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
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Buscar por codSubArea
    Public Function BuscarSubarea() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarSubArea"
            cmd.Parameters.Add("@codSubArea", SqlDbType.Int).Value = Cod
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
    Public Function BuscarSubAreaXArea() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarSubAreaXArea"
            cmd.Parameters.Add("@codigoArea", SqlDbType.Int).Value = codigoArea_
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
    Public Function BuscarSubAreaNombre() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarSubAreaNombre"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombr_e
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
