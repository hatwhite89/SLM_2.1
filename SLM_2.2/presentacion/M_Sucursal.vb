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
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

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

            M_Factura.lblcodeSucursal.Text = lblcode.Text
            M_Factura.txtcodigoSucursal.Text = txtcodigo.Text
            M_Factura.txtnombreSucursal.Text = txtnombre.Text

            btnmodificar.Enabled = True

            txtnombre.ReadOnly = False
            txtcodigo.ReadOnly = False
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
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
        btnnuevo.Enabled = False
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
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
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

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
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

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
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objSuc.SeleccionarSucursal.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class