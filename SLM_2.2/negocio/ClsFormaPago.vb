
Imports System.Data.SqlClient
Public Class ClsFormaPago
    'GUARDAR CAMBIOS
    'VARIABLES DE FORMA DE PAGO
    Dim codigo, comentario, nombreBanco, formulario, tipo, banco As String
    Dim cuenta, nroCtaBanco As Integer
    Dim comision As Decimal
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
    Public Property Comi_sion As Decimal
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

        'Seleccion de procedimiento a ejecutar
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "Nombre de Procedimiento"

        'nombre campo en el procedimiento almacenado 
        'sqlpar = New SqlParameter
        'sqlpar.ParameterName = "primer_nombre"
        'sqlpar.Value = Primer_nombre1
        'sqlcom.Parameters.Add(sqlpar)
        'sqlpar = New SqlParameter

        'sqlpar.ParameterName = "segundo_nombre"
        'sqlpar.Value = Segundo_apellido1
        'sqlcom.Parameters.Add(sqlpar)

        'sqlpar = New SqlParameter
        'sqlpar.ParameterName = "primer_apellido"
        'sqlpar.Value = Primer_apellido1
        'sqlcom.Parameters.Add(sqlpar)

        'sqlpar = New SqlParameter
        'sqlpar.ParameterName = "segundo_apellido"
        'sqlpar.Value = Segundo_apellido1
        'sqlcom.Parameters.Add(sqlpar)


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
