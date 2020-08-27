Public Class M_Area
    Private Sub M_Area_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub M_Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objArea As New ClsArea
        Dim dv As DataView = objArea.SeleccionarArea.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        alternarColoFilasDatagridview(dgbtabla)
        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_Departamento") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el área?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Departamento.txtcodigoArea.Text = txtcodigo.Text
                    M_Departamento.txtnombreArea.Text = txtnombre.Text
                    Me.Close()
                End If
            ElseIf (lblform.Text = "M_Empleados") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el área?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Empleados.lblcodigoArea.Text = txtcodigo.Text
                    M_Empleados.txtArea.Text = txtnombre.Text
                    M_Empleados.lblcodePuesto.Text = ""
                    M_Empleados.txtPuestoTrabajo.Text = ""
                    M_Empleados.txtdepartamento.Text = ""
                    M_Empleados.lblcodeDepto.Text = ""
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

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtnombre.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""

        txtnombre.ReadOnly = False

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

            If (Trim(txtnombre.Text) <> "") Then
                Dim objArea As New ClsArea
                With objArea
                    .Nombre_ = txtnombre.Text
                End With

                If objArea.RegistrarNuevaArea() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objArea.SeleccionarArea.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el cajero(a).", MsgBoxStyle.Critical)
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

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "") Then
                txtnombre.Text = sinDobleEspacio(txtnombre.Text)
                Dim objArea As New ClsArea
                With objArea
                    .Nombre_ = txtnombre.Text
                    .codigo_ = txtcodigo.Text
                End With

                If objArea.ModificarArea() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objArea.SeleccionarArea.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el cajero(a).", MsgBoxStyle.Critical)
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
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objArea As New ClsArea
            With objArea
                .Nombre_ = txtnombreB.Text
            End With

            If (Trim(txtnombreB.Text) <> "") Then
                Dim dv As DataView = objArea.BuscarAreaNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                Dim dv As DataView = objArea.SeleccionarArea.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class