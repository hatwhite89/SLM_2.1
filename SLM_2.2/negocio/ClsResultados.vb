Imports System.Data.SqlClient

Public Class ClsResultados
    Private id_orden As String

    Public Property Id_orden1 As String
        Get
            Return id_orden
        End Get
        Set(value As String)
            id_orden = value
        End Set
    End Property

    Public Function RecuperarListadoFacturas(ByVal id_factura) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "exec M_slmReporteResultadoFactura " + id_factura + ""
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

    Public Function RecuperarListadoFacturasPorID(ByVal identidad) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "exec E_slmReporteResultadoID " + "'" + identidad + "'" + ""
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function

    Public Function RecuperarToleranciaInsulina(ByVal id_orden As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select i.codigo,h.hora, ot.cod_orden_trabajo,ie.descripcion,i.nombre,
SUBSTRING (ot.resultado, 0, Len(ot.resultado) - 1 ) as resultado  from OrdenTrabajoDetalle ot, ItemExamenDetalle i,Item_Examenes ie,HorasParametros h
where ot.cod_item_examen_detalle = i.codigo and ie.codItemExa = i.codigoItemExamen
and i.codigo = h.id_parametro
and ot.cod_orden_trabajo ='" + id_orden + "' 
order by h.hora", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

    'Public Function RecuperarExamenGraficable(ByVal id_orden As String) As String
    '    Dim sqlcom As SqlCommand
    '    sqlcom = New SqlCommand
    '    sqlcom.CommandText = "exec E_slmExamenGraficoExiste " + id_orden + ""
    '    sqlcom.Connection = New ClsConnection().getConexion
    '    Return sqlcom.ExecuteScalar
    'End Function

    Public Function RecuperarExamenGraficable() As String
        Dim sqlcom As SqlCommand
        Dim sqlpar As SqlParameter
        Dim par_sal As Integer

        sqlcom = New SqlCommand
        sqlcom.CommandType = CommandType.StoredProcedure
        sqlcom.CommandText = "E_slmExamenGraficoExiste"

        sqlpar = New SqlParameter
        sqlpar.ParameterName = "id_examen" 'nombre campo en el procedimiento almacenado 
        sqlpar.Value = Id_orden1
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

    Public Function ListarResultadosEnviados(ByVal cod As String) As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select distinct e.id_orden,f.numero,c.nombreCompleto,f.fechaFactura 
from   ExamenValidado e, OrdenDeTrabajo o, factura f,Cliente c, Item_Examenes ie,ItemExamenDetalle id,OrdenTrabajoDetalle otd
where f.numero = o.cod_factura
and e.id_orden = o.cod_orden_trabajo
and c.codigo = f.codigoCliente
and otd.cod_orden_trabajo = o.cod_orden_trabajo
and ie.codItemExa = id.codigoItemExamen
and otd.cod_item_examen_detalle = id.codigo
and f.numero = '" + cod + "'", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function

End Class
