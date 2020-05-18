Imports System.Data.SqlClient

Public Class clsEntradaAlmacen
    Dim id_producto, id_almacen As Integer
    Dim cantidad, precio As Double
    Dim lote, descrip As String
    Dim fecha_vence As Date

    Public Property IdProducto As Integer
        Get
            Return id_producto
        End Get
        Set(value As Integer)
            id_producto = value
        End Set
    End Property

    Public Property IdAlmacen As Integer
        Get
            Return id_almacen
        End Get
        Set(value As Integer)
            id_almacen = value
        End Set
    End Property

    Public Property CantidadProducto As Double
        Get
            Return cantidad
        End Get
        Set(value As Double)
            cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property

    Public Property LoteProducto As String
        Get
            Return lote
        End Get
        Set(value As String)
            lote = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return descrip
        End Get
        Set(value As String)
            descrip = value
        End Set
    End Property

    Public Property FechaVencimiento As Date
        Get
            Return fecha_vence
        End Get
        Set(value As Date)
            fecha_vence = value
        End Set
    End Property

    Public Function RegistrarEntradaAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarEntradaAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_producto"
        sqlpar.Value = IdProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad"
        sqlpar.Value = CantidadProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precio_unitario"
        sqlpar.Value = PrecioUnitario
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lote"
        sqlpar.Value = LoteProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_almacen"
        sqlpar.Value = IdAlmacen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_vencimiento"
        sqlpar.Value = FechaVencimiento
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

    Public Function RecuperarEntradasInventario() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select * from EntradaAlmacen"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function


    Public Function ListarEntradaInventario() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.lote,p.id_producto,p.nombre_producto,e.cantidad,e.precio_unitario,e.fecha_vencimiento, e.id_entrada from EntradaAlmacen e, ProductoAlmacen p
where e.id_producto = p.id_producto", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ListarEntradaInventarioFecha(ByVal inicio As Date, ByVal fin As Date) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.lote,p.id_producto,p.nombre_producto,e.cantidad,e.precio_unitario,e.fecha_vencimiento, e.id_entrada from EntradaAlmacen e, ProductoAlmacen p
where e.id_producto = p.id_producto and e.fecha_registro between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
