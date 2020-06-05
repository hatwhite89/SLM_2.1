Public Class A_ListarCAI

    Dim cai As New ClsCAI
    Private Sub A_ListarCAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtCAIS.DataSource = cai.listarCAI


        Catch ex As Exception

        End Try


    End Sub
    Public Sub actualizarListado()

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
                .lblCodigo.Text = row("codigo")
                .mtxtCAI.Text = row("CAI")
                .dtpDesdeFecha.Value = row("desdeFecha")
                .dtpHastaFecha.Value = row("hastaFecha")
                .mtxtdesde.Text = row("desde")
                .mtxthasta.Text = row("hasta")
                .mtxtserie.Text = row("serie")
                .lblCodeMaquinaLocal.Text = row("codigoMaquinaLocal")
                .chkEstado.Checked = row("estado")
                .Show()
            End With
            'Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            'Me.Close()

            M_CAI.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class