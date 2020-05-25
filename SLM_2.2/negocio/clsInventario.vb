Imports System.Data.SqlClient

Public Class clsInventario
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
    Public Function ListarInventarioAlmacen(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombre_producto,e.lote,e.existencia,e.precio_unitario,e.fecha_vencimiento from EntradaAlmacen e, ProductoAlmacen p
where existencia >0 and e.id_producto = p.id_producto and e.id_almacen='" + codigo + "'", cn)
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
End Class
