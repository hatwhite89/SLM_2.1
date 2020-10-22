Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Notificación
        'ApruebaS.Show()

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
            ElseIf Convert.ToInt32(rowD("diasFaltantes")) < 0 Then
                A_Notificacion.lblMensajeDias.Visible = True
                A_Notificacion.Show()
            End If

        Catch ex As Exception

        End Try
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click

        If PanelAlmacen.Visible = True Or PanelFactura.Visible = True Or PanelLab.Visible = True Or PanelSistema.Visible = True Or PanelTalentoHumano.Visible = True Then
            PanelSistema.Visible = False
            PanelFactura.Visible = False
            PanelLab.Visible = False
            PanelAlmacen.Visible = False
            PanelTalentoHumano.Visible = False
            panelMenu.Visible = True

        Else
            panelMenu.Visible = True


        End If

    End Sub
    Private Sub btnlaboratorio_Click(sender As Object, e As EventArgs) Handles btnlaboratorio.Click

        Try


            If PanelAlmacen.Visible = True Or PanelFactura.Visible = True Or panelMenu.Visible = True Or PanelSistema.Visible = True Or PanelTalentoHumano.Visible = True Then
                PanelFactura.Visible = False
                panelMenu.Visible = False
                PanelSistema.Visible = False
                PanelLab.Visible = True
                PanelAlmacen.Visible = False
                PanelTalentoHumano.Visible = False
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


            If PanelAlmacen.Visible = True Or panelMenu.Visible = True Or PanelLab.Visible = True Or PanelSistema.Visible = True Or PanelTalentoHumano.Visible = True Then
                PanelFactura.Visible = True
                PanelLab.Visible = False
                panelMenu.Visible = False
                PanelSistema.Visible = False
                PanelAlmacen.Visible = False
                PanelTalentoHumano.Visible = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnChequera.Click

        Try
            A_Chequera.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCheques.Click

        Try
            A_ListadoCheques.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnFacturaCompra.Click

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click

        Try

            M_Precio.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click

        Try
            M_Descuentos.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnListaPrecio.Click

        Try

            M_ListadoDePrecios.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnPromociones.Click

        Try
            A_ListarPromociones.Show()
        Catch ex As Exception
            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnPeriodoContable.Click
        Try

            A_PeriodoContable.Show()
        Catch ex As Exception

            MsgBox("Error al abrir el formulario.Detalles: " + ex.Message)
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnAsientos.Click
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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnPacienteF.Click
        M_Cliente.ShowDialog()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Me.Close()
        End

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PanelLab.Visible = False
    End Sub

    Private Sub btnAcerca_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SLMSportToolStripMenuItem_Click(sender As Object, e As EventArgs)

        ' Apariencia.SkinFile = "C:\Users\Software 3\Source\Repos\hatwhite89\SLM_2.1\SLM_2.2\Themes\Componentes Graficos Vb2\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Sports\SportsBlue.ssk"

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCAI.Click
        Try

            A_ListarCAI.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        A_Notificacion.Show()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        AA_Guardado.Show()
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click

        Try

            A_Consolidacion.Show()

        Catch ex As Exception
            MsgBox("Error al abrir el formulario. Error: " + ex.Message)
        End Try

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Version 0.01")
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles pbxNoti.Click
        A_Alertas.Show()
    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        panelMenu.Visible = False
    End Sub

    Private Sub btnSistema_Click(sender As Object, e As EventArgs) Handles btnSistema.Click

        If PanelAlmacen.Visible = True Or PanelFactura.Visible = True Or PanelLab.Visible = True Or panelMenu.Visible = True Or PanelTalentoHumano.Visible = True Then

            PanelFactura.Visible = False
            PanelLab.Visible = False
            panelMenu.Visible = False
            PanelTalentoHumano.Visible = False
            PanelAlmacen.Visible = False
            PanelSistema.Visible = True

        Else
            PanelSistema.Visible = True


        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PanelSistema.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        E_Usuarios.Show()
    End Sub

    Private Sub btnTrabajo_Click(sender As Object, e As EventArgs) Handles btnTrabajo.Click
        'E_frmUbicacion.Show()
        E_ListarOrdenesDeTrabajo.ShowDialog()
    End Sub

    'Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
    '    E_frmTipoMovientoAlmacen.Show()
    'End Sub


    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles btnDepreciacion.Click
        Try
            A_ListarDepreciacion.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try


            M_InicioSesion.Show()

            Me.Close()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnServidorCorreo_Click(sender As Object, e As EventArgs)
        Try
            A_ConfiguracionCorreo.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTalentoHumano_Click(sender As Object, e As EventArgs) Handles btnTalentoHumano.Click

        If PanelAlmacen.Visible = True Or PanelFactura.Visible = True Or PanelLab.Visible = True Or panelMenu.Visible = True Or PanelSistema.Visible = True Then
            PanelTalentoHumano.Visible = True
            PanelFactura.Visible = False
            PanelLab.Visible = False
            panelMenu.Visible = False
            PanelSistema.Visible = False
            PanelAlmacen.Visible = False


        Else
            PanelTalentoHumano.Visible = True

        End If
    End Sub

    Private Sub btnCerrarTalentoHumano_Click(sender As Object, e As EventArgs) Handles btnCerrarTalentoHumano.Click
        PanelTalentoHumano.Visible = False
    End Sub

    Private Sub btnPuestoTrabajo_Click(sender As Object, e As EventArgs) Handles btnPuestoTrabajo.Click

        M_PuestoTrabajo.ShowDialog()
    End Sub

    Private Sub btnHorarios_Click(sender As Object, e As EventArgs) Handles btnHorarios.Click
        M_Horarios.lblform.Text = "M_Horarios"
        M_Horarios.ShowDialog()
    End Sub

    Private Sub btnContratos_Click(sender As Object, e As EventArgs) Handles btnContratos.Click
        M_Contratos.ShowDialog()
    End Sub

    Private Sub btnSucursales_Click(sender As Object, e As EventArgs) Handles btnSucursales.Click
        M_Sucursal.lblform.Text = "M_Sucursal"
        M_Sucursal.ShowDialog()
    End Sub

    Private Sub btnPermisos_Click(sender As Object, e As EventArgs) Handles btnPermisos.Click
        M_Permisos.lblform.Text = "M_Permisos"
        M_Permisos.ShowDialog()
    End Sub

    Private Sub btnVacaciones_Click(sender As Object, e As EventArgs) Handles btnVacaciones.Click
        M_Vacaciones.lblform.Text = "M_Vacaciones"
        M_Vacaciones.ShowDialog()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        M_BuscarEmpleados.ShowDialog()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click

        If PanelTalentoHumano.Visible = True Or PanelFactura.Visible = True Or PanelLab.Visible = True Or panelMenu.Visible = True Or PanelSistema.Visible = True Then

            PanelFactura.Visible = False
            PanelLab.Visible = False
            panelMenu.Visible = False
            PanelSistema.Visible = False
            PanelTalentoHumano.Visible = False
            PanelAlmacen.Visible = True
        Else
            PanelAlmacen.Visible = True


        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        E_frmProducto.Show()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        E_frmCategoriaProducto.Show()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles btnUnidadMedida.Click
        E_frmUnidadMedida_almacen.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        E_frmUbicacion.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles btnOrdeCompra.Click
        E_frmOrdenCompra.Show()
    End Sub

    Private Sub btnPerfiles_Click(sender As Object, e As EventArgs) Handles btnPerfiles.Click
        A_PerfilUsuario.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        E_frmEntrada.Show()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles btnSalidas.Click
        E_frmSalida.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btnOrdenInterna.Click
        E_frmSolicitudInternaAlmacen.Show()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub btnServidorCorreo_Click_1(sender As Object, e As EventArgs) Handles btnServidorCorreo.Click
        Try
            A_ConfiguracionCorreo.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        A_Proveedor.Show()
    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs)
        E_frmInventario.Show()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        E_frmAutorizarOC.Show()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)
        E_frmBIAlmacen.Show()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs)
        A_FacturaCompras.Show()
    End Sub

    Private Sub btnProfesion_Click(sender As Object, e As EventArgs) Handles btnProfesion.Click
        M_Profesion.lblform.Text = "M_Profesion"
        M_Profesion.ShowDialog()
    End Sub

    Private Sub btnTipoDeducciones_Click(sender As Object, e As EventArgs) Handles btnTipoDeducciones.Click
        M_TipoDeducciones.lblform.Text = "M_TipoDeducciones"
        M_TipoDeducciones.ShowDialog()
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        M_Area.lblform.Text = "M_Area"
        M_Area.ShowDialog()
    End Sub

    Private Sub btnDepto_Click(sender As Object, e As EventArgs) Handles btnDepto.Click
        M_Departamento.lblform.Text = "M_Departamento"
        M_Departamento.ShowDialog()
    End Sub

    Private Sub btnMaquinasLocales_Click(sender As Object, e As EventArgs) Handles btnMaquinasLocales.Click
        M_MaquinasLocales.lblform.Text = "Form1"
        M_MaquinasLocales.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        E_frmProcesarSolicitudInterna.ShowDialog()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        PanelAlmacen.Visible = False
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnValoresRef.Click
        Try

            A_ValoresRefPar.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnApertura_Click(sender As Object, e As EventArgs) Handles btnApertura.Click
        M_Apertura.ShowDialog()
    End Sub

    Private Sub btnHojaTrabajo_Click(sender As Object, e As EventArgs) Handles btnHojaTrabajo.Click
        E_EspecificarHojaTrabajo.ShowDialog()
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        Try
            A_Informes.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gbxMenu_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub bntCerrar_Click(sender As Object, e As EventArgs) Handles bntCerrar.Click
        Try

            Me.Close()
            End

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        End

    End Sub

    Private Sub banner_Click(sender As Object, e As EventArgs) Handles banner.Click

    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        E_frmInventario.Show()
    End Sub

    Private Sub btnBI_Click(sender As Object, e As EventArgs) Handles btnBI.Click
        E_frmBIAlmacen.Show()
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        E_frmProcesarSolicitudInterna.Show()
    End Sub

    Private Sub btnAutorizacion_Click(sender As Object, e As EventArgs) Handles btnAutorizacion.Click
        E_frmAutorizarOC.Show()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        A_Proveedor.Show()
    End Sub

    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles Button2.Click
        frmMovimientoAlmacen.Show()
    End Sub

    Private Sub btnGrupoExamenes_Click(sender As Object, e As EventArgs) Handles btnGrupoExamenes.Click
        Try
            E_GrupoExamen.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSubAreas_Click(sender As Object, e As EventArgs) Handles btnSubAreas.Click

        Try
            E_SubArea.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnFactCompra_Click(sender As Object, e As EventArgs) Handles btnFactCompra.Click
        A_FacturaCompras.Show()
    End Sub

    Private Sub btnCandidatos_Click(sender As Object, e As EventArgs) Handles btnCandidatos.Click
        Try
            A_Candidatos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCapacitaciones_Click(sender As Object, e As EventArgs) Handles btnCapacitaciones.Click
        Try

            M_BuscarCapacitaciones.lblform.Text = "M_BuscarCapacitaciones"
            M_BuscarCapacitaciones.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTipoPermiso_Click(sender As Object, e As EventArgs) Handles btnTipoPermiso.Click
        Try
            M_TipoPermiso.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnReporteria_Click(sender As Object, e As EventArgs) Handles btnReporteria.Click
        Try
            M_ReporteriaTalentoHumano.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConstanciaPlantillas_Click(sender As Object, e As EventArgs) Handles btnConstanciaPlantillas.Click

    End Sub

    Private Sub btnCategoriaCliente_Click(sender As Object, e As EventArgs) Handles btnCategoriaCliente.Click
        Try
            M_Categoria.lblform.Text = "Form1"
            M_Categoria.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTipoClasificacion_Click(sender As Object, e As EventArgs) Handles btnTipoClasificacion.Click
        Try
            M_TipoClasificacion.lbltipo.Text = "Form1"
            M_TipoClasificacion.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPlanilla_Click(sender As Object, e As EventArgs) Handles btnPlanilla.Click
        Try
            A_BuscarPlanilla.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFeriados_Click(sender As Object, e As EventArgs) Handles btnFeriados.Click
        A_ConfiguracionFeriados.Show()
    End Sub

    Private Sub btnEvaluacionP_Click(sender As Object, e As EventArgs) Handles btnEvaluacionP.Click
        frmEvaluacionProveedores.Show()
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Button1.Click
        frmSolicitudNuevoProducto.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        frmAdministrarRequisiciones.Show()
    End Sub
End Class
