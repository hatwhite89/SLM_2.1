Imports System.Data.SqlClient
Public Class ClsListaPrecios
    Dim descripcion, codigoBreve As String
    Dim codigo, codigoTerminoPago As Integer
    Dim tipoConvenio As Boolean
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
    Public Property codigoBreve_ As String
        Get
            Return codigoBreve
        End Get
        Set(value As String)
            codigoBreve = value
        End Set
    End Property
    Public Property descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
    Public Property tipoConvenio_ As Boolean
        Get
            Return tipoConvenio
        End Get
        Set(value As Boolean)
            tipoConvenio = value
        End Set
    End Property
    Public Property codigoTerminoPago_ As Integer
        Get
            Return codigoTerminoPago
        End Get
        Set(value As Integer)
            codigoTerminoPago = value
        End Set
    End Property
    Public Function RegistrarNuevaListaPrecios() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarListaPrecios"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoBreve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoConvenio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = tipoConvenio_
        sqlcom.Parameters.Add(sqlpar)

        If tipoConvenio_ Then
            sqlpar = New SqlParameter
            sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
            sqlpar.Value = codigoTerminoPago_
            sqlcom.Parameters.Add(sqlpar)
        End If

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
    Public Function ModificarListaPrecios() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarListaPrecios"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoBreve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoConvenio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = tipoConvenio_
        sqlcom.Parameters.Add(sqlpar)

        If tipoConvenio_ Then
            sqlpar = New SqlParameter
            sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
            sqlpar.Value = codigoTerminoPago_
            sqlcom.Parameters.Add(sqlpar)
        End If

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
    Public Function BuscarListaPreciosCodigo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarListaPreciosCodigo"
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
    Public Function BuscarListaPrecios() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarListaPrecios"
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion_
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
    Public Function BuscarListaPreciosCode() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarListaPreciosCode"
            cmd.Parameters.Add("@codigoBreve", SqlDbType.VarChar).Value = codigoBreve_
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
    Public Function CapturarListaPrecios() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmCapturarListaPrecios", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
    Public Function SeleccionarListaPrecios() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarListaPrecios", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class