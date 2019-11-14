Public Class A_Cuenta

    Dim Cuenta As New ClsCuenta

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Ingresar nueva cuenta

        Try
            Cuenta.Cuent_a = Convert.ToInt32(txtCuenta.Text)
            Cuenta.Nombr_e = txtNombre.Text
            Cuenta.Tipo_Cuenta = lblTipo.Text

            'Variable de Estado
            If chkEstado.Checked = True Then
                Cuenta.Esta_do = 1
            Else
                Cuenta.Esta_do = 0
            End If

            'Registro de Cuenta
            Cuenta.registrarNuevaCuenta()

            'Refresh lista de cuentas
            dtCuentas.DataSource = Cuenta.listarCuentas

        Catch ex As Exception

        End Try

    End Sub
    Private Sub rbtActivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtActivo.CheckedChanged
        lblTipo.Text = "Activo"
    End Sub
    Private Sub rbtPasivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPasivo.CheckedChanged
        lblTipo.Text = "Pasivo"
    End Sub
    Private Sub rbtPatrimonio_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPatrimonio.CheckedChanged
        lblTipo.Text = "Patrimonio"
    End Sub
    Private Sub rbtIngresos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIngresos.CheckedChanged
        lblTipo.Text = "Ingresos"
    End Sub
    Private Sub rbtGastos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtGastos.CheckedChanged
        lblTipo.Text = "Gastos"
    End Sub

    Private Sub A_Cuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub A_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar cuentas al cargar formulario
        dtCuentas.DataSource = Cuenta.listarCuentas

    End Sub

    Private Sub cbxEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        If chkEstado.Checked = True Then

            lblEstadoColor.Text = "Inactiva"
            lblEstadoColor.ForeColor = Color.Red
        Else
            lblEstadoColor.Text = "Activa"
            lblEstadoColor.ForeColor = Color.Green

        End If
    End Sub

    Private Sub dtCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellClick


        Try
            txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(1).Value
            txtNombre.Text = dtCuentas.Rows(e.RowIndex).Cells(2).Value
            lblTipo.Text = dtCuentas.Rows(e.RowIndex).Cells(3).Value

            If lblTipo.Text = "Activo" Then
                rbtActivo.Checked = True
            ElseIf lblTipo.Text = "Pasivo" Then
                rbtPasivo.Checked = True
            ElseIf lblTipo.Text = "Patrimonio" Then
                rbtPatrimonio.Checked = True
            ElseIf lblTipo.Text = "Ingresos" Then
                rbtIngresos.Checked = True
            ElseIf lblTipo.Text = "Gastos" Then
                rbtGastos.Checked = True
            End If

            chkEstado.Checked = dtCuentas.Rows(e.RowIndex).Cells(6).Value
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class