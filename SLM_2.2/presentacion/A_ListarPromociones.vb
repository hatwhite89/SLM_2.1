Public Class A_ListarPromociones

    Dim promo As New ClsPromociones
    Private Sub A_ListarPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtPromos.DataSource = promo.ListarPromociones

        'Ocultar columnas
        dtPromos.Columns("contador").Visible = False
        dtPromos.Columns("precio").Visible = False
        dtPromos.Columns("img").Visible = False
        dtPromos.Columns("descripcion").Width = 230
    End Sub

    Private Sub dtPromos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPromos.CellDoubleClick

        Dim dt As DataTable
        Dim rows As DataRow

        dt = dtPromos.DataSource
        rows = dt.Rows(e.RowIndex)

        With A_Promociones

            .txtCod.Text = rows("codigo")
            .txtDescrip.Text = rows("descripcion")
            .txtPrecio.Text = rows("precio")
            .dtpFechaI.Value = rows("fechaInicio")
            .dtpFechaF.Value = rows("fechaFinal")
            '.pbxPromo.Image = dtPromos.Rows(e.RowIndex).Cells(7).FormattedValue

            .Show()

        End With

    End Sub

    Private Sub A_ListarPromociones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar ESC para cerrar ventana
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

End Class