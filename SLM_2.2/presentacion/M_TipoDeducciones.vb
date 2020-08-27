Public Class M_TipoDeducciones
    Private Sub M_TipoDeducciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub M_TipoDeducciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objTipoD As New ClsTipoDeducciones
        Dim dv As DataView = objTipoD.SeleccionarTipoDeduccion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        alternarColoFilasDatagridview(dgbtabla)
        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True
        txttotal.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_PuestoTrabajo") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el tipo de deducción?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_PuestoTrabajo.txtcodigoDepto.Text = txtcodigo.Text
                    M_PuestoTrabajo.txtnombreDepto.Text = txtnombre.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txttotal.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtnombre.ReadOnly = False
            txttotal.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txttotal.Text = ""
        txtNombreB.Text() = ""

        txtnombre.ReadOnly = False
        txttotal.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
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

            txtnombre.Text = sinDobleEspacio(txtnombre.Text)

            If (Trim(txtnombre.Text) <> "" And Trim(txttotal.Text) <> "") Then
                Dim objTipoD As New ClsTipoDeducciones
                With objTipoD
                    .Nombre_ = txtnombre.Text
                    .total_ = Convert.ToDouble(txttotal.Text)
                End With

                If objTipoD.RegistrarNuevoTipoDeduccion() = 1 Then

                    MsgBox("Registrado el tipo de deducción correctamente.")
                    Dim dv As DataView = objTipoD.SeleccionarTipoDeduccion.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    txttotal.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el tipo de deducción.", MsgBoxStyle.Critical)
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

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "" And Trim(txttotal.Text) <> "") Then
                txtnombre.Text = sinDobleEspacio(txtnombre.Text)
                Dim objTipoD As New ClsTipoDeducciones
                With objTipoD
                    .Nombre_ = txtnombre.Text
                    .codigo_ = txtcodigo.Text
                    .total_ = Convert.ToDouble(txttotal.Text)
                End With

                If objTipoD.ModificarTipoDeduccion() = 1 Then
                    MsgBox("Modificado el tipo de deducción correctamente.")

                    Dim dv As DataView = objTipoD.SeleccionarTipoDeduccion.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    txttotal.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el tipo de deducción.", MsgBoxStyle.Critical)
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
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        Try
            Dim objTipoD As New ClsTipoDeducciones
            With objTipoD
                .Nombre_ = txtNombreB.Text
            End With

            If (Trim(txtNombreB.Text) <> "") Then
                Dim dv As DataView = objTipoD.BuscarTipoDeduccionNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                Dim dv As DataView = objTipoD.SeleccionarTipoDeduccion.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class