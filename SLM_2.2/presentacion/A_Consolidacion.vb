Public Class A_Consolidacion

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        ' Importar excel, se debe enviar hoja que se desea importar al datagrid
        importarExcel(dtExcel)

    End Sub

    Private Sub btnBanco_Click(sender As Object, e As EventArgs) Handles btnBanco.Click

        Try
            'Captura banco para filtro de transferencias
            A_ListadoBancos.Show()
            A_ListadoBancos.lblFormBanco.Text = "3"

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
                If a = "Cheques" Then ' Si selecciona cheque

                    dtTransferencia.DataSource = Nothing
                    Dim cheque As New ClsCheques

                    With cheque

                        .cod_Banco = Convert.ToInt32(txtCodBanco.Text)
                        dt = .ConsolidarCheque(dtpDesde.Value, dtpHasta.Value)
                        dtTransferencia.DataSource = dt

                        dtTransferencia.Columns("codCheque").Visible = False
                        dtTransferencia.Columns("codChequera").Visible = False
                        dtTransferencia.Columns("moneda").Visible = False
                        dtTransferencia.Columns("tipo").Visible = False
                        dtTransferencia.Columns("ctaOrigen").Visible = False
                        dtTransferencia.Columns("ctaTemporal").Visible = False
                        dtTransferencia.Columns("ctaDestino").Visible = False
                        dtTransferencia.Columns("codProveedor").Visible = False

                        dtTransferencia.Columns("nroCheque").Frozen = True

                    End With

                ElseIf a = "Depositos Bancarios" Then ' Si selecciona Depositos

                    dtTransferencia.DataSource = Nothing
                    Dim depo As New ClsDeposito

                    With depo

                        dt = depo.ConsolidarDepositos(txtBanco.Text, dtpDesde.Value, dtpHasta.Value)

                        If dt.Rows.Count < 0 Then
                            MsgBox("No existen transferencias del banco seleccionado.")
                        Else
                            dtTransferencia.DataSource = dt

                            'ocultar columnas
                            dtTransferencia.Columns("codDeposito").Visible = False
                            dtTransferencia.Columns("codFPBanco").Visible = False
                            dtTransferencia.Columns("codFPContado").Visible = False
                            dtTransferencia.Columns("moneda").Visible = False
                            dtTransferencia.Columns("monBase").Visible = False
                            dtTransferencia.Columns("tipoDeposito").Visible = False
                            'dtTransferencia.Columns("codCajero").Visible = False
                            'dtTransferencia.Columns("codFormaPago").Visible = False

                        End If

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
            MsgBox(ex.Message)
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
        dtExcel.DataSource = Nothing

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

            Dim check2 As String

            For j = 0 To dtExcel.Rows.Count 'for excel

                check2 = dtExcel.Rows(j).Cells(0).Value

                If check2 = "True" Then ' si la transferencia tiene check

                    dtExcel.Rows.Remove(dtExcel.Rows(j))

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dtTransferencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtTransferencia.CellContentClick
        If e.ColumnIndex = 0 Then
            If dtTransferencia.Rows(e.RowIndex).Cells(0).Value = False Then
                dtTransferencia.Rows(e.RowIndex).Cells(0).Value = True
            Else
                dtTransferencia.Rows(e.RowIndex).Cells(0).Value = False
            End If
        End If
    End Sub

    Private Sub dtExcel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtExcel.CellContentClick
        If e.ColumnIndex = 0 Then
            If dtExcel.Rows(e.RowIndex).Cells(0).Value = False Then
                dtExcel.Rows(e.RowIndex).Cells(0).Value = True
            Else
                dtExcel.Rows(e.RowIndex).Cells(0).Value = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim check As String
            For i = 0 To dtTransferencia.Rows.Count 'for transferencias

                check = dtTransferencia.Rows(i).Cells(0).Value

                If check = "True" Then ' si la transferencia tiene check

                    dtTransferencia.Rows.Remove(dtTransferencia.Rows(i))

                End If

            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        E_frmInventario.GridAExcel(dtTransferencia)
        E_frmInventario.GridAExcel(dtExcel)

    End Sub
End Class