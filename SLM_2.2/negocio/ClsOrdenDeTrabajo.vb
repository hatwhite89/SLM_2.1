Imports System.Data.SqlClient

Public Class ClsOrdenDeTrabajo

    Dim cod_orden_trabajo, cod_factura, pmUsuario, npUsuario, epUsuario, prUsuario, coUsuario As Integer
    Dim estado, curva, facturaTomaMuestra, tecnicoLab As String
    Dim enUsuario, inUsuario, cod_sede, cod_tecnico, cod_validador, cod_objeto As Integer
    Dim pmFecha, npFecha, epFecha, prFecha, coFecha, enFecha, inFecha, fechaEntrega As Date
    Dim enviadaWS, enviadaEmail, cortesia, urgente, entregarMedico, entregarPaciente As Boolean
    'Constructor
    Public Sub New()

    End Sub
    Public Property cod_orden_trabajo_ As Integer
        Get
            Return cod_orden_trabajo
        End Get
        Set(value As Integer)
            cod_orden_trabajo = value
        End Set
    End Property
    Public Property cod_factura_ As Integer
        Get
            Return cod_factura
        End Get
        Set(value As Integer)
            cod_factura = value
        End Set
    End Property
    Public Property pmUsuario_ As Integer
        Get
            Return pmUsuario
        End Get
        Set(value As Integer)
            pmUsuario = value
        End Set
    End Property
    Public Property npUsuario_ As Integer
        Get
            Return npUsuario
        End Get
        Set(value As Integer)
            npUsuario = value
        End Set
    End Property
    Public Property epUsuario_ As Integer
        Get
            Return epUsuario
        End Get
        Set(value As Integer)
            epUsuario = value
        End Set
    End Property

    Public Property prUsuario_ As Integer
        Get
            Return prUsuario
        End Get
        Set(value As Integer)
            prUsuario = value
        End Set
    End Property
    Public Property coUsuario_ As Integer
        Get
            Return coUsuario
        End Get
        Set(value As Integer)
            coUsuario = value
        End Set
    End Property
    Public Property enUsuario_ As Integer
        Get
            Return enUsuario
        End Get
        Set(value As Integer)
            enUsuario = value
        End Set
    End Property
    Public Property inUsuario_ As Integer
        Get
            Return inUsuario
        End Get
        Set(value As Integer)
            inUsuario = value
        End Set
    End Property
    Public Property cod_sede_ As Integer
        Get
            Return cod_sede
        End Get
        Set(value As Integer)
            cod_sede = value
        End Set
    End Property
    Public Property cod_tecnico_ As Integer
        Get
            Return cod_tecnico
        End Get
        Set(value As Integer)
            cod_tecnico = value
        End Set
    End Property
    Public Property estado_ As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property curva_ As String
        Get
            Return curva
        End Get
        Set(value As String)
            curva = value
        End Set
    End Property

    Public Property facturaTomaMuestra_ As String
        Get
            Return facturaTomaMuestra
        End Get
        Set(value As String)
            facturaTomaMuestra = value
        End Set
    End Property
    Public Property tecnicoLab_ As String
        Get
            Return tecnicoLab
        End Get
        Set(value As String)
            tecnicoLab = value
        End Set
    End Property
    Public Property pmFecha_ As Date
        Get
            Return pmFecha
        End Get
        Set(value As Date)
            pmFecha = value
        End Set
    End Property
    Public Property npFecha_ As Date
        Get
            Return npFecha
        End Get
        Set(value As Date)
            npFecha = value
        End Set
    End Property
    Public Property epFecha_ As Date
        Get
            Return epFecha
        End Get
        Set(value As Date)
            epFecha = value
        End Set
    End Property

    Public Property prFecha_ As Date
        Get
            Return prFecha
        End Get
        Set(value As Date)
            prFecha = value
        End Set
    End Property

    Public Property coFecha_ As Date
        Get
            Return coFecha
        End Get
        Set(value As Date)
            coFecha = value
        End Set
    End Property

    Public Property enFecha_ As Date
        Get
            Return enFecha
        End Get
        Set(value As Date)
            enFecha = value
        End Set
    End Property
    Public Property inFecha_ As Date
        Get
            Return inFecha
        End Get
        Set(value As Date)
            inFecha = value
        End Set
    End Property
    Public Property fechaEntrega_ As Date
        Get
            Return fechaEntrega
        End Get
        Set(value As Date)
            fechaEntrega = value
        End Set
    End Property
    Public Property entregarPaciente_ As Boolean
        Get
            Return entregarPaciente
        End Get
        Set(value As Boolean)
            entregarPaciente = value
        End Set
    End Property
    Public Property entregarMedico_ As Boolean
        Get
            Return entregarMedico
        End Get
        Set(value As Boolean)
            entregarMedico = value
        End Set
    End Property
    Public Property urgente_ As Boolean
        Get
            Return urgente
        End Get
        Set(value As Boolean)
            urgente = value
        End Set
    End Property
    Public Property cortesia_ As Boolean
        Get
            Return cortesia
        End Get
        Set(value As Boolean)
            cortesia = value
        End Set
    End Property

    Public Property enviadaEmail_ As Boolean
        Get
            Return enviadaEmail
        End Get
        Set(value As Boolean)
            enviadaEmail = value
        End Set
    End Property
    Public Property enviadaWS_ As Boolean
        Get
            Return enviadaWS
        End Get
        Set(value As Boolean)
            enviadaWS = value
        End Set
    End Property
    Public Property cod_validador_ As Integer
        Get
            Return cod_validador
        End Get
        Set(value As Integer)
            cod_validador = value
        End Set
    End Property

    Public Property cod_objeto_ As Integer
        Get
            Return cod_objeto
        End Get
        Set(value As Integer)
            cod_objeto = value
        End Set
    End Property

    'Public Function RegistrarNuevaFactura() As String
    '    Dim sqlcom As SqlCommand
    '    Dim sqlpar As SqlParameter
    '    Dim par_sal As Integer

    '    sqlcom = New SqlCommand
    '    sqlcom.CommandType = CommandType.StoredProcedure
    '    sqlcom.CommandText = "M_slmInsertarFactura"

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "numeroOficial" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = numeroOficial_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoCliente" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoCliente_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoRecepcionista" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoRecepcionista_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoMedico" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoMedico_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoCajero" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoCajero_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoTerminoPago" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoTerminoPago1
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoSede" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoSede_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "fechaVto" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = fechaVto_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoSucursal" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoSucursal_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoConvenio" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoConvenio_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "numeroPoliza" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = numeroPoliza_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "codigoTerminal" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = codigoTerminal_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "entregaMedico" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = entregaMedico_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "entregaPaciente" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = entregaPaciente_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "enviarEmail" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = enviarEmail_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "pagoPaciente" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = pagoPaciente_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "vuelto" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = vuelto_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "total" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = total_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = ok_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "ingresoEfectivo" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = ingresoEfectivo_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "ingresoTarjeta" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = ingresoTarjeta_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "salida"
    '    sqlpar.Value = ""
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar.Direction = ParameterDirection.Output

    '    Dim con As New ClsConnection
    '    sqlcom.Connection = con.getConexion

    '    sqlcom.ExecuteNonQuery()

    '    con.cerrarConexion()

    '    par_sal = sqlcom.Parameters("salida").Value

    '    Return par_sal

    'End Function
    'Public Function ModificarFactura() As String
    '    Dim sqlcom As SqlCommand
    '    Dim sqlpar As SqlParameter
    '    Dim par_sal As Integer

    '    sqlcom = New SqlCommand
    '    sqlcom.CommandType = CommandType.StoredProcedure
    '    sqlcom.CommandText = "M_slmModificarFactura"

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "numero" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = numero_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "numeroOficial" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = numeroOficial_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "entregaMedico" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = entregaMedico_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "entregaPaciente" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = entregaPaciente_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "enviarEmail" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = enviarEmail_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "pagoPaciente" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = pagoPaciente_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "vuelto" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = vuelto_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "ok" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = ok_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "ingresoEfectivo" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = ingresoEfectivo_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "ingresoTarjeta" 'nombre campo en el procedimiento almacenado @
    '    sqlpar.Value = ingresoTarjeta_
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar = New SqlParameter
    '    sqlpar.ParameterName = "salida"
    '    sqlpar.Value = ""
    '    sqlcom.Parameters.Add(sqlpar)

    '    sqlpar.Direction = ParameterDirection.Output

    '    Dim con As New ClsConnection
    '    sqlcom.Connection = con.getConexion

    '    sqlcom.ExecuteNonQuery()

    '    con.cerrarConexion()

    '    par_sal = sqlcom.Parameters("salida").Value

    '    Return par_sal

    'End Function
    'Public Function BuscarFactura() As DataTable
    '    Dim objCon As New ClsConnection
    '    Dim cn As New SqlConnection
    '    cn = objCon.getConexion
    '    Using cmd As New SqlCommand
    '        cmd.Connection = cn
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "M_slmBuscarFactura"
    '        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
    '        Using da As New SqlDataAdapter
    '            da.SelectCommand = cmd
    '            Using dt As New DataTable
    '                da.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using
    '    End Using
    'End Function
    'Public Function BuscarFacturaNumero() As DataTable
    '    Dim objCon As New ClsConnection
    '    Dim cn As New SqlConnection
    '    cn = objCon.getConexion
    '    Using cmd As New SqlCommand
    '        cmd.Connection = cn
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "M_slmBuscarFacturaNumero"
    '        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero_
    '        Using da As New SqlDataAdapter
    '            da.SelectCommand = cmd
    '            Using dt As New DataTable
    '                da.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using
    '    End Using
    'End Function
    'Public Function BuscarFacturaCliente() As DataTable
    '    Dim objCon As New ClsConnection
    '    Dim cn As New SqlConnection
    '    cn = objCon.getConexion
    '    Using cmd As New SqlCommand
    '        cmd.Connection = cn
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.CommandText = "M_slmBuscarFacturaCliente"
    '        cmd.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = nombreCliente_
    '        Using da As New SqlDataAdapter
    '            da.SelectCommand = cmd
    '            Using dt As New DataTable
    '                da.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using
    '    End Using
    'End Function

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
End Class
