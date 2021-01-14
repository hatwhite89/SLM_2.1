Public Class M_TipoClasificacion
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcodigo.Text() = ""
        txtcomentarioB.Text() = ""
        rtxtcomentario.Text() = ""
        txtcodigoListaPrecios.ResetText()
        txtcodigoCategoriaCliente.ResetText()
        lblcodeCategoria.ResetText()
        lblCodePriceList.ResetText()

        txtcomentarioB.ReadOnly = False
        rtxtcomentario.ReadOnly = False
        txtcodigo.ReadOnly = True
        txtcodigoCategoriaCliente.ReadOnly = False
        txtcodigoListaPrecios.ReadOnly = False
        btnCategoriaCliente.Enabled = True
        btnBuscarListaPrecios.Enabled = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(rtxtcomentario.Text) <> "" And Trim(txtNombreCategoria.Text) <> "" And Trim(txtdescripcionListaPrecios.Text) <> "") Then

                rtxtcomentario.Text = sinDobleEspacio(rtxtcomentario.Text)

                Dim objTipoCla As New ClsTipoClasificacion
                With objTipoCla
                    .Comentario1 = rtxtcomentario.Text
                    .codigoCategoriaCliente_ = Integer.Parse(lblcodeCategoria.Text)
                    .codigoListaPrecios_ = Integer.Parse(lblCodePriceList.Text)
                End With

                If objTipoCla.RegistrarNuevoTipoClasificacion() = 1 Then
                    MsgBox("Registrado correctamente.", MsgBoxStyle.Information)

                    Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    rtxtcomentario.ReadOnly = True
                    txtcodigoCategoriaCliente.ReadOnly = True
                    txtcodigoListaPrecios.ReadOnly = True

                    btnBuscarListaPrecios.Enabled = True
                    btnCategoriaCliente.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el tipo de clasificación.", MsgBoxStyle.Critical)
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

            If (Trim(rtxtcomentario.Text) <> "" And Trim(txtNombreCategoria.Text) <> "" And Trim(txtdescripcionListaPrecios.Text) <> "") Then

                rtxtcomentario.Text = sinDobleEspacio(rtxtcomentario.Text)

                Dim objTipoCla As New ClsTipoClasificacion
                With objTipoCla
                    .Comentario1 = rtxtcomentario.Text
                    .Codigo1 = txtcodigo.Text
                    .codigoCategoriaCliente_ = Integer.Parse(lblcodeCategoria.Text)
                    .codigoListaPrecios_ = Integer.Parse(lblCodePriceList.Text)
                End With

                If objTipoCla.ModificarTipoClasificacion() = 1 Then
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)

                    Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    rtxtcomentario.ReadOnly = True
                    txtcodigoCategoriaCliente.ReadOnly = True
                    txtcodigoListaPrecios.ReadOnly = True

                    btnBuscarListaPrecios.Enabled = True
                    btnCategoriaCliente.Enabled = False

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el tipo de clasificación.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_TipoClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objTipoCla As New ClsTipoClasificacion
        Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        rtxtcomentario.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            rtxtcomentario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            lblcodeCategoria.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            lblCodePriceList.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            If (lbltipo.Text = "Categoria") Then
                M_Categoria.txtcodigoTipo.Text = txtcodigo.Text
                M_Categoria.txtdescripcionTipo.Text = rtxtcomentario.Text
            ElseIf (lbltipo.Text = "ClasificacionContacto") Then
                M_ClasificacionContacto.txtcodigoTipo.Text = txtcodigo.Text
                M_ClasificacionContacto.txtcomentarioTipo.Text = rtxtcomentario.Text
            ElseIf (lbltipo.Text = "ClasificacionItem") Then
                E_ClasificacionItem.txtcodigoTipo.Text = txtcodigo.Text
                E_ClasificacionItem.txtcomentarioTipo.Text = rtxtcomentario.Text
            End If

            txtcomentarioB.ReadOnly = False
            rtxtcomentario.ReadOnly = False
            txtcodigo.ReadOnly = True
            txtcodigoCategoriaCliente.ReadOnly = False
            txtcodigoListaPrecios.ReadOnly = False
            btnCategoriaCliente.Enabled = True
            btnBuscarListaPrecios.Enabled = True
            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            'rtxtcomentario.ReadOnly = False
            'txtcodigo.ReadOnly = True
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lbltipo.Text = "Categoria") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el médico en la factura?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Categoria.txtcodigoTipo.Text = txtcodigo.Text
                    M_Categoria.txtdescripcionTipo.Text = rtxtcomentario.Text
                    Me.Close()
                End If
            ElseIf (lbltipo.Text = "ClasificacionContacto") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el tipo de clasificación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_ClasificacionContacto.txtcodigoTipo.Text = txtcodigo.Text
                    M_ClasificacionContacto.txtcomentarioTipo.Text = rtxtcomentario.Text
                    Me.Close()
                End If
            ElseIf (lbltipo.Text = "ClasificacionItem") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el tipo de clasificación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    E_ClasificacionItem.txtcodigoTipo.Text = txtcodigo.Text
                    E_ClasificacionItem.txtcomentarioTipo.Text = rtxtcomentario.Text
                    Me.Close()
                End If
            ElseIf (lbltipo.Text = "M_Cliente") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el tipo de clasificación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Cliente.txtcodigoClasificacion.Text = txtcodigo.Text
                    M_Cliente.txtnombreClasificacion.Text = rtxtcomentario.Text
                    M_Cliente.lblcodeCategoria.Text = lblcodeCategoria.Text
                    Me.Close()
                End If
            ElseIf (lbltipo.Text = "M_DiarioFacturacion") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el tipo de clasificación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_DiarioFacturacion.lblcodigoTipoClasif.Text = txtcodigo.Text
                    M_DiarioFacturacion.txtnombreClasificacion.Text = rtxtcomentario.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcomentarioB_TextChanged(sender As Object, e As EventArgs) Handles txtcomentarioB.TextChanged
        Dim objTipoCla As New ClsTipoClasificacion
        With objTipoCla
            .Comentario1 = txtcomentarioB.Text
        End With
        If (Trim(txtcomentarioB.Text) <> "") Then
            Dim dv As DataView = objTipoCla.BuscarTipoClasificacion.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Else
            Dim dv As DataView = objTipoCla.SeleccionarTipoClasificacion.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub txtcodigoCategoriaCliente_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoCategoriaCliente.TextChanged
        If (txtcodigoCategoriaCliente.Text <> "") Then
            Try
                Dim objCat As New ClsCategoria
                With objCat
                    .codigoCategoria_ = txtcodigoCategoriaCliente.Text
                End With
                Dim dt As New DataTable
                dt = objCat.BuscarCategoriaCode()
                Dim row As DataRow = dt.Rows(0)
                txtNombreCategoria.Text = CStr(row("descripcion"))
                lblcodeCategoria.Text = CStr(row("codigo"))
                txtcodigoCategoriaCliente.BackColor = Color.White
            Catch ex As Exception
                txtcodigoCategoriaCliente.BackColor = Color.Red
                lblcodeCategoria.Text = ""
                txtNombreCategoria.Text = ""
            End Try
        Else
            txtNombreCategoria.Text = ""
            lblcodeCategoria.Text = ""
            txtcodigoCategoriaCliente.BackColor = Color.Red
        End If
    End Sub
    Private Sub lblcodeCategoria_TextChanged(sender As Object, e As EventArgs) Handles lblcodeCategoria.TextChanged
        Try
            Dim objCat As New ClsCategoria
            With objCat
                .codigo_ = lblcodeCategoria.Text
            End With
            Dim dt As New DataTable
            dt = objCat.BuscarCategoriaNumero()
            Dim row As DataRow = dt.Rows(0)
            txtNombreCategoria.Text = CStr(row("descripcion"))
            txtcodigoCategoriaCliente.Text = CStr(row("codigoCategoriaCliente"))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
            txtNombreCategoria.ResetText()
            'txtcodigoCategoriaCliente.ResetText()
        End Try
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
                lblCodePriceList.Text = CStr(row("codigo"))
                txtcodigoListaPrecios.BackColor = Color.White
            Catch ex As Exception
                txtcodigoListaPrecios.BackColor = Color.Red
                txtdescripcionListaPrecios.Text = ""
                lblCodePriceList.Text = ""
            End Try
        Else
            'txtcodigoListaPrecios.Text = ""
            txtdescripcionListaPrecios.Text = ""
            lblCodePriceList.Text = ""
            txtcodigoListaPrecios.BackColor = Color.White
        End If
    End Sub
    Private Sub lblCodePriceList_TextChanged(sender As Object, e As EventArgs) Handles lblCodePriceList.TextChanged
        Try
            Dim dt As New DataTable
            Dim objPriceList As New ClsListaPrecios
            objPriceList.codigo_ = lblCodePriceList.Text
            dt = objPriceList.BuscarListaPreciosCodigo()
            Dim row As DataRow = dt.Rows(0)
            txtcodigoListaPrecios.Text = CStr(row("codigoBreve"))
            txtdescripcionListaPrecios.Text = CStr(row("descripcion"))
        Catch ex As Exception
            txtdescripcionListaPrecios.ResetText()
            'txtcodigoListaPrecios.ResetText()
        End Try
    End Sub

    Private Sub btnBuscarListaPrecios_Click(sender As Object, e As EventArgs) Handles btnBuscarListaPrecios.Click
        M_ListadoDePrecios.lblForm.Text = "TipoClasificacion"
        M_ListadoDePrecios.Show()
    End Sub

    Private Sub btnCategoriaCliente_Click(sender As Object, e As EventArgs) Handles btnCategoriaCliente.Click
        M_Categoria.lblform.Text = "TipoClasificacion"
        M_Categoria.Show()
    End Sub
End Class