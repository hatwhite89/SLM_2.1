Imports System.Data.SqlClient
Public Class ClsDeposito
    'VARIABLES
    Dim TipoContado, moneda, comentario, tipoDeposito, codCajero, banco As String
    Dim codDeposito, codFormapago As Integer
    Dim fecha As Date
    Dim comision, contado, totalDepositado, monBase As Double

    'Constructor
    Public Sub New()



    End Sub

    '::::::::::::::::::::::::::::: METODOS SET Y GET ::::::::::::::::::::::::::::::

    'Codigo de Deposito
    Public Property Cod As Integer
        Get
            Return codDeposito
        End Get
        Set(value As Integer)
            codDeposito = value
        End Set
    End Property

    'banco
    Public Property Banc_o As String
        Get
            Return banco
        End Get
        Set(value As String)
            banco = value
        End Set
    End Property

    'Codigo de Cajero
    Public Property cod_Cajero As String
        Get
            Return codCajero
        End Get
        Set(value As String)
            codCajero = value
        End Set
    End Property

    'tipoDeposito
    Public Property Tipo_Deposito As String
        Get
            Return tipoDeposito
        End Get
        Set(value As String)
            tipoDeposito = value
        End Set
    End Property

    'Comentario
    Public Property Comenta_rio As String
        Get
            Return comentario
        End Get
        Set(value As String)
            comentario = value
        End Set
    End Property

    'Moneda
    Public Property Mone_da As String
        Get
            Return moneda
        End Get
        Set(value As String)
            moneda = value
        End Set
    End Property

    'Tipo Contado
    Public Property Tipo_Contado As String
        Get
            Return TipoContado
        End Get
        Set(value As String)
            TipoContado = value
        End Set
    End Property

    'Codigo Forma de Pago
    Public Property Cod_FormaPago As Integer
        Get
            Return codFormapago
        End Get
        Set(value As Integer)
            codFormapago = value
        End Set
    End Property
    'MonBase
    Public Property mon_base As Double
        Get
            Return monBase
        End Get
        Set(value As Double)
            monBase = value
        End Set
    End Property
    'totalDepositado
    Public Property total_Depositado As Double
        Get
            Return totalDepositado
        End Get
        Set(value As Double)
            totalDepositado = value
        End Set
    End Property
    'contado
    Public Property conta_do As Double
        Get
            Return contado
        End Get
        Set(value As Double)
            contado = value
        End Set
    End Property
    'fecha
    Public Property Fech_a As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property
    'Comision
    Public Property comisi_on As Double
        Get
            Return comision
        End Get
        Set(value As Double)
            comision = value
        End Set
    End Property


    '::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO ::::::::::::::::::::::::::::::
    'Registrar Nuevo Deposito
    Public Function registrarNuevoDeposito() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarDeposito"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha"
        sqlpar.Value = Fech_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco"
        sqlpar.Value = Banc_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contado"
        sqlpar.Value = conta_do
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "TipoContado"
        sqlpar.Value = Tipo_Contado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "totalDeposito"
        sqlpar.Value = total_Depositado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda"
        sqlpar.Value = Mone_da
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "monBase"
        sqlpar.Value = mon_base
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comision"
        sqlpar.Value = comisi_on
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comenta_rio
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoDeposito"
        sqlpar.Value = Tipo_Deposito
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCajero"
        sqlpar.Value = cod_Cajero
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFormaPago"
        sqlpar.Value = Cod_FormaPago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion
        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("Salida").Value

        Return par_sal

    End Function
    'Listar todos los depositos
    Public Function listarDepositos() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmListarDepositos_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Buscar deposito por codigo del deposito
    Public Function buscarDepositoXCod() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarDeposito_A"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Cod
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Buscar deposito por tipo del deposito
    Public Function buscarDepositoXTipoDepo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarDepositoXTipoDepo_A"
            cmd.Parameters.Add("@tipoDeposito", SqlDbType.VarChar).Value = Tipo_Deposito
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function
    'Buscar deposito por Codigo de banco
    Public Function buscarDepositoXBanco() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarDepositoXBanco_A"
            cmd.Parameters.Add("@banco", SqlDbType.VarChar).Value = Banc_o
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Modificar datos de deposito
    Public Function modificarDeposito() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmActualizarDeposito_A"

        'VARIABLES
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codDeposito"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha"
        sqlpar.Value = Fech_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco"
        sqlpar.Value = Banc_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "contado"
        sqlpar.Value = conta_do
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "TipoContado"
        sqlpar.Value = Tipo_Contado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "totalDeposito"
        sqlpar.Value = total_Depositado
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "moneda"
        sqlpar.Value = Mone_da
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "monBase"
        sqlpar.Value = mon_base
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comision"
        sqlpar.Value = comisi_on
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comenta_rio
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoDeposito"
        sqlpar.Value = Tipo_Deposito
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCajero"
        sqlpar.Value = cod_Cajero
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFormaPago"
        sqlpar.Value = Cod_FormaPago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion
        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

End Class
