Imports System.Data.SqlClient

Public Class ClsProducto
    'variables
    Dim id, unidad_medida, ubicacion, categoria As Integer
    Dim nombre, marca, modelo, descripcion As String
    Dim precio_base As Double
    Dim cantidad_minima, existencia As Integer


    'constructor
    Public Sub New()

    End Sub

    Public Property IdProducto As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property UnidadMedida As Integer
        Get
            Return unidad_medida
        End Get
        Set(value As Integer)
            unidad_medida = value
        End Set
    End Property

    Public Property UbicacionProducto As Integer
        Get
            Return ubicacion
        End Get
        Set(value As Integer)
            ubicacion = value
        End Set
    End Property

    Public Property CategoriaProducto As Integer
        Get
            Return categoria
        End Get
        Set(value As Integer)
            categoria = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property MarcaProducto As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property ModeloProducto As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    Public Property DescripcionProducto As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property CantidadMinimaProducto As Integer
        Get
            Return cantidad_minima
        End Get
        Set(value As Integer)
            cantidad_minima = value
        End Set
    End Property

    Public Property ExistenciaProducto As Integer
        Get
            Return existencia
        End Get
        Set(value As Integer)
            existencia = value
        End Set
    End Property

    Public Function RecuperarProductoOC() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select * from ProductoAlmacen"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

    Public Function RecuperarProducto2() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from ProductoAlmacen", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


    Public Function RegistrarProducto() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarProductoAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_producto"
        sqlpar.Value = NombreProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "marca"
        sqlpar.Value = MarcaProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "modelo"
        sqlpar.Value = ModeloProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = DescripcionProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad_minima"
        sqlpar.Value = CantidadMinimaProducto
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_unidad_medida"
        sqlpar.Value = UnidadMedida
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_categoria"
        sqlpar.Value = CategoriaProducto
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
