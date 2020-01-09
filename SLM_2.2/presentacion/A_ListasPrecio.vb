Public Class A_ListasPrecio
    Private Sub A_ListasPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        importarExcel(dtExcel)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim precios As New ClsPrecio

        For fila = 0 To dtExcel.Rows.Count - 2
            Try
                'Insertar precio
                With precios
                    .codigoItem_ = Convert.ToInt16(dtExcel.Rows(fila).Cells(0).Value)
                    .codigoListaPrecios_ = Convert.ToInt16(dtExcel.Rows(fila).Cells(1).Value)
                    .precio_ = Convert.ToInt16(dtExcel.Rows(fila).Cells(3).Value)
                End With

                'Funcion de registro de precio
                precios.RegistrarNuevoPrecio()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next

        ' M_Precio.dgbtabla.DataSource = precios.SeleccionarPrecios

        Dim dv As DataView = precios.SeleccionarPrecios.DefaultView
        M_Precio.dgbtabla.DataSource = dv
        M_Precio.lblcantidad.Text = dv.Count
        M_Precio.dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        Me.Close()

    End Sub
End Class