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

            'MsgBox(numero & nombreCompleto & fechaFactura & nombreMedico & descripcionTermino & estado & usuarioCajero & "desde" & fechaDesde & "fhasta" & fechaHasta & descripcionExamen & descripcionGrupo)
            'Llenado de la tabla al llamar al procedimiento almacenado
            dv = objCli.BuscarClienteInfo(codigo, identidad, rtn, nombre1, nombre2, apellido1, apellido2, genero, clasificacion, categoria, termino).DefaultView
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
End Class