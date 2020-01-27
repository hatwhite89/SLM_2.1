Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba Cambio
    End Sub
    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click

        panelMenu.Visible = True

    End Sub
    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click

        Try
            M_MenuLaboratorio.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            E_DetalleExamenes.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click

        Try
            M_MenuFacturacion.ShowDialog()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        panelMenu.Visible = False

    End Sub

    Private Sub btnDepoBanc_Click(sender As Object, e As EventArgs) Handles btnDepoBanc.Click

        Try
            frmTipoDeposito.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click

        Try
            A_ListarPagos.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            A_Chequera.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            A_ListadoCheques.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try

            A_ListadoFacturaCompra.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click


        Try

            frmFormaPago.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click


        Try

            A_Bancos.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCuentas_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click


        Try

            A_Cuenta.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCategoriaProveedor_Click(sender As Object, e As EventArgs) Handles btnCategoriaProveedor.Click


        Try

            A_CategoriaProveedor.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click

        Try

            A_Proveedor.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try

            M_Precio.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try
            M_Descuentos.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try

            M_ListaPrecios.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Try
            A_ListarPromociones.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try

            A_PeriodoContable.Show()
        Catch ex As Exception

            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            A_ListadoAsientos.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub


End Class
