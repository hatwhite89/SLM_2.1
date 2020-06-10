Public Class M_MaquinasLocales
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub M_MaquinasLocales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objMaqLoc As New ClsMaquinasLocales
        Dim dv As DataView = objMaqLoc.SeleccionarMaquinasLocales.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Me.dgbtabla.Columns("codigo").Visible = False

        rtxtdescripcion.ReadOnly = True
        txtcodigo.ReadOnly = True
        txtcodigoSucursal.ReadOnly = True

        btnSucursal.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            lblcodeSucursal.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False
            btnSucursal.Enabled = True

            rtxtdescripcion.ReadOnly = False
            txtcodigo.ReadOnly = False
            txtcodigoSucursal.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblform.Text = "M_CAI" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la máquina local seleccionada?", MsgBoxStyle.YesNo, "Validación")
                End If
                If n = vbYes Then
                    M_CAI.lblCodeMaquinaLocal.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_CAI.txtcodigoMaquina.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    M_CAI.txtdescripcionMaquina.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtcodigoSucursal.Text = ""
        rtxtdescripcion.Text = System.Environment.MachineName
        '2 formas para obtener el nombre de la computadora
        'rtxtdescripcion.Text = System.Windows.Forms.SystemInformation.ComputerName & "----" & System.Environment.MachineName

        rtxtdescripcionB.Text() = ""

        rtxtdescripcion.ReadOnly = False
        txtcodigo.ReadOnly = False
        txtcodigoSucursal.ReadOnly = False

        btnSucursal.Enabled = True

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
            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
            If (Trim(txtcodigo.Text) <> "" And Trim(rtxtdescripcion.Text) <> "" And Trim(lblcodeSucursal.Text) <> "") Then
                Dim objMaqLoc As New ClsMaquinasLocales
                With objMaqLoc
                    .codigoMaquinasLocales_ = txtcodigo.Text
                    .descripcion_ = rtxtdescripcion.Text
                    .codigoSucursal_ = lblcodeSucursal.Text
                End With

                If objMaqLoc.RegistrarNuevaMaquinaLocal() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information)

                    Dim dv As DataView = objMaqLoc.SeleccionarMaquinasLocales.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar la máquina local.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox("Debe ingresar un código breve y descripción único en el sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)

            If (Trim(txtcodigo.Text) <> "" And Trim(rtxtdescripcion.Text) <> "" And Trim(lblcodeSucursal.Text) <> "") Then

                Dim objMaqLoc As New ClsMaquinasLocales
                With objMaqLoc
                    .codigoMaquinasLocales_ = txtcodigo.Text
                    .descripcion_ = rtxtdescripcion.Text
                    .codigo_ = lblcode.Text
                    .codigoSucursal_ = lblcodeSucursal.Text
                End With

                If objMaqLoc.ModificarMaquinasLocales() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)

                    Dim dv As DataView = objMaqLoc.SeleccionarMaquinasLocales.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar la máquina local.", MsgBoxStyle.Critical)
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
    Private Sub rtxtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles rtxtdescripcionB.TextChanged
        Dim objMaqLoc As New ClsMaquinasLocales
        With objMaqLoc
            .descripcion_ = rtxtdescripcionB.Text
        End With
        Try
            Dim dv As DataView = objMaqLoc.BuscarMaquinasLocalesDesc.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception
            MsgBox("No existe la máquina local.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub txtcodigoSucursal_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoSucursal.TextChanged
        If (txtcodigoSucursal.Text <> "") Then
            Try
                Dim objSuc As New ClsSucursal
                With objSuc
                    .codigoSucursal_ = txtcodigoSucursal.Text
                End With
                Dim dt As New DataTable
                dt = objSuc.BuscarSucursalCode()
                Dim row As DataRow = dt.Rows(0)
                lblcodeSucursal.Text = CStr(row("codigo"))
                txtnombreSucursal.Text = CStr(row("nombre"))
                txtcodigoSucursal.BackColor = Color.White
            Catch ex As Exception
                txtcodigoSucursal.BackColor = Color.Red
                txtnombreSucursal.Text = ""
                lblcodeSucursal.Text = ""
            End Try
        Else
            txtcodigoSucursal.Text = ""
            txtnombreSucursal.Text = ""
            lblcodeSucursal.Text = ""
            txtcodigoSucursal.BackColor = Color.White
        End If
    End Sub
    Private Sub lblcodeSucursal_TextChanged(sender As Object, e As EventArgs) Handles lblcodeSucursal.TextChanged
        If (lblcodeSucursal.Text <> "") Then
            Try
                Dim objSuc As New ClsSucursal
                With objSuc
                    .codigo_ = lblcodeSucursal.Text
                End With
                Dim dt As New DataTable
                dt = objSuc.BuscarSucursalNumero()
                Dim row As DataRow = dt.Rows(0)
                txtcodigoSucursal.Text = CStr(row("codigoSucursal"))
                txtnombreSucursal.Text = CStr(row("nombre"))
                txtcodigoSucursal.BackColor = Color.White
            Catch ex As Exception
                txtcodigoSucursal.BackColor = Color.Red
                txtnombreSucursal.Text = ""
                lblcodeSucursal.Text = ""
            End Try
        Else
            txtcodigoSucursal.Text = ""
            txtnombreSucursal.Text = ""
            lblcodeSucursal.Text = ""
            txtcodigoSucursal.BackColor = Color.White
        End If
    End Sub
    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        M_Sucursal.lblform.Text = "M_MaquinasLocales"
        M_Sucursal.ShowDialog()
    End Sub

End Class