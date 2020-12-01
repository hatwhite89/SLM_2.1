Imports System.Data.SqlClient

Public Class ClsEvaluacionProveedor
    Dim aencuesta1, aencuesta2, aencuesta3, aencuentas4, aencuesta5 As Integer
    Dim bencuesta1, bencuesta2, bencuesta3, bencuentas4, bencuesta5 As Integer
    Dim cencuesta1, cencuesta2, cencuesta3, cencuentas4, cencuesta5 As Integer
    Dim dencuesta1, dencuesta2, dencuesta3, dencuentas4, dencuesta5 As Integer
    Dim eencuesta1, eencuesta2, eencuesta3, eencuentas4, eencuesta5 As Integer
    Dim id_oc, id_proveedor As Integer

    'constructor
    Public Sub New()

    End Sub

    Public Property Aencuesta11 As Integer
        Get
            Return aencuesta1
        End Get
        Set(value As Integer)
            aencuesta1 = value
        End Set
    End Property

    Public Property Aencuesta21 As Integer
        Get
            Return aencuesta2
        End Get
        Set(value As Integer)
            aencuesta2 = value
        End Set
    End Property

    Public Property Aencuesta31 As Integer
        Get
            Return aencuesta3
        End Get
        Set(value As Integer)
            aencuesta3 = value
        End Set
    End Property

    Public Property Aencuentas41 As Integer
        Get
            Return aencuentas4
        End Get
        Set(value As Integer)
            aencuentas4 = value
        End Set
    End Property

    Public Property Aencuesta51 As Integer
        Get
            Return aencuesta5
        End Get
        Set(value As Integer)
            aencuesta5 = value
        End Set
    End Property

    Public Property Bencuesta11 As Integer
        Get
            Return bencuesta1
        End Get
        Set(value As Integer)
            bencuesta1 = value
        End Set
    End Property

    Public Property Bencuesta21 As Integer
        Get
            Return bencuesta2
        End Get
        Set(value As Integer)
            bencuesta2 = value
        End Set
    End Property

    Public Property Bencuesta31 As Integer
        Get
            Return bencuesta3
        End Get
        Set(value As Integer)
            bencuesta3 = value
        End Set
    End Property

    Public Property Bencuentas41 As Integer
        Get
            Return bencuentas4
        End Get
        Set(value As Integer)
            bencuentas4 = value
        End Set
    End Property

    Public Property Bencuesta51 As Integer
        Get
            Return bencuesta5
        End Get
        Set(value As Integer)
            bencuesta5 = value
        End Set
    End Property

    Public Property Cencuesta11 As Integer
        Get
            Return cencuesta1
        End Get
        Set(value As Integer)
            cencuesta1 = value
        End Set
    End Property

    Public Property Cencuesta21 As Integer
        Get
            Return cencuesta2
        End Get
        Set(value As Integer)
            cencuesta2 = value
        End Set
    End Property

    Public Property Cencuesta31 As Integer
        Get
            Return cencuesta3
        End Get
        Set(value As Integer)
            cencuesta3 = value
        End Set
    End Property

    Public Property Cencuentas41 As Integer
        Get
            Return cencuentas4
        End Get
        Set(value As Integer)
            cencuentas4 = value
        End Set
    End Property

    Public Property Cencuesta51 As Integer
        Get
            Return cencuesta5
        End Get
        Set(value As Integer)
            cencuesta5 = value
        End Set
    End Property

    Public Property Dencuesta11 As Integer
        Get
            Return dencuesta1
        End Get
        Set(value As Integer)
            dencuesta1 = value
        End Set
    End Property

    Public Property Dencuesta21 As Integer
        Get
            Return dencuesta2
        End Get
        Set(value As Integer)
            dencuesta2 = value
        End Set
    End Property

    Public Property Dencuesta31 As Integer
        Get
            Return dencuesta3
        End Get
        Set(value As Integer)
            dencuesta3 = value
        End Set
    End Property

    Public Property Dencuentas41 As Integer
        Get
            Return dencuentas4
        End Get
        Set(value As Integer)
            dencuentas4 = value
        End Set
    End Property

    Public Property Dencuesta51 As Integer
        Get
            Return dencuesta5
        End Get
        Set(value As Integer)
            dencuesta5 = value
        End Set
    End Property

    Public Property Eencuesta11 As Integer
        Get
            Return eencuesta1
        End Get
        Set(value As Integer)
            eencuesta1 = value
        End Set
    End Property

    Public Property Eencuesta21 As Integer
        Get
            Return eencuesta2
        End Get
        Set(value As Integer)
            eencuesta2 = value
        End Set
    End Property

    Public Property Eencuesta31 As Integer
        Get
            Return eencuesta3
        End Get
        Set(value As Integer)
            eencuesta3 = value
        End Set
    End Property

    Public Property Eencuentas41 As Integer
        Get
            Return eencuentas4
        End Get
        Set(value As Integer)
            eencuentas4 = value
        End Set
    End Property

    Public Property Eencuesta51 As Integer
        Get
            Return eencuesta5
        End Get
        Set(value As Integer)
            eencuesta5 = value
        End Set
    End Property

    Public Property Id_oc1 As Integer
        Get
            Return id_oc
        End Get
        Set(value As Integer)
            id_oc = value
        End Set
    End Property

    Public Property Id_proveedor1 As Integer
        Get
            Return id_proveedor
        End Get
        Set(value As Integer)
            id_proveedor = value
        End Set
    End Property

    Public Function RegistrarEvaluacion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarEvaluacion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc"
        sqlpar.Value = Id_oc1
        sqlcom.Parameters.Add(sqlpar)
        'estos son los a
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "a1"
        sqlpar.Value = Aencuesta11
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "a2"
        sqlpar.Value = Aencuesta21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "a3"
        sqlpar.Value = Aencuesta31
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "a4"
        sqlpar.Value = Aencuentas41
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "a5"
        sqlpar.Value = Aencuesta51
        sqlcom.Parameters.Add(sqlpar)

        'estos son los B

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "b1"
        sqlpar.Value = Bencuesta11
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "b2"
        sqlpar.Value = Bencuesta21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "b3"
        sqlpar.Value = Bencuesta31
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "b4"
        sqlpar.Value = Bencuentas41
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "b5"
        sqlpar.Value = Bencuesta51
        sqlcom.Parameters.Add(sqlpar)

        'estas son las c

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "c1"
        sqlpar.Value = Cencuesta11
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "c2"
        sqlpar.Value = Cencuesta21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "c3"
        sqlpar.Value = Cencuesta31
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "c4"
        sqlpar.Value = Cencuentas41
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "c5"
        sqlpar.Value = Cencuesta51
        sqlcom.Parameters.Add(sqlpar)
        'aqui van los d

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "d1"
        sqlpar.Value = Dencuesta11
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "d2"
        sqlpar.Value = Dencuesta21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "d3"
        sqlpar.Value = Dencuesta31
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "d4"
        sqlpar.Value = Dencuentas41
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "d5"
        sqlpar.Value = Dencuesta51
        sqlcom.Parameters.Add(sqlpar)

        'aqui van los e

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "e1"
        sqlpar.Value = Eencuesta11
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "e2"
        sqlpar.Value = Eencuesta21
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "e3"
        sqlpar.Value = Eencuesta31
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "e4"
        sqlpar.Value = Eencuentas41
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "e5"
        sqlpar.Value = Eencuesta51
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

    Public Function listarProveedoresOC2(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombreProveedor,p.codProveedor from OrdenDeCompra o, Proveedor p where o.id_proveedor = p.codProveedor and o.id_oc ='" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function listarProveedoresEvaluacionNormal(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from calificacionProveedorNormal where id_proveedor ='" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function validarOrdenCompra(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select top 1 * from DetalleTablaDeCalificacionServicio where id_oc ='" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function RecuperarCodigoProveedor(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from Proveedor where nombreProveedor like ='%" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function RecuperarCodigoProveedor2(ByVal cod As String) As String
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select top 1  codProveedor from Proveedor where nombreProveedor like '%" + cod + "'"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteScalar
    End Function

    Public Function calcularEvaluacion(ByVal cod As String, ByVal inicio As Date, ByVal fin As Date) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select (sum(c.nota)/count(*))*10 as calificacion,d.nombre,p.nombreProveedor,c.id_oc from DetalleTablaDeCalificacionServicio c, Proveedor p, Departamento d
where nota >0 and p.codProveedor = c.id_proveedor and c.id_departamento = d.codigo and p.codProveedor ='" + cod + "' and fecha between '" + inicio.ToString("yyyyMMdd") + "' and '" + fin.ToString("yyyyMMdd") + "'
group by d.nombre,p.nombreProveedor,c.id_oc", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function listarProveedoresOC2EvaluacionReacitvos(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombreProveedor,o.fecha_elaboracion from OrdenDeCompra o, Proveedor p where o.id_proveedor = p.codProveedor and o.id_oc ='" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
