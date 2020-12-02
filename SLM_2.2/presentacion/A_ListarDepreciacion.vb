Public Class A_ListarDepreciacion

    Dim depre As New ClsDepreciacion

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            A_Depreciacion.Show()
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub A_ListarDepreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtDepreciacion.DataSource = depre.listarDepreciacion

        Catch ex As Exception
            MsgBox("Error al cargar listado de Activos en Depreciación. Error: " + ex.Message)
        End Try
        alternarColoFilasDatagridview(dtDepreciacion)
    End Sub

    Private Sub dtDepreciacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtDepreciacion.CellDoubleClick

        Try
            Dim dt As New DataTable
            dt = dtDepreciacion.DataSource
            Dim row As DataRow = dt.Rows(e.RowIndex)

            With A_Depreciacion
                .txtCod.Text = row("cod_Depreciacion")
                .txtDescripcion.Text = row("descripcion")
                .txtCosto.Text = row("costoActivo")
                .txtValorResidual.Text = row("valorResidual")
                .dtpCreacion.Value = row("fechaCreacion")
                .dtpFechaCalculo.Value = row("fechaCalculo")
                .lblTipo.Text = row("tipoDepreciacion")
                .txtSede.Text = row("sede")
                .txtTipo.Text = row("tipo")
                .Show()
            End With

        Catch ex As Exception
            MsgBox("Hubo un error al cargar la información del registro seleccionado. Detalle: " + ex.Message)
        End Try

        Me.Close()
    End Sub
End Class