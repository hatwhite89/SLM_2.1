Imports System.Data.SqlClient
Public Class ClsProveedor

    Dim codProveedor As Integer
    Dim codBreve, nombreProveedor, telefono, email, direccion, sitioweb As String

    'Constructor
    Public Sub New()

    End Sub

    ':::::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::
    'Codigo Proveedor
    Public Property Cod_Proveedor As String
        Get
            Return codProveedor
        End Get
        Set(value As String)
            codProveedor = value
        End Set
    End Property

    'codBreve
    Public Property Cod_Breve As String
        Get
            Return codBreve
        End Get
        Set(value As String)
            codBreve = value
        End Set
    End Property

    'nombreProveedor
    Public Property Nombre_Proveedor As String
        Get
            Return nombreProveedor
        End Get
        Set(value As String)
            nombreProveedor = value
        End Set
    End Property

    'telefono
    Public Property Telefo_no As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    'email
    Public Property Emai_l As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    'direccion
    Public Property Direcci_on As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'Sitio Web
    Public Property Sitio_Web As String
        Get
            Return sitioweb
        End Get
        Set(value As String)
            sitioweb = value
        End Set
    End Property

    ':::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::

    'Guardar nuevo registro de Proveedor
    Public Function registrarNuevoProveedor() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarProveedor_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Cod_Breve
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono"
        sqlpar.Value = Telefo_no
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "email"
        sqlpar.Value = Emai_l
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion"
        sqlpar.Value = Direcci_on
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sitioweb"
        sqlpar.Value = Sitio_Web
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

    'Modificar una registro de proveedor
    Public Function ModificarProveedor() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarProveedor_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codProveedor"
        sqlpar.Value = Cod_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codBreve"
        sqlpar.Value = Cod_Breve
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nombreProveedor"
        sqlpar.Value = Nombre_Proveedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "telefono"
        sqlpar.Value = Telefo_no
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "email"
        sqlpar.Value = Emai_l
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "direccion"
        sqlpar.Value = Direcci_on
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sitioweb"
        sqlpar.Value = Sitio_Web
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






End Class
