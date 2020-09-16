Imports System.Data.SqlClient

Public Class clsDetalleOI
    Dim id, id_producto, id_oi, id_entrada As Integer
    Dim lote, producto As String
    Dim cantidad_solicitada As Double
    Dim cantidad_entregada As Double

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Id_producto1 As Integer
        Get
            Return id_producto
        End Get
        Set(value As Integer)
            id_producto = value
        End Set
    End Property

    Public Property Lote1 As String
        Get
            Return lote
        End Get
        Set(value As String)
            lote = value
        End Set
    End Property

    Public Property Producto1 As String
        Get
            Return producto
        End Get
        Set(value As String)
            producto = value
        End Set
    End Property

    Public Property Cantidad_solicitada1 As Double
        Get
            Return cantidad_solicitada
        End Get
        Set(value As Double)
            cantidad_solicitada = value
        End Set
    End Property

    Public Property Cantidad_entregada1 As Double
        Get
            Return cantidad_entregada
        End Get
        Set(value As Double)
            cantidad_entregada = value
        End Set
    End Property

    Public Property Id_oi1 As Integer
        Get
            Return id_oi
        End Get
        Set(value As Integer)
            id_oi = value
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

    Public Function RegistrarOrdenInterna() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarDetalleOrdenInterna"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_producto"
        sqlpar.Value = Id_producto1
        sqlcom.Parameters.Add(sqlpar)




        sqlpar = New SqlParameter
        sqlpar.ParameterName = "producto"
        sqlpar.Value = Producto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad_solicitada"
        sqlpar.Value = Cantidad_solicitada1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad_recibida"
        sqlpar.Value = Cantidad_entregada1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oi"
        sqlpar.Value = Id_oi1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_entrada"
        sqlpar.Value = Id_entrada1
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

    'Listar Ultima Chequera
    Public Function listarOrdenesInternasConParametro(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select d.id_detalle_oi,p.id_producto,p.nombre_producto,d.cantidad_solicitada 
from 
OrdenInterna o, 
detalleOrdenInterna d, 
ProductoAlmacen p,
Usuario u
where d.id_producto = p.id_producto 

and d.id_oi = o.id_oi


and  o.id_usuario= u.cod_usuario
 and d.estado = 0  and d.id_oi='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function EliminarOrdenInterna() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmEliminarDetalleOI"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_detalle_oc"
        sqlpar.Value = Id_oi1
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

    Public Function listarInventarioExistencias(ByVal codigo As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.id_entrada, p.nombre_producto,e.lote,e.existencia,e.fecha_vencimiento,a.nombre_almacen
from EntradaAlmacen e, ProductoAlmacen p,Almacen a
where e.id_producto = p.id_producto
and a.id_almacen =e.id_almacen
and e.existencia > 0  and p.id_producto ='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
