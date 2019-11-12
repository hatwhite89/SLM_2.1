Imports System.Data.SqlClient

Public Class ClsEspecialidad

    Dim codigo As Integer
    Dim nombre As String
    'Constructor
    Public Sub New()

    End Sub

    Public Property Codigo1 As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Function RegistrarNuevaEspecialidad() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarEspecialidad"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
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

    Public Function ModificarEspecialidad() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarEspecialidad"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
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


    Public Function BuscarEspecialidad() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarEspecialidad"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre1
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function


    Public Function SeleccionarEspecialidad() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmSeleccionarEspecialidad", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function




    Public Function BuscarEspecialidadCode() As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.Parameters.Add("", SqlDbType.Int).Value = Codigo1
        sqlcom.CommandText = "select * from slmBuscarEspecialidadCode()"
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

End Class
