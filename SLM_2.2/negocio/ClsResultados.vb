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
End Class
