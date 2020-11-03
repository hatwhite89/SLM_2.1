Imports System.Data.SqlClient

Public Class ClsOrdenDeCompra
    Dim id, id_forma_pago, id_proveedor As Integer

    Dim fecha_elaboracion As Date

    Dim condicion, usuario_consignado, usuario_solicito, usuario_autorizo, departamento_solicita, departamento_autoriza, observaciones, obser_autorizacion, autorizacion_estado As String
    Dim estado As Boolean

    Public Property IdOrdenCompra As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property IdFormaPago As Integer
        Get
            Return id_forma_pago
        End Get
        Set(value As Integer)
            id_forma_pago = value
        End Set
    End Property

    Public Property IdProveedor As Integer
        Get
            Return id_proveedor
        End Get
        Set(value As Integer)
            id_proveedor = value
        End Set
    End Property

    Public Property FechaElaboracion As Date
        Get
            Return fecha_elaboracion
        End Get
        Set(value As Date)
            fecha_elaboracion = value
        End Set
    End Property

    Public Property Condiciones As String
        Get
            Return condicion
        End Get
        Set(value As String)
            condicion = value
        End Set
    End Property

    Public Property UsuarioConsignado As String
        Get
            Return usuario_consignado
        End Get
        Set(value As String)
            usuario_consignado = value
        End Set
    End Property

    Public Property UsuarioSolicito As String
        Get
            Return usuario_solicito
        End Get
        Set(value As String)
            usuario_solicito = value
        End Set
    End Property

    Public Property UsuarioAutorizo As String
        Get
            Return usuario_autorizo
        End Get
        Set(value As String)
            usuario_autorizo = value
        End Set
    End Property

    Public Property DepartamentSolicita As String
        Get
            Return departamento_solicita
        End Get
        Set(value As String)
            departamento_solicita = value
        End Set
    End Property

    Public Property DepartamentoAutoriza As String
        Get
            Return departamento_autoriza
        End Get
        Set(value As String)
            departamento_autoriza = value
        End Set
    End Property

    Public Property ObservacionesOC As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property

    Public Property EstadoOC As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    Public Property Obser_autorizacion1 As String
        Get
            Return obser_autorizacion
        End Get
        Set(value As String)
            obser_autorizacion = value
        End Set
    End Property

    Public Property Autorizacion_estado1 As String
        Get
            Return autorizacion_estado
        End Get
        Set(value As String)
            autorizacion_estado = value
        End Set
    End Property

    Public Function CrearrOrdenDeCompra() As Integer
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "exec E_slmCrearOC"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteScalar
    End Function


    Public Function RecuperarOC() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.autorizacion <> 'Anulada' and oc.autorizacion <> 'Cerrada'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOCConParametro(ByVal codigo As String) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from OrdenDeCompra where id_oc ='" + codigo + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOCParaAutorizar() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and  oc.autorizacion <> 'Autorizada' and oc.autorizacion <> 'Anulada' and oc.autorizacion <> 'Cerrada'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOCRechazadas(ByVal usuario As String, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.autorizacion ='Rechazada'  and oc.usuario_autorizo ='" + usuario + "' and oc.fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


    Public Function RecuperarOCAutorizadasUsuario(ByVal usuario As String, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from OrdenDeCompra where autorizacion = 'Autorizada' and usuario_autorizo ='" + usuario + "' and fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOCPrFechas(ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "' ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


    Public Function ActualizarOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_ActualizarOC"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOrdenCompra
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "forma_pago" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdFormaPago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_proveedor" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdProveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_elaboracion" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = FechaElaboracion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "condicion" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Condiciones
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_consignado" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = UsuarioConsignado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_solicito" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = UsuarioSolicito
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_autorizo" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = UsuarioAutorizo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "departamento_solicita" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = DepartamentSolicita
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "departamento_autoriza" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = DepartamentoAutoriza
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = ObservacionesOC
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = EstadoOC
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


    Public Function AutorizarOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_AutorizarOC"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOrdenCompra
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_autorizo" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = UsuarioAutorizo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones_autorizacion" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Obser_autorizacion1
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
    Public Function REchazarOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_REchazarOC"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOrdenCompra
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario_autorizo" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = UsuarioAutorizo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "observaciones_autorizacion" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Obser_autorizacion1
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

    Public Function AnularOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_AnularOC"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOrdenCompra
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
    Public Function CerrarOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_CerrarOC"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOrdenCompra
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
    Public Function AbrirOC() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_AbrirOC"



        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdOrdenCompra
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

    Public Function RecuperarOCAnuladas(ByVal usuario As String, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.autorizacion ='Anulada'  and oc.usuario_autorizo ='" + usuario + "' and oc.fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOAutorizo(ByVal usuario As String, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.estado_final,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.estado_final ='Autorizada'  and oc.usuario_autorizo ='" + usuario + "' and oc.fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOCCerrada(ByVal usuario As String, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.autorizacion ='Cerrada'  and oc.usuario_autorizo ='" + usuario + "' and oc.fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function RecuperarOCAbierta(ByVal usuario As String, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select oc.id_oc,p.nombreProveedor,oc.usuario_consignado,oc.usuario_autorizo,oc.autorizacion,oc.fecha_autorizacion,oc.observaciones from OrdenDeCompra oc ,Proveedor p where oc.id_proveedor= p.codProveedor and oc.autorizacion ='Abierta' and oc.fecha_elaboracion between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class
