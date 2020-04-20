Public Class ClsAlmacen
    Dim id As Integer
    Dim nombre, descripcion As String
    'constructor
    Public Sub New()

    End Sub

    Public Property IdAlmacen As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NombreAlmacen As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property DescripcionAlmacen As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
End Class
