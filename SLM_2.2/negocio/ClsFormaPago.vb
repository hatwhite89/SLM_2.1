
Imports System.Data.SqlClient
Public Class ClsFormaPago

    'VARIABLES DE FORMA DE PAGO
    Dim codigo, comentario, nombreBanco, formulario, tipo, banco, cuenta, nroCtaBanco As String
    Dim codFormaPago As Integer
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
    Public Property Cuen_ta As String
        Get
            Return cuenta
        End Get
        Set(value As String)
            cuenta = value
        End Set
    End Property

    'Numero de Cuenta de Banco
    Public Property Cuenta_Banco As String
        Get
            Return nroCtaBanco
        End Get
        Set(value As String)
            nroCtaBanco = value
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
        sqlcom.CommandText = "A_slmInsertarFormaPago"

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

    'Funcion para buscar codigo de banco
    Public Function buscarCodigoFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarCodigoFormaPago"
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

        Using da As New SqlDataAdapter("A_slmListarFormasPago", cn)
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
            cmd.CommandText = "A_slmBuscarCodFormaPago"
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

    'Buscar Forma de Pago por codFormaPago
    Public Function buscarFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarFormaPago"
            cmd.Parameters.Add("@codFormaPago", SqlDbType.Int).Value = Codigo_FormaPago
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
            cmd.CommandText = "A_slmEliminarFormaPago"
            cmd.Parameters.Add("@codFormaPago", SqlDbType.Int).Value = Codigo_FormaPago
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

        Using da As New SqlDataAdapter("A_slmInformacionFormaPago", cn)
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
        sqlcom.CommandText = "A_slmActualizarFormaPago"

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

    'Mostrar data de formas de pago
    Public Function mostrarFormasPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmMostrarFormaPago", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Capturar numero de cuenta de banco
    Public Function numerodeCuenta() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmCapturarNumeroCtaFormaPago"
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

    'Capturar toda informacion por codigo de forma de pago
    Public Function infoFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmInfoFormaPagoxCod"
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

    'Capturar informacion de forma de pago por codigo numerico
    Public Function ctaBancoXBanco() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmCtaBancoXBanco"
            cmd.Parameters.Add("@banco", SqlDbType.VarChar).Value = Ban_co
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function BusquedaFormaPago() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarFormaPagoxCod"
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Codigo_FormaPago
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function


End Class
