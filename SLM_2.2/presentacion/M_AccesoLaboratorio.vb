Public Class M_AccesoLaboratorio
    Private Sub M_AccesoLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objAccLab As New ClsAccesoLaboratorio
        Dim dv As DataView = objAccLab.SeleccionarAccesoLaboratorio.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True

        cbxConfirmar.Enabled = False
        cbxIngresar.Enabled = False
        cbxObjetar.Enabled = False
        cbxValidar.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (txtcodigo.Text <> "" And txtnombre.Text <> "") Then
                Dim objAccLab As New ClsAccesoLaboratorio
                With objAccLab
                    .usuario_ = txtcodigo.Text
                    .Nombre_ = txtnombre.Text
                    .ingresarResultado_ = cbxIngresar.Checked
                    .objetarResultado_ = cbxObjetar.Checked
                    .confirmarResultado_ = cbxConfirmar.Checked
                    .validarResultado_ = cbxValidar.Checked
                End With

                If objAccLab.RegistrarNuevoAccesoLaboratorio() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objAccLab.SeleccionarAccesoLaboratorio.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    cbxConfirmar.Enabled = False
                    cbxIngresar.Enabled = False
                    cbxObjetar.Enabled = False
                    cbxValidar.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el acceso al laboratorio.", MsgBoxStyle.Critical)
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
                Dim objAccLab As New ClsAccesoLaboratorio
                With objAccLab
                    .usuario_ = txtcodigo.Text
                    .Nombre_ = txtnombre.Text
                    .ingresarResultado_ = cbxIngresar.Checked
                    .objetarResultado_ = cbxObjetar.Checked
                    .confirmarResultado_ = cbxConfirmar.Checked
                    .validarResultado_ = cbxValidar.Checked
                End With

                If objAccLab.ModificarAccesoLaboratorio() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objAccLab.SeleccionarAccesoLaboratorio.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    cbxConfirmar.Enabled = False
                    cbxIngresar.Enabled = False
                    cbxObjetar.Enabled = False
                    cbxValidar.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el acceso al laboratorio.", MsgBoxStyle.Critical)
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

        cbxIngresar.Enabled = True
        cbxValidar.Enabled = True
        cbxObjetar.Enabled = True
        cbxConfirmar.Enabled = True

        txtnombre.ReadOnly = False
        txtcodigo.ReadOnly = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            cbxIngresar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            cbxObjetar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            cbxConfirmar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            cbxValidar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()

            cbxIngresar.Enabled = True
            cbxValidar.Enabled = True
            cbxObjetar.Enabled = True
            cbxConfirmar.Enabled = True

            btnmodificar.Enabled = True
            txtnombre.ReadOnly = False
            txtcodigo.ReadOnly = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoB.TextChanged
        Try
            Dim objAccLab As New ClsAccesoLaboratorio
            With objAccLab
                .usuario_ = txtcodigoB.Text
            End With
            If (Trim(txtcodigoB.Text) <> "") Then
                Dim dv As DataView = objAccLab.BuscarAccesoLaboratorio.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objAccLab.SeleccionarAccesoLaboratorio.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class