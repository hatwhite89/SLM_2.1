Public Class E_SubArea
    'Objeto SubArea
    Dim SubA As New ClsSubArea

    Private Sub limpiar()
        txtCodigo.ResetText()
        txtNombre.ResetText()
        txtFormulario.ResetText()
        txtSecImpre.ResetText()
        txtSubArea.ResetText()
        chkConsolidado.Checked = False
        chkNoSolitar.Checked = False
        cmbxCodigoArea.SelectedValue = "1"

        txtNombre.ReadOnly = False
        txtFormulario.ReadOnly = False
        txtSecImpre.ReadOnly = False
        txtSubArea.ReadOnly = False
        chkConsolidado.Enabled = True
        chkNoSolitar.Enabled = True
        cmbxCodigoArea.Enabled = True

        btnGuardar.Enabled = True
        btnModificar.Enabled = False
    End Sub
    Private Sub deshabilitar()
        txtNombre.ReadOnly = True
        txtFormulario.ReadOnly = True
        txtSecImpre.ReadOnly = True
        txtSubArea.ReadOnly = True
        chkConsolidado.Enabled = False
        chkNoSolitar.Enabled = False
        cmbxCodigoArea.Enabled = False

        btnGuardar.Enabled = False
        btnModificar.Enabled = False
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub E_SubArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrupoExamen()
        limpiar()
        seleccionarSubAreas()
        Me.dgbtabla.Columns("Formulario").Visible = False
        Me.dgbtabla.Columns("secImpresion").Visible = False
        Me.dgbtabla.Columns("noSolicitarSucursal").Visible = False
        Me.dgbtabla.Columns("formularioConsolidado").Visible = False
    End Sub
    Private Sub seleccionarSubAreas()
        Try
            Dim dv As DataView = SubA.listarSubAreas.DefaultView
            dgbtabla.DataSource = dv
            lblcantidad.Text = dv.Count
            dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If Trim(txtNombre.Text) <> "" And Trim(txtSubArea.Text) <> "" Then

                'Capturar Variables
                With SubA
                    .Cod_SubArea = txtSubArea.Text
                    .Nombr_e = txtNombre.Text
                    .codigoArea_ = Integer.Parse(cmbxCodigoArea.SelectedValue)
                    .Formulari_o = txtFormulario.Text
                    .sec_Impresion = txtSecImpre.Text
                    .noSolicitar_Sucursal = chkNoSolitar.Checked
                    .formulario_Consolidado = chkConsolidado.Checked

                    'Procedimiento Ingreso
                    If .registrarNuevaSubArea() = 1 Then
                        MsgBox("Registrada la subárea correctamente.", MsgBoxStyle.Information)
                        deshabilitar()
                        seleccionarSubAreas()
                    Else
                        MsgBox("Error al momento de registrar la subárea en el sistema.", MsgBoxStyle.Critical)
                    End If

                End With

            Else
                MsgBox("Debe llenar los campos necesarios.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al registrar. Detalle: " + ex.Message)
        End Try
    End Sub
    Public Sub llenarGrupoExamen()
        'llenar el combo box CONTRATOS
        Try
            Dim objGroup As New ClsGrupoExamen
            Dim dt As New DataTable
            dt = objGroup.SeleccionarGrupoExamen

            cmbxCodigoArea.DataSource = dt
            cmbxCodigoArea.DisplayMember = "nombre"
            cmbxCodigoArea.ValueMember = "codigo"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If (lblform.Text = "M_PuestoTrabajo") Then
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar la subárea?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    'M_PuestoTrabajo.txtcodigoDepto.Text = txtcodigo.Text
                    'M_PuestoTrabajo.txtnombreDepto.Text = txtnombre.Text
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            limpiar()
            txtCodigo.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value()
            txtSubArea.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(1).Value()
            cmbxCodigoArea.SelectedValue = Me.dgbtabla.Rows(e.RowIndex).Cells(2).Value()
            txtNombre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(3).Value()
            txtFormulario.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(4).Value()
            txtSecImpre.Text = Me.dgbtabla.Rows(e.RowIndex).Cells(5).Value()
            chkNoSolitar.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(6).Value()
            chkConsolidado.Checked = Me.dgbtabla.Rows(e.RowIndex).Cells(7).Value()

            btnModificar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If Trim(txtNombre.Text) <> "" And Trim(txtSubArea.Text) <> "" And txtCodigo.Text <> "" Then
                'Capturar Variables
                With SubA
                    .Cod = Integer.Parse(txtCodigo.Text)
                    .Cod_SubArea = txtSubArea.Text
                    .Nombr_e = txtNombre.Text
                    .codigoArea_ = Integer.Parse(cmbxCodigoArea.SelectedValue)
                    .Formulari_o = txtFormulario.Text
                    .sec_Impresion = txtSecImpre.Text
                    .noSolicitar_Sucursal = chkNoSolitar.Checked
                    .formulario_Consolidado = chkConsolidado.Checked

                    'Procedimiento Ingreso
                    If .modificarSubArea() = 1 Then
                        MsgBox("Actualizada la subárea correctamente.", MsgBoxStyle.Information)
                        deshabilitar()
                        seleccionarSubAreas()
                    Else
                        MsgBox("Error al momento de actualizar la subárea en el sistema.", MsgBoxStyle.Critical)
                    End If

                End With

            Else
                MsgBox("Debe llenar los campos necesarios.", MsgBoxStyle.Information)
            End If


        Catch ex As Exception
            MessageBox.Show("Error al actualizar. Detalle: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCrearNuevo_Click(sender As Object, e As EventArgs) Handles btnCrearNuevo.Click
        limpiar()
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        Try

            SubA.Nombr_e = txtnombreB.Text

            If (Trim(txtnombreB.Text) <> "") Then
                Dim dv As DataView = SubA.BuscarSubAreaNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                seleccionarSubAreas()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class