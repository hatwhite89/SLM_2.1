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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Validar campos vacios
        If txtCosto.Text <> "" And txtValorResidual.Text <> "" Then

            With Depreciacion
                'VARIABLES DE DEPRECIACION
                .Descripcion_ = txtDescripcion.Text
                .Costo_Activo = Convert.ToDouble(txtCosto.Text)
                .Valor_Residual = Convert.ToDouble(txtValorResidual.Text)
                .Fecha_Creacion = dtpCreacion.Value
                .Fecha_Calculo = dtpFechaCalculo.Value
                .Tipo = Convert.ToInt16(lblTipo.Text)
                'REGISTRO DE DATOS DE DEPRECIACION
                If .registrarDepreciacion() = 1 Then
                    MsgBox("El registro se guardo correctamente.")
                    limpia()
                End If
            End With

        ElseIf txtCosto.Text = "" Then 'Si esta vacio marcar en rojo

            txtCosto.ForeColor = Color.Red

        ElseIf txtValorResidual.Text = "" Then 'Si esta vacio marcar en rojo

            txtValorResidual.ForeColor = Color.Red

        End If

    End Sub

    Sub limpia()

        txtCod.Text = ""
        txtDescripcion.Text = ""
        txtCosto.Text = ""
        txtValorResidual.Text = ""
        dtpCreacion.Value = DateTime.Now
        dtpFechaCalculo.Value = DateTime.Now
        rbtAnual.Checked = False
        rbtMensual.Checked = False
        rbtDiaria.Checked = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpia()

    End Sub
End Class