Imports System.Data.SqlClient

Public Class ClsColaPacientes
    Dim codigo, numeroFactura As Integer
    Dim prioridad, estadoEnCola As Boolean
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
    Public Property numeroFactura_ As Integer
        Get
            Return numeroFactura
        End Get
        Set(value As Integer)
            numeroFactura = value
        End Set
    End Property
    Public Property prioridad_ As Boolean
        Get
            Return prioridad
        End Get
        Set(value As Boolean)
            prioridad = value
        End Set
    End Property
    Public Property estadoEnCola_ As Boolean
        Get
            Return estadoEnCola
        End Get
        Set(value As Boolean)
            estadoEnCola = value
        End Set
    End Property
    Public Function RegistrarNuevaColaPacientes() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarColaPacientes"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroFactura" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroFactura_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "prioridad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = prioridad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoEnCola" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estadoEnCola_
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
    Public Function ModificarColaPacientesEstado() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarColaPacientesEstado"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoEnCola" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estadoEnCola_
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
    Public Function ModificarColaPacientes() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarColaPacientes"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroFactura" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroFactura_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "prioridad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = prioridad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estadoEnCola" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estadoEnCola_
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
    Public Function BuscarColaPacientes() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarColaPacientes"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarColaPacientesCliente(ByVal nombre As String) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarColaPacientesCliente"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarColaPacientesFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarColaPacientesFactura"
            cmd.Parameters.Add("@numeroFactura", SqlDbType.Int).Value = numeroFactura_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function ListarColaPacientes() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmListarColaPacientes", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function SeleccionarColaPacientes() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarColaPacientes", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
