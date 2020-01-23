Imports System.Data.SqlClient

Public Class ClsPromociones
    Dim descripcion, imagen As String
    Dim codigo, contador As Integer
    Dim precio As Double
    Dim img As Byte()
    Dim fechaInicio, fechaFinal As Date

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
    Public Property contador_ As Integer
        Get
            Return contador
        End Get
        Set(value As Integer)
            contador = value
        End Set
    End Property
    Public Property descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property imagen_ As String
        Get
            Return imagen
        End Get
        Set(value As String)
            imagen = value
        End Set
    End Property

    Public Property precio_ As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property
    Public Property img_ As Byte()
        Get
            Return img
        End Get
        Set(value As Byte())
            img = value
        End Set
    End Property
    Public Property fechaInicio_ As Date
        Get
            Return fechaInicio
        End Get
        Set(value As Date)
            fechaInicio = value
        End Set
    End Property
    Public Property fechaFinal_ As Date
        Get
            Return fechaFinal
        End Get
        Set(value As Date)
            fechaFinal = value
        End Set
    End Property

    Public Function RegistrarPromocion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarPromocion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaInicio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaInicio_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFinal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaFinal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "img" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = img_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = precio_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "imagen" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = precio_
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

    Public Function ModificarPromocion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmModificarPromocion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaInicio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaInicio_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFinal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaFinal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "img" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = img_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "precio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = precio_
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

    Public Function SeleccionarPromociones() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarPromociones", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function ListarPromociones() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarPromociones", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

    Public Function capturarCodPromocion() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmCapturarCodPromo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using


    End Function



End Class

