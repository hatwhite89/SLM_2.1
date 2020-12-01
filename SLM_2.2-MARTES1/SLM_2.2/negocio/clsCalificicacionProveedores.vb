Imports System.Data.SqlClient

Public Class clsCalificicacionProveedores
    Dim id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12c, id13c, id_proveedor, id_oc, id_departamento, id_usuario As Integer
    Public Sub New()

    End Sub

    Public Property Id12 As Integer
        Get
            Return id1
        End Get
        Set(value As Integer)
            id1 = value
        End Set
    End Property

    Public Property Id21 As Integer
        Get
            Return id2
        End Get
        Set(value As Integer)
            id2 = value
        End Set
    End Property

    Public Property Id31 As Integer
        Get
            Return id3
        End Get
        Set(value As Integer)
            id3 = value
        End Set
    End Property

    Public Property Id51 As Integer
        Get
            Return id5
        End Get
        Set(value As Integer)
            id5 = value
        End Set
    End Property

    Public Property Id61 As Integer
        Get
            Return id6
        End Get
        Set(value As Integer)
            id6 = value
        End Set
    End Property


    Public Property Id71 As Integer
        Get
            Return id7
        End Get
        Set(value As Integer)
            id7 = value
        End Set
    End Property

    Public Property Id81 As Integer
        Get
            Return id8
        End Get
        Set(value As Integer)
            id8 = value
        End Set
    End Property

    Public Property Id91 As Integer
        Get
            Return id9
        End Get
        Set(value As Integer)
            id9 = value
        End Set
    End Property

    Public Property Id101 As Integer
        Get
            Return id10
        End Get
        Set(value As Integer)
            id10 = value
        End Set
    End Property

    Public Property Id111 As Integer
        Get
            Return id11
        End Get
        Set(value As Integer)
            id11 = value
        End Set
    End Property

    Public Property Id41 As Integer
        Get
            Return id4
        End Get
        Set(value As Integer)
            id4 = value
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

    Public Property Id_oc1 As Integer
        Get
            Return id_oc
        End Get
        Set(value As Integer)
            id_oc = value
        End Set
    End Property



    Public Property Id_departamento2 As Integer
        Get
            Return id_departamento
        End Get
        Set(value As Integer)
            id_departamento = value
        End Set
    End Property

    Public Property Id_usuario1 As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            id_usuario = value
        End Set
    End Property

    Public Property Id12c1 As Integer
        Get
            Return id12c
        End Get
        Set(value As Integer)
            id12c = value
        End Set
    End Property

    Public Property Id13c1 As Integer
        Get
            Return id13c
        End Get
        Set(value As Integer)
            id13c = value
        End Set
    End Property

    Public Function RegistraCalificacion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarCalificacionServicio"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id1" 'nombre del almacen 
        sqlpar.Value = Id12
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id2" 'nombre del almacen 
        sqlpar.Value = Id21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id3" 'nombre del almacen 
        sqlpar.Value = Id31
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id4" 'nombre del almacen 
        sqlpar.Value = Id41
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id5" 'nombre del almacen 
        sqlpar.Value = Id51
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id6" 'nombre del almacen 
        sqlpar.Value = Id61
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id7" 'nombre del almacen 
        sqlpar.Value = Id71
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id8" 'nombre del almacen 
        sqlpar.Value = Id81
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id9" 'nombre del almacen 
        sqlpar.Value = Id91
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id10" 'nombre del almacen 
        sqlpar.Value = Id101
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id11" 'nombre del almacen 
        sqlpar.Value = Id111
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_proveedor" 'nombre del almacen 
        sqlpar.Value = Id_proveedor1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_oc" 'nombre del almacen 
        sqlpar.Value = Id_oc1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_usuario" 'nombre del almacen 
        sqlpar.Value = Id_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_departamento" 'nombre del almacen 
        sqlpar.Value = Id_departamento2
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
    Public Function RegistraCalificacionProveedor() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_InsertarCalificacionProveedorNormal"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal1" 'nombre del almacen 
        sqlpar.Value = Id12
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal2" 'nombre del almacen 
        sqlpar.Value = Id21
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal3" 'nombre del almacen 
        sqlpar.Value = Id31
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal4" 'nombre del almacen 
        sqlpar.Value = Id41
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal5" 'nombre del almacen 
        sqlpar.Value = Id51
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal6" 'nombre del almacen 
        sqlpar.Value = Id61
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal7" 'nombre del almacen 
        sqlpar.Value = Id71
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal8" 'nombre del almacen 
        sqlpar.Value = Id81
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal9" 'nombre del almacen 
        sqlpar.Value = Id91
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal10" 'nombre del almacen 
        sqlpar.Value = Id101
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal11" 'nombre del almacen 
        sqlpar.Value = Id111
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_proveedor" 'nombre del almacen 
        sqlpar.Value = Id_proveedor1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal12" 'nombre del almacen 
        sqlpar.Value = Id12c1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cal13" 'nombre del almacen 
        sqlpar.Value = Id13c1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_usuario" 'nombre del almacen 
        sqlpar.Value = Id_usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_departamento_califica" 'nombre del almacen 
        sqlpar.Value = Id_departamento2
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

    Public Function EliminarCalificacionProveedor() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_EliminarCalificacionProveedorNormal"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_proveedor"
        sqlpar.Value = Id_proveedor1
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

    Public Function ListarProveedoresCalificados() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select p.nombreProveedor, (cast(((c.cal1+c.cal2+c.cal3+c.cal4+c.cal5+c.cal6+c.cal7+c.cal8+c.cal9+c.cal10+c.cal11+c.cal12+c.cal3)) as float )/130 * 100 ) as promedio,d.nombre from calificacionProveedorNormal c, Proveedor p, Departamento d
where c.id_proveedor = p.codProveedor and c.id_departamento_califica = d.codigo ", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
