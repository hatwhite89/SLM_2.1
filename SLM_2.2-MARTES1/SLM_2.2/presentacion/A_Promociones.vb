Imports System.Drawing.Imaging
Imports System.IO

Public Class A_Promociones

    Dim promo As New ClsPromociones
    Dim detallepromo As New ClsDetallePromociones
    Dim Imagen As String
    Dim img As Image
    Dim datos As Byte()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If dtDetallePromo.Rows.Count > 0 Then

            If txtDescrip.Text <> "" And txtPrecio.Text <> "" Then
                txtDescrip.BackColor = Color.White
                txtPrecio.BackColor = Color.White

                Try

                    With promo

                        .descripcion_ = txtDescrip.Text
                        .fechaInicio_ = dtpFechaI.Value
                        .fechaFinal_ = dtpFechaF.Value
                        .precio_ = Convert.ToDouble(txtPrecio.Text)
                        .imagen_ = txtRuta.Text

                        If .RegistrarPromocion = 1 Then

                            MsgBox("Se registro una nueva promoción.")

                        End If

                    End With

                    'Ingreso detalle de promo
                    Dim detalle As New ClsDetallePromociones

                    Dim dt As DataTable

                    dt = promo.capturarCodPromocion()

                    Dim row As DataRow = dt.Rows(0)
                    txtCod.Text = CStr(row("codigo"))
                    Dim fila As Integer

                    For fila = 0 To dtDetallePromo.Rows.Count

                        With detalle

                            .codigoExamen_ = Convert.ToInt32(dtDetallePromo.Rows(fila).Cells(0).Value)
                            .codigoPromocion_ = Convert.ToInt32(txtCod.Text)
                            If .RegistrarDetallePromocion <> 1 Then
                                MsgBox("Error al registrar el detalle.")
                            End If
                        End With

                    Next
                    LimpiarForma()
                Catch ex As Exception
                    MsgBox("Error al guardar o falta imagen de promoción. Detalle: " + ex.Message)
                End Try

            ElseIf txtDescrip.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtDescrip.BackColor = Color.Red
            ElseIf txtPrecio.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtPrecio.BackColor = Color.Red
            End If

        Else

            MsgBox("La promoción esta incompleta. Debe gregar exámenes y llenar todos los campos.")

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If dtDetallePromo.Rows.Count > 1 Then

            If txtDescrip.Text <> "" And txtPrecio.Text <> "" Then
                txtDescrip.BackColor = Color.White
                txtPrecio.BackColor = Color.White

                Try

                    With promo

                        .codigo_ = Convert.ToInt32(txtCod.Text)
                        .descripcion_ = txtDescrip.Text
                        .fechaInicio_ = dtpFechaI.Value
                        .fechaFinal_ = dtpFechaF.Value
                        .precio_ = Convert.ToDouble(txtPrecio.Text)
                        .imagen_ = txtRuta.Text

                        If .ModificarPromocion = 1 Then

                            MsgBox("Se modifico el registro.")

                        End If

                    End With

                    'Ingreso detalle de promo
                    Dim detalle As New ClsDetallePromociones

                    Dim dt As DataTable

                    dt = promo.capturarCodPromocion()

                    Dim row As DataRow = dt.Rows(0)
                    txtCod.Text = CStr(row("codigo"))
                    Dim fila As Integer

                    For fila = 0 To dtDetallePromo.Rows.Count

                        With detalle

                            .codigoExamen_ = Convert.ToInt32(dtDetallePromo.Rows(fila).Cells(0).Value)
                            .codigoPromocion_ = Convert.ToInt32(txtCod.Text)
                            If .RegistrarDetallePromocion <> 1 Then
                                MsgBox("Error al registrar el detalle.")
                            End If
                        End With

                    Next
                    LimpiarForma()
                Catch ex As Exception
                    MsgBox("Error al guardar o falta imagen de promoción. Detalle: " + ex.Message)
                End Try

            ElseIf txtDescrip.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtDescrip.BackColor = Color.Red
            ElseIf txtPrecio.Text = "" Then
                MsgBox("Existen campos vacíos.")
                txtPrecio.BackColor = Color.Red
            End If

        Else

            MsgBox("La promoción esta incompleta. Debe gregar exámenes y llenar todos los campos.")

        End If

    End Sub
    Private Sub btnBuscarImage_Click(sender As Object, e As EventArgs) Handles btnBuscarImage.Click
        SubirImagen()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        pbxPromo.Image = Nothing
    End Sub
    Sub SubirImagen() 'Metodo que selecciona imagen

        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then

                Imagen = OpenFileDialog1.FileName
                txtRuta.Text = Imagen.ToString
                Dim largo As Integer = Imagen.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                    pbxPromo.Load(Imagen)
                End If

                pbxPromo.Load(Imagen)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar la imagen." + ex.Message)
        End Try

    End Sub

    Private Sub txtDescrip_TextChanged(sender As Object, e As EventArgs) Handles txtDescrip.TextChanged
        txtDescrip.BackColor = Color.White
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        txtPrecio.BackColor = Color.White
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        A_ListarExamenes.ShowDialog()
    End Sub

    Sub LimpiarForma()

        Me.Close()
        Dim frm As New A_Promociones
        frm.Show()

    End Sub

    Public Function validarDetalle(ByVal codigoExamen As Integer)
        For index As Integer = 0 To dtDetallePromo.Rows.Count - 2
            If (dtDetallePromo.Rows(index).Cells(0).Value().ToString = codigoExamen) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    Private Sub A_Promociones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Presionar ESC para cerrar ventana
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub A_Promociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If txtCod.Text <> "" Then

                detallepromo.codigoPromocion_ = Convert.ToInt32(txtCod.Text)
                dtDetallePromo.DataSource = detallepromo.VerDetallePromocion()


                dtDetallePromo.Columns("Cod").Visible = False
                dtDetallePromo.Columns("Descrip").Visible = False
                dtDetallePromo.Columns("Descrip").Width = 300

            Else
                dtDetallePromo.Columns("Cod").Visible = True
                dtDetallePromo.Columns("Descrip").Visible = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        btnModificar.Enabled = False
        btnCrear.Enabled = False
        btnGuardar.Enabled = True
        dtDetallePromo.DataSource = Nothing
        dtDetallePromo.Columns("Cod").Visible = True
        dtDetallePromo.Columns("Descrip").Visible = True
        limpiar()

    End Sub

    Sub limpiar()

        Try
            txtCod.Text = ""
            dtpFechaF.Value = Date.Now
            dtpFechaI.Value = Date.Now
            txtDescrip.Text = ""
            pbxPromo.Image = Nothing
            txtPrecio.Text = ""
            txtRuta.Text = ""
            dtDetallePromo.Rows.Clear()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelarRegistro_Click(sender As Object, e As EventArgs) Handles btnCancelarRegistro.Click
        limpiar()
    End Sub

End Class