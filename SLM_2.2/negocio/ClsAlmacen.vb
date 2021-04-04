Imports System.Data.SqlClient

Public Class ClsAlmacen
    Dim id As Integer
    Dim nombre, descripcion, usuario, nombre_encargado As String
    'constructor
    Public Sub New()

    End Sub

    Public Property IdAlmacen As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NombreAlmacen As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property DescripcionAlmacen As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property Nombre_encargado1 As String
        Get
            Return nombre_encargado
        End Get
        Set(value As String)
            nombre_encargado = value
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

    Public Function RegistrarAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_almacen" 'nombre del almacen 
        sqlpar.Value = NombreAlmacen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_usuario" 'nombre del almacen 
        sqlpar.Value = Nombre_encargado1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario" 'nombre del almacen 
        sqlpar.Value = Usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'descripcion del almacen
        sqlpar.Value = DescripcionAlmacen
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

    Public Function ActualizarAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmActualizarAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_almacen" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdAlmacen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_almacen" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = NombreAlmacen
        sqlcom.Parameters.Add(sqlpar)
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre_usuario" 'nombre del almacen 
        sqlpar.Value = Nombre_encargado1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario" 'nombre del almacen 
        sqlpar.Value = Usuario1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = DescripcionAlmacen
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


    Public Function ListarAlmacenEntrada() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select id_almacen,nombre_almacen,descripcion,nombre_encargado,usuario from Almacen where estado <>1", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function RecuperarAlmacenes() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "select id_almacen,nombre_almacen,descripcion,nombre_encargado,usuario from Almacen where estado <>1"
        sqlcom.Connection = New ClsConnection().getConexion

        Return sqlcom.ExecuteReader
        sqlcom.Connection.Close()
    End Function

    Public Function BajarAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slm_DarBajaAlmacen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_almacen" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = IdAlmacen
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

    'reportes
    Public Function CargarReportes() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from ReporteAlmacen", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
