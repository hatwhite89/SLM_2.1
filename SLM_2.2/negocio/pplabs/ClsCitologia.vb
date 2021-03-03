

Imports System.Data.SqlClient


Public Class ClsCitologia

	':::::::::: VARIABLES
	Dim id_citologia, id_identificador_cito, id_firma1, id_firma2, numero_factura As Integer
	Dim deteccion_cancer, indice_maduracion, sin_nota_citologia As Boolean
	Dim FUR, FUP, fecha_muestra1, fecha_muestra2 As Date
	Dim otrosA, diagnostico, gravida, para, aborto, otros2 As String

    Public Sub New()



    End Sub

    ':::::::::: METODOS SET Y GET
    Public Property OTROS2_ As String
        Get
            Return otros2
        End Get
        Set(value As String)
            otros2 = value
        End Set
    End Property

    Public Property ABORTO_ As String
        Get
            Return aborto
        End Get
        Set(value As String)
            aborto = value
        End Set
    End Property

    Public Property PARA_ As String
        Get
            Return para
        End Get
        Set(value As String)
            para = value
        End Set
    End Property

    Public Property GRAVIDAD As String
        Get
            Return gravida
        End Get
        Set(value As String)
            gravida = value
        End Set
    End Property

    Public Property DIAGNOSTICO_ As String
        Get
            Return diagnostico
        End Get
        Set(value As String)
            diagnostico = value
        End Set
    End Property

    Public Property OTROSA_ As String
        Get
            Return otrosA
        End Get
        Set(value As String)
            otrosA = value
        End Set
    End Property

    Public Property FECHAMUESTRA2 As Date
        Get
            Return fecha_muestra2
        End Get
        Set(value As Date)
            fecha_muestra2 = value
        End Set
    End Property

    Public Property FECHAMUESTRA1 As Date
        Get
            Return fecha_muestra1
        End Get
        Set(value As Date)
            fecha_muestra1 = value
        End Set
    End Property

    Public Property FUP_ As Date
        Get
            Return FUP
        End Get
        Set(value As Date)
            FUP = value
        End Set
    End Property

    Public Property FUR_ As Date
        Get
            Return FUR
        End Get
        Set(value As Date)
            FUR = value
        End Set
    End Property

    Public Property SIN_NOTA As Boolean
        Get
            Return sin_nota_citologia
        End Get
        Set(value As Boolean)
            sin_nota_citologia = value
        End Set
    End Property

    Public Property INDICE_MADURACION_ As Boolean
        Get
            Return indice_maduracion
        End Get
        Set(value As Boolean)
            indice_maduracion = value
        End Set
    End Property

    Public Property DETECCION_CANCER_ As Boolean
        Get
            Return deteccion_cancer
        End Get
        Set(value As Boolean)
            deteccion_cancer = value
        End Set
    End Property

    Public Property IDCITOLOGIA As Integer
        Get
            Return id_citologia
        End Get
        Set(value As Integer)
            id_citologia = value
        End Set
    End Property

    Public Property IDIDENTIFICADORCITO As Integer
        Get
            Return id_identificador_cito
        End Get
        Set(value As Integer)
            id_identificador_cito = value
        End Set
    End Property

    Public Property IDFIRMA1 As Integer
        Get
            Return id_firma1
        End Get
        Set(value As Integer)
            id_firma1 = value
        End Set
    End Property

    Public Property IDFIRMA2 As Integer
        Get
            Return id_firma2
        End Get
        Set(value As Integer)
            id_firma2 = value
        End Set
    End Property

    Public Property NUM_FACTURA As Integer
        Get
            Return numero_factura
        End Get
        Set(value As Integer)
            numero_factura = value
        End Set
    End Property


    ':::::::::: FUNCIONES DE MANTENIMIENTO

    Public Function NUEVOREGISTRO() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTENIMIENTO_CITOLOGIA"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero_factura" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NUM_FACTURA
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "otrosA" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = OTROSA_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "deteccion_cancer" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = DETECCION_CANCER_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "indice_maduracion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = INDICE_MADURACION_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "diagnostico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = DIAGNOSTICO_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "FUR" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FUR_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "FUP" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FUP_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "gravida" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = GRAVIDAD
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "para" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = PARA_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "aborto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ABORTO_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_identificador_cito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDIDENTIFICADORCITO
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_firma1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDFIRMA1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_muestra1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FECHAMUESTRA1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_firma2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDFIRMA2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_muestra2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FECHAMUESTRA2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sin_nota_citologia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = SIN_NOTA
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "otros2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = OTROS2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = 1
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

    Public Function MODIFICARREGISTRO() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "MANTENIMIENTO_CITOLOGIA"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_citologia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDCITOLOGIA
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "numero_factura" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = NUM_FACTURA
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "otrosA" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = OTROSA_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "deteccion_cancer" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = DETECCION_CANCER_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "indice_maduracion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = INDICE_MADURACION_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "diagnostico" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = DIAGNOSTICO_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "FUR" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FUR_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "FUP" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FUP_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "gravida" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = GRAVIDAD
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "para" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = PARA_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "aborto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = ABORTO_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_identificador_cito" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDIDENTIFICADORCITO
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_firma1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDFIRMA1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_muestra1" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FECHAMUESTRA1
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_firma2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = IDFIRMA2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "fecha_muestra2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = FECHAMUESTRA2
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "sin_nota_citologia" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = SIN_NOTA
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "otros2" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = OTROS2_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "accion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = 2
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

    Public Function ELIMINARREGISTRO() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTENIMIENTO_CITOLOGIA"
            cmd.Parameters.Add("@id_citologia", SqlDbType.Int).Value = IDCITOLOGIA
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = 3
            cmd.Parameters.Add("@salida", SqlDbType.Int).Value = ""

            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function LISTARREGISTROS() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "MANTENIMIENTO_CITOLOGIA"
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("@salida", SqlDbType.VarChar).Value = ""

            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    objCon.cerrarConexion()
                    Return dt
                End Using
            End Using
        End Using

    End Function







End Class
