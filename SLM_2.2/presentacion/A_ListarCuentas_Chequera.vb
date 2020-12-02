Public Class A_ListarCuentas_Chequera
    'Objeto Cuenta
    Dim Cuenta As New ClsCuenta
    Private Sub A_ListarCuentas_Chequera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Listar cuentas activas
        Try
            dtCuentas.DataSource = Cuenta.listarCuentasActivas
            alternarColoFilasDatagridview(dtCuentas)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtCuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellDoubleClick

        Try
            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtCuentas.DataSource
            row = dt.Rows(e.RowIndex)
            A_Chequera.txtCtaDestino.Text = row("cuenta")
            A_Chequera.lblCodCuenta.Text = row("codCuenta")
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub


End Class