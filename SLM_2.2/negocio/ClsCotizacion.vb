﻿Imports System.Data.SqlClient

Public Class ClsCotizacion
    Dim numero, codigoCliente, codigoRecepcionista, codigoTerminoPago, codigoSucursal, codigoCajero As Integer
    Dim nombreCliente As String
    Dim fecha As Date
    Dim total As Double
    'Constructor
    Public Sub New()

    End Sub
    Public Property numero_ As Integer
        Get
            Return numero
        End Get
        Set(value As Integer)
            numero = value
        End Set
    End Property
    Public Property codigoCliente_ As Integer
        Get
            Return codigoCliente
        End Get
        Set(value As Integer)
            codigoCliente = value
        End Set
    End Property
    Public Property codigoTerminoPago_ As Integer
        Get
            Return codigoTerminoPago
        End Get
        Set(value As Integer)
            codigoTerminoPago = value
        End Set
    End Property
    Public Property nombreCliente_ As String
        Get
            Return nombreCliente
        End Get
        Set(value As String)
            nombreCliente = value
        End Set
    End Property
    Public Property codigoCajero_ As Integer
        Get
            Return codigoCajero
        End Get
        Set(value As Integer)
            codigoCajero = value
        End Set
    End Property
    Public Property codigoRecepcionista_ As Integer
        Get
            Return codigoRecepcionista
        End Get
        Set(value As Integer)
            codigoRecepcionista = value
        End Set
    End Property
    Public Property codigoSucursal_ As Integer
        Get
            Return codigoSucursal
        End Get
        Set(value As Integer)
            codigoSucursal = value
        End Set
    End Property
    Public Property total_ As Double
        Get
            Return total
        End Get
        Set(value As Double)
            total = value
        End Set
    End Property
    Public Property fecha_ As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property
    Public Function RegistrarNuevaCotizacion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarCotizacion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCliente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCliente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminoPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoRecepcionista" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoRecepcionista_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSucursal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSucursal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = total_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCajero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCajero_
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
    Public Function ModificarCotizacion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmModificarCotizacion"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCliente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCliente_
        sqlcom.Parameters.Add(sqlpar)

        'sqlpar = New SqlParameter
        'sqlpar.ParameterName = "fecha" 'nombre campo en el procedimiento almacenado @
        'sqlpar.Value = fecha_
        'sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminoPago_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoRecepcionista" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoRecepcionista_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSucursal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSucursal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = total_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCajero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCajero_
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
    Public Function BuscarCotizacion() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarCotizacion"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
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
    Public Function BuscarCotizacionNumero() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarCotizacionNumero"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
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
    Public Function BuscarCotizacionCode() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarCotizacionCode"
            cmd.Parameters.Add("@codigoCliente", SqlDbType.Int).Value = codigoCliente_
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = total_
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
    Public Function BuscarCotizacionCliente() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarCotizacionCliente"
            cmd.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = nombreCliente_
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
    Public Function SeleccionarCotizacion() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("M_slmSeleccionarCotizacion", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class