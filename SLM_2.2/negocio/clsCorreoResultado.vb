Imports System.Data.SqlClient

Public Class clsCorreoResultado
    Dim correoSalida, pass, puerto, host As String
    Dim sslOK As Boolean
    Public Sub New()

    End Sub

    Public Property CorreoSalida1 As String
        Get
            Return correoSalida
        End Get
        Set(value As String)
            correoSalida = value
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

    Public Property Puerto1 As String
        Get
            Return puerto
        End Get
        Set(value As String)
            puerto = value
        End Set
    End Property

    Public Property Host1 As String
        Get
            Return host
        End Get
        Set(value As String)
            host = value
        End Set
    End Property

    Public Property SslOK1 As Boolean
        Get
            Return sslOK
        End Get
        Set(value As Boolean)
            sslOK = value
        End Set
    End Property

    Public Function RegistrarAlmacen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmConfiguracionCorreo"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo"
        sqlpar.Value = CorreoSalida1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "host"
        sqlpar.Value = Host1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pass"
        sqlpar.Value = Pass1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "puerto"
        sqlpar.Value = Puerto1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ssl"
        sqlpar.Value = SslOK1
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

    Public Function BuscarCorreo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select * from correoResultado", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using

    End Function
End Class
