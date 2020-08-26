Public Class M_DiarioFacturacion
    Dim objFact As New ClsFactura
    Dim dv As DataView = objFact.SeleccionarDiarioFacturacion.DefaultView
    Private Sub limpiar()

    End Sub
    Private Sub M_DiarioFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Llenado de la tabla
            SeleccionarFacturas()
            Me.dgbtabla.Columns("codigoCliente").Visible = False
            Me.dgbtabla.Columns("codigoTerminoPago").Visible = False
            Me.dgbtabla.Columns("codigoMedico").Visible = False
            Me.dgbtabla.Columns("codigoCajero").Visible = False

            'llenar el combobox medico
            Dim objMed As New ClsMedico
            Dim dt As New DataTable
            dt = objMed.SeleccionarMedico()
            cbxMedico.DataSource = dt
            cbxMedico.DisplayMember = "nombre_completo"
            cbxMedico.ValueMember = "codigo"


            'llenar el combobox terminoPago
            Dim objTerm As New ClsTerminoPago
            Dim dt2 As New DataTable
            dt2 = objTerm.SeleccionarTerminoPago()
            cbxTerminoPago.DataSource = dt2
            cbxTerminoPago.DisplayMember = "descripcion"
            cbxTerminoPago.ValueMember = "codigo"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SeleccionarFacturas()
        dv = objFact.SeleccionarDiarioFacturacion.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub
    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblForm.Text = "M_ListaPrecios" Then
                'Dim n As String = ""
                'Dim temp As String = M_ListaPrecios.dgbtabla.Rows(lblFila.Text).Cells(2).Value()
                'If e.RowIndex >= 0 Then
                '    n = MsgBox("¿Desea utilizar el examen que a seleccionado?", MsgBoxStyle.YesNo, "Validación")
                'End If
                'If n = vbYes Then
                '    If Convert.ToInt64(lblFila.Text) >= 0 And temp <> "" Then
                '        M_ListaPrecios.dgbtabla.Rows.Remove(M_ListaPrecios.dgbtabla.Rows(lblFila.Text))
                '    End If
                '    M_ListaPrecios.dgbtabla.Rows.Insert(lblFila.Text, New String() {"", "", temp, dgbtabla.Rows(e.RowIndex).Cells(0).Value(), dgbtabla.Rows(e.RowIndex).Cells(1).Value()})
                '    Me.Close()
                'End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtnumeroB_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroB.TextChanged
        'dv.RowFilter = String.Format("numero Like '%{0}%'", txtnumeroB.Text)
        dv.RowFilter = "Convert(" & "numero" & ", 'System.String') LIKE '%" & txtnumeroB.Text & "%'"
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
            txtnumeroB.Text = ""
            SeleccionarFacturas()
        End If
    End Sub

    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        dv.RowFilter = String.Format("nombreCompleto Like '%{0}%'", txtnombreB.Text)
        lblcantidad.Text = dv.Count

        If lblcantidad.Text = "0" Then
            MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
            txtnombreB.Text = ""
            SeleccionarFacturas()
        End If
    End Sub

    Private Sub cbxMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMedico.SelectedIndexChanged
        Try
            dv.RowFilter = "Convert(" & "codigoMedico" & ", 'System.String') LIKE '%" & cbxMedico.SelectedValue & "%'"
            lblcantidad.Text = dv.Count

            If lblcantidad.Text = "0" Then
                MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
                txtnombreB.Text = ""
                SeleccionarFacturas()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Try
            Dim fecha As Date = dtpFecha.Value
            MsgBox(fecha & " entra " & dtpFecha.Value)
            'dv.RowFilter = "([fecha] = '" & dtpFecha.Value & "')"
            dv.RowFilter = "Convert(" & "fechaFactura" & ", 'System.String') LIKE '%" & fecha & "%'"
            lblcantidad.Text = dv.Count

            If lblcantidad.Text = "0" Then
                MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
                txtnombreB.Text = ""
                SeleccionarFacturas()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxTerminoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTerminoPago.SelectedIndexChanged
        Try
            dv.RowFilter = "Convert(" & "codigoTerminoPago" & ", 'System.String') LIKE '%" & cbxTerminoPago.SelectedValue & "%'"
            lblcantidad.Text = dv.Count

            If lblcantidad.Text = "0" Then
                MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
                txtnombreB.Text = ""
                SeleccionarFacturas()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        Try
            Dim bandera As Boolean = False
            If cmbEstado.SelectedItem = "Activa" Then
                MsgBox("activo")
                bandera = False
            ElseIf cmbEstado.SelectedItem = "Anulada" Then
                bandera = True
            End If
            dv.RowFilter = "Convert(" & "estado" & ", 'System.String') LIKE '%" & bandera & "%'"
            lblcantidad.Text = dv.Count

            If lblcantidad.Text = "0" Then
                MsgBox("No existe la factura.", MsgBoxStyle.Exclamation)
                txtnombreB.Text = ""
                SeleccionarFacturas()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class