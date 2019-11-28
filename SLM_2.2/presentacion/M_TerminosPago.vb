Public Class M_TerminosPago
    Private Sub btntipoPago_Click(sender As Object, e As EventArgs) Handles btntipoPago.Click
        M_TipoTermino.ShowDialog()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub txtdiasNeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiasNeto.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodigoCtaContado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoCtaContado.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcodigoCtaVentas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoCtaVentas.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub M_TerminosPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objTerm As New ClsTerminoPago
        Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        rtxtdescripcion.ReadOnly = True
        txtdiasNeto.ReadOnly = True
        txtcodigoCtaContado.ReadOnly = True
        txtcodigoCtaVentas.ReadOnly = True
        txtcodigo.ReadOnly = True

        cbxtipoPago.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True

        Try
            Dim objTipoTerm As New ClsTipoTermino
            Dim dt As New DataTable
            dt = objTipoTerm.SeleccionarTipoTermino()
            Dim cant As Integer = dt.Rows.Count
            Dim row As DataRow
            cbxtipoPago.Items.Clear()
            For index As Integer = 0 To cant - 1
                row = dt.Rows(index)
                cbxtipoPago.Items.Add(CStr(row("descripcion")))
            Next
        Catch ex As Exception
            MsgBox("No existe el código del tipo de término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            Dim temp As Integer = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value().ToString
            cbxtipoPago.SelectedIndex = temp - 1
            If (lblform.Text = "factura") Then
                M_Factura.txtcodigoTerminosPago.Text = txtcodigo.Text
            ElseIf (lblform.Text = "cliente") Then
                M_Cliente.txtcodigoTermino.Text = txtcodigo.Text
                M_Cliente.txtnombreTerminos.Text = rtxtdescripcion.Text
            End If

            If (Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value() = 0) Then
                txtdiasNeto.Text = ""
            Else
                txtdiasNeto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            End If

            If (Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value() = 0) Then
                txtcodigoCtaContado.Text = ""
            Else
                txtcodigoCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            End If

            If (Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value() = 0) Then
                txtcodigoCtaVentas.Text = ""
            Else
                txtcodigoCtaVentas.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            End If
            cbxtipoPago.Enabled = True

            btnmodificar.Enabled = True

            rtxtdescripcion.ReadOnly = False
            txtdiasNeto.ReadOnly = False
            txtcodigoCtaContado.ReadOnly = False
            txtcodigoCtaVentas.ReadOnly = False
            txtcodigo.ReadOnly = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        rtxtdescripcion.Text() = ""
        txtdiasNeto.Text() = ""
        txtcodigoCtaContado.Text() = ""
        txtcodigoCtaVentas.Text() = ""
        cbxtipoPago.SelectedItem = cbxtipoPago.Items(0)

        rtxtdescripcion.ReadOnly = False
        txtdiasNeto.ReadOnly = False
        txtcodigoCtaContado.ReadOnly = False
        txtcodigoCtaVentas.ReadOnly = False
        txtcodigo.ReadOnly = False

        cbxtipoPago.Enabled = True
        btnbuscar.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim testString As String = cadena
        Dim texto As String = ""
        Dim testArray() As String = Split(testString)
        Dim lastNonEmpty As Integer = -1
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lastNonEmpty += 1
                testArray(lastNonEmpty) = testArray(i)
                texto += testArray(i) + " "
            End If
        Next
        ReDim Preserve testArray(lastNonEmpty)
        Return texto
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (cbxtipoPago.SelectedIndex.ToString > -1 And rtxtdescripcion.Text <> "" And txtcodigo.Text <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .Codigo1 = txtcodigo.Text
                    .Descripcion1 = rtxtdescripcion.Text
                    .codigoTipoTermino1 = Convert.ToInt32(cbxtipoPago.SelectedIndex.ToString) + 1
                End With

                If (txtcodigoCtaContado.Text <> "") Then
                    objTerm.codigoCtaContado1 = Convert.ToInt32(txtcodigoCtaContado.Text)
                ElseIf (txtcodigoCtaVentas.Text <> "") Then
                    objTerm.codigoCtaVentas1 = Convert.ToInt32(txtcodigoCtaVentas.Text)
                ElseIf (txtdiasNeto.Text <> "") Then
                    objTerm.diasNeto1 = Convert.ToInt32(txtdiasNeto.Text)
                End If

                If objTerm.RegistrarNuevaTerminoPago() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtdescripcion.ReadOnly = True
                    txtdiasNeto.ReadOnly = True
                    txtcodigoCtaContado.ReadOnly = True
                    txtcodigoCtaVentas.ReadOnly = True
                    txtcodigo.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el término de pago.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (txtcodigo.Text <> "" And rtxtdescripcion.Text <> "") Then

                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)

                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .Codigo1 = txtcodigo.Text
                    .Descripcion1 = rtxtdescripcion.Text
                    .codigoTipoTermino1 = Convert.ToInt32(cbxtipoPago.SelectedIndex.ToString) + 1
                End With

                If (txtcodigoCtaContado.Text <> "") Then
                    objTerm.codigoCtaContado1 = Convert.ToInt32(txtcodigoCtaContado.Text)
                ElseIf (txtcodigoCtaVentas.Text <> "") Then
                    objTerm.codigoCtaVentas1 = Convert.ToInt32(txtcodigoCtaVentas.Text)
                ElseIf (txtdiasNeto.Text <> "") Then
                    objTerm.diasNeto1 = Convert.ToInt32(txtdiasNeto.Text)
                End If

                If objTerm.ModificarTerminoPago() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtdescripcion.ReadOnly = True
                    txtdiasNeto.ReadOnly = True
                    txtcodigoCtaContado.ReadOnly = True
                    txtcodigoCtaVentas.ReadOnly = True
                    txtcodigo.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el término de pago.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim objTerm As New ClsTerminoPago
        With objTerm
            .Descripcion1 = txtdescripcionB.Text
        End With
        Dim dv As DataView = objTerm.BuscarTerminoPago.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub btnctaContado_Click(sender As Object, e As EventArgs) Handles btnctaContado.Click
        'Asignar valor a label para diferenciar campo a llenar.
        M_BuscarCuenta.lbltipoCta.Text = "Contado"
        M_BuscarCuenta.ShowDialog()
    End Sub
    Private Sub btnctaVentas_Click(sender As Object, e As EventArgs) Handles btnctaVentas.Click
        'Asignar valor a label para diferenciar campo a llenar.
        M_BuscarCuenta.lbltipoCta.Text = "Ventas"
        M_BuscarCuenta.ShowDialog()
    End Sub
    Private Sub txtcodigoCtaContado_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCtaContado.TextChanged
        If (txtcodigoCtaContado.Text <> "") Then
            Try
                Dim objEsp As New ClsCuenta
                With objEsp
                    .Cod_Cuenta = txtcodigoCtaContado.Text
                End With
                Dim dt As New DataTable
                dt = objEsp.BuscarCuentaCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCtaContado.Text = CStr(row("cuenta"))
            Catch ex As Exception
                'MsgBox("No existe el código de la cuenta.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoCtaContado.Text = ""
            txtnombreCtaContado.Text = ""
        End If
    End Sub
    Private Sub txtcodigoCtaVentas_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCtaVentas.TextChanged
        If (txtcodigoCtaVentas.Text <> "") Then
            Try
                Dim objEsp As New ClsCuenta
                With objEsp
                    .Cod_Cuenta = txtcodigoCtaVentas.Text
                End With
                Dim dt As New DataTable
                dt = objEsp.BuscarCuentaCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCtaVentas.Text = CStr(row("cuenta"))
            Catch ex As Exception
                'MsgBox("No existe el código de la cuenta.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoCtaVentas.Text = ""
            txtnombreCtaVentas.Text = ""
        End If
    End Sub
End Class