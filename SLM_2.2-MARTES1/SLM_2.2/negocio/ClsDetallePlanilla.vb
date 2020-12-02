Imports System.Data.SqlClient

Public Class ClsDetallePlanilla

    Dim codDetPlanilla, codPlanilla, codEmpleado As Integer
    'Constructor
    Public Sub New()

    End Sub
    Public Property codDetPlanilla_ As Integer
        Get
            Return codDetPlanilla
        End Get
        Set(value As Integer)
            codDetPlanilla = value
        End Set
    End Property

    Public Property codPlanilla_ As Integer
        Get
            Return codPlanilla
        End Get
        Set(value As Integer)
            codPlanilla = value
        End Set
    End Property

    Public Property codEmpleado_ As Integer
        Get
            Return codEmpleado
        End Get
        Set(value As Integer)
            codEmpleado = value
        End Set
    End Property

    Public Function RegistrarNuevoDetallePlanilla() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmInsertarDetallePlanilla"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codPlanilla" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codPlanilla_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codEmpleado_
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

    Public Function ActualizarDetallePlanilla() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmActualizarDetallePlanilla"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codDetPlanilla" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codDetPlanilla_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codPlanilla" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codPlanilla_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codEmpleado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codEmpleado_
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

    Public Function EliminarDetallePlanilla() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "A_slmEliminarDetallePlanilla"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codDetPlanilla" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codDetPlanilla_
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
    Public Function BuscarDetallePlanilla() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "A_slmBuscarDetallePlanilla"
            cmd.Parameters.Add("@codPlanilla", SqlDbType.Int).Value = codPlanilla_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using

    End Function

    Public Function SeleccionarDetallePlanilla() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("A_slmSeleccionarDetallePlanilla", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            objCon.cerrarConexion()
            Return dt
        End Using
    End Function


End Class
