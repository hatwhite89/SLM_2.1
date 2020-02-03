Public Class A_ListarPromociones

    Dim promo As New ClsPromociones
    Private Sub A_ListarPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtPromos.DataSource = promo.ListarPromociones

        'Ocultar columnas
        dtPromos.Columns("contador").Visible = False
        dtPromos.Columns("precio").Visible = False
        dtPromos.Columns("imagen").Visible = False
        dtPromos.Columns("descripcion").Width = 230
    End Sub

    Private Sub dtPromos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPromos.CellDoubleClick

        Try


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
                .txtRuta.Text = rows("imagen")
                .pbxPromo.Load(rows("imagen"))

                Dim objDetProm As New ClsDetallePromociones
                objDetProm.codigoPromocion_ = rows("codigo")
                dt = objDetProm.SeleccionarDetallePromocion()
                For index As Integer = 0 To dt.Rows.Count - 1
                    rows = dt.Rows(index)
                    .dtDetallePromo.Rows.Add(New String() {CStr(rows("codigoExamen")), CStr(rows("descripcion"))})
                Next

                .Show()

            End With

            With A_Promociones

                .btnCrear.Visible = True
                .btnModificar.Visible = True
                .btnGuardar.Visible = False

            End With

        Catch ex As Exception

        End Try


    End Sub

    Private Sub A_ListarPromociones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Presionar ESC para cerrar ventana
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevaPromo.Click
        Try

            Me.Close()

            With A_Promociones

                .Show()
                .btnGuardar.Visible = True
                .btnCrear.Visible = False
                .btnModificar.Visible = False

            End With

        Catch ex As Exception

        End Try

    End Sub

End Class