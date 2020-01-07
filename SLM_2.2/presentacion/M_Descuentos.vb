Public Class M_Descuentos
    Dim objDesc As New ClsDescuentos
    Dim dv As DataView = objDesc.SeleccionarDescuento.DefaultView
    Private Sub M_Descuentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiar()
        SeleccionarDescuentos()

    End Sub
    Private Sub limpiar()

        txtcodigo.ReadOnly = True
        txtcodigoBreve.ReadOnly = True
        txtDescripcion.ReadOnly = True
        txtPorcentaje.ReadOnly = True

        txtcodigo.Text = ""
        txtcodigoBreve.Text = ""
        txtDescripcion.Text = ""
        txtPorcentaje.Text = ""

        txtdescripcionB.Text = ""

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True

    End Sub
    Private Sub SeleccionarDescuentos()
        dv = objDesc.SeleccionarDescuento.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub txtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
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

            txtDescripcion.Text = sinDobleEspacio(txtDescripcion.Text)
            If (Trim(txtcodigoBreve.Text) <> "" And Trim(txtDescripcion.Text) <> "" And Trim(txtPorcentaje.Text) <> "") Then

                With objDesc
                    .codigoBreve_ = txtcodigoBreve.Text
                    .descripcion_ = txtDescripcion.Text
                    .porcentaje_ = txtPorcentaje.Text
                End With

                If objDesc.RegistrarNuevoDescuento() = 1 Then
                    MsgBox("Registrado correctamente.")

                    dv = objDesc.SeleccionarDescuento.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    limpiar()
                Else
                    MsgBox("Error al querer ingresar el descuento.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Error al querer ingresar el descuento.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            txtDescripcion.Text = sinDobleEspacio(txtDescripcion.Text)
            If (Trim(txtcodigoBreve.Text) <> "" And Trim(txtDescripcion.Text) <> "" And Trim(txtPorcentaje.Text) <> "") Then

                With objDesc
                    .Codigo_ = txtcodigo.Text
                    .codigoBreve_ = txtcodigoBreve.Text
                    .descripcion_ = txtDescripcion.Text
                    .porcentaje_ = txtPorcentaje.Text
                End With

                If objDesc.ModificarDescuento() = 1 Then
                    MsgBox("Modificado correctamente.")

                    dv = objDesc.SeleccionarDescuento.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    limpiar()
                Else
                    MsgBox("Error al querer modificar el descuento.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Error al querer ingresar el descuento.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigoBreve.ReadOnly = False
        txtDescripcion.ReadOnly = False
        txtPorcentaje.ReadOnly = False

        txtcodigo.Text = ""
        txtcodigoBreve.Text = ""
        txtDescripcion.Text = ""
        txtPorcentaje.Text = ""

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigoBreve.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtDescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtPorcentaje.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtcodigoBreve.ReadOnly = False
            txtDescripcion.ReadOnly = False
            txtPorcentaje.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea utilizar el examen que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                If Convert.ToInt64(lblFila.Text) >= 0 And temp <> "" Then
                    M_ListaPrecios.dgbtabla.Rows.Remove(M_ListaPrecios.dgbtabla.Rows(lblFila.Text))
                End If
                M_ListaPrecios.dgbtabla.Rows.Insert(lblFila.Text, New String() {"", "", temp, dgbtabla.Rows(e.RowIndex).Cells(0).Value()})
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtdescripcionB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe el descuento.", MsgBoxStyle.Exclamation)
            txtdescripcionB.Text = ""
            SeleccionarDescuentos()
        End If
    End Sub
End Class