Imports System.Data.SqlClient

Public Class ClsFactura

    Dim numero, codigoCliente, codigoMedico, codigoSede, codigoRecepcionista, codigoCajero, codigoTerminoPago As Integer
    Dim numeroOficial, numeroPoliza, nombreCliente As String
    Dim codigoSucursal, codigoConvenio, codigoTerminal As Integer
    Dim fechaFactura, fechaVto As Date
    Dim ok, enviarEmail, entregaPaciente, entregaMedico, estado As Boolean
    Dim pagoPaciente, vuelto, total, ingresoEfectivo, ingresoTarjeta As Double

    Dim cheque, transferencia, deposito As Double
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
    Public Property nombreCliente_ As String
        Get
            Return nombreCliente
        End Get
        Set(value As String)
            nombreCliente = value
        End Set
    End Property
    Public Property codigoTerminoPago1 As Integer
        Get
            Return codigoTerminoPago
        End Get
        Set(value As Integer)
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
    Public Property codigoRecepcionista_ As Integer
        Get
            Return codigoRecepcionista
        End Get
        Set(value As Integer)
            codigoRecepcionista = value
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
    Public Property codigoSede_ As Integer
        Get
            Return codigoSede
        End Get
        Set(value As Integer)
            codigoSede = value
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
    Public Property codigoConvenio_ As Integer
        Get
            Return codigoConvenio
        End Get
        Set(value As Integer)
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
    Public Property codigoTerminal_ As Integer
        Get
            Return codigoTerminal
        End Get
        Set(value As Integer)
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
    Public Property estado_ As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
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

    Public Property ingresoEfectivo_ As Double
        Get
            Return ingresoEfectivo
        End Get
        Set(value As Double)
            ingresoEfectivo = value
        End Set
    End Property
    Public Property ingresoTarjeta_ As Double
        Get
            Return ingresoTarjeta
        End Get
        Set(value As Double)
            ingresoTarjeta = value
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
    Public Property cheque_ As Double
        Get
            Return cheque
        End Get
        Set(value As Double)
            cheque = value
        End Set
    End Property
    Public Property deposito_ As Double
        Get
            Return deposito
        End Get
        Set(value As Double)
            deposito = value
        End Set
    End Property
    Public Property transferencia_ As Double
        Get
            Return transferencia
        End Get
        Set(value As Double)
            transferencia = value
        End Set
    End Property
    Public Function RegistrarNuevaFactura() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "M_slmInsertarFactura"

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
        sqlpar.ParameterName = "ingresoEfectivo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ingresoEfectivo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ingresoTarjeta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ingresoTarjeta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "deposito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = deposito_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "transferencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = transferencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cheque" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cheque_
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
        sqlcom.CommandText = "M_slmModificarFactura"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numero_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numeroOficial" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = numeroOficial_
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
        sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ok_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ingresoEfectivo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ingresoEfectivo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ingresoTarjeta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ingresoTarjeta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "total" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = total_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "deposito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = deposito_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "transferencia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = transferencia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cheque" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cheque_
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
    Public Function BuscarFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarFactura"
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
            cmd.CommandText = "M_slmBuscarFacturaNumero"
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
    Public Function BuscarFacturaNumeroF() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "M_slmBuscarFacturaNumeroF"
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
            cmd.CommandText = "M_slmBuscarFacturaCliente"
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
        sqlcom.CommandText = "M_slmEliminarFactura"

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
            cmd.CommandText = "M_slmBuscarFacturaCode"
            cmd.Parameters.Add("@numeroOficial", SqlDbType.VarChar).Value = numeroOficial_
            cmd.Parameters.Add("@codigoCliente", SqlDbType.Int).Value = codigoCliente_
            cmd.Parameters.Add("@codigoRecepcionista", SqlDbType.Int).Value = codigoRecepcionista_
            cmd.Parameters.Add("@codigoMedico", SqlDbType.Int).Value = codigoMedico_
            cmd.Parameters.Add("@codigoCajero", SqlDbType.Int).Value = codigoCajero_
            cmd.Parameters.Add("@codigoTerminoPago", SqlDbType.Int).Value = codigoTerminoPago1
            cmd.Parameters.Add("@codigoSede", SqlDbType.Int).Value = codigoSede_
            cmd.Parameters.Add("@fechaVto", SqlDbType.DateTime).Value = fechaVto_
            cmd.Parameters.Add("@codigoSucursal", SqlDbType.Int).Value = codigoSucursal_
            cmd.Parameters.Add("@pagoPaciente", SqlDbType.Float).Value = pagoPaciente_
            cmd.Parameters.Add("@vuelto", SqlDbType.Float).Value = vuelto_
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
    Public Function SeleccionarDiarioFacturacion() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("M_slmSeleccionarFacturaDiario", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
    Public Function SeleccionarFactura() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("M_slmSeleccionarFactura", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
    Public Function BuscarDiarioFacturacion(Optional ByVal numero As Integer = Nothing, Optional ByVal nombreCompleto As String = Nothing,
                                            Optional ByVal fechaFactura As Date = Nothing, Optional ByVal nombreMedico As String = Nothing,
                                            Optional ByVal descripcionTermino As String = Nothing, Optional ByVal estado As Boolean = Nothing,
                                            Optional ByVal usuarioCajero As String = Nothing, Optional ByVal fechaDesde As Date = Nothing,
                                            Optional ByVal fechaHasta As Date = Nothing, Optional ByVal descripcionExamen As String = Nothing,
                                            Optional ByVal descripcionGrupo As String = Nothing) As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "Z_BuscarDiarioFacturacion"
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero
            cmd.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = nombreCompleto
            cmd.Parameters.Add("@fechaFactura", SqlDbType.Date).Value = fechaFactura
            cmd.Parameters.Add("@nombreMedico", SqlDbType.VarChar).Value = nombreMedico
            cmd.Parameters.Add("@descripcionTermino", SqlDbType.VarChar).Value = descripcionTermino
            cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = estado
            cmd.Parameters.Add("@usuarioCajero", SqlDbType.VarChar).Value = usuarioCajero
            cmd.Parameters.Add("@fechaDesde", SqlDbType.Date).Value = fechaDesde
            cmd.Parameters.Add("@fechaHasta", SqlDbType.Date).Value = fechaHasta
            cmd.Parameters.Add("@descripcionExamen", SqlDbType.VarChar).Value = descripcionExamen
            cmd.Parameters.Add("@descripcionGrupo", SqlDbType.VarChar).Value = descripcionGrupo
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
