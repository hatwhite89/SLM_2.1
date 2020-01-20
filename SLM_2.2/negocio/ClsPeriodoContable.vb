
Imports System.Data.SqlClient

Public Class ClsPeriodoContable

    Dim fecha_i, fecha_f As Date
    Dim estado As Boolean



    ':::::::::::::::::::::: Constructor ::::::::::::::::::::::
    Public Sub New()

    End Sub


    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Fecha Inicio de periodo
    Public Property Fecha_Inicio As Date
        Get
            Return fecha_i
        End Get
        Set(value As Date)
            fecha_i = value
        End Set
    End Property

    'Fecha Cierre de periodo
    Public Property Fecha_Final As Date
        Get
            Return fecha_f
        End Get
        Set(value As Date)
            fecha_f = value
        End Set
    End Property

    'Estado
    Public Property Estad_o As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property


    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar nuevo periodo contable en base de datos
    Public Function registrarPeriodoContable() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarPeriodoContable"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_i"
        sqlpar.Value = Fecha_Inicio
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_f"
        sqlpar.Value = Fecha_Final
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
        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("salida").Value

        Return par_sal

    End Function

    'Capturar Ultimo Periodo
    Public Function capturarCodPeriodo() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmCapturarPeriodo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using


    End Function





End Class
