Public Class E_AreaLaboratorio
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(txtnombre.Text) <> "" And Trim(txtarea.Text) <> "") Then
                Dim objAreaLabecialidad As New ClsAreaLaboratorio
                With objAreaLabecialidad
                    .Nombre_ = txtnombre.Text
                    .Area_ = txtarea.Text
                End With

                If objAreaLabecialidad.RegistrarNuevaAreaLaboratorio() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objAreaLabecialidad.SeleccionarAreaLaboratorio.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                    txtarea.ReadOnly = True
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

            If (Trim(txtnombre.Text) <> "" And Trim(txtarea.Text) <> "") Then
                Dim objAreaLabecialidad As New ClsAreaLaboratorio
                With objAreaLabecialidad
                    .Nombre_ = txtnombre.Text
                    .Area_ = txtarea.Text
                    .codigo_ = lblcode.Text
                End With

                If objAreaLabecialidad.ModificarAreaLaboratorio() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objAreaLabecialidad.SeleccionarAreaLaboratorio.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtarea.ReadOnly = True
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
        txtarea.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""

        txtnombre.ReadOnly = False
        txtarea.ReadOnly = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub E_AreaLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objAreaLab As New ClsAreaLaboratorio
        Dim dv As DataView = objAreaLab.SeleccionarAreaLaboratorio.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        txtnombre.ReadOnly = True
        txtarea.ReadOnly = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtarea.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            btnmodificar.Enabled = True
            btnnuevo.Enabled = True
            btnguardar.Enabled = False
            txtnombre.ReadOnly = False
            txtarea.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Dim objAreaLab As New ClsAreaLaboratorio
        With objAreaLab
            .Nombre_ = txtnombreB.Text
        End With
        If (Trim(txtnombreB.Text) <> "") Then
            Dim dv As DataView = objAreaLab.BuscarAreaLaboratorio.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Else
            Dim dv As DataView = objAreaLab.SeleccionarAreaLaboratorio.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub
End Class