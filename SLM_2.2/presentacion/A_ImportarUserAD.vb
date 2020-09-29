
Public Class A_ImportarUserAD


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub A_ImportarUserAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtUsuariosAD)
        dtUsuariosAD.Rows.Clear()
        btnCargar.Enabled = True
        btnImportar.Enabled = False

    End Sub

    Private Sub UI_ButtonMaterial1_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            ImportarUsuariosAD()
            btnCargar.Enabled = False
            btnActualizar.Enabled = True
            btnImportar.Enabled = True

            Dim data As New DataTable
            Dim row As DataRow
            Dim users As New ClsUsuario

            'Eliminar usuarios de AD que estan en SLM
            data = users.listarUsuarios

            For mg = 0 To dtUsuariosAD.Rows.Count - 1

                For es = 0 To data.Rows.Count - 1


                    If dtUsuariosAD.Rows(mg).Cells(3).Value = data.Rows(es).Item(1).ToString Then

                        dtUsuariosAD.Rows.Remove(dtUsuariosAD.Rows(mg))

                    End If


                Next

            Next

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
            Dim dt, dtP As New DataTable
            Dim row, rowP As DataRow

            dtP = perfil.PerfilDefault
            rowP = dtP.Rows(0)
            MsgBox(rowP("cod"))

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
                        .Cod_Perfil = Convert.ToInt32(rowP("cod"))
                        .perfil_ = rowP("codBreve")
                        .Cod_Empleado = Convert.ToInt32(row("codigo"))
                        .registrarNuevoUsuario()

                        End With

                End If 'Agregar filas con check

            Next
            MsgBox("Se finalizó la importación.")
        Catch ex As Exception
            MsgBox("No se encontró el empleado en la BD. Detalle de error: " + ex.Message)
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

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try

            dtUsuariosAD.Rows.Clear()
            ImportarUsuariosAD()
            btnCargar.Enabled = False
            btnImportar.Enabled = True

            Dim data As New DataTable
            Dim row As DataRow
            Dim users As New ClsUsuario

            'Eliminar usuarios de AD que estan en SLM
            data = users.listarUsuarios

            For mg = 0 To dtUsuariosAD.Rows.Count - 1

                For es = 0 To data.Rows.Count - 1


                    If dtUsuariosAD.Rows(mg).Cells(3).Value = data.Rows(es).Item(1).ToString Then

                        dtUsuariosAD.Rows.Remove(dtUsuariosAD.Rows(mg))

                    End If


                Next

            Next

        Catch ex As Exception

        End Try
    End Sub
End Class