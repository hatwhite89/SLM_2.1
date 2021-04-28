Public Class M_BuscarClientes
    Dim objCli As New ClsCliente
    Dim dv As DataView
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        M_Contratos.GridAExcel(dgbtabla)
    End Sub
    Private Sub ocultarColumnas()
        'OCULTAR COLUMNAS
        'Me.dgbtabla.Columns("direccion").Visible = False
        'Me.dgbtabla.Columns("telCasa").Visible = False
        'Me.dgbtabla.Columns("telTrabajo").Visible = False
        'Me.dgbtabla.Columns("celular").Visible = False
        Me.dgbtabla.Columns("codigoClasificacion").Visible = False
        Me.dgbtabla.Columns("codigoTerminoPago").Visible = False
        Me.dgbtabla.Columns("codigoCategoria").Visible = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim identidad = Nothing, rtn = Nothing, nombre1 = Nothing, nombre2 = Nothing, apellido1 = Nothing, apellido2 As String = Nothing, genero = Nothing, clasificacion As String = Nothing, categoria = Nothing, termino As String = Nothing
            Dim codigo As System.Nullable(Of Integer) = Nothing
            Dim correo_1 = Nothing, celular As String = Nothing

            If Trim(txtCodigo.Text) <> "" Then
                codigo = Integer.Parse(txtCodigo.Text)
            Else
                codigo = Nothing
            End If
            If Trim(txtIdentidad.Text) <> "" Then
                identidad = txtIdentidad.Text
            Else
                identidad = Nothing
            End If
            If Trim(txtRTN.Text) <> "" Then
                rtn = txtRTN.Text
            Else
                rtn = Nothing
            End If
            If Trim(txtNombre1.Text) <> "" Then
                nombre1 = txtNombre1.Text
            Else
                nombre1 = Nothing
            End If
            If Trim(txtNombre2.Text) <> "" Then
                nombre2 = txtNombre2.Text
            Else
                nombre2 = Nothing
            End If
            If cmbxGenero.SelectedItem = "Masculino" Then
                genero = "Masculino"
            ElseIf cmbxGenero.SelectedItem = "Femenino" Then
                genero = "Femenino"
            Else
                genero = Nothing
            End If
            If Trim(txtApellido1.Text) <> "" Then
                apellido1 = txtApellido1.Text
            Else
                apellido1 = Nothing
            End If
            If Trim(txtApellido2.Text) <> "" Then
                apellido2 = txtApellido2.Text
            Else
                apellido2 = Nothing
            End If
            If Trim(txtnombreClasificacion.Text) <> "" Then
                clasificacion = txtnombreClasificacion.Text
            Else
                clasificacion = Nothing
            End If
            If Trim(txtCategoria.Text) <> "" Then
                categoria = txtCategoria.Text
            Else
                categoria = Nothing
            End If
            If Trim(txtTermino.Text) <> "" Then
                termino = txtTermino.Text
            Else
                termino = Nothing
            End If
            If Trim(txtcorreo1.Text) <> "" Then
                correo_1 = txtcorreo1.Text
            Else
                correo_1 = Nothing
            End If
            If Trim(txtCelular.Text) <> "" Then
                celular = txtCelular.Text
            Else
                celular = Nothing
            End If


            'MsgBox(numero & nombreCompleto & fechaFactura & nombreMedico & descripcionTermino & estado & usuarioCajero & "desde" & fechaDesde & "fhasta" & fechaHasta & descripcionExamen & descripcionGrupo)
            'Llenado de la tabla al llamar al procedimiento almacenado
            dv = objCli.BuscarClienteInfo(codigo, identidad, rtn, nombre1, nombre2, apellido1, apellido2, genero, clasificacion, categoria, termino, correo_1, celular).DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            ocultarColumnas()
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub M_BuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dgbtabla)
    End Sub

    Private Sub btnTipoClasificacion_Click(sender As Object, e As EventArgs) Handles btnTipoClasificacion.Click
        M_TipoClasificacion.lbltipo.Text = "M_BuscarClientes"
        M_TipoClasificacion.Show()
    End Sub

    Private Sub btnTerminoPago_Click(sender As Object, e As EventArgs) Handles btnTerminoPago.Click
        M_TerminosPago.lblform.Text = "M_BuscarClientes"
        M_TerminosPago.Show()
    End Sub

    Private Sub btnCategoriaCliente_Click(sender As Object, e As EventArgs) Handles btnCategoriaCliente.Click
        M_Categoria.lblform.Text = "M_BuscarClientes"
        M_Categoria.Show()
    End Sub

    Private Sub M_BuscarClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If (e.KeyCode = Keys.Escape) Then
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try

            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver la información del cliente?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                M_Cliente.gbxinfoCliente.Visible = True


                M_Cliente.txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                M_Cliente.txtscanId.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                M_Cliente.mtxtidentidad.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                M_Cliente.txtrtn.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                M_Cliente.txtnombre1.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                M_Cliente.txtnombre2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
                M_Cliente.txtapellido1.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                M_Cliente.txtapellido2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                M_Cliente.dtpfechaNacimiento.Value = Convert.ToDateTime(Me.dgbtabla.Rows(e.RowIndex).Cells(9).Value())
                If Trim(Me.dgbtabla.Rows(e.RowIndex).Cells(10).Value().ToString) = "Masculino" Then
                    M_Cliente.rbtnmasculino.Checked = True
                Else
                    M_Cliente.rbtnfemenino.Checked = True
                End If
                M_Cliente.rtxtdireccion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(11).Value()
                M_Cliente.txttelefonoCasa.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(12).Value()
                M_Cliente.txttelefonoTrabajo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(13).Value()
                M_Cliente.txtcelular.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(14).Value()
                M_Cliente.txtcorreo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(15).Value()
                M_Cliente.txtcorreo2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(16).Value()
                M_Cliente.lblcodeCategoria.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(18).Value()
                M_Cliente.lblcodeTerminoPago.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(19).Value()
                M_Cliente.cmbxClasificacion.SelectedValue = Me.dgbtabla.Rows(e.RowIndex).Cells(17).Value()

                'Seleccionar al cliente en la factura
                M_Cliente.btnseleccionarCliente.Enabled = True

                Me.Close()
                M_Cliente.Show()
                M_Cliente.BringToFront()
                M_Cliente.WindowState = WindowState.Normal
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class