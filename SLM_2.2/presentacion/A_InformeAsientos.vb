Public Class A_InformeAsientos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim informe As New ClsAsientoContable

            Dim fechaDesde, fechaHasta As Date
            Dim dt As New DataTable
            Dim row As DataRow


            fechaDesde = dtpDesde.Value
            fechaHasta = dtpHasta.Value

            dt = informe.InformeDeAsientos(fechaDesde, fechaHasta)

            For i = 0 To dt.Rows.Count - 1
                row = dt.Rows(i)
                Dim tipo As String = LTrim(RTrim(CStr(row("tipoCuenta"))))
                dgvData.Rows.Add(New String() {(row("campoLlave")), (row("origen")), CStr(row("fecha")), CStr(row("descripcion")), CStr(row("cuenta")), CStr(row("debe")), CStr(row("haber")), tipo})

            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            E_frmInventario.GridAExcel(dgvData)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub A_InformeAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alternarColoFilasDatagridview(dgvData)
        Catch ex As Exception

        End Try
    End Sub
End Class