Imports System.Data.SqlClient

Public Class ClsPermisos
    Dim asunto As String
    Dim codigo, codigoEmpleado, codigoJefeInmediato, codigoTalentoHumano As Integer
    Dim fecha As Date
    Dim entradaTarde, salidaTemprano, salidaTarde As System.Nullable(Of Date)
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
    Public Property fecha_ As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property asunto_ As String
        Get
            Return asunto
        End Get
        Set(value As String)
            asunto = value
        End Set
    End Property
    Public Property codigoEmpleado_ As Integer
        Get
            Return codigoEmpleado
        End Get
        Set(value As Integer)
            codigoEmpleado = value
        End Set
    End Property
    Public Property codigoJefeInmediato_ As Integer
        Get
            Return codigoJefeInmediato
        End Get
        Set(value As Integer)
            codigoJefeInmediato = value
        End Set
    End Property
    Public Property codigoTalentoHumano_ As Integer
        Get
            Return codigoTalentoHumano
        End Get
        Set(value As Integer)
            codigoTalentoHumano = value
        End Set
    End Property
    Public Property entradaTarde_ As System.Nullable(Of Date)
        Get
            Return entradaTarde
        End Get
        Set(value As System.Nullable(Of Date))
            entradaTarde = value
        End Set
    End Property
    Public Property salidaTemprano_ As System.Nullable(Of Date)
        Get
            Return salidaTemprano
        End Get
        Set(value As System.Nullable(Of Date))
            salidaTemprano = value
        End Set
    End Property
    Public Property salidaTarde_ As System.Nullable(Of Date)
        Get
            Return salidaTarde
        End Get
        Set(value As System.Nullable(Of Date))
            salidaTarde = value
        End Set
    End Property

    Public Function RegistrarNuevoPermiso() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarPermisos"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entradaTarde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entradaTarde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaTarde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaTarde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaTemprano" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaTemprano_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "asunto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = asunto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoEmpleado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoJefeInmediato" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoJefeInmediato_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTalentoHumano" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTalentoHumano_
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

    Public Function ModificarPermisos() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarPermisos"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entradaTarde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entradaTarde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaTarde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaTarde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salidaTemprano" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = salidaTemprano_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "asunto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = asunto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoEmpleado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoJefeInmediato" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoJefeInmediato_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTalentoHumano" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTalentoHumano_
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


    Public Function BuscarPermisosNombre() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarPermisosNombre"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = asunto_
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

    Public Function BuscarPermisos() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarPermiso"
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

    Public Function SeleccionarPermisos() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarPermisos", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

End Class
