Imports System.Drawing.Imaging
Imports System.IO

Public Class A_Promociones

    Dim promo As New ClsPromociones
    Dim Imagen As String
    Dim datos_ As Byte


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If dtDetallePromo.Rows.Count > 1 Then





            If txtDescrip.Text <> "" And txtPrecio.Text <> "" Then
                txtDescrip.BackColor = Color.White
                txtPrecio.BackColor = Color.White

                Try

                    With promo

                        .descripcion_ = txtDescrip.Text
                        .fechaInicio_ = dtpFechaI.Value
                        .fechaFinal_ = dtpFechaF.Value
                        .precio_ = Convert.ToDouble(txtPrecio.Text)

                        'Guardar imagen
                        Dim ms As New MemoryStream
                        pbxPromo.Image.Save(ms, pbxPromo.Image.RawFormat)

                        .img_ = ms.GetBuffer

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

                    For fila = 0 To dtDetallePromo.Rows.Count - 2

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





        'Limpiar todo



    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'Modificar promocion
        Try

            With promo

                .codigo_ = Convert.ToInt64(txtCod.Text)
                .descripcion_ = txtDescrip.Text
                .fechaInicio_ = dtpFechaI.Value
                .fechaFinal_ = dtpFechaF.Value
                .precio_ = Convert.ToDouble(txtPrecio.Text)

                'Guardar imagen
                Dim ms As New MemoryStream
                pbxPromo.Image.Save(ms, pbxPromo.Image.RawFormat)

                .img_ = ms.GetBuffer

                If .RegistrarPromocion = 1 Then

                    MsgBox("La edición del registro fue exitosa.")

                End If

            End With

        Catch ex As Exception
            MsgBox("Error al editar. Detalle: " + ex.Message)
        End Try

    End Sub
    Private Sub btnBuscarImage_Click(sender As Object, e As EventArgs) Handles btnBuscarImage.Click
        SubirImagen()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pbxPromo.Image = Nothing
    End Sub
    Sub SubirImagen() 'Metodo que selecciona imagen

        Try

            ofdImagen.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes bitmaps|*.bmp|Imagenes JPEG|*.jpeg"

            If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then

                pbxPromo.Image = Image.FromFile(ofdImagen.FileName)

            End If

        Catch ex As Exception
            MsgBox("No se selecciono una imagen o hubo un error al intentarlo. Detalle: " + ex.Message)
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

    Private Sub A_Promociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class