﻿Public Class M_Sede
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

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
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

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
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
            Dim numero As Integer = 0
            If (Trim(rtxtdireccion1.Text) <> "") Then
                numero += 1
                rtxtdireccion1.Text = sinDobleEspacio(rtxtdireccion1.Text)
            End If
            If (Trim(rtxtdireccion2.Text) <> "") Then
                numero += 1
                rtxtdireccion2.Text = sinDobleEspacio(rtxtdireccion2.Text)
            End If
            If (Trim(rtxtdireccion3.Text) <> "") Then
                numero += 1
                rtxtdireccion3.Text = sinDobleEspacio(rtxtdireccion3.Text)
            End If
            If (Trim(rtxtdireccion4.Text) <> "") Then
                numero += 1
                rtxtdireccion4.Text = sinDobleEspacio(rtxtdireccion4.Text)
            End If

            If (numero > 0 And Trim(txtnombre.Text) <> "") Then
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
                    'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

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
            If (Trim(rtxtdireccion1.Text) <> "") Then
                numero += 1
                rtxtdireccion1.Text = sinDobleEspacio(rtxtdireccion1.Text)
            End If
            If (Trim(rtxtdireccion2.Text) <> "") Then
                numero += 1
                rtxtdireccion2.Text = sinDobleEspacio(rtxtdireccion2.Text)
            End If
            If (Trim(rtxtdireccion3.Text) <> "") Then
                numero += 1
                rtxtdireccion3.Text = sinDobleEspacio(rtxtdireccion3.Text)
            End If
            If (Trim(rtxtdireccion4.Text) <> "") Then
                numero += 1
                rtxtdireccion4.Text = sinDobleEspacio(rtxtdireccion4.Text)
            End If
            If (numero > 0 And Trim(txtnombre.Text) <> "" And txtcodigo.Text <> "") Then
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
                    'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

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
        limpiar()
        Me.Close()
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs)
        Dim objSede As New ClsSede
        With objSede
            .Nombre1 = txtnombreB.Text
        End With
        Dim dv As DataView = objSede.BuscarSede.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
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

            'M_Factura.txtcodigoSede.Text = txtcodigo.Text
            'M_Factura.txtnombreSede.Text = txtnombre.Text

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

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
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "factura") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sede en la factura?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Factura.txtcodigoSede.Text = txtcodigo.Text
                    M_Factura.txtnombreSede.Text = txtnombre.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_Sede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSede As New ClsSede
        Dim dv As DataView = objSede.SeleccionarSede.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        deshabilitar()
        alternarColoFilasDatagridview(dgbtabla)
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Dim objSede As New ClsSede
        With objSede
            .Nombre1 = txtnombreB.Text
        End With
        Dim dv As DataView = objSede.BuscarSede.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        'dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If GridAExcel(dgbtabla) Then
            MsgBox("Exportado a Excel con éxito.", MsgBoxStyle.Information, "Validación.")
        End If
    End Sub
    Function GridAExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add 'crea el libro de excel 
            exHoja = exLibro.Worksheets.Add() 'cuenta filas y columnas
            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            exHoja.Rows.Item(1).Font.Bold = 1 'titulo en negritas
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            'alineacion al centro
            exHoja.Columns.AutoFit() 'autoajuste de la columna
            exHoja.Columns.HorizontalAlignment = 2
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        M_Factura.Show()
    End Sub
End Class