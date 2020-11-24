Imports System.Data.SqlClient

Public Class ClsTrasladosAlmacen
    Dim id, almacen_entrega, usuario_entrega, usuario_recibe, id_entrada, id_producto, id_oc, almacen_recibe As Integer
    Dim fecha_envio, fecha_recibio, fecha_vencimiento As Date
    Dim estado, lote, descripcion As String
    Dim precio_unitario As Double

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Almacen_entrega1 As Integer
        Get
            Return almacen_entrega
        End Get
        Set(value As Integer)
            almacen_entrega = value
        End Set
    End Property

    Public Property Usuario_entrega1 As Integer
        Get
            Return usuario_entrega
        End Get
        Set(value As Integer)
            usuario_entrega = value
        End Set
    End Property

    Public Property Usuario_recibe1 As Integer
        Get
            Return usuario_recibe
        End Get
        Set(value As Integer)
            usuario_recibe = value
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

    Public Property Id_oc1 As Integer
        Get
            Return id_oc
        End Get
        Set(value As Integer)
            id_oc = value
        End Set
    End Property

    Public Property Almacen_recibe1 As Integer
        Get
            Return almacen_recibe
        End Get
        Set(value As Integer)
            almacen_recibe = value
        End Set
    End Property

    Public Property Fecha_envio1 As Date
        Get
            Return fecha_envio
        End Get
        Set(value As Date)
            fecha_envio = value
        End Set
    End Property

    Public Property Fecha_recibio1 As Date
        Get
            Return fecha_recibio
        End Get
        Set(value As Date)
            fecha_recibio = value
        End Set
    End Property

    Public Property Fecha_vencimiento1 As Date
        Get
            Return fecha_vencimiento
        End Get
        Set(value As Date)
            fecha_vencimiento = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
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

    Public Property Descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property Precio_unitario1 As Double
        Get
            Return precio_unitario
        End Get
        Set(value As Double)
            precio_unitario = value
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

    Public Function RegistrarTraslado() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "almacen_entrega"
        sqlpar.Value = Almacen_entrega1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "almacen_recibe"
        sqlpar.Value = Almacen_recibe1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_envio"
        sqlpar.Value = Fecha_envio1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_recibio"
        sqlpar.Value = Fecha_recibio1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_entrega"
        sqlpar.Value = Usuario_entrega1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_recibe"
        sqlpar.Value = Usuario_recibe1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estado1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_entrada"
        sqlpar.Value = Id_entrada1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_producto"
        sqlpar.Value = Id_producto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precio_unitario"
        sqlpar.Value = Precio_unitario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "lote"
        sqlpar.Value = Lote1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_vencimiento"
        sqlpar.Value = Fecha_vencimiento1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc"
        sqlpar.Value = Id_oc1
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
