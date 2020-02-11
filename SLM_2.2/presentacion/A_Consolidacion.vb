Public Class A_Consolidacion

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        importarExcel(dtExcel)

    End Sub

    Private Sub btnBanco_Click(sender As Object, e As EventArgs) Handles btnBanco.Click

        Try

            A_BuscarFormaPago.Show()
            A_BuscarFormaPago.lblJC.Text = "3"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try
            'Validacion de campos llenos
            If txtCodBanco.Text <> "" And cbxTransferencia.Text <> "" Then

                'Limpiar espacios vacios
                Dim a As String = Trim(cbxTransferencia.Text)

                'Consulta de transferencias
                If a = "Cheques" Then

                    Dim cheque As New ClsCheques

                    With cheque

                        .Nombre_Banco = txtBanco.Text
                        dtTransferencia.DataSource = .ConsolidarCheque

                        'Falta ocultar columnas de cheque y demas transferencias


                    End With

                End If

            ElseIf txtCodBanco.Text = "" Then
                MsgBox("Falta información que completar.")
                txtCodBanco.BackColor = Color.Red
                txtBanco.BackColor = Color.Red

            ElseIf cbxTransferencia.Text = "" Then

                MsgBox("Falta información que completar.")
                cbxTransferencia.BackColor = Color.Red

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Sub limpiar()

        txtCodBanco.Text = ""
        txtBanco.Text = ""
        cbxTransferencia.Text = ""
        dtTransferencia.DataSource = Nothing

    End Sub

End Class