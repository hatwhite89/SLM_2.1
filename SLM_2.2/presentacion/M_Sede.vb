﻿Public Class M_Sede
    Private Sub btncancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtcorreo.Text() = ""
        txttelefono.Text() = ""
        rtxtdireccion1.Text() = ""
        rtxtdireccion2.Text() = ""
        rtxtdireccion3.Text() = ""
        rtxtdireccion4.Text() = ""
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""
        txtcontacto.Text() = ""

        txttelefono.ReadOnly = False
        txtnombre.ReadOnly = False
        txtcorreo.ReadOnly = False
        rtxtdireccion1.ReadOnly = False
        rtxtdireccion2.ReadOnly = False
        rtxtdireccion3.ReadOnly = False
        txtcodigo.ReadOnly = True
        rtxtdireccion4.ReadOnly = False
        txtcontacto.ReadOnly = False

        btnbuscar.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = False
    End Sub

    Private Sub deshabilitar()

        txttelefono.ReadOnly = True
        txtnombre.ReadOnly = True
        txtcorreo.ReadOnly = True
        rtxtdireccion1.ReadOnly = True
        rtxtdireccion2.ReadOnly = True
        rtxtdireccion3.ReadOnly = True
        txtcodigo.ReadOnly = True
        rtxtdireccion4.ReadOnly = True
        txtcontacto.ReadOnly = True

        btnbuscar.Enabled = True
        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub

    Private Function sinEspacios(ByVal cadena As String) As String
        Dim testString As String = cadena
        Dim texto As String = ""
        Dim testArray() As String = Split(testString)
        Dim lastNonEmpty As Integer = -1
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lastNonEmpty += 1
                testArray(lastNonEmpty) = testArray(i)
                texto += testArray(i) + " "
            End If
        Next
        ReDim Preserve testArray(lastNonEmpty)
        Return texto
    End Function
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim numero As Integer = 0
            If (rtxtdireccion1.Text <> "") Then
                numero += 1
                rtxtdireccion1.Text = sinEspacios(rtxtdireccion1.Text)
            ElseIf (rtxtdireccion2.Text <> "") Then
                numero += 1
                rtxtdireccion2.Text = sinEspacios(rtxtdireccion2.Text)
            ElseIf (rtxtdireccion3.Text <> "") Then
                numero += 1
                rtxtdireccion3.Text = sinEspacios(rtxtdireccion3.Text)
            ElseIf (rtxtdireccion4.Text <> "") Then
                numero += 1
                rtxtdireccion4.Text = sinEspacios(rtxtdireccion4.Text)
            Else
                numero = 0
            End If
            If (numero > 0 And txtnombre.Text <> "" And txtcorreo.Text <> "" And txttelefono.Text <> "" And txtcontacto.Text <> "") Then

                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objSede As New ClsSede
                With objSede
                    .Nombre1 = txtnombre.Text
                    .Direccion_1 = rtxtdireccion1.Text
                    .Direccion_2 = rtxtdireccion2.Text
                    .Direccion_3 = rtxtdireccion3.Text
                    .Direccion_4 = rtxtdireccion4.Text
                    .Contacto_1 = txtcontacto.Text
                    .Correo_1 = txtcorreo.Text
                    .Telefono_1 = txttelefono.Text
                End With

                If objSede.RegistrarNuevaSede() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objSede.SeleccionarSede.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    deshabilitar()
                Else
                    MsgBox("Error al querer ingresar la sede.", MsgBoxStyle.Critical)
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
            Dim numero As Integer = 0
            If (rtxtdireccion1.Text <> "") Then
                numero += 1
                rtxtdireccion1.Text = sinEspacios(rtxtdireccion1.Text)
            ElseIf (rtxtdireccion2.Text <> "") Then
                numero += 1
                rtxtdireccion2.Text = sinEspacios(rtxtdireccion2.Text)
            ElseIf (rtxtdireccion3.Text <> "") Then
                numero += 1
                rtxtdireccion3.Text = sinEspacios(rtxtdireccion3.Text)
            ElseIf (rtxtdireccion4.Text <> "") Then
                numero += 1
                rtxtdireccion4.Text = sinEspacios(rtxtdireccion4.Text)
            Else
                numero = 0
            End If
            If (numero > 0 And txtnombre.Text <> "" And txtcorreo.Text <> "" And txttelefono.Text <> "" And txtcontacto.Text <> "" And txtcodigo.Text <> "") Then

                'MsgBox("txtNombre: " + texto + ", correo:" + txtcorreo.Text() + ", tel: " + txttelefono.Text())
                Dim objSede As New ClsSede
                With objSede
                    .Codigo1 = txtcodigo.Text
                    .Nombre1 = txtnombre.Text
                    .Direccion_1 = rtxtdireccion1.Text
                    .Direccion_2 = rtxtdireccion2.Text
                    .Direccion_3 = rtxtdireccion3.Text
                    .Direccion_4 = rtxtdireccion4.Text
                    .Contacto_1 = txtcontacto.Text
                    .Correo_1 = txtcorreo.Text
                    .Telefono_1 = txttelefono.Text
                End With

                If objSede.ModificarSede() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objSede.SeleccionarSede.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    deshabilitar()
                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar la sede.", MsgBoxStyle.Critical)
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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim objSede As New ClsSede
        With objSede
            .Nombre1 = txtnombreB.Text
        End With
        Dim dv As DataView = objSede.BuscarSede.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            rtxtdireccion1.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            rtxtdireccion2.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            rtxtdireccion3.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            rtxtdireccion4.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            txtcontacto.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
            txtcorreo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()
            txttelefono.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(8).Value()

            M_Factura.txtcodigoSede.Text = txtcodigo.Text
            M_Factura.txtnombreSede.Text = txtnombre.Text

            btnmodificar.Enabled = True

            txttelefono.ReadOnly = False
            txtnombre.ReadOnly = False
            txtcorreo.ReadOnly = False
            rtxtdireccion1.ReadOnly = False
            rtxtdireccion2.ReadOnly = False
            rtxtdireccion3.ReadOnly = False
            txtcodigo.ReadOnly = True
            rtxtdireccion4.ReadOnly = False
            txtcontacto.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub M_Sede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSede As New ClsSede
        Dim dv As DataView = objSede.SeleccionarSede.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        deshabilitar()
    End Sub
End Class