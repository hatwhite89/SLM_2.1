Imports System.Drawing.Imaging
Imports System.IO

Public Class A_Promociones

    Dim promo As New ClsPromociones
    Dim Imagen As String
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click





        Try

            With promo

                .descripcion_ = txtDescrip.Text
                .fechaInicio_ = dtpFechaI.Value
                .fechaInicio_ = dtpFechaF.Value
                .img_ = pbxPromo.Image
                .precio_ = Convert.ToDouble(txtPrecio.Text)

                .RegistrarPromocion()

            End With





        Catch ex As Exception

        End Try




    End Sub

    Private Sub btnBuscarImage_Click(sender As Object, e As EventArgs) Handles btnBuscarImage.Click
        SubirImagen()
    End Sub





    Sub SubirImagen() 'Metodo que selecciona imagen
        Try

            Dim myFileDialog As New OpenFileDialog()
            myFileDialog.ShowDialog()
            If myFileDialog.FileName <> "" Then

                Imagen = myFileDialog.FileName
                Dim largo As Integer = Imagen.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
        pbxPromo.Load(Imagen)
    End Sub


End Class