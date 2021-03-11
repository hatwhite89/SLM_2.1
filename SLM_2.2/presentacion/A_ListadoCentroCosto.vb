Public Class A_ListadoCentroCosto

    Dim objcc As New ClsCentroCostos


    Private Sub A_ListadoCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dgvListado)
            Dim dt As New DataTable
            Dim row As DataRow

            dt = objcc.ListarCentrodeCosto

            For i = 0 To dt.Rows.Count - 1

                row = dt.Rows(i)

                dgvListado.Rows.Add(CStr(row("id_centrocosto")), row("codBreve"), row("nombre"))

            Next

        Catch ex As Exception

        End Try

    End Sub

End Class