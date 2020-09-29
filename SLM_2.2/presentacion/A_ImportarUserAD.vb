
Public Class A_ImportarUserAD


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub A_ImportarUserAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtUsuariosAD)

    End Sub

    Private Sub UI_ButtonMaterial1_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            ImportarUsuariosAD()
            btnCargar.Enabled = False
            btnImportar.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            Dim nombre As String
            Dim empleado As New ClsEmpleados
            Dim user As New ClsUsuario
            Dim perfil As New ClsPerfilesUsuario
            Dim dt As New DataTable
            Dim row As DataRow



            For a = 0 To dtUsuariosAD.Rows.Count - 1

                If dtUsuariosAD.Rows(a).Cells(0).Value = True Then
                    'concatenar y capturar nombre de usuarios seleccionados
                    nombre = dtUsuariosAD.Rows(a).Cells(1).Value.ToString + " " + dtUsuariosAD.Rows(a).Cells(2).Value.ToString
                    'consultar existencia de nombre de usuario en base de datos
                    With empleado

                        .NombreCompleto_ = nombre
                        dt = .CompararNombre()
                        row = dt.Rows(0)
                    End With




                    With user

                        .Usuario_ = dtUsuariosAD.Rows(a).Cells(3).Value
                        .password_ = "#changepass#"
                        .Estad_o = 1
                        .Cod_Perfil =
                            .perfil_ =

                    End With


                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtUsuariosAD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUsuariosAD.CellContentClick
        If e.ColumnIndex = 0 Then
            If dtUsuariosAD.Rows(e.RowIndex).Cells(0).Value = False Then
                dtUsuariosAD.Rows(e.RowIndex).Cells(0).Value = True
            Else
                dtUsuariosAD.Rows(e.RowIndex).Cells(0).Value = False
            End If
        End If
    End Sub
End Class