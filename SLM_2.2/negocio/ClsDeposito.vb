Imports System.Data.SqlClient
Public Class ClsDeposito
    'VARIABLES
    Dim TipoContado, moneda, comentario, tipoDeposito, codCajero, banco As String
    Dim contado, totalDepositado, monBase, codFormapago As Integer
    Dim fecha As Date
    Dim comision As Decimal

    'Constructor
    Public Sub New()



    End Sub
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
    Public Property mon_base As Integer
        Get
            Return monBase
        End Get
        Set(value As Integer)
            monBase = value
        End Set
    End Property
    'totalDepositado
    Public Property total_Depositado As Integer
        Get
            Return totalDepositado
        End Get
        Set(value As Integer)
            totalDepositado = value
        End Set
    End Property
    'contado
    Public Property conta_do As Integer
        Get
            Return contado
        End Get
        Set(value As Integer)
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
    Public Property comisi_on As Decimal
        Get
            Return comision
        End Get
        Set(value As Decimal)
            comision = value
        End Set
    End Property

    Public Function RegistrarNuevoPaciente() As String
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

        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("Salida").Value

        Return par_sal

    End Function



End Class
