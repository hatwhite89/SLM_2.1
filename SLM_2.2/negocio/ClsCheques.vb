
Imports System.Data.SqlClient
Public Class ClsCheques

    'Variables de Cheque
    Dim codCheque, codChequera As Integer
    Dim nroCheque, moneda, codBreveProve, nombreProveedor, codBreveBanco, nombreBanco, descripcion, estado As String
    Dim monto As Double
    Dim fechaReg, fechaVto As Date

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::::::::::::::::::::::::

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



    ':::::::::::::::::::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO ::::::::::::::::::::::::::::::::::::::::::::::

    'Registar nuevos cheques
    Public Function registrarNuevosCheques() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCheques_A"

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
        sqlpar.ParameterName = "salida"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion
        sqlcom.CommandTimeout = 1000
        sqlcom.ExecuteNonQuery()

        par_sal = sqlcom.Parameters("salida").Value
        Return par_sal

    End Function

    'Modificar cheque

End Class
