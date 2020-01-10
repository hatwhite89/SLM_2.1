Public Class M_Precio
    Dim objPre As New ClsPrecio
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtcodigoItem.Text() = ""
        txtPrecio.Text() = ""
        txtcodigoListaPrecios.Text() = ""

        txtCodigoB.Text = ""

        txtcodigoItem.ReadOnly = False
        txtPrecio.ReadOnly = False
        txtcodigoListaPrecios.ReadOnly = False

        btnbuscarItem.Enabled = True
        btnBuscarListaPrecios.Enabled = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub deshabilitar()
        txtcodigoItem.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtcodigoListaPrecios.ReadOnly = True

        btnbuscarItem.Enabled = False
        btnBuscarListaPrecios.Enabled = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(txtcodigoItem.Text) <> "" And Trim(txtPrecio.Text) <> "" And Trim(txtcodigoListaPrecios.Text) <> "" And txtcodigoListaPrecios.BackColor = Color.White And txtcodigoItem.BackColor = Color.White) Then

                With objPre
                    .codigoItem_ = txtcodigoItem.Text
                    .precio_ = txtPrecio.Text
                    .codigoListaPrecios_ = lblCode.Text
                End With

                If objPre.RegistrarNuevoPrecio() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objPre.ListarPrecios.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    deshabilitar()
                Else
                    MsgBox("Error al querer ingresar el precio.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            If (Trim(txtcodigoItem.Text) <> "" And Trim(txtPrecio.Text) <> "" And Trim(txtcodigoListaPrecios.Text) <> "" And txtcodigoListaPrecios.BackColor = Color.White And txtcodigoItem.BackColor = Color.White) Then

                With objPre
                    .codigo_ = txtcodigo.Text
                    .codigoItem_ = txtcodigoItem.Text
                    .precio_ = txtPrecio.Text
                    .codigoListaPrecios_ = lblCode.Text
                End With

                If objPre.ModificarPrecio() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objPre.ListarPrecios.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    deshabilitar()
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el precio.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click_1(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigoItem.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtPrecio.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            lblCode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtcodigoItem.ReadOnly = False
            txtPrecio.ReadOnly = False
            txtcodigoListaPrecios.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub M_Precio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_Precio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dv As DataView = objPre.ListarPrecios.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        'Me.Width = 687
        'Me.Height = 725
        deshabilitar()
    End Sub

    Private Sub txtcodigoItem_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoItem.TextChanged
        If (txtcodigoItem.Text <> "") Then
            Try
                Dim objItem As New ClsItemExamen
                With objItem
                    .Cod_ItemExa = txtcodigoItem.Text
                End With
                Dim dt As New DataTable
                dt = objItem.BuscarItemExam()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionItem.Text = CStr(row("descripcion"))
                txtcodigoItem.BackColor = Color.White
            Catch ex As Exception
                txtcodigoItem.BackColor = Color.Red
                txtdescripcionItem.Text = ""
                'MsgBox("No existe ese código de especialidad.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoItem.Text = ""
            txtdescripcionItem.Text = ""
            txtcodigoItem.BackColor = Color.White
        End If
    End Sub

    Private Sub txtcodigoListaPrecios_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoListaPrecios.TextChanged
        If (txtcodigoListaPrecios.Text <> "") Then
            Try
                Dim objPriceList As New ClsListaPrecios
                With objPriceList
                    .codigoBreve_ = txtcodigoListaPrecios.Text
                End With
                Dim dt As New DataTable
                dt = objPriceList.BuscarListaPreciosCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionListaPrecios.Text = CStr(row("descripcion"))
                lblCode.Text = CStr(row("codigo"))
                txtcodigoListaPrecios.BackColor = Color.White
            Catch ex As Exception
                txtcodigoListaPrecios.BackColor = Color.Red
                txtdescripcionListaPrecios.Text = ""
                'MsgBox("No existe ese código de especialidad.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtcodigoListaPrecios.Text = ""
            txtdescripcionListaPrecios.Text = ""
            lblCode.Text = ""
            txtcodigoListaPrecios.BackColor = Color.White
        End If
    End Sub

    Private Sub btnbuscarItem_Click(sender As Object, e As EventArgs) Handles btnbuscarItem.Click
        E_DetalleExamenes.ShowDialog()
    End Sub

    Private Sub btnBuscarListaPrecios_Click(sender As Object, e As EventArgs) Handles btnBuscarListaPrecios.Click
        M_ListadoDePrecios.lblForm.Text = "Precio"
        M_ListadoDePrecios.ShowDialog()
    End Sub

    Private Sub lblCode_TextChanged(sender As Object, e As EventArgs) Handles lblCode.TextChanged
        Try
            Dim dt As New DataTable
            Dim objPriceList As New ClsListaPrecios
            objPriceList.codigo_ = lblCode.Text
            dt = objPriceList.BuscarListaPreciosCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtcodigoListaPrecios.Text = CStr(row("codigoBreve"))
            txtdescripcionListaPrecios.Text = CStr(row("descripcion"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        Try
            objPre.codigo_ = txtCodigoB.Text
            Dim dv As DataView = objPre.BuscarPrecioCode.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        A_ListasPrecio.Show()
    End Sub


End Class