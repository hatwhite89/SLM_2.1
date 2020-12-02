
Imports System.Data.SqlClient
Public Class ClsPago

    'Variables
    Dim codPago, codformapago As Integer
    Dim referencia, comentario, sumaTotal As String
    Dim fechaPago, fechaTransferencia As Date
    Dim pagado As Boolean

    'Constructor
    Public Sub New()

    End Sub


    '::::::::::::::::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::::::::::

    'Codigo de Pago
    Public Property Cod_Pago As Integer
        Get
            Return codPago
        End Get
        Set(value As Integer)
            codPago = value
        End Set
    End Property

    'Forma de Pago
    Public Property codForma_Pago As Integer
        Get
            Return codformapago
        End Get
        Set(value As Integer)
            codformapago = value
        End Set
    End Property

    'Referencia
    Public Property Referenci_a As String
        Get
            Return referencia
        End Get
        Set(value As String)
            referencia = value
        End Set
    End Property

    'Comentario
    Public Property Comentari_o As String
        Get
            Return comentario
        End Get
        Set(value As String)
            comentario = value
        End Set
    End Property


    'Suma Total
    Public Property Suma_Total As String
        Get
            Return sumaTotal
        End Get
        Set(value As String)
            sumaTotal = value
        End Set
    End Property

    'Fecha de Pago
    Public Property Fecha_Pago As Date
        Get
            Return fechaPago
        End Get
        Set(value As Date)
            fechaPago = value
        End Set
    End Property

    'Fecha Transferencia
    Public Property Fecha_transfer As Date
        Get
            Return fechaTransferencia
        End Get
        Set(value As Date)
            fechaTransferencia = value
        End Set
    End Property

    'Estado Pagado
    Public Property Paga_do As Boolean
        Get
            Return pagado
        End Get
        Set(value As Boolean)
            pagado = value
        End Set
    End Property


    '::::::::::::::::::::::::::::::::::: Funciones de Mantenimiento :::::::::::::::::::::::::::::::::::
    'Registrar nuevo pago
    Public Function registrarNuevoPago() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarPago"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codformaPago"
        sqlpar.Value = codForma_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "referencia"
        sqlpar.Value = Referenci_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaPago"
        sqlpar.Value = Fecha_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaTransferencia"
        sqlpar.Value = Fecha_transfer
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pagado"
        sqlpar.Value = Paga_do
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sumaTotal"
        sqlpar.Value = Suma_Total
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "ID"
        sqlpar.Value = ""
        sqlcom.Parameters.Add(sqlpar)

        sqlpar.Direction = ParameterDirection.Output

        Dim con As New ClsConnection
        sqlcom.Connection = con.getConexion

        sqlcom.ExecuteNonQuery()

        con.cerrarConexion()

        par_sal = sqlcom.Parameters("ID").Value

        Return par_sal

    End Function

    'Listar Pagos
    Public Function listarPagosOk() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmPagosok", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Buscar pago por codigo
    Public Function buscarPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarPago"
            cmd.Parameters.Add("@codPago", SqlDbType.Int).Value = Cod_Pago
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function listarSinPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmPagossinOk", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Modificar Pago
    Public Function modificarPago() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarPagos"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codPago"
        sqlpar.Value = Cod_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "formaPago"
        sqlpar.Value = codForma_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "referencia"
        sqlpar.Value = Referenci_a
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "comentario"
        sqlpar.Value = Comentari_o
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaPago"
        sqlpar.Value = Fecha_Pago
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaTransferencia"
        sqlpar.Value = Fecha_transfer
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "pagado"
        sqlpar.Value = Paga_do
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sumaTotal"
        sqlpar.Value = Suma_Total
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
