Imports System.Data.SqlClient

Public Class clsDetalleOC
    Dim id, cod_proc, id_oc, cantidad_recibida As Integer
    Dim producto, num_lote As String
    Dim fecha_vence As Date
    Dim estado As Boolean
    Dim isv, cantidad, precio_uni, costo_total As Double


    Public Property CodigoProducto As Integer
        Get
            Return cod_proc
        End Get
        Set(value As Integer)
            cod_proc = value
        End Set
    End Property

    Public Property Numerolote As String
        Get
            Return num_lote
        End Get
        Set(value As String)
            num_lote = value
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



    Public Property ISVDetalle As Double
        Get
            Return isv
        End Get
        Set(value As Double)
            isv = value
        End Set
    End Property

    Public Property CantidadDetalle As Double
        Get
            Return cantidad
        End Get
        Set(value As Double)
            cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Double
        Get
            Return precio_uni
        End Get
        Set(value As Double)
            precio_uni = value
        End Set
    End Property

    Public Property CostoTotal As Double
        Get
            Return costo_total
        End Get
        Set(value As Double)
            costo_total = value
        End Set
    End Property

    Public Property ProductoOC As String
        Get
            Return producto
        End Get
        Set(value As String)
            producto = value
        End Set
    End Property

    Public Property EstadoOC As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    Public Property IdOC As Integer
        Get
            Return id_oc
        End Get
        Set(value As Integer)
            id_oc = value
        End Set
    End Property

    Public Property IdDetalleOC As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Cantidad_recibida1 As Integer
        Get
            Return cantidad_recibida
        End Get
        Set(value As Integer)
            cantidad_recibida = value
        End Set
    End Property

    Public Function RegistrarDetalleOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarDetalleOC"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_producto" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = ProductoOC
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_producto" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = CodigoProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "num_lote" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Numerolote
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_vencimiento" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = FechaVencimiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "isv" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = ISVDetalle
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = CantidadDetalle
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precio_unitario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = PrecioUnitario
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "costo_total" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = CostoTotal
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOC
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado_ingresado" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = EstadoOC
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad_recibida" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Cantidad_recibida1
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

    Public Function ActualizarDetalleOCEntrada() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarDetalleOCEntrada"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_detalle_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdDetalleOC
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad_recibida" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Cantidad_recibida1
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

    Public Function EliminarDetalleOCEntrada() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmEliminarDetalleOCEntrada"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_detalle_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdDetalleOC
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

    Public Function ListarDetalleOC(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select  id_detalle_oc,cod_producto,nombre_producto,precio_unitario,cantidad,costo_total from DetalleOrdenCompra where id_oc ='" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ListarDetalleOCEntrada(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select id_detalle_oc, cod_producto,nombre_producto,num_lote,precio_unitario,cantidad,cantidad_recibida, costo_total from DetalleOrdenCompra where id_oc ='" + cod + "' and estado_ingresado = 0", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
