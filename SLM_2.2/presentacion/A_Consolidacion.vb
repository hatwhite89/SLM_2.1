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

            Dim dt As DataTable
            'Validacion de campos llenos
            If txtCodBanco.Text <> "" And cbxTransferencia.Text <> "" Then

                'Limpiar espacios vacios
                Dim a As String = Trim(cbxTransferencia.Text)

                'Consulta de transferencias
                If a = "Cheques" Then

                    Dim cheque As New ClsCheques

                    With cheque

                        .Nombre_Banco = txtBanco.Text
                        dt = .ConsolidarCheque

                        dtTransferencia.DataSource = dt

                        'Falta ocultar columnas de cheque y demas transferencias

                    End With

                ElseIf a = "Depositos" Then

                    Dim depo As New ClsDeposito

                    With depo

                        .Banc_o = txtCodBanco.Text
                        dt = .ConciliacionDeposito
                        dtTransferencia.DataSource = dt

                        'ocultar columnas
                        dtTransferencia.Columns("banco").Visible = False
                        dtTransferencia.Columns("contado").Visible = False
                        dtTransferencia.Columns("TipoContado").Visible = False
                        dtTransferencia.Columns("moneda").Visible = False
                        dtTransferencia.Columns("monBase").Visible = False
                        dtTransferencia.Columns("tipoDeposito").Visible = False
                        dtTransferencia.Columns("codCajero").Visible = False
                        dtTransferencia.Columns("codFormaPago").Visible = False

                    End With

                End If

            ElseIf txtCodBanco.Text = "" Then

                'Marcar campo vacio
                MsgBox("Falta información que completar.")
                txtCodBanco.BackColor = Color.Red
                txtBanco.BackColor = Color.Red

            ElseIf cbxTransferencia.Text = "" Then

                'Marcar campo vacio
                MsgBox("Falta información que completar.")
                cbxTransferencia.BackColor = Color.Red

            End If 'final consulta de transferencia

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

    Private Sub txtCodBanco_TextChanged(sender As Object, e As EventArgs) Handles txtCodBanco.TextChanged

        If txtCodBanco.BackColor = Color.Red Then
            txtCodBanco.BackColor = Color.White
            txtBanco.BackColor = Color.White
        End If

    End Sub

    Private Sub cbxTransferencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTransferencia.SelectedIndexChanged

        If cbxTransferencia.BackColor = Color.Red Then
            cbxTransferencia.BackColor = Color.White
        End If

    End Sub


    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Try

            Dim j = 0, c As Integer 'variables contador

            For j = 0 To dtTransferencia.Rows.Count  'for transferencias

                Try

                    For c = 0 To dtExcel.Rows.Count   'for excel

                        If dtTransferencia.Rows(j).Cells(5).Value = dtExcel.Rows(c).Cells(2).Value Then

                            'dtTransferencia.Rows(j).DefaultCellStyle.BackColor = Color.PaleGreen
                            dtExcel.Rows.Remove(dtExcel.Rows(c))
                            dtTransferencia.Rows.Remove(dtTransferencia.Rows(j))

                            Exit For 'si encuentra igualdad detener for y seguir al siguiente

                        End If

                    Next 'For Excel

                Catch ex As Exception

                End Try

            Next 'For transferencias

        Catch ex As Exception

        End Try

    End Sub

End Class