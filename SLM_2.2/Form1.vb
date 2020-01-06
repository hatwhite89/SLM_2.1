Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba Cambio
    End Sub
    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click
        'Abrir formulario menu contabilidad.
        'frmMenuConta.Show()


        While (panelMenu.Width < 375)
            panelMenu.Width += 1
        End While
        tcMenu.Visible = True
        btnContabilidad.BackColor = Color.White



    End Sub
    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click
        M_MenuLaboratorio.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        E_DetalleExamenes.Show()
    End Sub
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        M_MenuFacturacion.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        tcMenu.Visible = False
        While (panelMenu.Width > 20)
            panelMenu.Width -= 1
        End While

        btnContabilidad.BackColor = Color.LightGray
    End Sub

    Private Sub btnDepoBanc_Click(sender As Object, e As EventArgs) Handles btnDepoBanc.Click
        frmTipoDeposito.Show()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        A_ListarPagos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A_Chequera.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A_ListadoCheques.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        A_FacturaCompras.Show()
    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        frmFormaPago.Show()
    End Sub

    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click
        A_Bancos.Show()
    End Sub

    Private Sub btnCuentas_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        A_Cuenta.Show()
    End Sub

    Private Sub btnCategoriaProveedor_Click(sender As Object, e As EventArgs) Handles btnCategoriaProveedor.Click
        A_CategoriaProveedor.Show()
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        A_Proveedor.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
