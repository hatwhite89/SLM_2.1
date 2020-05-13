
Imports System.Data.SqlClient
Public Class ClsDepreciacion

	'Variables
	Dim cod_Depreciacion, tipoDepreciacion As Integer
    Dim descripcion, sede, tipoActivo As String
    Dim costoActivo, valorResidual As Double
	Dim fechaCreacion, fechaCalculo As Date

	'Constructor Depreciacion
	Public Sub New()


    End Sub

    ':::::::::::::::::::::: Metodos SET y GET :::::::::::::::::::::::::::
    'Fecha de Creacion
    Public Property Fecha_Creacion As Date
        Get
            Return fechaCreacion
        End Get
        Set(value As Date)
            fechaCreacion = value
        End Set
    End Property

    'Fecha de Calculo
    Public Property Fecha_Calculo As Date
        Get
            Return fechaCalculo
        End Get
        Set(value As Date)
            fechaCalculo = value
        End Set
    End Property

    'Codigo Depreciacion
    Public Property Cod As Integer
        Get
            Return cod_Depreciacion
        End Get
        Set(value As Integer)
            cod_Depreciacion = value
        End Set
    End Property

    'Tipo Depreciacion
    Public Property Tipo As Integer
        Get
            Return tipoDepreciacion
        End Get
        Set(value As Integer)
            tipoDepreciacion = value
        End Set
    End Property

    'Descripcion
    Public Property Descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    'Sede
    Public Property Sede_ As String
        Get
            Return sede
        End Get
        Set(value As String)
            sede = value
        End Set
    End Property

    'Tipo Activo
    Public Property Tipo_Activo As String
        Get
            Return tipoActivo
        End Get
        Set(value As String)
            tipoActivo = value
        End Set
    End Property

    'Costo Activo
    Public Property Costo_Activo As Double
        Get
            Return costoActivo
        End Get
        Set(value As Double)
            costoActivo = value
        End Set
    End Property

    'Valor Residual
    Public Property Valor_Residual As Double
        Get
            Return valorResidual
        End Get
        Set(value As Double)
            valorResidual = value
        End Set
    End Property

    ':::::::::::::::::::::: Funciones de Mantenimiento ::::::::::::::::::

    'Registrar depreciacion en base de datos
    Public Function registrarDepreciacion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDepreciacion"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sede"
        sqlpar.Value = Sede_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipo"
        sqlpar.Value = Tipo_Activo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "costoActivo"
        sqlpar.Value = Costo_Activo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "valorResidual"
        sqlpar.Value = Valor_Residual
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaCreacion"
        sqlpar.Value = Fecha_Creacion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaCalculo"
        sqlpar.Value = Fecha_Calculo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoDepreciacion"
        sqlpar.Value = Tipo
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


    'Modificar depreciacion en base de datos
    Public Function modificarDepreciacion() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        'PROCEDIMIENTO ALMACENADO
        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDepreciacion"

        'VARIABLES 
        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_Depreciacion"
        sqlpar.Value = Cod
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion"
        sqlpar.Value = Descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sede"
        sqlpar.Value = Sede_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipo"
        sqlpar.Value = Tipo_Activo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "costoActivo"
        sqlpar.Value = Costo_Activo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "valorResidual"
        sqlpar.Value = Valor_Residual
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaCreacion"
        sqlpar.Value = Fecha_Creacion
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fechaCalculo"
        sqlpar.Value = Fecha_Calculo
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "tipoDepreciacion"
        sqlpar.Value = Tipo
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


    'Listar registros de depreciacion
    Public Function listarDepreciacion() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmListarDepreciacion", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
