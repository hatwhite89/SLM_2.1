

Imports System.Data.SqlClient


Public Class ClsCentroCostos

    'Variables
    Dim nombre, codBreve As String
    Dim id_centrocostos, cod_area, codCuenta As Integer
    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::::::::::::::::::: METODOS SET Y GET
    Public Property ID As Integer
        Get
            Return id_centrocostos
        End Get
        Set(value As Integer)
            id_centrocostos = value
        End Set
    End Property

    Public Property cod_Cuenta As Integer
        Get
            Return codCuenta
        End Get
        Set(value As Integer)
            codCuenta = value
        End Set
    End Property

    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property codBreve_ As String
        Get
            Return codBreve
        End Get
        Set(value As String)
            codBreve = value
        End Set
    End Property

    Public Property cod_area_ As Integer
        Get
            Return cod_area
        End Get
        Set(value As Integer)
            cod_area = value
        End Set
    End Property


    ':::::::::::::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO

    Public Function RegistrarNuevoCentroCosto() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarCentroCosto"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_area" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_area_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCuenta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_Cuenta
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


    Public Function ActualizarCentroCosto() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarCentroCosto"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_centrocosto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ID
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nombre_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_area" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_area_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codBreve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCuenta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_Cuenta
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




    Public Function BuscarCentroCosto() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarCentroCosto"
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre_
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

    Public Function ListarCentrodeCosto() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarCentroCosto", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


    Public Function BuscarCentroCostoCodigo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarCentroCostoXCodigo"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = ID
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
