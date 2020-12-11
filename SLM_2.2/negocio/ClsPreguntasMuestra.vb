
Imports System.Data.SqlClient

Public Class ClsPreguntasMuestra

    Dim codPregunta, codMuestra As Integer
    Dim estado As Boolean
    Dim enunciado, nota As String
    'Constructor
    Public Sub New()

    End Sub
    'Métodos GET y SET
    Public Property codPregunta_ As Integer
        Get
            Return codPregunta
        End Get
        Set(value As Integer)
            codPregunta = value
        End Set
    End Property
    Public Property codMuestra_ As Integer
        Get
            Return codMuestra
        End Get
        Set(value As Integer)
            codMuestra = value
        End Set
    End Property
    Public Property estado_ As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property
    Public Property enunciado_ As String
        Get
            Return enunciado
        End Get
        Set(value As String)
            enunciado = value
        End Set
    End Property
    Public Property nota_ As String
        Get
            Return nota
        End Get
        Set(value As String)
            nota = value
        End Set
    End Property
    Public Function RegistrarNuevaPreguntaMuestra() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarPreguntasMuestra"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codMuestra" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codMuestra_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enunciado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = enunciado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nota" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nota_
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
    Public Function ModificarPreguntasMuestra() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarPreguntasMuestra"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codPregunta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codPregunta_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codMuestra" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codMuestra_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "enunciado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = enunciado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "estado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = estado_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "nota" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = nota_
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
    Public Function EliminarPreguntaMuestra() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmEliminarPreguntasMuestra"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codPregunta" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codPregunta_
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

    Public Function BuscarPreguntasMuestraCodMuestra() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarPreguntasMuestraCodigoTomaMuestra"
            cmd.Parameters.Add("@codMuestra", SqlDbType.Int).Value = codMuestra_
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

