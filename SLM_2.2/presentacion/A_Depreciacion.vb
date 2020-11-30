Public Class A_Depreciacion

    'Falta Agregar Conexion de Base de datos.Solo calcula en ventana.
    'Falta Agregar Validación en campos.
    'Posible agregar procedimiento para impresion en CrystalReport.

    Private Formato_Decimales As String = "###,###,###,##.00"
    Dim Depreciacion As New ClsDepreciacion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        dtDepreciacion.Rows.Clear()
        dtDepreciacion.DataSource = Nothing
        Calcular_Depreciacion()
    End Sub

    'Calculo de Depreciación
    Sub Calcular_Depreciacion()
        Try

            Dim coste As Decimal = Convert.ToDecimal(txtCosto.Text)
            Dim vr As Decimal = Convert.ToDecimal(txtValorResidual.Text)
            Dim d As Decimal = 0
            Dim vu As Integer = 0
            Dim f As Decimal = 0
            Dim f2 As Decimal = 0
            Dim liDias As Integer
            Dim liMeses As Integer
            Dim liAños As Integer
            Dim variable As String = ""

            liAños = DateDiff(DateInterval.Year, dtpCreacion.Value.Date, dtpFechaCalculo.Value.Date)
            liMeses = DateDiff(DateInterval.Month, dtpCreacion.Value.Date, dtpFechaCalculo.Value.Date)
            liDias = DateDiff(DateInterval.Day, dtpCreacion.Value.Date, dtpFechaCalculo.Value.Date)

            'Seleccion de Depreciacion
            If (rbtAnual.Checked) Then
                vu = liAños + 1
            ElseIf (rbtMensual.Checked) Then
                vu = liMeses + 11
            Else
                vu = liDias
            End If

            For i = 0 To vu - 1

                If (d <= coste) Then
                    d = (coste - vr) / vu
                End If

                If (dtDepreciacion.RowCount = 0) Then
                    f = d
                    f2 = coste - d
                    If (rbtAnual.Checked) Then
                        variable = dtpCreacion.Value.Date.Year.ToString
                    ElseIf (rbtMensual.Checked) Then
                        variable = (dtpCreacion.Value.Date).ToShortDateString.ToString
                    Else
                        variable = (dtpCreacion.Value.Date).ToShortDateString.ToString
                    End If
                    dtDepreciacion.Rows.Add(variable, d.ToString(Formato_Decimales), d.ToString(Formato_Decimales), f2.ToString(Formato_Decimales))
                Else
                    f = d + f
                    f2 = (coste - f)
                    If (rbtAnual.Checked) Then
                        variable = DateAdd(DateInterval.Year, i, dtpCreacion.Value.Date).Year.ToString
                    ElseIf (rbtMensual.Checked) Then
                        variable = DateAdd(DateInterval.Month, i, dtpCreacion.Value.Date).ToShortDateString.ToString
                    Else
                        variable = DateAdd(DateInterval.Day, i, dtpCreacion.Value.Date).ToShortDateString.ToString
                    End If
                    dtDepreciacion.Rows.Add(variable, d.ToString(Formato_Decimales), f.ToString(Formato_Decimales), f2.ToString(Formato_Decimales))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try
    End Sub 'Fin Calculo depreciación

    Private Sub rbtAnual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAnual.CheckedChanged
        'Tipo Depreciacion Anual
        lblTipo.Text = 1
    End Sub

    Private Sub rbtMensual_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMensual.CheckedChanged
        'Tipo Depreciacion Mensual
        lblTipo.Text = 2
    End Sub

    Private Sub rbtDiaria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiaria.CheckedChanged
        'Tipo Depreciacion Diaria
        lblTipo.Text = 3
    End Sub

    Sub limpia()

        txtCod.Text = ""
        txtDescripcion.Text = ""
        txtSede.Text = ""
        txtTipo.Text = ""
        txtCosto.Text = ""
        txtValorResidual.Text = ""
        dtpCreacion.Value = DateTime.Now
        dtpFechaCalculo.Value = DateTime.Now
        rbtAnual.Checked = False
        rbtMensual.Checked = False
        rbtDiaria.Checked = False
        dtDepreciacion.DataSource = ""

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpia()

    End Sub

    Private Sub A_Depreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtCod.Text <> "" Then

            If lblTipo.Text = "1" Then
                rbtAnual.Checked = True
            ElseIf lblTipo.Text = "2" Then
                rbtMensual.Checked = True
            Else
                rbtDiaria.Checked = True
            End If

            Calcular_Depreciacion()

        End If
        alternarColoFilasDatagridview(dtDepreciacion)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            'Listado Sucursales
            M_Sucursal.Show()
            M_Sucursal.lblform.Text = "Depreciacion"

        Catch ex As Exception
            MsgBox("Error al cargar la información. Detalle:" + ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Registro de depreciacion

        Try


            If txtTipo.Text <> "" And txtDescripcion.Text <> "" And txtCosto.Text <> "" And txtValorResidual.Text <> "" Then 'fin if validaciones


                With Depreciacion

                    .Tipo_Activo = txtTipo.Text
                    .Sede_ = txtSede.Text
                    .Descripcion_ = txtDescripcion.Text
                    .Costo_Activo = txtCosto.Text
                    .Valor_Residual = txtValorResidual.Text
                    .Fecha_Calculo = dtpFechaCalculo.Value
                    .Fecha_Creacion = dtpCreacion.Value
                    .Tipo = Convert.ToInt32(lblTipo.Text)

                    If .registrarDepreciacion = 1 Then
                        MsgBox("Se guardo el registro exitosamente.")
                        limpia()

                    End If

                End With

            ElseIf txtTipo.Text = "" Then
                txtTipo.BackColor = Color.Red
            ElseIf txtDescripcion.Text = "" Then
                txtDescripcion.BackColor = color.red
            ElseIf txtCosto.text = "" Then
                txtCosto.BackColor = Color.Red
            ElseIf txtValorResidual.Text = "" Then
                txtValorResidual.BackColor = Color.Red

            End If 'fin if validaciones

        Catch ex As Exception
            MsgBox("No se pudo crear el registro. Error: " + ex.Message)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'Modificar registro de depreciacion

        Try


            If txtTipo.Text <> "" And txtDescripcion.Text <> "" And txtCosto.Text <> "" And txtValorResidual.Text <> "" Then 'fin if validaciones


                With Depreciacion

                    .Cod = Convert.ToInt32(txtCod.Text)
                    .Tipo_Activo = txtTipo.Text
                    .Sede_ = txtSede.Text
                    .Descripcion_ = txtDescripcion.Text
                    .Costo_Activo = txtCosto.Text
                    .Valor_Residual = txtValorResidual.Text
                    .Fecha_Calculo = dtpFechaCalculo.Value
                    .Fecha_Creacion = dtpCreacion.Value
                    .Tipo = Convert.ToInt32(lblTipo.Text)

                    If .modificarDepreciacion = 1 Then
                        MsgBox("Se modificó el registro exitosamente.")
                        limpia()

                    End If

                End With

            ElseIf txtTipo.Text = "" Then
                txtTipo.BackColor = Color.Red
            ElseIf txtDescripcion.Text = "" Then
                txtDescripcion.BackColor = Color.Red
            ElseIf txtCosto.Text = "" Then
                txtCosto.BackColor = Color.Red
            ElseIf txtValorResidual.Text = "" Then
                txtValorResidual.BackColor = Color.Red

            End If 'fin if validaciones

        Catch ex As Exception
            MsgBox("No se pudo modificar el registro. Error: " + ex.Message)
        End Try

    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress

        'Numeros y comas
        NUMEROSCOMA(e, 2, sender)

    End Sub

    Private Sub txtValorResidual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorResidual.KeyPress
        'Numeros y comas
        NUMEROSCOMA(e, 2, sender)
    End Sub

    Private Sub A_Depreciacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Cerrar ventana
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

        Try
            'Genera excel desde el data Gridview
            E_frmInventario.GridAExcel(dtDepreciacion)



        Catch ex As Exception

        End Try


    End Sub
End Class