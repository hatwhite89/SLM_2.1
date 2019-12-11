

Imports System.Data.SqlClient
Public Class ClsFacturaCompra

    Dim codFactura, codProveedor As Integer
    Dim total As Double
    Dim nombreProveedor, moneda, terminosPago, nroFactura As String
    Dim fechaFactura, fechaTransaccion, fechaVencimiento As Date

    'Constructor
    Public Sub New()

    End Sub
    ':::::::::::::::::::::::::::::::::::::::::::: Metodos SET y GET ::::::::::::::::::::::::::::::::::::::::::::

    'Codigo Proveedor
    Public Property Cod_Proveedor As Integer
        Get
            Return codProveedor
        End Get
        Set(value As Integer)
            codProveedor = value
        End Set
    End Property
    'Codigo Factura
    Public Property Cod_Factura As Integer
        Get
            Return codFactura
        End Get
        Set(value As Integer)
            codFactura = value
        End Set
    End Property
    'Total
    Public Property Tota_l As Double
        Get
            Return total
        End Get
        Set(value As Double)
            total = value
        End Set
    End Property
    'Terminos de Pago
    Public Property Terminos_Pago As String
        Get
            Return terminosPago
        End Get
        Set(value As String)
            terminosPago = value
        End Set
    End Property
    'Moneda
    Public Property Moned_a As String
        Get
            Return moneda
        End Get
        Set(value As String)
            moneda = value
        End Set
    End Property
    'Nombre de Proveedor
    Public Property Nombre_Proveedor As String
        Get
            Return nombreProveedor
        End Get
        Set(value As String)
            nombreProveedor = value
        End Set
    End Property
    'Fecha Vencimiento
    Public Property Fecha_Vencimiento As Date
        Get
            Return fechaVencimiento
        End Get
        Set(value As Date)
            fechaVencimiento = value
        End Set
    End Property
    'Fecha Transaccion
    Public Property Fecha_Transaccion As Date
        Get
            Return fechaTransaccion
        End Get
        Set(value As Date)
            fechaTransaccion = value
        End Set
    End Property
    'Fecha Factura
    Public Property Fecha_Factura As Date
        Get
            Return fechaFactura
        End Get
        Set(value As Date)
            fechaFactura = value
        End Set
    End Property

    Public Property Nro_Factura As String
        Get
            Return nroFactura
        End Get
        Set(value As String)
            nroFactura = value
        End Set
    End Property
    ':::::::::::::::::::::::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::::::::::::::::::::::::::::

    'Nuevo registro de Factura Compra
    Public Function registrarNuevaFacturaCompra() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarFacturaCompras"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codProveedor"
        sqlpar.Value = Cod_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total"
        sqlpar.Value = Tota_l
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda"
        sqlpar.Value = Moned_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "terminosPago"
        sqlpar.Value = Terminos_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFactura"
        sqlpar.Value = Fecha_Factura
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaTransaccion"
        sqlpar.Value = Fecha_Transaccion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaVencimiento"
        sqlpar.Value = Fecha_Vencimiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroFactura"
        sqlpar.Value = Nro_Factura
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

    'Modificacion registro de Factura Compra
    Public Function modificarFacturaCompra() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarFacturaCompras"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFactura"
        sqlpar.Value = Cod_Factura
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codProveedor"
        sqlpar.Value = Cod_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total"
        sqlpar.Value = Tota_l
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda"
        sqlpar.Value = Moned_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFactura"
        sqlpar.Value = Fecha_Factura
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaTransaccion"
        sqlpar.Value = Fecha_Transaccion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaVencimiento"
        sqlpar.Value = Fecha_Vencimiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroFactura"
        sqlpar.Value = Nro_Factura
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

    'Listar Factura Compra
    Public Function listarFacturaCompra() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarFacturasCompra", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Capturar ultima Factura Compra
    Public Function capturarCodFacturaCompra() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmCapturarCodFacturaCompra", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using


    End Function

    'Filtro Factura por nombre de proveedor
    Public Function buscarFacturaProveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarFacturaCompraPro"
            cmd.Parameters.Add("@nombreProveedor", SqlDbType.VarChar).Value = Nombre_Proveedor
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Comprobar existencia factura
    Public Function comprobarFactura() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarFacturaCompraCode"
            cmd.Parameters.Add("@codFactura", SqlDbType.Int).Value = Cod_Factura
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function




End Class
