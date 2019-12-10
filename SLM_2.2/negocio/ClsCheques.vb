
Imports System.Data.SqlClient
Public Class ClsCheques

    'Variables de Cheque
    Dim codCheque, codChequera, cantidad, ctaOrigen, ctaTemporal, ctaDestino As Integer
    Dim nroCheque, moneda, codBreveProve, nombreProveedor, codBreveBanco, nombreBanco, descripcion, estado, comentario, tipo As String
    Dim monto As Double
    Dim fechaReg, fechaVto, fechaAcreditacion, fechaRechazo, fechaEmision, fechaCancelado As Date

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::::::::::::::::::::::::


    'Cuenta Origen
    Public Property cta_Origen As Integer
        Get
            Return ctaOrigen
        End Get
        Set(value As Integer)
            ctaOrigen = value
        End Set
    End Property

    'Cuenta Temporal
    Public Property cta_Temporal As Integer
        Get
            Return ctaTemporal
        End Get
        Set(value As Integer)
            ctaTemporal = value
        End Set
    End Property

    'Cuenta Destino
    Public Property cta_Destino As Integer
        Get
            Return ctaDestino
        End Get
        Set(value As Integer)
            ctaDestino = value
        End Set
    End Property


    'Codigo de cheque
    Public Property Cod_Cheque As Integer
        Get
            Return codCheque
        End Get
        Set(value As Integer)
            codCheque = value
        End Set
    End Property

    'Codigo de Chequera
    Public Property Cod_Chequera As Integer
        Get
            Return codChequera
        End Get
        Set(value As Integer)
            codChequera = value
        End Set
    End Property

    'Tipo
    Public Property Tip_o As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    'Comentario
    Public Property Comentari_o As String
        Get
            Return comentario
        End Get
        Set(value As String)
            comentario = value
        End Set
    End Property

    'Estado
    Public Property Estad_o As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    'Descripcion
    Public Property Descripcio_n As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Nombre de Banco
    Public Property Nombre_Banco As String
        Get
            Return nombreBanco
        End Get
        Set(value As String)
            nombreBanco = value
        End Set
    End Property

    'Codigo Breve Banco
    Public Property Cod_BreveBanco As String
        Get
            Return codBreveBanco
        End Get
        Set(value As String)
            codBreveBanco = value
        End Set
    End Property


    'Nombre de Proveedor
    Public Property Nombre_Proveedor As String
        Get
            Return nombreProveedor
        End Get
        Set(value As String)
            nombreProveedor = value
        End Set
    End Property

    'Codigo breve de Proveedor
    Public Property Cod_BreveProvee As String
        Get
            Return codBreveProve
        End Get
        Set(value As String)
            codBreveProve = value
        End Set
    End Property

    'Moneda
    Public Property Moned_a As String
        Get
            Return moneda
        End Get
        Set(value As String)
            moneda = value
        End Set
    End Property

    'Numero de Cheque
    Public Property Numero_Cheque As String
        Get
            Return nroCheque
        End Get
        Set(value As String)
            nroCheque = value
        End Set
    End Property

    'monto
    Public Property Mont_o As Double
        Get
            Return monto
        End Get
        Set(value As Double)
            monto = value
        End Set
    End Property

    'fechaVto
    Public Property Fecha_Vto As Date
        Get
            Return fechaVto
        End Get
        Set(value As Date)
            fechaVto = value
        End Set
    End Property

    'fechaReg
    Public Property Fecha_reg As Date
        Get
            Return fechaReg
        End Get
        Set(value As Date)
            fechaReg = value
        End Set
    End Property

    'fecha acreditacion
    Public Property Fecha_Acreditacion As Date
        Get
            Return fechaAcreditacion
        End Get
        Set(value As Date)
            fechaAcreditacion = value
        End Set
    End Property

    'fecha rechazo
    Public Property Fecha_Rechazo As Date
        Get
            Return fechaRechazo
        End Get
        Set(value As Date)
            fechaRechazo = value
        End Set
    End Property

    'fecha emision
    Public Property Fecha_emision As Date
        Get
            Return fechaEmision
        End Get
        Set(value As Date)
            fechaEmision = value
        End Set
    End Property

    'fecha cancelado
    Public Property Fecha_cancelado As Date
        Get
            Return fechaCancelado
        End Get
        Set(value As Date)
            fechaCancelado = value
        End Set
    End Property

    'Cantidad
    Public Property Cantida_d As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            cantidad = value
        End Set
    End Property


    ':::::::::::::::::::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO ::::::::::::::::::::::::::::::::::::::::::::::

    'Registar nuevos cheques
    Public Function registrarNuevosCheques() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_InsertarXCantidad"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codChequera"
        sqlpar.Value = Cod_Chequera
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroCheque"
        sqlpar.Value = Numero_Cheque
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreveBanco"
        sqlpar.Value = Cod_BreveBanco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estad_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda"
        sqlpar.Value = Moned_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreBanco"
        sqlpar.Value = Nombre_Banco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cantidad"
        sqlpar.Value = Cantida_d
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "counter"
        sqlpar.Value = "1"
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

    'Modificar Cheque para pago
    Public Function modificarCheque() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarCheque"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCheque"
        sqlpar.Value = Cod_Cheque
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codChequera"
        sqlpar.Value = Cod_Chequera
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroCheque"
        sqlpar.Value = Numero_Cheque
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "monto"
        sqlpar.Value = Mont_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaReg"
        sqlpar.Value = Fecha_reg
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaVto"
        sqlpar.Value = Fecha_Vto
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda"
        sqlpar.Value = Cod_Cheque
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreveProveedor"
        sqlpar.Value = Cod_BreveProvee
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreveBanco"
        sqlpar.Value = Cod_BreveBanco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreBanco"
        sqlpar.Value = Nombre_Banco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Estad_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaAcreditacion"
        sqlpar.Value = Fecha_Acreditacion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaRechazo"
        sqlpar.Value = Fecha_Rechazo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaEmision"
        sqlpar.Value = Fecha_emision
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaCancelado"
        sqlpar.Value = Fecha_cancelado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipo"
        sqlpar.Value = Tip_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaOrigen"
        sqlpar.Value = cta_Origen
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaTemporal"
        sqlpar.Value = cta_Temporal
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaDestino"
        sqlpar.Value = cta_Destino
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

    'Listar cheques disponibles
    Public Function listarChequesDisponibles() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmListarChequesHabilitados"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Cod_BreveBanco
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
