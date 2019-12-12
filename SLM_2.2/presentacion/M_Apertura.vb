Public Class M_Apertura
    Private Sub M_Apertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHora.Text = Date.Now.ToLongTimeString
        txtFecha.Text = Date.Today

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtFondo.Text = ""
        Me.Close()
    End Sub
    Private Sub txtFondo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFondo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
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
                    MsgBox("Apertura de caja realizada correctamente.", MsgBoxStyle.Critical)
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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtFondo.Text = ""
    End Sub
End Class