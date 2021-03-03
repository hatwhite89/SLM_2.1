Imports System.Data.SqlClient

Public Class clsInventario

    Public Function BIAlmacen2(ByVal almacen As String, ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("
select top " + cod + " COUNT(e.existencia) as cantidad ,p.nombre_producto  from EntradaAlmacen e, ProductoAlmacen p
where e.id_producto =p.id_producto and e.id_almacen='" + almacen + "'
group by p.nombre_producto 
", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function BIAlmacen() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select COUNT(e.cantidad) as cantidad , a.nombre_almacen from  Almacen a, EntradaAlmacen e
where a.id_almacen =e.id_almacen
group by a.nombre_almacen", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function DatosGrafica(ByVal id_orden As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from datosgrafica where id_orden ='" + id_orden + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function BIAlmacenCostoInventario() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select COUNT(e.cantidad) as cantidad , a.nombre_almacen,sum(e.cantidad*e.precio_unitario) as costo from  Almacen a, EntradaAlmacen e
where a.id_almacen =e.id_almacen 
group by a.nombre_almacen
order by costo desc", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function ListarInventarioAlmacen(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where existencia > 0 And e.id_producto = p.id_producto And e.id_almacen ='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ListarInventarioAlmacenProductoVencido(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where e.fecha_vencimiento <= GETDATE()  and e.id_producto = p.id_producto  and e.id_almacen='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ListarInventarioAlmacenSinExistencia(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where existencia <=0 and e.id_producto = p.id_producto and e.id_almacen='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function



    Public Function TotalInventarioAlmacenProductoVencido() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where e.fecha_vencimiento <= GETDATE()  and e.id_producto = p.id_producto  ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function TotalInventarioAlmacenSinExistencia() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where existencia =0 and e.id_producto = p.id_producto ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function TotalInventarioAlmacen() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where existencia >0 and e.id_producto = p.id_producto ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function MovimientoInventarioAlmacen(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.id_entrada, e.id_producto, p.nombre_producto,e.lote,e.existencia from EntradaAlmacen e, ProductoAlmacen p
where existencia >0 and e.id_producto = p.id_producto and e.id_almacen='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function MovimientoInventarioAlmacen2(ByVal codigo As String) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select e.id_entrada, e.id_producto, p.nombre_producto,e.lote,e.existencia from EntradaAlmacen e, ProductoAlmacen p
where existencia >0 and e.id_producto = p.id_producto and e.id_almacen='" + codigo + "'"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function
End Class
