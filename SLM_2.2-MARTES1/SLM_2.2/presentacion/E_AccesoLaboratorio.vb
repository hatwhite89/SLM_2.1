Public Class E_AccesoLaboratorio
    Private Sub M_AccesoLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objAccLab As New ClsAccesoLaboratorio
        Dim dv As DataView = objAccLab.SeleccionarAccesoLaboratorio.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        txtnombre.ReadOnly = True
        txtusuario.ReadOnly = True

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

            If (Trim(txtusuario.Text) <> "" And Trim(txtnombre.Text) <> "") Then
                Dim objAccLab As New ClsAccesoLaboratorio
                With objAccLab
                    .usuario_ = txtusuario.Text
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
                    txtusuario.ReadOnly = True
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

            If (Trim(txtnombre.Text) <> "" And Trim(txtusuario.Text) <> "") Then
                Dim objAccLab As New ClsAccesoLaboratorio
                With objAccLab
                    .codigo_ = lblcode.Text
                    .usuario_ = txtusuario.Text
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

                    txtusuario.ReadOnly = True
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
        txtusuario.Text() = ""
        txtnombre.Text() = ""
        cbxIngresar.Checked = False
        cbxValidar.Checked = False
        cbxObjetar.Checked = False
        cbxConfirmar.Checked = False

        cbxIngresar.Enabled = True
        cbxValidar.Enabled = True
        cbxObjetar.Enabled = True
        cbxConfirmar.Enabled = True

        txtnombre.ReadOnly = False
        txtusuario.ReadOnly = False
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
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtusuario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            cbxIngresar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            cbxObjetar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            cbxConfirmar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            cbxValidar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()

            cbxIngresar.Enabled = True
            cbxValidar.Enabled = True
            cbxObjetar.Enabled = True
            cbxConfirmar.Enabled = True

            btnguardar.Enabled = False
            btnnuevo.Enabled = True
            btnmodificar.Enabled = True
            txtnombre.ReadOnly = False
            txtusuario.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtusuarioB.TextChanged
        Try
            Dim objAccLab As New ClsAccesoLaboratorio
            With objAccLab
                .usuario_ = txtusuarioB.Text
            End With
            If (Trim(txtusuarioB.Text) <> "") Then
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