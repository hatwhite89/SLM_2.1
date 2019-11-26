Imports System.Data.SqlClient
Public Class ClsObjeto
    Dim nombre, objeto, tipoObjeto As String
    Dim cerrado As Boolean
    'Constructor
    Public Sub New()

    End Sub
    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property objeto_ As String
        Get
            Return objeto
        End Get
        Set(value As String)
            objeto = value
        End Set
    End Property
    Public Property cerrado_ As Boolean
        Get
            Return cerrado
        End Get
        Set(value As Boolean)
            cerrado = value
        End Set
    End Property
    Public Property tipoObjeto_ As String
        Get
            Return tipoObjeto
        End Get
        Set(value As String)
            tipoObjeto = value
        End Set
    End Property
    Public Function RegistrarNuevoObjeto() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarObjeto_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "objeto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = objeto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoObjeto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = tipoObjeto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cerrado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cerrado_
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
    Public Function ModificarObjeto() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarObjeto_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "objeto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = objeto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoObjeto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = tipoObjeto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cerrado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cerrado_
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
    Public Function BuscarObjeto() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarObjeto_M"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarObjetoCode() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarObjetoCode_M"
            cmd.Parameters.Add("@objeto", SqlDbType.VarChar).Value = objeto_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function
    Public Function SeleccionarObjeto() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmSeleccionarObjeto_M", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function


    'Listar codigo y nombre de objeto
    Public Function listarNombreObjeto() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmListarNombreObjetos_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using

    End Function

End Class
