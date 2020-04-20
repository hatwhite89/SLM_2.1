Public Class A_ListarCAI

    Dim cai As New ClsCAI
    Private Sub A_ListarCAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtCAIS.DataSource = cai.listarCAI


        Catch ex As Exception

        End Try


    End Sub

    Private Sub dtCAIS_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtCAIS.CellMouseDoubleClick

        Try

            Dim dt As New DataTable
            dt = dtCAIS.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)

            With M_CAI
                .mtxtCAI.Text = row("CAI")
                .dtpDesdeFecha.Value = row("desdeFecha")
                .dtpHastaFecha.Value = row("hastaFecha")
                .mtxtdesde.Text = row("desde")
                .mtxthasta.Text = row("hasta")
                .mtxtserie.Text = row("serie")
                .txtcodigoMaquina.Text = row("codigoMaquinaLocal")
                .chkEstado.Checked = row("estado")
                .Show()
            End With


        Catch ex As Exception

        End Try



    End Sub
End Class