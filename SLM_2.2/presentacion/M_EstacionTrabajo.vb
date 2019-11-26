Public Class M_EstacionTrabajo
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_EstacionTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objEstTra As New ClsEstacionTrabajo
        Dim dv As DataView = objEstTra.SeleccionarEstacionTrabajo.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        rtxtdescripcion.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()

            btnmodificar.Enabled = True

            rtxtdescripcion.ReadOnly = False
            txtcodigo.ReadOnly = True
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
            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
            Dim t, t2 As String
            t = Trim(txtcodigo.Text)
            t2 = Trim(rtxtdescripcion.Text)
            If (t <> "" And t2 <> "") Then
                Dim objEstTra As New ClsEstacionTrabajo
                With objEstTra
                    .Codigo_ = txtcodigo.Text
                    .descripcion_ = rtxtdescripcion.Text
                End With

                If objEstTra.RegistrarNuevaEstacionTrabajo() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objEstTra.SeleccionarEstacionTrabajo.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True

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

            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
            Dim t, t2 As String
            t = Trim(txtcodigo.Text)
            t2 = Trim(rtxtdescripcion.Text)
            If (t <> "" And t2 <> "") Then
                Dim objEstTra As New ClsEstacionTrabajo
                With objEstTra
                    .Codigo_ = txtcodigo.Text
                    .descripcion_ = rtxtdescripcion.Text
                End With

                If objEstTra.ModificarEstacionTrabajo() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objEstTra.SeleccionarEstacionTrabajo.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True

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
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs)
        Dim objEstTra As New ClsEstacionTrabajo
        With objEstTra
            .descripcion_ = rtxtdescripcionB.Text
        End With
        Dim dv As DataView = objEstTra.BuscarEstacionTrabajo.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub rtxtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles rtxtdescripcionB.TextChanged
        If (rtxtdescripcionB.Text <> "") Then
            Try
                Dim objEstTra As New ClsEstacionTrabajo
                With objEstTra
                    .descripcion_ = rtxtdescripcionB.Text
                End With
                Dim dv As DataView = objEstTra.BuscarEstacionTrabajo.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la cotización.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            rtxtdescripcionB.Text = ""
        End If
    End Sub
End Class