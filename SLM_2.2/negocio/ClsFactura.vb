﻿Imports System.Data.SqlClient

Public Class ClsFactura

    Dim numero, codigoCliente, codigoMedico, codigoSede As Integer
    Dim numeroOficial, codigoRecepcionista, codigoCajero, codigoTerminoPago, nombreCliente As String
    Dim codigoCategoria, codigoSucursal, codigoConvenio, numeroPoliza, codigoTerminal As String
    Dim fechaFactura, fechaVto As Date
    Dim ok, enviarEmail, entregaPaciente, entregaMedico As Boolean
    Dim pagoPaciente, vuelto, total As Double
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
    Public Property codigoMedico_ As Integer
        Get
            Return codigoMedico
        End Get
        Set(value As Integer)
            codigoMedico = value
        End Set
    End Property
    Public Property codigoCategoria1 As String
        Get
            Return codigoCategoria
        End Get
        Set(value As String)
            codigoCategoria = value
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
    Public Property codigoTerminoPago1 As String
        Get
            Return codigoTerminoPago
        End Get
        Set(value As String)
            codigoTerminoPago = value
        End Set
    End Property
    Public Property numeroOficial_ As String
        Get
            Return numeroOficial
        End Get
        Set(value As String)
            numeroOficial = value
        End Set
    End Property
    Public Property codigoRecepcionista_ As String
        Get
            Return codigoRecepcionista
        End Get
        Set(value As String)
            codigoRecepcionista = value
        End Set
    End Property
    Public Property codigoCajero_ As String
        Get
            Return codigoCajero
        End Get
        Set(value As String)
            codigoCajero = value
        End Set
    End Property
    Public Property codigoSede_ As Integer
        Get
            Return codigoSede
        End Get
        Set(value As Integer)
            codigoSede = value
        End Set
    End Property
    Public Property codigoSucursal_ As String
        Get
            Return codigoSucursal
        End Get
        Set(value As String)
            codigoSucursal = value
        End Set
    End Property
    Public Property codigoConvenio_ As String
        Get
            Return codigoConvenio
        End Get
        Set(value As String)
            codigoConvenio = value
        End Set
    End Property
    Public Property numeroPoliza_ As String
        Get
            Return numeroPoliza
        End Get
        Set(value As String)
            numeroPoliza = value
        End Set
    End Property
    Public Property codigoTerminal_ As String
        Get
            Return codigoTerminal
        End Get
        Set(value As String)
            codigoTerminal = value
        End Set
    End Property
    Public Property fechaFactura_ As Date
        Get
            Return fechaFactura
        End Get
        Set(value As Date)
            fechaFactura = value
        End Set
    End Property
    Public Property fechaVto_ As Date
        Get
            Return fechaVto
        End Get
        Set(value As Date)
            fechaVto = value
        End Set
    End Property
    Public Property ok_ As Boolean
        Get
            Return ok
        End Get
        Set(value As Boolean)
            ok = value
        End Set
    End Property
    Public Property enviarEmail_ As Boolean
        Get
            Return enviarEmail
        End Get
        Set(value As Boolean)
            enviarEmail = value
        End Set
    End Property
    Public Property entregaPaciente_ As Boolean
        Get
            Return entregaPaciente
        End Get
        Set(value As Boolean)
            entregaPaciente = value
        End Set
    End Property
    Public Property entregaMedico_ As Boolean
        Get
            Return entregaMedico
        End Get
        Set(value As Boolean)
            entregaMedico = value
        End Set
    End Property

    Public Property pagoPaciente_ As Double
        Get
            Return pagoPaciente
        End Get
        Set(value As Double)
            pagoPaciente = value
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
    Public Property vuelto_ As Double
        Get
            Return vuelto
        End Get
        Set(value As Double)
            vuelto = value
        End Set
    End Property
    Public Function RegistrarNuevaFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarFactura_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroOficial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroOficial_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCliente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCliente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoRecepcionista" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoRecepcionista_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoMedico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoMedico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCajero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCajero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminoPago1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSede" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSede_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaVto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaVto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSucursal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSucursal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoConvenio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoConvenio_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroPoliza" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroPoliza_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entregaMedico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entregaMedico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entregaPaciente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entregaPaciente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enviarEmail" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = enviarEmail_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pagoPaciente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = pagoPaciente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "vuelto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = vuelto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = total_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ok_
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
    Public Function ModificarFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmModificarFactura_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroOficial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroOficial_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaFactura" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaFactura_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCliente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCliente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoRecepcionista" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoRecepcionista_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoMedico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoMedico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoCajero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoCajero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminoPago1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSede" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSede_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaVto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = fechaVto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSucursal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoSucursal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoConvenio" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoConvenio_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroPoliza" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroPoliza_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoTerminal" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoTerminal_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entregaMedico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entregaMedico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entregaPaciente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = entregaPaciente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enviarEmail" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = enviarEmail_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pagoPaciente" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = pagoPaciente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "vuelto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = vuelto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = total_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ok_
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
    Public Function BuscarFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarFactura_M"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarFacturaNumero() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarFacturaNumero_M"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarFacturaCliente() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarFacturaCliente_M"
            cmd.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = nombreCliente_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function EliminarFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmEliminarFactura_M"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numero_
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

    Public Function BuscarFacturaCode() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarFacturaCode_M"
            cmd.Parameters.Add("@numeroOficial", SqlDbType.VarChar).Value = numeroOficial_
            cmd.Parameters.Add("@codigoCliente", SqlDbType.Int).Value = codigoCliente_
            cmd.Parameters.Add("@codigoRecepcionista", SqlDbType.VarChar).Value = codigoRecepcionista_
            cmd.Parameters.Add("@codigoMedico", SqlDbType.Int).Value = codigoMedico_
            cmd.Parameters.Add("@codigoCajero", SqlDbType.VarChar).Value = codigoCajero_
            cmd.Parameters.Add("@codigoTerminoPago", SqlDbType.VarChar).Value = codigoTerminoPago1
            cmd.Parameters.Add("@codigoSede", SqlDbType.Int).Value = codigoSede_
            cmd.Parameters.Add("@fechaVto", SqlDbType.DateTime).Value = fechaVto_
            cmd.Parameters.Add("@codigoSucursal", SqlDbType.VarChar).Value = codigoSucursal_
            cmd.Parameters.Add("@pagoPaciente", SqlDbType.Float).Value = pagoPaciente_
            cmd.Parameters.Add("@vuelto", SqlDbType.Float).Value = vuelto_
            cmd.Parameters.Add("@total", SqlDbType.Float).Value = total_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function SeleccionarFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("slmSeleccionarFactura_M", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
