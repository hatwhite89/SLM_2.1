Public Class E_frmConfiguracionCorreoResultado
    Private Sub E_frmConfiguracionCorreoResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim correoSalida As String = "sinergia@laboratoriosmedicos.hn"
        Dim pass As String = "Lmsinergia2020"
        Dim puerto As String = "587"
        Dim sslOK As Boolean = True
        Dim host As String = "mail.laboratoriosmedicos.hn"

        Try
            Dim objP As New clsCorreoResultado

            Dim dt As New DataTable
            dt = objP.BuscarCorreo()
            Dim row As DataRow = dt.Rows(0)
            txtCorreo.Text = CStr(row("correo"))
            txtHost.Text = CStr(row("host"))
            txtPass.Text = CStr(row("pass"))
            txtPuerto.Text = CStr(row("puerto"))
            If CBool(row("ssl")) = 0 Then
                rbdFalso.Checked = True
            Else
                rsbVerdadero.Checked = True
            End If


        Catch ex As Exception



        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsC As New clsCorreoResultado
        Dim bandera As Boolean = 0
        If rsbVerdadero.Checked = True Then
            bandera = 1
        End If
        With clsC
            .CorreoSalida1 = txtCorreo.Text
            .Pass1 = txtPass.Text
            .Puerto1 = txtPuerto.Text
            .Host1 = txtHost.Text
            .SslOK1 = bandera
        End With
        If clsC.RegistrarAlmacen() = "1" Then
            MsgBox(mensaje_actualizacion)
        End If
    End Sub
End Class