Imports System.Data.SqlClient

Public Class ClsSalidaAlmacen
    Dim id_producto, id_oi, id_detalle_oi, id_entrada, id_entrada_almacen, id_salida As Integer
    Dim cantidad As Double
    Dim lote, descrip, tipo_movimiento, producto, persona_recibe, id_almacen, persona_entrega, id_departamento As String
    Dim fecha_vence As Date

    Public Sub New()

    End Sub

    Public Property IdProducto As Integer
        Get
            Return id_producto
        End Get
        Set(value As Integer)
            id_producto = value
        End Set
    End Property

    Public Property IdAlmacen As String
        Get
            Return id_almacen
        End Get
        Set(value As String)
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

    Public Property Id_oi1 As Integer
        Get
            Return id_oi
        End Get
        Set(value As Integer)
            id_oi = value
        End Set
    End Property

    Public Property Persona_recibe1 As String
        Get
            Return persona_recibe
        End Get
        Set(value As String)
            persona_recibe = value
        End Set
    End Property

    Public Property Persona_entrega1 As String
        Get
            Return persona_entrega
        End Get
        Set(value As String)
            persona_entrega = value
        End Set
    End Property

    Public Property Id_departamento1 As String
        Get
            Return id_departamento
        End Get
        Set(value As String)
            id_departamento = value
        End Set
    End Property

    Public Property Tipo_movimiento1 As String
        Get
            Return tipo_movimiento
        End Get
        Set(value As String)
            tipo_movimiento = value
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

    Public Property Id_detalle_oi1 As Integer
        Get
            Return id_detalle_oi
        End Get
        Set(value As Integer)
            id_detalle_oi = value
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

    Public Property Id_entrada_almacen1 As Integer
        Get
            Return id_entrada_almacen
        End Get
        Set(value As Integer)
            id_entrada_almacen = value
        End Set
    End Property

    Public Property Id_salida1 As Integer
        Get
            Return id_salida
        End Get
        Set(value As Integer)
            id_salida = value
        End Set
    End Property

    Public Function RegistrarSalidaAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarSalidaAlmacen"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_io"
        sqlpar.Value = Id_oi1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_detalle_io"
        sqlpar.Value = Id_detalle_oi1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_producto"
        sqlpar.Value = IdProducto
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lote"
        sqlpar.Value = LoteProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "producto"
        sqlpar.Value = Producto1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad_entregada"
        sqlpar.Value = CantidadProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "persona_recibe"
        sqlpar.Value = Persona_recibe1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "persona_entrega"
        sqlpar.Value = Persona_entrega1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "almacen_entrega"
        sqlpar.Value = IdAlmacen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_salida"
        sqlpar.Value = FechaVencimiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "departamento_recibe"
        sqlpar.Value = Id_departamento1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipo_movimiento"
        sqlpar.Value = Tipo_movimiento1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones"
        sqlpar.Value = Descripcion
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
    Public Function ListarSalidaInventarioFecha(ByVal inicio As Date, ByVal fin As Date) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select id_salida,id_producto,producto,cantidad_entregada,persona_recibe,persona_entrega from SalidaAlmacen
where fecha_salida between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ExistenciasDeEntrada(ByVal id_entrada As String) As String
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select existencia from  EntradaAlmacen where id_entrada = '" + id_entrada + "'"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteScalar
    End Function

    Public Function RecuperarDatosOrdenInterna(ByVal inicio As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.nombreCompleto,u.usuario,d.nombre from OrdenInterna o, Usuario u,Empleados e, Departamento d
where o.id_usuario =u.cod_usuario and u.codigo = e.codigo and o.id_departamento = d.codigo
and o.id_oi ='" + inicio + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function RegistrarSalidaAlmacen2() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_OtrasSalidas"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_entrada"
        sqlpar.Value = Id_entrada_almacen1
        sqlcom.Parameters.Add(sqlpar)




        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad"
        sqlpar.Value = CantidadProducto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario"
        sqlpar.Value = Persona_recibe1
        sqlcom.Parameters.Add(sqlpar)




        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones"
        sqlpar.Value = Descripcion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipomovimiento"
        sqlpar.Value = Tipo_movimiento1
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



    Public Function RegistrarDevolucionEntrada() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarEntradaAlmacenDevoluvion"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_salida"
        sqlpar.Value = Id_salida1
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
