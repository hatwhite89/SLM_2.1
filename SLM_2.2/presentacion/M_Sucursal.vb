Public Class M_Sucursal
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_Sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objSuc As New ClsSucursal
        Dim dv As DataView = objSuc.SeleccionarSucursal.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        alternarColoFilasDatagridview(dgbtabla)
        dgbtabla.Columns("codigo").Visible = False

        txtnombre.ReadOnly = True
        txtcodigo.ReadOnly = True

        btnmodificar.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            lblcode.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtcodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            txtnombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()

            btnmodificar.Enabled = True
            btnguardar.Enabled = False

            txtnombre.ReadOnly = False
            txtcodigo.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "factura") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sucursal en la factura?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_Factura.txtcodigoMedico.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Factura.lblcodeSucursal.Text = lblcode.Text
                    M_Factura.txtcodigoSucursal.Text = txtcodigo.Text
                    M_Factura.txtnombreSucursal.Text = txtnombre.Text
                    Me.Close()
                End If

            ElseIf lblform.Text = "Depreciacion" Then 'llenar campo sede de ventana Depreciación

                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sucursal en el registro de depreciación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    A_Depreciacion.txtSede.Text = txtcodigo.Text
                    Me.Close()
                End If

            ElseIf (lblform.Text = "M_MaquinasLocales") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sucursal en la máquina local?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_MaquinasLocales.lblcodeSucursal.Text = lblcode.Text
                    M_MaquinasLocales.txtcodigoSucursal.Text = txtcodigo.Text
                    M_MaquinasLocales.txtnombreSucursal.Text = txtnombre.Text
                    Me.Close()
                End If
            ElseIf (lblform.Text = "E_EspecificarHojaTrabajo") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sucursal en la máquina local?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    E_EspecificarHojaTrabajo.lblCodeSucursal.Text = lblcode.Text
                    E_EspecificarHojaTrabajo.txtSucursal.Text = txtcodigo.Text
                    E_EspecificarHojaTrabajo.txtDescripcionSucursal.Text = txtnombre.Text
                    Me.Close()
                End If

            ElseIf (lblform.Text = "A_FacturaCompras") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sucursal en la Factura de Compra?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then

                    With A_FacturaCompras

                        .dtDetalleFactura.Rows(Convert.ToInt32(A_FacturaCompras.lblFila.Text)).Cells(7).Value = lblcode.Text
                        .dtDetalleFactura.Rows(Convert.ToInt32(A_FacturaCompras.lblFila.Text)).Cells(3).Value = txtcodigo.Text

                    End With
                    Me.Close()
                End If
            ElseIf (lblform.Text = "M_DiarioFacturacion") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la sucursal en el diario de facturación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_DiarioFacturacion.txtnombreSucursal.Text = txtnombre.Text
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub limpiar()
        txtcodigo.Text() = ""
        txtnombre.Text() = ""
        txtnombreB.Text() = ""

        txtnombre.ReadOnly = False
        txtcodigo.ReadOnly = False

        btnmodificar.Enabled = False
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
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
            'validacion
            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "") Then
                txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
                txtnombre.Text = sinDobleEspacio(txtnombre.Text)
                Dim objSuc As New ClsSucursal
                With objSuc
                    .codigoSucursal_ = txtcodigo.Text
                    .Nombre1 = txtnombre.Text
                End With

                If objSuc.RegistrarNuevaSucursal() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objSuc.SeleccionarSucursal.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar la sucursal.", MsgBoxStyle.Critical)
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

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "") Then
                txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
                txtnombre.Text = sinDobleEspacio(txtnombre.Text)
                Dim objSuc As New ClsSucursal
                With objSuc
                    .codigoSucursal_ = txtcodigo.Text
                    .Nombre1 = txtnombre.Text
                    .codigo_ = lblcode.Text
                End With

                If objSuc.ModificarSucursal() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objSuc.SeleccionarSucursal.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar la sucursal.", MsgBoxStyle.Critical)
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
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try
            Dim objSuc As New ClsSucursal
            With objSuc
                .Nombre1 = txtnombreB.Text
            End With
            If (Trim(txtnombreB.Text) <> "") Then
                Dim dv As DataView = objSuc.BuscarSucursal.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                Dim dv As DataView = objSuc.SeleccionarSucursal.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GridAExcel(dgbtabla)
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
End Class