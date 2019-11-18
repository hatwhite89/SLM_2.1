﻿Imports System.Data.SqlClient
Public Class ClsCategoriaProveedor

    'Variables 
    Dim codCatProveedor, CtaAcreedores, CtaAnticipos As Integer
    Dim codigo, Descripcion As String
    'Constructor
    Public Sub New()

    End Sub
    '::::::::::::::::::::::::: Metodos SET y GET ::::::::::::::::::::::::::::::::::

    'Codigo de Categoria
    Public Property Cod As Integer
        Get
            Return codCatProveedor
        End Get
        Set(value As Integer)
            codCatProveedor = value
        End Set
    End Property

    'Cuenta Acreedores
    Public Property Cta_Acreedor As Integer
        Get
            Return Cta_Acreedor
        End Get
        Set(value As Integer)
            CtaAcreedores = value
        End Set
    End Property

    'Cuenta Anticipos
    Public Property Cta_Anticipos As Integer
        Get
            Return CtaAnticipos
        End Get
        Set(value As Integer)
            CtaAnticipos = value
        End Set
    End Property

    'Descripcion
    Public Property Descripcio_n As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    'Codigo
    Public Property Codig_o As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property
    ':::::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::::::::::

    'Registrar nueva categoria
    Public Function registrarNuevaCategoria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarCategoria_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo"
        sqlpar.Value = Codig_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAcreedores"
        sqlpar.Value = Cta_Acreedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAnticipo"
        sqlpar.Value = Cta_Anticipos
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

    'Modificar Categoria
    Public Function modificarNuevaCategoria() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmActualizarCategoria_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo"
        sqlpar.Value = Codig_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcio_n
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAcreedores"
        sqlpar.Value = Cta_Acreedor
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ctaAnticipo"
        sqlpar.Value = Cta_Anticipos
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
