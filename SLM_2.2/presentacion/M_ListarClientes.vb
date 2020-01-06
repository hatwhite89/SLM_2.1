Public Class M_ListarClientes
    'Dim objCli As New ClsCliente
    'Dim dv As DataView = objCli.SeleccionarClientes.DefaultView
    Private Sub M_ListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarClientes()
        txtIdentidadB.Text = ""
        txtNombreB.Text = ""
        Me.dgbtabla.Columns("scanId").Visible = False
        Me.dgbtabla.Columns("rtn").Visible = False
        Me.dgbtabla.Columns("nombre1").Visible = False
        Me.dgbtabla.Columns("nombre2").Visible = False
        Me.dgbtabla.Columns("apellido1").Visible = False
        Me.dgbtabla.Columns("apellido2").Visible = False
        Me.dgbtabla.Columns("fechaNacimiento").Visible = False
        Me.dgbtabla.Columns("direccion").Visible = False
        Me.dgbtabla.Columns("telTrabajo").Visible = False
        Me.dgbtabla.Columns("correo2").Visible = False
        Me.dgbtabla.Columns("codigoClasificacion").Visible = False
        Me.dgbtabla.Columns("codigoCategoria").Visible = False
        Me.dgbtabla.Columns("codigoTerminoPago").Visible = False
        Me.dgbtabla.Columns("genero").Visible = False
    End Sub
    Private Sub SeleccionarClientes()
        Dim objCli As New ClsCliente
        Dim dv As DataView = objCli.SeleccionarClientes.DefaultView
        dv = objCli.SeleccionarClientes.DefaultView
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
            If n = vbYes And lblForm.Text = "" Then
                M_Cliente.limpiar()
                M_Cliente.txtcodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                M_Cliente.txtnombreCompleto.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                M_Cliente.txtcorreo.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                M_Cliente.txttelefonoCasa.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                M_Cliente.txtcelular.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                M_Cliente.mtxtidentidad.Text = dgbtabla.Rows(e.RowIndex).Cells(5).Value()

                M_Cliente.txtscanId.Text = dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                M_Cliente.txtrtn.Text = dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                M_Cliente.txtnombre1.Text = dgbtabla.Rows(e.RowIndex).Cells(8).Value()
                M_Cliente.txtnombre2.Text = dgbtabla.Rows(e.RowIndex).Cells(9).Value()
                M_Cliente.txtapellido1.Text = dgbtabla.Rows(e.RowIndex).Cells(10).Value()
                M_Cliente.txtapellido2.Text = dgbtabla.Rows(e.RowIndex).Cells(11).Value()
                M_Cliente.dtpfechaNacimiento.Text = dgbtabla.Rows(e.RowIndex).Cells(12).Value()

                M_Cliente.rtxtdireccion.Text = dgbtabla.Rows(e.RowIndex).Cells(13).Value()
                M_Cliente.txttelefonoTrabajo.Text = dgbtabla.Rows(e.RowIndex).Cells(14).Value()
                M_Cliente.txtcorreo2.Text = dgbtabla.Rows(e.RowIndex).Cells(15).Value()
                M_Cliente.txtcodigoClasificacion.Text = dgbtabla.Rows(e.RowIndex).Cells(16).Value()
                M_Cliente.lblcodeCategoria.Text = dgbtabla.Rows(e.RowIndex).Cells(17).Value()
                M_Cliente.lblcodeTerminoPago.Text = dgbtabla.Rows(e.RowIndex).Cells(18).Value()

                If (dgbtabla.Rows(e.RowIndex).Cells(19).Value() = "Masculino") Then
                    M_Cliente.rbtnmasculino.Checked = True
                ElseIf (dgbtabla.Rows(e.RowIndex).Cells(19).Value() = "Femenino") Then
                    M_Cliente.rbtnfemenino.Checked = True
                Else
                    M_Cliente.rbtnmasculino.Checked = False
                    M_Cliente.rbtnfemenino.Checked = False
                End If
                M_Cliente.gbxinfoCliente.Visible = True
                M_Cliente.ShowDialog()
            ElseIf n = vbYes And lblForm.Text = "VerPaciente" Then
                M_VerPaciente.limpiar()
                'conseguir la edad del paciente
                Dim yr As Integer = DateDiff(DateInterval.Year, dgbtabla.Rows(e.RowIndex).Cells(12).Value(), Now)
                'Dim month As Integer = DateDiff(DateInterval.Month, dgbtabla.Rows(e.RowIndex).Cells(12).Value(), Now) Mod 12
                M_VerPaciente.txtEdad.Text = yr & " a"

                M_VerPaciente.txtcodigo.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                M_VerPaciente.txtnombreCompleto.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                M_VerPaciente.txtcorreo.Text = dgbtabla.Rows(e.RowIndex).Cells(2).Value()
                M_VerPaciente.txttelefonoCasa.Text = dgbtabla.Rows(e.RowIndex).Cells(3).Value()
                M_VerPaciente.txtcelular.Text = dgbtabla.Rows(e.RowIndex).Cells(4).Value()
                M_VerPaciente.mtxtidentidad.Text = dgbtabla.Rows(e.RowIndex).Cells(5).Value()

                M_VerPaciente.txtscanId.Text = dgbtabla.Rows(e.RowIndex).Cells(6).Value()
                M_VerPaciente.txtrtn.Text = dgbtabla.Rows(e.RowIndex).Cells(7).Value()
                M_VerPaciente.txtnombre1.Text = dgbtabla.Rows(e.RowIndex).Cells(8).Value()
                M_VerPaciente.txtnombre2.Text = dgbtabla.Rows(e.RowIndex).Cells(9).Value()
                M_VerPaciente.txtapellido1.Text = dgbtabla.Rows(e.RowIndex).Cells(10).Value()
                M_VerPaciente.txtapellido2.Text = dgbtabla.Rows(e.RowIndex).Cells(11).Value()
                M_VerPaciente.dtpfechaNacimiento.Text = dgbtabla.Rows(e.RowIndex).Cells(12).Value()

                M_VerPaciente.rtxtdireccion.Text = dgbtabla.Rows(e.RowIndex).Cells(13).Value()
                M_VerPaciente.txttelefonoTrabajo.Text = dgbtabla.Rows(e.RowIndex).Cells(14).Value()
                M_VerPaciente.txtcorreo2.Text = dgbtabla.Rows(e.RowIndex).Cells(15).Value()
                M_VerPaciente.txtcodigoClasificacion.Text = dgbtabla.Rows(e.RowIndex).Cells(16).Value()
                M_VerPaciente.lblcodeCategoria.Text = dgbtabla.Rows(e.RowIndex).Cells(17).Value()
                M_VerPaciente.lblcodeTerminoPago.Text = dgbtabla.Rows(e.RowIndex).Cells(18).Value()

                If (dgbtabla.Rows(e.RowIndex).Cells(19).Value() = "Masculino") Then
                    M_VerPaciente.rbtnmasculino.Checked = True
                ElseIf (dgbtabla.Rows(e.RowIndex).Cells(19).Value() = "Femenino") Then
                    M_VerPaciente.rbtnfemenino.Checked = True
                Else
                    M_VerPaciente.rbtnmasculino.Checked = False
                    M_VerPaciente.rbtnfemenino.Checked = False
                End If
                M_VerPaciente.gbxinfoCliente.Visible = True
                M_VerPaciente.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub txtIdentidadB_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidadB.TextChanged
    '    dv.RowFilter = String.Format("Identidad Like '%{0}%'", txtIdentidadB.Text)
    '    lblcantidad.Text = dv.Count


    '    If lblcantidad.Text = "0" Then
    '        MsgBox("No existe el paciente.", MsgBoxStyle.Exclamation)
    '        txtIdentidadB.Text = ""
    '        SeleccionarClientes()
    '    End If
    'End Sub

    'Private Sub txtNombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
    '    dv.RowFilter = String.Format("Nombre Like '%{0}%'", txtNombreB.Text)
    '    lblcantidad.Text = dv.Count


    '    If lblcantidad.Text = "0" Then
    '        MsgBox("No existe el paciente.", MsgBoxStyle.Exclamation)
    '        txtNombreB.Text = ""
    '        SeleccionarClientes()
    '    End If
    'End Sub

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

    Private Sub txtIdentidadB_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidadB.TextChanged
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
End Class