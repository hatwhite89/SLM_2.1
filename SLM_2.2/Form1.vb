Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Notificación

        Dim cai As New ClsCAI
        Dim numfact, dias As DataTable
        Dim rowD, rowsF As DataRow

        numfact = cai.ContarFacturas
        dias = cai.DiaVencimiento

        Try
            rowD = dias.Rows(0)
            rowsF = numfact.Rows(0)

            If Convert.ToInt32(rowD("diasFaltantes")) < 7 Then

                A_Notificacion.lblMensajeDias.Visible = True
                A_Notificacion.Show()

            ElseIf Convert.ToInt32(rowsF("disponible")) < 150 Then

                A_Notificacion.lblMensajeFact.Visible = True
                A_Notificacion.Show()

            ElseIf Convert.ToInt32(rowD("diasFaltantes")) < 7 And Convert.ToInt32(rowsF("disponible")) < 150 Then

                A_Notificacion.lblMensajeFact.Visible = True
                A_Notificacion.lblMensajeDias.Visible = True
                A_Notificacion.Show()

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click

        If PanelFactura.Visible = True Or PanelLab.Visible = True Or PanelSistema.Visible = True Then
            PanelSistema.Visible = False
            PanelFactura.Visible = False
            PanelLab.Visible = False
            panelMenu.Visible = True

        Else
            panelMenu.Visible = True
        End If

    End Sub
    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click

        Try


            If PanelFactura.Visible = True Or panelMenu.Visible = True Or PanelSistema.Visible = True Then
                PanelFactura.Visible = False
                panelMenu.Visible = False
                PanelSistema.Visible = False
                PanelLab.Visible = True
            Else
                PanelLab.Visible = True

            End If


            'M_MenuLaboratorio.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Try
            E_DetalleExamenes.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub
    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click

        Try


            If panelMenu.Visible = True Or PanelLab.Visible = True Or PanelSistema.Visible = True Then
                PanelFactura.Visible = True
                PanelLab.Visible = False
                panelMenu.Visible = False
                PanelSistema.Visible = False
            Else
                PanelFactura.Visible = True
            End If


            'M_MenuFacturacion.ShowDialog()

        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)



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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
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


    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Try
            M_BuscarFactura.ShowDialog()

        Catch ex As Exception
            M_BuscarFactura.Close()
            M_BuscarFactura.ShowDialog()
        End Try
    End Sub

    Private Sub btnCotizar_Click(sender As Object, e As EventArgs) Handles btnCotizar.Click
        M_BuscarCotizacion.ShowDialog()
    End Sub

    Private Sub btnRecibos_Click(sender As Object, e As EventArgs) Handles btnRecibos.Click
        M_BuscarRecibo.ShowDialog()
    End Sub

    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        A_Proveedor.ShowDialog()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        E_DetalleExamenes.ShowDialog()
    End Sub

    Private Sub btnGrupo_Click(sender As Object, e As EventArgs) Handles btnGrupo.Click
        E_GrupoExamen.ShowDialog()
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs)
        M_Cliente.ShowDialog()
    End Sub

    Private Sub btnTermino_Click(sender As Object, e As EventArgs) Handles btnTermino.Click
        M_TerminosPago.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PanelFactura.Visible = False
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        M_ListarClientes.lblForm.Text = "VerPaciente"
        M_ListarClientes.ShowDialog()
    End Sub

    Private Sub btnExamen_Click(sender As Object, e As EventArgs) Handles btnExamen.Click
        E_DetalleExamenes.ShowDialog()
    End Sub

    Private Sub btnMedico_Click(sender As Object, e As EventArgs) Handles btnMedico.Click
        M_Medico.ShowDialog()
    End Sub

    Private Sub btnSede_Click(sender As Object, e As EventArgs) Handles btnSede.Click
        M_Sede.lblform.Text = "Sede"
        M_Sede.ShowDialog()
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        M_Sucursal.lblform.Text = "Sucursal"
        M_Sucursal.ShowDialog()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        M_Cliente.ShowDialog()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PanelLab.Visible = False
    End Sub

    Private Sub btnAcerca_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SLMSportToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Sports\SportsBlue.ssk"

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCAI.Click
        Try

            M_CAI.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        A_Notificacion.Show()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        A_Notificacion.Show()
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click

        Try

            A_Consolidacion.Show()

        Catch ex As Exception
            MsgBox("Error al abrir el formulario. Error: " + ex.Message)
        End Try

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Version 0.01")
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles pbxNoti.Click
        A_Alertas.Show()
    End Sub

    Private Sub panelMenu_Paint(sender As Object, e As PaintEventArgs) Handles panelMenu.Paint

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        panelMenu.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If PanelFactura.Visible = True Or PanelLab.Visible = True Or panelMenu.Visible = True Then

            PanelFactura.Visible = False
            PanelLab.Visible = False
            panelMenu.Visible = False
            PanelSistema.Visible = True
        Else
            PanelSistema.Visible = True
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PanelSistema.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        E_Usuarios.Show()
    End Sub

    Private Sub btnTrabajo_Click(sender As Object, e As EventArgs) Handles btnTrabajo.Click
        E_frmUbicacion.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        E_frmTipoMovientoAlmacen.Show()
    End Sub
End Class
