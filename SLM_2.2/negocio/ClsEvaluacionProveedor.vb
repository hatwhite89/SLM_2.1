Imports System.Data.SqlClient

Public Class ClsEvaluacionProveedor
    Dim aencuesta1, aencuesta2, aencuesta3, aencuentas4, aencuesta5 As Integer
    Dim bencuesta1, bencuesta2, bencuesta3, bencuentas4, bencuesta5 As Integer
    Dim cencuesta1, cencuesta2, cencuesta3, cencuentas4, cencuesta5 As Integer
    Dim dencuesta1, dencuesta2, dencuesta3, dencuentas4, dencuesta5 As Integer
    Dim eencuesta1, eencuesta2, eencuesta3, eencuentas4, eencuesta5 As Integer
    Dim id_oc As Integer

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

        Using da As New SqlDataAdapter("select p.nombreProveedor from OrdenDeCompra o, Proveedor p where o.id_proveedor = p.codProveedor and o.id_oc ='" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function validarOrdenCompra(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from EvaluacionProveedor where id_oc ='" + cod + "'", cn)
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
        sqlcom.CommandText = "select  codProveedor from Proveedor where nombreProveedor like '%" + cod + "'"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteScalar
    End Function

    Public Function calcularEvaluacion(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select e.id_oc,sum(e.a1+e.a2+e.a3+e.a4+e.a5)as encuesta1, sum(e.b1+e.b2+e.b3+e.b4+e.b5)as encuesta2,sum(e.c1+e.c2+e.c3+e.c4+e.c5)as encuesta3,sum(e.d1+e.d2+e.d3+e.d4+e.d5)as encuesta4,sum(e.e1+e.e2+e.e3+e.e4+e.e5)as encuesta5,
(cast(sum(e.a1+e.a2+e.a3+e.a4+e.a5)+sum(e.b1+e.b2+e.b3+e.b4+e.b5)+sum(e.c1+e.c2+e.c3+e.c4+e.c5)+sum(e.d1+e.d2+e.d3+e.d4+e.d5)+sum(e.e1+e.e2+e.e3+e.e4+e.e5) as float)/25)*100 as promedio from EvaluacionProveedor e, OrdenDeCompra o
where   e.id_oc =o.id_oc and
o.id_proveedor =
'" + cod + "' group by e.id_oc", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
