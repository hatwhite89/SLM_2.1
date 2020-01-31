﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prueba Cambio
    End Sub
    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click

        If PanelFactura.Visible = True Or PanelLab.Visible = True Then

            PanelFactura.Visible = False
            PanelLab.Visible = False
            panelMenu.Visible = True

        Else
            panelMenu.Visible = True
        End If

    End Sub
    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click

        Try
            If PanelFactura.Visible = True Or panelMenu.Visible = True Then
                PanelFactura.Visible = False
                panelMenu.Visible = False

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
            If panelMenu.Visible = True Or PanelLab.Visible = True Then
                PanelFactura.Visible = True
                PanelLab.Visible = False
                panelMenu.Visible = False
            Else
                PanelFactura.Visible = True
            End If
            'M_MenuFacturacion.ShowDialog()

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


    Private Sub SLMBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMBlueToolStripMenuItem.Click

        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Diamond\DiamondBlue.ssk"

    End Sub

    Private Sub SLMGrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMGrayToolStripMenuItem.Click
        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Emerald\EmeraldColor1.ssk"

    End Sub

    Private Sub SLMLongHordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMLongHordToolStripMenuItem.Click
        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Longhorn\Longhorn.ssk"

    End Sub

    Private Sub SLMLightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMLightToolStripMenuItem.Click

        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\MacOS\MacOS.ssk"


    End Sub

    Private Sub SLMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMToolStripMenuItem.Click

        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\RealOne\realone.ssk"

    End Sub

    Private Sub SLMSilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMSilverToolStripMenuItem.Click
        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Silver\silver.ssk"

    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        M_BuscarFactura.ShowDialog()
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
        M_Sede.ShowDialog()
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
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

    Private Sub btnAcerca_Click(sender As Object, e As EventArgs) Handles btnAcerca.Click
        MsgBox("Version 0.01")
    End Sub

    Private Sub SLMSportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLMSportToolStripMenuItem.Click
        Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Sports\SportsBlue.ssk"
    End Sub

End Class
