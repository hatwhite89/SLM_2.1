﻿Public Class M_Departamento

    Dim objDepto As New ClsDepartamento

    Private Sub M_Departamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub actualizarDepartamento()
        Dim dv As DataView = objDepto.SeleccionarDepartamento.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub M_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        actualizarDepartamento()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'CAMBIAS NOMBRE COLUMNAS
        'dgbtabla.Columns("codigoArea").HeaderText = "Código"
        'dgbtabla.Columns("nombre").HeaderText = "Nombre"
        'dgbtabla.Columns("goseSueldo").HeaderText = "Gose de Sueldo"

        'DESHABILITAR
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True
        txtcodigoArea.ReadOnly = True
        btnArea.Enabled = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_PuestoTrabajo") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el departamento?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_PuestoTrabajo.txtcodigoDepto.Text = txtcodigo.Text
                    M_PuestoTrabajo.txtnombreDepto.Text = txtnombre.Text
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
            txtcodigoArea.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtnombre.ReadOnly = False

            txtcodigoArea.ReadOnly = False
            btnArea.Enabled = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txtcodigoArea.Text = ""
        txtnombreArea.Text = ""
        txtNombreB.Text() = ""

        txtnombre.ReadOnly = False

        txtcodigoArea.ReadOnly = False

        btnArea.Enabled = True

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

            If (Trim(txtnombre.Text) <> "" And Trim(txtcodigoArea.Text) <> "") Then
                'Dim objDepto As New ClsDepartamento
                With objDepto
                    .Nombre_ = txtnombre.Text
                    .codigoArea_ = txtcodigoArea.Text
                End With

                If objDepto.RegistrarNuevaDepartamento() = 1 Then
                    MsgBox("Registrado el departamento correctamente.")

                    Dim dv As DataView = objDepto.SeleccionarDepartamento.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    txtcodigoArea.ReadOnly = True
                    btnArea.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el departamento.", MsgBoxStyle.Critical)
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

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "" And Trim(txtcodigoArea.Text) <> "") Then
                txtnombre.Text = sinDobleEspacio(txtnombre.Text)
                'Dim objDepto As New ClsDepartamento
                With objDepto
                    .Nombre_ = txtnombre.Text
                    .codigo_ = txtcodigo.Text
                    .codigoArea_ = txtcodigoArea.Text
                End With

                If objDepto.ModificarDepartamento() = 1 Then
                    MsgBox("Modificado el departamento correctamente.")

                    Dim dv As DataView = objDepto.SeleccionarDepartamento.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    txtcodigoArea.ReadOnly = True
                    btnArea.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el departamento.", MsgBoxStyle.Critical)
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
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Try
            'Dim objDepto As New ClsDepartamento
            With objDepto
                .Nombre_ = txtNombreB.Text
            End With

            If (Trim(txtNombreB.Text) <> "") Then
                Dim dv As DataView = objDepto.BuscarDepartamentoNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                Dim dv As DataView = objDepto.SeleccionarDepartamento.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtcodigoArea_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoArea.TextChanged
        txtnombreArea.Text = ""
        If (Trim(txtcodigoArea.Text) <> "") Then
            Try
                Dim objArea As New ClsArea
                With objArea
                    .codigo_ = txtcodigoArea.Text
                End With
                Dim dt As New DataTable
                dt = objArea.BuscarArea()
                Dim row As DataRow = dt.Rows(0)
                txtnombreArea.Text = CStr(row("nombre"))
                txtcodigoArea.BackColor = Color.White
            Catch ex As Exception
                txtcodigoArea.BackColor = Color.Red
                txtnombreArea.Text = ""
            End Try
        Else
            txtcodigoArea.Text = ""
            txtnombreArea.Text = ""
            txtcodigoArea.BackColor = Color.White
        End If
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        M_Area.lblform.Text = "M_Departamento"
        M_Area.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class