Public Class M_ListadoDePrecios
    Dim objListPrice As New ClsListaPrecios
    Private Sub M_ListadoDePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seleccionarListaPrecios()
        txtCodigoBreve.Text = ""
        txtDescripcion.Text = ""
        Me.dgbtabla.Columns("codigo").Visible = False
    End Sub
    Public Sub seleccionarListaPrecios()
        Dim dv As DataView = objListPrice.SeleccionarListaPrecios.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 And lblForm.Text = "Precio" Then
                n = MsgBox("¿Desea utilizar la lista de precio que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    M_Precio.lblCode.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    Me.Close()
                End If
            ElseIf e.RowIndex >= 0 And lblForm.Text = "TipoClasificacion" Then
                n = MsgBox("¿Desea utilizar la lista de precio que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    M_TipoClasificacion.lblCodePriceList.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    Me.Close()
                End If

            ElseIf e.RowIndex >= 0 Then
                n = MsgBox("¿Desea actualizar la lista de precio que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    M_ListaPrecios.txtcodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_ListaPrecios.txtcodigoBreve.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    M_ListaPrecios.txtDescripcion.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()

                    'TIPO CONVENIO
                    If dgbtabla.Rows(e.RowIndex).Cells(3).Value() Then
                        M_ListaPrecios.lblcodeT.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                        M_ListaPrecios.txtrtn.Text = dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                        M_ListaPrecios.rbtnConvenioSi.Checked = True
                    Else
                        M_ListaPrecios.txtrtn.Clear()
                        M_ListaPrecios.rbtnConvenioNo.Checked = True
                    End If

                    'SOLICITA PAGO
                    If dgbtabla.Rows(e.RowIndex).Cells(5).Value() Then
                        M_ListaPrecios.txtPorcentaje.Text = dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                        M_ListaPrecios.rbtnPagoSi.Checked = True
                    Else
                        M_ListaPrecios.rbtnPagoNo.Checked = True
                        M_ListaPrecios.txtPorcentaje.Text = ""
                    End If
                    'limpiar el data grid view
                    M_ListaPrecios.dgbtabla.Rows.Clear()

                    Dim objDetLP As New ClsDetalleListaPrecios
                    objDetLP.codigoListaPrecios_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    Dim dt As New DataTable
                    dt = objDetLP.BuscarDetalleListaPrecios
                    'M_ListaPrecios.dgbtabla.DataSource = dv
                    'falta esta parte del llenado del datagridview
                    Dim row As DataRow = dt.Rows(0)
                    For index As Integer = 0 To dt.Rows.Count - 1
                        row = dt.Rows(index)
                        M_ListaPrecios.dgbtabla.Rows.Add(New String() {CStr(row("codigo")), CStr(row("codigoListaPrecios")), CStr(row("codigoGrupoItem")), CStr(row("nombreItem")), CStr(row("codigoDescuento")), CStr(row("codigoBreve"))})
                    Next

                    M_ListaPrecios.btnguardar.Enabled = False
                    M_ListaPrecios.btnmodificar.Enabled = True
                    M_ListaPrecios.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        If (Trim(txtDescripcion.Text) <> "") Then
            Try
                objListPrice.descripcion_ = txtDescripcion.Text
                Dim dv As DataView = objListPrice.BuscarListaPrecios.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarListaPrecios()
        End If
    End Sub

    Private Sub txtCodigoBreve_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoBreve.TextChanged
        If (Trim(txtCodigoBreve.Text) <> "") Then
            Try
                objListPrice.codigoBreve_ = txtCodigoBreve.Text
                Dim dv As DataView = objListPrice.BuscarListaPreciosCode.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            seleccionarListaPrecios()
        End If
    End Sub

    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        M_ListaPrecios.limpiar()
        M_ListaPrecios.Show()
    End Sub
End Class