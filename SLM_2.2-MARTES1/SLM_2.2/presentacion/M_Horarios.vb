Public Class M_Horarios

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtcodigoBreve.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""
        dtpEntrada.Value() = Date.Now()
        dtpSalida.Value() = Date.Now()
        cbxLunes.Checked = False
        cbxMartes.Checked = False
        cbxMiercoles.Checked = False
        cbxJueves.Checked = False
        cbxViernes.Checked = False
        cbxSabado.Checked = False
        cbxDomingo.Checked = False
        rtxtObservacion.Text() = ""
        dtpEntradaFinSemana.Value() = Date.Now()
        dtpSalidaFinSemana.Value() = Date.Now()

        txtcodigoBreve.ReadOnly = False
        txtnombre.ReadOnly = False
        dtpEntrada.Enabled = True
        dtpSalida.Enabled = True
        rtxtObservacion.ReadOnly = False
        cbxLunes.Enabled = True
        cbxMartes.Enabled = True
        cbxMiercoles.Enabled = True
        cbxJueves.Enabled = True
        cbxViernes.Enabled = True
        cbxSabado.Enabled = True
        cbxDomingo.Enabled = True

        dtpEntradaFinSemana.Enabled = True
        dtpSalidaFinSemana.Enabled = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub deshabilitar()

        txtcodigoBreve.ReadOnly = True
        txtnombre.ReadOnly = True
        dtpEntrada.Enabled = False
        dtpSalida.Enabled = False
        rtxtObservacion.ReadOnly = True
        cbxLunes.Enabled = False
        cbxMartes.Enabled = False
        cbxMiercoles.Enabled = False
        cbxJueves.Enabled = False
        cbxViernes.Enabled = False
        cbxSabado.Enabled = False
        cbxDomingo.Enabled = False
        dtpEntradaFinSemana.Enabled = False
        dtpSalidaFinSemana.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
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
            If txtcodigoBreve.TextLength = 0 Then
                txtcodigoBreve.BackColor = Color.Red
            Else
                txtcodigoBreve.BackColor = Color.White
            End If
            If txtnombre.TextLength = 0 Then
                txtnombre.BackColor = Color.Red
            Else
                txtnombre.BackColor = Color.White
            End If

            If (txtcodigoBreve.BackColor = Color.White And txtnombre.BackColor = Color.White) Then
                Dim objHorario As New ClsHorarios
                With objHorario
                    .codigoBreve_ = txtcodigoBreve.Text
                    .Nombre_ = txtnombre.Text
                    .entrada_ = dtpEntrada.Value
                    .salida_ = dtpSalida.Value
                    .lunes_ = cbxLunes.Checked
                    .martes_ = cbxMartes.Checked
                    .miercoles_ = cbxMiercoles.Checked
                    .jueves_ = cbxJueves.Checked
                    .viernes_ = cbxViernes.Checked
                    .sabado_ = cbxSabado.Checked
                    .domingo_ = cbxDomingo.Checked
                    .observacion_ = rtxtObservacion.Text
                    .entradaFinSemana_ = dtpEntradaFinSemana.Value
                    .salidaFinSemana_ = dtpSalidaFinSemana.Value
                End With

                If objHorario.RegistrarNuevoHorario() = 1 Then
                    MsgBox("Registrado el horario de trabajo correctamente.")

                    seleccionarHorarios()

                    deshabilitar()
                Else
                    MsgBox("Error al querer ingresar el horario de trabajo.", MsgBoxStyle.Critical)
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
            If (txtcodigoBreve.BackColor = Color.White And txtnombre.BackColor = Color.White And txtcodigo.Text <> "") Then
                Dim objHorario As New ClsHorarios
                With objHorario
                    .Codigo_ = txtcodigo.Text
                    .codigoBreve_ = txtcodigoBreve.Text
                    .Nombre_ = txtnombre.Text
                    .entrada_ = dtpEntrada.Value
                    .salida_ = dtpSalida.Value
                    .lunes_ = cbxLunes.Checked
                    .martes_ = cbxMartes.Checked
                    .miercoles_ = cbxMiercoles.Checked
                    .jueves_ = cbxJueves.Checked
                    .viernes_ = cbxViernes.Checked
                    .sabado_ = cbxSabado.Checked
                    .domingo_ = cbxDomingo.Checked
                    .observacion_ = rtxtObservacion.Text
                    .entradaFinSemana_ = dtpEntradaFinSemana.Value
                    .salidaFinSemana_ = dtpSalidaFinSemana.Value
                End With

                If objHorario.ModificarHorario() = 1 Then
                    MsgBox("Modificado el horario de trabajo correctamente.")

                    seleccionarHorarios()
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el horario de trabajo.", MsgBoxStyle.Critical)
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

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            limpiar()

            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigoBreve.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            dtpEntrada.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value().ToString
            dtpSalida.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value().ToString
            cbxLunes.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            cbxMartes.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
            cbxMiercoles.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
            cbxJueves.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value()
            cbxViernes.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value()
            cbxSabado.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(10).Value()
            cbxDomingo.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(11).Value()
            rtxtObservacion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(12).Value()

            dtpEntradaFinSemana.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(13).Value().ToString
            dtpSalidaFinSemana.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(14).Value().ToString

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_Empleados") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el horario de trabajo en el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Empleados.txtcodigoHorario.Text = txtcodigo.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_Sede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        seleccionarHorarios()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'OCULTAR COLUMNAS
        Me.dgbtabla.Columns("lunes").Visible = False
        Me.dgbtabla.Columns("martes").Visible = False
        Me.dgbtabla.Columns("miercoles").Visible = False
        Me.dgbtabla.Columns("jueves").Visible = False
        Me.dgbtabla.Columns("viernes").Visible = False
        Me.dgbtabla.Columns("sabado").Visible = False
        Me.dgbtabla.Columns("domingo").Visible = False
        Me.dgbtabla.Columns("observacion").Visible = False

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("codigoBreve").HeaderText = "Código Breve"
        dgbtabla.Columns("nombre").HeaderText = "Nombre"
        dgbtabla.Columns("entrada").HeaderText = "Entrada Semanal"
        dgbtabla.Columns("salida").HeaderText = "Salida Semanal"
        dgbtabla.Columns("entradaFinSemana").HeaderText = "Entrada Fin de Semana"
        dgbtabla.Columns("salidaFinSemana").HeaderText = "Salida Fin de Semana"


    End Sub
    Private Sub seleccionarHorarios()
        Try
            Dim objHorario As New ClsHorarios
            Dim dv As DataView = objHorario.SeleccionarHorario.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            deshabilitar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objHorario As New ClsHorarios
            With objHorario
                .Nombre_ = txtnombreB.Text
            End With
            Dim dv As DataView = objHorario.BuscarHorarioNombre.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcodigoBreve_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoBreve.TextChanged
        If txtcodigoBreve.TextLength = 0 Then
            txtcodigoBreve.BackColor = Color.Red
        Else
            txtcodigoBreve.BackColor = Color.White
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If txtnombre.TextLength = 0 Then
            txtnombre.BackColor = Color.Red
        Else
            txtnombre.BackColor = Color.White
        End If
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(dgbtabla)
    End Sub
End Class