Public Class A_ListarCuentas_Chequera
    'Objeto Cuenta
    Dim Cuenta As New ClsCuenta
    Private Sub A_ListarCuentas_Chequera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Listar cuentas activas
        Try
            dtCuentas.DataSource = Cuenta.listarCuentasActivas
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtCuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellDoubleClick

        Try
            A_Chequera.txtCtaDestino.Text = dtCuentas.Rows(e.RowIndex).Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub


End Class