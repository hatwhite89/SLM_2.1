Public Class A_Alertas

    Dim misNotificaciones As New ClsNotificaciones

    Private Sub A_Alertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtNotificaciones.DataSource = misNotificaciones.listarNotifiaciones

            'TAMAÑO COLUMNAS

            dtNotificaciones.Columns("cod_Noti").Visible = False
            dtNotificaciones.Columns("nombreAlerta").Width = "120"
            dtNotificaciones.Columns("descripcion").Width = "320"
            dtNotificaciones.Columns("estado").Width = "50"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub dtNotificaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtNotificaciones.CellContentClick
        Try






        Catch ex As Exception

        End Try
    End Sub
End Class