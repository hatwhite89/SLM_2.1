Imports System.Data.SqlClient
Public Class ClsCategoria
    Dim codigoTipo As Integer
    Dim descripcion, codigo As String
    'Constructor
    Public Sub New()

    End Sub

    Public Property Codigo1 As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property CodigoTipo1 As Integer
        Get
            Return codigoTipo
        End Get
        Set(value As Integer)
            codigoTipo = value
        End Set
    End Property

    Public Property descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property


    Public Function RegistrarNuevaCategoria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCategoria_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTipo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CodigoTipo1
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

    Public Function ModificarCategoria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarCategoria_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTipo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CodigoTipo1
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


    Public Function BuscarCategoria() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarCategoria_M"
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function BuscarCategoriaCode() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarCategoriaCode_M"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo1
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function SeleccionarCategoria() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmSeleccionarCategoria_M", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
