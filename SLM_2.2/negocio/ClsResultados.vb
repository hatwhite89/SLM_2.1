Imports System.Data.SqlClient

Public Class ClsResultados
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

    Public Function RecuperarToleranciaInsulina() As DataTable

        Dim objCon As New ClsConnection
        Dim cn As New SqlConnection
        cn = objCon.getConexion

        Using da As New SqlDataAdapter("select i.codigo,h.hora, ot.cod_orden_trabajo,ie.descripcion,i.nombre,
SUBSTRING (ot.resultado, 0, Len(ot.resultado) - 1 ) as resultado  from OrdenTrabajoDetalle ot, ItemExamenDetalle i,Item_Examenes ie,HorasParametros h
where ot.cod_item_examen_detalle = i.codigo and ie.codItemExa = i.codigoItemExamen
and i.codigo = h.id_parametro
and ot.cod_orden_trabajo =1203 
order by h.hora", cn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        End Using
    End Function
End Class
