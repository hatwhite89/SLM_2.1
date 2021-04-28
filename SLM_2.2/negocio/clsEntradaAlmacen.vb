Imports System.Data.SqlClient

Public Class clsEntradaAlmacen
    Dim id_producto, id_almacen, id_entrada, id_oc, id_almacen_viejo, id_traslado, id_detalle_oc As Integer
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

    Public Property Id_entrada1 As Integer
        Get
            Return id_entrada
        End Get
        Set(value As Integer)
            id_entrada = value
        End Set
    End Property

    Public Property Id_oc1 As Integer
        Get
            Return id_oc
        End Get
        Set(value As Integer)
            id_oc = value
        End Set
    End Property

    Public Property Id_almacen_viejo1 As Integer
        Get
            Return id_almacen_viejo
        End Get
        Set(value As Integer)
            id_almacen_viejo = value
        End Set
    End Property

    Public Property Id_traslado1 As Integer
        Get
            Return id_traslado
        End Get
        Set(value As Integer)
            id_traslado = value
        End Set
    End Property

    Public Property Id_detalle_oc1 As Integer
        Get
            Return id_detalle_oc
        End Get
        Set(value As Integer)
            id_detalle_oc = value
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
        sqlpar.ParameterName = "id_oc"
        sqlpar.Value = Id_oc1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_detalle_oc"
        sqlpar.Value = Id_detalle_oc1
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

    Public Function ActualizarEntradaAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarEntradaAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_entrada"
        sqlpar.Value = Id_entrada1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "orden_compra"
        sqlpar.Value = Id_oc1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "detalle_oc"
        sqlpar.Value = Id_detalle_oc1
        sqlcom.Parameters.Add(sqlpar)
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad"
        sqlpar.Value = CantidadProducto
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_vencimiento"
        sqlpar.Value = FechaVencimiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lote"
        sqlpar.Value = LoteProducto
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

        Using da As New SqlDataAdapter("select  id_producto,nombre_producto,descripcion from ProductoAlmacen", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ListarEntradaInventarioFecha(ByVal inicio As Date, ByVal fin As Date) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.lote,p.id_producto,p.nombre_producto,e.cantidad,e.precio_unitario,e.fecha_vencimiento, e.id_entrada,e.id_oc,e.id_detalle_oc from EntradaAlmacen e, ProductoAlmacen p
where e.id_producto = p.id_producto and e.fecha_registro between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function TrasladarEntradaAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmMoverInventario"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_entrada"
        sqlpar.Value = Id_entrada1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nueva_existencia"
        sqlpar.Value = CantidadProducto
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nuevo_almacen"
        sqlpar.Value = IdAlmacen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "almacen_viejo"
        sqlpar.Value = Id_almacen_viejo1
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
    Public Function AceptarTraslado() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmMoverInventario2"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_entrada"
        sqlpar.Value = Id_entrada1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_traslado"
        sqlpar.Value = Id_traslado1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nueva_existencia"
        sqlpar.Value = CantidadProducto
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nuevo_almacen"
        sqlpar.Value = IdAlmacen
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


    Public Function ListarTrasladosFecha(ByVal inicio As Date, ByVal fin As Date) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select  p.nombre_producto ,t.cantidad,t.estado,t.fecha_envio,t.lote,a.nombre_almacen,a.usuario from traslado t, almacen a,ProductoAlmacen p
where t.almacen_recibe = a.id_almacen and t.id_producto = p.id_producto and a.usuario ='" + nombre_usurio + "' and  t.fecha_envio  between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

    Public Function ListarTrasladosFecha2(ByVal inicio As Date, ByVal fin As Date) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select  p.nombre_producto ,t.cantidad,t.estado,t.fecha_envio,t.lote,a.nombre_almacen,a.usuario from traslado t, almacen a,ProductoAlmacen p
where t.almacen_entrega = a.id_almacen and t.id_producto = p.id_producto and t.usuario_recibe ='" + codigo_usuario + "' and  t.fecha_envio  between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

    Public Function ListarTrasladosEnTransito() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select t.id,t.id_entrada, p.id_producto, t.precio_unitario,p.nombre_producto ,t.cantidad,t.estado,t.fecha_envio,t.lote,a.nombre_almacen,a.usuario,a.id_almacen from traslado t, almacen a,ProductoAlmacen p
where t.almacen_entrega = a.id_almacen and t.id_producto = p.id_producto and t.usuario_recibe ='" + codigo_usuario + "' "
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

End Class
