Imports System.Data.SqlClient

Public Class clsTomaDeMuestra
    Dim factura As String
    Dim usuario, pass, estacion, sucursal As String
    Dim id_sucursal, id_impresora As Integer
    Public Property Factura1 As String
        Get
            Return factura
        End Get
        Set(value As String)
            factura = value
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

    Public Property Pass1 As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property

    Public Property Estacion1 As String
        Get
            Return estacion
        End Get
        Set(value As String)
            estacion = value
        End Set
    End Property

    Public Property Sucursal1 As String
        Get
            Return sucursal
        End Get
        Set(value As String)
            sucursal = value
        End Set
    End Property

    Public Property Id_sucursal1 As Integer
        Get
            Return id_sucursal
        End Get
        Set(value As Integer)
            id_sucursal = value
        End Set
    End Property

    Public Property Id_impresora1 As Integer
        Get
            Return id_impresora
        End Get
        Set(value As Integer)
            id_impresora = value
        End Set
    End Property

    Public Function RecuperarPreguntas(id As Integer) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select pregunta,valor,nota from respuestasTomaMuestra where id_factura = '" + id.ToString + "'"
        sqlcom.Connection = New ClsConnection().getConexion

        Return sqlcom.ExecuteReader

    End Function
    Public Function ListarSucursales() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from Sucursal", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function ListarUsuarios() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select u.id,u.usuario,u.fecha_registro,u.estacion,u.sucursal,i.alias from UsuariosTM u, impresoras i
where i.sucursal = u.id_sucursal", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function RegistrarUsuario() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmRegistrarUsuarioTM"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pass" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Pass1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estacion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Estacion1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_sucusal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Id_sucursal1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sucursal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Sucursal1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "impresora" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Id_impresora1
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

    Public Function EliminarUsuario() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmEliminarUsuarioTM"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Usuario1
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
End Class
