Public Class E_GrupoExamen
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub M_GrupoExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objGrpE As New ClsGrupoExamen
        Dim dv As DataView = objGrpE.SeleccionarGrupoExamen.DefaultView
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
            If (lblform.Text = "E_DetalleExamenes") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el grupo de examen en el item facturable?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    E_DetalleExamenes.lblcodigoGrupo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value
                    E_DetalleExamenes.txtGrupo.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value
                    Me.Close()
                End If
            ElseIf (lblForm.Text = "M_DiarioFacturacion") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el área en el diario de facturación?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_ListaPrecios.lblcodeT.Text = lblcode.Text
                    M_DiarioFacturacion.txtGrupo.Text = txtnombre.Text
                    Me.Close()
                End If
            ElseIf (lblForm.Text = "A_PlantillasDeResultado") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el área en la plantilla de resultado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    A_PlantillasDeResultado.txtCodigoArea.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value
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
            txtcodigo.Text = sinDobleEspacio(txtcodigo.Text)
            txtnombre.Text = sinDobleEspacio(txtnombre.Text)

            If (Trim(txtcodigo.Text) <> "" And Trim(txtnombre.Text) <> "") Then
                Dim objGrpE As New ClsGrupoExamen
                With objGrpE
                    .codigoGrupoExamen_ = txtcodigo.Text
                    .Nombre_ = txtnombre.Text
                End With

                If objGrpE.RegistrarNuevaGrupoExamen() = 1 Then
                    MsgBox("Registrado correctamente.")

                    Dim dv As DataView = objGrpE.SeleccionarGrupoExamen.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer ingresar el grupo de examen.", MsgBoxStyle.Critical)
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
                Dim objGrpE As New ClsGrupoExamen
                With objGrpE
                    .codigoGrupoExamen_ = txtcodigo.Text
                    .Nombre_ = txtnombre.Text
                    .codigo_ = lblcode.Text
                End With
                If objGrpE.ModificarGrupoExamen() = 1 Then
                    MsgBox("Modificado correctamente.")

                    Dim dv As DataView = objGrpE.SeleccionarGrupoExamen.DefaultView
                    dgbtabla.DataSource = dv
                    lblcantidad.Text = dv.Count
                    dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

                    txtcodigo.ReadOnly = True
                    txtnombre.ReadOnly = True

                    btnmodificar.Enabled = False
                    btnguardar.Enabled = False
                    btnnuevo.Enabled = True
                Else
                    MsgBox("Error al querer modificar el grupo del examen.", MsgBoxStyle.Critical)
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
            Dim objGrpE As New ClsGrupoExamen
            With objGrpE
                .Nombre_ = txtnombreB.Text
            End With

            If (Trim(txtnombreB.Text) <> "") Then
                Dim dv As DataView = objGrpE.BuscarGrupoExamen.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                Dim dv As DataView = objGrpE.SeleccionarGrupoExamen.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class