
Imports System.Data.SqlClient
Public Class ClsDetalleFacturaCompra

    'Variables 
    Dim codDetalle, cuenta, codFactura As Integer
    Dim area, sede, descripcion, tipoStock As String
    Dim monto As Double

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::: Metodos SET y GET ::::::::::::::::::::::::::::::::::::::::::::
    'Monto
    Public Property Mont_o As Double
        Get
            Return monto
        End Get
        Set(value As Double)
            monto = value
        End Set
    End Property

    'Tipo de Stock
    Public Property Tipo_Stock As String
        Get
            Return tipoStock
        End Get
        Set(value As String)
            tipoStock = value
        End Set
    End Property

    'Descripcion
    Public Property Descripcio_n As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Area
    Public Property Are_a As String
        Get
            Return area
        End Get
        Set(value As String)
            area = value
        End Set
    End Property

    'Sede
    Public Property Sed_e As String
        Get
            Return sede
        End Get
        Set(value As String)
            sede = value
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

    'Cuenta
    Public Property Cuent_a As Integer
        Get
            Return cuenta
        End Get
        Set(value As Integer)
            cuenta = value
        End Set
    End Property

    'Codigo Detalle
    Public Property Cod As Integer
        Get
            Return codDetalle
        End Get
        Set(value As Integer)
            codDetalle = value
        End Set
    End Property

    ':::::::::::::::::::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::::::::::::::::::::::::

    'Registrar Detalle de Factura
    Public Function registrarDetalleFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDetalleFacturaCompras"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuent_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "area"
        sqlpar.Value = Are_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sede"
        sqlpar.Value = Sed_e
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "monto"
        sqlpar.Value = Mont_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoStock"
        sqlpar.Value = Tipo_Stock
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFactura"
        sqlpar.Value = Cod_Factura
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

    'Modificar Detalle de Factura
    Public Function modificarDetalleFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDetalleFacturaCompra"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codDetalle"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuent_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "area"
        sqlpar.Value = Are_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sede"
        sqlpar.Value = Sed_e
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "monto"
        sqlpar.Value = Mont_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoStock"
        sqlpar.Value = Tipo_Stock
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFactura"
        sqlpar.Value = Cod_Factura
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

    'Listar detalles de Factura Compra
    Public Function listarDetallesFacturaCompra() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmlistarDetalleFacturaCompra"
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
