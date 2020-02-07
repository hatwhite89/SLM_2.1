Imports System.Data.SqlClient

Public Class ClsCAI
    Dim codigo, codigoMaquinaLocal As Integer
    Dim CAI, serie, desde, hasta As String
    Dim desdeFecha, hastaFecha As Date
    Dim estado As Boolean
    'Constructor
    Public Sub New()

    End Sub
    'get y set
    Public Property Codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Public Property codigoMaquinaLocal_ As Integer
        Get
            Return codigoMaquinaLocal
        End Get
        Set(value As Integer)
            codigoMaquinaLocal = value
        End Set
    End Property
    Public Property CAI_ As String
        Get
            Return CAI
        End Get
        Set(value As String)
            CAI = value
        End Set
    End Property
    Public Property serie_ As String
        Get
            Return serie
        End Get
        Set(value As String)
            serie = value
        End Set
    End Property
    Public Property desde_ As String
        Get
            Return desde
        End Get
        Set(value As String)
            desde = value
        End Set
    End Property
    Public Property hasta_ As String
        Get
            Return hasta
        End Get
        Set(value As String)
            hasta = value
        End Set
    End Property
    Public Property estado_ As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property
    Public Property desdeFecha_ As Date
        Get
            Return desdeFecha
        End Get
        Set(value As Date)
            desdeFecha = value
        End Set
    End Property
    Public Property hastaFecha_ As Date
        Get
            Return hastaFecha
        End Get
        Set(value As Date)
            hastaFecha = value
        End Set
    End Property
    Public Function RegistrarNuevoCAI() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarCAI"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "CAI" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CAI_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "desdeFecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = desdeFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "hastaFecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = hastaFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "serie" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = serie_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "desde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = desde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "hasta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = hasta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoMaquinaLocal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoMaquinaLocal_
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

    Public Function ModificarCAI() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarCAI"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "CAI" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = CAI_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "desdeFecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = desdeFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "hastaFecha" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = hastaFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "serie" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = serie_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "desde" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = desde_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "hasta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = hasta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoMaquinaLocal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoMaquinaLocal_
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

    Public Function BuscarCAI() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarCAI"
            cmd.Parameters.Add("@codigoMaquinaLocal", SqlDbType.Int).Value = codigoMaquinaLocal_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function CapturarCAI() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmCapturarCAI", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using

    End Function
    Public Function SeleccionarCAI() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarCAI", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using

    End Function

    ':::::::::::::::::::::::::::::::::::::::: Procedimientos de Notificación ::::::::::::::::::::::::::::::::::::::::

    Public Function ContarFacturas() As DataTable
        Try
            Dim objCon As New ClsConnection
            Dim cn As New SqlConnection
            cn = objCon.getConexion

            Using da As New SqlDataAdapter("M_slmValidacionCAICantidad", cn)
                Dim dt As New DataTable
                da.Fill(dt)
                objCon.cerrarConexion()
                Return dt
            End Using

        Catch ex As Exception

        End Try

    End Function

    Public Function DiaVencimiento() As DataTable
        Try

            Dim objCon As New ClsConnection
            Dim cn As New SqlConnection
            cn = objCon.getConexion

            Using da As New SqlDataAdapter("M_slmValidacionCAIDias", cn)
                Dim dt As New DataTable
                da.Fill(dt)
                objCon.cerrarConexion()
                Return dt
            End Using


        Catch ex As Exception

        End Try

    End Function
End Class
