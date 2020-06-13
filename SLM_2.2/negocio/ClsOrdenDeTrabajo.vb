Imports System.Data.SqlClient

Public Class ClsOrdenDeTrabajo

    Dim cod_orden_trabajo, cod_factura, pmUsuario, npUsuario, epUsuario, prUsuario, coUsuario As Integer
    Dim estado, curva, facturaTomaMuestra, tecnicoLab As String
    Dim enUsuario, inUsuario, cod_sede, cod_tecnico, cod_validador, cod_objeto, codigoSubArea As Integer
    Dim pmFecha, npFecha, epFecha, prFecha, coFecha, enFecha, inFecha, fechaEntrega As Date
    Dim enviadaWS, enviadaEmail, cortesia, urgente, entregarMedico, entregarPaciente As Boolean

    'busqueda hoja de trabajo
    Dim codigoSucursal As Integer
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
    Public Property codigoSucursal_ As Integer
        Get
            Return codigoSucursal
        End Get
        Set(value As Integer)
            codigoSucursal = value
        End Set
    End Property
    Public Property codigoSubArea_ As Integer
        Get
            Return codigoSubArea
        End Get
        Set(value As Integer)
            codigoSubArea = value
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

    Public Function RegistrarOrdenDeTrabajo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarOrdenDeTrabajo"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_factura" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_factura_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pmFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = pmFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pmUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = pmUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "npFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = pmFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "npUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = pmUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSubArea" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = codigoSubArea_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = estado_
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
    Public Function ModificarOrdenDeTrabajo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarOrdenDeTrabajo"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_orden_trabajo" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_orden_trabajo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_factura" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_factura_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pmFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = pmFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pmUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = pmUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "npFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = npFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "npUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = npUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "epFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = epFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "epUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = epUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "prFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = prFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "prUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = prUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "coFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = coFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "coUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = coUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = enFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = enUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "inFecha" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = inFecha_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "inUsuario" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = inUsuario_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = estado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "curva" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = curva_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_sede" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_sede_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_tecnico" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_tecnico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_validador" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_validador_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_objeto" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cod_objeto_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "facturaTomaMuestra" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = facturaTomaMuestra_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tecnicoLab" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = tecnicoLab_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enviadaWS" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = enviadaWS_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enviadaEmail" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = enviadaEmail_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaEntrega" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = fechaEntrega_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cortesia" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = cortesia_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "urgente" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = urgente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entregarMedico" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = entregarMedico_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "entregarPaciente" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = entregarPaciente_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoSubArea" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = codigoSubArea_
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
    'generar hoja de trabajo por sucursal y subarea
    Public Function BuscarHojaDeTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarHojaDeTrabajo"
            cmd.Parameters.Add("codigoSubArea", SqlDbType.Int).Value = codigoSubArea_
            cmd.Parameters.Add("codigoSucursal", SqlDbType.Int).Value = codigoSucursal_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function BuscarOrdenDeTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarOrdenDeTrabajo"
            cmd.Parameters.Add("cod_orden_trabajo", SqlDbType.Int).Value = cod_orden_trabajo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function CapturarOrdenDeTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmCapturarOrdenDeTrabajo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
    Public Function SeleccionarOrdenDeTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using da As New SqlDataAdapter("E_slmSeleccionarOrdenDeTrabajo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class
