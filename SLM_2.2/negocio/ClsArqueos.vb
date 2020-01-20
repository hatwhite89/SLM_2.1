Imports System.Data.SqlClient

Public Class ClsArqueos
    Dim codigoMaquinaLocal As Integer
    'Constructor
    Public Sub New()

    End Sub
    Public Property codigoMaquinaLocal_ As Integer
        Get
            Return codigoMaquinaLocal
        End Get
        Set(value As Integer)
            codigoMaquinaLocal = value
        End Set
    End Property

    Public Function BuscarArqueo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarArqueo"
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

End Class
