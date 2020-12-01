

Imports System.Data.SqlClient
Public Class ClsDetalleAsiento

    Dim codDetalle, codAsiento, cuenta As Integer
    Dim debe, haber As Double


    ':::::::::::::::::::::: Constructor ::::::::::::::::::::::
    Public Sub New()

    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Codigo Detalle
    Public Property Cod_Detalle As Integer
        Get
            Return codDetalle
        End Get
        Set(value As Integer)
            codDetalle = value
        End Set
    End Property

    'Codigo asiento
    Public Property Cod_Asiento As Integer
        Get
            Return codAsiento
        End Get
        Set(value As Integer)
            codAsiento = value
        End Set
    End Property

    'Cuenta
    Public Property Cuenta_ As Integer
        Get
            Return cuenta
        End Get
        Set(value As Integer)
            cuenta = value
        End Set
    End Property

    'Debe
    Public Property Debe_ As Double
        Get
            Return debe
        End Get
        Set(value As Double)
            debe = value
        End Set
    End Property

    'Haber
    Public Property Haber_ As Double
        Get
            Return haber
        End Get
        Set(value As Double)
            haber = value
        End Set
    End Property



    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar detalle siento
    Public Function registrarDetalleAsiento() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDetalleAsiento"

        'VARIABLES 

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codAsiento"
        sqlpar.Value = Cod_Asiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "debe"
        sqlpar.Value = Debe_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "haber"
        sqlpar.Value = Haber_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuenta_
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


    'Modificar detalle Asiento
    Public Function modificarDetalleAsiento() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDetalleAsiento"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codDetalleAsiento"
        sqlpar.Value = Cod_Detalle
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codAsiento"
        sqlpar.Value = Cod_Asiento
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "debe"
        sqlpar.Value = Debe_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "haber"
        sqlpar.Value = Haber_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuenta_
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




    'Ver detalle Asiento
    Public Function VerDetalleAsiento() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmVerDetalleAsiento"
            cmd.Parameters.Add("@cod_Asiento", SqlDbType.VarChar).Value = Cod_Asiento
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
