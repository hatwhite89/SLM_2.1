Imports System.Data.SqlClient

Public Class ClsRequisicion
    Dim cod_requi, cod_usuario, usuario_aprobo, usuario_rechazo As Integer
    Dim fecha As DateTime
    Dim usuario, descripcion, tipo_compra, estado, comentario_rechazo As String
    Public Sub New()

    End Sub

    Public Property Cod_requi1 As Integer
        Get
            Return cod_requi
        End Get
        Set(value As Integer)
            cod_requi = value
        End Set
    End Property

    Public Property Cod_usuario1 As Integer
        Get
            Return cod_usuario
        End Get
        Set(value As Integer)
            cod_usuario = value
        End Set
    End Property

    Public Property Usuario_aprobo1 As Integer
        Get
            Return usuario_aprobo
        End Get
        Set(value As Integer)
            usuario_aprobo = value
        End Set
    End Property

    Public Property Usuario_rechazo1 As Integer
        Get
            Return usuario_rechazo
        End Get
        Set(value As Integer)
            usuario_rechazo = value
        End Set
    End Property

    Public Property Comentario_rechazo1 As String
        Get
            Return comentario_rechazo
        End Get
        Set(value As String)
            comentario_rechazo = value
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

    Public Property Usuario1 As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
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

    Public Property Tipo_compra1 As String
        Get
            Return tipo_compra
        End Get
        Set(value As String)
            tipo_compra = value
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

    Public Function RegistrarRequisicion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_RegistrarRequisicion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_usuario"
        sqlpar.Value = Cod_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipo_compra"
        sqlpar.Value = Tipo_compra1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion1
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

    Public Function RecuperarRequisicionFechas(ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select cod_requisicion, estado,tipo_compra,fecha_solicitud,descripcion from Requisicion where cod_usuario = '" + codigo_usuario + "' and fecha_solicitud between  '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "' ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarRequisicionCodigo(ByVal codigo As String) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from Requisicion where cod_requisicion = '" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarRequisicion() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select cod_requisicion,tipo_compra,fecha_solicitud,descripcion from Requisicion where estado = 'Creado'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function AprobarRequisicion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_AprobarRequisicion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_requi"
        sqlpar.Value = Cod_requi1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentario_rechazo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_usuario_aprobo"
        sqlpar.Value = Usuario_aprobo1
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

    Public Function RechazarRequisicion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_RechazarRequisicion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_requi"
        sqlpar.Value = Cod_requi1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentario_rechazo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_usuario_aprobo"
        sqlpar.Value = Usuario_aprobo1
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

    Public Function RecuperarRequisicionFechasAutorizaciones(ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select cod_requisicion, estado,tipo_compra,fecha_solicitud,descripcion from Requisicion where estado <> 'Creado'  and fecha_autorizacion between  '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "' ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class
