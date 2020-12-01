Public Class A_ListadoPerfiles
    Private Sub A_ListadoPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim perfil As New ClsPerfilesUsuario
            dtPerfiles.DataSource = perfil.listarPerfilesHabilitados

            dtPerfiles.Columns("cod").Visible = False
            dtPerfiles.Columns("codBreve").HeaderText = "Código Breve"
            dtPerfiles.Columns("descripcion").HeaderText = "Descripción"
            dtPerfiles.Columns("estado").Visible = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtPerfiles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPerfiles.CellDoubleClick


        Try

            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtPerfiles.DataSource
            row = dt.Rows(e.RowIndex)

            E_Usuarios.lblCodPerfil.Text = row("cod")
            E_Usuarios.txtPerfil.Text = row("codBreve")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class