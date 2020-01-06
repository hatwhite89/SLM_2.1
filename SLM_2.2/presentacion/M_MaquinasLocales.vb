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

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            rtxtdescripcion.ReadOnly = False
            txtcodigo.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        rtxtdescripcion.Text() = ""
        rtxtdescripcionB.Text() = ""

        rtxtdescripcion.ReadOnly = False
        txtcodigo.ReadOnly = False

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
            If (Trim(txtcodigo.Text) <> "" And Trim(rtxtdescripcion.Text) <> "") Then
                Dim objMaqLoc As New ClsMaquinasLocales
                With objMaqLoc
                    .codigoMaquinasLocales_ = txtcodigo.Text
                    .descripcion_ = rtxtdescripcion.Text
                End With

                If objMaqLoc.RegistrarNuevaMaquinaLocal() = 1 Then
                    MsgBox("Registrado correctamente.")

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
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
            Dim t, t2 As String
            t = Trim(txtcodigo.Text)
            t2 = Trim(rtxtdescripcion.Text)
            If (t <> "" And t2 <> "") Then
                Dim objMaqLoc As New ClsMaquinasLocales
                With objMaqLoc
                    .codigoMaquinasLocales_ = txtcodigo.Text
                    .descripcion_ = rtxtdescripcion.Text
                    .codigo_ = lblcode.Text
                End With

                If objMaqLoc.ModificarMaquinasLocales() = 1 Then
                    MsgBox("Modificado correctamente.")

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

End Class