Imports System.Data.SqlClient

Public Class ClsParametroExamenDetalle
    Dim codigo, codigoParametroExam As Integer
    Dim posibleResultado, valPorDefecto As String

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
    Public Property codigoParametroExam_ As Integer
        Get
            Return codigoParametroExam
        End Get
        Set(value As Integer)
            codigoParametroExam = value
        End Set
    End Property
    Public Property posibleResultado_ As String
        Get
            Return posibleResultado
        End Get
        Set(value As String)
            posibleResultado = value
        End Set
    End Property
    Public Property valPorDefecto_ As String
        Get
            Return valPorDefecto
        End Get
        Set(value As String)
            valPorDefecto = value
        End Set
    End Property
    Public Function RegistrarNuevoParametroExamenDetalle() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarParametroExamenDetalle"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoParametroExam" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoParametroExam_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "posibleResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = posibleResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "valPorDefecto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = valPorDefecto_
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

    Public Function ModificarParametroExamenDetalle() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarParametroExamenDetalle"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigoParametroExam" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigoParametroExam_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "posibleResultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = posibleResultado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "valPorDefecto" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = valPorDefecto_
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
    Public Function BuscarParametroExamenDetalle() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarParametroExamenDetalle"
            cmd.Parameters.Add("@codigoParametroExam", SqlDbType.Int).Value = codigoParametroExam_
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

    Public Function SeleccionarParametroExamenDetalle() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmSeleccionarParametroExamenDetalle", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function
End Class