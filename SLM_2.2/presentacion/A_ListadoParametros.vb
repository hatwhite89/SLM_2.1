Public Class A_ListadoParametros
    Private Sub A_ListadoParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parametro As New ClsItemExamenDetalle
        alternarColoFilasDatagridview(dtParametros)
        dtParametros.DataSource = parametro.SeleccionarItemExamenDetalle


        If dtParametros.Columns.Contains("codigo") = True Then

            dtParametros.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtParametros.Columns("codigo").Visible = False

            dtParametros.Columns("codigoItemExamen").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtParametros.Columns("codigoItemExamen").HeaderText = "Exámen"

            dtParametros.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtParametros.Columns("nombre").HeaderText = "Cod. Exámen"

            dtParametros.Columns("codigoUnidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dtParametros.Columns("codigoUnidad").HeaderText = "Cod. Unidad"

        End If

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
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
                A_ValoresRefPar.txtParametro2.Text = row("nombre")

                'capturar unidad a partir de parametro seleccionado
                unidad.Codigo_ = Convert.ToInt32(row("codigoUnidad"))

                dtunidad = unidad.BuscarUnidadCode()

                Dim row1 As DataRow = dtunidad.Rows(0)

                A_ValoresRefPar.txtunidad2.Text = row1("codigoUnidad")
                Me.Close()


            ElseIf lblFormulario.Text = "valorRef" Then

                Dim dt, dtunidad As New DataTable
                Dim unidad As New ClsUnidad

                'capturar informacion de parametro
                dt = dtParametros.DataSource
                Dim row As DataRow = dt.Rows(e.RowIndex)

                A_ValoresRefPar.lblCodParametro.Text = row("codigo")
                A_ValoresRefPar.txtParametro.Text = row("nombre")

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

    Private Sub txtCodExamen_TextChanged(sender As Object, e As EventArgs) Handles txtCodExamen.TextChanged
        Try
            If Trim(txtCodExamen.Text) <> "" Then
                Dim buscar As New ClsItemExamenDetalle

                buscar.codigoItemExamen_ = Convert.ToInt32(txtCodExamen.Text)
                dtParametros.DataSource = buscar.BuscarItemExamenDetalle
            Else
                Dim buscar As New ClsItemExamenDetalle

                'buscar.codigoItemExamen_ = Convert.ToInt32(txtCodExamen.Text)
                dtParametros.DataSource = buscar.SeleccionarItemExamenDetalle

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class