Public Class M_PuestoTrabajo
    Private Sub M_PuestoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'ACTUALIZAR LISTADO
            Dim objPuesto As New ClsPuestoTrabajo
            Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

            'AGREGARLE COLOR AL DATAGRIDVIEW
            alternarColoFilasDatagridview(dgbtabla)

            'OCULTAR COLUMNAS
            Me.dgbtabla.Columns("codigoDepto").Visible = False
            Me.dgbtabla.Columns("codigoArea").Visible = False

            'CAMBIAS NOMBRE COLUMNAS
            dgbtabla.Columns("codigo").HeaderText = "Código"
            dgbtabla.Columns("descripcion").HeaderText = "Descripción"


            'DESHABILITAR 
            rtxtdescripcion.ReadOnly = True
            txtcodigo.ReadOnly = True
            txtcodigoDepto.ReadOnly = True
            btnDepto.Enabled = False
            btnmodificar.Enabled = False
            btnguardar.Enabled = False
            btnnuevo.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtcodigoDepto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            rtxtdescripcion.ReadOnly = False
            txtcodigoDepto.ReadOnly = False

            btnDepto.Enabled = True

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            rtxtdescripcion.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "Empleados") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo en el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Empleados.lblcodePuesto.Text = txtcodigo.Text
                    M_Empleados.txtPuestoTrabajo.Text = rtxtdescripcion.Text
                    MsgBox(txtcodigo.Text)
                    Me.Close()
                End If
            ElseIf (lblform.Text = "Candidatos") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo en el candidato?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    A_Candidatos.lblcodCargo.Text = txtcodigo.Text
                    A_Candidatos.txtCargo.Text = rtxtdescripcion.Text

                    Me.Close()
                End If

            ElseIf (lblform.Text = "CandidatosInforme") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el puesto de trabajo en el informe?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    A_Candidatos.lblcodCargo.Text = txtcodigo.Text
                    A_Candidatos.txtCargoI.Text = rtxtdescripcion.Text

                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        rtxtdescripcion.Text() = ""
        txtdescripcionB.Text() = ""
        txtnombreDepto.Text = ""
        txtcodigoDepto.Text = ""

        rtxtdescripcion.ReadOnly = False
        txtcodigoDepto.ReadOnly = False

        btnDepto.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
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
            If rtxtdescripcion.TextLength = 0 Then
                rtxtdescripcion.BackColor = Color.Red
            Else
                rtxtdescripcion.BackColor = Color.White
            End If
            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtnombreDepto.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objPuesto As New ClsPuestoTrabajo
                With objPuesto
                    .Descripcion_ = rtxtdescripcion.Text
                    .codigoDepto_ = txtcodigoDepto.Text
                End With

                If objPuesto.RegistrarNuevoPuestoTrabajo() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information, "Validación.")

                    Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True
                    txtcodigoDepto.ReadOnly = True

                    btnDepto.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el puesto de trabajo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (txtcodigo.Text <> "" And Trim(rtxtdescripcion.Text) <> "" And Trim(txtnombreDepto.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objPuesto As New ClsPuestoTrabajo
                With objPuesto
                    .Codigo_ = txtcodigo.Text
                    .Descripcion_ = rtxtdescripcion.Text
                    .codigoDepto_ = txtcodigoDepto.Text
                End With

                If objPuesto.ModificarPuestoTrabajo() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information, "Validación.")

                    Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True
                    txtcodigoDepto.ReadOnly = True

                    btnDepto.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el puesto de trabajo.", MsgBoxStyle.Critical)
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
    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        'Try

        '    'Dim objPuesto As New ClsPuestoTrabajo
        '    'With objPuesto
        '    '    .Descripcion_ = txtdescripcionB.Text
        '    'End With

        '    'If (Trim(txtdescripcionB.Text) <> "") Then
        '    '    Dim dv As DataView = objPuesto.BuscarPuestoTrabajo.DefaultView
        '    '    dgbtabla.DataSource = dv
        '    '    lblcantidad.Text = dv.Count
        '    '    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    'Else
        '    '    Dim dv As DataView = objPuesto.SeleccionarPuestoTrabajo.DefaultView
        '    '    dgbtabla.DataSource = dv
        '    '    lblcantidad.Text = dv.Count
        '    '    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    'End If
        'Catch ex As Exception

        'End Try

        Try
            Dim dv As DataView = dgbtabla.DataSource
            dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtdescripcionB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub rtxtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles rtxtdescripcion.TextChanged
        If rtxtdescripcion.TextLength = 0 Then
            rtxtdescripcion.BackColor = Color.Red
        Else
            rtxtdescripcion.BackColor = Color.White
        End If
    End Sub

    Private Sub btnDepto_Click(sender As Object, e As EventArgs) Handles btnDepto.Click
        M_Departamento.lblform.Text = "M_PuestoTrabajo"
        M_Departamento.Show()
    End Sub

    Private Sub txtcodigoDepto_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoDepto.TextChanged
        If (txtcodigoDepto.Text <> "") Then
            Try
                Dim objDepto As New ClsDepartamento
                With objDepto
                    .codigo_ = txtcodigoDepto.Text
                End With
                Dim dt As New DataTable
                dt = objDepto.BuscarDepartamento()
                Dim row As DataRow = dt.Rows(0)
                txtnombreDepto.Text = CStr(row("nombre"))
                txtcodigoDepto.BackColor = Color.White
            Catch ex As Exception
                txtcodigoDepto.BackColor = Color.Red
                txtnombreDepto.Text = ""
            End Try
        Else
            txtcodigoDepto.Text = ""
            txtnombreDepto.Text = ""
            txtcodigoDepto.BackColor = Color.White
        End If
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