Imports System.Data.SqlClient
Public Class ClsCategoriaProveedor

    'Variables 
    Dim codCatProveedor, CtaAcreedores, CtaAnticipos As Integer
    Dim codigo, Descripcion As String
    'Constructor
    Public Sub New()

    End Sub
    '::::::::::::::::::::::::: Metodos SET y GET ::::::::::::::::::::::::::::::::::

    'Codigo de Categoria
    Public Property Cod As Integer
        Get
            Return codCatProveedor
        End Get
        Set(value As Integer)
            codCatProveedor = value
        End Set
    End Property

    'Cuenta Acreedores
    Public Property Cta_Acreedor As Integer
        Get
            Return CtaAcreedores
        End Get
        Set(value As Integer)
            CtaAcreedores = value
        End Set
    End Property

    'Cuenta Anticipos
    Public Property Cta_Anticipos As Integer
        Get
            Return CtaAnticipos
        End Get
        Set(value As Integer)
            CtaAnticipos = value
        End Set
    End Property

    'Descripcion
    Public Property Descripcio_n As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    'Codigo
    Public Property Codig_o As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    ':::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::::::::::

    'Registrar nueva categoria
    Public Function registrarNuevaCategoria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCategoriaProveedor_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Codig_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAcreedores"
        sqlpar.Value = Cta_Acreedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAnticipos"
        sqlpar.Value = Cta_Anticipos
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

    'Modificar Categoria
    Public Function modificarCategoria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmActualizarCategoriaProveedor_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCat"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Codig_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAcreedores"
        sqlpar.Value = Cta_Acreedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAnticipos"
        sqlpar.Value = Cta_Anticipos
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

        par_sal = sqlcom.Parameters("Salida").Value

        Return par_sal

    End Function

    'Listar categorias
    Public Function listarCategoriasProveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmListarCategoriaProveedor_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function


End Class
