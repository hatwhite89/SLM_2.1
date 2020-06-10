﻿Public Class M_Apertura
    Private Sub M_Apertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub buscarMaquinaLocal()
        Try
            Dim objMaq As New ClsMaquinasLocales
            With objMaq
                .descripcion_ = System.Environment.MachineName
            End With
            Dim dt As New DataTable
            dt = objMaq.BuscarMaquinasLocalesDesc()
            Dim row As DataRow = dt.Rows(0)
            lblcodeMaquinaLocal.Text = CStr(row("codigo"))
            txtMaquinaLocal.Text = CStr(row("codigoMaquinasLocales"))
        Catch ex As Exception
            lblcodeMaquinaLocal.Text = ""
            txtMaquinaLocal.Text = ""
        End Try
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Trim(txtFondo.Text) <> "" Then
            Try
                Dim fecha As Date = txtHora.Text + txtFecha.Text
                Dim objAper As New ClsApertura
                With objAper
                    .codigoMaquinaLocal_ = lblcodeMaquinaLocal.Text
                    .codigoCajero_ = lblcodeCajero.Text
                    .fecha_ = fecha
                    .fondo_ = txtFondo.Text
                    .estado_ = txtEstado.Text
                End With

                If objAper.RegistrarNuevaApertura() = 1 Then
                    MsgBox("Apertura de caja registrada correctamente.")
                    Me.Close()
                Else
                    MsgBox("Error al querer guardar la apertura.", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Debe ingresar el fondo.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub limpiar()
        txtFondo.Text = ""
        txtHora.Text = Date.Now.ToLongTimeString
        txtFecha.Text = Date.Today
        buscarMaquinaLocal()
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
End Class