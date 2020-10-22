Module Module1
    Public nombre_proveedorOC As String
    Public nombre_usurio As String
    Public codigo_usuario As String
    Public codigo_requisicion As String
    Public codigo_orden_interna As String
    Public nombre_completo As String
    Public departamento_global As String
    Public id_departamento_global As String

    Public Sub CargarDatosGlobales()
        Try
            Dim objP As New ClsUsuario

            Dim dt As New DataTable
            dt = objP.RecuperarUsuariosGlobales
            Dim row As DataRow = dt.Rows(0)
            nombre_completo = CStr(row("nombreCompleto"))
            departamento_global = CStr(row("nombre"))
            id_departamento_global = CStr(row("codigo"))

        Catch ex As Exception

        End Try
    End Sub
End Module
