Public Class A_Alertas

    Dim misNotificaciones As New ClsNotificaciones

    Private Sub A_Alertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtNotificaciones.DataSource = misNotificaciones.listarNotifiaciones
            alternarColoFilasDatagridview(dtNotificaciones)
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

    End Sub

    Private Sub btnVerificado_Click(sender As Object, e As EventArgs) Handles btnVerificado.Click
        Try


            dtNotificaciones.DataSource = misNotificaciones.listarNotifiaciones
            Form1.pbxNoti.Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtNotificaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtNotificaciones.CellClick
        Try

            If e.ColumnIndex = 3 Then 'IF CLICK EN COLUMNA


                If dtNotificaciones.Rows(e.RowIndex).Cells(3).Value() = 0 Then

                    With misNotificaciones

                        .codigo_ = Convert.ToInt64(dtNotificaciones.Rows(e.RowIndex).Cells(0).Value())
                        .estado_ = 1
                        .VerificarNotificacion()

                    End With
                Else

                    With misNotificaciones

                        .codigo_ = Convert.ToInt64(dtNotificaciones.Rows(e.RowIndex).Cells(0).Value())
                        .estado_ = 0
                        .VerificarNotificacion()

                    End With

                End If


            ElseIf e.ColumnIndex = 2 Then

                MsgBox("Alerta: " + dtNotificaciones.Rows(e.RowIndex).Cells(2).Value())

            End If ' IF CLICK EN COLUMNA



        Catch ex As Exception

        End Try

    End Sub
End Class