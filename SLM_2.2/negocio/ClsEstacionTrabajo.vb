Imports System.Data.SqlClient

Public Class ClsEstacionTrabajo
    Dim codigo, descripcion As String
    'Constructor
    Public Sub New()

    End Sub

    Public Property Codigo_ As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
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


    Public Function RegistrarNuevaEstacionTrabajo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarEstacionTrabajo_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'descripcion campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'descripcion campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    Public Function ModificarEstacionTrabajo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarEstacionTrabajo_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'descripcion campo en el procedimiento almacenado @
        sqlpar.Value = Codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'descripcion campo en el procedimiento almacenado @
        sqlpar.Value = descripcion_
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function


    Public Function BuscarEstacionTrabajo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarEstacionTrabajo_M"
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Public Function BuscarEstacionTrabajoCode() As DataTable

    '    Dim objCon As New ClsConnection
    '    Dim cn As New SqlConnection
    '    cn = objCon.getConexion

    '    Using cmd As New SqlCommand
    '        cmd.Connection = cn
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "slmBuscarEstacionTrabajoCode_M"
    '        cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo1
    '        Using da As New SqlDataAdapter
    '            da.SelectCommand = cmd
    '            Using dt As New DataTable
    '                da.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using
    '    End Using

    'End Function

    Public Function SeleccionarEstacionTrabajo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmSeleccionarEstacionTrabajo_M", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
