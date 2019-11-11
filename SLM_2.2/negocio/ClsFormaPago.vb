
Imports System.Data.SqlClient
Public Class ClsFormaPago
    'GUARDAR CAMBIOS
    'VARIABLES DE FORMA DE PAGO
    Dim codigo, comentario, nombreBanco, formulario, tipo, banco As String
    Dim cuenta, nroCtaBanco As Integer
    Dim comision As Double
    'Constructor
    Public Sub New()

    End Sub

    'METODOS SET Y GET DE VARIABLES

    'codigo
    Public Property Cod As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
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

    'Nombre de Banco
    Public Property Nombre_Banco As String
        Get
            Return nombreBanco
        End Get
        Set(value As String)
            nombreBanco = value
        End Set
    End Property

    'formulario
    Public Property Formu_lario As String
        Get
            Return formulario
        End Get
        Set(value As String)
            formulario = value
        End Set
    End Property

    'Tipo
    Public Property Ti_po As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    'Banco
    Public Property Ban_co As String
        Get
            Return banco
        End Get
        Set(value As String)
            banco = value
        End Set
    End Property

    'Cuenta
    Public Property Cuen_ta As Integer
        Get
            Return cuenta
        End Get
        Set(value As Integer)
            cuenta = value
        End Set
    End Property

    'Numero de Cuenta de Banco
    Public Property Cuenta_Banco As Integer
        Get
            Return nroCtaBanco
        End Get
        Set(value As Integer)
            nroCtaBanco = value
        End Set
    End Property

    'Comision
    Public Property Comi_sion As Double
        Get
            Return comision
        End Get
        Set(value As Double)
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
        sqlcom.CommandText = "slmInsertarFormaPago"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuen_ta
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comenta_rio
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroCtaBanco"
        sqlpar.Value = Cuenta_Banco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreBanco"
        sqlpar.Value = Nombre_Banco
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "formulario"
        sqlpar.Value = Formu_lario
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipo"
        sqlpar.Value = Ti_po
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "banco"
        sqlpar.Value = Ban_co
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comision"
        sqlpar.Value = 1.5
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
