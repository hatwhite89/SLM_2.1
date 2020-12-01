Imports System.Data.SqlClient

Public Class ClsTerminoPago

    Dim codigoTerminoPago, descripcion As String
    Dim codigoCtaContado, diasNeto, codigoCtaVentas, codigoTipoTermino As Integer
    Dim codigo As Integer
    'Constructor
    Public Sub New()

    End Sub
    Public Property codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Public Property codigoTerminoPago_ As String
        Get
            Return codigoTerminoPago
        End Get
        Set(value As String)
            codigoTerminoPago = value
        End Set
    End Property

    Public Property codigoCtaContado1 As Integer
        Get
            Return codigoCtaContado
        End Get
        Set(value As Integer)
            codigoCtaContado = value
        End Set
    End Property
    Public Property diasNeto1 As Integer
        Get
            Return diasNeto
        End Get
        Set(value As Integer)
            diasNeto = value
        End Set
    End Property
    Public Property codigoCtaVentas1 As Integer
        Get
            Return codigoCtaVentas
        End Get
        Set(value As Integer)
            codigoCtaVentas = value
        End Set
    End Property
    Public Property codigoTipoTermino1 As Integer
        Get
            Return codigoTipoTermino
        End Get
        Set(value As Integer)
            codigoTipoTermino = value
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
    Public Function RegistrarNuevaTerminoPago() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarTerminoPago"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminoPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Descripcion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "diasNeto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = diasNeto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCtaContado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCtaContado1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCtaVentas" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCtaVentas1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTipoTermino" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTipoTermino1
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

    Public Function ModificarTerminoPago() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarTerminoPago"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminoPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Descripcion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "diasNeto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = diasNeto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCtaContado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCtaContado1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCtaVentas" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCtaVentas1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTipoTermino" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTipoTermino1
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
    Public Function BuscarTerminoPagoNumero() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarTerminoPagoNumero"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarTerminoPago() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarTerminoPago"
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Descripcion1
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarTerminoPagoCode() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarTerminoPagoCode"
            cmd.Parameters.Add("@codigoTerminoPago", SqlDbType.VarChar).Value = codigoTerminoPago_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function SeleccionarTerminoPago() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarTerminoPago", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Listar código y descripcion de termino de pago
    Public Function listarCodDescripTerminoPago() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarCodDescripTerminoPago", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Listar por busqueda de codigo
    Public Function listarBusquedaTerminoPago() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarTerminoPagoCod"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function
End Class
