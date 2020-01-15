Public Class M_Categoria
    Private Sub btnbuscarTipo_Click(sender As Object, e As EventArgs)
        M_TipoClasificacion.ShowDialog()
    End Sub
    Private Sub M_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCategoria As New ClsCategoria
        Dim dv As DataView = objCategoria.SeleccionarCategoria.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        dgbtabla.Columns("codigo").Visible = False

        rtxtdescripcion.ReadOnly = True
        txtcodigoTipo.ReadOnly = True
        txtcodigo.ReadOnly = True

        'btnbuscarEspecialidad.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtcodigoTipo.Text() = ""
        txtdescripcionB.Text() = ""
        txtdescripcionTipo.Text() = ""
        rtxtdescripcion.Text() = ""
        txtcodigoListaPrecios.Text = ""
        txtdescripcionListaPrecios.Text = ""
        lblCodePriceList.Text = ""

        txtcodigoTipo.ReadOnly = False
        txtdescripcionB.ReadOnly = False
        rtxtdescripcion.ReadOnly = False
        txtcodigo.ReadOnly = False
        txtcodigoListaPrecios.ReadOnly = False

        btnbuscarTipo.Enabled = True
        btnBuscarListaPrecios.Enabled = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtcodigoListaPrecios.Text) <> "" And txtcodigoListaPrecios.BackColor = Color.White And Trim(txtcodigoTipo.Text) <> "" And txtcodigoTipo.BackColor = Color.White And Trim(txtcodigo.Text) <> "") Then

                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objCategoriaif As New ClsCategoria
                With objCategoriaif
                    .descripcion1 = rtxtdescripcion.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                    .codigoCategoria_ = txtcodigo.Text
                    .codigoListaPrecios_ = lblCodePriceList.Text
                End With

                If objCategoriaif.RegistrarNuevaCategoria() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objCategoriaif.SeleccionarCategoria.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtdescripcion.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True
                    txtcodigo.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar la clasificación del contacto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
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
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try

            If (Trim(rtxtdescripcion.Text) <> "" And Trim(txtcodigoListaPrecios.Text) <> "" And txtcodigoListaPrecios.BackColor = Color.White And Trim(txtcodigoTipo.Text) <> "" And txtcodigoTipo.BackColor = Color.White And Trim(txtcodigo.Text) <> "") Then

                rtxtdescripcion.Text = sinDobleEspacio(rtxtdescripcion.Text)
                Dim objCategoriaif As New ClsCategoria
                With objCategoriaif
                    .descripcion1 = rtxtdescripcion.Text
                    .codigoCategoria_ = txtcodigo.Text
                    .CodigoTipo1 = txtcodigoTipo.Text
                    .codigo_ = lblcode.Text
                    .codigoListaPrecios_ = lblCodePriceList.Text
                End With

                If objCategoriaif.ModificarCategoria() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objCategoriaif.SeleccionarCategoria.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    rtxtdescripcion.ReadOnly = True
                    txtcodigoTipo.ReadOnly = True
                    txtcodigo.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar la clasificación del contacto.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtdescripcion.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtcodigoTipo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            lblCodePriceList.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()

            M_Cliente.lblcodeCategoria.Text = lblcode.Text
            M_Cliente.txtcodigoCategoria.Text = txtcodigo.Text
            M_Cliente.txtnombreCategoria.Text = rtxtdescripcion.Text

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            rtxtdescripcion.ReadOnly = False
            txtcodigoTipo.ReadOnly = False
            txtcodigo.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub txtcodigoTipo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoTipo.TextChanged
        txtdescripcionTipo.Text = ""
        If (Trim(txtcodigoTipo.Text) <> "") Then
            Try
                Dim objTipoClas As New ClsTipoClasificacion
                With objTipoClas
                    .Codigo1 = txtcodigoTipo.Text
                End With
                Dim dt As New DataTable
                dt = objTipoClas.BuscarTipoClasificacionCode()
                Dim row As DataRow = dt.Rows(0)
                txtdescripcionTipo.Text = CStr(row("comentario"))
                txtcodigoTipo.BackColor = Color.White
            Catch ex As Exception
                txtcodigoTipo.BackColor = Color.Red
                txtdescripcionTipo.Text = ""
            End Try
        Else
            txtcodigoTipo.Text = ""
            txtdescripcionTipo.Text = ""
            txtcodigoTipo.BackColor = Color.White
        End If
    End Sub
    Private Sub btnbuscarTipo_Click_1(sender As Object, e As EventArgs) Handles btnbuscarTipo.Click
        M_TipoClasificacion.lbltipo.Text = "Categoria"
        M_TipoClasificacion.ShowDialog()
    End Sub

    Private Sub txtdescripcionB_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcionB.TextChanged
        Try

            Dim objCategoria As New ClsCategoria
            With objCategoria
                .descripcion1 = txtdescripcionB.Text
            End With
            If (Trim(txtdescripcionB.Text) <> "") Then
                Dim dv As DataView = objCategoria.BuscarCategoria.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objCategoria.SeleccionarCategoria.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

        Catch ex As Exception

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
            txtcodigoListaPrecios.Text = ""
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

        End Try
    End Sub

    Private Sub btnBuscarListaPrecios_Click(sender As Object, e As EventArgs) Handles btnBuscarListaPrecios.Click
        M_ListadoDePrecios.lblForm.Text = "Categoria"
        M_ListadoDePrecios.ShowDialog()
    End Sub
End Class