Public Class A_ListadoParametros
    Private Sub A_ListadoParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametro As New ClsParametroExamen

        dtParametros.DataSource = parametro.SeleccionarParametroExamen

    End Sub

    Private Sub dtParametros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtParametros.CellDoubleClick

        Try


            If lblFormulario.Text = "valortxt" Then


                Dim dt, dtunidad As New DataTable
                Dim unidad As New ClsUnidad

                'capturar informacion de parametro
                dt = dtParametros.DataSource
                Dim row As DataRow = dt.Rows(e.RowIndex)

                A_ValoresRefPar.lblCodParametro.Text = row("codigo")
                A_ValoresRefPar.txtParametro2.Text = row("descripcion")

                'capturar unidad a partir de parametro seleccionado
                unidad.Codigo_ = Convert.ToInt32(row("codigoUnidad"))

                dtunidad = unidad.BuscarUnidadCode()

                Dim row1 As DataRow = dtunidad.Rows(0)

                A_ValoresRefPar.txtunidad2.Text = row1("codigoUnidad")
                Me.Close()


            Else

                Dim dt, dtunidad As New DataTable
                Dim unidad As New ClsUnidad

                'capturar informacion de parametro
                dt = dtParametros.DataSource
                Dim row As DataRow = dt.Rows(e.RowIndex)

                A_ValoresRefPar.lblCodParametro.Text = row("codigo")
                A_ValoresRefPar.txtParametro.Text = row("descripcion")

                'capturar unidad a partir de parametro seleccionado
                unidad.Codigo_ = Convert.ToInt32(row("codigoUnidad"))

                dtunidad = unidad.BuscarUnidadCode()

                Dim row1 As DataRow = dtunidad.Rows(0)

                A_ValoresRefPar.txtUnidad.Text = row1("codigoUnidad")
                Me.Close()



            End If



        Catch ex As Exception

        End Try




    End Sub
End Class