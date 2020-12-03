Public Class M_TipoPermiso
    Dim objTipoPermiso As New ClsTipoPermiso
    Private Sub M_TipoPermiso_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub M_TipoPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        actualizarListadoTipoPermiso()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("nombre").HeaderText = "Nombre"
        dgbtabla.Columns("goseSueldo").HeaderText = "Gose de Sueldo"

        'DESHABILITAR
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub actualizarListadoTipoPermiso()
        Dim dv As DataView = objTipoPermiso.SeleccionarTipoPermiso.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_Permisos") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el tipo de permiso?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Permisos.llenarTipoPermiso()
                    M_Permisos.cmbxTipoPermiso.SelectedValue = txtcodigo.Text
                    Me.Close()
                End If
            ElseIf (lblform.Text = "M_TerminoPago") Then
                If e.RowIndex >= 0 Then
                        n = MsgBox("¿Desea utilizar el tipo de permiso?", MsgBoxStyle.YesNo)
                    End If
                    If n = vbYes Then
                        M_Permisos.llenarTipoPermiso()
                        M_Permisos.cmbxTipoPermiso.SelectedValue = txtcodigo.Text
                        Me.Close()
                    End If
                End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            If Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value() Then
                rbtnSi.Checked = True
            Else
                rbtnNo.Checked = True
            End If

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtnombre.ReadOnly = False
            rbtnSi.Enabled = True
            rbtnNo.Enabled = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""
        rbtnSi.Enabled = True
        rbtnNo.Enabled = True

        txtnombre.ReadOnly = False
        rbtnNo.Checked = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            txtnombre.Text = sinDobleEspacio(txtnombre.Text)

            If (Trim(txtnombre.Text) <> "") Then
                Dim objTipoPermiso As New ClsTipoPermiso
                With objTipoPermiso
                    .Nombre_ = txtnombre.Text
                    .goseSueldo_ = rbtnSi.Checked
                End With

                If objTipoPermiso.RegistrarNuevaTipoPermiso() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information)
                    M_Permisos.llenarTipoPermiso()
                    actualizarListadoTipoPermiso()

                    txtnombre.ReadOnly = True
                    rbtnSi.Enabled = False
                    rbtnNo.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el tipo de permiso.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
    '    Try
    '        Dim n As String = ""
    '        If (lblform.Text = "M_TerminosPago") Then
    '            If e.RowIndex >= 0 Then
    '                n = MsgBox("¿Desea utilizar el tipo de término de pago?", MsgBoxStyle.YesNo)
    '            End If
    '            If n = vbYes Then
    '                'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
    '                M_TerminosPago.cbxtipoPago.SelectedValue = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
    '                Me.Close()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "") Then
                txtnombre.Text = sinDobleEspacio(txtnombre.Text)
                Dim objTipoPermiso As New ClsTipoPermiso
                With objTipoPermiso
                    .Nombre_ = txtnombre.Text
                    .codigo_ = txtcodigo.Text
                    .goseSueldo_ = rbtnSi.Checked
                End With

                If objTipoPermiso.ModificarTipoPermiso() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)
                    M_Permisos.llenarTipoPermiso()

                    actualizarListadoTipoPermiso()

                    'btnmodificar.Enabled = False
                    'btnguardar.Enabled = False
                    'btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el tipo de permiso.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim dv As DataView = dgbtabla.DataSource
            dv.RowFilter = String.Format("nombre Like '%{0}%'", txtnombreB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(dgbtabla)
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
End Class