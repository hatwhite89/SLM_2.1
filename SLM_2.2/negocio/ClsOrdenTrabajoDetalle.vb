Imports System.Data.SqlClient
Public Class ClsOrdenTrabajoDetalle
    Dim resultado As Double
    Dim codigo, cod_orden_trabajo, cod_item_examen_detalle As Integer
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
    Public Property cod_orden_trabajo_ As Integer
        Get
            Return cod_orden_trabajo
        End Get
        Set(value As Integer)
            cod_orden_trabajo = value
        End Set
    End Property
    Public Property cod_item_examen_detalle_ As Integer
        Get
            Return cod_item_examen_detalle
        End Get
        Set(value As Integer)
            cod_item_examen_detalle = value
        End Set
    End Property
    Public Property resultado_ As Double
        Get
            Return resultado
        End Get
        Set(value As Double)
            resultado = value
        End Set
    End Property
    Public Function RegistrarNuevoDetalleOrdenTrabajo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmInsertarOrdenTrabajoDetalle"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_orden_trabajo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_orden_trabajo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_item_examen_detalle" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_item_examen_detalle_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "resultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = resultado_
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
    Public Function ModificarOrdenTrabajo() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmModificarOrdenTrabajo"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "codigo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = codigo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_orden_trabajo" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_orden_trabajo_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "cod_item_examen_detalle" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = cod_item_examen_detalle_
        sqlcom.Parameters.Add(sqlpar)

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "resultado" 'nombre campo en el procedimiento almacenado @
        sqlpar.Value = resultado_
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
    Public Function BuscarOrdenTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarOrdenTrabajo"
            cmd.Parameters.Add("@cod_orden_trabajo", SqlDbType.Int).Value = cod_orden_trabajo_
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Public Function SeleccionarOrdenTrabajo() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("E_slmSeleccionarOrdenTrabajo", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function BuscarOrdenTrabajoCode() As DataTable
        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "E_slmBuscarOrdenTrabajoCode"
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo_
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
