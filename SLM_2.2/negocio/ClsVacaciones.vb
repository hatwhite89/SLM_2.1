Imports System.Data.SqlClient

Public Class ClsVacaciones
    Dim codigo, codigoEmpleado, codigoSupervisor, codigoJefeDepto, codigoTalentoHumano As Integer
    Dim motivoInasistencia, cubrira, observaciones, nombre As String
    Dim fechaInasistencia As Date
    Dim fecha As System.Nullable(Of Date)
    Dim notifico As Boolean
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
    Public Property fechaInasistencia_ As Date
        Get
            Return fechaInasistencia
        End Get
        Set(value As Date)
            fechaInasistencia = value
        End Set
    End Property
    Public Property notifico_ As Boolean
        Get
            Return notifico
        End Get
        Set(value As Boolean)
            notifico = value
        End Set
    End Property
    Public Property codigoJefeDepto_ As Integer
        Get
            Return codigoJefeDepto
        End Get
        Set(value As Integer)
            codigoJefeDepto = value
        End Set
    End Property
    Public Property fecha_ As System.Nullable(Of Date)
        Get
            Return fecha
        End Get
        Set(value As System.Nullable(Of Date))
            fecha = value
        End Set
    End Property

    Public Property cubrira_ As String
        Get
            Return cubrira
        End Get
        Set(value As String)
            cubrira = value
        End Set
    End Property
    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property observaciones_ As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property
    Public Property motivoInasistencia_ As String
        Get
            Return motivoInasistencia
        End Get
        Set(value As String)
            motivoInasistencia = value
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
    Public Property codigoSupervisor_ As Integer
        Get
            Return codigoSupervisor
        End Get
        Set(value As Integer)
            codigoSupervisor = value
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


    Public Function RegistrarNuevoVacaciones() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarVacaciones"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoEmpleado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaInasistencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaInasistencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "motivoInasistencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = motivoInasistencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "notifico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = notifico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cubrira" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cubrira_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observaciones_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSupervisor" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSupervisor_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoJefeDepto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoJefeDepto_
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

    Public Function ModificarVacaciones() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarVacaciones"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoEmpleado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaInasistencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaInasistencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "motivoInasistencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = motivoInasistencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "notifico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = notifico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cubrira" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cubrira_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = observaciones_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSupervisor" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSupervisor_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoJefeDepto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoJefeDepto_
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


    Public Function BuscarVacacionesNombre() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarVacacionesNombre"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_
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

    Public Function BuscarVacaciones() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarVacaciones"
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

    Public Function SeleccionarVacaciones() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarVacaciones", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

End Class
