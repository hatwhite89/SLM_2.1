﻿Public Class M_TipoObjeto
    Private Sub M_TipoObjeto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objTipoObj As New ClsTipoObjeto
        Dim dv As DataView = objTipoObj.SeleccionarTipoObjeto.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        rtxtcomentario.ReadOnly = True
        txtcodigo.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (txtcodigo.Text <> "" And rtxtcomentario.Text <> "") Then
                Dim objTipoObj As New ClsTipoObjeto
                With objTipoObj
                    .codigo_ = txtcodigo.Text
                    .comentario_ = rtxtcomentario.Text
                End With

                If objTipoObj.RegistrarNuevoTipoObjeto() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objTipoObj.SeleccionarTipoObjeto.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    txtcodigo.ReadOnly = True
                    rtxtcomentario.ReadOnly = True
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el tipo de objeto.", MsgBoxStyle.Critical)
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

            If (rtxtcomentario.Text <> "" And txtcodigo.Text <> "") Then
                Dim objTipoObj As New ClsTipoObjeto
                With objTipoObj
                    .codigo_ = txtcodigo.Text
                    .comentario_ = rtxtcomentario.Text
                End With

                If objTipoObj.ModificarTipoObjeto() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objTipoObj.SeleccionarTipoObjeto.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtcomentario.ReadOnly = True
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el tipo de objeto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text() = ""
        rtxtcomentario.Text() = ""

        rtxtcomentario.ReadOnly = False
        txtcodigo.ReadOnly = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtcomentario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            btnmodificar.Enabled = True
            rtxtcomentario.ReadOnly = False
            txtcodigo.ReadOnly = True
            M_Objeto.txtcodigoTipo.Text = txtcodigo.Text
            M_Objeto.txtcomentarioTipo.Text = rtxtcomentario.Text
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcomentarioB_TextChanged(sender As Object, e As EventArgs) Handles txtcomentarioB.TextChanged
        If (txtcomentarioB.Text <> "") Then
            Dim objTipoObj As New ClsTipoObjeto
            With objTipoObj
                .comentario_ = txtcomentarioB.Text
            End With
            Dim dv As DataView = objTipoObj.BuscarTipoObjeto.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub
End Class