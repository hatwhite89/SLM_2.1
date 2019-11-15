
Imports System.Data.SqlClient
Public Class ClsFormaPago
    'GUARDAR CAMBIOS
    'VARIABLES DE FORMA DE PAGO
    Dim codigo, comentario, nombreBanco, formulario, tipo, banco As String
    Dim cuenta, nroCtaBanco, codFormaPago As Integer
    Dim comision, retencion As Double
    'Constructor
    Public Sub New()

    End Sub

    '::::::::::::::::::::::::::::: METODOS SET Y GET ::::::::::::::::::::::::::::::

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
    'Codigo Forma Pago
    Public Property Codigo_FormaPago As Integer
        Get
            Return codFormaPago
        End Get
        Set(value As Integer)
            codFormaPago = value
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
    'Retencion
    Public Property Retenci_on As Double
        Get
            Return retencion
        End Get
        Set(value As Double)
            retencion = value
        End Set
    End Property

    '::::::::::::::::::::::::::::: FUNCIONES DE MANTENIMIENTO ::::::::::::::::::::::::::::::

    'Guardar una nueva forma de pago
    Public Function RegistrarNuevaFormaPago() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmInsertarFormaPago_A"

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
        sqlpar.Value = comision
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "retencion"
        sqlpar.Value = Retenci_on
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

    'Funcion para buscar codigo de banco
    Public Function buscarCodigoFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarCodigoFormaPago_A"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Cod
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Funcion para listar las formas de pago
    Public Function listarFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmListarFormasPago_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    'Buscar Forma de Pago
    Public Function buscarCodFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmBuscarCodFormaPago_A"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Cod
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function
    'Capturar comision de forma de pago
    Public Function capturarComision() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmCapturarComision_A"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Cod
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Eliminar Forma de Pago
    Public Function eliminarFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "slmEliminarFormaPago_A"
            cmd.Parameters.Add("@codFormaPago", SqlDbType.VarChar).Value = Codigo_FormaPago
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    'Mostrar informacion completa formas de pago
    Public Function informacionFormasPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmInformacionFormaPago_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Modificar forma de pago
    Public Function modificarFormaPago() As String


        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "slmActualizarFormaPago_A"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codFormaPago"
        sqlpar.Value = Codigo_FormaPago
        sqlcom.Parameters.Add(sqlpar)

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
        sqlpar.Value = comision
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "retencion"
        sqlpar.Value = Retenci_on
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

    'Mostrar data de formas de pago
    Public Function mostrarFormasPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("slmMostrarFormaPago_A", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
