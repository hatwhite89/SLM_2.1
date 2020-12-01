Imports System.Data.SqlClient

Public Class ClsParametroExamen
    Dim codigo, codigoUnidad As Integer
    Dim codigoParametroExam, descripcion, breve As String
    Dim requiereDet, noCalc As Boolean

    'Constructor
    Public Sub New()

    End Sub
    Public Property codigo_ As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Public Property codigoUnidad_ As Integer
        Get
            Return codigoUnidad
        End Get
        Set(value As Integer)
            codigoUnidad = value
        End Set
    End Property
    Public Property Descripcion_ As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
    Public Property codigoParametroExam_ As String
        Get
            Return codigoParametroExam
        End Get
        Set(value As String)
            codigoParametroExam = value
        End Set
    End Property
    Public Property breve_ As String
        Get
            Return breve
        End Get
        Set(value As String)
            breve = value
        End Set
    End Property
    Public Property requiereDet_ As Boolean
        Get
            Return requiereDet
        End Get
        Set(value As Boolean)
            requiereDet = value
        End Set
    End Property
    Public Property noCalc_ As Boolean
        Get
            Return noCalc
        End Get
        Set(value As Boolean)
            noCalc = value
        End Set
    End Property
    Public Function RegistrarNuevoParametroExamen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarParametroExamen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoParametroExam" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoParametroExam_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "requiereDet" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = requiereDet_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoUnidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoUnidad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "breve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = breve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "noCalc" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = noCalc_
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

    Public Function ModificarParametroExamen() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarParametroExamen"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoParametroExam" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoParametroExam_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "requiereDet" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = requiereDet_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "descripcion" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = Descripcion_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoUnidad" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoUnidad_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "breve" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = breve_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "noCalc" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = noCalc_
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
    Public Function BuscarParametroExamenCode() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarParametroExamenCode"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
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
    Public Function BuscarParametroExamenDescripcion() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarParametroExamenDes"
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Descripcion_
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
    Public Function BuscarParametroExamen() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarParametroExamen"
            cmd.Parameters.Add("@codigoParametroExam", SqlDbType.VarChar).Value = codigoParametroExam_
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

    Public Function SeleccionarParametroExamen() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmSeleccionarParametroExamen", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class