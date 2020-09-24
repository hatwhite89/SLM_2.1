Public Class M_Contratos
    Dim objContratos As New ClsContratos
    Private Sub M_Contratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        seleccionarContratos()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("codigo").HeaderText = "Código"
        dgbtabla.Columns("descripcion").HeaderText = "Descripción"

        'DESHABILITAR
        rtxtdescripcion.ReadOnly = True
        txtcodigo.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub seleccionarContratos()
        Try
            Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()

            txtcodigo.ReadOnly = True
            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            rtxtdescripcion.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        rtxtdescripcion.Text() = ""
        txtdescripcionB.Text() = ""

        rtxtdescripcion.ReadOnly = False

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
            If rtxtdescripcion.TextLength = 0 Then
                rtxtdescripcion.BackColor = Color.Red
            Else
                rtxtdescripcion.BackColor = Color.White
            End If
            If (Trim(rtxtdescripcion.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                With objContratos
                    .Descripcion_ = rtxtdescripcion.Text
                End With

                If objContratos.RegistrarNuevoContratos() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el puesto de trabajo.", MsgBoxStyle.Critical)
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

            If (txtcodigo.Text <> "" And Trim(rtxtdescripcion.Text) <> "") Then
                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objContratos As New ClsContratos
                With objContratos
                    .Codigo_ = txtcodigo.Text
                    .Descripcion_ = rtxtdescripcion.Text
                End With

                If objContratos.ModificarContratos() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    rtxtdescripcion.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el puesto de trabajo.", MsgBoxStyle.Critical)
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
    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        'Try

        '    With objContratos
        '        .Descripcion_ = txtdescripcionB.Text
        '    End With

        '    If (Trim(txtdescripcionB.Text) <> "") Then
        '        Dim dv As DataView = objContratos.BuscarContratos.DefaultView
        '        dgbtabla.DataSource = dv
        '        lblcantidad.Text = dv.Count
        '        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    Else
        '        Dim dv As DataView = objContratos.SeleccionarContratos.DefaultView
        '        dgbtabla.DataSource = dv
        '        lblcantidad.Text = dv.Count
        '        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        '    End If

        'Catch ex As Exception

        'End Try
        Try
            Dim dv As DataView = dgbtabla.DataSource
            dv.RowFilter = String.Format("descripcion Like '%{0}%'", txtdescripcionB.Text)
            lblcantidad.Text = dv.Count
            dgbtabla.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub rtxtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles rtxtdescripcion.TextChanged
        If rtxtdescripcion.TextLength = 0 Then
            rtxtdescripcion.BackColor = Color.Red
        Else
            rtxtdescripcion.BackColor = Color.White
        End If
    End Sub
End Class