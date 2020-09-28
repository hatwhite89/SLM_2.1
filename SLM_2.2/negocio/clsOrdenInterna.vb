Imports System.Data.SqlClient

Public Class clsOrdenInterna
    'orden interna
    Dim id_oi, id_departamento, id_solicitante, id_entrega As Integer
    Dim fecha, fecha_entrega As Date
    Dim estado As String

    Public Property Id_oi1 As Integer
        Get
            Return id_oi
        End Get
        Set(value As Integer)
            id_oi = value
        End Set
    End Property

    Public Property Id_departamento1 As Integer
        Get
            Return id_departamento
        End Get
        Set(value As Integer)
            id_departamento = value
        End Set
    End Property

    Public Property Id_solicitante1 As Integer
        Get
            Return id_solicitante
        End Get
        Set(value As Integer)
            id_solicitante = value
        End Set
    End Property

    Public Property Id_entrega1 As Integer
        Get
            Return id_entrega
        End Get
        Set(value As Integer)
            id_entrega = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property Fecha_entrega1 As Date
        Get
            Return fecha_entrega
        End Get
        Set(value As Date)
            fecha_entrega = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Function RegistrarOrdenInterna() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarOrdenInterna"


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha"
        sqlpar.Value = Fecha1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_entrega"
        sqlpar.Value = Fecha_entrega1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_departamento"
        sqlpar.Value = Id_departamento1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_usuario"
        sqlpar.Value = Id_solicitante1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_sede"
        sqlpar.Value = Id_entrega1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_estado"
        sqlpar.Value = Estado1
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


    Public Function CrearrOrdenInterna() As Integer
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "exec E_slm_CrearOI"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteScalar
    End Function
    Public Function ActualizarOrdenInterna() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarOrdenInterna"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_io"
        sqlpar.Value = Id_oi1
        sqlcom.Parameters.Add(sqlpar)




        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_entrega"
        sqlpar.Value = Fecha_entrega1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_departamento"
        sqlpar.Value = Id_departamento1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_usuario"
        sqlpar.Value = Id_solicitante1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_sede"
        sqlpar.Value = Id_entrega1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_estado"
        sqlpar.Value = Estado1
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

    Public Function MisSolicitudesFecha(ByVal inicio As Date, ByVal fin As Date, ByVal user As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select o.id_oi,o.fecha,o.fecha_entrega,u.usuario, o.estado  from OrdenInterna o, Usuario u where u.cod_usuario =o.id_usuario and o.fecha between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "' and o.id_usuario='" + user + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function TodasSolicitudes() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from OrdenInterna where estado <> 'cerrado'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function listarDetallesMisSolicitudes(ByVal id As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select *  from DetalleOrdenInterna where id_oi = '" + id + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ActualizarEstadoOrdenInterna() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarOIEstado"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oi"
        sqlpar.Value = Id_oi1
        sqlcom.Parameters.Add(sqlpar)



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estado1
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

    Public Function SolicitudesFechaCerradas(ByVal inicio As Date, ByVal fin As Date) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from OrdenInterna where estado = 'cerrado'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
