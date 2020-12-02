Imports System.Data.SqlClient

Public Class ClsDetalleListaPrecios
    Dim codigo, codigoListaPrecios, codigoGrupoItem, codigoDescuento As Integer
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
    Public Property codigoListaPrecios_ As Integer
        Get
            Return codigoListaPrecios
        End Get
        Set(value As Integer)
            codigoListaPrecios = value
        End Set
    End Property
    Public Property codigoGrupoItem_ As Integer
        Get
            Return codigoGrupoItem
        End Get
        Set(value As Integer)
            codigoGrupoItem = value
        End Set
    End Property
    Public Property codigoDescuento_ As Integer
        Get
            Return codigoDescuento
        End Get
        Set(value As Integer)
            codigoDescuento = value
        End Set
    End Property
    Public Function RegistrarNuevoDetalleListaPrecios() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarDetalleListaPrecios"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoListaPrecios" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoListaPrecios_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoGrupoItem" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoGrupoItem_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoDescuento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoDescuento_
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
    Public Function ModificarDetalleListaPrecios() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarDetalleListaPrecios"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoListaPrecios" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoListaPrecios_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoGrupoItem" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoGrupoItem_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoDescuento" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoDescuento_
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
    Public Function EliminarDetalleListaPrecios() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmEliminarDetalleListaPrecios"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
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
    Public Function BuscarDetalleListaPrecios() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarDetalleListaPrecios"
            cmd.Parameters.Add("@codigoListaPrecios", SqlDbType.Int).Value = codigoListaPrecios_
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