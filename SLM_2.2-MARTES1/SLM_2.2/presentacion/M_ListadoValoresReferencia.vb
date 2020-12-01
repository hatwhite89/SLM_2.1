Public Class M_ListadoValoresReferencia

    Dim objValRef As New ClsValoresReferencia

    Private Sub M_ListadoValoresReferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ACTUALIZAR LISTADO
            seleccionarValoresReferenciaPorDescripcion()

            'AGREGARLE COLOR AL DATAGRIDVIEW
            alternarColoFilasDatagridview(dgbtabla)

            'OCULTAR COLUMNAS
            Me.dgbtabla.Columns("cod_DetalleValorRef").Visible = False
            Me.dgbtabla.Columns("cod_ValorReferencia").Visible = False

            'CAMBIAS NOMBRE COLUMNAS
            dgbtabla.Columns("edadde").HeaderText = "Edad De"
            dgbtabla.Columns("edadhasta").HeaderText = "Edad Hasta"
            dgbtabla.Columns("valornormal").HeaderText = "Valor Normal"
            dgbtabla.Columns("hasta").HeaderText = "Valor Hasta"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub seleccionarValoresReferenciaPorDescripcion()
        objValRef.Descripcion_ = Convert.ToInt64(lblcodeCateCli.Text)
        Dim dv As DataView = objValRef.buscarValorReferencia2.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub seleccionarValoresReferencia()
        Dim dv As DataView = objValRef.listarValores.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
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