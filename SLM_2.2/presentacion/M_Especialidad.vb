Public Class M_Especialidad


    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (txtnombre.Text <> "") Then
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objEspecialidad As New ClsEspecialidad
                With objEspecialidad
                    .Nombre1 = txtnombre.Text
                End With

                If objEspecialidad.RegistrarNuevaEspecialidad() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objEspecialidad.SeleccionarEspecialidad.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar la especialidad.", MsgBoxStyle.Critical)
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

            If (txtnombre.Text <> "" And txtcodigo.Text <> "") Then
                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objEspecialidad As New ClsEspecialidad
                With objEspecialidad
                    .Nombre1 = txtnombre.Text
                    .Codigo1 = txtcodigo.Text
                End With

                If objEspecialidad.ModificarEspecialidad() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objEspecialidad.SeleccionarEspecialidad.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar la especialidad.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text() = ""
        txtnombre.Text() = ""

        txtnombre.ReadOnly = False
        txtcodigo.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub M_CrearEspecialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objEsp As New ClsEspecialidad
        Dim dv As DataView = objEsp.SeleccionarEspecialidad.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim objEsp As New ClsEspecialidad
        With objEsp
            .Nombre1 = txtnombreB.Text
        End With
        Dim dv As DataView = objEsp.BuscarEspecialidad.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub


    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            btnmodificar.Enabled = True
            txtnombre.ReadOnly = False
            M_Medico.txtcodigoEspecialidad.Text = txtcodigo.Text
            M_Medico.txtnombreEspecialidad.Text = txtnombre.Text
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class