Imports CrystalDecisions.CrystalReports.ViewerObjectModel

Public Class A_ListadoCheques

    Dim cheque As New ClsCheques
    Private Sub A_ListadoCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtCheques)
        Try

            dtCheques.DataSource = cheque.listarCheques

            For a = 0 To dtCheques.Rows.Count - 1

                If dtCheques.Rows(a).Cells(7).Value = "Rechazado" Then
                    dtCheques.Rows(a).DefaultCellStyle.Font = New Font(Font.Name, Font.Size, FontStyle.Strikeout)
                    dtCheques.Rows(a).DefaultCellStyle.ForeColor = Color.Red
                End If

            Next

            dtpInicio.Format = DateTimePickerFormat.Custom
            dtpInicio.CustomFormat = " "

            dtpFin.Format = DateTimePickerFormat.Custom
            dtpFin.CustomFormat = " "

        Catch ex As Exception
            MsgBox("Hubo un error al intentar listar los cheques. Detalle: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Try
            txtBusqueda.Text = ""
            dtCheques.DataSource = cheque.listarCheques
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try
            Dim Dato As New DataTable
            'Actualizar datos en datagrid con textbox
            With cheque

                .Numero_Cheque = txtBusqueda.Text

                Dato = cheque.buscarCheques
                dtCheques.DataSource = Dato

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub A_ListadoCheques_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As Object, e As EventArgs) Handles txtBusqueda.MouseHover
        ttBusqueda.SetToolTip(txtBusqueda, "Ingrese el Nro. de Cheque")
        ttBusqueda.ToolTipTitle = "Búsqueda"
        ttBusqueda.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub dtCheques_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCheques.CellDoubleClick

        Try

            Dim dt As DataTable
            Dim row As DataRow
            dt = dtCheques.DataSource
            row = dt.Rows(e.RowIndex)

            If row("monto").ToString = "" Then ' si el cheque no ha sido usado

                With A_Cheques

                    .txtNro.Text = row("codCheque")
                    .txtNroCheq.Text = row("nroCheque")
                    '.txtMonto.Text = row("monto")
                    '.dtpFechaReg.Value = row("fechaReg")
                    '.dtpFechaVto.Value = row("fechaVto")
                    .txtMoneda.Text = row("moneda")
                    .lblEstado.Text = row("estado")
                    '.txtcodProvee.Text = row("codBreveProveedor")
                    '.txtNombreProvee.Text = row("nombreProveedor")
                    '.txtBanco.Text = row("codBreveBanco")
                    '.txtNroCtaBanco.Text = row2("nroCtaBanco")
                    '.txtnombreBanco.Text = row("nombreBanco")
                    '.dtpAcredita.Value = row("fechaacreditacion")
                    '.dtpRechazo.Value = row("fechaRechazo")
                    '.dtpEmision.Value = row("fechaEmision")
                    '.dtpCancelado.Value = row("fechaCancelado")
                    '.txtCtaOrigen.Text = row("ctaOrigen")
                    '.txtCtaDestino.Text = row("ctaDestino")
                    '.txtCtaTemporal.Text = row("ctaTemporal")
                    '.lblForm.Text = "ChequeSeleccionado"
                    .Show()

                End With


            Else ' Si el cheque ha sido usado
                With A_Cheques

                    .txtNro.Text = row("codCheque")
                    .txtNroCheq.Text = row("nroCheque")
                    .txtMonto.Text = row("monto")
                    .dtpFechaReg.Value = row("fechaReg")
                    .dtpFechaVto.Value = row("fechaVto")
                    .txtMoneda.Text = row("moneda")
                    .lblEstado.Text = row("estado")
                    .lblCodProveedor.Text = row("codProveedor")
                    '.txtNombreProvee.Text = row("nombreProveedor")
                    '.txtBanco.Text = row("codBreveBanco")
                    '.txtNroCtaBanco.Text = row2("nroCtaBanco")
                    '.txtnombreBanco.Text = row("nombreBanco")
                    .dtpAcredita.Value = row("fechaacreditacion")
                    .dtpRechazo.Value = row("fechaRechazo")
                    .dtpEmision.Value = row("fechaEmision")
                    .dtpCancelado.Value = row("fechaCancelado")
                    .txtCtaOrigen.Text = row("ctaOrigen")
                    .txtCtaDestino.Text = row("ctaDestino")
                    .txtCtaTemporal.Text = row("ctaTemporal")
                    .lblForm.Text = "ChequeSeleccionado"
                    .Show()

                End With


            End If

        Catch ex As Exception
            MsgBox("Error al seleccionar. Detalle: " + ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GridAExcel(dtCheques)
    End Sub

    Private Sub dtpInicio_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpInicio.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                Me.dtpInicio.Format = DateTimePickerFormat.Short
                Me.dtpInicio.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                Me.dtpInicio.Format = DateTimePickerFormat.Custom
                Me.dtpInicio.CustomFormat = " "
        End Select
    End Sub

    Private Sub dtpFin_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFin.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                Me.dtpFin.Format = DateTimePickerFormat.Short
                Me.dtpFin.Value = Date.Today

            Case Windows.Forms.MouseButtons.Right
                Me.dtpFin.Format = DateTimePickerFormat.Custom
                Me.dtpFin.CustomFormat = " "
        End Select
    End Sub

    Private Sub txtBanco_DoubleClick(sender As Object, e As EventArgs) Handles txtCodBanco.DoubleClick

        Try
            A_ListadoBancos.lblFormBanco.Text = "2"
            A_ListadoBancos.ShowDialog()
        Catch ex As Exception

        End Try


    End Sub

    Function GridAExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add 'crea el libro de excel 
            exHoja = exLibro.Worksheets.Add() 'cuenta filas y columnas
            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1 'titulo en negritas
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            'alineacion al centro
            exHoja.Columns.AutoFit() 'autoajuste de la columna
            exHoja.Columns.HorizontalAlignment = 2
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim busca As New ClsCheques

        With busca
            '.Cod_BreveBanco = txtBanco.Text
            .Fecha_Inicio = dtpInicio.Value
            .Fecha_Final = dtpFin.Value

            '  dtCheques.DataSource = .InformeCheque

        End With



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            dtCheques.DataSource = cheque.listarCheques

            dtpInicio.Format = DateTimePickerFormat.Custom
            dtpInicio.CustomFormat = " "

            dtpFin.Format = DateTimePickerFormat.Custom
            dtpFin.CustomFormat = " "

        Catch ex As Exception
            MsgBox("Hubo un error al intentar listar los cheques. Detalle: " + ex.Message)
        End Try
    End Sub

End Class