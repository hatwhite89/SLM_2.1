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
End Class
