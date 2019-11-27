Imports System.Data.SqlClient

Public Class ClsAccesoLaboratorio
    Dim usuario, nombre As String
    Dim ingresarResultado, objetarResultado, confirmarResultado, validarResultado As Boolean
    'Constructor
    Public Sub New()

    End Sub
    Public Property usuario_ As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property
    Public Property Nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property ingresarResultado_ As Boolean
        Get
            Return ingresarResultado
        End Get
        Set(value As Boolean)
            ingresarResultado = value
        End Set
    End Property
    Public Property objetarResultado_ As Boolean
        Get
            Return objetarResultado
        End Get
        Set(value As Boolean)
            objetarResultado = value
        End Set
    End Property
    Public Property confirmarResultado_ As Boolean
        Get
            Return confirmarResultado
        End Get
        Set(value As Boolean)
            confirmarResultado = value
        End Set
    End Property
    Public Property validarResultado_ As Boolean
        Get
            Return validarResultado
        End Get
        Set(value As Boolean)
            validarResultado = value
        End Set
    End Property
    Public Function RegistrarNuevoAccesoLaboratorio() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarAccesoLaboratorio_E"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = usuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ingresarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ingresarResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "objetarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = objetarResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "confirmarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = confirmarResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "validarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = validarResultado_
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
    Public Function ModificarAccesoLaboratorio() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarAccesoLaboratorio_E"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "usuario" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = usuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ingresarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ingresarResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "objetarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = objetarResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "confirmarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = confirmarResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "validarResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = validarResultado_
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
    Public Function BuscarAccesoLaboratorio() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarAccesoLaboratorio_E"
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function
    Public Function SeleccionarAccesoLaboratorio() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmSeleccionarAccesoLaboratorio_E", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class

