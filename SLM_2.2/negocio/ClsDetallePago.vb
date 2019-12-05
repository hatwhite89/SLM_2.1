﻿

Imports System.Data.SqlClient

Public Class ClsDetallePago

    'Variables
    Dim codDetalle, codPago, codFactura As Integer
    Dim formaPago, nroCheque As String

    'Constructor
    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::: METODOS SET Y GET ::::::::::::::::::::::::::::::
    'Numero de Cheque
    Public Property Nro_Cheque As String
        Get
            Return nroCheque
        End Get
        Set(value As String)
            nroCheque = value
        End Set
    End Property

    'forma pago
    Public Property Forma_Pago As String
        Get
            Return formaPago
        End Get
        Set(value As String)
            formaPago = value
        End Set
    End Property

    'codigo detalle
    Public Property Cod_Detalle As Integer
        Get
            Return codDetalle
        End Get
        Set(value As Integer)
            codDetalle = value
        End Set
    End Property

    'codigo pago
    Public Property Cod_Pago As Integer
        Get
            Return codPago
        End Get
        Set(value As Integer)
            codPago = value
        End Set
    End Property

    'codigo factura
    Public Property Cod_Factura As Integer
        Get
            Return codFactura
        End Get
        Set(value As Integer)
            codFactura = value
        End Set
    End Property

    '::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO ::::::::::::::::::::::::::::::

    'Guardar una nueva forma de pago
    Public Function registrarDetallePago() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDetallePago"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codPago"
        sqlpar.Value = Cod_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFactura"
        sqlpar.Value = Cod_Factura
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "formaPago"
        sqlpar.Value = Forma_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nroCheque"
        sqlpar.Value = Nro_Cheque
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





End Class
