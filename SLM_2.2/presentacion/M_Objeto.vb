﻿Public Class M_Objeto
    Private Sub M_Objeto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objObj As New ClsObjeto
        Dim dv As DataView = objObj.SeleccionarObjeto.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True
        txtcodigoTipo.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True

        dgbtabla.Columns("codigo").Visible = False
        alternarColoFilasDatagridview(dgbtabla)
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And txtcodigoTipo.BackColor = Color.White) Then
                Dim objObj As New ClsObjeto
                With objObj
                    .objeto_ = txtcodigo.Text
                    .nombre_ = txtnombre.Text
                    .tipoObjeto_ = lblcodeTipoObjeto.Text
                    .cerrado_ = cbxcerrado.Checked
                End With

                If objObj.RegistrarNuevoObjeto() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objObj.SeleccionarObjeto.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True
                    btnbuscarTipo.Enabled = False
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el objeto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Error al querer ingresar el objeto.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "" And Trim(txtcodigoTipo.Text) <> "" And txtcodigoTipo.BackColor = Color.White) Then
                Dim objObj As New ClsObjeto
                With objObj
                    .codigo_ = lblcode.Text
                    .objeto_ = txtcodigo.Text
                    .nombre_ = txtnombre.Text
                    .tipoObjeto_ = lblcodeTipoObjeto.Text
                    .cerrado_ = cbxcerrado.Checked
                End With

                If objObj.ModificarObjeto() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objObj.SeleccionarObjeto.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True
                    btnbuscarTipo.Enabled = False
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el objeto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Error al querer modificar el objeto.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txtcodigoTipo.Text() = ""

        cbxcerrado.Checked = False
        txtcodigoTipo.ReadOnly = False
        txtnombre.ReadOnly = False
        txtcodigo.ReadOnly = False
        btnbuscarTipo.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            lblcodeTipoObjeto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            txtcodigoTipo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            cbxcerrado.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtnombre.ReadOnly = False
            txtcodigoTipo.ReadOnly = False
            txtcodigo.ReadOnly = False
            btnbuscarTipo.Enabled = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objObj As New ClsObjeto
            With objObj
                .nombre_ = txtnombreB.Text
            End With

            If (Trim(txtnombreB.Text) <> "") Then
                Dim dv As DataView = objObj.BuscarObjeto.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objObj.SeleccionarObjeto.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_TipoObjeto.Show()
    End Sub

    Private Sub txtcodigoTipo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTipo.TextChanged
        lblcodeTipoObjeto.Text = ""
        txtcomentarioTipo.Text = ""
        If (Trim(txtcodigoTipo.Text) <> "") Then
            Try
                Dim objTipoObj As New ClsTipoObjeto
                With objTipoObj
                    .codigoTipoObjeto_ = txtcodigoTipo.Text
                End With
                Dim dt As New DataTable
                dt = objTipoObj.BuscarTipoObjetoCode()
                Dim row As DataRow = dt.Rows(0)
                txtcomentarioTipo.Text = CStr(row("comentario"))
                lblcodeTipoObjeto.Text = CStr(row("codigo"))
                txtcodigoTipo.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTipo.BackColor = Color.Red
                txtcomentarioTipo.Text = ""
            End Try
        Else
            txtcodigoTipo.Text = ""
            lblcodeTipoObjeto.Text = ""
            txtcomentarioTipo.Text = ""
            txtcodigoTipo.BackColor = Color.White
        End If
    End Sub
End Class