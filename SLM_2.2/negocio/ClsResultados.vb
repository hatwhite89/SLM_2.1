﻿Imports System.Data.SqlClient

Public Class ClsResultados
    Public Function RecuperarListadoFacturas(ByVal id_factura) As SqlDataReader
        Dim sqlcom As SqlCommand
        sqlcom = New SqlCommand
        sqlcom.CommandText = "exec M_slmReporteEncabecadoResultado " + id_factura + ""
        sqlcom.Connection = New ClsConnection().getConexion
        Return sqlcom.ExecuteReader
    End Function
End Class
