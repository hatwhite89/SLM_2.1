Imports System.Data.SqlClient
Public Class ClsProveedor

    Dim codProveedor, codCate, codTermPago, codCuenta As Integer
    Dim codBreve, nombreProveedor, telefono, email, direccion, sitioweb, idTributario As String

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::

    'Codigo Proveedor
    Public Property Cod_Proveedor As Integer
        Get
            Return codProveedor
        End Get
        Set(value As Integer)
            codProveedor = value
        End Set
    End Property

    'Codigo Categoria
    Public Property Cod_Cate As Integer
        Get
            Return codCate
        End Get
        Set(value As Integer)
            codCate = value
        End Set
    End Property
    'Codigo TerminoPago
    Public Property cod_TermPago As Integer
        Get
            Return codTermPago
        End Get
        Set(value As Integer)
            codTermPago = value
        End Set
    End Property

    'Codigo Cuenta
    Public Property cod_Cuenta As Integer
        Get
            Return codCuenta
        End Get
        Set(value As Integer)
            codCuenta = value
        End Set
    End Property

    'codBreve
    Public Property Cod_Breve As String
        Get
            Return codBreve
        End Get
        Set(value As String)
            codBreve = value
        End Set
    End Property

    'Id Tributario
    Public Property Id_Tributario As String
        Get
            Return idTributario
        End Get
        Set(value As String)
            idTributario = value
        End Set
    End Property

    'nombreProveedor
    Public Property Nombre_Proveedor As String
        Get
            Return nombreProveedor
        End Get
        Set(value As String)
            nombreProveedor = value
        End Set
    End Property

    'telefono
    Public Property Telefo_no As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    'email
    Public Property Emai_l As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    'direccion
    Public Property Direcci_on As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'Sitio Web
    Public Property Sitio_Web As String
        Get
            Return sitioweb
        End Get
        Set(value As String)
            sitioweb = value
        End Set
    End Property

    ':::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::

    'Guardar nuevo registro de Proveedor
    Public Function registrarNuevoProveedor() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarProveedor"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Cod_Breve
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "idTributario"
        sqlpar.Value = Id_Tributario
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono"
        sqlpar.Value = Telefo_no
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "email"
        sqlpar.Value = Emai_l
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion"
        sqlpar.Value = Direcci_on
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sitioweb"
        sqlpar.Value = Sitio_Web
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCate"
        sqlpar.Value = Cod_Cate
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codTermPago"
        sqlpar.Value = cod_TermPago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCuenta"
        sqlpar.Value = cod_Cuenta
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

        par_sal = sqlcom.Parameters("Salida").Value

        Return par_sal

    End Function

    'Modificar una registro de proveedor
    Public Function ModificarProveedor() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarProveedor"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codProveedor"
        sqlpar.Value = Cod_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Cod_Breve
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "idTributario"
        sqlpar.Value = Id_Tributario
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono"
        sqlpar.Value = Telefo_no
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "email"
        sqlpar.Value = Emai_l
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion"
        sqlpar.Value = Direcci_on
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sitioweb"
        sqlpar.Value = Sitio_Web
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCate"
        sqlpar.Value = Cod_Cate
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codTermPago"
        sqlpar.Value = cod_TermPago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCuenta"
        sqlpar.Value = cod_Cuenta
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

    'Listar Proveedores
    Public Function listarProveedores() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarProveedor", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Buscar Proveedor por nombre
    Public Function buscarProveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarProveedor"
            cmd.Parameters.Add("@nombreProveedor", SqlDbType.VarChar).Value = Nombre_Proveedor
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Capturar nombre de proveedor por codigo
    Public Function capturarNombreProveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmCapturarNombreProveedor"
            cmd.Parameters.Add("@codProveedor", SqlDbType.Int).Value = Cod_Proveedor
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Obtener el codigo del Proveedor
    Public Function obtenerProveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmCapturarProveedor", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    'Listar Proveedores oc
    Public Function listarProveedoresOC() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarProveedor", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function listarProveedoresOC2(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select top 1 * from Proveedor  p, TerminoPago t where p.codTermPago =t.codigo and p.nombreProveedor like '%" + cod + "%'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function listarProveedoresJC(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from Proveedor  where codProveedor =" + cod, cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function


    'Capturar nombre de proveedor por codigo
    Public Function cuentaProveedor() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmCuentaProveedores"
            cmd.Parameters.Add("@codProveedor", SqlDbType.Int).Value = Cod_Proveedor
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function


End Class
