Imports System.Data.SqlClient
Public Class ClsCotizacionFactura
    Dim numero, numeroCotizacion, codigoExamen, cantidad, descuento As Integer
    Dim fechaEntrega As Date
    Dim subtotal As Double
    'Constructor
    Public Sub New()

    End Sub
    'Métodos GET y SET
    Public Property numero_ As Integer
        Get
            Return numero
        End Get
        Set(value As Integer)
            numero = value
        End Set
    End Property
    Public Property numeroCotizacion_ As Integer
        Get
            Return numeroCotizacion
        End Get
        Set(value As Integer)
            numeroCotizacion = value
        End Set
    End Property
    Public Property codigoExamen_ As Integer
        Get
            Return codigoExamen
        End Get
        Set(value As Integer)
            codigoExamen = value
        End Set
    End Property
    Public Property cantidad_ As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property
    Public Property descuento_ As Integer
        Get
            Return descuento
        End Get
        Set(value As Integer)
            descuento = value
        End Set
    End Property
    Public Property fechaEntrega_ As Date
        Get
            Return fechaEntrega
        End Get
        Set(value As Date)
            fechaEntrega = value
        End Set
    End Property
    Public Property subtotal_ As Double
        Get
            Return subtotal
        End Get
        Set(value As Double)
            subtotal = value
        End Set
    End Property
    Public Function RegistrarNuevaCotizacionFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCotizacionFactura_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroCotizacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroCotizacion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoExamen" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoExamen_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cantidad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaEntrega" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaEntrega_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descuento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descuento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "subtotal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = subtotal_
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
    Public Function ModificarCotizacionFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarCotizacionFactura_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroCotizacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroCotizacion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoExamen" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoExamen_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cantidad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaEntrega" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaEntrega_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descuento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descuento_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "subtotal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = subtotal_
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
    Public Function BuscarCotizacionFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarCotizacionFactura_M"
            cmd.Parameters.Add("@numeroCotizacion", SqlDbType.Int).Value = numeroCotizacion_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function SeleccionarCotizacionFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("slmSeleccionarCotizacionFactura_M", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
