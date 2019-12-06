Public Class M_ListarClientes
    Private Sub M_ListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarClientes()
        'Me.dgbtabla.Columns("codigo").Visible = False
    End Sub
    Private Sub SeleccionarClientes()
        Dim objCli As New ClsCliente
        Dim dv As DataView = objCli.SeleccionarClientes.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver los datos del paciente?", MsgBoxStyle.YesNo, "Validación")
            End If
            If n = vbYes Then
                M_Recibo.dgbtabla.Rows.Add(New String() {"0", dgbtabla.Rows(e.RowIndex).Cells(1).Value(), dgbtabla.Rows(e.RowIndex).Cells(5).Value(), dgbtabla.Rows(e.RowIndex).Cells(6).Value(), dgbtabla.Rows(e.RowIndex).Cells(3).Value(), "LPS", dgbtabla.Rows(e.RowIndex).Cells(7).Value(), "LPS", dgbtabla.Rows(e.RowIndex).Cells(7).Value()})
                M_Cliente.txtcodigo.Text = ""
                M_Cliente.txtnombreCompleto.Text = ""
                M_Cliente.txtscanId.Text = ""
                M_Cliente.mtxtidentidadClienteB.Text = ""
                M_Cliente.txtrtn.Text = ""
                M_Cliente.txtnombre1.Text = ""
                M_Cliente.txtnombre2.Text = ""
                M_Cliente.txtapellido1.Text = ""
                M_Cliente.txtapellido2.Text = ""
                M_Cliente.dtpfechaNacimiento.Text = ""

                M_Cliente.rtxtdireccion.Text = ""
                M_Cliente.txttelefonoCasa.Text = ""
                M_Cliente.txttelefonoTrabajo.Text = ""
                M_Cliente.txtcelular.Text = ""
                M_Cliente.txtcorreo.Text = ""
                M_Cliente.txtcorreo2.Text = ""
                M_Cliente.txtcodigoClasificacion.Text = ""
                M_Cliente.lblcodeCategoria.Text = ""
                M_Cliente.lblcodeTerminoPago.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "    subir", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidadB.TextChanged
        If (txtIdentidadB.Text <> "") Then
            Try
                Dim objCli As New ClsCliente
                objCli.Identidad1 = txtIdentidadB.Text
                Dim dv As DataView = objCli.BuscarCliente.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            SeleccionarClientes()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        If (txtNombreB.Text <> "") Then
            Try
                Dim objCli As New ClsCliente
                objCli.NombreCompleto1 = txtNombreB.Text
                Dim dv As DataView = objCli.BuscarClienteNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la factura.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            SeleccionarClientes()
        End If
    End Sub

End Class