Imports System.Data.SqlClient

Public Class ClsDetalleCAI
    Dim codigo, codigoCAI As Integer
    Dim numeroOficial As String
    Dim estado As Boolean
    'Constructor
    Public Sub New()

    End Sub
    'get y set
    Public Property Codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Public Property codigoCAI_ As Integer
        Get
            Return codigoCAI
        End Get
        Set(value As Integer)
            codigoCAI = value
        End Set
    End Property
    Public Property numeroOficial_ As String
        Get
            Return numeroOficial
        End Get
        Set(value As String)
            numeroOficial = value
        End Set
    End Property

    Public Property estado_ As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    Public Function RegistrarNuevoDetalleCAI(ByVal serie As String, ByVal desde As String, ByVal cantidad As Integer) As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarDetalleCAI"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCAI" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCAI_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "serie" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = serie
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "desde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = desde
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cantidad
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "counter" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ""
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

    Public Function ModificarDetalleCAI() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarDetalleCAI"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_
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
    Public Function BuscarDetalleCAI() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarDetalleCAI"
            cmd.Parameters.Add("@codigoCAI", SqlDbType.Int).Value = codigoCAI_
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

    Public Function SeleccionarCAI() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarDetalleCAI", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


End Class
