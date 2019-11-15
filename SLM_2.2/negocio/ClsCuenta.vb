
Imports System.Data.SqlClient
Public Class ClsCuenta

    'VARIABLES
    Dim nombre, tipoCuenta As String
    Dim codCuenta, cuenta As Integer
    Dim estado As Boolean

    'Constructor
    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::: METODOS SET Y GET ::::::::::::::::::::::::::::::

    'Tipo de Cuenta
    Public Property Tipo_Cuenta As String
        Get
            Return tipoCuenta
        End Get
        Set(value As String)
            tipoCuenta = value
        End Set
    End Property

    'nombre
    Public Property Nombr_e As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    'Cuenta
    Public Property Cuent_a As Integer
        Get
            Return cuenta
        End Get
        Set(value As Integer)
            cuenta = value
        End Set
    End Property

    'Codigo de Cuenta
    Public Property Cod_Cuenta As Integer
        Get
            Return codCuenta
        End Get
        Set(value As Integer)
            codCuenta = value
        End Set
    End Property

    'Estado
    Public Property Esta_do As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    '::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO ::::::::::::::::::::::::::::

    'Registar nueva cuenta en la base de datos
    Public Function registrarNuevaCuenta() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCuenta_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuent_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre"
        sqlpar.Value = Nombr_e
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoCuenta"
        sqlpar.Value = Tipo_Cuenta
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = estado
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

    'Listra todas las cuentas creadas
    Public Function listarCuentas() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmListarCuentas_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Selecciona la cuenta y el nombre de las cuentas creadas
    Public Function seleccionarCuentas() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmSeleccionarCuentas_M", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Editar una cuenta
    Public Function modificarCuenta() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmActualizarCuenta_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codCuenta"
        sqlpar.Value = Cod_Cuenta
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cuenta"
        sqlpar.Value = Cuent_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombre"
        sqlpar.Value = Nombr_e
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoCuenta"
        sqlpar.Value = Tipo_Cuenta
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado"
        sqlpar.Value = Esta_do
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
