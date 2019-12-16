Public Class A_ListarTerminoPago

    Dim terminop As New ClsTerminoPago
    Private Sub A_ListarTerminoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Listar terminos de pago
        dtTerminoPago.DataSource = terminop.listarCodDescripTerminoPago

    End Sub

    Private Sub dtTerminoPago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtTerminoPago.CellClick

        'Seleccion de termino de pago
        A_FacturaCompras.txtTerminoPago.Text = dtTerminoPago.Rows(e.RowIndex).Cells(1).Value
        'Cerrar Formulario al seleccionar
        Me.Close()

    End Sub

    Private Sub txtBusquedaTermino_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaTermino.TextChanged

        'Busqueda de termino de pago

        Dim Dato As New DataView

        Try
            With terminop

                'txtBusquedaTermino.Text = txtBusquedaTermino.Text.Trim
                .codigoTerminoPago_ = txtBusquedaTermino.Text
                Dato = terminop.listarBusquedaTerminoPago.DefaultView
                dtTerminoPago.DataSource = Dato

            End With

        Catch ex As Exception
        End Try

    End Sub
End Class