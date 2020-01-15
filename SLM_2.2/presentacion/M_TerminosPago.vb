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

        dgbtabla.Columns("codigo").Visible = False

        rtxtdescripcion.ReadOnly = True
        txtdiasNeto.ReadOnly = True
        txtcodigoCtaContado.ReadOnly = True
        txtcodigoCtaVentas.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnctaContado.Enabled = False
        btnctaVentas.Enabled = False

        cbxtipoPago.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
        btntipoPago.Enabled = False

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            Dim temp As Integer = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value().ToString
            cbxtipoPago.SelectedIndex = temp - 1
            If (lblform.Text = "factura") Then
                M_Factura.lblcodeTerminoPago.Text = lblcode.Text
                M_Factura.txtcodigoTerminosPago.Text = txtcodigo.Text
                M_Factura.txtdescripcionTermino.Text = rtxtdescripcion.Text
            ElseIf (lblform.Text = "cliente") Then
                M_Cliente.lblcodeTerminoPago.Text = lblcode.Text
                M_Cliente.txtcodigoTermino.Text = txtcodigo.Text
                M_Cliente.txtnombreTerminos.Text = rtxtdescripcion.Text
            End If

            If (Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value() = 0) Then
                txtdiasNeto.Text = ""
            Else
                txtdiasNeto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            End If

            If (Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value() = "0") Then
                txtcodigoCtaContado.Text = ""
                lblcodeCtaContado.Text = "0"
            Else
                lblcodeCtaContado.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                Dim objcuenta As New ClsCuenta
                Dim dt As New DataTable
                objcuenta.Cod_Cuenta = lblcodeCtaContado.Text
                dt = objcuenta.BuscarCuentaCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCtaContado.Text = CStr(row("nombre"))
                txtcodigoCtaContado.Text = CStr(row("cuenta"))
            End If

            If (Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value() = "0") Then
                txtcodigoCtaVentas.Text = ""
                lblcodeCtaVentas.Text = "0"
            Else
                lblcodeCtaVentas.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
                Dim objcuenta As New ClsCuenta
                Dim dt As New DataTable
                objcuenta.Cod_Cuenta = lblcodeCtaVentas.Text
                dt = objcuenta.BuscarCuentaCode()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCtaVentas.Text = CStr(row("nombre"))
                txtcodigoCtaVentas.Text = CStr(row("cuenta"))
            End If

            cbxtipoPago.Enabled = True

            btnctaVentas.Enabled = True
            btnctaContado.Enabled = True
            btntipoPago.Enabled = True

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            rtxtdescripcion.ReadOnly = False
            txtdiasNeto.ReadOnly = False
            txtcodigoCtaContado.ReadOnly = False
            txtcodigoCtaVentas.ReadOnly = False
            txtcodigo.ReadOnly = False
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

        btnctaContado.Enabled = True
        btnctaVentas.Enabled = True
        btntipoPago.Enabled = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(txtcodigo.Text) <> "" And Trim(rtxtdescripcion.Text) <> "" And txtcodigoCtaVentas.BackColor = Color.White And txtcodigoCtaContado.BackColor = Color.White) Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigoTerminoPago_ = txtcodigo.Text
                    .Descripcion1 = rtxtdescripcion.Text
                    .codigoTipoTermino1 = Convert.ToInt32(cbxtipoPago.SelectedIndex.ToString) + 1
                End With

                If (txtcodigoCtaContado.Text <> "") Then
                    objTerm.codigoCtaContado1 = Convert.ToInt32(lblcodeCtaContado.Text)
                ElseIf (txtcodigoCtaVentas.Text <> "") Then
                    objTerm.codigoCtaVentas1 = Convert.ToInt32(lblcodeCtaVentas.Text)
                ElseIf (txtdiasNeto.Text <> "") Then
                    objTerm.diasNeto1 = Convert.ToInt32(txtdiasNeto.Text)
                End If

                If objTerm.RegistrarNuevaTerminoPago() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    deshabilitar()
                Else
                    MsgBox("Error al querer ingresar el término de pago.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub deshabilitar()
        rtxtdescripcion.ReadOnly = True
        txtdiasNeto.ReadOnly = True
        txtcodigoCtaContado.ReadOnly = True
        txtcodigoCtaVentas.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnctaContado.Enabled = False
        btnctaVentas.Enabled = False
        btntipoPago.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (Trim(txtcodigo.Text) <> "" And Trim(rtxtdescripcion.Text) <> "" And txtcodigoCtaVentas.BackColor = Color.White And txtcodigoCtaContado.BackColor = Color.White) Then

                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)

                Dim objTerm As New ClsTerminoPago
                With objTerm
                    .codigo_ = lblcode.Text
                    .codigoTerminoPago_ = txtcodigo.Text
                    .Descripcion1 = rtxtdescripcion.Text
                    .codigoTipoTermino1 = Convert.ToInt32(cbxtipoPago.SelectedIndex.ToString) + 1
                End With

                If (txtcodigoCtaContado.Text <> "") Then
                    objTerm.codigoCtaContado1 = Convert.ToInt32(lblcodeCtaContado.Text)
                End If
                If (txtcodigoCtaVentas.Text <> "") Then
                    objTerm.codigoCtaVentas1 = Convert.ToInt32(lblcodeCtaVentas.Text)
                End If
                If (txtdiasNeto.Text <> "") Then
                    objTerm.diasNeto1 = Convert.ToInt32(txtdiasNeto.Text)
                End If

                If objTerm.ModificarTerminoPago() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    deshabilitar()
                Else
                    MsgBox("Error al querer modificar el término de pago.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
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
        If (Trim(txtcodigoCtaContado.Text) <> "") Then
            Try
                Dim objEsp As New ClsCuenta
                With objEsp
                    .Cuent_a = txtcodigoCtaContado.Text
                End With
                Dim dt As New DataTable
                dt = objEsp.Comprobar()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCtaContado.Text = CStr(row("nombre"))
                lblcodeCtaContado.Text = CStr(row("codCuenta"))
                txtcodigoCtaContado.BackColor = Color.White
            Catch ex As Exception
                txtcodigoCtaContado.BackColor = Color.Red
                lblcodeCtaContado.Text = ""
                txtnombreCtaContado.Text = ""
                'MsgBox("No existe el código de la cuenta.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoCtaContado.Text = ""
            txtnombreCtaContado.Text = ""
            lblcodeCtaContado.Text = ""
            txtcodigoCtaContado.BackColor = Color.White
        End If
    End Sub
    Private Sub txtcodigoCtaVentas_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCtaVentas.TextChanged
        If (Trim(txtcodigoCtaVentas.Text) <> "") Then
            Try
                Dim objEsp As New ClsCuenta
                With objEsp
                    .Cuent_a = txtcodigoCtaVentas.Text
                End With
                Dim dt As New DataTable
                dt = objEsp.Comprobar()
                Dim row As DataRow = dt.Rows(0)
                txtnombreCtaVentas.Text = CStr(row("nombre"))
                lblcodeCtaVentas.Text = CStr(row("codCuenta"))
                txtcodigoCtaVentas.BackColor = Color.White
            Catch ex As Exception
                txtcodigoCtaVentas.BackColor = Color.Red
                lblcodeCtaVentas.Text = ""
                txtnombreCtaVentas.Text = ""
                'MsgBox("No existe el código de la cuenta.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoCtaVentas.Text = ""
            txtnombreCtaVentas.Text = ""
            lblcodeCtaVentas.Text = ""
            txtcodigoCtaVentas.BackColor = Color.White
        End If
    End Sub

    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        Try

            Dim objTerm As New ClsTerminoPago
            With objTerm
                .Descripcion1 = txtdescripcionB.Text
            End With
            If (Trim(txtdescripcionB.Text) <> "") Then
                Dim dv As DataView = objTerm.BuscarTerminoPago.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objTerm.SeleccionarTerminoPago.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

        Catch ex As Exception

        End Try
    End Sub
    'Private Sub lblcodeCtaContado_TextChanged(sender As Object, e As EventArgs) Handles lblcodeCtaContado.TextChanged
    '    Dim objcuenta As New ClsCuenta
    '    Dim dt As New DataTable
    '    objcuenta.Cod_Cuenta = lblcodeCtaContado.Text
    '    dt = objcuenta.BuscarCuentaCode()
    '    Dim row As DataRow = dt.Rows(0)
    '    txtnombreCtaContado.Text = CStr(row("nombre"))
    '    txtcodigoCtaContado.Text = CStr(row("cuenta"))
    'End Sub
    'Private Sub lblcodeCtaVentas_TextChanged(sender As Object, e As EventArgs) Handles lblcodeCtaVentas.TextChanged
    '    Dim objcuenta As New ClsCuenta
    '    Dim dt As New DataTable
    '    objcuenta.Cod_Cuenta = lblcodeCtaVentas.Text
    '    dt = objcuenta.BuscarCuentaCode()
    '    Dim row As DataRow = dt.Rows(0)
    '    txtnombreCtaVentas.Text = CStr(row("nombre"))
    '    txtcodigoCtaVentas.Text = CStr(row("cuenta"))
    'End Sub
End Class