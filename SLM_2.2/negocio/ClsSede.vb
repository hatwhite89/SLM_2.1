Imports System.Data.SqlClient
Public Class ClsSede

    Dim codigo As Integer
    Dim nombre, direccion1, direccion2, direccion3, direccion4, contacto, correo, telefono As String
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

    Public Property Direccion_1 As String
        Get
            Return direccion1
        End Get
        Set(value As String)
            direccion1 = value
        End Set
    End Property

    Public Property Direccion_2 As String
        Get
            Return direccion2
        End Get
        Set(value As String)
            direccion2 = value
        End Set
    End Property

    Public Property Direccion_3 As String
        Get
            Return direccion3
        End Get
        Set(value As String)
            direccion3 = value
        End Set
    End Property

    Public Property Direccion_4 As String
        Get
            Return direccion4
        End Get
        Set(value As String)
            direccion4 = value
        End Set
    End Property

    Public Property Contacto_1 As String
        Get
            Return contacto
        End Get
        Set(value As String)
            contacto = value
        End Set
    End Property

    Public Property Correo_1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property Telefono_1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Function RegistrarNuevaSede() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarSede"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion3" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_3
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion4" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_4
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contacto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Contacto_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Telefono_1
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

    Public Function ModificarSede() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarSede"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Codigo1
        sqlcom.Parameters.Add(sqlpar)


        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion3" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_3
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion4" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Direccion_4
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contacto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Contacto_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "correo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Correo_1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Telefono_1
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


    Public Function BuscarSede() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarSede"
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


    Public Function SeleccionarSede() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarSede", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function


    Public Function BuscarSedeCode() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarSedeCode"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = Codigo1
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

End Class
