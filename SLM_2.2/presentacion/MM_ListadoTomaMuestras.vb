Public Class MM_ListadoTomaMuestras
    Dim objToma As New ClsTomaDeMuestras
    Dim objPreg As New ClsPreguntasMuestra
    Private Sub M_BuscarRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTUALIZAR LISTADO
        listarTomaMuestra()

        'AGREGARLE COLOR AL DATAGRIDVIEW
        alternarColoFilasDatagridview(dgbtabla)

        'OCULTAR COLUMNAS
        'Me.dgbtabla.Columns("codExamen").Visible = False
        'Me.dgbtabla.Columns("codMuestra").Visible = False

        'CAMBIAS NOMBRE COLUMNAS
        dgbtabla.Columns("codMuestra").HeaderText = "Código Muestra"
        dgbtabla.Columns("codExamen").HeaderText = "Código Examen"
        dgbtabla.Columns("descripcion").HeaderText = "Descripción"

    End Sub
    Public Sub listarTomaMuestra()
        Dim dv As DataView = objToma.ListarTomaMuestras.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellDoubleClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver la toma de muestra?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                MM_TomaDeMuestras.limpiar()

                MM_TomaDeMuestras.txtCodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                MM_TomaDeMuestras.lblcodexamen.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                MM_TomaDeMuestras.txtDescripcion.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()

                objPreg.codMuestra_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                Dim dt As New DataTable
                dt = objPreg.BuscarPreguntasMuestraCodMuestra()
                Dim row As DataRow
                For index As Integer = 0 To dt.Rows.Count - 1
                    row = dt.Rows(index)
                    MM_TomaDeMuestras.dgvPreguntas.Rows.Add(New String() {CStr(row("codPregunta")), CStr(row("enunciado")), CStr(row("estado")), CStr(row("nota"))})
                Next

                MM_TomaDeMuestras.btnGuardar.Enabled = False
                MM_TomaDeMuestras.btnModificar.Enabled = True
                MM_TomaDeMuestras.lblEstado.Text = "Modificar"

                MM_TomaDeMuestras.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtCodMuestraB.TextChanged
        If (txtCodMuestraB.Text <> "") Then
            Try
                objToma.codMuestra_ = txtCodMuestraB.Text
                Dim dv As DataView = objToma.BuscarTomaDeMuestrasCodigo.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la toma de muestra.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            listarTomaMuestra()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionB.TextChanged
        If (txtDescripcionB.Text <> "") Then
            Try
                objToma.Descripcion_ = txtDescripcionB.Text
                Dim dv As DataView = objToma.BuscarTomaMuestraDescrip.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la toma de muestra.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            listarTomaMuestra()
        End If
    End Sub
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnueva.Click
        'Me.Close
        MM_TomaDeMuestras.limpiar()
        MM_TomaDeMuestras.ShowDialog()
    End Sub

End Class