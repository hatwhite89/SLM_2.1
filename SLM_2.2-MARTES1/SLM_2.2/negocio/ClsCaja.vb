Imports System.Data.SqlClient

Public Class ClsCaja
    Dim codigoCaja, nombre As String
    Dim codigo As Integer
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

    Public Property codigoCaja_ As String
        Get
            Return codigoCaja
        End Get
        Set(value As String)
            codigoCaja = value
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


    Public Function RegistrarNuevaCaja() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarCaja"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCaja_
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

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    Public Function ModificarCaja() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarCaja"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCaja" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCaja_
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

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function


    Public Function BuscarCaja() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarCaja"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Nombre1
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

    'Public Function BuscarCajaCode() As DataTable

    '    Dim objCon As New ClsConnection
    '    Dim cn As New SqlConnection
    '    cn = objCon.getConexion

    '    Using cmd As New SqlCommand
    '        cmd.Connection = cn
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "M_slmBuscarCajaCode"
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

    Public Function SeleccionarCaja() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("M_slmSeleccionarCaja", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function

End Class
