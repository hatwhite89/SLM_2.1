Public Class M_ListadoValoresRefTxt

    Dim objValRef As New ClsValoresReferenciaTXT
    Dim objValRefDet As New ClsDetalleValorRefTxt

    Private Sub M_ListadoValoresReferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ACTUALIZAR LISTADO
            seleccionarValoresReferenciatxtParametro()
            seleccionarValoresReferenciaDetalleParametro()

            'AGREGARLE COLOR AL DATAGRIDVIEW
            alternarColoFilasDatagridview(dgbtabla)
            alternarColoFilasDatagridview(dgvDetalleTabla)

            'OCULTAR COLUMNAS
            Me.dgbtabla.Columns("cod_parametro").Visible = False
            Me.dgbtabla.Columns("cod_ValorReferenciaTxt").Visible = False

            Me.dgvDetalleTabla.Columns("cod_DetalleValorReftxt").Visible = False
            Me.dgvDetalleTabla.Columns("cod_ValorReferenciaTxt").Visible = False

            'CAMBIAS NOMBRE COLUMNAS
            dgbtabla.Columns("edadde").HeaderText = "Edad Desde"
            dgbtabla.Columns("edadhasta").HeaderText = "Edad Hasta"
            dgbtabla.Columns("descripcion").HeaderText = "Descripción"
            dgbtabla.Columns("genero").HeaderText = "Genero"

            dgvDetalleTabla.Columns("descripcion").HeaderText = "Descripción"
            dgvDetalleTabla.Columns("texto").HeaderText = "Texto"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        alternarColoFilasDatagridview(dgbtabla)
    End Sub

    Private Sub seleccionarValoresReferenciatxtParametro()
        'objValRef.Descripcion_ = Convert.ToInt64(lblParamtro.Text)
        Dim dv As DataView = objValRef.buscarValorReferenciaTxtParamtro(lblParamtro.Text).DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub seleccionarValoresReferenciaDetalleParametro()
        Dim dv As DataView = objValRefDet.buscarDetalleValorRefTxtParametro(lblParamtro.Text).DefaultView
        dgvDetalleTabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgvDetalleTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        'Try
        '    If lblform.Text = "M_Cliente" And lblBandera.Text = "1" Then
        '        Dim n As String = ""
        '        If e.RowIndex >= 0 Then
        '            n = MsgBox("¿Desea utilizar el tipo de clasificación seleccionado?", MsgBoxStyle.YesNo, "Validación")
        '        End If
        '        If n = vbYes Then
        '            M_Cliente.txtcodigoClasificacion.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
        '            M_Cliente.txtnombreClasificacion.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
        '            Me.Close()
        '        End If
        '    ElseIf lblform.Text = "M_Empleados" And lblBandera.Text = "0" Then
        '        'Dim n As String = ""
        '        'If e.RowIndex >= 0 Then
        '        '    n = MsgBox("¿Desea utilizar el tipo de clasificación seleccionado?", MsgBoxStyle.YesNo, "Validación")
        '        'End If
        '        'If n = vbYes Then
        '        '    M_Empleados.lblcodePuesto.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
        '        '    M_Empleados.txtTipoClasificacion.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
        '        '    M_Empleados.lblcodeDepto.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
        '        '    M_Empleados.lblcodigoArea.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
        '        '    Me.Close()
        '        'End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try
    End Sub

End Class